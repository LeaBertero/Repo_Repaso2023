namespace While_Mientras_
{
    partial class Do_while
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
            SuspendLayout();
            // 
            // BtSalir
            // 
            BtSalir.BackColor = Color.ForestGreen;
            BtSalir.Cursor = Cursors.Hand;
            BtSalir.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtSalir.ForeColor = SystemColors.Control;
            BtSalir.Location = new Point(892, 523);
            BtSalir.Name = "BtSalir";
            BtSalir.Size = new Size(168, 59);
            BtSalir.TabIndex = 1;
            BtSalir.Text = "Salir";
            BtSalir.UseVisualStyleBackColor = false;
            BtSalir.Click += BtSalir_Click;
            // 
            // Do_while
            // 
            AcceptButton = BtSalir;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.HotPink;
            ClientSize = new Size(1072, 594);
            Controls.Add(BtSalir);
            Name = "Do_while";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Do_while";
            ResumeLayout(false);
        }

        #endregion

        private Button BtSalir;
    }
}