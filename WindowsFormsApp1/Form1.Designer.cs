namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add = new System.Windows.Forms.Button();
            this.Substract = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Pow = new System.Windows.Forms.Button();
            this.Log10 = new System.Windows.Forms.Button();
            this.Xgradey = new System.Windows.Forms.Button();
            this.Logxy = new System.Windows.Forms.Button();
            this.Xgrademinusy = new System.Windows.Forms.Button();
            this.Xgrademinusone = new System.Windows.Forms.Button();
            this.Log2x = new System.Windows.Forms.Button();
            this.Twogradex = new System.Windows.Forms.Button();
            this.Tengradex = new System.Windows.Forms.Button();
            this.Arcsin = new System.Windows.Forms.Button();
            this.Arccos = new System.Windows.Forms.Button();
            this.Arctg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(33, 163);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 0;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Click);
            // 
            // Substract
            // 
            this.Substract.Location = new System.Drawing.Point(167, 163);
            this.Substract.Name = "Substract";
            this.Substract.Size = new System.Drawing.Size(75, 23);
            this.Substract.TabIndex = 1;
            this.Substract.Text = "-";
            this.Substract.UseVisualStyleBackColor = true;
            this.Substract.Click += new System.EventHandler(this.Click);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(33, 207);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(75, 23);
            this.Multiply.TabIndex = 2;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Click);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(167, 207);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(75, 23);
            this.Divide.TabIndex = 3;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(33, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(33, 115);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(167, 85);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(75, 20);
            this.textBox5.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ответ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Число x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Число y";
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(33, 249);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(75, 23);
            this.Sin.TabIndex = 10;
            this.Sin.Text = "sin(x)";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.Click2);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(167, 249);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(75, 23);
            this.Cos.TabIndex = 11;
            this.Cos.Text = "cos(x)";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.Click2);
            // 
            // Pow
            // 
            this.Pow.Location = new System.Drawing.Point(33, 297);
            this.Pow.Name = "Pow";
            this.Pow.Size = new System.Drawing.Size(75, 23);
            this.Pow.TabIndex = 12;
            this.Pow.Text = "x^2";
            this.Pow.UseVisualStyleBackColor = true;
            this.Pow.Click += new System.EventHandler(this.Click2);
            // 
            // Log10
            // 
            this.Log10.Location = new System.Drawing.Point(167, 297);
            this.Log10.Name = "Log10";
            this.Log10.Size = new System.Drawing.Size(75, 23);
            this.Log10.TabIndex = 13;
            this.Log10.Text = "Log10(x)";
            this.Log10.UseVisualStyleBackColor = true;
            this.Log10.Click += new System.EventHandler(this.Click2);
            // 
            // Xgradey
            // 
            this.Xgradey.Location = new System.Drawing.Point(281, 163);
            this.Xgradey.Name = "Xgradey";
            this.Xgradey.Size = new System.Drawing.Size(75, 23);
            this.Xgradey.TabIndex = 14;
            this.Xgradey.Text = "x^y";
            this.Xgradey.UseVisualStyleBackColor = true;
            this.Xgradey.Click += new System.EventHandler(this.Click);
            // 
            // Logxy
            // 
            this.Logxy.Location = new System.Drawing.Point(281, 249);
            this.Logxy.Name = "Logxy";
            this.Logxy.Size = new System.Drawing.Size(75, 23);
            this.Logxy.TabIndex = 15;
            this.Logxy.Text = "logx(y)";
            this.Logxy.UseVisualStyleBackColor = true;
            this.Logxy.Click += new System.EventHandler(this.Click);
            // 
            // Xgrademinusy
            // 
            this.Xgrademinusy.Location = new System.Drawing.Point(281, 206);
            this.Xgrademinusy.Name = "Xgrademinusy";
            this.Xgrademinusy.Size = new System.Drawing.Size(75, 23);
            this.Xgrademinusy.TabIndex = 16;
            this.Xgrademinusy.Text = "x^(1/y)";
            this.Xgrademinusy.UseVisualStyleBackColor = true;
            this.Xgrademinusy.Click += new System.EventHandler(this.Click);
            // 
            // Xgrademinusone
            // 
            this.Xgrademinusone.Location = new System.Drawing.Point(281, 296);
            this.Xgrademinusone.Name = "Xgrademinusone";
            this.Xgrademinusone.Size = new System.Drawing.Size(75, 23);
            this.Xgrademinusone.TabIndex = 17;
            this.Xgrademinusone.Text = "1/x";
            this.Xgrademinusone.UseVisualStyleBackColor = true;
            this.Xgrademinusone.Click += new System.EventHandler(this.Click2);
            // 
            // Log2x
            // 
            this.Log2x.Location = new System.Drawing.Point(281, 336);
            this.Log2x.Name = "Log2x";
            this.Log2x.Size = new System.Drawing.Size(75, 23);
            this.Log2x.TabIndex = 18;
            this.Log2x.Text = "Log2(x)";
            this.Log2x.UseVisualStyleBackColor = true;
            this.Log2x.Click += new System.EventHandler(this.Click2);
            // 
            // Twogradex
            // 
            this.Twogradex.Location = new System.Drawing.Point(388, 163);
            this.Twogradex.Name = "Twogradex";
            this.Twogradex.Size = new System.Drawing.Size(75, 23);
            this.Twogradex.TabIndex = 19;
            this.Twogradex.Text = "2^x";
            this.Twogradex.UseVisualStyleBackColor = true;
            this.Twogradex.Click += new System.EventHandler(this.Click2);
            // 
            // Tengradex
            // 
            this.Tengradex.Location = new System.Drawing.Point(388, 207);
            this.Tengradex.Name = "Tengradex";
            this.Tengradex.Size = new System.Drawing.Size(75, 23);
            this.Tengradex.TabIndex = 20;
            this.Tengradex.Text = "10^x";
            this.Tengradex.UseVisualStyleBackColor = true;
            this.Tengradex.Click += new System.EventHandler(this.Click2);
            // 
            // Arcsin
            // 
            this.Arcsin.Location = new System.Drawing.Point(388, 249);
            this.Arcsin.Name = "Arcsin";
            this.Arcsin.Size = new System.Drawing.Size(75, 23);
            this.Arcsin.TabIndex = 21;
            this.Arcsin.Text = "arcsin(x)";
            this.Arcsin.UseVisualStyleBackColor = true;
            this.Arcsin.Click += new System.EventHandler(this.Click2);
            // 
            // Arccos
            // 
            this.Arccos.Location = new System.Drawing.Point(388, 297);
            this.Arccos.Name = "Arccos";
            this.Arccos.Size = new System.Drawing.Size(75, 23);
            this.Arccos.TabIndex = 22;
            this.Arccos.Text = "arcos(x)";
            this.Arccos.UseVisualStyleBackColor = true;
            this.Arccos.Click += new System.EventHandler(this.Click2);
            // 
            // Arctg
            // 
            this.Arctg.Location = new System.Drawing.Point(388, 336);
            this.Arctg.Name = "Arctg";
            this.Arctg.Size = new System.Drawing.Size(75, 23);
            this.Arctg.TabIndex = 23;
            this.Arctg.Text = "arctg(x)";
            this.Arctg.UseVisualStyleBackColor = true;
            this.Arctg.Click += new System.EventHandler(this.Click2);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(526, 413);
            this.Controls.Add(this.Arctg);
            this.Controls.Add(this.Arccos);
            this.Controls.Add(this.Arcsin);
            this.Controls.Add(this.Tengradex);
            this.Controls.Add(this.Twogradex);
            this.Controls.Add(this.Log2x);
            this.Controls.Add(this.Xgrademinusone);
            this.Controls.Add(this.Xgrademinusy);
            this.Controls.Add(this.Logxy);
            this.Controls.Add(this.Xgradey);
            this.Controls.Add(this.Log10);
            this.Controls.Add(this.Pow);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Substract);
            this.Controls.Add(this.Add);
            this.Name = "Form1";
            this.Text = "Kалькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Substract;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Pow;
        private System.Windows.Forms.Button Log10;
        private System.Windows.Forms.Button Xgradey;
        private System.Windows.Forms.Button Logxy;
        private System.Windows.Forms.Button Xgrademinusy;
        private System.Windows.Forms.Button Xgrademinusone;
        private System.Windows.Forms.Button Log2x;
        private System.Windows.Forms.Button Twogradex;
        private System.Windows.Forms.Button Tengradex;
        private System.Windows.Forms.Button Arcsin;
        private System.Windows.Forms.Button Arccos;
        private System.Windows.Forms.Button Arctg;
    }
}

