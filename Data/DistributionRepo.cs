using SignalRWindowsService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRWindowsService.Data
{
    public class DistributionRepo : IDistributionRepo
    {
        private readonly DistributionDataContext _dataContext;

        public DistributionRepo()
        {
            this._dataContext = new DistributionDataContext();
        }

        public List<Bill> BillsDBToBills(IEnumerable<BillDB> BillsDBs)
        {
            return BillsDBs.Select(BillsDB => new Bill() 
            { 
                Amount = BillsDB.Amount,
                DueDate = BillsDB.DueDate,
                Type = BillsDB.Type
            }).ToList();
        }

        public List<Bill> GetAllBills()
        {
            return BillsDBToBills(_dataContext.GetAllBills());
        }
    }
}
