namespace Tienda.Models
{
    public class Venta
    {
        public DateTime Fecha { get; private set; }
        public Producto ProductoVendido { get; private set; }
        public int Cantidad { get; private set; }
        public Cliente Cliente { get; private set; }

        public Venta(DateTime fecha, Producto productoVendido, int cantidad, Cliente cliente)
        {
            Fecha = fecha;
            ProductoVendido = productoVendido;
            Cantidad = cantidad;
            Cliente = cliente;
        }

        public double CalcularTotal()
        {
            double total = ProductoVendido.Precio * Cantidad;
            return total;
        }

        public string MostrarVenta()
        {
            string mensaje = $"\nDetalles de venta: {ProductoVendido}, Cantidad: {Cantidad}, Precio: {CalcularTotal()}, Feccha {Fecha}";
            return mensaje;
        }
    }
}
