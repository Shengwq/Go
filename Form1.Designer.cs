namespace GO
{
    partial class GO
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GO));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("华文行楷", 35.9999962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 134);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(345, 52);
            label1.Name = "label1";
            label1.Size = new Size(336, 103);
            label1.TabIndex = 0;
            label1.Text = "五子棋";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("华文行楷", 16.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 134);
            button1.ForeColor = SystemColors.Desktop;
            button1.Location = new Point(87, 211);
            button1.Name = "button1";
            button1.Size = new Size(367, 86);
            button1.TabIndex = 1;
            button1.Text = "双人对战";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Font = new Font("华文行楷", 16.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 134);
            button2.ForeColor = SystemColors.Desktop;
            button2.Location = new Point(81, 351);
            button2.Name = "button2";
            button2.Size = new Size(374, 82);
            button2.TabIndex = 2;
            button2.Text = "人机对战";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("华文行楷", 16.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 134);
            button3.ForeColor = SystemColors.Desktop;
            button3.Location = new Point(84, 495);
            button3.Name = "button3";
            button3.Size = new Size(369, 75);
            button3.TabIndex = 3;
            button3.Text = "退出游戏";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // GO
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = global::GO.Properties.Resources.五子棋背景;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1085, 682);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            ForeColor = Color.Cyan;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GO";
            Text = "GO";
            Load += GO_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
