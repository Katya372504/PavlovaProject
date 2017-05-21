namespace WindowsFormsPavlovaProject
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SearchText = new System.Windows.Forms.TextBox();
            this.SearchProcessButton = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.Title7 = new System.Windows.Forms.PictureBox();
            this.Title6 = new System.Windows.Forms.PictureBox();
            this.Title5 = new System.Windows.Forms.PictureBox();
            this.Title4 = new System.Windows.Forms.PictureBox();
            this.Title3 = new System.Windows.Forms.PictureBox();
            this.Title2 = new System.Windows.Forms.PictureBox();
            this.Title1 = new System.Windows.Forms.PictureBox();
            this.PictureLeft = new System.Windows.Forms.PictureBox();
            this.PictureRight = new System.Windows.Forms.PictureBox();
            this.Title8 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RussianSearchButton = new System.Windows.Forms.Button();
            this.EnglishSearchButton = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Title7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title8)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchText
            // 
            this.SearchText.BackColor = System.Drawing.SystemColors.MenuBar;
            this.SearchText.Location = new System.Drawing.Point(82, 3);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(678, 20);
            this.SearchText.TabIndex = 0;
            this.SearchText.Text = "Введите запрос (Анголязычный поиск)";
            this.SearchText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchText_KeyDown);
            // 
            // SearchProcessButton
            // 
            this.SearchProcessButton.Location = new System.Drawing.Point(384, 25);
            this.SearchProcessButton.Name = "SearchProcessButton";
            this.SearchProcessButton.Size = new System.Drawing.Size(75, 23);
            this.SearchProcessButton.TabIndex = 1;
            this.SearchProcessButton.Text = "Найти";
            this.SearchProcessButton.UseVisualStyleBackColor = true;
            this.SearchProcessButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.EnglishSearchButton);
            this.MenuPanel.Controls.Add(this.RussianSearchButton);
            this.MenuPanel.Controls.Add(this.SearchText);
            this.MenuPanel.Controls.Add(this.SearchProcessButton);
            this.MenuPanel.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MenuPanel.Location = new System.Drawing.Point(213, 123);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(825, 51);
            this.MenuPanel.TabIndex = 2;
            // 
            // Title7
            // 
            this.Title7.Image = global::WindowsFormsPavlovaProject.Properties.Resources.yp_CfDYIdPY;
            this.Title7.Location = new System.Drawing.Point(795, 7);
            this.Title7.Name = "Title7";
            this.Title7.Size = new System.Drawing.Size(71, 79);
            this.Title7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Title7.TabIndex = 12;
            this.Title7.TabStop = false;
            // 
            // Title6
            // 
            this.Title6.Image = global::WindowsFormsPavlovaProject.Properties.Resources.X56NJQmYDaI;
            this.Title6.Location = new System.Drawing.Point(718, 7);
            this.Title6.Name = "Title6";
            this.Title6.Size = new System.Drawing.Size(71, 79);
            this.Title6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Title6.TabIndex = 11;
            this.Title6.TabStop = false;
            // 
            // Title5
            // 
            this.Title5.Image = global::WindowsFormsPavlovaProject.Properties.Resources.yM_y5pHO898;
            this.Title5.Location = new System.Drawing.Point(641, 7);
            this.Title5.Name = "Title5";
            this.Title5.Size = new System.Drawing.Size(71, 79);
            this.Title5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Title5.TabIndex = 10;
            this.Title5.TabStop = false;
            // 
            // Title4
            // 
            this.Title4.Image = global::WindowsFormsPavlovaProject.Properties.Resources._8nsHkrRnWcY;
            this.Title4.Location = new System.Drawing.Point(564, 7);
            this.Title4.Name = "Title4";
            this.Title4.Size = new System.Drawing.Size(71, 79);
            this.Title4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Title4.TabIndex = 9;
            this.Title4.TabStop = false;
            // 
            // Title3
            // 
            this.Title3.Image = global::WindowsFormsPavlovaProject.Properties.Resources._7mrkmB6Ncjg;
            this.Title3.Location = new System.Drawing.Point(487, 7);
            this.Title3.Name = "Title3";
            this.Title3.Size = new System.Drawing.Size(71, 79);
            this.Title3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Title3.TabIndex = 8;
            this.Title3.TabStop = false;
            // 
            // Title2
            // 
            this.Title2.Image = global::WindowsFormsPavlovaProject.Properties.Resources.r9g1w9GZhEI;
            this.Title2.Location = new System.Drawing.Point(410, 7);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(71, 79);
            this.Title2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Title2.TabIndex = 7;
            this.Title2.TabStop = false;
            // 
            // Title1
            // 
            this.Title1.Image = global::WindowsFormsPavlovaProject.Properties.Resources._8nsHkrRnWcY;
            this.Title1.Location = new System.Drawing.Point(333, 7);
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(71, 79);
            this.Title1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Title1.TabIndex = 6;
            this.Title1.TabStop = false;
            // 
            // PictureLeft
            // 
            this.PictureLeft.Image = global::WindowsFormsPavlovaProject.Properties.Resources.M6FAc6ArZBA;
            this.PictureLeft.Location = new System.Drawing.Point(45, 191);
            this.PictureLeft.Name = "PictureLeft";
            this.PictureLeft.Size = new System.Drawing.Size(256, 407);
            this.PictureLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLeft.TabIndex = 5;
            this.PictureLeft.TabStop = false;
            // 
            // PictureRight
            // 
            this.PictureRight.Image = global::WindowsFormsPavlovaProject.Properties.Resources.CvwQ_BnDD3s;
            this.PictureRight.Location = new System.Drawing.Point(965, 191);
            this.PictureRight.Name = "PictureRight";
            this.PictureRight.Size = new System.Drawing.Size(255, 407);
            this.PictureRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureRight.TabIndex = 4;
            this.PictureRight.TabStop = false;
            // 
            // Title8
            // 
            this.Title8.Image = global::WindowsFormsPavlovaProject.Properties.Resources.yM_y5pHO898;
            this.Title8.Location = new System.Drawing.Point(872, 7);
            this.Title8.Name = "Title8";
            this.Title8.Size = new System.Drawing.Size(71, 79);
            this.Title8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Title8.TabIndex = 13;
            this.Title8.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(307, 191);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(652, 407);
            this.textBox1.TabIndex = 14;
            // 
            // RussianSearchButton
            // 
            this.RussianSearchButton.Location = new System.Drawing.Point(3, 25);
            this.RussianSearchButton.Name = "RussianSearchButton";
            this.RussianSearchButton.Size = new System.Drawing.Size(135, 23);
            this.RussianSearchButton.TabIndex = 2;
            this.RussianSearchButton.Text = "Русский поиск";
            this.RussianSearchButton.UseVisualStyleBackColor = true;
            this.RussianSearchButton.Click += new System.EventHandler(this.RussianSearchButton_Click);
            // 
            // EnglishSearchButton
            // 
            this.EnglishSearchButton.Location = new System.Drawing.Point(682, 25);
            this.EnglishSearchButton.Name = "EnglishSearchButton";
            this.EnglishSearchButton.Size = new System.Drawing.Size(140, 23);
            this.EnglishSearchButton.TabIndex = 3;
            this.EnglishSearchButton.Text = "Английский поиск";
            this.EnglishSearchButton.UseVisualStyleBackColor = true;
            this.EnglishSearchButton.Click += new System.EventHandler(this.EnglishSearchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Title8);
            this.Controls.Add(this.Title7);
            this.Controls.Add(this.Title6);
            this.Controls.Add(this.Title5);
            this.Controls.Add(this.Title4);
            this.Controls.Add(this.Title3);
            this.Controls.Add(this.Title2);
            this.Controls.Add(this.Title1);
            this.Controls.Add(this.PictureLeft);
            this.Controls.Add(this.PictureRight);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Незнайка";
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Title7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Button SearchProcessButton;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.PictureBox PictureRight;
        private System.Windows.Forms.PictureBox PictureLeft;
        private System.Windows.Forms.PictureBox Title1;
        private System.Windows.Forms.PictureBox Title2;
        private System.Windows.Forms.PictureBox Title3;
        private System.Windows.Forms.PictureBox Title4;
        private System.Windows.Forms.PictureBox Title5;
        private System.Windows.Forms.PictureBox Title6;
        private System.Windows.Forms.PictureBox Title7;
        private System.Windows.Forms.PictureBox Title8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button EnglishSearchButton;
        private System.Windows.Forms.Button RussianSearchButton;
    }
}

