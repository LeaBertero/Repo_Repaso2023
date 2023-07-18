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
            // Do_while
            // 
            AcceptButton = BtSalir;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(1072, 594);
            Controls.Add(BtIniciar);
            Controls.Add(BtSalir);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Do_while";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Do_while";
            ResumeLayout(false);
        }

        #endregion

        private Button BtSalir;
        private Button BtIniciar;
    }
}