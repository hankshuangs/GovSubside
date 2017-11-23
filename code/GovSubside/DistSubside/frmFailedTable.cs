using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DistSubside.SQL;
using OfficeExcel = Microsoft.Office.Interop.Excel;

namespace DistSubside
{
	public partial class frmFailedTable : Form
	{
		public frmFailedTable()
		{
			InitializeComponent();
		}

		private void btnFailedTable_Click(object sender, EventArgs e)
		{
			FailedTable ftOj = new FailedTable();
			System.Data.DataSet ds = ftOj.fTables();


			System.Data.DataSet dsData = ftOj.fTables();
			ExportDataSetToExcel(dsData, Application.StartupPath);


		}

		private void ExportDataSetToExcel(System.Data.DataSet ds, string strPath)
		{
			int inHeaderLength = 3, inColumn = 0, inRow = 0;
			System.Reflection.Missing Default = System.Reflection.Missing.Value;
			//Create Excel File
			strPath += @"\Excel" + DateTime.Now.ToString("yyyyMMdd-hhmmss").Replace('/', '-') + ".xlsx";
			OfficeExcel.Application excelApp = new OfficeExcel.Application();
			OfficeExcel.Workbook excelWorkBook = excelApp.Workbooks.Add(1);
			foreach (DataTable dt in ds.Tables)
			{
				//Create Excel WorkSheet
				OfficeExcel.Worksheet excelWorkSheet = excelWorkBook.Sheets.Add(Default, excelWorkBook.Sheets[excelWorkBook.Sheets.Count]);
				excelWorkSheet.Name = dt.TableName; //Name worksheet

				//Write Column Name
				for (int i = 0; i < dt.Columns.Count; i++)
					excelWorkSheet.Cells[inHeaderLength + 1, i + 1] = dt.Columns[i].ColumnName.ToUpper();
				//Write Rows
				for (int m = 0; m < dt.Rows.Count; m++)
				{
					for (int n = 0; n < dt.Columns.Count; n++)
					{
						inColumn = n + 1;
						inRow = inHeaderLength + 2 + m;
						excelWorkSheet.Cells[inRow, inColumn] = dt.Rows[m].ItemArray[n].ToString();
						if (m % 2 == 0)
							excelWorkSheet.get_Range("A" + inRow.ToString(), "G" + inRow.ToString()).Interior.Color = System.Drawing.ColorTranslator.FromHtml("#FCE4D6");
					}
				}

				//Excel Header
				OfficeExcel.Range cellRang = excelWorkSheet.get_Range("A1", "G3");
				cellRang.Merge(false);
				cellRang.Interior.Color = System.Drawing.Color.White;
				cellRang.Font.Color = System.Drawing.Color.Gray;
				cellRang.HorizontalAlignment = OfficeExcel.XlHAlign.xlHAlignCenter;
				cellRang.VerticalAlignment = OfficeExcel.XlHAlign.xlHAlignCenter;
				cellRang.Font.Size = 26;
				excelWorkSheet.Cells[1, 1] = "Greate Novels Of All Time";

				//Style table column names
				cellRang = excelWorkSheet.get_Range("A4", "G4");
				cellRang.Font.Bold = true;
				cellRang.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
				cellRang.Interior.Color = System.Drawing.ColorTranslator.FromHtml("#ED7D31");
				excelWorkSheet.get_Range("F4").EntireColumn.HorizontalAlignment = OfficeExcel.XlHAlign.xlHAlignRight;
				//Formate prince column
				excelWorkSheet.get_Range("F5").EntireColumn.NumberFormat = "0.00";
				//Auto fit columns
				excelWorkSheet.Columns.AutoFit();
			}

			//Delete First Page
			excelApp.DisplayAlerts = false;
			Microsoft.Office.Interop.Excel.Worksheet lastWorkSeet = (Microsoft.Office.Interop.Excel.Worksheet)excelWorkBook.Worksheets[1];
			lastWorkSeet.Delete();
			excelApp.DisplayAlerts = true;

			//Set Defualt Page
			(excelWorkBook.Sheets[1] as OfficeExcel.Worksheet).Activate();

			excelWorkBook.SaveAs(strPath, Default, Default, Default, false, Default, OfficeExcel.XlSaveAsAccessMode.xlNoChange, Default, Default, Default, Default, Default);
			excelWorkBook.Close();
			excelApp.Quit();

			MessageBox.Show("Excel generated successfully \n As " + strPath);
		}


	}
}
