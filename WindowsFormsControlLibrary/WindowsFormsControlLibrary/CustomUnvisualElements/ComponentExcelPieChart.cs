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
    public partial class ComponentExcelPieChart : Component
    {
        public ComponentExcelPieChart()
        {
            InitializeComponent();
        }

        public ComponentExcelPieChart(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void CreateFile(string filename, string title, string chartName, Dictionary<string, int> dictionary)
        {
            if (filename != null && title != null && chartName != null && dictionary != null)
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

                int startColumnCell = 1;
                int startRowCell = 2;

                int k = startRowCell;
                foreach (var keyValue in dictionary)
                {
                    workSheet.Cells[k, startColumnCell] = keyValue.Key;
                    workSheet.Cells[k, startColumnCell + 1] = keyValue.Value + "%";
                    k++;
                }

                var range = workSheet.Range[workSheet.Cells[startRowCell, startColumnCell], workSheet.Cells[startRowCell + dictionary.Count - 1, startColumnCell + 1]];
                range.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                range.Columns.AutoFit();

                Excel.ChartObjects chartObjs = (Excel.ChartObjects)workSheet.ChartObjects();
                Excel.ChartObject chartObj = chartObjs.Add(200, 40, 500, 300);
                Excel.Chart chart = chartObj.Chart;
                chart.ChartType = Excel.XlChartType.xlPie;
                chart.HasTitle = true;
                chart.ChartTitle.Text = chartName;
                chart.HasLegend = true;

                chart.Legend.Position = Excel.XlLegendPosition.xlLegendPositionBottom;

                chart.SetSourceData(range, Excel.XlRowCol.xlColumns);

                workBook.SaveAs(filename, Excel.XlFileFormat.xlWorkbookNormal, null, null, null, null, Excel.XlSaveAsAccessMode.xlExclusive, null, null, null, null, null);
                workBook.Close(true, null, null);
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