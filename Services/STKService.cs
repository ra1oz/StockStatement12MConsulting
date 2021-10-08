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
    public class STKService : IDatabase<STK>
    {
        STKDAL sTKDAL = new STKDAL();

        public DataTable ProductWithMalKodu(string malKodu)
        {
            return sTKDAL.ProductWithMalKodu(malKodu);
        }

        public DataTable MalKoduList()
        {
            return sTKDAL.MalKoduFind();
        }

        public int Delete(STK entity)
        {
            return sTKDAL.Delete(entity);
        }

        public DataTable Find(int id)
        {
            return sTKDAL.Find(id);
        }

        public List<STK> List()
        {
            return sTKDAL.List();
        }

        public DataTable ListAll()
        {
            return sTKDAL.ListAll();
        }

        public int Save(STK entity)
        {
            return sTKDAL.Save(entity);
        }

        public int Update(STK entity)
        {
            return sTKDAL.Update(entity);
        }
    }
}
