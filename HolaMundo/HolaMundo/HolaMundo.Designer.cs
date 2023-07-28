namespace HolaMundo
{
    partial class HolaMundo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtEjecutar = new Button();
            LblMensaje = new Label();
            Btcerrar = new Button();
            SuspendLayout();
            // 
            // BtEjecutar
            // 
            BtEjecutar.Cursor = Cursors.Hand;
            BtEjecutar.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            BtEjecutar.Location = new Point(434, 397);
            BtEjecutar.Name = "BtEjecutar";
            BtEjecutar.Size = new Size(180, 75);
            BtEjecutar.TabIndex = 0;
            BtEjecutar.Text = "Ejecutar";
            BtEjecutar.UseVisualStyleBackColor = true;
            BtEjecutar.Click += BtSalir_Click;
            // 
            // LblMensaje
            // 
            LblMensaje.AutoSize = true;
            LblMensaje.Font = new Font("Segoe UI", 56F, FontStyle.Bold, GraphicsUnit.Point);
            LblMensaje.Location = new Point(12, 140);
            LblMensaje.Name = "LblMensaje";
            LblMensaje.Size = new Size(321, 125);
            LblMensaje.TabIndex = 1;
            LblMensaje.Text = "label1";
            LblMensaje.Visible = false;
            // 
            // Btcerrar
            // 
            Btcerrar.Cursor = Cursors.Hand;
            Btcerrar.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Btcerrar.Location = new Point(1194, 446);
            Btcerrar.Name = "Btcerrar";
            Btcerrar.Size = new Size(180, 75);
            Btcerrar.TabIndex = 2;
            Btcerrar.Text = "Salir";
            Btcerrar.UseVisualStyleBackColor = true;
            Btcerrar.Click += Btcerrar_Click;
            // 
            // HolaMundo
            // 
            AcceptButton = BtEjecutar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1386, 533);
            Controls.Add(Btcerrar);
            Controls.Add(LblMensaje);
            Controls.Add(BtEjecutar);
            Name = "HolaMundo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HolaMundo (Primer programa)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtEjecutar;
        private Label LblMensaje;
        private Button Btcerrar;
    }
}