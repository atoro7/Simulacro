using Tienda.Models;

namespace Tienda
{
    public class Program
    {
        static void Main()
        {
            Producto producto = new Producto("Teclado", 50000, "00056");

            Cliente cliente = new Cliente("Nicolás", 154783223, "AB201");

            Venta venta = new Venta(DateTime.Now, producto, 1, cliente);

            producto.MostrarDetalles();

            cliente.MostrarCliente();
            
            venta.CalcularTotal();
            venta.MostrarVenta();
        }
    }
}
