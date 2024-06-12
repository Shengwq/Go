namespace GO
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            comboBox1 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "初级", "中级", "高级" });
            comboBox1.Location = new Point(661, 98);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(220, 39);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("微软雅黑", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(661, 59);
            label1.Name = "label1";
            label1.Size = new Size(127, 36);
            label1.TabIndex = 1;
            label1.Text = "对战难度";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            BackgroundImage = global::GO.Properties.Resources.五子棋背景3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(909, 586);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "人机对战";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
    }
    
}