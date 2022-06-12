
namespace WinForm
{
    partial class WinForm
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
            this.CheckV = new System.Windows.Forms.Button();
            this.Download = new System.Windows.Forms.Button();
            this.GetData = new System.Windows.Forms.Button();
            this.OnOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckV
            // 
            this.CheckV.Enabled = false;
            this.CheckV.Location = new System.Drawing.Point(24, 82);
            this.CheckV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckV.Name = "CheckV";
            this.CheckV.Size = new System.Drawing.Size(112, 58);
            this.CheckV.TabIndex = 3;
            this.CheckV.Text = "Проверить вирусы";
            this.CheckV.UseVisualStyleBackColor = true;
            this.CheckV.Click += new System.EventHandler(this.CheckV_Click);
            // 
            // Download
            // 
            this.Download.Enabled = false;
            this.Download.Location = new System.Drawing.Point(168, 82);
            this.Download.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(112, 58);
            this.Download.TabIndex = 4;
            this.Download.Text = "Скачать";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // GetData
            // 
            this.GetData.Enabled = false;
            this.GetData.Location = new System.Drawing.Point(311, 82);
            this.GetData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GetData.Name = "GetData";
            this.GetData.Size = new System.Drawing.Size(112, 58);
            this.GetData.TabIndex = 5;
            this.GetData.Text = "Показать данные";
            this.GetData.UseVisualStyleBackColor = true;
            this.GetData.Click += new System.EventHandler(this.GetData_Click);
            // 
            // OnOff
            // 
            this.OnOff.Location = new System.Drawing.Point(461, 82);
            this.OnOff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OnOff.Name = "OnOff";
            this.OnOff.Size = new System.Drawing.Size(112, 58);
            this.OnOff.TabIndex = 6;
            this.OnOff.Text = "Вкл/Выкл";
            this.OnOff.UseVisualStyleBackColor = true;
            this.OnOff.Click += new System.EventHandler(this.OnOff_Click);
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 219);
            this.Controls.Add(this.OnOff);
            this.Controls.Add(this.GetData);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.CheckV);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WinForm";
            this.Text = "Computer";
            this.Load += new System.EventHandler(this.WinForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CheckV;
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.Button GetData;
        private System.Windows.Forms.Button OnOff;
    }
}

