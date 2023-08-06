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
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // BtMover
            // 
            BtMover.BackColor = Color.Gold;
            BtMover.Location = new Point(12, 12);
            BtMover.Name = "BtMover";
            BtMover.Size = new Size(265, 61);
            BtMover.TabIndex = 0;
            BtMover.Text = "MOver";
            BtMover.UseVisualStyleBackColor = false;
            BtMover.Click += BtMover_Click;
            // 
            // Btsalir
            // 
            Btsalir.Cursor = Cursors.Hand;
            Btsalir.Location = new Point(911, 472);
            Btsalir.Name = "Btsalir";
            Btsalir.Size = new Size(160, 61);
            Btsalir.TabIndex = 1;
            Btsalir.Text = "Salir";
            Btsalir.UseVisualStyleBackColor = true;
            Btsalir.Click += Btsalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 143);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 212);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // Dowhile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1083, 545);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btsalir);
            Controls.Add(BtMover);
            Name = "Dowhile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dowhile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtMover;
        private Button Btsalir;
        private Label label1;
        private Label label2;
    }
}