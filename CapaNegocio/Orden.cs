using System;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class Orden
    {
        public int Id { get; set; }
        public int NumeroMesa { get; set; }
        public int IdMesero { get; set; }
        public DateTime FechaHora { get; set; }
        public string Estado { get; set; }
        public decimal Total { get; set; }
        public List<DetalleOrden> Detalles { get; set; }

        public Orden()
        {
            Detalles = new List<DetalleOrden>();
            FechaHora = DateTime.Now;
            Estado = "Pendiente";
        }

        public void AgregarDetalle(DetalleOrden detalle)
        {
            Detalles.Add(detalle);
            CalcularTotal();
        }

        public void CalcularTotal()
        {
            Total = 0;
            foreach (var detalle in Detalles)
            {
                Total += detalle.Subtotal;
            }
        }

        public string ObtenerResumen()
        {
            return $"Orden #{Id} - Mesa {NumeroMesa} - Total: {Total:C} - Estado: {Estado}";
        }
    }
}