namespace Matrices
{
    partial class Matrices
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
            label1 = new Label();
            TxIngreso = new TextBox();
            LblRes = new Label();
            BtInicio = new Button();
            lblMensaje = new Label();
            BtSalir = new Button();
            BtListar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(405, 18);
            label1.Name = "label1";
            label1.Size = new Size(275, 81);
            label1.TabIndex = 0;
            label1.Text = "Matrices";
            // 
            // TxIngreso
            // 
            TxIngreso.Location = new Point(135, 146);
            TxIngreso.Name = "TxIngreso";
            TxIngreso.Size = new Size(483, 27);
            TxIngreso.TabIndex = 1;
            // 
            // LblRes
            // 
            LblRes.AutoSize = true;
            LblRes.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LblRes.Location = new Point(135, 226);
            LblRes.Name = "LblRes";
            LblRes.Size = new Size(0, 32);
            LblRes.TabIndex = 2;
            // 
            // BtInicio
            // 
            BtInicio.Location = new Point(677, 144);
            BtInicio.Name = "BtInicio";
            BtInicio.Size = new Size(94, 29);
            BtInicio.TabIndex = 3;
            BtInicio.Text = "comenzar";
            BtInicio.UseVisualStyleBackColor = true;
            BtInicio.Click += BtInicio_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblMensaje.ForeColor = Color.White;
            lblMensaje.Location = new Point(135, 554);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 32);
            lblMensaje.TabIndex = 4;
            lblMensaje.Visible = false;
            // 
            // BtSalir
            // 
            BtSalir.BackColor = Color.YellowGreen;
            BtSalir.Cursor = Cursors.Hand;
            BtSalir.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtSalir.ForeColor = SystemColors.ButtonHighlight;
            BtSalir.Location = new Point(931, 565);
            BtSalir.Name = "BtSalir";
            BtSalir.Size = new Size(168, 51);
            BtSalir.TabIndex = 5;
            BtSalir.Text = "Salir";
            BtSalir.UseVisualStyleBackColor = false;
            BtSalir.Click += BtSalir_Click;
            // 
            // BtListar
            // 
            BtListar.Location = new Point(792, 146);
            BtListar.Name = "BtListar";
            BtListar.Size = new Size(94, 29);
            BtListar.TabIndex = 6;
            BtListar.Text = "Listar";
            BtListar.UseVisualStyleBackColor = true;
            BtListar.Click += BtListar_Click;
            // 
            // Matrices
            // 
            AcceptButton = BtInicio;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GreenYellow;
            ClientSize = new Size(1111, 628);
            Controls.Add(BtListar);
            Controls.Add(BtSalir);
            Controls.Add(lblMensaje);
            Controls.Add(BtInicio);
            Controls.Add(LblRes);
            Controls.Add(TxIngreso);
            Controls.Add(label1);
            Name = "Matrices";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Matrices";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxIngreso;
        private Label LblRes;
        private Button BtInicio;
        private Label lblMensaje;
        private Button BtSalir;
        private Button BtListar;
    }
}