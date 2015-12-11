namespace Pokemon
{
    partial class PrincipalJugador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalJugador));
            this.groupBoxLista = new System.Windows.Forms.GroupBox();
            this.lstBxPkmns = new System.Windows.Forms.ListBox();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.lblTipo2 = new System.Windows.Forms.Label();
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
            this.picBxPkmns = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCapturados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxLista.SuspendLayout();
            this.groupBoxDatos.SuspendLayout();
            this.groupBoxImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxPkmns)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLista
            // 
            this.groupBoxLista.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBoxLista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxLista.BackgroundImage")));
            this.groupBoxLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxLista.Controls.Add(this.lstBxPkmns);
            this.groupBoxLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLista.ForeColor = System.Drawing.Color.White;
            this.groupBoxLista.Location = new System.Drawing.Point(169, 76);
            this.groupBoxLista.Name = "groupBoxLista";
            this.groupBoxLista.Size = new System.Drawing.Size(150, 342);
            this.groupBoxLista.TabIndex = 5;
            this.groupBoxLista.TabStop = false;
            this.groupBoxLista.Text = "Lista";
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
            ""});
            this.lstBxPkmns.Location = new System.Drawing.Point(6, 19);
            this.lstBxPkmns.Name = "lstBxPkmns";
            this.lstBxPkmns.Size = new System.Drawing.Size(138, 312);
            this.lstBxPkmns.TabIndex = 0;
            this.lstBxPkmns.SelectedIndexChanged += new System.EventHandler(this.lstBxPkmns_SelectedIndexChanged);
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBoxDatos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxDatos.BackgroundImage")));
            this.groupBoxDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxDatos.Controls.Add(this.lblTipo2);
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
            this.groupBoxDatos.Location = new System.Drawing.Point(12, 232);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(150, 186);
            this.groupBoxDatos.TabIndex = 4;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos";
            // 
            // lblTipo2
            // 
            this.lblTipo2.AutoSize = true;
            this.lblTipo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo2.Location = new System.Drawing.Point(71, 109);
            this.lblTipo2.Name = "lblTipo2";
            this.lblTipo2.Size = new System.Drawing.Size(25, 13);
            this.lblTipo2.TabIndex = 12;
            this.lblTipo2.Text = "???";
            // 
            // lbAltura_v
            // 
            this.lbAltura_v.AutoSize = true;
            this.lbAltura_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAltura_v.Location = new System.Drawing.Point(71, 161);
            this.lbAltura_v.Name = "lbAltura_v";
            this.lbAltura_v.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbAltura_v.Size = new System.Drawing.Size(25, 13);
            this.lbAltura_v.TabIndex = 11;
            this.lbAltura_v.Text = "???";
            // 
            // lbPeso_v
            // 
            this.lbPeso_v.AutoSize = true;
            this.lbPeso_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeso_v.Location = new System.Drawing.Point(71, 136);
            this.lbPeso_v.Name = "lbPeso_v";
            this.lbPeso_v.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPeso_v.Size = new System.Drawing.Size(25, 13);
            this.lbPeso_v.TabIndex = 10;
            this.lbPeso_v.Text = "???";
            // 
            // lbTipo_v
            // 
            this.lbTipo_v.AutoSize = true;
            this.lbTipo_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo_v.Location = new System.Drawing.Point(71, 87);
            this.lbTipo_v.Name = "lbTipo_v";
            this.lbTipo_v.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTipo_v.Size = new System.Drawing.Size(25, 13);
            this.lbTipo_v.TabIndex = 9;
            this.lbTipo_v.Text = "???";
            // 
            // lbNaturaleza_v
            // 
            this.lbNaturaleza_v.AutoSize = true;
            this.lbNaturaleza_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNaturaleza_v.Location = new System.Drawing.Point(71, 62);
            this.lbNaturaleza_v.Name = "lbNaturaleza_v";
            this.lbNaturaleza_v.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbNaturaleza_v.Size = new System.Drawing.Size(25, 13);
            this.lbNaturaleza_v.TabIndex = 8;
            this.lbNaturaleza_v.Text = "???";
            // 
            // lbNombre_v
            // 
            this.lbNombre_v.AutoSize = true;
            this.lbNombre_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre_v.Location = new System.Drawing.Point(71, 38);
            this.lbNombre_v.Name = "lbNombre_v";
            this.lbNombre_v.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbNombre_v.Size = new System.Drawing.Size(25, 13);
            this.lbNombre_v.TabIndex = 7;
            this.lbNombre_v.Text = "???";
            // 
            // lbID_v
            // 
            this.lbID_v.AutoSize = true;
            this.lbID_v.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID_v.Location = new System.Drawing.Point(71, 16);
            this.lbID_v.Name = "lbID_v";
            this.lbID_v.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbID_v.Size = new System.Drawing.Size(25, 13);
            this.lbID_v.TabIndex = 6;
            this.lbID_v.Text = "???";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(6, 161);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAltura.Size = new System.Drawing.Size(40, 13);
            this.lblAltura.TabIndex = 5;
            this.lblAltura.Text = "Altura";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(6, 136);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPeso.Size = new System.Drawing.Size(35, 13);
            this.lblPeso.TabIndex = 4;
            this.lblPeso.Text = "Peso";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(6, 87);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTipo.Size = new System.Drawing.Size(32, 13);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo";
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClase.Location = new System.Drawing.Point(6, 62);
            this.lblClase.Name = "lblClase";
            this.lblClase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblClase.Size = new System.Drawing.Size(38, 13);
            this.lblClase.TabIndex = 2;
            this.lblClase.Text = "Clase";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(6, 16);
            this.lblID.Name = "lblID";
            this.lblID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblID.Size = new System.Drawing.Size(20, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // groupBoxImagen
            // 
            this.groupBoxImagen.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBoxImagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxImagen.BackgroundImage")));
            this.groupBoxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxImagen.Controls.Add(this.picBxPkmns);
            this.groupBoxImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxImagen.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBoxImagen.Location = new System.Drawing.Point(12, 76);
            this.groupBoxImagen.Name = "groupBoxImagen";
            this.groupBoxImagen.Size = new System.Drawing.Size(150, 150);
            this.groupBoxImagen.TabIndex = 3;
            this.groupBoxImagen.TabStop = false;
            this.groupBoxImagen.Text = "Imagen";
            // 
            // picBxPkmns
            // 
            this.picBxPkmns.BackColor = System.Drawing.Color.SteelBlue;
            this.picBxPkmns.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBxPkmns.BackgroundImage")));
            this.picBxPkmns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBxPkmns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBxPkmns.ImageLocation = "";
            this.picBxPkmns.Location = new System.Drawing.Point(3, 16);
            this.picBxPkmns.Name = "picBxPkmns";
            this.picBxPkmns.Size = new System.Drawing.Size(144, 131);
            this.picBxPkmns.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBxPkmns.TabIndex = 0;
            this.picBxPkmns.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitulo.Location = new System.Drawing.Point(8, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(85, 13);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Pokedex v1.6";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Snow;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSalir.Location = new System.Drawing.Point(306, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(27, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.Gold;
            this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugar.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.ForeColor = System.Drawing.Color.White;
            this.btnJugar.Location = new System.Drawing.Point(180, 25);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(120, 45);
            this.btnJugar.TabIndex = 11;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(18, 33);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(75, 13);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Nombre";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCapturados
            // 
            this.lblCapturados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapturados.ForeColor = System.Drawing.Color.White;
            this.lblCapturados.Location = new System.Drawing.Point(49, 48);
            this.lblCapturados.Name = "lblCapturados";
            this.lblCapturados.Size = new System.Drawing.Size(13, 13);
            this.lblCapturados.TabIndex = 13;
            this.lblCapturados.Text = "/";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "000";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "000";
            // 
            // PrincipalJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(333, 430);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCapturados);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBoxLista);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.groupBoxImagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrincipalJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrincipalJugador";
            this.groupBoxLista.ResumeLayout(false);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.groupBoxImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxPkmns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLista;
        private System.Windows.Forms.ListBox lstBxPkmns;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Label lblTipo2;
        private System.Windows.Forms.Label lbAltura_v;
        private System.Windows.Forms.Label lbPeso_v;
        private System.Windows.Forms.Label lbTipo_v;
        private System.Windows.Forms.Label lbNaturaleza_v;
        private System.Windows.Forms.Label lbNombre_v;
        private System.Windows.Forms.Label lbID_v;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox groupBoxImagen;
        private System.Windows.Forms.PictureBox picBxPkmns;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCapturados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}