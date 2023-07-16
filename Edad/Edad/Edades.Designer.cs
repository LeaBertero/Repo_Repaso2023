namespace Edad
{
    partial class Edades
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
            BtRes = new Button();
            label1 = new Label();
            LblRes = new Label();
            TxtNota = new TextBox();
            BtLimpiar = new Button();
            SuspendLayout();
            // 
            // BtRes
            // 
            BtRes.Location = new Point(223, 173);
            BtRes.Name = "BtRes";
            BtRes.Size = new Size(144, 47);
            BtRes.TabIndex = 0;
            BtRes.Text = "Comenzar";
            BtRes.UseVisualStyleBackColor = true;
            BtRes.Click += BtRes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 126);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 1;
            label1.Text = "Edad";
            // 
            // LblRes
            // 
            LblRes.AutoSize = true;
            LblRes.Location = new Point(223, 285);
            LblRes.Name = "LblRes";
            LblRes.Size = new Size(43, 20);
            LblRes.TabIndex = 2;
            LblRes.Text = "Edad";
            // 
            // TxtNota
            // 
            TxtNota.Location = new Point(414, 183);
            TxtNota.Name = "TxtNota";
            TxtNota.Size = new Size(155, 27);
            TxtNota.TabIndex = 3;
            // 
            // BtLimpiar
            // 
            BtLimpiar.Location = new Point(414, 216);
            BtLimpiar.Name = "BtLimpiar";
            BtLimpiar.Size = new Size(155, 47);
            BtLimpiar.TabIndex = 4;
            BtLimpiar.Text = "Limpiar";
            BtLimpiar.UseVisualStyleBackColor = true;
            BtLimpiar.Click += BtLimpiar_Click;
            // 
            // Edades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(800, 450);
            Controls.Add(BtLimpiar);
            Controls.Add(TxtNota);
            Controls.Add(LblRes);
            Controls.Add(label1);
            Controls.Add(BtRes);
            Name = "Edades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Programa de edades";
            Load += Edades_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtRes;
        private Label label1;
        private Label LblRes;
        private TextBox TxtNota;
        private Button BtLimpiar;
    }
}