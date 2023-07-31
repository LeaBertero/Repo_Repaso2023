namespace Cadena_dato
{
    partial class FrmDato
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
            BtSalir = new Button();
            Btconvert = new Button();
            TXDato = new TextBox();
            LblRes = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtSalir
            // 
            BtSalir.Cursor = Cursors.Hand;
            BtSalir.Location = new Point(366, 406);
            BtSalir.Name = "BtSalir";
            BtSalir.Size = new Size(259, 29);
            BtSalir.TabIndex = 0;
            BtSalir.Text = "Salir";
            BtSalir.UseVisualStyleBackColor = true;
            BtSalir.Click += BtSalir_Click;
            // 
            // Btconvert
            // 
            Btconvert.Location = new Point(366, 145);
            Btconvert.Name = "Btconvert";
            Btconvert.Size = new Size(259, 55);
            Btconvert.TabIndex = 1;
            Btconvert.Text = "Convertir";
            Btconvert.UseVisualStyleBackColor = true;
            Btconvert.Click += Btconvert_Click;
            // 
            // TXDato
            // 
            TXDato.Location = new Point(366, 100);
            TXDato.Name = "TXDato";
            TXDato.Size = new Size(259, 27);
            TXDato.TabIndex = 2;
            // 
            // LblRes
            // 
            LblRes.AutoSize = true;
            LblRes.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            LblRes.Location = new Point(428, 246);
            LblRes.Name = "LblRes";
            LblRes.Size = new Size(172, 72);
            LblRes.TabIndex = 3;
            LblRes.Text = "label1";
            LblRes.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(982, 72);
            label1.TabIndex = 4;
            label1.Text = "Ingrese una frase para poder convertirla";
            label1.Visible = false;
            // 
            // FrmDato
            // 
            AcceptButton = Btconvert;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 450);
            Controls.Add(label1);
            Controls.Add(LblRes);
            Controls.Add(TXDato);
            Controls.Add(Btconvert);
            Controls.Add(BtSalir);
            Name = "FrmDato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "prueba de ingreso de datos ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtSalir;
        private Button Btconvert;
        private TextBox TXDato;
        private Label LblRes;
        private Label label1;
    }
}