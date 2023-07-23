namespace Matrices
{
    partial class Matrices_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Matrices_2));
            BtAgregar = new Button();
            BtSalir = new Button();
            TXingreso = new TextBox();
            label1 = new Label();
            Btlistar = new Button();
            LblRes = new Label();
            BtDimension = new Button();
            label2 = new Label();
            TxCantidad = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // BtAgregar
            // 
            BtAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtAgregar.Location = new Point(443, 189);
            BtAgregar.Name = "BtAgregar";
            BtAgregar.Size = new Size(97, 37);
            BtAgregar.TabIndex = 0;
            BtAgregar.Text = "Ingresar";
            BtAgregar.UseVisualStyleBackColor = true;
            BtAgregar.Click += BtAgregar_Click;
            // 
            // BtSalir
            // 
            BtSalir.Cursor = Cursors.Hand;
            BtSalir.Location = new Point(1197, 529);
            BtSalir.Name = "BtSalir";
            BtSalir.Size = new Size(149, 54);
            BtSalir.TabIndex = 1;
            BtSalir.Text = "salir";
            BtSalir.UseVisualStyleBackColor = true;
            BtSalir.Click += BtSalir_Click;
            // 
            // TXingreso
            // 
            TXingreso.Location = new Point(203, 194);
            TXingreso.Name = "TXingreso";
            TXingreso.Size = new Size(225, 27);
            TXingreso.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(171, 27);
            label1.Name = "label1";
            label1.Size = new Size(1053, 72);
            label1.TabIndex = 3;
            label1.Text = "Programa Dimensiones -  Segunda parte";
            // 
            // Btlistar
            // 
            Btlistar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Btlistar.Location = new Point(546, 189);
            Btlistar.Name = "Btlistar";
            Btlistar.Size = new Size(71, 37);
            Btlistar.TabIndex = 4;
            Btlistar.Text = "Listar";
            Btlistar.UseVisualStyleBackColor = true;
            Btlistar.Click += Btlistar_Click;
            // 
            // LblRes
            // 
            LblRes.AutoSize = true;
            LblRes.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LblRes.Location = new Point(203, 276);
            LblRes.Name = "LblRes";
            LblRes.Size = new Size(0, 32);
            LblRes.TabIndex = 5;
            // 
            // BtDimension
            // 
            BtDimension.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtDimension.Location = new Point(315, 134);
            BtDimension.Name = "BtDimension";
            BtDimension.Size = new Size(113, 47);
            BtDimension.TabIndex = 6;
            BtDimension.Text = "Dimensionar";
            BtDimension.UseVisualStyleBackColor = true;
            BtDimension.Click += BtDimension_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 144);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 7;
            label2.Text = "Cantidad";
            // 
            // TxCantidad
            // 
            TxCantidad.Location = new Point(203, 141);
            TxCantidad.Name = "TxCantidad";
            TxCantidad.Size = new Size(98, 27);
            TxCantidad.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 197);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 9;
            label3.Text = "Nombre";
            // 
            // Matrices_2
            // 
            AcceptButton = BtAgregar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(1358, 595);
            Controls.Add(label3);
            Controls.Add(TxCantidad);
            Controls.Add(label2);
            Controls.Add(BtDimension);
            Controls.Add(LblRes);
            Controls.Add(Btlistar);
            Controls.Add(label1);
            Controls.Add(TXingreso);
            Controls.Add(BtSalir);
            Controls.Add(BtAgregar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Matrices_2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Matrices_2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtAgregar;
        private Button BtSalir;
        private TextBox TXingreso;
        private Label label1;
        private Button Btlistar;
        private Label LblRes;
        private Button BtDimension;
        private Label label2;
        private TextBox TxCantidad;
        private Label label3;
    }
}