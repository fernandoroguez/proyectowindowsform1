using System.ComponentModel;

namespace proyecto_wondows_form_1
{
    public partial class Form1 : Form
    {


        List<Hardware> lista;

        int index = 0;

        Boolean crear = false;
        Boolean mod = false;

        public Form1()
        {
            InitializeComponent();
            lista = new List<Hardware>();
            //en cuanto inicio el programa lo primero que hago es cargar los archivos del fichero
            cargar();
            mostrar();
            act_modificar();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);

        }

        public void mostrar()
        {
            try
            {


                Hardware h = lista[index];
                txtcodigo.Text = Convert.ToString(lista[index].Id);
                txtfabricante.Text = Convert.ToString(lista[index].IdProductor);
                txtnombre.Text = lista[index].Nombre;
                txtPrecio.Text = Convert.ToString(lista[index].Precio);
                if (lista[index].Stock)
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
            catch (Exception)
            {

            }
        }
        public void aceptar()
        {
            Hardware h;

            try
            {


                Boolean aux = ckbstock.Checked;
                string auxs = txtnombre.Text;
                int auxint = Convert.ToInt32(txtcodigo.Text);
                char auxchar = Convert.ToChar(txtfabricante.Text);
                float auxfloat = float.Parse(txtPrecio.Text);
                h = new Hardware(auxs, auxchar, auxint, auxfloat, aux);

                try
                {
                    Image auxi = Image.FromFile(txtpath.Text);
                    h.imageToByteArray(auxi);
                }
                catch (Exception) { }
                lista.Add(h);


                cancelar();
            }
            catch (Exception)
            {
                MessageBox.Show("Faltan datos por introducir(la foto es opcional)");
            }

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
            btnfiles.Visible = false;
            mod = false;
            act_modificar();
        }

        public void vaciado()
        {
            txtcodigo.Text = "";
            txtfabricante.Text = "";
            txtnombre.Text = "";
            txtPrecio.Text = "";
            txtpath.Text = "";
        }

        public void creacion()
        {

            btnsiguiente.Text = "Aceptar";
            btnatras.Text = "Cancelar";
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
            btnfiles.Visible = true;
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
                    fichero.Write(lista[i].Nombre);
                    fichero.Write(lista[i].IdProductor);
                    fichero.Write(lista[i].Id);
                    fichero.Write(lista[i].Precio);
                    fichero.Write(lista[i].Stock);
                    fichero.Write(lista[i].Tamfoto);
                    fichero.Write(lista[i].Foto);
                }

                fichero.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha abierto el fichero para guardar");
            }
        }

        private void activar_mod()
        {
            btnmodificar.Enabled = true;
        }

        private void desactivar_mod()
        {
            btnmodificar.Enabled = false;
        }

        public void act_modificar()
        {
            if (lista.Count > 0)
            {
                btnmodificar.Enabled=true;
            }
            else
            {
                btnmodificar.Enabled=false;
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            guardar();
        }

        private void cargar()
        {
            string nombre = "";
            char id_productor;
            int id = 0;
            float precio = 0;
            Boolean stock = false;
            int lon;


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
            catch (Exception)
            {
                MessageBox.Show("No se ha abierto el fichero");
            }
        }

        public void aniadir_cargar(
            string nombre,
            char id_p,
            int id,
            float precio,
            Boolean stock,
            byte[] b
        )
        {
            Hardware j = new Hardware(nombre, id_p, id, precio, stock, b);
            lista.Add(j);
        }

        public void modificar()
        {
            lista[index].Stock = ckbstock.Checked;
            lista[index].Nombre = txtnombre.Text;
            lista[index].Id = Convert.ToInt32(txtcodigo.Text);
            lista[index].IdProductor = Convert.ToChar(txtfabricante.Text);
            lista[index].Precio = float.Parse(txtPrecio.Text);


            try
            {
                Image? auxi = Image.FromFile(txtpath.Text);
                lista[index].imageToByteArray(auxi);

            }
            catch (Exception) { }





            cancelar();

        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            if (crear || mod)
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
            else if (mod)
            {
                modificar();
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
            crear = true;
            vaciado();
            creacion();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            lista.RemoveAt(index);
            index = 0;
            if (lista.Count == 0)
            {
                desactivar_mod();
            }
            else
            {
                activar_mod();
            }
            act_modificar();
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

        private void btnfiles_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string str_RutaArchivo = openFileDialog1.FileName;
                    txtpath.Text = str_RutaArchivo;
                }
                catch (Exception) { }
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            mod = true;
            creacion();
        }
    }
}
