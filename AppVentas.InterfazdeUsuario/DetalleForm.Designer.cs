namespace AppVentas.InterfazdeUsuario
{
    partial class DetalleForm
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
            dgvDetalle = new DataGridView();
            label1 = new Label();
            linkVentas = new LinkLabel();
            linkFactura = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // dgvDetalle
            // 
            dgvDetalle.BackgroundColor = SystemColors.Control;
            dgvDetalle.BorderStyle = BorderStyle.Fixed3D;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(30, 36);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowTemplate.Height = 25;
            dgvDetalle.Size = new Size(717, 192);
            dgvDetalle.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(320, 8);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 2;
            label1.Text = "Detalle de Factura";
            // 
            // linkVentas
            // 
            linkVentas.AutoSize = true;
            linkVentas.Location = new Point(600, 405);
            linkVentas.Name = "linkVentas";
            linkVentas.Size = new Size(60, 15);
            linkVentas.TabIndex = 49;
            linkVentas.TabStop = true;
            linkVentas.Text = "Ir a Ventas";
            linkVentas.LinkClicked += linkVentas_LinkClicked;
            // 
            // linkFactura
            // 
            linkFactura.AutoSize = true;
            linkFactura.Location = new Point(693, 405);
            linkFactura.Name = "linkFactura";
            linkFactura.Size = new Size(65, 15);
            linkFactura.TabIndex = 48;
            linkFactura.TabStop = true;
            linkFactura.Text = "Ir a Factura";
            linkFactura.LinkClicked += linkFactura_LinkClicked;
            // 
            // DetalleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkVentas);
            Controls.Add(linkFactura);
            Controls.Add(dgvDetalle);
            Controls.Add(label1);
            Name = "DetalleForm";
            Text = "DetalleForm";
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvdetalle;
        private Label label1;
        private LinkLabel linkVentas;
        private LinkLabel linkFactura;
        private DataGridView dgvDetalle;
    }
}