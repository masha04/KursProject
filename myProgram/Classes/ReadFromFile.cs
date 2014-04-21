using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace myProgram
{
    class ReadFromFile
    {
        public string[,] WorkExcel()//работа с Excel
        {
            Excel.Application objExcel = new Excel.Application();
            Excel.Workbook objBook = objExcel.Workbooks.Open(@"d:\MailBranch\Book.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            Excel.Worksheet objSheet = (Excel.Worksheet)objBook.Sheets[1];
            var lastCell = objSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);

            string[,] list = new string[lastCell.Row, lastCell.Column];

            for (int i = 0; i < (int)lastCell.Row; i++)
            {
                for (int j = 0; j < (int)lastCell.Column; j++)
                {
                    list[i, j] = objSheet.Cells[i + 1, j + 1].Text.ToString();
                }
            }
            objBook.Close(false, Type.Missing, Type.Missing);
            objExcel.Quit();

            return list;
        }

        public int GetId(DataTable dt, string fieldName, string str)//Linq запрос на получение id
        {
            var q = dt.AsEnumerable()
                .Where(t => t.Field<string>(fieldName) == str)
                .Select(t => t.Field<int>("id"));

            int value = -1;
            foreach (var i in q)
                value = i;

            return value;
        } 
    }
}
