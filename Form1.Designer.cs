namespace Proyecto_AnimalesNocturnos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.lblespecie = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.txtespecie = new System.Windows.Forms.TextBox();
            this.btnagregaranimal = new System.Windows.Forms.Button();
            this.btnlistaanimales = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.LISTADOANIMALES = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombredelAnimal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipodeAnimal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Especie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnlimpiarlista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(176, 29);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(184, 13);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "LISTA DE ANIMALES NOCTURNOS";
            this.lbltitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(473, 66);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(473, 101);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre";
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(472, 138);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(28, 13);
            this.lbltipo.TabIndex = 3;
            this.lbltipo.Text = "Tipo";
            // 
            // lblespecie
            // 
            this.lblespecie.AutoSize = true;
            this.lblespecie.Location = new System.Drawing.Point(472, 173);
            this.lblespecie.Name = "lblespecie";
            this.lblespecie.Size = new System.Drawing.Size(45, 13);
            this.lblespecie.TabIndex = 4;
            this.lblespecie.Text = "Especie";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(523, 63);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 5;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(523, 98);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 6;
            // 
            // txttipo
            // 
            this.txttipo.Location = new System.Drawing.Point(523, 135);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(100, 20);
            this.txttipo.TabIndex = 7;
            // 
            // txtespecie
            // 
            this.txtespecie.Location = new System.Drawing.Point(523, 170);
            this.txtespecie.Name = "txtespecie";
            this.txtespecie.Size = new System.Drawing.Size(100, 20);
            this.txtespecie.TabIndex = 8;
            // 
            // btnagregaranimal
            // 
            this.btnagregaranimal.Location = new System.Drawing.Point(523, 228);
            this.btnagregaranimal.Name = "btnagregaranimal";
            this.btnagregaranimal.Size = new System.Drawing.Size(100, 34);
            this.btnagregaranimal.TabIndex = 9;
            this.btnagregaranimal.Text = "Agregar Animal";
            this.btnagregaranimal.UseVisualStyleBackColor = true;
            this.btnagregaranimal.Click += new System.EventHandler(this.btnagregaranimal_Click);
            // 
            // btnlistaanimales
            // 
            this.btnlistaanimales.Location = new System.Drawing.Point(523, 278);
            this.btnlistaanimales.Name = "btnlistaanimales";
            this.btnlistaanimales.Size = new System.Drawing.Size(100, 34);
            this.btnlistaanimales.TabIndex = 10;
            this.btnlistaanimales.Text = "Lista de Animales";
            this.btnlistaanimales.UseVisualStyleBackColor = true;
            this.btnlistaanimales.Click += new System.EventHandler(this.btnlistaanimales_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(523, 417);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(100, 23);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // LISTADOANIMALES
            // 
            this.LISTADOANIMALES.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.NombredelAnimal,
            this.TipodeAnimal,
            this.Especie});
            this.LISTADOANIMALES.HideSelection = false;
            this.LISTADOANIMALES.Location = new System.Drawing.Point(53, 66);
            this.LISTADOANIMALES.Name = "LISTADOANIMALES";
            this.LISTADOANIMALES.Size = new System.Drawing.Size(403, 341);
            this.LISTADOANIMALES.TabIndex = 12;
            this.LISTADOANIMALES.UseCompatibleStateImageBehavior = false;
            this.LISTADOANIMALES.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 35;
            // 
            // NombredelAnimal
            // 
            this.NombredelAnimal.Text = "Nombre del Animal";
            this.NombredelAnimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NombredelAnimal.Width = 135;
            // 
            // TipodeAnimal
            // 
            this.TipodeAnimal.Text = "Tipo de Animal";
            this.TipodeAnimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TipodeAnimal.Width = 115;
            // 
            // Especie
            // 
            this.Especie.Text = "Especie";
            this.Especie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Especie.Width = 115;
            // 
            // btnlimpiarlista
            // 
            this.btnlimpiarlista.Location = new System.Drawing.Point(523, 330);
            this.btnlimpiarlista.Name = "btnlimpiarlista";
            this.btnlimpiarlista.Size = new System.Drawing.Size(100, 34);
            this.btnlimpiarlista.TabIndex = 13;
            this.btnlimpiarlista.Text = "Limpiar Lista";
            this.btnlimpiarlista.UseVisualStyleBackColor = true;
            this.btnlimpiarlista.Click += new System.EventHandler(this.btnlimpiarlista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 452);
            this.Controls.Add(this.btnlimpiarlista);
            this.Controls.Add(this.LISTADOANIMALES);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlistaanimales);
            this.Controls.Add(this.btnagregaranimal);
            this.Controls.Add(this.txtespecie);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblespecie);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label lblespecie;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.TextBox txtespecie;
        private System.Windows.Forms.Button btnagregaranimal;
        private System.Windows.Forms.Button btnlistaanimales;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.ListView LISTADOANIMALES;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader NombredelAnimal;
        private System.Windows.Forms.ColumnHeader TipodeAnimal;
        private System.Windows.Forms.ColumnHeader Especie;
        private System.Windows.Forms.Button btnlimpiarlista;
    }
}

