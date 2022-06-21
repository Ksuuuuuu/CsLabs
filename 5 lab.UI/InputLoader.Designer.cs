
namespace _5_lab.UI
{
    partial class InputLoader
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
            this.ListBox = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.Items.AddRange(new object[] {
            "Kind One",
            "Kind Two"});
            this.ListBox.Location = new System.Drawing.Point(12, 24);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(276, 28);
            this.ListBox.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(107, 78);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(94, 29);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // InputLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 119);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.ListBox);
            this.Name = "InputLoader";
            this.Text = "InputLoader";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ListBox;
        private System.Windows.Forms.Button addBtn;
    }
}