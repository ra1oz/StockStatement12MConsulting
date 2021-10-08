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
    public class STIDAL : IDatabase<STI>
    {
        public DataTable FindByDate(int startDate, int endDate)
        {
            //int _startDate = Convert.ToInt32(startDate.ToShortDateString());
            //int _endDate = Convert.ToInt32(endDate.ToShortDateString());
                        

            string sqlQuery = "spAddDate";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@BaslangicTarihi", startDate);
            dictionary.Add("@BitisTarihi", endDate);
            return ADODataAccess.SelectQuery(sqlQuery, dictionary, Common.Enums.CommandType.StoredProcedure);
        }
        

        public int Delete(STI entity)
        {
            throw new NotImplementedException();
        }

        public DataTable Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<STI> List()
        {
            throw new NotImplementedException();
        }

        public DataTable ListAll()
        {
            throw new NotImplementedException();
        }

        public int Save(STI entity)
        {
            throw new NotImplementedException();
        }

        public int Update(STI entity)
        {
            throw new NotImplementedException();
        }
    }
}
