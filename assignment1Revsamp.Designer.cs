namespace FirstApp
{
    partial class assignment1Revsamp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(assignment1Revsamp));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            txtId = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtYear = new ComboBox();
            txtCourse = new ComboBox();
            txtPartTime = new ComboBox();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(120, 446);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Update Data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(442, 94);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Add More";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(768, 94);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 9;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1036, 94);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 10;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(130, 59);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(616, 58);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(125, 27);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(1005, 62);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 4;
            // 
            // txtYear
            // 
            txtYear.FormattingEnabled = true;
            txtYear.Location = new Point(141, 128);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(151, 28);
            txtYear.TabIndex = 2;
            txtYear.Text = "Select Year";
            // 
            // txtCourse
            // 
            txtCourse.FormattingEnabled = true;
            txtCourse.Location = new Point(616, 128);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(151, 28);
            txtCourse.TabIndex = 5;
            txtCourse.Text = "Select Course";
            // 
            // txtPartTime
            // 
            txtPartTime.FormattingEnabled = true;
            txtPartTime.Location = new Point(1005, 128);
            txtPartTime.Name = "txtPartTime";
            txtPartTime.Size = new Size(151, 28);
            txtPartTime.TabIndex = 6;
            txtPartTime.Text = "Select Type";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(49, 180);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1143, 204);
            listBox1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 70);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 11;
            label1.Text = "StudentId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(504, 65);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 12;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(913, 62);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 13;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 136);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 14;
            label4.Text = "Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(504, 131);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 15;
            label5.Text = "Course";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(862, 131);
            label6.Name = "label6";
            label6.Size = new Size(137, 20);
            label6.TabIndex = 16;
            label6.Text = "Full Time/Part Time";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtYear);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtCourse);
            panel1.Controls.Add(txtPartTime);
            panel1.Controls.Add(txtFirstName);
            panel1.Location = new Point(-11, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1261, 196);
            panel1.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(-11, 352);
            panel2.Name = "panel2";
            panel2.Size = new Size(1275, 217);
            panel2.TabIndex = 18;
            panel2.Paint += panel2_Paint;
            // 
            // assignment1Revsamp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1245, 573);
            Controls.Add(listBox1);
            Controls.Add(txtId);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "assignment1Revsamp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "assignment1Revsamp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox txtId;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private ComboBox txtYear;
        private ComboBox txtCourse;
        private ComboBox txtPartTime;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Panel panel2;
    }
}