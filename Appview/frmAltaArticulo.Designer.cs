namespace Appview
{
    partial class frmAltaArticulo
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
            this.txtCodArt = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtImg = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cbxMarcas = new System.Windows.Forms.ComboBox();
            this.cbxCategorias = new System.Windows.Forms.ComboBox();
            this.lblCodArt = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnAddImg = new System.Windows.Forms.Button();
            this.btnImgDB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodArt
            // 
            this.txtCodArt.Location = new System.Drawing.Point(144, 63);
            this.txtCodArt.Name = "txtCodArt";
            this.txtCodArt.Size = new System.Drawing.Size(100, 20);
            this.txtCodArt.TabIndex = 0;
            this.txtCodArt.Enter += new System.EventHandler(this.txtCodArt_Enter);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(144, 107);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(144, 154);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.Enter += new System.EventHandler(this.txtDescripcion_Enter);
            // 
            // txtImg
            // 
            this.txtImg.Location = new System.Drawing.Point(144, 274);
            this.txtImg.Name = "txtImg";
            this.txtImg.Size = new System.Drawing.Size(100, 20);
            this.txtImg.TabIndex = 5;
            this.txtImg.Enter += new System.EventHandler(this.txtImg_Enter);
            this.txtImg.Leave += new System.EventHandler(this.txtImg_Leave);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(144, 367);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 6;
            this.txtPrecio.Enter += new System.EventHandler(this.txtPrecio_Enter);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // cbxMarcas
            // 
            this.cbxMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarcas.FormattingEnabled = true;
            this.cbxMarcas.Location = new System.Drawing.Point(144, 195);
            this.cbxMarcas.Name = "cbxMarcas";
            this.cbxMarcas.Size = new System.Drawing.Size(100, 21);
            this.cbxMarcas.TabIndex = 3;
            // 
            // cbxCategorias
            // 
            this.cbxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategorias.FormattingEnabled = true;
            this.cbxCategorias.Location = new System.Drawing.Point(144, 234);
            this.cbxCategorias.Name = "cbxCategorias";
            this.cbxCategorias.Size = new System.Drawing.Size(100, 21);
            this.cbxCategorias.TabIndex = 4;
            // 
            // lblCodArt
            // 
            this.lblCodArt.AutoSize = true;
            this.lblCodArt.Location = new System.Drawing.Point(60, 69);
            this.lblCodArt.Name = "lblCodArt";
            this.lblCodArt.Size = new System.Drawing.Size(81, 13);
            this.lblCodArt.TabIndex = 7;
            this.lblCodArt.Text = "Codigo Articulo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(63, 113);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(63, 157);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(63, 198);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 13);
            this.lblMarca.TabIndex = 10;
            this.lblMarca.Text = "Marcas:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(63, 237);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(60, 13);
            this.lblCategoria.TabIndex = 11;
            this.lblCategoria.Text = "Categorias:";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(60, 277);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(61, 13);
            this.lblImagen.TabIndex = 12;
            this.lblImagen.Text = "Url Imagen:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(60, 370);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Precio:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(213, 406);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(358, 406);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(293, 79);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(341, 238);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 16;
            this.pbxArticulo.TabStop = false;
            // 
            // btnAddImg
            // 
            this.btnAddImg.Location = new System.Drawing.Point(124, 303);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Size = new System.Drawing.Size(142, 23);
            this.btnAddImg.TabIndex = 17;
            this.btnAddImg.Text = "Nueva Imagen";
            this.btnAddImg.UseVisualStyleBackColor = true;
            this.btnAddImg.Click += new System.EventHandler(this.btnAddImg_Click);
            // 
            // btnImgDB
            // 
            this.btnImgDB.Location = new System.Drawing.Point(124, 332);
            this.btnImgDB.Name = "btnImgDB";
            this.btnImgDB.Size = new System.Drawing.Size(142, 23);
            this.btnImgDB.TabIndex = 18;
            this.btnImgDB.Text = "Carpeta";
            this.btnImgDB.UseVisualStyleBackColor = true;
            this.btnImgDB.Click += new System.EventHandler(this.btnImgDB_Click);
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 468);
            this.Controls.Add(this.btnImgDB);
            this.Controls.Add(this.btnAddImg);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodArt);
            this.Controls.Add(this.cbxCategorias);
            this.Controls.Add(this.cbxMarcas);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtImg);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodArt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(669, 507);
            this.MinimumSize = new System.Drawing.Size(669, 507);
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Articulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodArt;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtImg;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cbxMarcas;
        private System.Windows.Forms.ComboBox cbxCategorias;
        private System.Windows.Forms.Label lblCodArt;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnAddImg;
        private System.Windows.Forms.Button btnImgDB;
    }
}