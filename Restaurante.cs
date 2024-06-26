using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraccion
{
    // Clase que representa el restaurante
    public class Restaurante
    {
        private List<Empleado> empleados;

        // Constructor
        public Restaurante()
        {
            empleados = new List<Empleado>();
        }

        // Método para agregar un empleado
        public void AgregarEmpleado(Empleado empleado)
        {
            if (empleado != null)
                empleados.Add(empleado);
            else
                throw new ArgumentNullException("El empleado no puede ser nulo.");
        }

        // Método para iniciar las responsabilidades de todos los empleados
        public void IniciarTrabajo()
        {
            foreach (var empleado in empleados)
            {
                empleado.RealizarResponsabilidad();
            }
        }

        // Método para reportar la actividad de todos los empleados
        public void ReportarActividad()
        {
            foreach (var empleado in empleados)
            {
                empleado.Reportar();
            }
        }
    }
}
