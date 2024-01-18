using AppVentas.AccesoADatos;
using AppVentas.EntidadDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVentas.InterfazdeUsuario
{
    public partial class DetalleForm : Form
    {
        public DetalleForm()
        {
            InitializeComponent();
            CargarDatosAsync();
            dgvDetalle.BorderStyle = BorderStyle.None;
        }
        private async void CargarDatosAsync()
        {
            dgvDetalle.Columns.Clear();
            List<DetalleFactura> detalles = await DetalleFacturaDAL.ObtenerTodosAsync();
            dgvDetalle.DataSource = detalles;
        }

        private void linkVentas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppVentasUI appventasUi = new AppVentasUI();
            this.Hide();
            appventasUi.ShowDialog();
            this.Close();
        }

        private void linkFactura_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EncabezadoForm encabezadoForm = new EncabezadoForm();
            this.Hide();
            encabezadoForm.ShowDialog();
            this.Close();
        }
    }
}
