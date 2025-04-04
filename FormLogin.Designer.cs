namespace SistemaPizzaria
{
    partial class Form1
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
            label2 = new Label();
            txtCliente = new TextBox();
            txtSenha = new TextBox();
            btnAcessar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 195);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 163);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(266, 160);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(100, 23);
            txtCliente.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(266, 195);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 3;
            // 
            // btnAcessar
            // 
            btnAcessar.Location = new Point(266, 253);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(75, 23);
            btnAcessar.TabIndex = 4;
            btnAcessar.Text = "Acessar ";
            btnAcessar.UseVisualStyleBackColor = true;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAcessar);
            Controls.Add(txtSenha);
            Controls.Add(txtCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCliente;
        private TextBox txtSenha;
        private Button btnAcessar;
    }
}
