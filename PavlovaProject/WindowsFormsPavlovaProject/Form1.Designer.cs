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
            this.SearchButton = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.WebResult = new System.Windows.Forms.WebBrowser();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchText
            // 
            this.SearchText.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchText.Location = new System.Drawing.Point(0, 0);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(784, 20);
            this.SearchText.TabIndex = 0;
            this.SearchText.Text = "Введите запрос (Анголязычный поиск)";
            this.SearchText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchText_KeyDown);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(3, 25);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.SearchText);
            this.MenuPanel.Controls.Add(this.SearchButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(784, 51);
            this.MenuPanel.TabIndex = 2;
            // 
            // WebResult
            // 
            this.WebResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebResult.Location = new System.Drawing.Point(0, 51);
            this.WebResult.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebResult.Name = "WebResult";
            this.WebResult.Size = new System.Drawing.Size(784, 511);
            this.WebResult.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.WebResult);
            this.Controls.Add(this.MenuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Незнайка";
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.WebBrowser WebResult;
    }
}

