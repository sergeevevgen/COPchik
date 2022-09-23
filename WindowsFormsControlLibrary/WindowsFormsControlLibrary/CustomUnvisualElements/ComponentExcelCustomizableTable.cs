using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsControlLibrary.CustomUnvisualElements
{
    public partial class ComponentExcelCustomizableTable : Component
    {
        public ComponentExcelCustomizableTable()
        {
            InitializeComponent();
        }

        public ComponentExcelCustomizableTable(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void CreateFile<T>(string filename, string title, List<int> mergedCols, List<int> colSize, List<string> mtitle, List<T> data)
        {
            if (filename != null && title != null && mergedCols != null && colSize != null && mtitle != null
                && data != null && typeof(T).GetProperties().Length == colSize.Count && typeof(T).GetProperties().Length == mtitle.Count)
            {
                if (File.Exists(filename))
                    File.Delete(filename);
                var missing = System.Reflection.Missing.Value;
                var app = new Excel.Application();
                var workBook = app.Workbooks.Add(missing);
                var workSheet = (Excel.Worksheet)workBook.Worksheets[1];

                workSheet.Name = name;
                workSheet.Cells[1, 1].Value = name;

                int columnCellIndex = 1;
                int startCell = 2;

                var properties = typeof(T).GetProperties();

                var tmpList = new List<int>();

                foreach (var value in mergedRows.Values)
                {
                    tmpList.AddRange(value);
                }

                int k = startCell;
                for (int i = 0; i < properties.Length; i++)
                {
                    if (!tmpList.Contains(i))
                        xlWorkSheet.Range[xlWorkSheet.Cells[k, columnCellIndex], xlWorkSheet.Cells[k, columnCellIndex + 1]].Merge(misValue);
                    k++;
                }

                foreach (var keyValue in mergedRows)
                {
                    var range = xlWorkSheet.Range[xlWorkSheet.Cells[startCell + keyValue.Value[0], columnCellIndex], xlWorkSheet.Cells[startCell + keyValue.Value[0] + keyValue.Value.Length - 1, columnCellIndex]];
                    range.Merge(misValue);
                    range.Value = keyValue.Key;
                }

                for (int i = 0; i < tableHeader.Length; i++)
                {
                    if (!tmpList.Contains(i))
                        xlWorkSheet.Cells[i + startCell, columnCellIndex] = tableHeader[i];
                    else
                        xlWorkSheet.Cells[i + startCell, columnCellIndex + 1] = tableHeader[i];
                }

                var headerRange = xlWorkSheet.Range[xlWorkSheet.Cells[startCell, columnCellIndex], xlWorkSheet.Cells[startCell + tableHeader.Length - 1, columnCellIndex + 1]];
                headerRange.Font.Bold = true;

                int j = columnCellIndex + 2;
                k = startCell;
                foreach (var person in list)
                {
                    foreach (var prop in properties)
                    {
                        xlWorkSheet.Cells[k, j] = prop.GetValue(person);
                        k++;
                    }
                    j++;
                    k = startCell;
                }

                var listRange = xlWorkSheet.Range[xlWorkSheet.Cells[startCell, columnCellIndex + 2], xlWorkSheet.Cells[startCell + properties.Length - 1, columnCellIndex + list.Count + 1]];

                var tableRange = xlWorkSheet.Range[xlWorkSheet.Cells[startCell, columnCellIndex], xlWorkSheet.Cells[startCell + properties.Length - 1, columnCellIndex + list.Count + 1]];
                //tableRange.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic);
                tableRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                tableRange.Style.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
                tableRange.Columns.AutoFit();

                for (int i = 0; i < heightRows.Length; i++)
                {
                    xlWorkSheet.Cells[i + startCell, columnCellIndex].RowHeight = heightRows[i];
                }

                headerRange.Style.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                listRange.Style.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

                xlWorkBook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);

                xlApp.Workbooks.Close();
                xlApp.Quit();

                releaseObject(xlApp);
                releaseObject(xlWorkBook);
                releaseObject(xlWorkSheet);
            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}