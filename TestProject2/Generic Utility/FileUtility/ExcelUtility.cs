using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiten_s_Automation_Exercise.GenericUtility.FileUtility
{
    internal class ExcelUtility
    {
        public String GetDataFromExcel(string SheetName, int row, int cell)
        {
            //Path for Excel
            String path = "E:\\VisualStudio\\Hiten's_Automation_Exercise\\Hiten's_Automation_Exercise\\TestData\\TestData.xlsx";

            //read Data from Excel
            XLWorkbook workbook = new XLWorkbook(path);
            IXLWorksheet worksheet = workbook.Worksheet(SheetName);
            string cellValue = worksheet.Row(row).Cell(cell).GetValue<String>();
            return cellValue;
        }

        public String GetDataFromExcel(int sheetNo, int row, int cell)
        {
            //Path for Excel
            String path = "E:\\VisualStudio\\Hiten's_Automation_Exercise\\Hiten's_Automation_Exercise\\TestData\\TestData.xlsx";

            //read Data from Excel
            XLWorkbook workbook = new XLWorkbook(path);
            IXLWorksheet worksheet = workbook.Worksheet(sheetNo);
            string cellValue = worksheet.Row(row).Cell(cell).GetValue<String>();
            return cellValue;
        }
    }
}
