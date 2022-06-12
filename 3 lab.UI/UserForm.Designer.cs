
namespace _3_лаб
{
    partial class UserForm
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
            this.List = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Heal = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // List
            // 
            this.List.FormattingEnabled = true;
            this.List.ItemHeight = 16;
            this.List.Location = new System.Drawing.Point(12, 64);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(341, 196);
            this.List.TabIndex = 0;
            this.List.SelectedIndexChanged += new System.EventHandler(this.List_SelectedIndexChanged);
            this.List.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.List_MouseDoubleClick);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(12, 22);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(86, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(104, 22);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Heal
            // 
            this.Heal.Location = new System.Drawing.Point(197, 22);
            this.Heal.Name = "Heal";
            this.Heal.Size = new System.Drawing.Size(75, 23);
            this.Heal.TabIndex = 4;
            this.Heal.Text = "Лечить";
            this.Heal.UseVisualStyleBackColor = true;
            this.Heal.Click += new System.EventHandler(this.Heal_Click);
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(278, 22);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(75, 23);
            this.Data.TabIndex = 5;
            this.Data.Text = "Данные";
            this.Data.UseVisualStyleBackColor = true;
            this.Data.Click += new System.EventHandler(this.Data_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 272);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Heal);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.List);
            this.Name = "UserForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Heal;
        private System.Windows.Forms.Button Data;
    }
}

