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
            BtCerrar = new Button();
            TxSalir = new TextBox();
            label1 = new Label();
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
            BtIniciar.Location = new Point(428, 12);
            BtIniciar.Name = "BtIniciar";
            BtIniciar.Size = new Size(168, 59);
            BtIniciar.TabIndex = 2;
            BtIniciar.Text = "Iniciar";
            BtIniciar.UseVisualStyleBackColor = false;
            BtIniciar.Click += BtIniciar_Click;
            // 
            // LblMov
            // 
            LblMov.BackColor = Color.PaleGreen;
            LblMov.Location = new Point(0, 117);
            LblMov.Name = "LblMov";
            LblMov.Size = new Size(94, 84);
            LblMov.TabIndex = 3;
            // 
            // BtCerrar
            // 
            BtCerrar.BackColor = Color.ForestGreen;
            BtCerrar.Cursor = Cursors.Hand;
            BtCerrar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtCerrar.ForeColor = SystemColors.Control;
            BtCerrar.Location = new Point(31, 388);
            BtCerrar.Name = "BtCerrar";
            BtCerrar.Size = new Size(168, 59);
            BtCerrar.TabIndex = 4;
            BtCerrar.Text = "cerrar";
            BtCerrar.UseVisualStyleBackColor = false;
            BtCerrar.Click += BtCerrar_Click;
            // 
            // TxSalir
            // 
            TxSalir.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxSalir.Location = new Point(241, 399);
            TxSalir.Name = "TxSalir";
            TxSalir.Size = new Size(187, 39);
            TxSalir.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(241, 353);
            label1.Name = "label1";
            label1.Size = new Size(260, 28);
            label1.TabIndex = 6;
            label1.Text = "Para cerrar, escriba \"Salir\"";
            // 
            // While
            // 
            AcceptButton = BtSalir;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(1019, 555);
            Controls.Add(label1);
            Controls.Add(TxSalir);
            Controls.Add(BtCerrar);
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
            PerformLayout();
        }

        #endregion

        private Button BtSalir;
        private Button BtNuevo;
        private Button BtIniciar;
        private Label LblMov;
        private Button BtCerrar;
        private TextBox TxSalir;
        private Label label1;
    }
}