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
            BtIniciar.Location = new Point(584, 12);
            BtIniciar.Name = "BtIniciar";
            BtIniciar.Size = new Size(298, 176);
            BtIniciar.TabIndex = 0;
            BtIniciar.Text = "Iniciar";
            BtIniciar.TextAlign = ContentAlignment.BottomCenter;
            BtIniciar.UseVisualStyleBackColor = true;
            // 
            // picArg
            // 
            picArg.Image = (Image)resources.GetObject("picArg.Image");
            picArg.Location = new Point(24, 234);
            picArg.Name = "picArg";
            picArg.Size = new Size(286, 178);
            picArg.TabIndex = 1;
            picArg.TabStop = false;
            // 
            // picFra
            // 
            picFra.Image = Properties.Resources.france;
            picFra.Location = new Point(1157, 234);
            picFra.Name = "picFra";
            picFra.Size = new Size(276, 178);
            picFra.TabIndex = 2;
            picFra.TabStop = false;
            // 
            // While
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1456, 495);
            Controls.Add(picFra);
            Controls.Add(picArg);
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
    }
}