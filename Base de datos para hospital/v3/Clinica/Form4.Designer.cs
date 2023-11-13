namespace Clinica
{
    partial class Form4
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
            button2 = new Button();
            panel1 = new Panel();
            tab = new TabControl();
            tabPage2 = new TabPage();
            fecha2 = new TextBox();
            fecha1 = new TextBox();
            direccion_paciente = new TextBox();
            telefono_paciente = new TextBox();
            apellido_paciente = new TextBox();
            btn_ingresar = new Button();
            id_paciente = new NumericUpDown();
            label11 = new Label();
            label10 = new Label();
            estado_civil_paciente = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            sexo_paciente = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            nombre_paciente = new TextBox();
            tabPage1 = new TabPage();
            btn_rotar = new Button();
            button1 = new Button();
            label12 = new Label();
            sala_txt = new TextBox();
            label13 = new Label();
            personal_txt = new TextBox();
            panel2 = new Panel();
            dg1 = new DataGridView();
            tabPage3 = new TabPage();
            btnAgregarPariente = new Button();
            label17 = new Label();
            telefono_pariente = new TextBox();
            label18 = new Label();
            label19 = new Label();
            direccion_pariente = new TextBox();
            relacion = new TextBox();
            apellido_pariente = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            nombre_pariente = new TextBox();
            tabPage4 = new TabPage();
            btnIngresarPaciente = new Button();
            clinicaA = new ComboBox();
            label21 = new Label();
            id_pacienteA = new NumericUpDown();
            label20 = new Label();
            no_pacientep = new TextBox();
            panel1.SuspendLayout();
            tab.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)id_paciente).BeginInit();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg1).BeginInit();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)id_pacienteA).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(249, 247, 247);
            label1.Location = new Point(325, 9);
            label1.Name = "label1";
            label1.Size = new Size(290, 60);
            label1.TabIndex = 1;
            label1.Text = "Enfermera";
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
            button2.Location = new Point(12, 11);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(156, 50);
            button2.TabIndex = 8;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 64, 119);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tab);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(16, 83);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(903, 433);
            panel1.TabIndex = 9;
            // 
            // tab
            // 
            tab.Controls.Add(tabPage2);
            tab.Controls.Add(tabPage1);
            tab.Controls.Add(tabPage3);
            tab.Controls.Add(tabPage4);
            tab.Dock = DockStyle.Fill;
            tab.Location = new Point(0, 0);
            tab.Name = "tab";
            tab.SelectedIndex = 0;
            tab.Size = new Size(901, 431);
            tab.TabIndex = 10;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(17, 45, 78);
            tabPage2.Controls.Add(fecha2);
            tabPage2.Controls.Add(fecha1);
            tabPage2.Controls.Add(direccion_paciente);
            tabPage2.Controls.Add(telefono_paciente);
            tabPage2.Controls.Add(apellido_paciente);
            tabPage2.Controls.Add(btn_ingresar);
            tabPage2.Controls.Add(id_paciente);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(estado_civil_paciente);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(sexo_paciente);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(nombre_paciente);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(893, 403);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ingresar";
            // 
            // fecha2
            // 
            fecha2.BackColor = Color.FromArgb(249, 247, 247);
            fecha2.Font = new Font("Rockwell", 20F, FontStyle.Regular, GraphicsUnit.Point);
            fecha2.Location = new Point(511, 53);
            fecha2.Margin = new Padding(3, 2, 3, 2);
            fecha2.Name = "fecha2";
            fecha2.Size = new Size(209, 39);
            fecha2.TabIndex = 16;
            // 
            // fecha1
            // 
            fecha1.BackColor = Color.FromArgb(249, 247, 247);
            fecha1.Font = new Font("Rockwell", 20F, FontStyle.Regular, GraphicsUnit.Point);
            fecha1.Location = new Point(271, 141);
            fecha1.Margin = new Padding(3, 2, 3, 2);
            fecha1.Name = "fecha1";
            fecha1.Size = new Size(209, 39);
            fecha1.TabIndex = 14;
            // 
            // direccion_paciente
            // 
            direccion_paciente.BackColor = Color.FromArgb(249, 247, 247);
            direccion_paciente.Font = new Font("Rockwell", 20F, FontStyle.Regular, GraphicsUnit.Point);
            direccion_paciente.Location = new Point(271, 53);
            direccion_paciente.Margin = new Padding(3, 2, 3, 2);
            direccion_paciente.Name = "direccion_paciente";
            direccion_paciente.Size = new Size(209, 39);
            direccion_paciente.TabIndex = 13;
            // 
            // telefono_paciente
            // 
            telefono_paciente.BackColor = Color.FromArgb(249, 247, 247);
            telefono_paciente.Font = new Font("Rockwell", 20F, FontStyle.Regular, GraphicsUnit.Point);
            telefono_paciente.Location = new Point(18, 229);
            telefono_paciente.Margin = new Padding(3, 2, 3, 2);
            telefono_paciente.Name = "telefono_paciente";
            telefono_paciente.Size = new Size(209, 39);
            telefono_paciente.TabIndex = 12;
            // 
            // apellido_paciente
            // 
            apellido_paciente.BackColor = Color.FromArgb(249, 247, 247);
            apellido_paciente.Font = new Font("Rockwell", 20F, FontStyle.Regular, GraphicsUnit.Point);
            apellido_paciente.Location = new Point(18, 141);
            apellido_paciente.Margin = new Padding(3, 2, 3, 2);
            apellido_paciente.Name = "apellido_paciente";
            apellido_paciente.Size = new Size(209, 39);
            apellido_paciente.TabIndex = 11;
            // 
            // btn_ingresar
            // 
            btn_ingresar.BackColor = Color.FromArgb(17, 45, 78);
            btn_ingresar.FlatAppearance.BorderColor = Color.FromArgb(249, 247, 247);
            btn_ingresar.FlatAppearance.BorderSize = 2;
            btn_ingresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(18, 81, 157);
            btn_ingresar.FlatStyle = FlatStyle.Flat;
            btn_ingresar.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ingresar.ForeColor = Color.FromArgb(249, 247, 247);
            btn_ingresar.Location = new Point(352, 294);
            btn_ingresar.Margin = new Padding(3, 2, 3, 2);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(156, 50);
            btn_ingresar.TabIndex = 19;
            btn_ingresar.Text = "Ingresar";
            btn_ingresar.UseVisualStyleBackColor = false;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // id_paciente
            // 
            id_paciente.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            id_paciente.Location = new Point(511, 229);
            id_paciente.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            id_paciente.Name = "id_paciente";
            id_paciente.ReadOnly = true;
            id_paciente.Size = new Size(200, 35);
            id_paciente.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(249, 247, 247);
            label11.Location = new Point(511, 198);
            label11.Name = "label11";
            label11.Size = new Size(118, 22);
            label11.TabIndex = 30;
            label11.Text = "No.Paciente";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(249, 247, 247);
            label10.Location = new Point(405, 175);
            label10.Name = "label10";
            label10.Size = new Size(0, 22);
            label10.TabIndex = 29;
            // 
            // estado_civil_paciente
            // 
            estado_civil_paciente.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            estado_civil_paciente.FormattingEnabled = true;
            estado_civil_paciente.Items.AddRange(new object[] { "Casado", "Soltero" });
            estado_civil_paciente.Location = new Point(271, 229);
            estado_civil_paciente.Name = "estado_civil_paciente";
            estado_civil_paciente.Size = new Size(200, 38);
            estado_civil_paciente.TabIndex = 15;
            estado_civil_paciente.Text = "Ingrese una opcion";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(249, 247, 247);
            label8.Location = new Point(271, 198);
            label8.Name = "label8";
            label8.Size = new Size(122, 22);
            label8.TabIndex = 26;
            label8.Text = "Estado Civil";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(249, 247, 247);
            label9.Location = new Point(18, 198);
            label9.Name = "label9";
            label9.Size = new Size(88, 22);
            label9.TabIndex = 24;
            label9.Text = "Telefono";
            // 
            // sexo_paciente
            // 
            sexo_paciente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            sexo_paciente.FormattingEnabled = true;
            sexo_paciente.Items.AddRange(new object[] { "Masculino", "Femenino" });
            sexo_paciente.Location = new Point(511, 141);
            sexo_paciente.Name = "sexo_paciente";
            sexo_paciente.Size = new Size(200, 33);
            sexo_paciente.TabIndex = 17;
            sexo_paciente.Text = "Ingrese una opcion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(249, 247, 247);
            label7.Location = new Point(511, 110);
            label7.Name = "label7";
            label7.Size = new Size(54, 22);
            label7.TabIndex = 22;
            label7.Text = "Sexo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(249, 247, 247);
            label6.Location = new Point(511, 19);
            label6.Name = "label6";
            label6.Size = new Size(145, 22);
            label6.TabIndex = 19;
            label6.Text = "Fecha Registro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(249, 247, 247);
            label2.Location = new Point(271, 110);
            label2.Name = "label2";
            label2.Size = new Size(172, 22);
            label2.TabIndex = 17;
            label2.Text = "Fecha Nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(249, 247, 247);
            label5.Location = new Point(271, 19);
            label5.Name = "label5";
            label5.Size = new Size(98, 22);
            label5.TabIndex = 16;
            label5.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(249, 247, 247);
            label4.Location = new Point(18, 110);
            label4.Name = "label4";
            label4.Size = new Size(209, 22);
            label4.TabIndex = 13;
            label4.Text = "Apellido del paciente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(249, 247, 247);
            label3.Location = new Point(18, 19);
            label3.Name = "label3";
            label3.Size = new Size(203, 22);
            label3.TabIndex = 12;
            label3.Text = "Nombre del paciente";
            // 
            // nombre_paciente
            // 
            nombre_paciente.BackColor = Color.FromArgb(249, 247, 247);
            nombre_paciente.Font = new Font("Rockwell", 20F, FontStyle.Regular, GraphicsUnit.Point);
            nombre_paciente.Location = new Point(18, 53);
            nombre_paciente.Margin = new Padding(3, 2, 3, 2);
            nombre_paciente.Name = "nombre_paciente";
            nombre_paciente.Size = new Size(209, 39);
            nombre_paciente.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(17, 45, 78);
            tabPage1.Controls.Add(btn_rotar);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(sala_txt);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(personal_txt);
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(893, 403);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Rotaciones ";
            // 
            // btn_rotar
            // 
            btn_rotar.BackColor = Color.FromArgb(17, 45, 78);
            btn_rotar.FlatAppearance.BorderColor = Color.FromArgb(249, 247, 247);
            btn_rotar.FlatAppearance.BorderSize = 2;
            btn_rotar.FlatAppearance.MouseDownBackColor = Color.FromArgb(18, 81, 157);
            btn_rotar.FlatStyle = FlatStyle.Flat;
            btn_rotar.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_rotar.ForeColor = Color.FromArgb(249, 247, 247);
            btn_rotar.Location = new Point(786, 270);
            btn_rotar.Margin = new Padding(3, 2, 3, 2);
            btn_rotar.Name = "btn_rotar";
            btn_rotar.Size = new Size(104, 60);
            btn_rotar.TabIndex = 34;
            btn_rotar.Text = "Rotar Personal";
            btn_rotar.UseVisualStyleBackColor = false;
            btn_rotar.Click += btn_rotar_Click;
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
            button1.Location = new Point(553, 270);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(104, 60);
            button1.TabIndex = 33;
            button1.Text = "Personal";
            button1.UseVisualStyleBackColor = false;
            button1.Click += mostarPersonal;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(249, 247, 247);
            label12.Location = new Point(553, 152);
            label12.Name = "label12";
            label12.Size = new Size(126, 22);
            label12.TabIndex = 32;
            label12.Text = "Codigo sala ";
            // 
            // sala_txt
            // 
            sala_txt.BackColor = Color.FromArgb(249, 247, 247);
            sala_txt.Font = new Font("Rockwell", 20F, FontStyle.Regular, GraphicsUnit.Point);
            sala_txt.Location = new Point(553, 186);
            sala_txt.Margin = new Padding(3, 2, 3, 2);
            sala_txt.Name = "sala_txt";
            sala_txt.Size = new Size(337, 39);
            sala_txt.TabIndex = 31;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(249, 247, 247);
            label13.Location = new Point(553, 37);
            label13.Name = "label13";
            label13.Size = new Size(162, 22);
            label13.TabIndex = 30;
            label13.Text = "Codigo Personal";
            // 
            // personal_txt
            // 
            personal_txt.BackColor = Color.FromArgb(249, 247, 247);
            personal_txt.Font = new Font("Rockwell", 20F, FontStyle.Regular, GraphicsUnit.Point);
            personal_txt.Location = new Point(553, 71);
            personal_txt.Margin = new Padding(3, 2, 3, 2);
            personal_txt.Name = "personal_txt";
            personal_txt.Size = new Size(337, 39);
            personal_txt.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.Controls.Add(dg1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(547, 403);
            panel2.TabIndex = 1;
            // 
            // dg1
            // 
            dg1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg1.Dock = DockStyle.Fill;
            dg1.Location = new Point(0, 0);
            dg1.Name = "dg1";
            dg1.RowTemplate.Height = 25;
            dg1.Size = new Size(547, 403);
            dg1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(17, 45, 78);
            tabPage3.Controls.Add(no_pacientep);
            tabPage3.Controls.Add(btnAgregarPariente);
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(telefono_pariente);
            tabPage3.Controls.Add(label18);
            tabPage3.Controls.Add(label19);
            tabPage3.Controls.Add(direccion_pariente);
            tabPage3.Controls.Add(relacion);
            tabPage3.Controls.Add(apellido_pariente);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(nombre_pariente);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(893, 403);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Parentesco Paciente";
            // 
            // btnAgregarPariente
            // 
            btnAgregarPariente.BackColor = Color.FromArgb(17, 45, 78);
            btnAgregarPariente.FlatAppearance.BorderColor = Color.FromArgb(249, 247, 247);
            btnAgregarPariente.FlatAppearance.BorderSize = 2;
            btnAgregarPariente.FlatAppearance.MouseDownBackColor = Color.FromArgb(18, 81, 157);
            btnAgregarPariente.FlatStyle = FlatStyle.Flat;
            btnAgregarPariente.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarPariente.ForeColor = Color.FromArgb(249, 247, 247);
            btnAgregarPariente.Location = new Point(356, 328);
            btnAgregarPariente.Margin = new Padding(3, 2, 3, 2);
            btnAgregarPariente.Name = "btnAgregarPariente";
            btnAgregarPariente.Size = new Size(156, 59);
            btnAgregarPariente.TabIndex = 38;
            btnAgregarPariente.Text = "Agregar Pariente";
            btnAgregarPariente.UseVisualStyleBackColor = false;
            btnAgregarPariente.Click += AgregarPariente;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.FromArgb(249, 247, 247);
            label17.Location = new Point(442, 232);
            label17.Name = "label17";
            label17.Size = new Size(123, 22);
            label17.TabIndex = 37;
            label17.Text = "No. Paciente";
            // 
            // telefono_pariente
            // 
            telefono_pariente.BackColor = Color.FromArgb(249, 247, 247);
            telefono_pariente.Font = new Font("Rockwell", 20F, FontStyle.Regular, GraphicsUnit.Point);
            telefono_pariente.Location = new Point(442, 175);
            telefono_pariente.Margin = new Padding(3, 2, 3, 2);
            telefono_pariente.Name = "telefono_pariente";
            telefono_pariente.Size = new Size(209, 39);
            telefono_pariente.TabIndex = 32;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.FromArgb(249, 247, 247);
            label18.Location = new Point(442, 144);
            label18.Name = "label18";
            label18.Size = new Size(189, 22);
            label18.TabIndex = 35;
            label18.Text = "Numero de telefono";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = Color.FromArgb(249, 247, 247);
            label19.Location = new Point(442, 53);
            label19.Name = "label19";
            label19.Size = new Size(98, 22);
            label19.TabIndex = 34;
            label19.Text = "Direccion";
            // 
            // direccion_pariente
            // 
            direccion_pariente.BackColor = Color.FromArgb(249, 247, 247);
            direccion_pariente.Font = new Font("Rockwell", 20F, FontStyle.Regular, GraphicsUnit.Point);
            direccion_pariente.Location = new Point(442, 87);
            direccion_pariente.Margin = new Padding(3, 2, 3, 2);
            direccion_pariente.Name = "direccion_pariente";
            direccion_pariente.Size = new Size(209, 39);
            direccion_pariente.TabIndex = 31;
            // 
            // relacion
            // 
            relacion.BackColor = Color.FromArgb(249, 247, 247);
            relacion.Font = new Font("Rockwell", 20F, FontStyle.Regular, GraphicsUnit.Point);
            relacion.Location = new Point(179, 263);
            relacion.Margin = new Padding(3, 2, 3, 2);
            relacion.Name = "relacion";
            relacion.Size = new Size(209, 39);
            relacion.TabIndex = 27;
            // 
            // apellido_pariente
            // 
            apellido_pariente.BackColor = Color.FromArgb(249, 247, 247);
            apellido_pariente.Font = new Font("Rockwell", 20F, FontStyle.Regular, GraphicsUnit.Point);
            apellido_pariente.Location = new Point(179, 175);
            apellido_pariente.Margin = new Padding(3, 2, 3, 2);
            apellido_pariente.Name = "apellido_pariente";
            apellido_pariente.Size = new Size(209, 39);
            apellido_pariente.TabIndex = 26;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(249, 247, 247);
            label14.Location = new Point(179, 232);
            label14.Name = "label14";
            label14.Size = new Size(231, 22);
            label14.TabIndex = 30;
            label14.Text = "Relacion con el paciente";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(249, 247, 247);
            label15.Location = new Point(179, 144);
            label15.Name = "label15";
            label15.Size = new Size(207, 22);
            label15.TabIndex = 29;
            label15.Text = "Apellido del pariente";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.FromArgb(249, 247, 247);
            label16.Location = new Point(179, 53);
            label16.Name = "label16";
            label16.Size = new Size(201, 22);
            label16.TabIndex = 28;
            label16.Text = "Nombre del pariente";
            // 
            // nombre_pariente
            // 
            nombre_pariente.BackColor = Color.FromArgb(249, 247, 247);
            nombre_pariente.Font = new Font("Rockwell", 20F, FontStyle.Regular, GraphicsUnit.Point);
            nombre_pariente.Location = new Point(179, 87);
            nombre_pariente.Margin = new Padding(3, 2, 3, 2);
            nombre_pariente.Name = "nombre_pariente";
            nombre_pariente.Size = new Size(209, 39);
            nombre_pariente.TabIndex = 25;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(17, 45, 78);
            tabPage4.Controls.Add(btnIngresarPaciente);
            tabPage4.Controls.Add(clinicaA);
            tabPage4.Controls.Add(label21);
            tabPage4.Controls.Add(id_pacienteA);
            tabPage4.Controls.Add(label20);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(893, 403);
            tabPage4.TabIndex = 4;
            tabPage4.Text = "Ingresar Paciente Ambulatorio";
            // 
            // btnIngresarPaciente
            // 
            btnIngresarPaciente.BackColor = Color.FromArgb(17, 45, 78);
            btnIngresarPaciente.FlatAppearance.BorderColor = Color.FromArgb(249, 247, 247);
            btnIngresarPaciente.FlatAppearance.BorderSize = 2;
            btnIngresarPaciente.FlatAppearance.MouseDownBackColor = Color.FromArgb(18, 81, 157);
            btnIngresarPaciente.FlatStyle = FlatStyle.Flat;
            btnIngresarPaciente.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresarPaciente.ForeColor = Color.FromArgb(249, 247, 247);
            btnIngresarPaciente.Location = new Point(364, 281);
            btnIngresarPaciente.Margin = new Padding(3, 2, 3, 2);
            btnIngresarPaciente.Name = "btnIngresarPaciente";
            btnIngresarPaciente.Size = new Size(156, 50);
            btnIngresarPaciente.TabIndex = 42;
            btnIngresarPaciente.Text = "Ingresar";
            btnIngresarPaciente.UseVisualStyleBackColor = false;
            btnIngresarPaciente.Click += IngresarAmbulatorio;
            // 
            // clinicaA
            // 
            clinicaA.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            clinicaA.FormattingEnabled = true;
            clinicaA.Items.AddRange(new object[] { "Sala de Emergencia", "Sala de Cirugia " });
            clinicaA.Location = new Point(345, 108);
            clinicaA.Name = "clinicaA";
            clinicaA.Size = new Size(200, 33);
            clinicaA.TabIndex = 40;
            clinicaA.Text = "Ingrese una opcion";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = Color.FromArgb(249, 247, 247);
            label21.Location = new Point(345, 77);
            label21.Name = "label21";
            label21.Size = new Size(133, 22);
            label21.TabIndex = 41;
            label21.Text = "Ambulatorias";
            // 
            // id_pacienteA
            // 
            id_pacienteA.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            id_pacienteA.Location = new Point(345, 209);
            id_pacienteA.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            id_pacienteA.Name = "id_pacienteA";
            id_pacienteA.ReadOnly = true;
            id_pacienteA.Size = new Size(200, 35);
            id_pacienteA.TabIndex = 38;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.FromArgb(249, 247, 247);
            label20.Location = new Point(345, 178);
            label20.Name = "label20";
            label20.Size = new Size(123, 22);
            label20.TabIndex = 39;
            label20.Text = "No. Paciente";
            // 
            // no_pacientep
            // 
            no_pacientep.BackColor = Color.FromArgb(249, 247, 247);
            no_pacientep.Font = new Font("Rockwell", 20F, FontStyle.Regular, GraphicsUnit.Point);
            no_pacientep.Location = new Point(442, 263);
            no_pacientep.Margin = new Padding(3, 2, 3, 2);
            no_pacientep.Name = "no_pacientep";
            no_pacientep.Size = new Size(209, 39);
            no_pacientep.TabIndex = 39;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 45, 78);
            ClientSize = new Size(931, 527);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Enfermera";
            panel1.ResumeLayout(false);
            tab.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)id_paciente).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dg1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)id_pacienteA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Panel panel1;
        private TabControl tab;
        private TabPage tabPage2;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox nombre_paciente;
        private ComboBox sexo_paciente;
        private Label label7;
        private Label label6;
        private Button btn_ingresar;
        private NumericUpDown id_paciente;
        private Label label11;
        private Label label10;
        private ComboBox estado_civil_paciente;
        private Label label8;
        private Label label9;
        private TextBox direccion_paciente;
        private TextBox telefono_paciente;
        private TextBox apellido_paciente;
        private TextBox fecha2;
        private TextBox fecha1;
        private TabPage tabPage1;
        private Panel panel2;
        private DataGridView dg1;
        private Label label12;
        private TextBox sala_txt;
        private Label label13;
        private TextBox personal_txt;
        private Button btn_rotar;
        private Button button1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button btnAgregarPariente;
        private Label label17;
        private TextBox telefono_pariente;
        private Label label18;
        private Label label19;
        private TextBox direccion_pariente;
        private TextBox relacion;
        private TextBox apellido_pariente;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox nombre_pariente;
        private Button btnIngresarPaciente;
        private ComboBox clinicaA;
        private Label label21;
        private NumericUpDown id_pacienteA;
        private Label label20;
        private TextBox no_pacientep;
    }
}