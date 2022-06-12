
namespace _3_лаб
{
    partial class InputForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FioBox = new System.Windows.Forms.TextBox();
            this.ExpBox = new System.Windows.Forms.TextBox();
            this.OpBox = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Опыт работы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество проведенных операций";
            // 
            // FioBox
            // 
            this.FioBox.Location = new System.Drawing.Point(34, 29);
            this.FioBox.Name = "FioBox";
            this.FioBox.Size = new System.Drawing.Size(283, 22);
            this.FioBox.TabIndex = 3;
            // 
            // ExpBox
            // 
            this.ExpBox.Location = new System.Drawing.Point(120, 85);
            this.ExpBox.Name = "ExpBox";
            this.ExpBox.Size = new System.Drawing.Size(103, 22);
            this.ExpBox.TabIndex = 4;
            // 
            // OpBox
            // 
            this.OpBox.Location = new System.Drawing.Point(123, 144);
            this.OpBox.Name = "OpBox";
            this.OpBox.Size = new System.Drawing.Size(100, 22);
            this.OpBox.TabIndex = 5;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(120, 188);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(104, 23);
            this.Save.TabIndex = 6;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(340, 223);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.OpBox);
            this.Controls.Add(this.ExpBox);
            this.Controls.Add(this.FioBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FioBox;
        private System.Windows.Forms.TextBox ExpBox;
        private System.Windows.Forms.TextBox OpBox;
        private System.Windows.Forms.Button Save;
    }
}