using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwangRLibrary.Data;

namespace TwangRLibrary.Model
{
    public class Users : ICollection<UserData>
    {
        public List<UserData> _Users;

        private readonly ITwangRRepo repo;

        public void GetUsersByName(string QueryText)
        {
            _Users = repo.GetUsersByName(QueryText);
        }

        public void GetFriendsList(int UserId)
        {
            _Users = repo.GetFriendsList(UserId);
        }

        public void GetFriendRequests(int UserId)
        {
            _Users = repo.GetFriendRequests(UserId);
        }

        public Users() : this(new TwangRRepo()) { }
        public Users(ITwangRRepo repo)
        {
            this.repo = repo;
        }

        public void Add(UserData item)
        {
            _Users.Add(item);
        }

        public void Clear()
        {
            _Users.Clear();
        }

        public bool Contains(UserData item)
        {
            return _Users.Contains(item);
        }

        public void CopyTo(UserData[] array, int arrayIndex)
        {
            _Users.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _Users.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(UserData item)
        {
            return _Users.Remove(item);
        }

        public IEnumerator<UserData> GetEnumerator()
        {
            return _Users.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _Users.GetEnumerator();
        }

    }
}
