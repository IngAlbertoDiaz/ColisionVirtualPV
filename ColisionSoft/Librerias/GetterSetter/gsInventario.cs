namespace ColisionSoft
{
    class gsInventario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public float peso { get; set; }
        public string unidad_medida { get; set; }
        public float bodega { get; set; }
        public float exhibicion { get; set; }
        public float precio { get; set; }
        public int proveedor { get; set; }

        public gsInventario() { }

        public gsInventario(int pId, string pNombre, float pPeso, string pUnidad_medida, int pBodega, int pExhibicion, float pPrecio, int pProveedor)
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
