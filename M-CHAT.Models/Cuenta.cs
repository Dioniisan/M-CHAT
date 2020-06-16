using System;
using System.Collections.Generic;
using System.Text;

namespace M_CHAT.Models
{
    public class Cuenta : BaseEntity
    {
        public int CuentaID { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }
    }
}
