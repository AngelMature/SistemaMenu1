using System;

namespace CapaNegocio
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }

        public Producto() { }

        public Producto(int id, string nombre, string tipo, decimal precio, string descripcion, string categoria)
        {
            Id = id;
            Nombre = nombre;
            Tipo = tipo;
            Precio = precio;
            Descripcion = descripcion;
            Categoria = categoria;
        }
    }
}