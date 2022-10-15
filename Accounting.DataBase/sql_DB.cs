using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataBase
{
    public class sql_DB:IDisposable
    {
        private AccountingEntities db = new AccountingEntities();
        private DataBase _databaseRepository;
        public DataBase DB{
            get{
                if(_databaseRepository == null)
                {
                    _databaseRepository = new DataBase(db);
                }
                return _databaseRepository;
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
