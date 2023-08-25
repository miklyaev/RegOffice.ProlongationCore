using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegOffice.DataServiceCore.Interfaces
{
    public interface IDataService
    {
        void SaveChanges();
        IDbTransaction BeginTransaction();
        void Close();
    }
}
