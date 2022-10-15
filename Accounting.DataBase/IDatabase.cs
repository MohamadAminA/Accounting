using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataBase
{
    internal interface IDatabase
    {
        bool Delete(int ID);
        bool Update(tblAccounting account);
        IEnumerable<tblAccounting> GetAll();
        tblAccounting Get(int ID);
        void Save();
        bool Insert (tblAccounting account);
    }
}
