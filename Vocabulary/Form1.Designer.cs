namespace Vocabulary
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ToplamSoru = new System.Windows.Forms.Label();
            this.Doğru = new System.Windows.Forms.Label();
            this.Yanlış = new System.Windows.Forms.Label();
            this.Toplam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Soru = new System.Windows.Forms.Button();
            this.ctarih = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(62, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(178, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.Location = new System.Drawing.Point(62, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button4.Location = new System.Drawing.Point(178, 155);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 47);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // ToplamSoru
            // 
            this.ToplamSoru.AutoSize = true;
            this.ToplamSoru.Location = new System.Drawing.Point(15, 279);
            this.ToplamSoru.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ToplamSoru.Name = "ToplamSoru";
            this.ToplamSoru.Size = new System.Drawing.Size(13, 13);
            this.ToplamSoru.TabIndex = 5;
            this.ToplamSoru.Text = "0";
            // 
            // Doğru
            // 
            this.Doğru.AutoSize = true;
            this.Doğru.Location = new System.Drawing.Point(53, 279);
            this.Doğru.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Doğru.Name = "Doğru";
            this.Doğru.Size = new System.Drawing.Size(13, 13);
            this.Doğru.TabIndex = 6;
            this.Doğru.Text = "0";
            // 
            // Yanlış
            // 
            this.Yanlış.AutoSize = true;
            this.Yanlış.Location = new System.Drawing.Point(88, 278);
            this.Yanlış.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Yanlış.Name = "Yanlış";
            this.Yanlış.Size = new System.Drawing.Size(13, 13);
            this.Yanlış.TabIndex = 7;
            this.Yanlış.Text = "0";
            // 
            // Toplam
            // 
            this.Toplam.AutoSize = true;
            this.Toplam.Location = new System.Drawing.Point(-1, 258);
            this.Toplam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Toplam.Name = "Toplam";
            this.Toplam.Size = new System.Drawing.Size(42, 13);
            this.Toplam.TabIndex = 8;
            this.Toplam.Text = "Toplam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 258);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Doğru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 258);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Yanlış";
            // 
            // Soru
            // 
            this.Soru.BackColor = System.Drawing.Color.Transparent;
            this.Soru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Soru.FlatAppearance.BorderSize = 0;
            this.Soru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Soru.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Soru.Location = new System.Drawing.Point(62, 50);
            this.Soru.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Soru.Name = "Soru";
            this.Soru.Size = new System.Drawing.Size(228, 47);
            this.Soru.TabIndex = 11;
            this.Soru.Text = "Soru";
            this.Soru.UseVisualStyleBackColor = false;
            // 
            // ctarih
            // 
            this.ctarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ctarih.FormattingEnabled = true;
            this.ctarih.Items.AddRange(new object[] {
            "All"});
            this.ctarih.Location = new System.Drawing.Point(248, 11);
            this.ctarih.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ctarih.Name = "ctarih";
            this.ctarih.Size = new System.Drawing.Size(104, 25);
            this.ctarih.TabIndex = 12;
            this.ctarih.SelectedIndexChanged += new System.EventHandler(this.ctarih_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(363, 301);
            this.Controls.Add(this.ctarih);
            this.Controls.Add(this.Soru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Toplam);
            this.Controls.Add(this.Yanlış);
            this.Controls.Add(this.Doğru);
            this.Controls.Add(this.ToplamSoru);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Vocabulary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label ToplamSoru;
        private System.Windows.Forms.Label Doğru;
        private System.Windows.Forms.Label Yanlış;
        private System.Windows.Forms.Label Toplam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Soru;
        private System.Windows.Forms.ComboBox ctarih;
    }
}

