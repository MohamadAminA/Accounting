using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
namespace Accounting.DataBase
{
    public class DataBase : IDatabase
    {
        private AccountingEntities DB;
        public DataBase(AccountingEntities db)
        {
            DB = db;
        }
        public bool Delete(int ID)
        {
            try
            {
                DB.tblAccounting.Remove(Get(ID));
            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }
        public tblAccounting Get(int ID)
        {
            try
            {
                return DB.tblAccounting.Find(ID);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<tblAccounting> GetAll()
        {
            try
            {
                return DB.tblAccounting.Select(n => n).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool Insert(tblAccounting account)
        {
            try
            {
                DB.tblAccounting.Add(account);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void Save()
        {
            DB.SaveChanges();
        }
        public bool Update(tblAccounting account)
        {
            try
            {
                DB.Entry(account).State = EntityState.Modified;
                return true;   
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
