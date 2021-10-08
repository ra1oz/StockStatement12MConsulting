using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstract
{
    public abstract class ADatabase<T> where T : class, new()
    {
        //İhtiyacımıza göre tamamlanmış operasyon ekleyip abstract class kullanımı yapabiliriz
        public abstract int Save(T entity);
        public abstract int Delete(T entity);
        public abstract int Update(T Entity);
        public abstract List<T> List();
        public abstract DataTable ListAll();
    }
}
