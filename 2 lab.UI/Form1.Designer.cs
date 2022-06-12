
namespace _2_лаба__полиморфизм_
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
            this.Output = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.Enabled = false;
            this.Output.Location = new System.Drawing.Point(179, 62);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(102, 42);
            this.Output.TabIndex = 0;
            this.Output.Text = "Вывести данные";
            this.Output.UseVisualStyleBackColor = true;
            this.Output.Click += new System.EventHandler(this.Level_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(28, 62);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(84, 42);
            this.Input.TabIndex = 2;
            this.Input.Text = "Ввести данные";
            this.Input.UseVisualStyleBackColor = true;
            this.Input.Click += new System.EventHandler(this.Input_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 140);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Output;
        private System.Windows.Forms.Button Input;
    }
}

