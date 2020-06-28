namespace CoreEscuela.Entidades 
{
    class Escuela
    {
        string nombre;
        public string Nombre {
            get { return "Copia: " + nombre; }
            set { nombre = value.ToUpper(); }
        }

        public int AñoDeCreación { get; set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela { get; set; }

        /*public Escuela(string nombre, int año)
        {
            this.nombre = nombre;
            AñoDeCreación = año;
        }*/

        public Escuela(string nombre, int año) => (Nombre, AñoDeCreación) = (nombre, año);
    
        public Escuela(string nombre, int año, TiposEscuela 
        tipos, string pais = "", string ciudad = "") {
            (Nombre, AñoDeCreación) = (nombre, año); //Asignación por tuplas
            Pais = pais;
            Ciudad = ciudad;
        }

        public override string ToString()
        {   
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} {System.Environment.NewLine}" 
            + $"Pais: {Pais}, Ciudad: {Ciudad}";
        }    
    }
}