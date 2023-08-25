using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage;
using RegOffice.DataModel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegOffice.DataModel
{
    public interface IDataEngine : IDisposable
    {
        Exception LastError { get; }
        PostgreeSqlContext DataModel { get; }
        bool Open();
        bool Close();
        IDbContextTransaction BeginTransaction();
        int SaveChanges();
        void Detach(object entity);
        void DetachAll();
        IEnumerable<T> ExecuteStoreQuery<T>(string query);
        IEnumerable<T> ExecuteStoreQuery<T>(string query, params object[] parameters);
        void Refresh();
        void UndoingChanges();
        void Refresh(object entity);
        void SetTimeout(int seconds);
        void SetDefaultTimeout();
        bool Reopen();
        void ExecuteSqlCommand(string command);
        void ExecuteSqlCommand(string command, params object[] parameters);
    }
}
