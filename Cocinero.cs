using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraccion
{
    // Clase derivada que representa a un cocinero
    public class Cocinero : Empleado
    {
        public Cocinero(string nombre, int edad) : base(nombre, edad) { }

        // Implementación del método abstracto
        public override void RealizarResponsabilidad()
        {
            Console.WriteLine($"{Nombre} está cocinando.");
        }

        // Sobrescribir el método virtual
        public override void Reportar()
        {
            Console.WriteLine($"{Nombre} el cocinero, está reportando el estado de la cocina.");
        }
    }
}
