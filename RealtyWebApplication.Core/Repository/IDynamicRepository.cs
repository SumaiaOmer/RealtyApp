using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RealtyWebApplication.Core.Repository
{
  public  interface IDynamicRepository<T> where T :class
    {
       
        Task<T> GetById(int id);
         Task<IEnumerable<T>> GetAll();
        T AddData(T entity);
        T ModifyData(T entity);
        T RemoveData(T entity); 
    }
}
