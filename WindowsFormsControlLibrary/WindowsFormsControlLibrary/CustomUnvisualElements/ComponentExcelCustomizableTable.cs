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

        public void CreateFile<T>(string filename, string title, Dictionary<string, int[]> mergedCols, List<int> colSize, List<string> mtitle, List<T> data)
        {
            if (filename != null && title != null && mergedCols != null && colSize != null && mtitle != null
                && data != null && typeof(T).GetProperties().Length == colSize.Count && typeof(T).GetProperties().Length == mtitle.Count)
            {
                if (File.Exists(filename))
                    File.Delete(filename);
                
                var app = new Excel.Application();
                var workBook = app.Workbooks.Add();
                var workSheet = (Excel.Worksheet)workBook.Worksheets[1];

                workSheet.Name = title;
                workSheet.Cells[1, 5].Value = title;
                workSheet.Range[workSheet.Cells[1, 5], workSheet.Cells[1, 10]].Merge();
                workSheet.Range[workSheet.Cells[1, 5], workSheet.Cells[1, 10]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                workSheet.Range[workSheet.Cells[1, 5], workSheet.Cells[1, 10]].Font.Bold = true;
                workSheet.Range[workSheet.Cells[1, 5], workSheet.Cells[1, 10]].Font.Size = 24;

                int columnCellIndex = 1;
                int startCell = 2;

                var properties = typeof(T).GetProperties();

                var tmpList = new List<int>();

                foreach (var value in mergedCols.Values)
                {
                    tmpList.AddRange(value);
                }

                int k = startCell;
                for (int i = 0; i < properties.Length; i++)
                {
                    if (!tmpList.Contains(i))
                        workSheet.Range[workSheet.Cells[k, columnCellIndex], workSheet.Cells[k, columnCellIndex + 1]].Merge();
                    k++;
                }

                foreach (var keyValue in mergedCols)
                {
                    var range = workSheet.Range[workSheet.Cells[startCell + keyValue.Value[0], columnCellIndex], workSheet.Cells[startCell + keyValue.Value[0] + keyValue.Value.Length - 1, columnCellIndex]].Merge();
                    range.Value = keyValue.Key;
                }

                for (int i = 0; i < mtitle.Count; i++)
                {
                    if (!tmpList.Contains(i))
                        workSheet.Cells[i + startCell, columnCellIndex] = mtitle[i];
                    else
                        workSheet.Cells[i + startCell, columnCellIndex + 1] = mtitle[i];
                }

                var headerRange = workSheet.Range[workSheet.Cells[startCell, columnCellIndex], workSheet.Cells[startCell + mtitle.Count - 1, columnCellIndex + 1]];
                headerRange.Font.Bold = true;

                int j = columnCellIndex + 2;
                k = startCell;
                foreach (var element in data)
                {
                    foreach (var prop in properties)
                    {
                        workSheet.Cells[k, j] = prop.GetValue(element);
                        k++;
                    }
                    j++;
                    k = startCell;
                }

                var listRange = workSheet.Range[workSheet.Cells[startCell, columnCellIndex + 2], workSheet.Cells[startCell + properties.Length - 1, columnCellIndex + data.Count + 1]];

                var tableRange = workSheet.Range[workSheet.Cells[startCell, columnCellIndex], workSheet.Cells[startCell + properties.Length - 1, columnCellIndex + data.Count + 1]];
                tableRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                tableRange.Style.VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
                tableRange.Columns.AutoFit();

                for (int i = 0; i < colSize.Count; i++)
                {
                    workSheet.Cells[i + startCell, columnCellIndex].RowHeight = colSize[i];
                }

                headerRange.Style.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                listRange.Style.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;

                workBook.SaveAs(filename, Excel.XlFileFormat.xlWorkbookNormal, Excel.XlSaveAsAccessMode.xlExclusive);
                workBook.Close(true);
                app.Quit();

                releaseObject(app);
                releaseObject(workBook);
                releaseObject(workSheet);
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