namespace FrmPrueba
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
            label1 = new Label();
            label2 = new Label();
            TxtOper1 = new TextBox();
            TxtOper2 = new TextBox();
            label3 = new Label();
            BtRes = new Button();
            LblRes = new Label();
            BtCerrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 80);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "Operador 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 80);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Operador 2";
            // 
            // TxtOper1
            // 
            TxtOper1.Location = new Point(52, 138);
            TxtOper1.Name = "TxtOper1";
            TxtOper1.Size = new Size(125, 27);
            TxtOper1.TabIndex = 2;
            // 
            // TxtOper2
            // 
            TxtOper2.Location = new Point(301, 138);
            TxtOper2.Name = "TxtOper2";
            TxtOper2.Size = new Size(125, 27);
            TxtOper2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(226, 140);
            label3.Name = "label3";
            label3.Size = new Size(19, 20);
            label3.TabIndex = 4;
            label3.Text = "+";
            // 
            // BtRes
            // 
            BtRes.Location = new Point(475, 136);
            BtRes.Name = "BtRes";
            BtRes.Size = new Size(94, 29);
            BtRes.TabIndex = 5;
            BtRes.Text = "=";
            BtRes.UseVisualStyleBackColor = true;
            BtRes.Click += BtRes_Click;
            // 
            // LblRes
            // 
            LblRes.AutoSize = true;
            LblRes.Location = new Point(645, 140);
            LblRes.Name = "LblRes";
            LblRes.Size = new Size(85, 20);
            LblRes.TabIndex = 6;
            LblRes.Text = "Operador 2";
            LblRes.Visible = false;
            // 
            // BtCerrar
            // 
            BtCerrar.Cursor = Cursors.Hand;
            BtCerrar.Location = new Point(645, 409);
            BtCerrar.Name = "BtCerrar";
            BtCerrar.Size = new Size(94, 29);
            BtCerrar.TabIndex = 7;
            BtCerrar.Text = "Salir";
            BtCerrar.UseVisualStyleBackColor = true;
            BtCerrar.Click += BtCerrar_Click;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtCerrar);
            Controls.Add(LblRes);
            Controls.Add(BtRes);
            Controls.Add(label3);
            Controls.Add(TxtOper2);
            Controls.Add(TxtOper1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmInicio";
            Text = "FrmInicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtOper1;
        private TextBox TxtOper2;
        private Label label3;
        private Button BtRes;
        private Label LblRes;
        private Button BtCerrar;
    }
}