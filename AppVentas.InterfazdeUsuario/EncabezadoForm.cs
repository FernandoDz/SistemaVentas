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
    public partial class EncabezadoForm : Form
    {
        public EncabezadoForm()
        {
            InitializeComponent();
            CargarDatosAsync();
            dgvFactura.BorderStyle = BorderStyle.None;
        }
        private async void CargarDatosAsync()
        {
            dgvFactura.Columns.Clear();
            List<EncabezadoFactura> encabezados = await EncabezadoFacturaDAL.ObtenerTodosAsync();
            dgvFactura.DataSource = encabezados;
        }

        private void linkVenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppVentasUI appventasUi = new AppVentasUI();
            this.Hide();
            appventasUi.ShowDialog();
            this.Close();
        }

        private void linkDetail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DetalleForm detalleForm = new DetalleForm();
            this.Hide();
            detalleForm.ShowDialog();
            this.Close();
        }
    }
}
