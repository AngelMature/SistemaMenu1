using System;

namespace CapaNegocio
{
    public class Bebida : ItemMenu
    {
        public string Tamano { get; set; }
        public bool EsAlcoholica { get; set; }

        public Bebida() : base() { }

        public Bebida(int id, string nombre, decimal precio, string descripcion, string categoria, string tamano, bool esAlcoholica)
            : base(id, nombre, precio, descripcion, categoria)
        {
            Tamano = tamano;
            EsAlcoholica = esAlcoholica;
        }

        public override string PrepararOrden()
        {
            string tipo = EsAlcoholica ? "bebida alcohólica" : "bebida no alcohólica";
            return $"Sirviendo {tipo}: {Nombre}. Tamaño: {Tamano}";
        }

        public override decimal CalcularPrecio()
        {
            decimal precioFinal = Precio;
            if (EsAlcoholica)
            {
                precioFinal *= 1.10m; 
            }
            return precioFinal;
        }
    }
}