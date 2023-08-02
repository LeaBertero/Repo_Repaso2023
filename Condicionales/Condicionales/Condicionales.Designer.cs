namespace Condicionales
{
    partial class Condicionales
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
            BtCalcular = new Button();
            LblResultado = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            TxNum1 = new TextBox();
            TxOperador = new TextBox();
            TxNum2 = new TextBox();
            BtCerrar = new Button();
            BtLimpiar = new Button();
            SuspendLayout();
            // 
            // BtCalcular
            // 
            BtCalcular.Cursor = Cursors.Hand;
            BtCalcular.Location = new Point(336, 66);
            BtCalcular.Name = "BtCalcular";
            BtCalcular.Size = new Size(94, 29);
            BtCalcular.TabIndex = 4;
            BtCalcular.Text = "Calcular";
            BtCalcular.UseVisualStyleBackColor = true;
            BtCalcular.Click += BtCalcular_Click;
            // 
            // LblResultado
            // 
            LblResultado.AutoSize = true;
            LblResultado.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LblResultado.Location = new Point(154, 303);
            LblResultado.Name = "LblResultado";
            LblResultado.Size = new Size(158, 41);
            LblResultado.TabIndex = 6;
            LblResultado.Text = "Resultado";
            LblResultado.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 31);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 6;
            label3.Text = "Numero 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 122);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 7;
            label2.Text = "Operador";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(152, 213);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 8;
            label4.Text = "Numero 2";
            // 
            // TxNum1
            // 
            TxNum1.Location = new Point(152, 68);
            TxNum1.Name = "TxNum1";
            TxNum1.Size = new Size(125, 27);
            TxNum1.TabIndex = 1;
            // 
            // TxOperador
            // 
            TxOperador.Location = new Point(152, 159);
            TxOperador.Name = "TxOperador";
            TxOperador.Size = new Size(125, 27);
            TxOperador.TabIndex = 2;
            // 
            // TxNum2
            // 
            TxNum2.Location = new Point(152, 250);
            TxNum2.Name = "TxNum2";
            TxNum2.Size = new Size(125, 27);
            TxNum2.TabIndex = 3;
            // 
            // BtCerrar
            // 
            BtCerrar.BackColor = SystemColors.ActiveCaption;
            BtCerrar.Cursor = Cursors.Hand;
            BtCerrar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtCerrar.Location = new Point(655, 12);
            BtCerrar.Name = "BtCerrar";
            BtCerrar.Size = new Size(133, 51);
            BtCerrar.TabIndex = 5;
            BtCerrar.Text = "Cerrar";
            BtCerrar.UseVisualStyleBackColor = false;
            BtCerrar.Click += BtCerrar_Click;
            // 
            // BtLimpiar
            // 
            BtLimpiar.BackColor = Color.MediumTurquoise;
            BtLimpiar.Cursor = Cursors.Hand;
            BtLimpiar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtLimpiar.Location = new Point(336, 139);
            BtLimpiar.Name = "BtLimpiar";
            BtLimpiar.Size = new Size(94, 58);
            BtLimpiar.TabIndex = 9;
            BtLimpiar.Text = "CE";
            BtLimpiar.UseVisualStyleBackColor = false;
            BtLimpiar.Click += BtLimpiar_Click;
            // 
            // Condicionales
            // 
            AcceptButton = BtCalcular;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 367);
            ControlBox = false;
            Controls.Add(BtLimpiar);
            Controls.Add(BtCerrar);
            Controls.Add(TxNum2);
            Controls.Add(TxOperador);
            Controls.Add(TxNum1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(LblResultado);
            Controls.Add(BtCalcular);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Condicionales";
            Text = "Condicionales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtCalcular;
        private Label LblResultado;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox TxNum1;
        private TextBox TxOperador;
        private TextBox TxNum2;
        private Button BtCerrar;
        private Button BtLimpiar;
    }
}