using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColisionSoft
{
    class gsProveedores
    {
        public int id { get; set; }
        public string nombre_prov { get; set; }
        public string abrev { get; set; }

        public gsProveedores() { }

        public gsProveedores(int pId, string pNombre, string pAbrev)
        {
            this.id = pId;
            this.nombre_prov = pNombre;
            this.abrev = pAbrev;
        }
    }
}
