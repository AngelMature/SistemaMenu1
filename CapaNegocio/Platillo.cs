using System;

namespace CapaNegocio
{
    public class Platillo : ItemMenu
    {
        public string TiempoPreparacion { get; set; }

        public Platillo() : base() { }

        public Platillo(int id, string nombre, decimal precio, string descripcion, string categoria, string tiempoPreparacion)
            : base(id, nombre, precio, descripcion, categoria)
        {
            TiempoPreparacion = tiempoPreparacion;
        }

        public override string PrepararOrden()
        {
            return $"Preparando platillo: {Nombre}. Tiempo estimado: {TiempoPreparacion}";
        }

        public override decimal CalcularPrecio()
        {
            
            return base.CalcularPrecio();
        }
    }
}