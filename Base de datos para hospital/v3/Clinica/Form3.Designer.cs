namespace Clinica
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
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            sala_txt = new TextBox();
            label3 = new Label();
            personal_txt = new TextBox();
            label2 = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(249, 247, 247);
            label1.Location = new Point(377, 9);
            label1.Name = "label1";
            label1.Size = new Size(420, 60);
            label1.TabIndex = 3;
            label1.Text = "Oficial Personal";
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
            button1.Location = new Point(12, 11);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(104, 60);
            button1.TabIndex = 8;
            button1.Text = "Cerrar Sesion";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 64, 119);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(sala_txt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(personal_txt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 555);
            panel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(249, 247, 247);
            label5.Location = new Point(642, 28);
            label5.Name = "label5";
            label5.Size = new Size(475, 46);
            label5.TabIndex = 29;
            label5.Text = "Asignar Personal a salas ";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(17, 45, 78);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(556, 555);
            dataGridView1.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(249, 247, 247);
            label4.Location = new Point(703, 249);
            label4.Name = "label4";
            label4.Size = new Size(126, 22);
            label4.TabIndex = 27;
            label4.Text = "Codigo sala ";
            // 
            // sala_txt
            // 
            sala_txt.BackColor = Color.FromArgb(249, 247, 247);
            sala_txt.Font = new Font("Rockwell", 20F, FontStyle.Regular, GraphicsUnit.Point);
            sala_txt.Location = new Point(703, 283);
            sala_txt.Margin = new Padding(3, 2, 3, 2);
            sala_txt.Name = "sala_txt";
            sala_txt.Size = new Size(337, 39);
            sala_txt.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(249, 247, 247);
            label3.Location = new Point(703, 134);
            label3.Name = "label3";
            label3.Size = new Size(162, 22);
            label3.TabIndex = 25;
            label3.Text = "Codigo Personal";
            // 
            // personal_txt
            // 
            personal_txt.BackColor = Color.FromArgb(249, 247, 247);
            personal_txt.Font = new Font("Rockwell", 20F, FontStyle.Regular, GraphicsUnit.Point);
            personal_txt.Location = new Point(703, 168);
            personal_txt.Margin = new Padding(3, 2, 3, 2);
            personal_txt.Name = "personal_txt";
            personal_txt.Size = new Size(337, 39);
            personal_txt.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(249, 247, 247);
            label2.Location = new Point(298, 114);
            label2.Name = "label2";
            label2.Size = new Size(0, 60);
            label2.TabIndex = 23;
            // 
            // button5
            // 
            button5.BackColor = Color.CornflowerBlue;
            button5.FlatAppearance.BorderColor = Color.FromArgb(249, 247, 247);
            button5.FlatAppearance.BorderSize = 2;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(18, 81, 157);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(249, 247, 247);
            button5.Location = new Point(792, 352);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(139, 60);
            button5.TabIndex = 22;
            button5.Text = "Agregar ";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(17, 45, 78);
            button4.FlatAppearance.BorderColor = Color.FromArgb(249, 247, 247);
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(18, 81, 157);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(249, 247, 247);
            button4.Location = new Point(795, 466);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(139, 60);
            button4.TabIndex = 21;
            button4.Text = "Detalle Salas";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
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
            button3.Location = new Point(977, 466);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(104, 60);
            button3.TabIndex = 20;
            button3.Text = "Salas";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            button2.Location = new Point(643, 466);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(104, 60);
            button2.TabIndex = 19;
            button2.Text = "Personal";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 45, 78);
            ClientSize = new Size(1180, 644);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Oficial Personal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Panel panel1;
        private Label label5;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox sala_txt;
        private Label label3;
        private TextBox personal_txt;
        private Label label2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}