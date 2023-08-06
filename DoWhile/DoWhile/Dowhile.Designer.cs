namespace DoWhile
{
    partial class Dowhile
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
            BtMover = new Button();
            Btsalir = new Button();
            azul = new Label();
            rojo = new Label();
            SuspendLayout();
            // 
            // BtMover
            // 
            BtMover.BackColor = Color.Gold;
            BtMover.Cursor = Cursors.Hand;
            BtMover.Location = new Point(390, 41);
            BtMover.Name = "BtMover";
            BtMover.Size = new Size(265, 61);
            BtMover.TabIndex = 0;
            BtMover.Text = "Mover";
            BtMover.UseVisualStyleBackColor = false;
            BtMover.Click += BtMover_Click;
            // 
            // Btsalir
            // 
            Btsalir.Cursor = Cursors.Hand;
            Btsalir.Location = new Point(390, 472);
            Btsalir.Name = "Btsalir";
            Btsalir.Size = new Size(265, 61);
            Btsalir.TabIndex = 1;
            Btsalir.Text = "Salir";
            Btsalir.UseVisualStyleBackColor = true;
            Btsalir.Click += Btsalir_Click;
            // 
            // azul
            // 
            azul.BackColor = Color.Blue;
            azul.Location = new Point(727, 215);
            azul.Name = "azul";
            azul.Size = new Size(68, 60);
            azul.TabIndex = 2;
            azul.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rojo
            // 
            rojo.BackColor = Color.Red;
            rojo.Location = new Point(213, 215);
            rojo.Name = "rojo";
            rojo.Size = new Size(68, 60);
            rojo.TabIndex = 3;
            rojo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Dowhile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1083, 545);
            Controls.Add(rojo);
            Controls.Add(azul);
            Controls.Add(Btsalir);
            Controls.Add(BtMover);
            Name = "Dowhile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dowhile";
            ResumeLayout(false);
        }

        #endregion

        private Button BtMover;
        private Button Btsalir;
        private Label azul;
        private Label rojo;
    }
}