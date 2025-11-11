using System;

namespace CapaNegocio
{
    public class DetalleOrden
    {
        public int Id { get; set; }
        public int IdOrden { get; set; }
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
        public string Comentarios { get; set; }

        public DetalleOrden() { }

        public DetalleOrden(int idProducto, string nombreProducto, int cantidad, decimal precioUnitario, string comentarios = "")
        {
            IdProducto = idProducto;
            NombreProducto = nombreProducto;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Comentarios = comentarios;
            CalcularSubtotal();
        }

        public void CalcularSubtotal()
        {
            Subtotal = Cantidad * PrecioUnitario;
        }
    }
}