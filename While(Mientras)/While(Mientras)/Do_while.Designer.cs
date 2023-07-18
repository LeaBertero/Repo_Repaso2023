namespace While_Mientras_
{
    partial class Do_while
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
            BtSalir = new Button();
            Btcerrar = new Button();
            TxIngreso = new TextBox();
            LblMensaje = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtSalir
            // 
            BtSalir.BackColor = Color.ForestGreen;
            BtSalir.Cursor = Cursors.Hand;
            BtSalir.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtSalir.ForeColor = SystemColors.Control;
            BtSalir.Location = new Point(892, 523);
            BtSalir.Name = "BtSalir";
            BtSalir.Size = new Size(168, 59);
            BtSalir.TabIndex = 1;
            BtSalir.Text = "Salir";
            BtSalir.UseVisualStyleBackColor = false;
            BtSalir.Click += BtSalir_Click;
            // 
            // Btcerrar
            // 
            Btcerrar.BackColor = Color.ForestGreen;
            Btcerrar.Cursor = Cursors.Hand;
            Btcerrar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Btcerrar.ForeColor = SystemColors.Control;
            Btcerrar.Location = new Point(100, 229);
            Btcerrar.Name = "Btcerrar";
            Btcerrar.Size = new Size(306, 59);
            Btcerrar.TabIndex = 2;
            Btcerrar.Text = "Cerrar manualmente";
            Btcerrar.UseVisualStyleBackColor = false;
            Btcerrar.Click += Btcerrar_Click;
            // 
            // TxIngreso
            // 
            TxIngreso.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            TxIngreso.Location = new Point(142, 79);
            TxIngreso.Name = "TxIngreso";
            TxIngreso.Size = new Size(221, 39);
            TxIngreso.TabIndex = 3;
            // 
            // LblMensaje
            // 
            LblMensaje.AutoSize = true;
            LblMensaje.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LblMensaje.Location = new Point(142, 156);
            LblMensaje.Name = "LblMensaje";
            LblMensaje.Size = new Size(0, 32);
            LblMensaje.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(524, 32);
            label1.TabIndex = 5;
            label1.Text = "Ingrese salir, para poder cerrar el formulario";
            // 
            // Do_while
            // 
            AcceptButton = BtSalir;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.HotPink;
            ClientSize = new Size(1072, 594);
            Controls.Add(label1);
            Controls.Add(LblMensaje);
            Controls.Add(TxIngreso);
            Controls.Add(Btcerrar);
            Controls.Add(BtSalir);
            Name = "Do_while";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Do_while";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtSalir;
        private Button Btcerrar;
        private TextBox TxIngreso;
        private Label LblMensaje;
        private Label label1;
    }
}