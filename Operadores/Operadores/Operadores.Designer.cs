namespace Operadores
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            BtCalcular = new Button();
            Txoper1 = new TextBox();
            Txoper2 = new TextBox();
            label1 = new Label();
            LblResultado = new Label();
            BtSalir = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // BtCalcular
            // 
            BtCalcular.Cursor = Cursors.Hand;
            BtCalcular.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            BtCalcular.Location = new Point(815, 235);
            BtCalcular.Name = "BtCalcular";
            BtCalcular.Size = new Size(165, 49);
            BtCalcular.TabIndex = 0;
            BtCalcular.Text = "Calcular";
            BtCalcular.UseVisualStyleBackColor = true;
            BtCalcular.Click += BtCalcular_Click;
            // 
            // Txoper1
            // 
            Txoper1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Txoper1.Location = new Point(301, 238);
            Txoper1.Name = "Txoper1";
            Txoper1.Size = new Size(125, 43);
            Txoper1.TabIndex = 1;
            // 
            // Txoper2
            // 
            Txoper2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Txoper2.Location = new Point(605, 238);
            Txoper2.Name = "Txoper2";
            Txoper2.Size = new Size(125, 43);
            Txoper2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(495, 238);
            label1.Name = "label1";
            label1.Size = new Size(39, 41);
            label1.TabIndex = 3;
            label1.Text = "+";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblResultado
            // 
            LblResultado.AutoSize = true;
            LblResultado.Font = new Font("Segoe UI Variable Text", 23F, FontStyle.Bold, GraphicsUnit.Point);
            LblResultado.Location = new Point(482, 350);
            LblResultado.Name = "LblResultado";
            LblResultado.Size = new Size(203, 52);
            LblResultado.TabIndex = 4;
            LblResultado.Text = "Resultado";
            LblResultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtSalir
            // 
            BtSalir.BackColor = SystemColors.Highlight;
            BtSalir.Cursor = Cursors.Hand;
            BtSalir.FlatAppearance.BorderColor = Color.Black;
            BtSalir.FlatAppearance.BorderSize = 5;
            BtSalir.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtSalir.ForeColor = Color.Ivory;
            BtSalir.Location = new Point(1047, 459);
            BtSalir.Name = "BtSalir";
            BtSalir.Size = new Size(127, 71);
            BtSalir.TabIndex = 5;
            BtSalir.Text = "Salir";
            BtSalir.UseVisualStyleBackColor = false;
            BtSalir.Click += BtSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(312, 33);
            label2.Name = "label2";
            label2.Size = new Size(641, 67);
            label2.TabIndex = 6;
            label2.Text = "Formulario de operadores";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(1186, 542);
            Controls.Add(label2);
            Controls.Add(BtSalir);
            Controls.Add(LblResultado);
            Controls.Add(label1);
            Controls.Add(Txoper2);
            Controls.Add(Txoper1);
            Controls.Add(BtCalcular);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Operadores";
            Load += FrmInicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtCalcular;
        private TextBox Txoper1;
        private TextBox Txoper2;
        private Label label1;
        private Label LblResultado;
        private Button BtSalir;
        private Label label2;
    }
}