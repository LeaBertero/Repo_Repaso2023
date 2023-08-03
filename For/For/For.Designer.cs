namespace For
{
    partial class FrmInicio
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
            BtIniciar = new Button();
            Lbdesplazar = new Label();
            BtCerrar = new Button();
            TxValorIni = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtIniciar
            // 
            BtIniciar.Cursor = Cursors.Hand;
            BtIniciar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtIniciar.Location = new Point(179, 66);
            BtIniciar.Name = "BtIniciar";
            BtIniciar.Size = new Size(161, 39);
            BtIniciar.TabIndex = 0;
            BtIniciar.Text = "Comenzar";
            BtIniciar.UseVisualStyleBackColor = true;
            BtIniciar.Click += BtIniciar_Click;
            // 
            // Lbdesplazar
            // 
            Lbdesplazar.BackColor = Color.Red;
            Lbdesplazar.BorderStyle = BorderStyle.Fixed3D;
            Lbdesplazar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Lbdesplazar.Location = new Point(0, 166);
            Lbdesplazar.Name = "Lbdesplazar";
            Lbdesplazar.Size = new Size(140, 79);
            Lbdesplazar.TabIndex = 1;
            Lbdesplazar.Text = "Lean";
            Lbdesplazar.TextAlign = ContentAlignment.MiddleCenter;
            Lbdesplazar.Visible = false;
            // 
            // BtCerrar
            // 
            BtCerrar.Cursor = Cursors.Hand;
            BtCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtCerrar.Location = new Point(1117, 12);
            BtCerrar.Name = "BtCerrar";
            BtCerrar.Size = new Size(123, 48);
            BtCerrar.TabIndex = 2;
            BtCerrar.Text = "Salir";
            BtCerrar.UseVisualStyleBackColor = true;
            BtCerrar.Click += BtCerrar_Click;
            // 
            // TxValorIni
            // 
            TxValorIni.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            TxValorIni.Location = new Point(12, 66);
            TxValorIni.Name = "TxValorIni";
            TxValorIni.Size = new Size(125, 39);
            TxValorIni.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(185, 32);
            label1.TabIndex = 4;
            label1.Text = "Posición inicial";
            // 
            // FrmInicio
            // 
            AcceptButton = BtIniciar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(1252, 267);
            Controls.Add(label1);
            Controls.Add(TxValorIni);
            Controls.Add(BtCerrar);
            Controls.Add(Lbdesplazar);
            Controls.Add(BtIniciar);
            Name = "FrmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "For";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtIniciar;
        private Label Lbdesplazar;
        private Button BtCerrar;
        private TextBox TxValorIni;
        private Label label1;
    }
}