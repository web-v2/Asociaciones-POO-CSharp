namespace AsociacionesPOO
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
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox5 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            groupBox3 = new GroupBox();
            listBox1 = new ListBox();
            button2 = new Button();
            groupBox4 = new GroupBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(29, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(461, 101);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(333, 48);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(333, 30);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 6;
            label4.Text = "Celular";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(227, 48);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(227, 30);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 4;
            label3.Text = "Num Id";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(121, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 30);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellidos";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 30);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombres";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Location = new Point(36, 162);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(454, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de la Venta";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(270, 55);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(134, 23);
            textBox5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(270, 37);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 8;
            label6.Text = "Valor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 34);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 1;
            label5.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(14, 52);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(156, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.Value = new DateTime(2023, 8, 22, 0, 8, 6, 0);
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(36, 268);
            button1.Name = "button1";
            button1.Size = new Size(135, 43);
            button1.TabIndex = 2;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listBox1);
            groupBox3.Location = new Point(43, 384);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(447, 206);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ventas";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(16, 28);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(416, 169);
            listBox1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(355, 335);
            button2.Name = "button2";
            button2.Size = new Size(135, 43);
            button2.TabIndex = 4;
            button2.Text = "Ventas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label7);
            groupBox4.Location = new Point(42, 607);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(448, 59);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Total Ventas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 192, 0);
            label7.Location = new Point(176, 19);
            label7.Name = "label7";
            label7.Size = new Size(44, 34);
            label7.TabIndex = 0;
            label7.Text = "$0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 678);
            Controls.Add(groupBox4);
            Controls.Add(button2);
            Controls.Add(groupBox3);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Array Objetos";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox textBox5;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private GroupBox groupBox3;
        private Button button2;
        private ListBox listBox1;
        private GroupBox groupBox4;
        private Label label7;
    }
}