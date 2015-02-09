using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TwangRLibrary
{
    public class BadLoginException : Exception, ISerializable
    {
        public BadLoginException(string message) : base(message) { }
    }
}
