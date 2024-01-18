using AppVentas.AccesoADatos;
using AppVentas.EntidadDeNegocio;
using AppVentas.LogicaDeNegocio;
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
    public partial class AppVentasUI : Form
    {
        public AppVentasUI()
        {
            InitializeComponent();
        }
        private int ObtenerClienteId()
        {
            return int.Parse(txtClienteId.Text);
        }
        private async void btnBuscar_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                int clienteId;
                if (!int.TryParse(txtClienteId.Text, out clienteId))
                {
                    MessageBox.Show("Ingrese un Id válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Cliente clienteABuscar = new Cliente { ClienteId = clienteId };
                ClienteBL clienteBL = new ClienteBL();
                List<Cliente> clientesEncontrados = await clienteBL.BuscarAsync(clienteABuscar);
                if (clientesEncontrados.Count > 0)
                {
                    MostrarDatosCliente(clientesEncontrados[0]);
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarDatosCliente(Cliente cliente)
        {
            txtClienteNombre.Text = cliente.Nombre;
            txtClienteApellido.Text = cliente.Apellido;
            txtClienteTelefono.Text = cliente.Telefono.ToString();
            txtClienteDireccion.Text = cliente.Direccion;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente nuevoCliente = new Cliente
                {
                    Nombre = txtClienteNombre.Text,
                    Apellido = txtClienteApellido.Text,
                    Telefono = Convert.ToInt32(txtClienteTelefono.Text),
                    Direccion = txtClienteDireccion.Text

                };

                ClienteBL clienteBL = new ClienteBL();
                int resultado = await clienteBL.CrearAsync(nuevoCliente);

                if (resultado > 0)
                {
                    MessageBox.Show("Cliente guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarDatosCliente(nuevoCliente);
                }
                else
                {
                    MessageBox.Show("Error al guardar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int clienteId;
                if (!int.TryParse(txtClienteId.Text, out clienteId))
                {
                    MessageBox.Show("Ingrese un ClienteId válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Cliente clienteAModificar = new Cliente
                {
                    ClienteId = clienteId,
                    Nombre = txtClienteNombre.Text,
                    Apellido = txtClienteApellido.Text,
                    Telefono = Convert.ToInt32(txtClienteTelefono.Text),
                    Direccion = txtClienteDireccion.Text
                };

                ClienteBL clienteBL = new ClienteBL();
                int resultado = await clienteBL.ModificarAsync(clienteAModificar);

                if (resultado > 0)
                {
                    MessageBox.Show("Cliente modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al modificar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int clienteId;
                if (!int.TryParse(txtClienteId.Text, out clienteId))
                {
                    MessageBox.Show("Ingrese un ClienteId válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Cliente clienteAEliminar = new Cliente
                {
                    ClienteId = clienteId
                };

                ClienteBL clienteBL = new ClienteBL();
                int resultado = await clienteBL.EliminarAsync(clienteAEliminar);

                if (resultado > 0)
                {
                    MessageBox.Show("Cliente eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void LimpiarCampos()
        {
            txtClienteId.Text = string.Empty;
            txtClienteNombre.Text = string.Empty;
            txtClienteApellido.Text = string.Empty;
            txtClienteTelefono.Text = string.Empty;
            txtClienteDireccion.Text = string.Empty;
        }
        private async void btnCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                string codigoProducto = txtCodigo.Text;

                if (string.IsNullOrWhiteSpace(codigoProducto))
                {
                    MessageBox.Show("Ingrese un código válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Producto productoABuscar = new Producto { Codigo = codigoProducto };
                List<Producto> productosEncontrados = await ProductoDAL.BuscarAsync(productoABuscar);

                if (productosEncontrados.Count > 0)
                {
                    MostrarDatosProducto(productosEncontrados[0]);
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void MostrarDatosProducto(Producto producto)
        {

            txtDescripcion.Text = producto.Descripcion;
            txtPrecio.Text = producto.Precio.ToString();
            txtCantidad.Text = producto.Cantidad.ToString();
            txtDescripcion.Enabled = false;
            txtPrecio.Enabled = false;
        }

        private void btnQuitarData_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    int indiceSeleccionado = dataGridView2.SelectedRows[0].Index;
                    listaProductos.RemoveAt(indiceSeleccionado);
                    ActualizarDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private List<Producto> listaProductos = new List<Producto>();
        private void btnAgregarData_Click(object sender, EventArgs e)
        {
            try
            {
                string codigoProducto = txtCodigo.Text;
                string descripcion = txtDescripcion.Text;
                decimal precio = Convert.ToDecimal(txtPrecio.Text);
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                Producto producto = new Producto
                {
                    Codigo = codigoProducto,
                    Descripcion = descripcion,
                    Precio = precio,
                    Cantidad = cantidad
                };
                listaProductos.Add(producto);
                ActualizarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ActualizarDataGridView()
        {
            dataGridView2.Rows.Clear();
            decimal total = 0;

            foreach (Producto producto in listaProductos)
            {
                dataGridView2.Rows.Add(producto.Codigo, producto.Descripcion, producto.Precio, producto.Cantidad);
                decimal subtotal = producto.Precio * producto.Cantidad;
                total += subtotal;
            }
            txtTotal.Text = total.ToString();
        }



        private async void btnVenta_Click(object sender, EventArgs e)
        {
            try
            {
                string totalStr = txtTotal.Text;
                if (decimal.TryParse(totalStr, out decimal total))
                {
                    EncabezadoFactura encabezadoFactura = new EncabezadoFactura
                    {
                        Fecha = DateTime.Now,
                        ClienteId = ObtenerClienteId(),
                        Total = total
                    };

                    EncabezadoFacturaBL encabezadoFacturaBL = new EncabezadoFacturaBL();
                    int encabezadoFacturaId = await encabezadoFacturaBL.CrearAsync(encabezadoFactura);

                    foreach (Producto producto in listaProductos)
                    {
                        DetalleFactura detalleFactura = new DetalleFactura
                        {
                            EncabezadoFacturaId = encabezadoFacturaId,
                            ProductoCodigo = producto.Codigo,
                            Cantidad = producto.Cantidad,
                            Subtotal = producto.Precio * producto.Cantidad
                        };
                        await DetalleFacturaDAL.CrearAsync(detalleFactura);
                    }

                    MessageBox.Show("Venta realizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarDatosVenta();
                }
                else
                {
                    MessageBox.Show("El formato del total no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarDatosVenta()
        {
            listaProductos.Clear();
            ActualizarDataGridView();

        }

        private void linkEncabezado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EncabezadoForm encabezadoForm = new EncabezadoForm();
            this.Hide();
            encabezadoForm.ShowDialog();
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
