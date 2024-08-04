namespace FirstApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            hScrollBar1 = new HScrollBar();
            Click = new Button();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            menuStrip1 = new MenuStrip();
            homePageToolStripMenuItem = new ToolStripMenuItem();
            smurfCatToolStripMenuItem = new ToolStripMenuItem();
            dateTimeToolStripMenuItem = new ToolStripMenuItem();
            assignmentToolStripMenuItem = new ToolStripMenuItem();
            assignementRevampToolStripMenuItem = new ToolStripMenuItem();
            userControl21 = new UserControl2();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(-5, 415);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(100, 26);
            hScrollBar1.TabIndex = 0;
            // 
            // Click
            // 
            Click.BackColor = Color.GreenYellow;
            Click.Location = new Point(254, 106);
            Click.Name = "Click";
            Click.Size = new Size(94, 29);
            Click.TabIndex = 1;
            Click.Text = "Click Me";
            Click.UseVisualStyleBackColor = false;
            Click.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(17, 44);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(635, 34);
            textBox1.TabIndex = 4;
            textBox1.Text = "Hello";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.IndianRed;
            checkBox1.Location = new Point(12, 156);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(97, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Ice Cream";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.IndianRed;
            checkBox2.Location = new Point(12, 202);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(65, 24);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Soda";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 243);
            label1.Name = "label1";
            label1.Size = new Size(49, 40);
            label1.TabIndex = 7;
            label1.Text = "Result\r\n\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(498, 243);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 10;
            label3.Text = "Selected State";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(608, 243);
            label4.Name = "label4";
            label4.Size = new Size(16, 20);
            label4.TabIndex = 11;
            label4.Text = "?";
            label4.Click += label4_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homePageToolStripMenuItem, smurfCatToolStripMenuItem, dateTimeToolStripMenuItem, assignmentToolStripMenuItem, assignementRevampToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(746, 28);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // homePageToolStripMenuItem
            // 
            homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            homePageToolStripMenuItem.Size = new Size(103, 24);
            homePageToolStripMenuItem.Text = "Home Page";
            homePageToolStripMenuItem.Click += homePageToolStripMenuItem_Click;
            // 
            // smurfCatToolStripMenuItem
            // 
            smurfCatToolStripMenuItem.Name = "smurfCatToolStripMenuItem";
            smurfCatToolStripMenuItem.Size = new Size(93, 24);
            smurfCatToolStripMenuItem.Text = "Smurf Cat";
            smurfCatToolStripMenuItem.Click += smurfCatToolStripMenuItem_Click;
            // 
            // dateTimeToolStripMenuItem
            // 
            dateTimeToolStripMenuItem.Name = "dateTimeToolStripMenuItem";
            dateTimeToolStripMenuItem.Size = new Size(91, 24);
            dateTimeToolStripMenuItem.Text = "DateTime";
            dateTimeToolStripMenuItem.Click += dateTimeToolStripMenuItem_Click;
            // 
            // assignmentToolStripMenuItem
            // 
            assignmentToolStripMenuItem.Name = "assignmentToolStripMenuItem";
            assignmentToolStripMenuItem.Size = new Size(107, 24);
            assignmentToolStripMenuItem.Text = "Assignment";
            assignmentToolStripMenuItem.Click += assignmentToolStripMenuItem_Click;
            // 
            // assignementRevampToolStripMenuItem
            // 
            assignementRevampToolStripMenuItem.Name = "assignementRevampToolStripMenuItem";
            assignementRevampToolStripMenuItem.Size = new Size(176, 24);
            assignementRevampToolStripMenuItem.Text = "Assignement Revamp";
            assignementRevampToolStripMenuItem.Click += assignementRevampToolStripMenuItem_Click;
            // 
            // userControl21
            // 
            userControl21.Location = new Point(354, 122);
            userControl21.Name = "userControl21";
            userControl21.Size = new Size(380, 84);
            userControl21.TabIndex = 13;
            userControl21.Load += userControl21_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(746, 356);
            Controls.Add(userControl21);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(Click);
            Controls.Add(hScrollBar1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ashwin's App";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private HScrollBar hScrollBar1;
        private Button Click;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label1;
        private Label label3;
        private Label label4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homePageToolStripMenuItem;
        private ToolStripMenuItem smurfCatToolStripMenuItem;
        private ToolStripMenuItem dateTimeToolStripMenuItem;
        private ToolStripMenuItem assignmentToolStripMenuItem;
        private ToolStripMenuItem assignementRevampToolStripMenuItem;
        private UserControl2 userControl21;
    }
}
