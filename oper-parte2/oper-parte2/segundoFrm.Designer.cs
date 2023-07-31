namespace oper_parte2
{
    partial class segundoFrm
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
            btclose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 178);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "Ejecutame ésta!!";
            // 
            // btclose
            // 
            btclose.Location = new Point(578, 395);
            btclose.Name = "btclose";
            btclose.Size = new Size(193, 29);
            btclose.TabIndex = 1;
            btclose.Text = "Cerrar formulario";
            btclose.UseVisualStyleBackColor = true;
            btclose.Click += btclose_Click;
            // 
            // segundoFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btclose);
            Controls.Add(label1);
            Name = "segundoFrm";
            Text = "segundoFrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btclose;
    }
}