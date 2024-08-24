namespace registroEmpleados.Services
{
    public class Empleados
    {
        public int id {  get; set; }
        public string nombre { get; set; }
        public string trabajo { get; set; }
        public double sueldo { get; set; }

        public Empleados()
        {
            this.id = -1;
            this.nombre = string.Empty;
            this.trabajo = string.Empty;
            this.sueldo = 0;
        }
    }
}
