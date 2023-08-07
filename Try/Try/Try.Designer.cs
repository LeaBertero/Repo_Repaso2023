namespace Try
{
    partial class Try
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
            Txnum1 = new TextBox();
            TxNum2 = new TextBox();
            BtCalcular = new Button();
            LbRes = new Label();
            LbMensaje = new Label();
            label1 = new Label();
            button1 = new Button();
            BtSalir = new Button();
            SuspendLayout();
            // 
            // Txnum1
            // 
            Txnum1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Txnum1.Location = new Point(144, 177);
            Txnum1.Name = "Txnum1";
            Txnum1.Size = new Size(125, 43);
            Txnum1.TabIndex = 0;
            // 
            // TxNum2
            // 
            TxNum2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            TxNum2.Location = new Point(403, 177);
            TxNum2.Name = "TxNum2";
            TxNum2.Size = new Size(125, 43);
            TxNum2.TabIndex = 1;
            // 
            // BtCalcular
            // 
            BtCalcular.Cursor = Cursors.Hand;
            BtCalcular.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtCalcular.Location = new Point(616, 165);
            BtCalcular.Name = "BtCalcular";
            BtCalcular.Size = new Size(143, 67);
            BtCalcular.TabIndex = 2;
            BtCalcular.Text = "Calcular";
            BtCalcular.UseVisualStyleBackColor = true;
            BtCalcular.Click += BtCalcular_Click;
            // 
            // LbRes
            // 
            LbRes.AutoSize = true;
            LbRes.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LbRes.Location = new Point(824, 184);
            LbRes.Name = "LbRes";
            LbRes.Size = new Size(83, 32);
            LbRes.TabIndex = 3;
            LbRes.Text = "label1";
            LbRes.Visible = false;
            // 
            // LbMensaje
            // 
            LbMensaje.AutoSize = true;
            LbMensaje.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LbMensaje.Location = new Point(144, 302);
            LbMensaje.Name = "LbMensaje";
            LbMensaje.Size = new Size(83, 32);
            LbMensaje.TabIndex = 4;
            LbMensaje.Text = "label2";
            LbMensaje.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(316, 174);
            label1.Name = "label1";
            label1.Size = new Size(29, 37);
            label1.TabIndex = 5;
            label1.Text = "/";
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Enabled = false;
            button1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(144, 31);
            button1.Name = "button1";
            button1.Size = new Size(615, 89);
            button1.TabIndex = 6;
            button1.Text = "Ejercicio de TryCatch";
            button1.UseVisualStyleBackColor = false;
            // 
            // BtSalir
            // 
            BtSalir.BackColor = Color.DeepSkyBlue;
            BtSalir.Cursor = Cursors.Hand;
            BtSalir.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            BtSalir.ForeColor = Color.WhiteSmoke;
            BtSalir.Location = new Point(951, 46);
            BtSalir.Name = "BtSalir";
            BtSalir.Size = new Size(140, 59);
            BtSalir.TabIndex = 7;
            BtSalir.Text = "Salir";
            BtSalir.UseVisualStyleBackColor = false;
            BtSalir.Click += BtSalir_Click;
            // 
            // Try
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1103, 359);
            Controls.Add(BtSalir);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(LbMensaje);
            Controls.Add(LbRes);
            Controls.Add(BtCalcular);
            Controls.Add(TxNum2);
            Controls.Add(Txnum1);
            Name = "Try";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercico de control de errores (TryCatch)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txnum1;
        private TextBox TxNum2;
        private Button BtCalcular;
        private Label LbRes;
        private Label LbMensaje;
        private Label label1;
        private Button button1;
        private Button BtSalir;
    }
}