namespace abstraccion
{
    class Program
    {
        static void Main()
        {
            // Crear instancias de diferentes empleados
            Cocinero cocinero = new Cocinero("Carlos", 30);
            Mesero mesero = new Mesero("Ana", 25);
            Administrador administrador = new Administrador("Lucia", 40);

            // Crear instancia del restaurante
            Restaurante restaurante = new Restaurante();

            // Agregar empleados al restaurante
            restaurante.AgregarEmpleado(cocinero);
            restaurante.AgregarEmpleado(mesero);
            restaurante.AgregarEmpleado(administrador);

            // Iniciar trabajo de todos los empleados
            Console.WriteLine("Iniciando el trabajo de todos los empleados:");
            restaurante.IniciarTrabajo();

            // Reportar actividad de todos los empleados
            Console.WriteLine("\nReportando la actividad de todos los empleados:");
            restaurante.ReportarActividad();
        }
    }
}