using System;
using System.Collections.Generic;
using System.Text;
using M_CHAT.Models;
using System.Linq;

namespace M_CHAT.Services
{
    public class ContainerRepository : SQLRepository<Tutor>, IContainerRepository
    {
        //AppDBContext context;
        //public ContainerRepository(AppDBContext context)
        //{
        //    this.context = context;
        //}
        public ContainerRepository(AppDBContext context) : base(context) { }
        public IEnumerable<Tutor> GetTutores()
        {
            return context.Set<Tutor>().AsEnumerable();
        }

        public IEnumerable<Ninio> GetNinios()
        {
            return context.Set<Ninio>().AsEnumerable();
        }
    }
}
