namespace ListaPrecio
{
    partial class Lista_precio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_precio));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TxCodigo = new TextBox();
            TxProducto = new TextBox();
            TxPrecio = new TextBox();
            label5 = new Label();
            BtAceptar = new Button();
            BtListar = new Button();
            BtSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 176);
            label1.Name = "label1";
            label1.Size = new Size(120, 41);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 272);
            label2.Name = "label2";
            label2.Size = new Size(147, 41);
            label2.TabIndex = 1;
            label2.Text = "Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 370);
            label3.Name = "label3";
            label3.Size = new Size(105, 41);
            label3.TabIndex = 2;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(190, 9);
            label4.Name = "label4";
            label4.Size = new Size(964, 81);
            label4.TabIndex = 3;
            label4.Text = "Carga lista de precios con código";
            // 
            // TxCodigo
            // 
            TxCodigo.Location = new Point(171, 190);
            TxCodigo.Name = "TxCodigo";
            TxCodigo.Size = new Size(125, 27);
            TxCodigo.TabIndex = 1;
            // 
            // TxProducto
            // 
            TxProducto.Location = new Point(171, 286);
            TxProducto.Name = "TxProducto";
            TxProducto.Size = new Size(125, 27);
            TxProducto.TabIndex = 2;
            // 
            // TxPrecio
            // 
            TxPrecio.Location = new Point(171, 384);
            TxPrecio.Name = "TxPrecio";
            TxPrecio.Size = new Size(125, 27);
            TxPrecio.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(830, 111);
            label5.Name = "label5";
            label5.Size = new Size(179, 41);
            label5.TabIndex = 7;
            label5.Text = "Lista precio";
            // 
            // BtAceptar
            // 
            BtAceptar.BackColor = Color.DarkOliveGreen;
            BtAceptar.Cursor = Cursors.Hand;
            BtAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtAceptar.ForeColor = Color.White;
            BtAceptar.Location = new Point(412, 176);
            BtAceptar.Name = "BtAceptar";
            BtAceptar.Size = new Size(106, 52);
            BtAceptar.TabIndex = 4;
            BtAceptar.Text = "Aceptar";
            BtAceptar.UseVisualStyleBackColor = false;
            BtAceptar.Click += BtAceptar_Click;
            // 
            // BtListar
            // 
            BtListar.BackColor = Color.DarkOliveGreen;
            BtListar.Cursor = Cursors.Hand;
            BtListar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtListar.ForeColor = Color.White;
            BtListar.Location = new Point(524, 176);
            BtListar.Name = "BtListar";
            BtListar.Size = new Size(106, 52);
            BtListar.TabIndex = 5;
            BtListar.Text = "Ver lista";
            BtListar.UseVisualStyleBackColor = false;
            BtListar.Click += BtListar_Click;
            // 
            // BtSalir
            // 
            BtSalir.BackColor = Color.DarkOliveGreen;
            BtSalir.Cursor = Cursors.Hand;
            BtSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtSalir.ForeColor = Color.White;
            BtSalir.Location = new Point(1072, 479);
            BtSalir.Name = "BtSalir";
            BtSalir.Size = new Size(191, 98);
            BtSalir.TabIndex = 6;
            BtSalir.Text = "Salir";
            BtSalir.UseVisualStyleBackColor = false;
            BtSalir.Click += BtSalir_Click;
            // 
            // Lista_precio
            // 
            AcceptButton = BtAceptar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chartreuse;
            ClientSize = new Size(1275, 589);
            Controls.Add(BtSalir);
            Controls.Add(BtListar);
            Controls.Add(BtAceptar);
            Controls.Add(label5);
            Controls.Add(TxPrecio);
            Controls.Add(TxProducto);
            Controls.Add(TxCodigo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Lista_precio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista_precio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxCodigo;
        private TextBox TxProducto;
        private TextBox TxPrecio;
        private Label label5;
        private Button BtAceptar;
        private Button BtListar;
        private Button BtSalir;
    }
}