namespace Operadores
{
    partial class FormPrueba
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
            BtComenzar = new Button();
            LblContar = new Label();
            BtSalir = new Button();
            SuspendLayout();
            // 
            // BtComenzar
            // 
            BtComenzar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtComenzar.Location = new Point(257, 213);
            BtComenzar.Name = "BtComenzar";
            BtComenzar.Size = new Size(208, 112);
            BtComenzar.TabIndex = 0;
            BtComenzar.Text = "Comenzar";
            BtComenzar.UseVisualStyleBackColor = true;
            BtComenzar.Click += BtComenzar_Click;
            // 
            // LblContar
            // 
            LblContar.AutoSize = true;
            LblContar.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LblContar.Location = new Point(611, 259);
            LblContar.Name = "LblContar";
            LblContar.Size = new Size(96, 37);
            LblContar.TabIndex = 1;
            LblContar.Text = "label1";
            // 
            // BtSalir
            // 
            BtSalir.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtSalir.Location = new Point(887, 12);
            BtSalir.Name = "BtSalir";
            BtSalir.Size = new Size(202, 57);
            BtSalir.TabIndex = 2;
            BtSalir.Text = "Salir";
            BtSalir.UseVisualStyleBackColor = true;
            BtSalir.Click += BtSalir_Click;
            // 
            // FormPrueba
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 578);
            Controls.Add(BtSalir);
            Controls.Add(LblContar);
            Controls.Add(BtComenzar);
            Name = "FormPrueba";
            Text = "FormPrueba";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtComenzar;
        private Label LblContar;
        private Button BtSalir;
    }
}