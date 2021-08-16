using System.Collections.Generic;

namespace TestTask.Models
{
    public class SourceData : ISourceData
    {
        public List<TableModel> GetData()
        {
            List<TableModel> table = new List<TableModel>();
            table.Add(new TableModel(1, "Customer", "Customerencko"));
            table.Add(new TableModel(2, "Custo,mer2", "Customerencko2"));
            table.Add(new TableModel(3, "Customer3", "Customerencko3"));
            table.Add(new TableModel(4, "Customer4", "Customerencko4"));

            return table;
        }
    }
}
