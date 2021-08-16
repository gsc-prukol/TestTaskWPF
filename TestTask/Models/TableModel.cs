using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Models
{
    public class TableModel
    {
        
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }

        public TableModel() { }
        public TableModel(int customerId, string customerName, string customerLastName)
        {
            if (customerId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(customerId));
            }

            if (string.IsNullOrEmpty(customerName))
            {
                throw new ArgumentNullException(nameof(customerName));
            }

            if (string.IsNullOrEmpty(customerLastName))
            {
                throw new ArgumentNullException(nameof(customerLastName));
            }

            CustomerId = customerId;
            CustomerName = customerName;
            CustomerLastName = customerLastName;
        }
    }
}
