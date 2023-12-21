using System;

namespace ProyectoWindowsForms_Irene
{
    public class Cliente
    {
        public string? nombre { get; set; }
        public string? apellido { get; set; }
        public int telefono { get; set; }
        public char genero { get; set; }
        public bool tipo1 { get; set; }
        public bool tipo2 { get; set; }
        public byte[] imagen { get; set; }
        public float precio { get; set; }


        public Cliente(string nombre, string apellido, int telefono, char genero, bool tipo1, bool tipo2,  byte[] imagen,float precio)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.genero = genero;
            this.tipo1 = tipo1;
            this.tipo2 = tipo2;
            this.imagen = imagen;
            this.precio = precio;
        }

    }
}
