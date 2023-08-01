namespace Operadores
{
    partial class Oper2
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
            label2 = new Label();
            BtCalcular = new Button();
            TxCalc2 = new TextBox();
            TxCalc1 = new TextBox();
            label1 = new Label();
            LbRes = new Label();
            LblContador = new Button();
            Lblincremento = new Label();
            SuspendLayout();
            // 
            // BtSalir
            // 
            BtSalir.Cursor = Cursors.Hand;
            BtSalir.Location = new Point(848, 457);
            BtSalir.Name = "BtSalir";
            BtSalir.Size = new Size(147, 69);
            BtSalir.TabIndex = 0;
            BtSalir.Text = "Salir";
            BtSalir.UseVisualStyleBackColor = true;
            BtSalir.Click += BtSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(65, 22);
            label2.Name = "label2";
            label2.Size = new Size(850, 67);
            label2.TabIndex = 7;
            label2.Text = "segundo formulario de operadores";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtCalcular
            // 
            BtCalcular.Location = new Point(685, 154);
            BtCalcular.Name = "BtCalcular";
            BtCalcular.Size = new Size(94, 29);
            BtCalcular.TabIndex = 8;
            BtCalcular.Text = "Calcular";
            BtCalcular.UseVisualStyleBackColor = true;
            BtCalcular.Click += BtCalcular_Click;
            // 
            // TxCalc2
            // 
            TxCalc2.Location = new Point(483, 154);
            TxCalc2.Name = "TxCalc2";
            TxCalc2.Size = new Size(125, 27);
            TxCalc2.TabIndex = 9;
            // 
            // TxCalc1
            // 
            TxCalc1.Location = new Point(220, 154);
            TxCalc1.Name = "TxCalc1";
            TxCalc1.Size = new Size(125, 27);
            TxCalc1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(383, 130);
            label1.Name = "label1";
            label1.Size = new Size(49, 67);
            label1.TabIndex = 11;
            label1.Text = "-";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LbRes
            // 
            LbRes.AutoSize = true;
            LbRes.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            LbRes.ForeColor = Color.White;
            LbRes.Location = new Point(78, 236);
            LbRes.Name = "LbRes";
            LbRes.Size = new Size(250, 67);
            LbRes.TabIndex = 12;
            LbRes.Text = "resultado";
            LbRes.TextAlign = ContentAlignment.MiddleCenter;
            LbRes.Visible = false;
            // 
            // LblContador
            // 
            LblContador.Location = new Point(78, 401);
            LblContador.Name = "LblContador";
            LblContador.Size = new Size(112, 58);
            LblContador.TabIndex = 13;
            LblContador.Text = "Contador";
            LblContador.UseVisualStyleBackColor = true;
            LblContador.Click += LblContador_Click;
            // 
            // Lblincremento
            // 
            Lblincremento.AutoSize = true;
            Lblincremento.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            Lblincremento.ForeColor = Color.White;
            Lblincremento.Location = new Point(272, 392);
            Lblincremento.Name = "Lblincremento";
            Lblincremento.Size = new Size(299, 67);
            Lblincremento.TabIndex = 14;
            Lblincremento.Text = "Incremento";
            Lblincremento.TextAlign = ContentAlignment.MiddleCenter;
            Lblincremento.Visible = false;
            // 
            // Oper2
            // 
            AcceptButton = BtCalcular;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.YellowGreen;
            ClientSize = new Size(1007, 538);
            Controls.Add(Lblincremento);
            Controls.Add(LblContador);
            Controls.Add(LbRes);
            Controls.Add(label1);
            Controls.Add(TxCalc1);
            Controls.Add(TxCalc2);
            Controls.Add(BtCalcular);
            Controls.Add(label2);
            Controls.Add(BtSalir);
            Cursor = Cursors.Hand;
            Name = "Oper2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Oper2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtSalir;
        private Label label2;
        private Button BtCalcular;
        private TextBox TxCalc2;
        private TextBox TxCalc1;
        private Label label1;
        private Label LbRes;
        private Button LblContador;
        private Label Lblincremento;
    }
}