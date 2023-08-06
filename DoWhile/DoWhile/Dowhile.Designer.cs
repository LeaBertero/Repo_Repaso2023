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
            red = new Label();
            blue = new Label();
            Comenzar = new Button();
            SuspendLayout();
            // 
            // BtMover
            // 
            BtMover.BackColor = Color.Gold;
            BtMover.Cursor = Cursors.Hand;
            BtMover.Location = new Point(413, 472);
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
            Btsalir.Location = new Point(911, 472);
            Btsalir.Name = "Btsalir";
            Btsalir.Size = new Size(160, 61);
            Btsalir.TabIndex = 1;
            Btsalir.Text = "Salir";
            Btsalir.UseVisualStyleBackColor = true;
            Btsalir.Click += Btsalir_Click;
            // 
            // azul
            // 
            azul.BackColor = Color.Blue;
            azul.Location = new Point(1003, 354);
            azul.Name = "azul";
            azul.Size = new Size(68, 60);
            azul.TabIndex = 2;
            azul.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rojo
            // 
            rojo.BackColor = Color.Red;
            rojo.Location = new Point(12, 354);
            rojo.Name = "rojo";
            rojo.Size = new Size(68, 60);
            rojo.TabIndex = 3;
            rojo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // red
            // 
            red.BackColor = Color.Red;
            red.Enabled = false;
            red.Location = new Point(124, 107);
            red.Name = "red";
            red.Size = new Size(68, 60);
            red.TabIndex = 6;
            red.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // blue
            // 
            blue.BackColor = Color.Blue;
            blue.Enabled = false;
            blue.Location = new Point(954, 107);
            blue.Name = "blue";
            blue.Size = new Size(68, 60);
            blue.TabIndex = 5;
            blue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Comenzar
            // 
            Comenzar.BackColor = Color.Gold;
            Comenzar.Cursor = Cursors.Hand;
            Comenzar.Enabled = false;
            Comenzar.Location = new Point(413, 12);
            Comenzar.Name = "Comenzar";
            Comenzar.Size = new Size(265, 61);
            Comenzar.TabIndex = 4;
            Comenzar.Text = "Comenzar";
            Comenzar.UseVisualStyleBackColor = false;
            Comenzar.Click += Comenzar_Click;
            // 
            // Dowhile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1083, 545);
            Controls.Add(red);
            Controls.Add(blue);
            Controls.Add(Comenzar);
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
        private Label red;
        private Label blue;
        private Button Comenzar;
    }
}