using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwangRLibrary.Data;

namespace TwangRLibrary.Model
{
    public class Status
    {
        public int StatusId { get; set; }
        public string StatusContent { get; set; }
        public int StatusAuthorID { get; set; }
        public string StatusAuthor { get; set; }
        public int StatusLikes { get; set; }
        public string LogDate { get; set; }

        private readonly ITwangRRepo repo;

        public Status() : this(new TwangRRepo()) { }
        public Status(ITwangRRepo repo)
        {
            this.repo = repo;
        }

        public void InsertStatus(Status status)
        {
            repo.InsertStatus(status);
        }

        public void UpdateStatus(Status status)
        {
            repo.UpdateStatus(status);
        }
    }
}
