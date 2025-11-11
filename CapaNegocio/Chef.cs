using System;

namespace CapaNegocio
{
    public class Chef : Empleado
    {
        public string Especialidad { get; set; }
        public int PlatillosPreparados { get; set; }

        public Chef() : base() { }

        public Chef(int id, string nombre, decimal salario, DateTime fechaContratacion, string especialidad, int platillosPreparados)
            : base(id, nombre, "Chef", salario, fechaContratacion)
        {
            Especialidad = especialidad;
            PlatillosPreparados = platillosPreparados;
        }

        public override void RealizarTrabajo()
        {
            Console.WriteLine($"Chef {Nombre} está cocinando en la especialidad: {Especialidad}");
        }

        public string PrepararPlatillo(string nombrePlatillo)
        {
            PlatillosPreparados++;
            return $"Platillo '{nombrePlatillo}' preparado por el chef {Nombre}. Total preparados: {PlatillosPreparados}";
        }

        public override decimal CalcularSalario()
        {
           
            decimal bono = PlatillosPreparados * 0.8m;
            return base.CalcularSalario() + bono;
        }
    }
}