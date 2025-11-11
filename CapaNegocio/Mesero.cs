using System;

namespace CapaNegocio
{
    public class Mesero : Empleado
    {
        public int OrdenesAtendidas { get; set; }

        public Mesero() : base() { }

        public Mesero(int id, string nombre, decimal salario, DateTime fechaContratacion, int ordenesAtendidas)
            : base(id, nombre, "Mesero", salario, fechaContratacion)
        {
            OrdenesAtendidas = ordenesAtendidas;
        }

        public override void RealizarTrabajo()
        {
            Console.WriteLine($"Mesero {Nombre} está atendiendo mesas y tomando órdenes.");
        }

        public string TomarOrden()
        {
            OrdenesAtendidas++;
            return $"Orden #{OrdenesAtendidas} tomada por el mesero {Nombre}";
        }

        public override decimal CalcularSalario()
        {
            
            return base.CalcularSalario() + (OrdenesAtendidas * 0.5m);
        }
    }
}