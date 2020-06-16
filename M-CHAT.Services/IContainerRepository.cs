using System;
using System.Collections.Generic;
using System.Text;
using M_CHAT.Models;

namespace M_CHAT.Services
{
    public interface IContainerRepository : IRepository<Tutor>
    {
        public IEnumerable<Tutor> GetTutores();

    }
}
