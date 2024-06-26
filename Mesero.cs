using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraccion
{
    // Clase derivada que representa a un mesero
    public class Mesero : Empleado
    {
        public Mesero(string nombre, int edad) : base(nombre, edad) { }

        // Implementación del método abstracto
        public override void RealizarResponsabilidad()
        {
            Console.WriteLine($"{Nombre} está atendiendo a los clientes.");
        }

        // Sobrescribir el método virtual
        public override void Reportar()
        {
            Console.WriteLine($"{Nombre} el mesero, está reportando el estado de las mesas.");
        }
    }
}
