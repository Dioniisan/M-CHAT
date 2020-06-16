using System;
using System.Collections.Generic;
using System.Text;

namespace M_CHAT.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAT { get; set; } = DateTime.Now;
        public DateTime? UpdatedAT { get; set; }
        public bool Status { get; set; } = true;
    }
}
