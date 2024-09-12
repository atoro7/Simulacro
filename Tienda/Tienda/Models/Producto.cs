namespace Tienda.Models
{
    public class Producto
    {
        public string Nombre {  get; private set; }
        public double Precio { get; private set; }
        public string Codigo { get; private set; }

        public Producto(string nombre, double precio, string codigo)
        {
            Nombre = nombre;
            Precio = precio;
            Codigo = codigo;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine("Detalles del Producto\n");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio: {Precio:C}");
            Console.WriteLine($"Codigo: {Codigo}");
        }
    }
}
