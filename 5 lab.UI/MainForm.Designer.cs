
namespace _5_lab.UI
{
    partial class MainForm
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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StartBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.addDetailBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.addLoaderBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.addMillerBtn = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PictureBox.Location = new System.Drawing.Point(12, 41);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(1381, 736);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // MessageBox
            // 
            this.MessageBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MessageBox.Location = new System.Drawing.Point(782, 41);
            this.MessageBox.Multiline = true;
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.ReadOnly = true;
            this.MessageBox.Size = new System.Drawing.Size(611, 46);
            this.MessageBox.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartBtn,
            this.addDetailBtn,
            this.addLoaderBtn,
            this.addMillerBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1405, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StartBtn
            // 
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(72, 24);
            this.StartBtn.Text = "Начать";
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // addDetailBtn
            // 
            this.addDetailBtn.Name = "addDetailBtn";
            this.addDetailBtn.Size = new System.Drawing.Size(140, 24);
            this.addDetailBtn.Text = "Добавить деталь";
            this.addDetailBtn.Click += new System.EventHandler(this.addDetailBtn_Click);
            // 
            // addLoaderBtn
            // 
            this.addLoaderBtn.Name = "addLoaderBtn";
            this.addLoaderBtn.Size = new System.Drawing.Size(165, 24);
            this.addLoaderBtn.Text = "Добавить погрузчик";
            this.addLoaderBtn.Click += new System.EventHandler(this.addLoaderBtn_Click);
            // 
            // addMillerBtn
            // 
            this.addMillerBtn.Name = "addMillerBtn";
            this.addMillerBtn.Size = new System.Drawing.Size(198, 24);
            this.addMillerBtn.Text = "Добавить фрезеровщика";
            this.addMillerBtn.Click += new System.EventHandler(this.addMillerBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 789);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TextBox MessageBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StartBtn;
        private System.Windows.Forms.ToolStripMenuItem addDetailBtn;
        private System.Windows.Forms.ToolStripMenuItem addLoaderBtn;
        private System.Windows.Forms.ToolStripMenuItem addMillerBtn;
    }
}