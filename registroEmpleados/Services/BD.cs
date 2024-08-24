namespace registroEmpleados.Services
{
    public class BD
    {
        private LinkedList<Empleados> list;
        public BD() { 
            list = new LinkedList<Empleados>();
            
            list.AddLast(new Empleados { id = 2056, nombre = "Juan Pérez", trabajo = "Desarrollador", sueldo = 50000 });
            list.AddLast(new Empleados { id = 9865, nombre = "María López", trabajo = "Analista", sueldo = 45000 });
			list.AddLast(new Empleados { id = 3806, nombre = "Reyphill Duarte", trabajo = "Ing.Software", sueldo = 85000 });
			list.AddLast(new Empleados { id = 1498, nombre = "Jose Luis", trabajo = "Telecomunicaciones", sueldo = 60000 });
		}



        public async Task AgregarEmpleadoAsync(Empleados emp)
        {
            await Task.Run(() =>
            {
                list.AddLast(emp);
            });
        }

		public async Task<Empleados> ObtenerEmpleadoPorIdAsync(int id)
		{
			return await Task.Run(() =>
			{
				return list.FirstOrDefault(e => e.id == id);
			});
		}

		public async Task ActualizarEmpleadoAsync(Empleados empleado)
		{
			await Task.Run(() =>
			{
				var empleadoExistente = list.FirstOrDefault(e => e.id == empleado.id);
				if (empleadoExistente != null)
				{
					empleadoExistente.nombre = empleado.nombre;
					empleadoExistente.trabajo = empleado.trabajo;
					empleadoExistente.sueldo = empleado.sueldo;
				}
				else
				{
					throw new Exception("Empleado no encontrado");
				}
			});
		}

		public async Task eliminar(int id)
        {
			await Task.Run(() =>
			{
				var empleado = list.FirstOrDefault(e => e.id == id);
				if (empleado != null)
				{
					list.Remove(empleado);
				}
				else
				{
					throw new Exception("Empleado no encontrado");
				}
			});
		}

		public Task<LinkedList<Empleados>> ObtenerEmpleadosAsync()
		{
			return Task.FromResult(list);
		}
	}
}
