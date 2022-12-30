using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appview
{
    public partial class frmDetalleArt : Form
    {
        Articulo seleccionado;
        public frmDetalleArt()
        {
            InitializeComponent();
        }

        public frmDetalleArt(Articulo seleccionado)
        {
            InitializeComponent();
            this.seleccionado = seleccionado;

        }

        private void frmDetalleArt_Load(object sender, EventArgs e)
        {
            Text = "Detalle de Articulo";
            txtId.Text = seleccionado.Id.ToString();
            lblNombre.Text = seleccionado.Nombre;
            txtDescripcion.Text = seleccionado.Descripcion;
            txtMarca.Text = seleccionado.Marca.Descripcion;
            txtCategoria.Text = seleccionado.Categoria.Descripcion;
            txtPrecio.Text = seleccionado.Precio.ToString();
            txtImgUrl.Text = seleccionado.UrlImagen;
        }
    }
}
