using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraccion
{
    // Clase abstracta que representa a un empleado del restaurante
    public abstract class Empleado
    {
        // Campos privados
        private string nombre;
        private int edad;

        // Propiedades públicas
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    nombre = value;
                else
                    throw new ArgumentException("El nombre no puede estar vacío.");
            }
        }

        public int Edad
        {
            get { return edad; }
            set
            {
                if (value > 0)
                    edad = value;
                else
                    throw new ArgumentException("La edad debe ser positiva.");
            }
        }

        // Constructor
        public Empleado(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        // Método abstracto para la responsabilidad principal del empleado
        public abstract void RealizarResponsabilidad();

        // Método virtual para una tarea común
        public virtual void Reportar()
        {
            Console.WriteLine($"{Nombre} está reportando su actividad.");
        }
    }
}
