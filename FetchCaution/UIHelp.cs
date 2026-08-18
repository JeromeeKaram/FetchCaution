using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVC.About
{
    public partial class UIHelp : Form
    {

        public const string pdf = "ExtractCautionsFromEngineManualTool.pdf";
        public const string pptx = "ExtractCautionsFromEngineManualTool.pptx";

        public UIHelp()
        {
            InitializeComponent();
        }

        private void UIHelp_Load(object sender, EventArgs e)
        {
            this.Text = this.Text = Utility.m_sToolName + " V" + Utility.m_sVersion;
            webBrowser1.Navigate(Path.Combine(Utility.m_sBinPath + "bin/", pdf));
        }

        private void pptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Utility.m_sBinPath, "bin/", pptx);

            if (File.Exists(filePath))
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true // <-- Important!
                };
                System.Diagnostics.Process.Start(psi);
            }
            else
            {
                MessageBox.Show("File not found:\n" + filePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
