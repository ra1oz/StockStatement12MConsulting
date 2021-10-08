using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IDatabase<T> where T : class, new()
    {
        //Genel olarak CRUD işlemleri ekledim ve generic yapıya sadece class ve referans tip gelebileceğini ekledim
        int Save(T entity);
        int Delete(T entity);
        int Update(T entity);
        List<T> List();       
        DataTable Find(int id);
        DataTable ListAll();
    }
}
