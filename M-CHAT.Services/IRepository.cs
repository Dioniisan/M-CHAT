using System;
using System.Collections.Generic;
using System.Text;
using M_CHAT.Models;

namespace M_CHAT.Services
{
    public interface IRepository<T> where T : BaseEntity
    {
        public IEnumerable<T> GetAll();
        public T Get(int id);
        public int Insert(T obj);
        public void Update(T obj);
        public void Delete(T obj);
    }
}
