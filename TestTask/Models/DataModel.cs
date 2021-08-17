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

        }

        public DataModel(ISourceData sourceData)
        {
            _sourceData = sourceData;

            table = _sourceData.GetData();
        }
    }
}
