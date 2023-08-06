namespace While
{
    partial class While
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(While));
            BtIniciar = new Button();
            picArg = new PictureBox();
            picFra = new PictureBox();
            BtAcomodar = new Button();
            BtSalir = new Button();
            LblMensaje = new Label();
            ((System.ComponentModel.ISupportInitialize)picArg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFra).BeginInit();
            SuspendLayout();
            // 
            // BtIniciar
            // 
            BtIniciar.BackgroundImage = (Image)resources.GetObject("BtIniciar.BackgroundImage");
            BtIniciar.Cursor = Cursors.Hand;
            BtIniciar.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point);
            BtIniciar.ForeColor = SystemColors.ButtonFace;
            BtIniciar.Location = new Point(601, 12);
            BtIniciar.Name = "BtIniciar";
            BtIniciar.Size = new Size(298, 176);
            BtIniciar.TabIndex = 0;
            BtIniciar.Text = "Iniciar";
            BtIniciar.TextAlign = ContentAlignment.BottomCenter;
            BtIniciar.UseVisualStyleBackColor = true;
            BtIniciar.Click += BtIniciar_Click;
            // 
            // picArg
            // 
            picArg.Image = (Image)resources.GetObject("picArg.Image");
            picArg.Location = new Point(12, 248);
            picArg.Name = "picArg";
            picArg.Size = new Size(267, 173);
            picArg.TabIndex = 1;
            picArg.TabStop = false;
            picArg.Visible = false;
            // 
            // picFra
            // 
            picFra.Image = Properties.Resources.france;
            picFra.Location = new Point(1207, 248);
            picFra.Name = "picFra";
            picFra.Size = new Size(267, 173);
            picFra.TabIndex = 2;
            picFra.TabStop = false;
            picFra.Visible = false;
            // 
            // BtAcomodar
            // 
            BtAcomodar.BackColor = Color.DarkRed;
            BtAcomodar.Cursor = Cursors.Hand;
            BtAcomodar.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            BtAcomodar.ForeColor = SystemColors.ButtonFace;
            BtAcomodar.Location = new Point(601, 633);
            BtAcomodar.Name = "BtAcomodar";
            BtAcomodar.Size = new Size(298, 64);
            BtAcomodar.TabIndex = 3;
            BtAcomodar.Text = "Acomodar";
            BtAcomodar.UseVisualStyleBackColor = false;
            BtAcomodar.Click += BtAcomodar_Click;
            // 
            // BtSalir
            // 
            BtSalir.BackColor = SystemColors.ActiveCaption;
            BtSalir.Cursor = Cursors.Hand;
            BtSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtSalir.ForeColor = SystemColors.ControlLightLight;
            BtSalir.Location = new Point(1313, 648);
            BtSalir.Name = "BtSalir";
            BtSalir.Size = new Size(131, 49);
            BtSalir.TabIndex = 4;
            BtSalir.Text = "Salir";
            BtSalir.UseVisualStyleBackColor = false;
            BtSalir.Click += BtSalir_Click;
            // 
            // LblMensaje
            // 
            LblMensaje.BackColor = Color.DeepSkyBlue;
            LblMensaje.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            LblMensaje.ForeColor = Color.White;
            LblMensaje.Location = new Point(12, 446);
            LblMensaje.Name = "LblMensaje";
            LblMensaje.Size = new Size(1462, 114);
            LblMensaje.TabIndex = 5;
            LblMensaje.Text = "Argentina Campeón del Mundo 2023 !!!!";
            LblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            LblMensaje.Visible = false;
            // 
            // While
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1486, 709);
            Controls.Add(LblMensaje);
            Controls.Add(picArg);
            Controls.Add(picFra);
            Controls.Add(BtSalir);
            Controls.Add(BtAcomodar);
            Controls.Add(BtIniciar);
            Name = "While";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "While";
            ((System.ComponentModel.ISupportInitialize)picArg).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFra).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtIniciar;
        private PictureBox picArg;
        private PictureBox picFra;
        private Button BtAcomodar;
        private Button BtSalir;
        private Label LblMensaje;
    }
}