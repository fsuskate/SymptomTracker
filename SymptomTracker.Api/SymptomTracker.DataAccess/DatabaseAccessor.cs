using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace SymptomTracker.DataAccess
{
    public class DatabaseAccessor
    {
        private static SqlDatabase _instance;
        private static DatabaseProviderFactory _factory;

        public static SqlDatabase Instance
        {
            get
            {
                if (_instance == null)
                {
                    _factory = new DatabaseProviderFactory();
                    Database defaultDatabase = _factory.CreateDefault();
                    _instance = defaultDatabase as SqlDatabase;
                }
                return _instance;
            }
        }
    }
}
