using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwangRLibrary.Model;

namespace TwangRLibrary.Data
{
    public interface ITwangRRepo
    {
        void LogMessage(Message message);
        dynamic Login(string username, string password);
        string Register(UserData data);
    }
}
