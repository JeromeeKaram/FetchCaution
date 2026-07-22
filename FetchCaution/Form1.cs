using HtmlAgilityPack;
using System;
using System.Diagnostics;
using System.Security.Policy;
using System.Text;

namespace FetchCaution
{
    public partial class Form1 : Form
    {
        private string OUTPUT_FILENAME = "CautionsList.xlsx";
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnFetchCaution_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUrl.Text))
            {
                MessageBox.Show("Please enter a URL.");
                return;
            }

            if (!ValidateOutputFolder(txtOutPutPath))
                return;

            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;
            progressBar1.Visible = true;
            try
            {
                await Task.Run(() =>
                {
                    var url = txtUrl.Text;

                    var fileNames = fetchLinks(url);
                    //var url = "http://127.0.0.1:8000/PW1000G-77445-19453-00/PW1100G-A-72-00-21-04A-520A-B.html"; - 1 item
                    //var url = "http://127.0.0.1:8000/PW1000G-77445-19453-00/PW1100G-A-72-11-00-01A-709A-B.html"; - 2 items
                    //var url = "http://127.0.0.1:8000/PW1000G-77445-19453-00/PW1100G-A-72-11-01-00A-520A-D.html"; - 3 items

                    var cautionList = new List<Caution>();

                    bool cautionsForEM = true;

                    if (cautionsForEM == true)
                    {
                         fileNames = fileNames
    .Where(x => x.Split('-').Length > 5 &&
                x.Split('-')[5].StartsWith("3"))
    .ToList();
                    }

                    foreach (var fileName in fileNames)
                    {
                        var newUrl = url.Substring(0, url.LastIndexOf('/') + 1) + fileName;
                        var cautions = FetchCautions(newUrl);
                        cautionList.AddRange(cautions);
                    }

                    var columnNames = new List<string> { "DMC", "Title", "CautionText" };

                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
#if DEBUG
                    var excelInstance = ExcelUtility.CreateExcelWithColumns(txtOutPutPath.Text, columnNames, "Cautions", "NoCautions");
#else
                    var excelInstance = ExcelUtility.CreateExcelWithColumns(txtOutPutPath.Text, columnNames, "Cautions");
#endif
                    var allCautions = cautionList.Where(c => c.CautionText != "No Caution Text Found.").ToList();
                    var noCautions = cautionList.Where(c => c.CautionText == "No Caution Text Found.").ToList();
                    ExcelUtility.SVCWriteOldSheet_EPPlus1(excelInstance, allCautions, "Cautions");
#if DEBUG
                    ExcelUtility.SVCWriteOldSheet_EPPlus1(excelInstance, noCautions, "NoCautions");
#endif
                    excelInstance.Save();

                    MessageBox.Show("Finished Fetching Cautions");

                    // Open the Excel file
                    Process.Start(new ProcessStartInfo(txtOutPutPath.Text)
                    {
                        UseShellExecute = true
                    });
                });
            }
            finally
            {
                progressBar1.Visible = false;
            }
        }


        public bool ValidateOutputFolder(TextBox textBox)
        {
            string path = textBox.Text?.Trim();

            // Check empty
            if (string.IsNullOrWhiteSpace(path))
            {
                MessageBox.Show("Output folder path cannot be empty.");
                textBox.Focus();
                return false;
            }

            if (!path.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show($"Output file must be an Excel file (.xlsx). Please select a valid file.");
                textBox.Focus();
                return false;
            }

            // Check invalid filename characters
            string fileName = Path.GetFileName(path);

            if (fileName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                MessageBox.Show($"Output file contains invalid characters.");
                textBox.Focus();
                return false;
            }

            // Validate path format
            try
            {
                Path.GetFullPath(path);
            }
            catch
            {
                MessageBox.Show("Invalid folder path format.");
                textBox.Focus();
                return false;
            }

            return true;
        }

        private List<string> fetchLinks(string url)
        {
            //url - http://127.0.0.1:8000/PW1000G-77445-19453-00/PW1000G-77445-15653-00.html
            List<ModuleInfo> lstmods = extract_task(url);
            List<string> fileNames = new List<string>();
            foreach (ModuleInfo mod in lstmods)
            {
                foreach (TaskInfo task in mod.m_lstTasks)
                {
                    fileNames.Add(task.m_sHtmlLink);
                }
            }

            return fileNames;
        }

        private List<ModuleInfo> extract_task(string path)
        {
            List<ModuleInfo> lstmods = new List<ModuleInfo>();
            try
            {

                using (var client = new System.Net.WebClient())
                {
                    string contents = client.DownloadString(path);
                    string[] sArrHrefs = contents.Split(new string[1] { "<a href=\"#\">" }, StringSplitOptions.None);
                    for (int x = 1; x < sArrHrefs.Length; x++)
                    {
                        string href = sArrHrefs[x];
                        if (href.Contains("class=\"navDocLink\">"))
                        {
                            //Get the title
                            string title = SplitString(href, "<")[0];

                            //Get the Htmls
                            List<string> lstlinks = new List<string>();
                            List<string> lstSplits1 = SplitString(href, "class=\"navDocLink\">");
                            for (int k = 0; k < lstSplits1.Count; k++)
                            {
                                List<string> lstSplits2 = SplitString(lstSplits1[k], new string[2] { "href=", " " }, false);
                                foreach (string html in lstSplits2)
                                {
                                    string html1 = html.Replace("data-dmc=", "").Replace("\"", "").Trim();
                                    if (html1.EndsWith(".html") && lstlinks.Contains(html1) == false)
                                    {
                                        lstlinks.Add(html1);
                                    }
                                }
                            }
                            //Add
                            lstmods.Add(new ModuleInfo(title, lstlinks));
                        }
                    }
                }
            }
            catch (Exception ee)
            {
                //Utility.WriteErrorLog("", ee.Message, ee.StackTrace);
            }
            return lstmods;
        }

        List<string> SplitString(string sValue, string schar)
        {
            List<string> lst = new List<string>();
            try
            {
                string[] sArr = sValue.Split(new string[1] { schar }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string ss in sArr)
                {
                    if (ss.Trim().Length > 0)
                    {
                        lst.Add(ss.Trim());
                    }
                }
            }
            catch (Exception ee)
            {
                //Utility.WriteErrorLog(ee);
            }
            return lst;
        }

        List<string> SplitString(string sValue, string[] schars, bool Toupper)
        {
            List<string> lst = new List<string>();
            try
            {
                string[] sArr = sValue.Split(schars, StringSplitOptions.RemoveEmptyEntries);
                foreach (string ss in sArr)
                {
                    if (ss.Trim().Length > 0)
                    {
                        if (Toupper == false)
                            lst.Add(ss.Trim());
                        else
                            lst.Add(ss.ToUpper().Trim());
                    }
                }
            }
            catch (Exception ee)
            {
                //Utility.WriteErrorLog(ee);
            }
            return lst;
        }

        private List<Caution> FetchCautions(string url)
        {
            var web = new HtmlWeb();
            var doc = web.Load(url);

            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(new Uri(url).AbsolutePath);

            var dmc = fileNameWithoutExtension;

            var h1Node = doc.DocumentNode.SelectSingleNode("//div[@class='header']/h1");

            var title = "";
            if (h1Node != null)
            {
                title = h1Node.InnerText.Trim();
            }

            var cautionNodes = doc.DocumentNode.SelectNodes(
    ".//div[contains(@class,'cautionOuterContainer')]//div[contains(concat(' ', normalize-space(@class), ' '), ' cautionText ')]");

            var cautionsText = new List<string>();

            if (cautionNodes != null)
            {
                foreach (var cautionNode in cautionNodes)
                {
                    cautionsText.Add(
                        HtmlEntity.DeEntitize(cautionNode.InnerText.Trim()));
                }
            }

            var cautionList = new List<Caution>();
            if (cautionsText.Any())
            {
                foreach (var cautionText in cautionsText)
                {
                    cautionList.Add(new Caution
                    {
                        DMC = dmc,
                        Title = title,
                        CautionText = cautionText,
                        NewUrl = url
                    });
                }
            }
            else
            {
                cautionList.Add(new Caution
                {
                    DMC = dmc,
                    Title = title,
                    CautionText = "No Caution Text Found.",
                    NewUrl = url
                });
            }

            return cautionList;
        }

        private void btnBrowseOutputPath_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog folderDialog = new SaveFileDialog())
            {
                folderDialog.FileName = OUTPUT_FILENAME;
                folderDialog.Title = "Select output file path";
                folderDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderDialog.FileName;
                    txtOutPutPath.Text = selectedPath;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
#if DEBUG
            //txtUrl.Text = "http://127.0.0.1:8000/PW1000G-77445-19453-00/PW1000G-77445-15653-00.html"; //EM_CIR
            txtUrl.Text = "http://127.0.0.1:8003/PW1000G-77445-19453-00/PW1000G-77445-16992-00.html"; //EM
            //txtUrl.Text = "http://127.0.0.1:8004/PW1000G-77445-19155-00/"; //SP_CIR_72_35
            //txtUrl.Text = "http://127.0.0.1:8005/PW1000G-77445-19156-00/"; //SP_CIR_72_51
#endif
        }
    }
}
