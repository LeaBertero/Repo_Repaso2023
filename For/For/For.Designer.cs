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
            BtComenzar_2 = new Button();
            LblMover2 = new Label();
            TxLeft = new TextBox();
            SuspendLayout();
            // 
            // BtIniciar
            // 
            BtIniciar.Cursor = Cursors.Hand;
            BtIniciar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtIniciar.Location = new Point(179, 66);
            BtIniciar.Name = "BtIniciar";
            BtIniciar.Size = new Size(167, 39);
            BtIniciar.TabIndex = 0;
            BtIniciar.Text = "Comenzar rojo";
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
            BtCerrar.Location = new Point(1117, 278);
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
            // BtComenzar_2
            // 
            BtComenzar_2.Cursor = Cursors.Hand;
            BtComenzar_2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtComenzar_2.Location = new Point(1051, 66);
            BtComenzar_2.Name = "BtComenzar_2";
            BtComenzar_2.Size = new Size(188, 39);
            BtComenzar_2.TabIndex = 5;
            BtComenzar_2.Text = "Comenzar Verde";
            BtComenzar_2.UseVisualStyleBackColor = true;
            BtComenzar_2.Click += BtComenzar_2_Click;
            // 
            // LblMover2
            // 
            LblMover2.BackColor = Color.Chartreuse;
            LblMover2.BorderStyle = BorderStyle.Fixed3D;
            LblMover2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LblMover2.Location = new Point(1112, 166);
            LblMover2.Name = "LblMover2";
            LblMover2.Size = new Size(140, 79);
            LblMover2.TabIndex = 6;
            LblMover2.Text = "Lean";
            LblMover2.TextAlign = ContentAlignment.MiddleCenter;
            LblMover2.Visible = false;
            // 
            // TxLeft
            // 
            TxLeft.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            TxLeft.Location = new Point(891, 66);
            TxLeft.Name = "TxLeft";
            TxLeft.Size = new Size(125, 39);
            TxLeft.TabIndex = 7;
            // 
            // FrmInicio
            // 
            AcceptButton = BtIniciar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(1252, 338);
            Controls.Add(TxLeft);
            Controls.Add(LblMover2);
            Controls.Add(BtComenzar_2);
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
        private Button BtComenzar_2;
        private Label LblMover2;
        private TextBox TxLeft;
    }
}