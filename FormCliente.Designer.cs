namespace SistemaPizzaria
{
    partial class FormCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            tabelaCliente = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNomeCliente = new TextBox();
            txtEnderecoCliente = new TextBox();
            txtTelefoneCliente = new TextBox();
            btnCadastrarCliente = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)tabelaCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabelaCliente
            // 
            tabelaCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaCliente.Location = new Point(107, 38);
            tabelaCliente.Name = "tabelaCliente";
            tabelaCliente.Size = new Size(460, 150);
            tabelaCliente.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 223);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 253);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 2;
            label2.Text = "Endereço:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 285);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 3;
            label3.Text = "Telefone:";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(107, 220);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(471, 23);
            txtNomeCliente.TabIndex = 4;
            // 
            // txtEnderecoCliente
            // 
            txtEnderecoCliente.Location = new Point(107, 253);
            txtEnderecoCliente.Name = "txtEnderecoCliente";
            txtEnderecoCliente.Size = new Size(471, 23);
            txtEnderecoCliente.TabIndex = 5;
            // 
            // txtTelefoneCliente
            // 
            txtTelefoneCliente.Location = new Point(107, 282);
            txtTelefoneCliente.Name = "txtTelefoneCliente";
            txtTelefoneCliente.Size = new Size(471, 23);
            txtTelefoneCliente.TabIndex = 6;
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.Location = new Point(107, 335);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(172, 23);
            btnCadastrarCliente.TabIndex = 7;
            btnCadastrarCliente.Text = "Cadastrar Cliente";
            btnCadastrarCliente.UseVisualStyleBackColor = true;
            btnCadastrarCliente.Click += btnCadastrarCliente_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrarCliente);
            Controls.Add(txtTelefoneCliente);
            Controls.Add(txtEnderecoCliente);
            Controls.Add(txtNomeCliente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tabelaCliente);
            Controls.Add(pictureBox1);
            Name = "FormCliente";
            Text = "FormCliente";
            Load += FormCliente_Load;
            ((System.ComponentModel.ISupportInitialize)tabelaCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tabelaCliente;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNomeCliente;
        private TextBox txtEnderecoCliente;
        private TextBox txtTelefoneCliente;
        private Button btnCadastrarCliente;
        private PictureBox pictureBox1;
    }
}