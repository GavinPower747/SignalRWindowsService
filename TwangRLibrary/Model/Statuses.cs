using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwangRLibrary.Data;

namespace TwangRLibrary.Model
{
    public class Statuses : ICollection<Status>
    {

        public List<Status> _Statuses;

        private readonly ITwangRRepo repo;

        public void GetAllPostsByUser(int UserId)
        {
            _Statuses = repo.GetAllPostsByUser(UserId);
        }

        public void GetNewsFeed(int UserId)
        {
            _Statuses = repo.GetNewsFeed(UserId);
        }

        public Statuses() : this(new TwangRRepo()) { }
        public Statuses(ITwangRRepo repo)
        {
            this.repo = repo;
        }

        public void Add(Status item)
        {
            _Statuses.Add(item);
        }

        public void Clear()
        {
            _Statuses.Clear();
        }

        public bool Contains(Status item)
        {
            return _Statuses.Contains(item);
        }

        public void CopyTo(Status[] array, int arrayIndex)
        {
            _Statuses.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _Statuses.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(Status item)
        {
            return _Statuses.Remove(item);
        }

        public IEnumerator<Status> GetEnumerator()
        {
            return _Statuses.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _Statuses.GetEnumerator();
        }
    }
}
