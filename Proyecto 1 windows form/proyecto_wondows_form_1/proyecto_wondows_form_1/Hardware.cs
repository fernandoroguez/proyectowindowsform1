﻿namespace proyecto_wondows_form_1
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Collections;

    internal class Hardware
    {
        string nombre;
        char id_productor;
        int id;
        float precio;
        Boolean stock;
        int tamfoto;
        byte[] foto;

        public Hardware(string nombre, char id, int almacen, float precio, bool stock)
        {
            this.nombre = nombre;
            this.id_productor = id;
            this.id = almacen;
            this.precio = precio;
            this.stock = stock;
        }
        public Hardware(string nombre, char id, int almacen, float precio, bool stock, byte[] b)
        {
            this.nombre = nombre;
            this.id_productor = id;
            this.id = almacen;
            this.precio = precio;
            this.stock = stock;
            //for(int i = 0; i < b.Length; i++)
            //{
            //    foto[i] = b[i];
            //}
            this.foto= b;
            tamfoto = b.Length;
        }

        public string getnombre()
        {
            return nombre;
        }
        public char getId_productor()
        {
            return id_productor;
        }

        public int getid()
        {
            return id;
        }
        public float getprecio()
        {
            return precio;
        }
        public Boolean getstock()
        {
            return stock;
        }

        public int getlenght()
        {
            return tamfoto;
        }
        public byte[] getfoto()
        {
            return foto;
        }

        public void imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            foto = ms.ToArray();
            tamfoto=foto.Length;
           // MessageBox.Show("" + tamfoto);
        }
        public Image byteArrayToImage()
        {
            MemoryStream ms = new MemoryStream(foto);
            Image returnImage = Image.FromStream(ms);
            return returnImage;

        }

    }
}