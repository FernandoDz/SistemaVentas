namespace AppVentas.InterfazdeUsuario
{
    partial class AppVentasUI
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
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            txtClienteId = new TextBox();
            btnBuscar = new Button();
            label2 = new Label();
            txtClienteNombre = new TextBox();
            label3 = new Label();
            txtClienteDireccion = new TextBox();
            btnQuitarData = new Button();
            btnAgregarData = new Button();
            dataGridView2 = new DataGridView();
            txtCodigoProducto = new DataGridViewTextBoxColumn();
            txtDescripcionProducto = new DataGridViewTextBoxColumn();
            txtPrecioProducto = new DataGridViewTextBoxColumn();
            txtCantidadProducto = new DataGridViewTextBoxColumn();
            txtPrecio = new TextBox();
            labe = new Label();
            label10 = new Label();
            txtDescripcion = new TextBox();
            label11 = new Label();
            txtCodigo = new TextBox();
            label12 = new Label();
            txtCantidad = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtClienteApellido = new TextBox();
            txtClienteTelefono = new TextBox();
            label6 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btnCodigo = new Button();
            txtTotal = new TextBox();
            label7 = new Label();
            btnVenta = new Button();
            linkDetail = new LinkLabel();
            linkEncabezado = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(137, 345);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(236, 345);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(335, 345);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 54);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 3;
            label1.Text = "Id del cliente";
            // 
            // txtClienteId
            // 
            txtClienteId.Location = new Point(96, 51);
            txtClienteId.Multiline = true;
            txtClienteId.Name = "txtClienteId";
            txtClienteId.Size = new Size(153, 23);
            txtClienteId.TabIndex = 4;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(270, 50);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_ClickAsync;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 93);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // txtClienteNombre
            // 
            txtClienteNombre.Location = new Point(75, 90);
            txtClienteNombre.Name = "txtClienteNombre";
            txtClienteNombre.Size = new Size(386, 23);
            txtClienteNombre.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 209);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 8;
            label3.Text = "Direccion";
            // 
            // txtClienteDireccion
            // 
            txtClienteDireccion.Location = new Point(75, 209);
            txtClienteDireccion.Multiline = true;
            txtClienteDireccion.Name = "txtClienteDireccion";
            txtClienteDireccion.Size = new Size(386, 91);
            txtClienteDireccion.TabIndex = 9;
            // 
            // btnQuitarData
            // 
            btnQuitarData.Location = new Point(687, 345);
            btnQuitarData.Name = "btnQuitarData";
            btnQuitarData.Size = new Size(75, 23);
            btnQuitarData.TabIndex = 35;
            btnQuitarData.Text = "Quitar ";
            btnQuitarData.UseVisualStyleBackColor = true;
            btnQuitarData.Click += btnQuitarData_Click;
            // 
            // btnAgregarData
            // 
            btnAgregarData.Location = new Point(782, 345);
            btnAgregarData.Name = "btnAgregarData";
            btnAgregarData.Size = new Size(75, 23);
            btnAgregarData.TabIndex = 34;
            btnAgregarData.Text = "Agregar Fila";
            btnAgregarData.UseVisualStyleBackColor = true;
            btnAgregarData.Click += btnAgregarData_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { txtCodigoProducto, txtDescripcionProducto, txtPrecioProducto, txtCantidadProducto });
            dataGridView2.Location = new Point(471, 93);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(575, 207);
            dataGridView2.TabIndex = 33;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.HeaderText = "Codigo";
            txtCodigoProducto.Name = "txtCodigoProducto";
            // 
            // txtDescripcionProducto
            // 
            txtDescripcionProducto.HeaderText = "Descripcion";
            txtDescripcionProducto.Name = "txtDescripcionProducto";
            txtDescripcionProducto.Width = 230;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.HeaderText = "Precio";
            txtPrecioProducto.Name = "txtPrecioProducto";
            // 
            // txtCantidadProducto
            // 
            txtCantidadProducto.HeaderText = "Cantidad";
            txtCantidadProducto.Name = "txtCantidadProducto";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(960, 64);
            txtPrecio.Multiline = true;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(86, 23);
            txtPrecio.TabIndex = 30;
            // 
            // labe
            // 
            labe.AutoSize = true;
            labe.Location = new Point(960, 46);
            labe.Name = "labe";
            labe.Size = new Size(64, 15);
            labe.TabIndex = 29;
            labe.Text = "Precio Uni.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(871, 46);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 27;
            label10.Text = "Cantidad";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(591, 64);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(275, 23);
            txtDescripcion.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(660, 46);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 25;
            label11.Text = "Descripcion";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(471, 64);
            txtCodigo.Multiline = true;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(114, 23);
            txtCodigo.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(471, 46);
            label12.Name = "label12";
            label12.Size = new Size(114, 15);
            label12.TabIndex = 23;
            label12.Text = "Codigo de Producto";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(871, 64);
            txtCantidad.Multiline = true;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(86, 23);
            txtCantidad.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(446, 9);
            label4.Name = "label4";
            label4.Size = new Size(156, 25);
            label4.TabIndex = 37;
            label4.Text = "Sistema de Ventas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 131);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 38;
            label5.Text = "Apellido";
            // 
            // txtClienteApellido
            // 
            txtClienteApellido.Location = new Point(75, 128);
            txtClienteApellido.Name = "txtClienteApellido";
            txtClienteApellido.Size = new Size(386, 23);
            txtClienteApellido.TabIndex = 39;
            // 
            // txtClienteTelefono
            // 
            txtClienteTelefono.Location = new Point(75, 168);
            txtClienteTelefono.Name = "txtClienteTelefono";
            txtClienteTelefono.Size = new Size(386, 23);
            txtClienteTelefono.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 171);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 40;
            label6.Text = "Telefono";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // btnCodigo
            // 
            btnCodigo.Location = new Point(591, 345);
            btnCodigo.Name = "btnCodigo";
            btnCodigo.Size = new Size(75, 23);
            btnCodigo.TabIndex = 42;
            btnCodigo.Text = "Buscar";
            btnCodigo.UseVisualStyleBackColor = true;
            btnCodigo.Click += btnCodigo_Click;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(960, 345);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(78, 23);
            txtTotal.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(922, 348);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 44;
            label7.Text = "Total :";
            // 
            // btnVenta
            // 
            btnVenta.Location = new Point(910, 441);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(136, 49);
            btnVenta.TabIndex = 45;
            btnVenta.Text = "Realizar Venta";
            btnVenta.UseVisualStyleBackColor = true;
            btnVenta.Click += btnVenta_Click;
            // 
            // linkDetail
            // 
            linkDetail.AutoSize = true;
            linkDetail.Location = new Point(771, 458);
            linkDetail.Name = "linkDetail";
            linkDetail.Size = new Size(70, 15);
            linkDetail.TabIndex = 46;
            linkDetail.TabStop = true;
            linkDetail.Text = "Ir a Detalles ";
            linkDetail.LinkClicked += linkDetail_LinkClicked;
            // 
            // linkEncabezado
            // 
            linkEncabezado.AutoSize = true;
            linkEncabezado.Location = new Point(678, 458);
            linkEncabezado.Name = "linkEncabezado";
            linkEncabezado.Size = new Size(65, 15);
            linkEncabezado.TabIndex = 47;
            linkEncabezado.TabStop = true;
            linkEncabezado.Text = "Ir a Factura";
            linkEncabezado.LinkClicked += linkEncabezado_LinkClicked;
            // 
            // AppVentasUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 502);
            Controls.Add(linkEncabezado);
            Controls.Add(linkDetail);
            Controls.Add(btnVenta);
            Controls.Add(label7);
            Controls.Add(txtTotal);
            Controls.Add(btnCodigo);
            Controls.Add(txtClienteTelefono);
            Controls.Add(label6);
            Controls.Add(txtClienteApellido);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtCantidad);
            Controls.Add(btnQuitarData);
            Controls.Add(btnAgregarData);
            Controls.Add(dataGridView2);
            Controls.Add(txtPrecio);
            Controls.Add(labe);
            Controls.Add(label10);
            Controls.Add(txtDescripcion);
            Controls.Add(label11);
            Controls.Add(txtCodigo);
            Controls.Add(label12);
            Controls.Add(txtClienteDireccion);
            Controls.Add(label3);
            Controls.Add(txtClienteNombre);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(txtClienteId);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Name = "AppVentasUI";
            Text = "AppVentasUI";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Guardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label label1;
        private TextBox txtClienteId;
        private Button btnBuscar;
        private Label label2;
        private TextBox txtClienteNombre;
        private Label label3;
        private TextBox txtClienteDireccion;
        private Button btnQuitarData;
        private Button btnAgregarData;
        private DataGridView dataGridView2;
        private TextBox txtPrecio;
        private Label labe;
        private Label label10;
        private TextBox txtDescripcion;
        private Label label11;
        private TextBox txtCodigo;
        private Label label12;
        private TextBox txtCantidad;
        private Label label4;
        private Label label5;
        private TextBox txtClienteApellido;
        private TextBox txtClienteTelefono;
        private Label label6;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnGuardar;
        private Button btnCodigo;
        private DataGridViewTextBoxColumn txtCodigoProducto;
        private DataGridViewTextBoxColumn txtDescripcionProducto;
        private DataGridViewTextBoxColumn txtPrecioProducto;
        private DataGridViewTextBoxColumn txtCantidadProducto;
        private TextBox txtTotal;
        private Label label7;
        private Button btnVenta;
        private LinkLabel linkDetail;
        private LinkLabel linkEncabezado;
    }
}