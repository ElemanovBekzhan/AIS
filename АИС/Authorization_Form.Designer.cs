namespace АИС
{
    partial class Authorization_Form
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
            this.Authoriz_button = new System.Windows.Forms.Button();
            this.Author_label = new System.Windows.Forms.Label();
            this.Login_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Authoriz_button
            // 
            this.Authoriz_button.Location = new System.Drawing.Point(116, 177);
            this.Authoriz_button.Name = "Authoriz_button";
            this.Authoriz_button.Size = new System.Drawing.Size(75, 23);
            this.Authoriz_button.TabIndex = 0;
            this.Authoriz_button.Text = "Войти";
            this.Authoriz_button.UseVisualStyleBackColor = true;
            this.Authoriz_button.Click += new System.EventHandler(this.Authoriz_button_Click);
            // 
            // Author_label
            // 
            this.Author_label.AutoSize = true;
            this.Author_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Author_label.Location = new System.Drawing.Point(96, 9);
            this.Author_label.Name = "Author_label";
            this.Author_label.Size = new System.Drawing.Size(152, 25);
            this.Author_label.TabIndex = 1;
            this.Author_label.Text = "Авторизация";
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_label.Location = new System.Drawing.Point(22, 64);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(55, 20);
            this.Login_label.TabIndex = 2;
            this.Login_label.Text = "Логин";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_label.Location = new System.Drawing.Point(10, 126);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(67, 20);
            this.Password_label.TabIndex = 3;
            this.Password_label.Text = "Пороль";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Authorization_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 219);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Login_label);
            this.Controls.Add(this.Author_label);
            this.Controls.Add(this.Authoriz_button);
            this.Name = "Authorization_Form";
            this.Text = "Authorization_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Authoriz_button;
        private System.Windows.Forms.Label Author_label;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}