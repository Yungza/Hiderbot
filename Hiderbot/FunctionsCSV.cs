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
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var row in schedule)
                {
                    var rowData = row.Select(period => $"{period.Teacher.Name} – {period.Subject}");
                    writer.WriteLine(string.Join(",", rowData));
                }
            }
        }
        public static void LoadCsvToDataGridView(DataGridView dataGridView, string filePath)
        {
            dataGridView.Rows.Clear(); // Clear existing rows
            dataGridView.Columns.Clear(); // Clear existing columns
            
            for (int i = 0; i < 10; i++)
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
    }
}
