using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Appview
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog img = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo modificar)
        {
            InitializeComponent();
            articulo = modificar;
            Text = "Modificar Articulo";
        }

        private void txtImg_Leave(object sender, EventArgs e)
        {
            cargarImagen();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            if(articulo == null)
                articulo = new Articulo();

            try
            {
                if (mostrarRequeridos())
                {
                    articulo.CodArticulo = txtCodArt.Text;
                    articulo.Nombre = txtNombre.Text;
                    articulo.Descripcion = txtDescripcion.Text;
                    articulo.Marca = (Tipo)cbxMarcas.SelectedItem;
                    articulo.Categoria = (Tipo)cbxCategorias.SelectedItem;
                    if (img != null && !(txtImg.Text.ToUpper().Contains("HTTP")))
                    {
                        if (!(txtImg.Text.Contains("C:\\Catalogo_DB")))
                        {
                        File.Copy(img.FileName, ConfigurationManager.AppSettings["images-folder"] + img.SafeFileName);
                        }
                        articulo.UrlImagen = ConfigurationManager.AppSettings["images-folder"] + img.SafeFileName;
                    }
                    else
                        articulo.UrlImagen = txtImg.Text;

                    articulo.Precio = decimal.Parse(txtPrecio.Text);

                    if (articulo.Id != 0)
                    {
                        negocio.modificar(articulo);
                        MessageBox.Show("Modificado exitosamente");
                        Close();
                    }
                    else
                    {
                        negocio.agregar(articulo);

                        MessageBox.Show("Agregado exitosamente");
                        Close();
                    }
                }








            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("La imagen ya se encuentra en nuestra base de datos... Intente entrando a la Carpeta debajo para buscarla");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio Tipo = new CategoriaNegocio();
            try
            {
                cbxCategorias.DataSource = Tipo.listar("Categorias");
                cbxCategorias.ValueMember = "Id";
                cbxCategorias.DisplayMember = "Descripcion";
                cbxMarcas.DataSource = Tipo.listar("Marcas");
                cbxMarcas.ValueMember = "Id";
                cbxMarcas.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodArt.Text = articulo.CodArticulo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    cbxCategorias.SelectedValue = articulo.Categoria.Id;
                    cbxMarcas.SelectedValue = articulo.Marca.Id;
                    txtImg.Text = articulo.UrlImagen;
                    txtPrecio.Text = articulo.Precio.ToString();
                    cargarImagen();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            

        }
        private void cargarImagen()
        {
            try
            {
                pbxArticulo.Load(txtImg.Text);
            }
            catch (Exception)
            {

                pbxArticulo.Load("https://thumbs.dreamstime.com/b/technical-difficulties-speech-bubble-white-background-vector-illustration-222973218.jpg");
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            img = new OpenFileDialog();
            img.InitialDirectory = "C:\\";
            img.Filter = "jpg|*.jpg|png|*.png";
            img.Multiselect = false;
            if(img.ShowDialog() == DialogResult.OK)
            {
                txtImg.Text = img.FileName;
                
                cargarImagen();
            }
        }

        private bool mostrarRequeridos()
        {
            if(txtCodArt.Text == "")
            {
                txtCodArt.BackColor = Color.Red;
                return false;
            }
            if(txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Red;
                return false;
            }
            if(txtDescripcion.Text == "")
            {
                txtDescripcion.BackColor = Color.Red;
                return false;
            }
            if(txtImg.Text == "")
            {
                txtImg.BackColor = Color.Red;
                return false;
            }
            if(txtPrecio.Text == "")
            {
                txtPrecio.BackColor = Color.Red;
                return false;
            }
            return true;


        }

        private void txtCodArt_Enter(object sender, EventArgs e)
        {
            txtCodArt.BackColor = Color.White;
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            txtNombre.BackColor = Color.White;
        }

        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            txtDescripcion.BackColor = Color.White;
        }

        private void txtImg_Enter(object sender, EventArgs e)
        {
            txtImg.BackColor = Color.White;
        }

        private void txtPrecio_Enter(object sender, EventArgs e)
        {
            txtPrecio.BackColor = Color.White;
        }

        private void btnImgDB_Click(object sender, EventArgs e)
        {
            img = new OpenFileDialog();
            img.InitialDirectory = "C:\\Catalogo_DB";
            img.Filter = "jpg|*.jpg|png|*.png";
            img.Multiselect = false;
            if (img.ShowDialog() == DialogResult.OK)
            {
                txtImg.Text = img.FileName;

                cargarImagen();
            }
        }
    }
}
