namespace GO
{
    partial class PVE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PVE));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(31, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(width, width);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Wheat;
            button1.Font = new Font("隶书", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button1.Location = new Point(699, 36);
            button1.Name = "button1";
            button1.Size = new Size(289, 83);
            button1.TabIndex = 1;
            button1.Text = "开始游戏";
            button1.UseVisualStyleBackColor = false;
            button1.Click += StartGame;
            // 
            // button2
            // 
            button2.BackColor = Color.Wheat;
            button2.Font = new Font("隶书", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button2.Location = new Point(699, 142);
            button2.Name = "button2";
            button2.Size = new Size(289, 86);
            button2.TabIndex = 2;
            button2.Text = "重新开始";
            button2.UseVisualStyleBackColor = false;
            button2.Click += StartGame;
            // 
            // button3
            // 
            button3.BackColor = Color.Wheat;
            button3.Font = new Font("隶书", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button3.Location = new Point(699, 250);
            button3.Name = "button3";
            button3.Size = new Size(289, 93);
            button3.TabIndex = 3;
            button3.Text = "切换难度";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(699, 442);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new Size(289, 236);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.BackColor = Color.FloralWhite;
            label1.Font = new Font("隶书", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(699, 374);
            label1.Name = "label1";
            label1.Size = new Size(289, 43);
            label1.TabIndex = 5;
            label1.Text = "游戏未开始\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PVE
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            BackgroundImage = Properties.Resources.五子棋背景4;
            ClientSize = new Size(1000, 700);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PVE";
            Text = "人机对战";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private RichTextBox richTextBox1;
        private Label label1;
    }
}