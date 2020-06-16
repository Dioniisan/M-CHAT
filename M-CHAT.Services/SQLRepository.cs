using System;
using System.Collections.Generic;
using System.Text;
using M_CHAT.Models;

namespace M_CHAT.Services
{
    public class SQLRepository<T> : IRepository<T> where T : BaseEntity
    {
        public SQLRepository()
        {
        }
        public void Delete(T obj)
        {
            throw new NotImplementedException();
        }
        public T Get(int id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }
        public int Insert(T obj)
        {
            throw new NotImplementedException();
        }
        public void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
