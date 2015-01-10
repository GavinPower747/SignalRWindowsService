using SignalRWindowsService.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRWindowsService.Model
{
    public class Bills : ICollection<Bill>
    {
        public List<Bill> _Bills { get; set;}
        public IDistributionRepo repo { get; set; }

        public Bills() : this(new DistributionRepo()) { }
        public Bills(IDistributionRepo repo)
        {
            this.repo = repo;
        }

        public void GetAllBills()
        {
            _Bills = repo.GetAllBills();
        }

        public void Add(Bill item)
        {
            _Bills.Add(item);
        }

        public void Clear()
        {
            _Bills.Clear();
        }

        public bool Contains(Bill item)
        {
            return _Bills.Contains(item);
        }

        public void CopyTo(Bill[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(Bill item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Bill> GetEnumerator()
        {
            return _Bills.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _Bills.GetEnumerator();
        }
    }
}
