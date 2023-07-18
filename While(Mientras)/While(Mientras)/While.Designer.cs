namespace While_Mientras_
{
    partial class While
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(While));
            BtSalir = new Button();
            BtNuevo = new Button();
            BtIniciar = new Button();
            LblMov = new Label();
            SuspendLayout();
            // 
            // BtSalir
            // 
            BtSalir.BackColor = Color.ForestGreen;
            BtSalir.Cursor = Cursors.Hand;
            BtSalir.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtSalir.ForeColor = SystemColors.Control;
            BtSalir.Location = new Point(841, 485);
            BtSalir.Name = "BtSalir";
            BtSalir.Size = new Size(168, 59);
            BtSalir.TabIndex = 0;
            BtSalir.Text = "Salir";
            BtSalir.UseVisualStyleBackColor = false;
            BtSalir.Click += BtSalir_Click;
            // 
            // BtNuevo
            // 
            BtNuevo.BackColor = Color.ForestGreen;
            BtNuevo.Cursor = Cursors.Hand;
            BtNuevo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtNuevo.ForeColor = SystemColors.Control;
            BtNuevo.Location = new Point(31, 484);
            BtNuevo.Name = "BtNuevo";
            BtNuevo.Size = new Size(529, 59);
            BtNuevo.TabIndex = 1;
            BtNuevo.Text = "NUevo formulario - Ejemplo Do While";
            BtNuevo.UseVisualStyleBackColor = false;
            BtNuevo.Click += BtNuevo_Click;
            // 
            // BtIniciar
            // 
            BtIniciar.BackColor = Color.ForestGreen;
            BtIniciar.Cursor = Cursors.Hand;
            BtIniciar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtIniciar.ForeColor = SystemColors.Control;
            BtIniciar.Location = new Point(12, 12);
            BtIniciar.Name = "BtIniciar";
            BtIniciar.Size = new Size(168, 59);
            BtIniciar.TabIndex = 2;
            BtIniciar.Text = "Iniciar";
            BtIniciar.UseVisualStyleBackColor = false;
            BtIniciar.Click += BtIniciar_Click;
            // 
            // LblMov
            // 
            LblMov.BackColor = Color.Red;
            LblMov.Location = new Point(294, 117);
            LblMov.Name = "LblMov";
            LblMov.Size = new Size(94, 84);
            LblMov.TabIndex = 3;
            // 
            // While
            // 
            AcceptButton = BtSalir;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(1019, 555);
            Controls.Add(LblMov);
            Controls.Add(BtIniciar);
            Controls.Add(BtNuevo);
            Controls.Add(BtSalir);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "While";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejemplo while - do while";
            ResumeLayout(false);
        }

        #endregion

        private Button BtSalir;
        private Button BtNuevo;
        private Button BtIniciar;
        private Label LblMov;
    }
}