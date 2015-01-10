using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRWindowsService.Model
{
    public class Bill
    {
        public string Type { get; set; }
        public double? Amount { get; set; }
        public DateTime? DueDate { get; set; }

        public void InsertBill()
        {
            throw new NotImplementedException();
        }
    }
}
