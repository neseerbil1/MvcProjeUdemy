using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Absract
{
    public interface IGenericService<T>
    {
        List<T> GetList();
        void TAdd(T t);
        About GetByID(int id);
        void TDelete(T t);
        void TUpdate(T t);
    }
}
