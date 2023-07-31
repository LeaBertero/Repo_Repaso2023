namespace FrmPrueba
{
    partial class FrmInicio
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
            label1 = new Label();
            label2 = new Label();
            TxNum1 = new TextBox();
            TxNum2 = new TextBox();
            BtRes = new Button();
            LblRes = new Label();
            BtCerrar = new Button();
            TxOperador = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 116);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Número 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(572, 116);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Número 2";
            // 
            // TxNum1
            // 
            TxNum1.Location = new Point(245, 174);
            TxNum1.Name = "TxNum1";
            TxNum1.Size = new Size(125, 27);
            TxNum1.TabIndex = 1;
            TxNum1.TextAlign = HorizontalAlignment.Center;
            // 
            // TxNum2
            // 
            TxNum2.Location = new Point(572, 174);
            TxNum2.Name = "TxNum2";
            TxNum2.Size = new Size(125, 27);
            TxNum2.TabIndex = 3;
            TxNum2.TextAlign = HorizontalAlignment.Center;
            
            // 
            // BtRes
            // 
            BtRes.BackColor = Color.Goldenrod;
            BtRes.Cursor = Cursors.Hand;
            BtRes.Location = new Point(746, 172);
            BtRes.Name = "BtRes";
            BtRes.Size = new Size(94, 29);
            BtRes.TabIndex = 4;
            BtRes.Text = "=";
            BtRes.UseVisualStyleBackColor = false;
            BtRes.Click += BtRes_Click;
            // 
            // LblRes
            // 
            LblRes.AutoSize = true;
            LblRes.Location = new Point(916, 176);
            LblRes.Name = "LblRes";
            LblRes.Size = new Size(0, 20);
            LblRes.TabIndex = 6;
            LblRes.Visible = false;
            // 
            // BtCerrar
            // 
            BtCerrar.Cursor = Cursors.Hand;
            BtCerrar.Location = new Point(12, 310);
            BtCerrar.Name = "BtCerrar";
            BtCerrar.Size = new Size(94, 29);
            BtCerrar.TabIndex = 7;
            BtCerrar.Text = "Salir";
            BtCerrar.UseVisualStyleBackColor = true;
            BtCerrar.Click += BtCerrar_Click;
            // 
            // TxOperador
            // 
            TxOperador.Location = new Point(431, 176);
            TxOperador.Name = "TxOperador";
            TxOperador.Size = new Size(61, 27);
            TxOperador.TabIndex = 2;
            TxOperador.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(384, 99);
            label3.Name = "label3";
            label3.Size = new Size(153, 41);
            label3.TabIndex = 9;
            label3.Text = "Operador";
            // 
            // FrmInicio
            // 
            AcceptButton = BtRes;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(1157, 351);
            Controls.Add(label3);
            Controls.Add(TxOperador);
            Controls.Add(BtCerrar);
            Controls.Add(LblRes);
            Controls.Add(BtRes);
            Controls.Add(TxNum2);
            Controls.Add(TxNum1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmInicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxNum1;
        private TextBox TxNum2;
        private Button BtRes;
        private Label LblRes;
        private Button BtCerrar;
        private TextBox TxOperador;
        private Label label3;
    }
}