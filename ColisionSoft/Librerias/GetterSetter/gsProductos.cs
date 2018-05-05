using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColisionSoft
{
    class gsProductos
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public float peso { get; set; }
        public string unidad_medida { get; set; }
        public int bodega { get; set; }
        public int exhibicion { get; set; }
        public float precio { get; set; }
        public int proveedor { get; set; }

        public gsProductos() { }

        public gsProductos(int pId, string pNombre, float pPeso, string pUnidad_medida, int pBodega, int pExhibicion, float pPrecio, int pProveedor)
        {
            this.id = pId;
            this.nombre = pNombre;
            this.peso = pPeso;
            this.unidad_medida= pUnidad_medida;
            this.bodega = pBodega;
            this.exhibicion = pExhibicion;
            this.precio = pPrecio;
            this.proveedor = pProveedor;
        }
    }
}
