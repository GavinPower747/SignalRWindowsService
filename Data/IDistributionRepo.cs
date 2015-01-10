using SignalRWindowsService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRWindowsService.Data
{
    public interface IDistributionRepo
    {
        List<Bill> GetAllBills();
    }
}
