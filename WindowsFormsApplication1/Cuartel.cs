using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Cuartel
    {
        public string CODIGO { get; set; }
        public string NOMBRE { get; set; }
        public string DIRECCION { get; set; }
        public string CIUDAD { get; set; }
        public List<Soldado>Soldados { get; set; }
        public Cuartel()
        {
            Soldados = new List<Soldado>();
        }

    }
}
