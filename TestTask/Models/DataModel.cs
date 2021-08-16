using CsvHelper;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace TestTask.Models
{
    public class DataModel : BindableBase, IDataModel
    {
        private List<TableModel> table;
        private ISourceData _sourceData;
        public List<TableModel> publicData => table;


        public DataModel()
        {
            _sourceData = new SourceData();
        }

        public DataModel(ISourceData sourceData)
        {
            _sourceData = sourceData;

            table = _sourceData.GetData();
        }

        public void ExportToCsv(List<TableModel> tableModels)
        {
            if (tableModels == null)
            {
                throw new ArgumentNullException(nameof(tableModels));
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            Stream myStream;

            saveFileDialog.Filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";

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

        public void ExportToTxt(List<TableModel> tableModels)
        {
            if (tableModels == null)
            {
                throw new ArgumentNullException(nameof(tableModels));
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            Stream myStream;

            saveFileDialog.Filter = "TXT file (*.txt)|*.txt| All Files (*.*)|*.*";

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
    }
}
