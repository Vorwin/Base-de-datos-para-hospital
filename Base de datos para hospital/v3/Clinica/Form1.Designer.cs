namespace Clinica
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
            label1 = new Label();
            label2 = new Label();
            toolStripContainer1 = new ToolStripContainer();
            panel1 = new Panel();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            password_txt = new TextBox();
            username_txt = new TextBox();
            button2 = new Button();
            button3 = new Button();
            toolStripContainer1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(249, 247, 247);
            label1.Location = new Point(373, 7);
            label1.Name = "label1";
            label1.Size = new Size(298, 60);
            label1.TabIndex = 0;
            label1.Text = "Hospital W";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(249, 247, 247);
            label2.Location = new Point(367, 20);
            label2.Name = "label2";
            label2.Size = new Size(124, 46);
            label2.TabIndex = 1;
            label2.Text = "Login";
            // 
            // toolStripContainer1
            // 
            toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Margin = new Padding(3, 2, 3, 2);
            toolStripContainer1.ContentPanel.Size = new Size(9, 8);
            toolStripContainer1.LeftToolStripPanelVisible = false;
            toolStripContainer1.Location = new Point(1030, 518);
            toolStripContainer1.Margin = new Padding(3, 2, 3, 2);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.RightToolStripPanelVisible = false;
            toolStripContainer1.Size = new Size(9, 8);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 64, 119);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(password_txt);
            panel1.Controls.Add(username_txt);
            panel1.Controls.Add(label2);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(87, 82);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(874, 402);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(17, 45, 78);
            button1.FlatAppearance.BorderColor = Color.FromArgb(249, 247, 247);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(18, 81, 157);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(249, 247, 247);
            button1.Location = new Point(367, 308);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(156, 50);
            button1.TabIndex = 6;
            button1.Text = "  Login ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(249, 247, 247);
            label4.Location = new Point(272, 186);
            label4.Name = "label4";
            label4.Size = new Size(97, 22);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(249, 247, 247);
            label3.Location = new Point(272, 95);
            label3.Name = "label3";
            label3.Size = new Size(102, 22);
            label3.TabIndex = 4;
            label3.Text = "Username";
            // 
            // password_txt
            // 
            password_txt.BackColor = Color.FromArgb(249, 247, 247);
            password_txt.Font = new Font("Rockwell", 20F, FontStyle.Regular, GraphicsUnit.Point);
            password_txt.Location = new Point(272, 217);
            password_txt.Margin = new Padding(3, 2, 3, 2);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(337, 39);
            password_txt.TabIndex = 3;
            password_txt.UseSystemPasswordChar = true;
            // 
            // username_txt
            // 
            username_txt.BackColor = Color.FromArgb(249, 247, 247);
            username_txt.Font = new Font("Rockwell", 20F, FontStyle.Regular, GraphicsUnit.Point);
            username_txt.Location = new Point(272, 129);
            username_txt.Margin = new Padding(3, 2, 3, 2);
            username_txt.Name = "username_txt";
            username_txt.Size = new Size(337, 39);
            username_txt.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(17, 45, 78);
            button2.FlatAppearance.BorderColor = Color.FromArgb(249, 247, 247);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(18, 81, 157);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(249, 247, 247);
            button2.Location = new Point(12, 7);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(156, 50);
            button2.TabIndex = 7;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(17, 45, 78);
            button3.FlatAppearance.BorderColor = Color.FromArgb(249, 247, 247);
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(18, 81, 157);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(249, 247, 247);
            button3.Location = new Point(869, 11);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(156, 50);
            button3.TabIndex = 8;
            button3.Text = "Informacion";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 45, 78);
            ClientSize = new Size(1037, 524);
            ControlBox = false;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(toolStripContainer1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de sesion";
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ToolStripContainer toolStripContainer1;
        private Panel panel1;
        private Label label3;
        private TextBox password_txt;
        private TextBox username_txt;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}