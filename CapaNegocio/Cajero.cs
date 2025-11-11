using System;

namespace CapaNegocio
{
    public class Cajero : Empleado
    {
        public int FacturasEmitidas { get; set; }
        public decimal TotalRecaudado { get; set; }

        public Cajero() : base() { }

        public Cajero(int id, string nombre, decimal salario, DateTime fechaContratacion, int facturasEmitidas, decimal totalRecaudado)
            : base(id, nombre, "Cajero", salario, fechaContratacion)
        {
            FacturasEmitidas = facturasEmitidas;
            TotalRecaudado = totalRecaudado;
        }

        public override void RealizarTrabajo()
        {
            Console.WriteLine($"Cajero {Nombre} está procesando pagos y emitiendo facturas.");
        }

        public string EmitirFactura(decimal monto)
        {
            FacturasEmitidas++;
            TotalRecaudado += monto;
            return $"Factura #{FacturasEmitidas} emitida por {Nombre}. Monto: {monto:C}";
        }

        public override decimal CalcularSalario()
        {
           
            decimal comision = TotalRecaudado * 0.02m;
            return base.CalcularSalario() + comision;
        }
    }
}