using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hiderbot
{
    public static class FunctionsCSV //with help from chatGPT
    {
        public static void SaveScheduleToCsv(List<List<Period>> schedule, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var row in schedule)
                    {
                        var rowData = row.Select(period => $"{period.Teacher.Name} – {period.Subject}");
                        writer.WriteLine(string.Join(",", rowData));
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void LoadCsvToDataGridView(DataGridView dataGridView, string filePath)
        {
            try
            {
                dataGridView.Rows.Clear(); // Clear existing rows
                dataGridView.Columns.Clear(); // Clear existing columns

                for (int i = 0; i < 16; i++)
                {
                    dataGridView.Columns.Add((i + 1) + ". hodina", (i + 1) + ". hodina");
                }

                // Populate rows from CSV file data
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] fields = reader.ReadLine().Split(',');
                        dataGridView.Rows.Add(fields);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void SaveDataGridViewToCsv(DataGridView dataGridView, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write rows
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow) // Skip the new row at the bottom of DataGridView
                    {
                        var cells = row.Cells.Cast<DataGridViewCell>();
                        writer.WriteLine(string.Join(",", cells.Select(cell => string.IsNullOrEmpty(cell.Value?.ToString()) ? "N/A" : cell.Value.ToString())));
                    }
                }
            }
        }
    }
}
