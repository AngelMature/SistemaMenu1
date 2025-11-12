using System;

namespace CapaNegocio
{
    public class DetalleOrden
    {
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }

        public DetalleOrden() { }

        public DetalleOrden(string producto, int cantidad, decimal precioUnitario)
        {
            Producto = producto;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Subtotal = precioUnitario * cantidad;
        }
    }
}