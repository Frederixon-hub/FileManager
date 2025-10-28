namespace AppLauncher
{
    partial class FormForApps
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
        private System.Windows.Forms.ComboBox comboBoxApps;
        private System.Windows.Forms.Button buttonLaunch;
        private System.Windows.Forms.Label labelSelect;
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForApps));
            this.buttonLauncher = new System.Windows.Forms.Button();
            this.comboBoxApp = new System.Windows.Forms.ComboBox();
            this.labelSelection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLauncher
            // 
            this.buttonLauncher.Location = new System.Drawing.Point(30, 110);
            this.buttonLauncher.Name = "buttonLauncher";
            this.buttonLauncher.Size = new System.Drawing.Size(300, 40);
            this.buttonLauncher.TabIndex = 0;
            this.buttonLauncher.Text = "Запустить";
            this.buttonLauncher.UseVisualStyleBackColor = true;
            this.buttonLauncher.Click += new System.EventHandler(this.buttonLauncher_Click_1);
            // 
            // comboBoxApp
            // 
            this.comboBoxApp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxApp.FormattingEnabled = true;
            this.comboBoxApp.Location = new System.Drawing.Point(30, 60);
            this.comboBoxApp.Name = "comboBoxApp";
            this.comboBoxApp.Size = new System.Drawing.Size(300, 21);
            this.comboBoxApp.TabIndex = 1;
            // 
            // labelSelection
            // 
            this.labelSelection.AutoSize = true;
            this.labelSelection.Location = new System.Drawing.Point(30, 30);
            this.labelSelection.Name = "labelSelection";
            this.labelSelection.Size = new System.Drawing.Size(122, 13);
            this.labelSelection.TabIndex = 2;
            this.labelSelection.Text = "Выберите приложение";
            // 
            // FormForApps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 180);
            this.Controls.Add(this.labelSelection);
            this.Controls.Add(this.comboBoxApp);
            this.Controls.Add(this.buttonLauncher);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormForApps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Запуск приложений";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLauncher;
        private System.Windows.Forms.ComboBox comboBoxApp;
        private System.Windows.Forms.Label labelSelection;
    }
}

