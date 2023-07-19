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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Do_while));
            BtSalir = new Button();
            BtIniciar = new Button();
            btContar = new Button();
            TxIngreso = new TextBox();
            LblMov = new Label();
            SuspendLayout();
            // 
            // BtSalir
            // 
            BtSalir.BackColor = Color.Gold;
            BtSalir.Cursor = Cursors.Hand;
            BtSalir.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtSalir.ForeColor = SystemColors.ActiveCaptionText;
            BtSalir.Location = new Point(892, 523);
            BtSalir.Name = "BtSalir";
            BtSalir.Size = new Size(168, 59);
            BtSalir.TabIndex = 1;
            BtSalir.Text = "Salir";
            BtSalir.UseVisualStyleBackColor = false;
            BtSalir.Click += BtSalir_Click;
            // 
            // BtIniciar
            // 
            BtIniciar.BackColor = Color.Gold;
            BtIniciar.Cursor = Cursors.Hand;
            BtIniciar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtIniciar.ForeColor = SystemColors.ActiveCaptionText;
            BtIniciar.Location = new Point(425, 12);
            BtIniciar.Name = "BtIniciar";
            BtIniciar.Size = new Size(168, 59);
            BtIniciar.TabIndex = 2;
            BtIniciar.Text = "Iniciar";
            BtIniciar.UseVisualStyleBackColor = false;
            BtIniciar.Click += BtIniciar_Click;
            // 
            // btContar
            // 
            btContar.BackColor = Color.Gold;
            btContar.Cursor = Cursors.Hand;
            btContar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btContar.ForeColor = SystemColors.ActiveCaptionText;
            btContar.Location = new Point(5, 452);
            btContar.Name = "btContar";
            btContar.Size = new Size(168, 59);
            btContar.TabIndex = 3;
            btContar.Text = "Contar";
            btContar.UseVisualStyleBackColor = false;
            // 
            // TxIngreso
            // 
            TxIngreso.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TxIngreso.Location = new Point(213, 465);
            TxIngreso.Name = "TxIngreso";
            TxIngreso.Size = new Size(211, 34);
            TxIngreso.TabIndex = 4;
            // 
            // LblMov
            // 
            LblMov.BackColor = Color.Goldenrod;
            LblMov.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblMov.Location = new Point(0, 105);
            LblMov.Name = "LblMov";
            LblMov.Size = new Size(211, 103);
            LblMov.TabIndex = 5;
            LblMov.Text = "Soy un rectángulo";
            LblMov.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Do_while
            // 
            AcceptButton = BtSalir;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(1072, 594);
            Controls.Add(LblMov);
            Controls.Add(TxIngreso);
            Controls.Add(btContar);
            Controls.Add(BtIniciar);
            Controls.Add(BtSalir);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Do_while";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Do_while";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtSalir;
        private Button BtIniciar;
        private Button btContar;
        private TextBox TxIngreso;
        private Label LblMov;
    }
}