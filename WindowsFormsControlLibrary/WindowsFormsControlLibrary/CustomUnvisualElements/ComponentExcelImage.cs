using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsControlLibrary.CustomUnvisualElements
{
    public partial class ComponentExcelImage : Component
    {
        public ComponentExcelImage()
        {
            InitializeComponent();
        }

        public ComponentExcelImage(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void CreateFile(string filename, string title, List<string> images)
        {
            if (filename != null && title != null && images != null)
            {
                if (File.Exists(filename))
                    File.Delete(filename);
                var app = new Excel.Application();
                var workBook = app.Workbooks.Add();
                var workSheet = (Excel.Worksheet)workBook.Worksheets[1];

                workSheet.Name = title;
                workSheet.Cells[1, 10].Value = title;
                workSheet.Range[workSheet.Cells[1, 10], workSheet.Cells[1, 20]].Merge();
                workSheet.Range[workSheet.Cells[1, 10], workSheet.Cells[1, 20]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                workSheet.Range[workSheet.Cells[1, 10], workSheet.Cells[1, 20]].Font.Bold = true;
                workSheet.Range[workSheet.Cells[1, 10], workSheet.Cells[1, 20]].Font.Size = 24;
                int y = 50;

                foreach (var image in images)
                {
                    Image newImage = Image.FromFile(image);
                    workSheet.Shapes.AddPicture(image, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 0, y, newImage.Width, newImage.Height);
                    y += newImage.Height;
                }

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