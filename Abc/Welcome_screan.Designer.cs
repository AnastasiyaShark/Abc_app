
namespace Abc
{
    partial class Welcome_screan
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
            this.learn_words_button = new System.Windows.Forms.Button();
            this.check_botton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // learn_words_button
            // 
            this.learn_words_button.BackColor = System.Drawing.Color.YellowGreen;
            this.learn_words_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.learn_words_button.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learn_words_button.ForeColor = System.Drawing.SystemColors.Desktop;
            this.learn_words_button.Location = new System.Drawing.Point(231, 405);
            this.learn_words_button.Name = "learn_words_button";
            this.learn_words_button.Size = new System.Drawing.Size(209, 92);
            this.learn_words_button.TabIndex = 0;
            this.learn_words_button.Text = "Учить слова";
            this.learn_words_button.UseVisualStyleBackColor = false;
            this.learn_words_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // check_botton
            // 
            this.check_botton.BackColor = System.Drawing.Color.SandyBrown;
            this.check_botton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_botton.FlatAppearance.BorderSize = 2;
            this.check_botton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.check_botton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.check_botton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_botton.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_botton.Location = new System.Drawing.Point(496, 405);
            this.check_botton.Name = "check_botton";
            this.check_botton.Size = new System.Drawing.Size(209, 93);
            this.check_botton.TabIndex = 1;
            this.check_botton.Text = "Проверка знаний";
            this.check_botton.UseVisualStyleBackColor = false;
            this.check_botton.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Abc.Properties.Resources.cancel;
            this.pictureBox2.Location = new System.Drawing.Point(833, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Abc.Properties.Resources._103824775_book_old_vintage_textbook_encyclopedia_dictionary_or_fairy_tale_book_happy_cartoon_design_for_kids_c_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(278, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 334);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Welcome_screan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.check_botton);
            this.Controls.Add(this.learn_words_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Welcome_screan";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Welcome_screan_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Welcome_screan_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button learn_words_button;
        private System.Windows.Forms.Button check_botton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

