using Common;
using Core.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class STKDAL : IDatabase<STK>
    {

        public DataTable ProductWithMalKodu(string malKodu)
        {
            string sqlQuery = "spMalKoduDetail";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@MalKodu", malKodu);
            return ADODataAccess.SelectQuery(sqlQuery, dictionary, Enums.CommandType.StoredProcedure);
        }

        public DataTable MalKoduFind()
        {
            string sqlQuery = "spMalKoduList";
            return ADODataAccess.SelectQuery(sqlQuery, null, Enums.CommandType.StoredProcedure);
        }

        public int Delete(STK entity)
        {
            throw new NotImplementedException();
        }

        public DataTable Find(int id)
        {
            string sqlQuery = "spSTKFind";
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("@Id", id);
            return ADODataAccess.SelectQuery(sqlQuery, dic, Enums.CommandType.StoredProcedure);
        }

        public List<STK> List()
        {
            throw new NotImplementedException();
        }

        public DataTable ListAll()
        {
            throw new NotImplementedException();
        }

        public int Save(STK entity)
        {
            throw new NotImplementedException();
        }

        public int Update(STK entity)
        {
            throw new NotImplementedException();
        }
    }
}
