namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Apagar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.prev = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.TextBox();
            this.Voltar = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.Num7 = new System.Windows.Forms.Button();
            this.Num8 = new System.Windows.Forms.Button();
            this.Num9 = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Num4 = new System.Windows.Forms.Button();
            this.Num5 = new System.Windows.Forms.Button();
            this.Num6 = new System.Windows.Forms.Button();
            this.Soma = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.Button();
            this.Num2 = new System.Windows.Forms.Button();
            this.Num3 = new System.Windows.Forms.Button();
            this.Ponto = new System.Windows.Forms.Button();
            this.Num0 = new System.Windows.Forms.Button();
            this.Calc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Apagar
            // 
            this.Apagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Apagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apagar.ForeColor = System.Drawing.Color.White;
            this.Apagar.Location = new System.Drawing.Point(26, 118);
            this.Apagar.Name = "Apagar";
            this.Apagar.Size = new System.Drawing.Size(50, 50);
            this.Apagar.TabIndex = 2;
            this.Apagar.Text = "CE";
            this.Apagar.UseVisualStyleBackColor = false;
            this.Apagar.Click += new System.EventHandler(this.Apagar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.prev);
            this.panel1.Controls.Add(this.Input);
            this.panel1.Location = new System.Drawing.Point(26, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 63);
            this.panel1.TabIndex = 2;
            // 
            // prev
            // 
            this.prev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.prev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prev.Enabled = false;
            this.prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev.ForeColor = System.Drawing.Color.White;
            this.prev.Location = new System.Drawing.Point(3, 11);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(206, 19);
            this.prev.TabIndex = 20;
            this.prev.Text = "prev";
            this.prev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.ForeColor = System.Drawing.Color.White;
            this.Input.Location = new System.Drawing.Point(-2, 33);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(211, 25);
            this.Input.TabIndex = 19;
            this.Input.Text = "Input";
            this.Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Voltar
            // 
            this.Voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voltar.ForeColor = System.Drawing.Color.White;
            this.Voltar.Location = new System.Drawing.Point(82, 118);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(50, 50);
            this.Voltar.TabIndex = 3;
            this.Voltar.Text = "C";
            this.Voltar.UseVisualStyleBackColor = false;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // Div
            // 
            this.Div.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Div.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Div.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Div.ForeColor = System.Drawing.Color.White;
            this.Div.Location = new System.Drawing.Point(138, 118);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(50, 50);
            this.Div.TabIndex = 4;
            this.Div.Text = "÷";
            this.Div.UseVisualStyleBackColor = false;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // Mult
            // 
            this.Mult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Mult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mult.ForeColor = System.Drawing.Color.White;
            this.Mult.Location = new System.Drawing.Point(193, 118);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(50, 50);
            this.Mult.TabIndex = 5;
            this.Mult.Text = "X";
            this.Mult.UseVisualStyleBackColor = false;
            this.Mult.Click += new System.EventHandler(this.Mult_Click);
            // 
            // Num7
            // 
            this.Num7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Num7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num7.ForeColor = System.Drawing.Color.White;
            this.Num7.Location = new System.Drawing.Point(26, 174);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(50, 50);
            this.Num7.TabIndex = 6;
            this.Num7.Text = "7";
            this.Num7.UseVisualStyleBackColor = false;
            this.Num7.Click += new System.EventHandler(this.Num7_Click);
            // 
            // Num8
            // 
            this.Num8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Num8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num8.ForeColor = System.Drawing.Color.White;
            this.Num8.Location = new System.Drawing.Point(82, 174);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(50, 50);
            this.Num8.TabIndex = 7;
            this.Num8.Text = "8";
            this.Num8.UseVisualStyleBackColor = false;
            this.Num8.Click += new System.EventHandler(this.Num8_Click);
            // 
            // Num9
            // 
            this.Num9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Num9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num9.ForeColor = System.Drawing.Color.White;
            this.Num9.Location = new System.Drawing.Point(138, 174);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(50, 50);
            this.Num9.TabIndex = 8;
            this.Num9.Text = "9";
            this.Num9.UseVisualStyleBackColor = false;
            this.Num9.Click += new System.EventHandler(this.Num9_Click);
            // 
            // Sub
            // 
            this.Sub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Sub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sub.ForeColor = System.Drawing.Color.White;
            this.Sub.Location = new System.Drawing.Point(193, 174);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(50, 50);
            this.Sub.TabIndex = 9;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = false;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Num4
            // 
            this.Num4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Num4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num4.ForeColor = System.Drawing.Color.White;
            this.Num4.Location = new System.Drawing.Point(26, 230);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(50, 50);
            this.Num4.TabIndex = 10;
            this.Num4.Text = "4";
            this.Num4.UseVisualStyleBackColor = false;
            this.Num4.Click += new System.EventHandler(this.Num4_Click);
            // 
            // Num5
            // 
            this.Num5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Num5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num5.ForeColor = System.Drawing.Color.White;
            this.Num5.Location = new System.Drawing.Point(82, 230);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(50, 50);
            this.Num5.TabIndex = 11;
            this.Num5.Text = "5";
            this.Num5.UseVisualStyleBackColor = false;
            this.Num5.Click += new System.EventHandler(this.Num5_Click);
            // 
            // Num6
            // 
            this.Num6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Num6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num6.ForeColor = System.Drawing.Color.White;
            this.Num6.Location = new System.Drawing.Point(138, 230);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(50, 50);
            this.Num6.TabIndex = 12;
            this.Num6.Text = "6";
            this.Num6.UseVisualStyleBackColor = false;
            this.Num6.Click += new System.EventHandler(this.Num6_Click);
            // 
            // Soma
            // 
            this.Soma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Soma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soma.ForeColor = System.Drawing.Color.White;
            this.Soma.Location = new System.Drawing.Point(194, 230);
            this.Soma.Name = "Soma";
            this.Soma.Size = new System.Drawing.Size(50, 50);
            this.Soma.TabIndex = 13;
            this.Soma.Text = "+";
            this.Soma.UseVisualStyleBackColor = false;
            this.Soma.Click += new System.EventHandler(this.Soma_Click);
            // 
            // Num1
            // 
            this.Num1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Num1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num1.ForeColor = System.Drawing.Color.White;
            this.Num1.Location = new System.Drawing.Point(26, 286);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(50, 50);
            this.Num1.TabIndex = 14;
            this.Num1.Text = "1";
            this.Num1.UseVisualStyleBackColor = false;
            this.Num1.Click += new System.EventHandler(this.Num1_Click);
            // 
            // Num2
            // 
            this.Num2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Num2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num2.ForeColor = System.Drawing.Color.White;
            this.Num2.Location = new System.Drawing.Point(82, 286);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(50, 50);
            this.Num2.TabIndex = 15;
            this.Num2.Text = "2";
            this.Num2.UseVisualStyleBackColor = false;
            this.Num2.Click += new System.EventHandler(this.Num2_Click);
            // 
            // Num3
            // 
            this.Num3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Num3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num3.ForeColor = System.Drawing.Color.White;
            this.Num3.Location = new System.Drawing.Point(138, 286);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(50, 50);
            this.Num3.TabIndex = 16;
            this.Num3.Text = "3";
            this.Num3.UseVisualStyleBackColor = false;
            this.Num3.Click += new System.EventHandler(this.Num3_Click);
            // 
            // Ponto
            // 
            this.Ponto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Ponto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Ponto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ponto.ForeColor = System.Drawing.Color.White;
            this.Ponto.Location = new System.Drawing.Point(138, 342);
            this.Ponto.Name = "Ponto";
            this.Ponto.Size = new System.Drawing.Size(50, 50);
            this.Ponto.TabIndex = 18;
            this.Ponto.Text = ",";
            this.Ponto.UseVisualStyleBackColor = false;
            this.Ponto.Click += new System.EventHandler(this.Ponto_Click);
            // 
            // Num0
            // 
            this.Num0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Num0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num0.ForeColor = System.Drawing.Color.White;
            this.Num0.Location = new System.Drawing.Point(26, 342);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(106, 50);
            this.Num0.TabIndex = 17;
            this.Num0.Text = "0";
            this.Num0.UseVisualStyleBackColor = false;
            this.Num0.Click += new System.EventHandler(this.Num0_Click);
            // 
            // Calc
            // 
            this.Calc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Calc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calc.ForeColor = System.Drawing.Color.White;
            this.Calc.Location = new System.Drawing.Point(193, 286);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(50, 106);
            this.Calc.TabIndex = 1;
            this.Calc.Text = "=";
            this.Calc.UseVisualStyleBackColor = false;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(269, 417);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.Num0);
            this.Controls.Add(this.Ponto);
            this.Controls.Add(this.Num3);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.Soma);
            this.Controls.Add(this.Num6);
            this.Controls.Add(this.Num5);
            this.Controls.Add(this.Num4);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Num9);
            this.Controls.Add(this.Num8);
            this.Controls.Add(this.Num7);
            this.Controls.Add(this.Mult);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Apagar);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Apagar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button Num7;
        private System.Windows.Forms.Button Num8;
        private System.Windows.Forms.Button Num9;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Num4;
        private System.Windows.Forms.Button Num5;
        private System.Windows.Forms.Button Num6;
        private System.Windows.Forms.Button Soma;
        private System.Windows.Forms.Button Num1;
        private System.Windows.Forms.Button Num2;
        private System.Windows.Forms.Button Num3;
        private System.Windows.Forms.Button Ponto;
        private System.Windows.Forms.Button Num0;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox prev;
    }
}

