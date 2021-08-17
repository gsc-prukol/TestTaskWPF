using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Models
{
    public interface IExporter
    {
        void ExportToCsv(List<TableModel> tableModels);
        void ExportToTxt(List<TableModel> tableModels);
    }
}
