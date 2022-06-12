
namespace _2_лаба__полиморфизм_
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
            this.label4 = new System.Windows.Forms.Label();
            this.diamBox = new System.Windows.Forms.TextBox();
            this.MatherialBox = new System.Windows.Forms.TextBox();
            this.CostBox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.Level1r = new System.Windows.Forms.RadioButton();
            this.Level2r = new System.Windows.Forms.RadioButton();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Диаметр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Материал";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тип подвески";
            // 
            // diamBox
            // 
            this.diamBox.Enabled = false;
            this.diamBox.Location = new System.Drawing.Point(154, 75);
            this.diamBox.Name = "diamBox";
            this.diamBox.Size = new System.Drawing.Size(120, 22);
            this.diamBox.TabIndex = 4;
            // 
            // MatherialBox
            // 
            this.MatherialBox.Enabled = false;
            this.MatherialBox.Location = new System.Drawing.Point(154, 116);
            this.MatherialBox.Name = "MatherialBox";
            this.MatherialBox.Size = new System.Drawing.Size(120, 22);
            this.MatherialBox.TabIndex = 5;
            // 
            // CostBox
            // 
            this.CostBox.Enabled = false;
            this.CostBox.Location = new System.Drawing.Point(154, 160);
            this.CostBox.Name = "CostBox";
            this.CostBox.Size = new System.Drawing.Size(120, 22);
            this.CostBox.TabIndex = 6;
            // 
            // TypeBox
            // 
            this.TypeBox.Enabled = false;
            this.TypeBox.Location = new System.Drawing.Point(154, 208);
            this.TypeBox.Multiline = true;
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(120, 57);
            this.TypeBox.TabIndex = 7;
            // 
            // Level1r
            // 
            this.Level1r.AutoSize = true;
            this.Level1r.Location = new System.Drawing.Point(24, 34);
            this.Level1r.Name = "Level1r";
            this.Level1r.Size = new System.Drawing.Size(94, 21);
            this.Level1r.TabIndex = 8;
            this.Level1r.TabStop = true;
            this.Level1r.Text = "1 уровень";
            this.Level1r.UseVisualStyleBackColor = true;
            this.Level1r.Click += new System.EventHandler(this.Level1r_Click);
            // 
            // Level2r
            // 
            this.Level2r.AutoSize = true;
            this.Level2r.Location = new System.Drawing.Point(154, 34);
            this.Level2r.Name = "Level2r";
            this.Level2r.Size = new System.Drawing.Size(94, 21);
            this.Level2r.TabIndex = 9;
            this.Level2r.TabStop = true;
            this.Level2r.Text = "2 уровень";
            this.Level2r.UseVisualStyleBackColor = true;
            this.Level2r.Click += new System.EventHandler(this.Level2r_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(109, 292);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(93, 23);
            this.Save.TabIndex = 10;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 327);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Level2r);
            this.Controls.Add(this.Level1r);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.CostBox);
            this.Controls.Add(this.MatherialBox);
            this.Controls.Add(this.diamBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InputForm";
            this.Text = "InputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox diamBox;
        private System.Windows.Forms.TextBox MatherialBox;
        private System.Windows.Forms.TextBox CostBox;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.RadioButton Level1r;
        private System.Windows.Forms.RadioButton Level2r;
        private System.Windows.Forms.Button Save;
    }
}