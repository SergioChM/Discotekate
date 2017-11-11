using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models
{
    public partial class Empresa {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string logo { get; set; }
    }

}
