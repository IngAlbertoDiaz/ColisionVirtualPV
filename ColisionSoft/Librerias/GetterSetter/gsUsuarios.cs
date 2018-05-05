using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColisionSoft
{
    class gsUsuarios
    {
        public int id{ get; set; }
        public string usuario { get; set; }
        public string pass{ get; set; }
        public int privilegios { get; set; }

        public gsUsuarios() { }

        public gsUsuarios(int _id,string _usuario, string _pass, int _privilegios)
        {
            this.id = _id;
            this.usuario = _usuario;
            this.pass = _pass;
            this.privilegios = _privilegios;
        }
    }
}
