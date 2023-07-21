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
            Btcerrar = new Button();
            SuspendLayout();
            // 
            // Btcerrar
            // 
            Btcerrar.Location = new Point(1020, 516);
            Btcerrar.Name = "Btcerrar";
            Btcerrar.Size = new Size(134, 47);
            Btcerrar.TabIndex = 0;
            Btcerrar.Text = "Cerrar";
            Btcerrar.UseVisualStyleBackColor = true;
            Btcerrar.Click += Btcerrar_Click;
            // 
            // Matrices_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 581);
            Controls.Add(Btcerrar);
            Name = "Matrices_2";
            Text = "Matrices_2";
            ResumeLayout(false);
        }

        #endregion

        private Button Btcerrar;
    }
}