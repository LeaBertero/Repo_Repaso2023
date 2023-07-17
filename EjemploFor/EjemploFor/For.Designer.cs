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
            TxtHasta = new TextBox();
            TxtDesde = new TextBox();
            label1 = new Label();
            label2 = new Label();
            LblRes = new Label();
            BtSalir = new Button();
            BtBorrar = new Button();
            label3 = new Label();
            TxtPaso = new TextBox();
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
            Btaceptar.Click += Btaceptar_Click;
            // 
            // TxtHasta
            // 
            TxtHasta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TxtHasta.ForeColor = Color.Red;
            TxtHasta.Location = new Point(478, 199);
            TxtHasta.Name = "TxtHasta";
            TxtHasta.Size = new Size(125, 34);
            TxtHasta.TabIndex = 1;
            TxtHasta.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtDesde
            // 
            TxtDesde.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TxtDesde.ForeColor = Color.Red;
            TxtDesde.Location = new Point(305, 199);
            TxtDesde.Name = "TxtDesde";
            TxtDesde.Size = new Size(125, 34);
            TxtDesde.TabIndex = 2;
            TxtDesde.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(305, 131);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 3;
            label1.Text = "Desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(478, 131);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 4;
            label2.Text = "Hasta";
            // 
            // LblRes
            // 
            LblRes.AutoSize = true;
            LblRes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblRes.ForeColor = Color.White;
            LblRes.Location = new Point(305, 299);
            LblRes.Name = "LblRes";
            LblRes.Size = new Size(106, 28);
            LblRes.TabIndex = 5;
            LblRes.Text = "Resultado";
            // 
            // BtSalir
            // 
            BtSalir.BackColor = Color.Red;
            BtSalir.Cursor = Cursors.Hand;
            BtSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtSalir.ForeColor = SystemColors.ControlLightLight;
            BtSalir.Location = new Point(305, 384);
            BtSalir.Name = "BtSalir";
            BtSalir.Size = new Size(669, 50);
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
            // TxtPaso
            // 
            TxtPaso.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TxtPaso.ForeColor = Color.Red;
            TxtPaso.Location = new Point(650, 199);
            TxtPaso.Name = "TxtPaso";
            TxtPaso.Size = new Size(125, 34);
            TxtPaso.TabIndex = 9;
            TxtPaso.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(650, 131);
            label4.Name = "label4";
            label4.Size = new Size(56, 28);
            label4.TabIndex = 10;
            label4.Text = "Paso";
            // 
            // FrmInicio
            // 
            AcceptButton = Btaceptar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(1115, 529);
            Controls.Add(label4);
            Controls.Add(TxtPaso);
            Controls.Add(label3);
            Controls.Add(BtBorrar);
            Controls.Add(BtSalir);
            Controls.Add(LblRes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtDesde);
            Controls.Add(TxtHasta);
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
        private TextBox TxtHasta;
        private TextBox TxtDesde;
        private Label label1;
        private Label label2;
        private Label LblRes;
        private Button BtSalir;
        private Button BtBorrar;
        private Label label3;
        private TextBox TxtPaso;
        private Label label4;
    }
}