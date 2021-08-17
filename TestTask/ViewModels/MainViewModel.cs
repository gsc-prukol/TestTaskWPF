using DevExpress.Mvvm;
using System.Collections.Generic;
using TestTask.Models;

namespace TestTask.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        readonly IDataModel _dataModel;
        readonly IExporter _exporter;

        public MainViewModel()
        {
            _dataModel = new DataModel();
        }

        public MainViewModel(IDataModel dataModel, IExporter exporter)
        {
            _dataModel = dataModel;
            _dataModel.PropertyChanged += (s, e) => { RaisePropertyChanged(e.PropertyName); };

            _exporter = exporter;

            ExportToCsv = new DelegateCommand<string>(str =>
            {
                if (MySelectedValues != null)
                {
                    _exporter.ExportToCsv(MySelectedValues);
                }
            });

            ExportToTxt = new DelegateCommand<string>(str =>
            {
                if (MySelectedValues != null)
                {
                    _exporter.ExportToTxt(MySelectedValues);
                }
            });
        }

        public bool ContextMenuIsVisible => MySelectedValues.Count > 0;
        public List<TableModel> MyValues => _dataModel.publicData;
        public List<TableModel> MySelectedValues { get; set; } = new List<TableModel>();
        public DelegateCommand<string> ExportToCsv { get; }
        public DelegateCommand<string> ExportToTxt { get; }
    }
}