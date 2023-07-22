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
            SuspendLayout();
            // 
            // BtAgregar
            // 
            BtAgregar.Location = new Point(613, 189);
            BtAgregar.Name = "BtAgregar";
            BtAgregar.Size = new Size(183, 37);
            BtAgregar.TabIndex = 0;
            BtAgregar.Text = "aceptar";
            BtAgregar.UseVisualStyleBackColor = true;
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
            TXingreso.Size = new Size(363, 27);
            TXingreso.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(168, 27);
            label1.Name = "label1";
            label1.Size = new Size(1053, 72);
            label1.TabIndex = 3;
            label1.Text = "Programa Dimensiones -  Segunda parte";
            // 
            // Matrices_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(1358, 595);
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
    }
}