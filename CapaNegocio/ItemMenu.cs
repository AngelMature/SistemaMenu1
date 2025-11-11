using System;

namespace CapaNegocio
{
    public abstract class ItemMenu
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }

    
        public abstract string PrepararOrden();

     
        public virtual decimal CalcularPrecio()
        {
            return Precio;
        }

        public ItemMenu()
        {
            
        }

        public ItemMenu(int id, string nombre, decimal precio, string descripcion, string categoria)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Descripcion = descripcion;
            Categoria = categoria;
        }
    }
}