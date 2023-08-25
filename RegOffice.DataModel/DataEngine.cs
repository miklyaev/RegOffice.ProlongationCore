using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage;
using RegOffice.DataModel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace RegOffice.DataModel
{
    public class DataEngine : IDataEngine
    {
        private bool _disposed;
        private bool _connected;       
        private int? _commandTimeout;
        private readonly PostgreeSqlContext _dataModel;
        private readonly DbContextOptions<PostgreeSqlContext> _options;

        public DataEngine(PostgreeSqlContext context, DbContextOptions<PostgreeSqlContext> options)
        {
            _dataModel = context;
            _options = options;
            _commandTimeout = _dataModel.Database.GetCommandTimeout();
        }

        public IDbConnection Connection
        {
            get { return _dataModel.Database.GetDbConnection(); }
        }
        public Exception LastError { get; private set; }

        public PostgreeSqlContext DataModel
        {
            get
            {
                if (!Open())
                {
                    var message = string.Empty;
                    if (LastError != null)
                    {
                        message = string.Format(" {0}", LastError.Message);
                        if (LastError.InnerException != null)
                        {
                            message = string.Format("{0} {1}", message, LastError.InnerException.Message);
                        }
                    }

                    throw new DataBaseException(string.Format("Ошибка подключения к базе данных RegOffice.{0}", message));
                }
                return _dataModel;
            }
        }

        public IDbContextTransaction BeginTransaction()
        {
            return (Open()) ? _dataModel.Database.BeginTransaction() : null;
        }

        public bool Close()
        {
            throw new NotImplementedException();
        }

        public void Detach(object entity)
        {
            throw new NotImplementedException();
        }

        public void DetachAll()
        {
            throw new NotImplementedException();
        }

        public void ExecuteSqlCommand(string command)
        {
            throw new NotImplementedException();
        }

        public void ExecuteSqlCommand(string command, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ExecuteStoreQuery<T>(string query)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ExecuteStoreQuery<T>(string query, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public bool Open()
        {
            if (_connected) return true;

            try
            {
                if (!Connection.State.HasFlag(ConnectionState.Open))
                    Connection.Open();

                _connected = true;
                return _connected;
            }
            catch (Exception ex)
            {
                Connection.Close();
                LastError = ex;
                _connected = false;
                return _connected;
            }
        }

        public void Refresh()
        {
            throw new NotImplementedException();
        }

        public void Refresh(object entity)
        {
            throw new NotImplementedException();
        }

        public bool Reopen()
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            return _dataModel.SaveChanges();
        }

        public void SetDefaultTimeout()
        {
            _dataModel.Database.SetCommandTimeout(600);
        }

        public void SetTimeout(int seconds)
        {
            _dataModel.Database.SetCommandTimeout(seconds);
        }

        public void UndoingChanges()
        {
            throw new NotImplementedException();
        }

        ~DataEngine()
        {            
            CleanUp(false);
        }

        public void Dispose()
        {
            CleanUp(true);
            GC.SuppressFinalize(this);
        }

        private void CleanUp(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_connected)
                    {
                        try
                        {
                            Connection.Close();
                        }
                        catch (Exception ex)
                        {
                        }
                        _connected = false;
                    }
                }
            }
            _disposed = true;
        }
    }
}
