using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask.Models
{
    public class Exporter : IExporter
    {
        private string CsvFileFilter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
        private string TxtFileFilter = "TXT file (*.txt)|*.txt| All Files (*.*)|*.*";

        private void ExportToFile(List<TableModel> tableModels, string fileFilter)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            Stream myStream;

            saveFileDialog.Filter = fileFilter;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    using (var writer = new StreamWriter(myStream))
                    {
                        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                        {
                            csv.WriteRecords(tableModels);
                        }
                    }
                }
            }


        }

        public void ExportToCsv(List<TableModel> tableModels)
        {
            if (tableModels == null)
            {
                throw new ArgumentNullException(nameof(tableModels));
            }

            ExportToFile(tableModels, CsvFileFilter);
        }


        public void ExportToTxt(List<TableModel> tableModels)
        {
            if (tableModels == null)
            {
                throw new ArgumentNullException(nameof(tableModels));
            }

            ExportToFile(tableModels, TxtFileFilter);
        }
    }
}
