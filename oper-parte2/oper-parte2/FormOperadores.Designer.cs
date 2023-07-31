namespace oper_parte2
{
    partial class FormOperadores
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
            BtComenzar = new Button();
            TxIngreso = new TextBox();
            LblRes = new Label();
            BtSegundo = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtSalir
            // 
            BtSalir.Cursor = Cursors.Hand;
            BtSalir.Location = new Point(673, 270);
            BtSalir.Name = "BtSalir";
            BtSalir.Size = new Size(94, 29);
            BtSalir.TabIndex = 0;
            BtSalir.Text = "Salir";
            BtSalir.UseVisualStyleBackColor = true;
            BtSalir.Click += BtSalir_Click;
            // 
            // BtComenzar
            // 
            BtComenzar.Location = new Point(142, 42);
            BtComenzar.Name = "BtComenzar";
            BtComenzar.Size = new Size(94, 29);
            BtComenzar.TabIndex = 1;
            BtComenzar.Text = "Calcular";
            BtComenzar.UseVisualStyleBackColor = true;
            // 
            // TxIngreso
            // 
            TxIngreso.Location = new Point(335, 44);
            TxIngreso.Name = "TxIngreso";
            TxIngreso.Size = new Size(125, 27);
            TxIngreso.TabIndex = 2;
            // 
            // LblRes
            // 
            LblRes.AutoSize = true;
            LblRes.Location = new Point(605, 51);
            LblRes.Name = "LblRes";
            LblRes.Size = new Size(50, 20);
            LblRes.TabIndex = 3;
            LblRes.Text = "label1";
            // 
            // BtSegundo
            // 
            BtSegundo.Location = new Point(43, 270);
            BtSegundo.Name = "BtSegundo";
            BtSegundo.Size = new Size(203, 29);
            BtSegundo.TabIndex = 4;
            BtSegundo.Text = "ejecutar formulario";
            BtSegundo.UseVisualStyleBackColor = true;
            BtSegundo.Click += FrmSegundo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 224);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 5;
            label1.Text = "Ejecución de prueba";
            // 
            // FormOperadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GreenYellow;
            ClientSize = new Size(800, 318);
            Controls.Add(label1);
            Controls.Add(BtSegundo);
            Controls.Add(LblRes);
            Controls.Add(TxIngreso);
            Controls.Add(BtComenzar);
            Controls.Add(BtSalir);
            Name = "FormOperadores";
            Text = "FormOperadores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtSalir;
        private Button BtComenzar;
        private TextBox TxIngreso;
        private Label LblRes;
        private Button BtSegundo;
        private Label label1;
    }
}