namespace EjemploFor
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
            Btaceptar = new Button();
            Txnum2 = new TextBox();
            Txnum1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxRes = new Label();
            BtSalir = new Button();
            BtBorrar = new Button();
            label3 = new Label();
            Txnum3 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // Btaceptar
            // 
            Btaceptar.BackColor = Color.Red;
            Btaceptar.Cursor = Cursors.Hand;
            Btaceptar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btaceptar.ForeColor = SystemColors.ControlLightLight;
            Btaceptar.Location = new Point(820, 191);
            Btaceptar.Name = "Btaceptar";
            Btaceptar.Size = new Size(154, 50);
            Btaceptar.TabIndex = 0;
            Btaceptar.Text = "Aceptar";
            Btaceptar.UseVisualStyleBackColor = false;
            // 
            // Txnum2
            // 
            Txnum2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Txnum2.ForeColor = Color.Red;
            Txnum2.Location = new Point(478, 199);
            Txnum2.Name = "Txnum2";
            Txnum2.Size = new Size(125, 34);
            Txnum2.TabIndex = 1;
            Txnum2.TextAlign = HorizontalAlignment.Center;
            // 
            // Txnum1
            // 
            Txnum1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Txnum1.ForeColor = Color.Red;
            Txnum1.Location = new Point(305, 199);
            Txnum1.Name = "Txnum1";
            Txnum1.Size = new Size(125, 34);
            Txnum1.TabIndex = 2;
            Txnum1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(305, 131);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 3;
            label1.Text = "Numero 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(478, 131);
            label2.Name = "label2";
            label2.Size = new Size(107, 28);
            label2.TabIndex = 4;
            label2.Text = "Numero 2";
            // 
            // TxRes
            // 
            TxRes.AutoSize = true;
            TxRes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TxRes.ForeColor = Color.White;
            TxRes.Location = new Point(305, 299);
            TxRes.Name = "TxRes";
            TxRes.Size = new Size(106, 28);
            TxRes.TabIndex = 5;
            TxRes.Text = "Resultado";
            // 
            // BtSalir
            // 
            BtSalir.BackColor = Color.Red;
            BtSalir.Cursor = Cursors.Hand;
            BtSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtSalir.ForeColor = SystemColors.ControlLightLight;
            BtSalir.Location = new Point(949, 467);
            BtSalir.Name = "BtSalir";
            BtSalir.Size = new Size(154, 50);
            BtSalir.TabIndex = 6;
            BtSalir.Text = "Salir";
            BtSalir.UseVisualStyleBackColor = false;
            BtSalir.Click += BtSalir_Click;
            // 
            // BtBorrar
            // 
            BtBorrar.BackColor = Color.Red;
            BtBorrar.Cursor = Cursors.Hand;
            BtBorrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtBorrar.ForeColor = SystemColors.ControlLightLight;
            BtBorrar.Location = new Point(820, 247);
            BtBorrar.Name = "BtBorrar";
            BtBorrar.Size = new Size(154, 50);
            BtBorrar.TabIndex = 7;
            BtBorrar.Text = "Borrar";
            BtBorrar.UseVisualStyleBackColor = false;
            BtBorrar.Click += BtBorrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(44, 25);
            label3.Name = "label3";
            label3.Size = new Size(1022, 57);
            label3.TabIndex = 8;
            label3.Text = "Nuevo programa - EJEMPLO ESTRUCTURA DE FOR";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Txnum3
            // 
            Txnum3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Txnum3.ForeColor = Color.Red;
            Txnum3.Location = new Point(650, 199);
            Txnum3.Name = "Txnum3";
            Txnum3.Size = new Size(125, 34);
            Txnum3.TabIndex = 9;
            Txnum3.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(650, 131);
            label4.Name = "label4";
            label4.Size = new Size(107, 28);
            label4.TabIndex = 10;
            label4.Text = "Numero 3";
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(1115, 529);
            Controls.Add(label4);
            Controls.Add(Txnum3);
            Controls.Add(label3);
            Controls.Add(BtBorrar);
            Controls.Add(BtSalir);
            Controls.Add(TxRes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Txnum1);
            Controls.Add(Txnum2);
            Controls.Add(Btaceptar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejemplo For";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btaceptar;
        private TextBox Txnum2;
        private TextBox Txnum1;
        private Label label1;
        private Label label2;
        private Label TxRes;
        private Button BtSalir;
        private Button BtBorrar;
        private Label label3;
        private TextBox Txnum3;
        private Label label4;
    }
}