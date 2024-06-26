using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraccion
{
    // Clase derivada que representa a un administrador
    public class Administrador : Empleado
    {
        public Administrador(string nombre, int edad) : base(nombre, edad) { }

        // Implementación del método abstracto
        public override void RealizarResponsabilidad()
        {
            Console.WriteLine($"{Nombre} está gestionando el restaurante.");
        }
    }
}
