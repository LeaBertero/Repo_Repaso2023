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
            TxDiv1 = new TextBox();
            TxDiv2 = new TextBox();
            BtCalcular = new Button();
            LbRes = new Label();
            LbMensaje = new Label();
            label1 = new Label();
            button1 = new Button();
            BtSalir = new Button();
            BtLimpiar = new Button();
            label2 = new Label();
            TxMult2 = new TextBox();
            TxMult1 = new TextBox();
            btsiguiente = new Button();
            BtHora = new Button();
            LbHora = new Label();
            SuspendLayout();
            // 
            // TxDiv1
            // 
            TxDiv1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            TxDiv1.Location = new Point(86, 176);
            TxDiv1.Name = "TxDiv1";
            TxDiv1.Size = new Size(125, 43);
            TxDiv1.TabIndex = 1;
            // 
            // TxDiv2
            // 
            TxDiv2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            TxDiv2.Location = new Point(345, 176);
            TxDiv2.Name = "TxDiv2";
            TxDiv2.Size = new Size(125, 43);
            TxDiv2.TabIndex = 2;
            // 
            // BtCalcular
            // 
            BtCalcular.BackColor = Color.DodgerBlue;
            BtCalcular.Cursor = Cursors.Hand;
            BtCalcular.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtCalcular.ForeColor = SystemColors.ControlLightLight;
            BtCalcular.Location = new Point(558, 173);
            BtCalcular.Name = "BtCalcular";
            BtCalcular.Size = new Size(143, 46);
            BtCalcular.TabIndex = 3;
            BtCalcular.Text = "Calcular";
            BtCalcular.UseVisualStyleBackColor = false;
            BtCalcular.Click += BtCalcular_Click;
            // 
            // LbRes
            // 
            LbRes.AutoSize = true;
            LbRes.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LbRes.Location = new Point(766, 183);
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
            LbMensaje.Location = new Point(86, 385);
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
            label1.Location = new Point(258, 173);
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
            button1.Location = new Point(86, 12);
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
            BtSalir.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BtSalir.ForeColor = Color.WhiteSmoke;
            BtSalir.Location = new Point(1202, 12);
            BtSalir.Name = "BtSalir";
            BtSalir.Size = new Size(137, 45);
            BtSalir.TabIndex = 7;
            BtSalir.Text = "Salir";
            BtSalir.UseVisualStyleBackColor = false;
            BtSalir.Click += BtSalir_Click;
            // 
            // BtLimpiar
            // 
            BtLimpiar.BackColor = Color.DodgerBlue;
            BtLimpiar.Cursor = Cursors.Hand;
            BtLimpiar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtLimpiar.ForeColor = SystemColors.ControlLightLight;
            BtLimpiar.Location = new Point(558, 225);
            BtLimpiar.Name = "BtLimpiar";
            BtLimpiar.Size = new Size(143, 46);
            BtLimpiar.TabIndex = 4;
            BtLimpiar.Text = "CE";
            BtLimpiar.UseVisualStyleBackColor = false;
            BtLimpiar.Click += BtLimpiar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(258, 260);
            label2.Name = "label2";
            label2.Size = new Size(29, 37);
            label2.TabIndex = 10;
            label2.Text = "*";
            // 
            // TxMult2
            // 
            TxMult2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            TxMult2.Location = new Point(345, 263);
            TxMult2.Name = "TxMult2";
            TxMult2.Size = new Size(125, 43);
            TxMult2.TabIndex = 9;
            // 
            // TxMult1
            // 
            TxMult1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            TxMult1.Location = new Point(86, 263);
            TxMult1.Name = "TxMult1";
            TxMult1.Size = new Size(125, 43);
            TxMult1.TabIndex = 8;
            // 
            // btsiguiente
            // 
            btsiguiente.BackColor = Color.DeepSkyBlue;
            btsiguiente.Cursor = Cursors.Hand;
            btsiguiente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btsiguiente.ForeColor = Color.WhiteSmoke;
            btsiguiente.Location = new Point(1202, 478);
            btsiguiente.Name = "btsiguiente";
            btsiguiente.Size = new Size(137, 45);
            btsiguiente.TabIndex = 11;
            btsiguiente.Text = "siguiente";
            btsiguiente.UseVisualStyleBackColor = false;
            btsiguiente.Click += btsiguiente_Click;
            // 
            // BtHora
            // 
            BtHora.BackColor = Color.DeepSkyBlue;
            BtHora.Cursor = Cursors.Hand;
            BtHora.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BtHora.ForeColor = Color.WhiteSmoke;
            BtHora.Location = new Point(74, 451);
            BtHora.Name = "BtHora";
            BtHora.Size = new Size(137, 45);
            BtHora.TabIndex = 12;
            BtHora.Text = "Hora";
            BtHora.UseVisualStyleBackColor = false;
            BtHora.Click += BtHora_Click;
            // 
            // LbHora
            // 
            LbHora.AutoSize = true;
            LbHora.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LbHora.Location = new Point(311, 458);
            LbHora.Name = "LbHora";
            LbHora.Size = new Size(83, 32);
            LbHora.TabIndex = 13;
            LbHora.Text = "label2";
            LbHora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Try
            // 
            AcceptButton = BtCalcular;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1351, 535);
            Controls.Add(LbHora);
            Controls.Add(BtHora);
            Controls.Add(btsiguiente);
            Controls.Add(label2);
            Controls.Add(TxMult2);
            Controls.Add(TxMult1);
            Controls.Add(BtLimpiar);
            Controls.Add(BtSalir);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(LbMensaje);
            Controls.Add(LbRes);
            Controls.Add(BtCalcular);
            Controls.Add(TxDiv2);
            Controls.Add(TxDiv1);
            Name = "Try";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercico de control de errores (TryCatch)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxDiv1;
        private TextBox TxDiv2;
        private Button BtCalcular;
        private Label LbRes;
        private Label LbMensaje;
        private Label label1;
        private Button button1;
        private Button BtSalir;
        private Button BtLimpiar;
        private Label label2;
        private TextBox TxMult2;
        private TextBox TxMult1;
        private Button btsiguiente;
        private Button BtHora;
        private Label LbHora;
    }
}