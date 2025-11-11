using System;

namespace CapaNegocio
{
    public abstract class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public decimal Salario { get; set; }
        public DateTime FechaContratacion { get; set; }

       
        public abstract void RealizarTrabajo();

      
        public virtual decimal CalcularSalario()
        {
            return Salario;
        }

        public Empleado()
        {
        }

        public Empleado(int id, string nombre, string tipo, decimal salario, DateTime fechaContratacion)
        {
            Id = id;
            Nombre = nombre;
            Tipo = tipo;
            Salario = salario;
            FechaContratacion = fechaContratacion;
        }
    }
}