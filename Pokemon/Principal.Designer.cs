namespace Pokemon
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBoxLista = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lstBxPkmns = new System.Windows.Forms.ListBox();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.lbAltura_v = new System.Windows.Forms.Label();
            this.lbPeso_v = new System.Windows.Forms.Label();
            this.lbTipo_v = new System.Windows.Forms.Label();
            this.lbNaturaleza_v = new System.Windows.Forms.Label();
            this.lbNombre_v = new System.Windows.Forms.Label();
            this.lbID_v = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblClase = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBoxImagen = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.picBxPkmns = new System.Windows.Forms.PictureBox();
            this.groupBoxLista.SuspendLayout();
            this.groupBoxDatos.SuspendLayout();
            this.groupBoxImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxPkmns)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Snow;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnSalir.Location = new System.Drawing.Point(306, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(27, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitulo.Location = new System.Drawing.Point(8, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(85, 13);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Pokedex v0.7";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // groupBoxLista
            // 
            this.groupBoxLista.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBoxLista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxLista.BackgroundImage")));
            this.groupBoxLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxLista.Controls.Add(this.btnRegistrar);
            this.groupBoxLista.Controls.Add(this.lstBxPkmns);
            this.groupBoxLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLista.ForeColor = System.Drawing.Color.White;
            this.groupBoxLista.Location = new System.Drawing.Point(169, 36);
            this.groupBoxLista.Name = "groupBoxLista";
            this.groupBoxLista.Size = new System.Drawing.Size(150, 342);
            this.groupBoxLista.TabIndex = 2;
            this.groupBoxLista.TabStop = false;
            this.groupBoxLista.Text = "Lista";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(187)))), ((int)(((byte)(40)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Location = new System.Drawing.Point(6, 313);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(138, 23);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar nuevo pokemon";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lstBxPkmns
            // 
            this.lstBxPkmns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBxPkmns.BackColor = System.Drawing.Color.SteelBlue;
            this.lstBxPkmns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBxPkmns.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBxPkmns.ForeColor = System.Drawing.Color.Transparent;
            this.lstBxPkmns.Items.AddRange(new object[] {
            "1.-Bulbasaur",
            "2.-Venosaur",
            "3.-Ivisaur",
            "4.-Charmander",
            "5.-Charmaleon",
            "6.-Charizard"});
            this.lstBxPkmns.Location = new System.Drawing.Point(6, 19);
            this.lstBxPkmns.Name = "lstBxPkmns";
            this.lstBxPkmns.Size = new System.Drawing.Size(138, 286);
            this.lstBxPkmns.Sorted = true;
            this.lstBxPkmns.TabIndex = 0;
            this.lstBxPkmns.Click += new System.EventHandler(this.listBox1_Click);
            this.lstBxPkmns.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBoxDatos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxDatos.BackgroundImage")));
            this.groupBoxDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxDatos.Controls.Add(this.lbAltura_v);
            this.groupBoxDatos.Controls.Add(this.lbPeso_v);
            this.groupBoxDatos.Controls.Add(this.lbTipo_v);
            this.groupBoxDatos.Controls.Add(this.lbNaturaleza_v);
            this.groupBoxDatos.Controls.Add(this.lbNombre_v);
            this.groupBoxDatos.Controls.Add(this.lbID_v);
            this.groupBoxDatos.Controls.Add(this.lblAltura);
            this.groupBoxDatos.Controls.Add(this.lblPeso);
            this.groupBoxDatos.Controls.Add(this.lblTipo);
            this.groupBoxDatos.Controls.Add(this.lblClase);
            this.groupBoxDatos.Controls.Add(this.lblNombre);
            this.groupBoxDatos.Controls.Add(this.lblID);
            this.groupBoxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatos.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxDatos.Location = new System.Drawing.Point(12, 192);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(150, 186);
            this.groupBoxDatos.TabIndex = 1;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos";
            // 
            // lbAltura_v
            // 
            this.lbAltura_v.AutoSize = true;
            this.lbAltura_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAltura_v.Location = new System.Drawing.Point(71, 157);
            this.lbAltura_v.Name = "lbAltura_v";
            this.lbAltura_v.Size = new System.Drawing.Size(28, 13);
            this.lbAltura_v.TabIndex = 11;
            this.lbAltura_v.Text = "0.71";
            // 
            // lbPeso_v
            // 
            this.lbPeso_v.AutoSize = true;
            this.lbPeso_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeso_v.Location = new System.Drawing.Point(71, 132);
            this.lbPeso_v.Name = "lbPeso_v";
            this.lbPeso_v.Size = new System.Drawing.Size(22, 13);
            this.lbPeso_v.TabIndex = 10;
            this.lbPeso_v.Text = "6.9";
            // 
            // lbTipo_v
            // 
            this.lbTipo_v.AutoSize = true;
            this.lbTipo_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo_v.Location = new System.Drawing.Point(71, 106);
            this.lbTipo_v.Name = "lbTipo_v";
            this.lbTipo_v.Size = new System.Drawing.Size(37, 13);
            this.lbTipo_v.TabIndex = 9;
            this.lbTipo_v.Text = "Planta";
            // 
            // lbNaturaleza_v
            // 
            this.lbNaturaleza_v.AutoSize = true;
            this.lbNaturaleza_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNaturaleza_v.Location = new System.Drawing.Point(71, 79);
            this.lbNaturaleza_v.Name = "lbNaturaleza_v";
            this.lbNaturaleza_v.Size = new System.Drawing.Size(40, 13);
            this.lbNaturaleza_v.TabIndex = 8;
            this.lbNaturaleza_v.Text = "Semilla";
            // 
            // lbNombre_v
            // 
            this.lbNombre_v.AutoSize = true;
            this.lbNombre_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre_v.Location = new System.Drawing.Point(71, 53);
            this.lbNombre_v.Name = "lbNombre_v";
            this.lbNombre_v.Size = new System.Drawing.Size(54, 13);
            this.lbNombre_v.TabIndex = 7;
            this.lbNombre_v.Text = "Bulbasaur";
            // 
            // lbID_v
            // 
            this.lbID_v.AutoSize = true;
            this.lbID_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID_v.Location = new System.Drawing.Point(71, 27);
            this.lbID_v.Name = "lbID_v";
            this.lbID_v.Size = new System.Drawing.Size(13, 13);
            this.lbID_v.TabIndex = 6;
            this.lbID_v.Text = "1";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(6, 157);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(40, 13);
            this.lblAltura.TabIndex = 5;
            this.lblAltura.Text = "Altura";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(6, 132);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(35, 13);
            this.lblPeso.TabIndex = 4;
            this.lblPeso.Text = "Peso";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(6, 106);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(32, 13);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo";
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClase.Location = new System.Drawing.Point(6, 79);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(38, 13);
            this.lblClase.TabIndex = 2;
            this.lblClase.Text = "Clase";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(6, 27);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // groupBoxImagen
            // 
            this.groupBoxImagen.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBoxImagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxImagen.BackgroundImage")));
            this.groupBoxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxImagen.Controls.Add(this.btnEditar);
            this.groupBoxImagen.Controls.Add(this.picBxPkmns);
            this.groupBoxImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxImagen.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxImagen.Location = new System.Drawing.Point(12, 36);
            this.groupBoxImagen.Name = "groupBoxImagen";
            this.groupBoxImagen.Size = new System.Drawing.Size(150, 150);
            this.groupBoxImagen.TabIndex = 0;
            this.groupBoxImagen.TabStop = false;
            this.groupBoxImagen.Text = "Imagen";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditar.Location = new System.Drawing.Point(127, 124);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(20, 20);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            this.btnEditar.MouseEnter += new System.EventHandler(this.btnEditar_MouseEnter);
            this.btnEditar.MouseHover += new System.EventHandler(this.bt);
            // 
            // picBxPkmns
            // 
            this.picBxPkmns.BackColor = System.Drawing.Color.SteelBlue;
            this.picBxPkmns.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBxPkmns.BackgroundImage")));
            this.picBxPkmns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBxPkmns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBxPkmns.ImageLocation = "images/1.png";
            this.picBxPkmns.Location = new System.Drawing.Point(3, 16);
            this.picBxPkmns.Name = "picBxPkmns";
            this.picBxPkmns.Size = new System.Drawing.Size(144, 131);
            this.picBxPkmns.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBxPkmns.TabIndex = 0;
            this.picBxPkmns.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(333, 392);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBoxLista);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.groupBoxImagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.groupBoxLista.ResumeLayout(false);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.groupBoxImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxPkmns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxImagen;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.GroupBox groupBoxLista;
        private System.Windows.Forms.ListBox lstBxPkmns;
        private System.Windows.Forms.PictureBox picBxPkmns;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lbAltura_v;
        private System.Windows.Forms.Label lbPeso_v;
        private System.Windows.Forms.Label lbTipo_v;
        private System.Windows.Forms.Label lbNaturaleza_v;
        private System.Windows.Forms.Label lbNombre_v;
        private System.Windows.Forms.Label lbID_v;
        private System.Windows.Forms.Button btnEditar;
    }
}