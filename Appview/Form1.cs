using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace Appview
{
    public partial class Form1 : Form
    {
        private List<Articulo> Articulos;
        public Form1()
        {
            InitializeComponent();
            Text = "Listado de Articulos";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblRequiredCampo.Text = "";
            lblRequiredCriterio.Text = "";
            cargar();
            cboCampo.Items.Add("Ninguno");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripción");
            cboCampo.Items.Add("Precio");
            cboCategoria.Items.Add("Todas");
            cboCategoria.Items.Add("Celulares");
            cboCategoria.Items.Add("Televisores");
            cboCategoria.Items.Add("Media");
            cboCategoria.Items.Add("Audio");
            cboMarca.Items.Add("Todas");
            cboMarca.Items.Add("Apple");
            cboMarca.Items.Add("Samsung");
            cboMarca.Items.Add("Motorola");
            cboMarca.Items.Add("Sony");
            cboMarca.Items.Add("Huawei");

            cboCampo.SelectedItem = "Ninguno";
            cboCategoria.SelectedItem = "Todas";
            cboMarca.SelectedItem = "Todas";
        }


        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                if (seleccionado.Nombre == "Galaxy S10")
                {
                    pbxArticulo.SizeMode = PictureBoxSizeMode.Normal;
                }
                else
                    pbxArticulo.SizeMode = PictureBoxSizeMode.StretchImage;

                cargarImagen(seleccionado.UrlImagen);
            }
            
            
        }

        private void cargar()
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                Articulos = negocio.listar();
                dgvArticulos.DataSource = Articulos;
                ocultarColumnas();
                cargarImagen(Articulos[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["UrlImagen"].Visible = false;
            dgvArticulos.Columns["CodArticulo"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {

                pbxArticulo.Load("https://thumbs.dreamstime.com/b/technical-difficulties-speech-bubble-white-background-vector-illustration-222973218.jpg");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo agregar = new frmAltaArticulo();
            agregar.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo modificar;
            if(dgvArticulos.CurrentRow != null)
            {
                modificar = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmAltaArticulo modificado = new frmAltaArticulo(modificar);
                modificado.ShowDialog();
                cargar();
            }
            
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                if(dgvArticulos.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿De verdad quieres eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                        negocio.eliminar(seleccionado.Id);
                        cargar();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                string criterio = "";
                string campo = cboCampo.SelectedItem.ToString();
                string filtro = txtFiltro.Text;
                if(cboCriterio.SelectedItem != null) 
                criterio = cboCriterio.SelectedItem.ToString();

                string marca = cboMarca.SelectedItem.ToString();
                string categoria = cboCategoria.SelectedItem.ToString();
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, marca, categoria, filtro);

                if (filtro != "")
                {
                    if (cboCampo.SelectedItem.ToString() == "Ninguno")
                    {
                        lblRequiredCampo.Text = "Requerido";
                    }
                    else if(cboCriterio.SelectedItem == null)
                    {
                        lblRequiredCampo.Text = "";
                        lblRequiredCriterio.Text = "Requerido";
                    }
                    else
                    {
                        lblRequiredCriterio.Text = "";
                    }

                }
                else
                {
                lblRequiredCampo.Text = "";
                lblRequiredCriterio.Text = "";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmDetalleArt frmDetalleArt = new frmDetalleArt(seleccionado);
                frmDetalleArt.ShowDialog();
            }
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltrar.Text;

            listaFiltrada = Articulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));

            if (filtro != "")
            {
                dgvArticulos.DataSource = null;
            }
            else
            {
                listaFiltrada = Articulos;
            }
            dgvArticulos.DataSource = listaFiltrada;

            ocultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string campo = cboCampo.SelectedItem.ToString();
            switch (campo)
            {
                case "Nombre":
                    cboCriterio.Items.Clear();
                    cboCriterio.Items.Add("Empieza con");
                    cboCriterio.Items.Add("Termina con");
                    cboCriterio.Items.Add("Contiene");
                    break;
                case "Descripcion":
                    cboCriterio.Items.Clear();
                    cboCriterio.Items.Add("Empieza con");
                    cboCriterio.Items.Add("Termina con");
                    cboCriterio.Items.Add("Contiene");
                    break;
                case "Precio":
                    cboCriterio.Items.Clear();
                    cboCriterio.Items.Add("Mayor a");
                    cboCriterio.Items.Add("Menor a");
                    cboCriterio.Items.Add("Igual a");
                   break;
            }

            if(campo == "Precio")
            {
                string cadena = txtFiltro.Text;
                foreach (char letter in cadena)
                {
                    if (char.IsLetter(letter))
                    {
                        txtFiltro.Text = "";
                    }                
                }
            }

        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cboCampo.SelectedItem.ToString() == "Precio")
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

                if ((e.KeyChar == 'e') && (e.KeyChar == 'E'))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
