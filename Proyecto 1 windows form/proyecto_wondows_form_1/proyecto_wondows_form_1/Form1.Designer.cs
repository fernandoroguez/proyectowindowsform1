namespace proyecto_wondows_form_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            txtcount = new TextBox();
            lblcount = new Label();
            btneliminar = new Button();
            btncrear = new Button();
            btnsiguiente = new Button();
            btnatras = new Button();
            txtPrecio = new TextBox();
            ckbstock = new CheckBox();
            txtfabricante = new TextBox();
            txtcodigo = new TextBox();
            txtnombre = new TextBox();
            lblPrecio = new Label();
            lblStock = new Label();
            lblCodigo = new Label();
            lblFabricante = new Label();
            lblNombre = new Label();
            lblpath = new Label();
            txtpath = new TextBox();
            foto = new PictureBox();
            btnguardar = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)foto).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnguardar);
            splitContainer1.Panel1.Controls.Add(txtcount);
            splitContainer1.Panel1.Controls.Add(lblcount);
            splitContainer1.Panel1.Controls.Add(btneliminar);
            splitContainer1.Panel1.Controls.Add(btncrear);
            splitContainer1.Panel1.Controls.Add(btnsiguiente);
            splitContainer1.Panel1.Controls.Add(btnatras);
            splitContainer1.Panel1.Controls.Add(txtPrecio);
            splitContainer1.Panel1.Controls.Add(ckbstock);
            splitContainer1.Panel1.Controls.Add(txtfabricante);
            splitContainer1.Panel1.Controls.Add(txtcodigo);
            splitContainer1.Panel1.Controls.Add(txtnombre);
            splitContainer1.Panel1.Controls.Add(lblPrecio);
            splitContainer1.Panel1.Controls.Add(lblStock);
            splitContainer1.Panel1.Controls.Add(lblCodigo);
            splitContainer1.Panel1.Controls.Add(lblFabricante);
            splitContainer1.Panel1.Controls.Add(lblNombre);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lblpath);
            splitContainer1.Panel2.Controls.Add(txtpath);
            splitContainer1.Panel2.Controls.Add(foto);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // txtcount
            // 
            txtcount.Location = new Point(183, 407);
            txtcount.Name = "txtcount";
            txtcount.ReadOnly = true;
            txtcount.Size = new Size(37, 23);
            txtcount.TabIndex = 15;
            // 
            // lblcount
            // 
            lblcount.AutoSize = true;
            lblcount.Location = new Point(18, 415);
            lblcount.Name = "lblcount";
            lblcount.Size = new Size(159, 15);
            lblcount.TabIndex = 14;
            lblcount.Text = "numero de registros actuales";
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(10, 255);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(75, 23);
            btneliminar.TabIndex = 13;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // btncrear
            // 
            btncrear.Location = new Point(175, 255);
            btncrear.Name = "btncrear";
            btncrear.Size = new Size(75, 23);
            btncrear.TabIndex = 12;
            btncrear.Text = "Crear";
            btncrear.UseVisualStyleBackColor = true;
            btncrear.Click += btncrear_Click;
            // 
            // btnsiguiente
            // 
            btnsiguiente.Location = new Point(175, 207);
            btnsiguiente.Name = "btnsiguiente";
            btnsiguiente.Size = new Size(75, 23);
            btnsiguiente.TabIndex = 11;
            btnsiguiente.Text = "Siguiente";
            btnsiguiente.UseVisualStyleBackColor = true;
            btnsiguiente.Click += btnsiguiente_Click;
            // 
            // btnatras
            // 
            btnatras.Location = new Point(10, 207);
            btnatras.Name = "btnatras";
            btnatras.Size = new Size(75, 23);
            btnatras.TabIndex = 10;
            btnatras.Text = "Anterior";
            btnatras.UseVisualStyleBackColor = true;
            btnatras.Click += btnatras_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(150, 124);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 9;
            // 
            // ckbstock
            // 
            ckbstock.AutoCheck = false;
            ckbstock.AutoSize = true;
            ckbstock.Location = new Point(231, 100);
            ckbstock.Name = "ckbstock";
            ckbstock.Size = new Size(15, 14);
            ckbstock.TabIndex = 8;
            ckbstock.UseVisualStyleBackColor = true;
            // 
            // txtfabricante
            // 
            txtfabricante.Location = new Point(149, 40);
            txtfabricante.Name = "txtfabricante";
            txtfabricante.ReadOnly = true;
            txtfabricante.Size = new Size(100, 23);
            txtfabricante.TabIndex = 7;
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(150, 11);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.ReadOnly = true;
            txtcodigo.Size = new Size(100, 23);
            txtcodigo.TabIndex = 6;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(149, 69);
            txtnombre.Name = "txtnombre";
            txtnombre.ReadOnly = true;
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 5;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(12, 127);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(12, 99);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(157, 15);
            lblStock.TabIndex = 3;
            lblStock.Text = "Hay existencias actualmente";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 14);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(117, 15);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "Codigo del producto";
            // 
            // lblFabricante
            // 
            lblFabricante.AutoSize = true;
            lblFabricante.Location = new Point(12, 43);
            lblFabricante.Name = "lblFabricante";
            lblFabricante.Size = new Size(123, 15);
            lblFabricante.TabIndex = 1;
            lblFabricante.Text = "Codigo del Fabricante";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 72);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblpath
            // 
            lblpath.AutoSize = true;
            lblpath.Location = new Point(44, 364);
            lblpath.Name = "lblpath";
            lblpath.Size = new Size(150, 15);
            lblpath.TabIndex = 2;
            lblpath.Text = "Introduce el path de la foto";
            lblpath.Visible = false;
            // 
            // txtpath
            // 
            txtpath.Location = new Point(44, 384);
            txtpath.Name = "txtpath";
            txtpath.Size = new Size(100, 23);
            txtpath.TabIndex = 1;
            txtpath.Visible = false;
            // 
            // foto
            // 
            foto.Enabled = false;
            foto.Location = new Point(18, 14);
            foto.Name = "foto";
            foto.Size = new Size(484, 331);
            foto.TabIndex = 0;
            foto.TabStop = false;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(10, 298);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(75, 23);
            btnguardar.TabIndex = 16;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)foto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label lblNombre;
        private Label lblStock;
        private Label lblCodigo;
        private Label lblFabricante;
        private Label lblPrecio;
        private TextBox txtnombre;
        private TextBox txtfabricante;
        private TextBox txtcodigo;
        private TextBox txtPrecio;
        private CheckBox ckbstock;
        private PictureBox foto;
        private Button btnatras;
        private Button btnsiguiente;
        private Button btncrear;
        private Button btneliminar;
        private TextBox txtpath;
        private Label lblpath;
        private Label lblcount;
        private TextBox txtcount;
        private Button btnguardar;
    }
}