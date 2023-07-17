namespace EjemploFor
{
    partial class siguiente
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
            BtComenzar = new Button();
            TxDesde1 = new TextBox();
            TxHasta2 = new TextBox();
            TxPaso3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LblResultado = new Label();
            SuspendLayout();
            // 
            // BtSalir
            // 
            BtSalir.BackColor = Color.MediumOrchid;
            BtSalir.Cursor = Cursors.Hand;
            BtSalir.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtSalir.ForeColor = SystemColors.HighlightText;
            BtSalir.Location = new Point(222, 368);
            BtSalir.Name = "BtSalir";
            BtSalir.Size = new Size(668, 55);
            BtSalir.TabIndex = 0;
            BtSalir.Text = "Salir";
            BtSalir.UseVisualStyleBackColor = false;
            BtSalir.Click += BtSalir_Click;
            // 
            // BtComenzar
            // 
            BtComenzar.BackColor = Color.MediumOrchid;
            BtComenzar.Cursor = Cursors.Hand;
            BtComenzar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtComenzar.ForeColor = SystemColors.HighlightText;
            BtComenzar.Location = new Point(723, 184);
            BtComenzar.Name = "BtComenzar";
            BtComenzar.Size = new Size(167, 55);
            BtComenzar.TabIndex = 1;
            BtComenzar.Text = "Comenzar";
            BtComenzar.UseVisualStyleBackColor = false;
            BtComenzar.Click += BtComenzar_Click;
            // 
            // TxDesde1
            // 
            TxDesde1.Location = new Point(222, 202);
            TxDesde1.Name = "TxDesde1";
            TxDesde1.Size = new Size(125, 27);
            TxDesde1.TabIndex = 2;
            // 
            // TxHasta2
            // 
            TxHasta2.Location = new Point(381, 202);
            TxHasta2.Name = "TxHasta2";
            TxHasta2.Size = new Size(125, 27);
            TxHasta2.TabIndex = 3;
            // 
            // TxPaso3
            // 
            TxPaso3.Location = new Point(530, 202);
            TxPaso3.Name = "TxPaso3";
            TxPaso3.Size = new Size(125, 27);
            TxPaso3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 146);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 5;
            label1.Text = "Desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(381, 146);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 6;
            label2.Text = "Hasta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(530, 146);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 7;
            label3.Text = "Paso";
            // 
            // LblResultado
            // 
            LblResultado.AutoSize = true;
            LblResultado.Location = new Point(222, 307);
            LblResultado.Name = "LblResultado";
            LblResultado.Size = new Size(75, 20);
            LblResultado.TabIndex = 8;
            LblResultado.Text = "Resultado";
            // 
            // siguiente
            // 
            AcceptButton = BtSalir;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Violet;
            ClientSize = new Size(1048, 526);
            Controls.Add(LblResultado);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxPaso3);
            Controls.Add(TxHasta2);
            Controls.Add(TxDesde1);
            Controls.Add(BtComenzar);
            Controls.Add(BtSalir);
            Name = "siguiente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "siguiente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtSalir;
        private Button BtComenzar;
        private TextBox TxDesde1;
        private TextBox TxHasta2;
        private TextBox TxPaso3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label LblResultado;
    }
}