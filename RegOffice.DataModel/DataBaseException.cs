using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegOffice.DataModel
{
    public class DataBaseException : Exception
    {
        public DataBaseException()
        {

        }
        public DataBaseException(string msg) : base(msg)
        {

        }

        public DataBaseException(string msg, Exception inner) : base(msg, inner)
        {

        }
    }
}
