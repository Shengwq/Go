namespace GO
{
    partial class PVP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PVP));
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button3 = new Button();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("华文行楷", 16.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 134);
            button1.ForeColor = SystemColors.Desktop;
            button1.Location = new Point(700, 146);
            button1.Name = "button1";
            button1.Size = new Size(221, 58);
            button1.TabIndex = 0;
            button1.Text = "重新开始";
            button1.UseVisualStyleBackColor = true;
            button1.Click += StartGame;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Cross;
            button2.Font = new Font("华文行楷", 16.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 134);
            button2.Location = new Point(700, 235);
            button2.Name = "button2";
            button2.Size = new Size(221, 56);
            button2.TabIndex = 1;
            button2.Text = "返回菜单";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Khaki;
            pictureBox1.Location = new Point(20, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(width,width);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("幼圆", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 134);
            label1.Location = new Point(700, 327);
            label1.Name = "label1";
            label1.Size = new Size(221, 46);
            label1.TabIndex = 3;
            label1.Text = "游戏未开始";
            // 
            // button3
            // 
            button3.Font = new Font("华文行楷", 16.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 134);
            button3.Location = new Point(700, 54);
            button3.Name = "button3";
            button3.Size = new Size(221, 59);
            button3.TabIndex = 4;
            button3.Text = "开始游戏";
            button3.UseVisualStyleBackColor = true;
            button3.Click += StartGame;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(700, 418);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new Size(221, 226);
            richTextBox1.TabIndex = 5;
            //richTextBox1.Text = $"第 {round} 回合\n";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = global::GO.Properties.Resources.五子棋背景2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 700);
            Controls.Add(richTextBox1);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "双人对战";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button3;
        private RichTextBox richTextBox1;
    }
}