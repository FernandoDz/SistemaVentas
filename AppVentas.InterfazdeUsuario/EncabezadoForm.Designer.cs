namespace AppVentas.InterfazdeUsuario
{
    partial class EncabezadoForm
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
            label1 = new Label();
            dgvFactura = new DataGridView();
            linkVenta = new LinkLabel();
            linkDetail = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(271, 9);
            label1.Name = "label1";
            label1.Size = new Size(199, 25);
            label1.TabIndex = 0;
            label1.Text = "Encabezado de facturas";
            // 
            // dgvFactura
            // 
            dgvFactura.AllowUserToDeleteRows = false;
            dgvFactura.BackgroundColor = SystemColors.Control;
            dgvFactura.BorderStyle = BorderStyle.Fixed3D;
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFactura.Location = new Point(53, 46);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.ReadOnly = true;
            dgvFactura.RowTemplate.Height = 25;
            dgvFactura.Size = new Size(717, 192);
            dgvFactura.TabIndex = 1;
            // 
            // linkVenta
            // 
            linkVenta.AutoSize = true;
            linkVenta.Location = new Point(601, 407);
            linkVenta.Name = "linkVenta";
            linkVenta.Size = new Size(60, 15);
            linkVenta.TabIndex = 49;
            linkVenta.TabStop = true;
            linkVenta.Text = "Ir a Ventas";
            linkVenta.LinkClicked += linkVenta_LinkClicked;
            // 
            // linkDetail
            // 
            linkDetail.AutoSize = true;
            linkDetail.Location = new Point(694, 407);
            linkDetail.Name = "linkDetail";
            linkDetail.Size = new Size(67, 15);
            linkDetail.TabIndex = 48;
            linkDetail.TabStop = true;
            linkDetail.Text = "Ir a Detalles";
            linkDetail.LinkClicked += linkDetail_LinkClicked;
            // 
            // EncabezadoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkVenta);
            Controls.Add(linkDetail);
            Controls.Add(dgvFactura);
            Controls.Add(label1);
            Name = "EncabezadoForm";
            Text = "EncabezadoForm";
            ((System.ComponentModel.ISupportInitialize)dgvFactura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvFactura;
        private LinkLabel linkVenta;
        private LinkLabel linkDetail;
        private DataGridViewTextBoxColumn EncabezadoFacturaId;
        private DataGridViewTextBoxColumn FechaEncabezado;
        private DataGridViewTextBoxColumn ClienteId;
        private DataGridViewTextBoxColumn Total;
    }
}