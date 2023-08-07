namespace Try
{
    partial class Try2
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
            BtCalculo = new Button();
            TxNum1 = new TextBox();
            TxNum2 = new TextBox();
            label1 = new Label();
            LbRes = new Label();
            SuspendLayout();
            // 
            // BtCalculo
            // 
            BtCalculo.Location = new Point(710, 132);
            BtCalculo.Name = "BtCalculo";
            BtCalculo.Size = new Size(130, 38);
            BtCalculo.TabIndex = 0;
            BtCalculo.Text = "Calcular";
            BtCalculo.UseVisualStyleBackColor = true;
            BtCalculo.Click += BtCalculo_Click;
            // 
            // TxNum1
            // 
            TxNum1.Location = new Point(199, 138);
            TxNum1.Name = "TxNum1";
            TxNum1.Size = new Size(138, 27);
            TxNum1.TabIndex = 1;
            // 
            // TxNum2
            // 
            TxNum2.Location = new Point(477, 138);
            TxNum2.Name = "TxNum2";
            TxNum2.Size = new Size(138, 27);
            TxNum2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(390, 141);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 3;
            label1.Text = "+";
            // 
            // LbRes
            // 
            LbRes.AutoSize = true;
            LbRes.Location = new Point(917, 141);
            LbRes.Name = "LbRes";
            LbRes.Size = new Size(50, 20);
            LbRes.TabIndex = 4;
            LbRes.Text = "label2";
            // 
            // Try2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1106, 487);
            Controls.Add(LbRes);
            Controls.Add(label1);
            Controls.Add(TxNum2);
            Controls.Add(TxNum1);
            Controls.Add(BtCalculo);
            Name = "Try2";
            Text = "Try2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtCalculo;
        private TextBox TxNum1;
        private TextBox TxNum2;
        private Label label1;
        private Label LbRes;
    }
}