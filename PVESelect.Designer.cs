namespace GO
{
    partial class PVESelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PVESelect));
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.OldLace;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "初级", "中级", "高级" });
            comboBox1.Location = new Point(361, 235);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(177, 39);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.OldLace;
            label1.Font = new Font("隶书", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(290, 106);
            label1.Name = "label1";
            label1.Size = new Size(320, 90);
            label1.TabIndex = 1;
            label1.Text = "对战难度";
            // 
            // button1
            // 
            button1.BackColor = Color.OldLace;
            button1.Font = new Font("隶书", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button1.Location = new Point(335, 318);
            button1.Name = "button1";
            button1.Size = new Size(220, 74);
            button1.TabIndex = 2;
            button1.Text = "确定";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PVESelect
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            BackgroundImage = Properties.Resources.五子棋背景3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(909, 586);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PVESelect";
            Text = "人机对战";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
    }
    
}