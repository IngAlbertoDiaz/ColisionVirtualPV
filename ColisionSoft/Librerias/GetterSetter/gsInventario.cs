namespace ColisionSoft
{
    class gsInventario
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string marca { get; set; }
        public string tipo { get; set; }
        public string medida { get; set; }
        public string color { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public string precio_unitario { get; set; }

        public gsInventario() { }

        public gsInventario(int pId, string pCodigo, string pMarca, string pTipo, string pMedida, 
            string pColor, string pDescripcion, int pCantidad, string pPrecioUnitario)
        {
            id = pId;
            codigo = pCodigo;
            marca = pMarca;
            tipo = pTipo;
            medida = pMedida;
            color = pColor;
            descripcion = pDescripcion;
            cantidad = pCantidad;
            precio_unitario = pPrecioUnitario;
        }
    }
}
