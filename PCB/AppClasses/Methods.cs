using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace PCB.AppClasses
{
    class Methods
    {
        public string GetRowValue(DataGridView gr, int index, int rowIndex)
        {
            return gr.Rows[rowIndex].Cells[index].Value.ToString();
        }

        static string connectionString = ConfigurationManager
            .ConnectionStrings["connString"]
            .ConnectionString;

        // Searches for values matching a keyword in a db column
        public DataTable SearchQuery(string searchWord, string dbColumn)
        {
            // Make it static and outside of method? 

            string keyword = "'%" + searchWord + "%'";

            var connection = new SqlConnection(connectionString);

            var dataAdapter = new SqlDataAdapter($"SELECT * FROM {dbColumn} WHERE Manufacturer LIKE {keyword}" +
                                                 $"OR Name LIKE {keyword}", connection);

            var dt = new DataTable();
            dataAdapter.Fill(dt);

            return dt;
        }

        // Clears all textboxes
        public void Clear(Control control)
        {
            if (control is TextBox)
            {
                ((TextBox)control).Text = string.Empty;
            }

            for (int i = 0; i < control.Controls.Count; i++)
            {
                Clear(control.Controls[i]);
            }
        }

        public void DisplayMessage(bool success, string operation, Control currentForm,
            Component hardwareComponent, string componentName, DataGridView gv)
        {
            string msg;

            if (success == true)
            {
                msg = $"Successfully {operation}!";
                // Clear all fields if successful
                Clear(currentForm);

                // Load data to the grid
                var dt = hardwareComponent.Select($"{componentName}");
                gv.DataSource = dt;
            }

            else
            {
                msg = "Operation failed, Try Again!";
            }

            MessageBox.Show(msg);
        }

        // Getting the row value and assigning it to the corresponding textbox
        public void FillTextBoxes(TextBox[] tb, DataGridView gr, int rowIndex)
        {
            for (int i = 0; i < tb.Length; i++)
            {
                tb[i].Text = GetRowValue(gr, i, rowIndex);
            }
        }

        public void ExportToExcel(DataGridView gr)
        {
            gr.SelectAll();
            DataObject dataObj = gr.GetClipboardContent();
            if (dataObj != null)
            {
                Clipboard.SetDataObject(dataObj);
            }

            Excel.Application xlexcel;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}
