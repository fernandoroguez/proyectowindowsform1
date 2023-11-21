namespace proyecto_wondows_form_1
{
    using System;
    using System.Collections;
    using System.Drawing;
    using System.IO;

    internal class Hardware
    {
        string nombre;
        char id_productor;
        int id;
        float precio;
        Boolean stock;
        int tamfoto;
        byte[]? foto;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public char IdProductor
        {
            get { return id_productor;}
            set { id_productor = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public Boolean Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public int Tamfoto
        {
            get { return tamfoto; }
            
        }
        public byte[] Foto
        {
            get { return foto; }
            set {  foto = value; }
        }

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
            this.foto = b;
            tamfoto = b.Length;
        }



        public void imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            foto = ms.ToArray();
            tamfoto = foto.Length;
        }

        public Image byteArrayToImage()
        {
            MemoryStream ms = new MemoryStream(foto);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
