namespace АИС
{
    partial class Menu
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
            this.InfoCompony_button = new System.Windows.Forms.Button();
            this.InfoShop_button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoCompony_button
            // 
            this.InfoCompony_button.Location = new System.Drawing.Point(24, 120);
            this.InfoCompony_button.Name = "InfoCompony_button";
            this.InfoCompony_button.Size = new System.Drawing.Size(174, 49);
            this.InfoCompony_button.TabIndex = 0;
            this.InfoCompony_button.Text = "О Компании ";
            this.InfoCompony_button.UseVisualStyleBackColor = true;
            this.InfoCompony_button.Click += new System.EventHandler(this.InfoCompony_button_Click);
            // 
            // InfoShop_button
            // 
            this.InfoShop_button.Location = new System.Drawing.Point(24, 198);
            this.InfoShop_button.Name = "InfoShop_button";
            this.InfoShop_button.Size = new System.Drawing.Size(174, 49);
            this.InfoShop_button.TabIndex = 1;
            this.InfoShop_button.Text = "Филиалы ";
            this.InfoShop_button.UseVisualStyleBackColor = true;
            this.InfoShop_button.Click += new System.EventHandler(this.InfoShop_button_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(232, 274);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 49);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(24, 274);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(174, 49);
            this.button.TabIndex = 4;
            this.button.Text = "Учет книг";
            this.button.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 49);
            this.button2.TabIndex = 5;
            this.button2.Text = "Учет поставок";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(232, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 49);
            this.button3.TabIndex = 6;
            this.button3.Text = "Контакты";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.InfoShop_button);
            this.Controls.Add(this.InfoCompony_button);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InfoCompony_button;
        private System.Windows.Forms.Button InfoShop_button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}