using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwangRLibrary.Data;

namespace TwangRLibrary.Model
{
    public class Chats : ICollection<Chat>
    {
        public List<Chat> _Chats;

        private readonly ITwangRRepo repo;

        public Chats() : this(new TwangRRepo()) { }
        public Chats(ITwangRRepo repo)
        {
            this.repo = repo;
        }

        public void Add(Chat item)
        {
            _Chats.Add(item);
        }

        public void Clear()
        {
            _Chats.Clear();
        }

        public bool Contains(Chat item)
        {
            return _Chats.Contains(item);
        }

        public void CopyTo(Chat[] array, int arrayIndex)
        {
            _Chats.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _Chats.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(Chat item)
        {
            return _Chats.Remove(item);
        }

        public IEnumerator<Chat> GetEnumerator()
        {
            return _Chats.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _Chats.GetEnumerator();
        }

    }
}
