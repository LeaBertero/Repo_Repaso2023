namespace Estructuras
{
    partial class FrmNuevo
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
            BtSalir2 = new Button();
            SuspendLayout();
            // 
            // BtSalir2
            // 
            BtSalir2.BackColor = Color.Orange;
            BtSalir2.Cursor = Cursors.Hand;
            BtSalir2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            BtSalir2.Location = new Point(599, 359);
            BtSalir2.Name = "BtSalir2";
            BtSalir2.Size = new Size(175, 79);
            BtSalir2.TabIndex = 1;
            BtSalir2.Text = "Salir";
            BtSalir2.UseVisualStyleBackColor = false;
            BtSalir2.Click += BtSalir2_Click;
            // 
            // FrmNuevo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtSalir2);
            Name = "FrmNuevo";
            Text = "Nuevo";
            Load += FrmNuevo_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BtSalir2;
    }
}