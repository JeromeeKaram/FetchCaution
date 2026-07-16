using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

public static class ExcelUtility
{
    public static ExcelPackage CreateExcelWithColumns(string filePath, IEnumerable<string> columnNames,
    params string[] sheetNames)
    {
        // 🔹 Delete file if it exists
        if (File.Exists(filePath))
        {
            //#if DEBUG
            //            while (IsFileLocked(filePath))
            //            {
            //                var result = MessageBox.Show(
            //                    $"The file is currently open:\n\n{filePath}\n\nPlease close it and click Retry.",
            //                    "File In Use",
            //                    MessageBoxButtons.RetryCancel,
            //                    MessageBoxIcon.Warning);

            //                if (result == DialogResult.Cancel)
            //                {
            //                    return null; // stop processing
            //                }
            //            }
            //#endif

            File.Delete(filePath);
        }

        var fileInfo = new FileInfo(filePath);
        var package = new ExcelPackage(fileInfo);

        foreach (var sheetName in sheetNames)
        {
            var worksheet = package.Workbook.Worksheets.Add(sheetName);

            int colIndex = 1;
            foreach (var colName in columnNames)
            {
                worksheet.Cells[1, colIndex].Value = colName;
                colIndex++;
            }

            // Header formatting
            using (var range = worksheet.Cells[1, 1, 1, columnNames.Count()])
            {
                range.Style.Font.Bold = true;
            }
        }

        package.Save();
        return package;
    }

    private static bool IsFileLocked(string filePath)
    {
        try
        {
            using (var stream = File.Open(
                filePath,
                FileMode.Open,
                FileAccess.ReadWrite,
                FileShare.None))
            {
                return false;
            }
        }
        catch (IOException)
        {
            return true;
        }
    }

    public static void SVCWriteOldSheet_EPPlus1(ExcelPackage package, List<Caution> lstCautions, string sheetName)
    {
        // Get or create worksheet
        var worksheet = package.Workbook.Worksheets[sheetName]
                        ?? package.Workbook.Worksheets.Add(sheetName);


        int excelRow = worksheet.Dimension?.End.Row + 1 ?? 2;

        if (sheetName == "Cautions")
        {
            foreach (var caution in lstCautions)
            {
                worksheet.Cells[excelRow, 1].Value = caution.DMC;
                worksheet.Cells[excelRow, 2].Value = caution.Title;
                worksheet.Cells[excelRow, 3].Value = caution.CautionText;

#if DEBUG
                var cell = worksheet.Cells[excelRow, 4];
                cell.Value = caution.NewUrl;
                cell.Hyperlink = new Uri(caution.NewUrl);
#endif

                excelRow++;
            }
        }
        else if (sheetName == "NoCautions")
        {
            foreach (var caution in lstCautions)
            {
                var cell = worksheet.Cells[excelRow, 1];
                cell.Value = caution.NewUrl;
                cell.Hyperlink = new Uri(caution.NewUrl);

                worksheet.Cells[excelRow, 2].Value = caution.Title;
                worksheet.Cells[excelRow, 3].Value = caution.CautionText;
                worksheet.Cells[excelRow, 4].Value = caution.DMC;
                excelRow++;
            }
        }
    }
}