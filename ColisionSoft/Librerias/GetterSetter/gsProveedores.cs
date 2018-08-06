namespace ColisionSoft
{
    class gsProveedores
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string abreviatura { get; set; }

        public gsProveedores() { }

        public gsProveedores(int pId, string pNombre, string pAbreviatura)
        {
            this.id = pId;
            this.nombre = pNombre;
            this.abreviatura = pAbreviatura;
        }
    }
}
