namespace Conta
{
    partial class Conta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conta));
            this.UserName = new System.Windows.Forms.Label();
            this.Saldo = new System.Windows.Forms.Label();
            this.Saque = new System.Windows.Forms.Button();
            this.Deposito = new System.Windows.Forms.Button();
            this.Entrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserId = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(58, 9);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(35, 13);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "Nome";
            // 
            // Saldo
            // 
            this.Saldo.AutoSize = true;
            this.Saldo.BackColor = System.Drawing.Color.White;
            this.Saldo.Location = new System.Drawing.Point(77, 219);
            this.Saldo.Name = "Saldo";
            this.Saldo.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Saldo.Size = new System.Drawing.Size(54, 19);
            this.Saldo.TabIndex = 1;
            this.Saldo.Text = "Saldo";
            // 
            // Saque
            // 
            this.Saque.BackColor = System.Drawing.Color.Black;
            this.Saque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Saque.ForeColor = System.Drawing.Color.White;
            this.Saque.Location = new System.Drawing.Point(44, 113);
            this.Saque.Name = "Saque";
            this.Saque.Size = new System.Drawing.Size(120, 32);
            this.Saque.TabIndex = 2;
            this.Saque.Text = "Sacar";
            this.Saque.UseVisualStyleBackColor = false;
            this.Saque.Click += new System.EventHandler(this.button1_Click);
            // 
            // Deposito
            // 
            this.Deposito.BackColor = System.Drawing.Color.Black;
            this.Deposito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deposito.ForeColor = System.Drawing.Color.White;
            this.Deposito.Location = new System.Drawing.Point(44, 151);
            this.Deposito.Name = "Deposito";
            this.Deposito.Size = new System.Drawing.Size(120, 32);
            this.Deposito.TabIndex = 3;
            this.Deposito.Text = "Depositar";
            this.Deposito.UseVisualStyleBackColor = false;
            this.Deposito.Click += new System.EventHandler(this.Deposito_Click);
            // 
            // Entrada
            // 
            this.Entrada.Location = new System.Drawing.Point(44, 81);
            this.Entrada.Name = "Entrada";
            this.Entrada.Size = new System.Drawing.Size(120, 20);
            this.Entrada.TabIndex = 4;
            this.Entrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(77, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Saldo";
            // 
            // UserId
            // 
            this.UserId.AutoSize = true;
            this.UserId.Location = new System.Drawing.Point(58, 24);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(44, 13);
            this.UserId.TabIndex = 6;
            this.UserId.Text = "Número";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Conta.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Insira o valor desejado";
            // 
            // Conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 268);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UserId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Entrada);
            this.Controls.Add(this.Deposito);
            this.Controls.Add(this.Saque);
            this.Controls.Add(this.Saldo);
            this.Controls.Add(this.UserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Conta";
            this.Text = "Conta";
            this.Load += new System.EventHandler(this.Conta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Saldo;
        private System.Windows.Forms.Button Saque;
        private System.Windows.Forms.Button Deposito;
        private System.Windows.Forms.TextBox Entrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}