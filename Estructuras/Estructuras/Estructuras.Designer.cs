namespace Estructuras
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            BtSalir = new Button();
            BtNuevo = new Button();
            BtAceptar = new Button();
            TxIngreso = new TextBox();
            label1 = new Label();
            LblResultado = new Label();
            label2 = new Label();
            Btlimpiar = new Button();
            SuspendLayout();
            // 
            // BtSalir
            // 
            BtSalir.BackColor = Color.Orange;
            BtSalir.Cursor = Cursors.Hand;
            BtSalir.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            BtSalir.Location = new Point(868, 12);
            BtSalir.Name = "BtSalir";
            BtSalir.Size = new Size(175, 79);
            BtSalir.TabIndex = 0;
            BtSalir.Text = "Salir";
            BtSalir.UseVisualStyleBackColor = false;
            BtSalir.Click += BtSalir_Click;
            // 
            // BtNuevo
            // 
            BtNuevo.BackColor = Color.Orange;
            BtNuevo.Cursor = Cursors.Hand;
            BtNuevo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            BtNuevo.Location = new Point(12, 12);
            BtNuevo.Name = "BtNuevo";
            BtNuevo.Size = new Size(175, 79);
            BtNuevo.TabIndex = 1;
            BtNuevo.Text = "Nuevo";
            BtNuevo.UseVisualStyleBackColor = false;
            BtNuevo.Click += BtNuevo_Click;
            // 
            // BtAceptar
            // 
            BtAceptar.BackColor = Color.Orange;
            BtAceptar.Cursor = Cursors.Hand;
            BtAceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtAceptar.Location = new Point(417, 257);
            BtAceptar.Name = "BtAceptar";
            BtAceptar.Size = new Size(203, 44);
            BtAceptar.TabIndex = 2;
            BtAceptar.Text = "Aceptar";
            BtAceptar.UseVisualStyleBackColor = false;
            BtAceptar.Click += BtAceptar_Click;
            // 
            // TxIngreso
            // 
            TxIngreso.Location = new Point(417, 224);
            TxIngreso.Name = "TxIngreso";
            TxIngreso.Size = new Size(203, 27);
            TxIngreso.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(417, 166);
            label1.Name = "label1";
            label1.Size = new Size(203, 37);
            label1.TabIndex = 4;
            label1.Text = "Ingrese su edad";
            // 
            // LblResultado
            // 
            LblResultado.AutoSize = true;
            LblResultado.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LblResultado.ForeColor = SystemColors.ControlLightLight;
            LblResultado.Location = new Point(640, 276);
            LblResultado.Name = "LblResultado";
            LblResultado.Size = new Size(134, 37);
            LblResultado.TabIndex = 5;
            LblResultado.Text = "Resultado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(357, 80);
            label2.Name = "label2";
            label2.Size = new Size(329, 46);
            label2.TabIndex = 6;
            label2.Text = "Programa de edades";
            // 
            // Btlimpiar
            // 
            Btlimpiar.BackColor = Color.Orange;
            Btlimpiar.Cursor = Cursors.Hand;
            Btlimpiar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Btlimpiar.Location = new Point(640, 220);
            Btlimpiar.Name = "Btlimpiar";
            Btlimpiar.Size = new Size(115, 41);
            Btlimpiar.TabIndex = 7;
            Btlimpiar.Text = "Limpiar";
            Btlimpiar.UseVisualStyleBackColor = false;
            Btlimpiar.Click += Btlimpiar_Click;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1055, 567);
            Controls.Add(Btlimpiar);
            Controls.Add(label2);
            Controls.Add(LblResultado);
            Controls.Add(label1);
            Controls.Add(TxIngreso);
            Controls.Add(BtAceptar);
            Controls.Add(BtNuevo);
            Controls.Add(BtSalir);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "estructuras";
            Load += FrmInicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtSalir;
        private Button BtNuevo;
        private Button BtAceptar;
        private TextBox TxIngreso;
        private Label label1;
        private Label LblResultado;
        private Label label2;
        private Button Btlimpiar;
    }
}