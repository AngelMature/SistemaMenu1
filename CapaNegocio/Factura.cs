using System;

namespace CapaNegocio
{
    public class Factura
    {
        public int Id { get; set; }
        public int IdOrden { get; set; }
        public int IdCajero { get; set; }
        public DateTime FechaHora { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }
        public string MetodoPago { get; set; }

        public Factura()
        {
            FechaHora = DateTime.Now;
            Impuesto = 0.15m; 
        }

        public void CalcularTotales(decimal subtotal)
        {
            Subtotal = subtotal;
            Impuesto = Subtotal * 0.15m;
            Total = Subtotal + Impuesto;
        }

        public string ObtenerResumen()
        {
            return $"Factura #{Id} - Orden: {IdOrden} - Total: {Total:C} - Método: {MetodoPago}";
        }

        public string GenerarFactura(Orden orden, string nombreCajero)
        {
            CalcularTotales(orden.Total);
            return $"=== FACTURA ===\n" +
                   $"Número: {Id}\n" +
                   $"Fecha: {FechaHora}\n" +
                   $"Mesa: {orden.NumeroMesa}\n" +
                   $"Cajero: {nombreCajero}\n" +
                   $"Subtotal: {Subtotal:C}\n" +
                   $"Impuesto (15%): {Impuesto:C}\n" +
                   $"TOTAL: {Total:C}\n" +
                   $"Método de Pago: {MetodoPago}";
        }
    }
}