using System.ComponentModel;

namespace proyecto_wondows_form_1
{
    public partial class Form1 : Form
    {

        List<Hardware> lista;

        int index = 0;

        Boolean crear = false;

        public Form1()
        {
            InitializeComponent();
            lista = new List<Hardware>();
            cargar();
            mostrar();
        }


        public void mostrar()
        {
            Hardware h = lista[index];
            txtcodigo.Text = Convert.ToString(lista[index].getid());
            txtfabricante.Text = Convert.ToString(lista[index].getId_productor());
            txtnombre.Text = lista[index].getnombre();
            txtPrecio.Text = Convert.ToString(lista[index].getprecio());
            if (lista[index].getstock())
            {
                ckbstock.Checked = true;
            }
            else
            {
                ckbstock.Checked = false;
            }
            foto.Image = lista[index].byteArrayToImage();
            txtcount.Text = "" + lista.Count();
        }

        public void aceptar()
        {
            Boolean aux = ckbstock.Checked;
            string auxs = txtnombre.Text;
            int auxint = Convert.ToInt32(txtcodigo.Text);
            char auxchar = Convert.ToChar(txtfabricante.Text);
            float auxfloat = float.Parse(txtPrecio.Text);
            Hardware h = new Hardware(auxs, auxchar, auxint, auxfloat, aux);
            Image auxi = Image.FromFile(txtpath.Text);
            h.imageToByteArray(auxi);
            lista.Add(h);
            cancelar();
        }

        public void cancelar()
        {
            txtcodigo.ReadOnly = true;
            txtfabricante.ReadOnly = true;
            txtnombre.ReadOnly = true;
            txtPrecio.ReadOnly = true;
            ckbstock.AutoCheck = false;
            crear = false;
            index = 0;
            btnsiguiente.Text = "Siguiente";
            btnatras.Text = "Anterior";
            foto.Visible = true;
            txtpath.Visible = false;
            lblpath.Visible = false;
            btncrear.Enabled = true;
            btneliminar.Enabled = true;
            btncargar.Enabled = true;
            btnguardar.Enabled = true;
        }

        public void creacion()
        {
            crear = true;
            btnsiguiente.Text = "Aceptar";
            btnatras.Text = "Cancelar";
            txtcodigo.Text = "";
            txtfabricante.Text = "";
            txtnombre.Text = "";
            txtPrecio.Text = "";
            txtpath.Text = "";
            txtcodigo.ReadOnly = false;
            txtfabricante.ReadOnly = false;
            txtnombre.ReadOnly = false;
            txtPrecio.ReadOnly = false;
            ckbstock.AutoCheck = true;
            foto.Visible = false;
            txtpath.Visible = true;
            lblpath.Visible = true;
            btneliminar.Enabled = false;
            btncrear.Enabled = false;
            btnguardar.Enabled = false;
            btncargar.Enabled = false;
        }

        private void guardar()
        {
            BinaryWriter fichero;

            try
            {
                fichero = new BinaryWriter(File.Open("databank.data", FileMode.Create));
                int cont = lista.Count;
                fichero.Write(cont);
                for (int i = 0; i < lista.Count; i++)
                {
                    fichero.Write(lista[i].getnombre());
                    fichero.Write(lista[i].getId_productor());
                    fichero.Write(lista[i].getid());
                    fichero.Write(lista[i].getprecio());
                    fichero.Write(lista[i].getstock());
                    fichero.Write(lista[i].getlenght());
                    fichero.Write(lista[i].getfoto());
                }

                fichero.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se ha abierto el fichero");
            }
        }

        private void cargar()
        {

            string nombre = "";
            char id_productor;
            int id = 0;
            float precio = 0;
            Boolean stock = false;
            int lon;
            byte[] cab;

            try
            {
                BinaryReader fichero = new BinaryReader(File.Open("databank.data", FileMode.Open));
                int cont = fichero.ReadInt32();
                for (int i = 0; i < cont; i++)
                {

                    nombre = fichero.ReadString();



                    id_productor = fichero.ReadChar();


                    id = fichero.ReadInt32();

                    precio = fichero.ReadSingle();

                    stock = fichero.ReadBoolean();
                    lon = fichero.ReadInt32();


                    byte[] b2 = fichero.ReadBytes(lon);

                    aniadir_cargar(nombre, id_productor, id, precio, stock, b2);

                }
                

                fichero.Close();
                txtcount.Text = "" + lista.Count();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se ha abierto el fichero");
            }
        }



        public void aniadir_cargar(string nombre, char id_p, int id, float precio, Boolean stock, byte[] b)
        {

            Hardware j = new Hardware(nombre, id_p, id, precio, stock, b);
            lista.Add(j);
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            if (crear)
            {
                cancelar();
            }
            else
            {
                if (index > 0)
                    index--;
            }
            mostrar();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if (crear)
            {
                aceptar();
            }
            else
            {
                if (index < lista.Count - 1)
                    index++;

            }
            mostrar();
        }

       

        private void btncrear_Click(object sender, EventArgs e)
        {

            creacion();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            lista.RemoveAt(index);
            index = 0;
            mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}