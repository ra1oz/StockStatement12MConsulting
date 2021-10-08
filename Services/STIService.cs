using Core.Interfaces;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class STIService : IDatabase<STI>
    {
        STIDAL sTIDAL = new STIDAL();

        public DataTable FindByDate(int startDate, int endDate)
        {
            return sTIDAL.FindByDate(startDate, endDate);
        }

        public int Delete(STI entity)
        {
            return sTIDAL.Delete(entity);
        }

        public DataTable Find(int id)
        {
            return sTIDAL.Find(id);
        }

        public List<STI> List()
        {
            return sTIDAL.List();
        }

        public DataTable ListAll()
        {
            return sTIDAL.ListAll();
        }

        public int Save(STI entity)
        {
            return sTIDAL.Save(entity);
        }

        public int Update(STI entity)
        {
            return sTIDAL.Update(entity);
        }
    }
}
