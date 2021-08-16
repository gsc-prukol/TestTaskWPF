using System.Collections.Generic;

namespace TestTask.Models
{
    public interface ISourceData
    {
        List<TableModel> GetData();
    }
}
