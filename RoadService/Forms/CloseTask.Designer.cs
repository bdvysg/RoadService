namespace RoadService.Forms
{
    partial class CloseTask
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
            panel1 = new Panel();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            button6 = new Button();
            richTextBox1 = new RichTextBox();
            label9 = new Label();
            textBox4 = new TextBox();
            button4 = new Button();
            button2 = new Button();
            dateTimePicker2 = new DateTimePicker();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            label11 = new Label();
            textBox5 = new TextBox();
            label12 = new Label();
            textBox6 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 481);
            panel1.Name = "panel1";
            panel1.Size = new Size(983, 228);
            panel1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(489, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(494, 228);
            dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(489, 228);
            dataGridView1.TabIndex = 0;
            // 
            // button6
            // 
            button6.Location = new Point(597, 284);
            button6.Name = "button6";
            button6.Size = new Size(104, 23);
            button6.TabIndex = 47;
            button6.Text = "Обчислити ціну";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(70, 146);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(344, 82);
            richTextBox1.TabIndex = 46;
            richTextBox1.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(535, 131);
            label9.Name = "label9";
            label9.Size = new Size(111, 15);
            label9.TabIndex = 45;
            label9.Text = "Фактична кількість";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(664, 128);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(121, 23);
            textBox4.TabIndex = 44;
            textBox4.Text = "1";
            // 
            // button4
            // 
            button4.Location = new Point(791, 75);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 42;
            button4.Text = "Додати";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(422, 433);
            button2.Name = "button2";
            button2.Size = new Size(138, 23);
            button2.TabIndex = 40;
            button2.Text = "Закрити завдання";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Enabled = false;
            dateTimePicker2.Location = new Point(100, 282);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 288);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 37;
            label8.Text = "Дата кінця";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(100, 253);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 259);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 35;
            label7.Text = "Дата початку";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(664, 75);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 34;
            comboBox2.SelectedValueChanged += comboBox2_SelectedValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(535, 78);
            label6.Name = "label6";
            label6.Size = new Size(123, 15);
            label6.TabIndex = 33;
            label6.Text = "Використані ресурси";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(72, 107);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 110);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 29;
            label4.Text = "Адреса";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 146);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 28;
            label3.Text = "Опис";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(70, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 78);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 26;
            label2.Text = "Назва";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(444, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 25;
            label1.Text = "Закритя завдання";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(535, 105);
            label5.Name = "label5";
            label5.Size = new Size(130, 15);
            label5.TabIndex = 50;
            label5.Text = "Запланована кількість";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(664, 102);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 49;
            textBox2.Text = "1";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(543, 219);
            label11.Name = "label11";
            label11.Size = new Size(105, 15);
            label11.TabIndex = 52;
            label11.Text = "Запланована ціна";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(672, 216);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(121, 23);
            textBox5.TabIndex = 51;
            textBox5.Text = "1";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(543, 248);
            label12.Name = "label12";
            label12.Size = new Size(86, 15);
            label12.TabIndex = 54;
            label12.Text = "Фактична ціна";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(672, 245);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(121, 23);
            textBox6.TabIndex = 53;
            textBox6.Text = "1";
            // 
            // CloseTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 709);
            Controls.Add(label12);
            Controls.Add(textBox6);
            Controls.Add(label11);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(button6);
            Controls.Add(richTextBox1);
            Controls.Add(label9);
            Controls.Add(textBox4);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(dateTimePicker2);
            Controls.Add(label8);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "CloseTask";
            Text = "CloseTask";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Button button6;
        private RichTextBox richTextBox1;
        private Label label9;
        private TextBox textBox4;
        private Button button4;
        private Button button2;
        private DateTimePicker dateTimePicker2;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private ComboBox comboBox2;
        private Label label6;
        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox textBox2;
        private Label label11;
        private TextBox textBox5;
        private Label label12;
        private TextBox textBox6;
    }
}