﻿namespace Tienda.Models
{
    public class Cliente
    {
        public string Nombre { get; private set; }
        public double Telefono { get; private set; }
        public string Codigo { get; private set; }

        public Cliente(string nombre, double telefono, string codigo)
        {
            Nombre = nombre;
            Telefono = telefono;
            Codigo = codigo;
        }

        public void MostrarCliente()
        {
            Console.WriteLine("\nDetalles del Cliente\n");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Telefono: {Telefono}");
            Console.WriteLine($"Codigo: {Codigo}");
        }
    }
}
