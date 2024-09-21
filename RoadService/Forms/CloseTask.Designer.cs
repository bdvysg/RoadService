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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dgv2 = new DataGridView();
            dgv1 = new DataGridView();
            btnCalc = new Button();
            txtDesc = new RichTextBox();
            label9 = new Label();
            txtActualCount = new TextBox();
            btnAddRess = new Button();
            btnCLose = new Button();
            dtp2 = new DateTimePicker();
            label8 = new Label();
            dtp1 = new DateTimePicker();
            label7 = new Label();
            cmbUsedRes = new ComboBox();
            label6 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            txtPlannedCount = new TextBox();
            label11 = new Label();
            txtPlannedPrice = new TextBox();
            label12 = new Label();
            txtActualPrice = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgv2);
            panel1.Controls.Add(dgv1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 481);
            panel1.Name = "panel1";
            panel1.Size = new Size(983, 228);
            panel1.TabIndex = 0;
            // 
            // dgv2
            // 
            dgv2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv2.DefaultCellStyle = dataGridViewCellStyle3;
            dgv2.Dock = DockStyle.Fill;
            dgv2.Location = new Point(489, 0);
            dgv2.Name = "dgv2";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv2.Size = new Size(494, 228);
            dgv2.TabIndex = 1;
            // 
            // dgv1
            // 
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.DefaultCellStyle = dataGridViewCellStyle3;
            dgv1.Dock = DockStyle.Left;
            dgv1.Location = new Point(0, 0);
            dgv1.Name = "dgv1";
            dgv1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv1.Size = new Size(489, 228);
            dgv1.TabIndex = 0;
            // 
            // btnCalc
            // 
            btnCalc.Font = new Font("Segoe UI", 12F);
            btnCalc.Location = new Point(678, 286);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(121, 29);
            btnCalc.TabIndex = 47;
            btnCalc.Text = "Обчислити ціну";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += button6_Click;
            // 
            // txtDesc
            // 
            txtDesc.Font = new Font("Segoe UI", 12F);
            txtDesc.Location = new Point(84, 147);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(332, 82);
            txtDesc.TabIndex = 46;
            txtDesc.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(535, 147);
            label9.Name = "label9";
            label9.Size = new Size(146, 21);
            label9.TabIndex = 45;
            label9.Text = "Фактична кількість";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtActualCount
            // 
            txtActualCount.Font = new Font("Segoe UI", 12F);
            txtActualCount.Location = new Point(700, 147);
            txtActualCount.Name = "txtActualCount";
            txtActualCount.Size = new Size(121, 29);
            txtActualCount.TabIndex = 44;
            txtActualCount.Text = "1";
            // 
            // btnAddRess
            // 
            btnAddRess.Font = new Font("Segoe UI", 12F);
            btnAddRess.Location = new Point(827, 78);
            btnAddRess.Name = "btnAddRess";
            btnAddRess.Size = new Size(93, 29);
            btnAddRess.TabIndex = 42;
            btnAddRess.Text = "Додати";
            btnAddRess.UseVisualStyleBackColor = true;
            btnAddRess.Click += button4_Click;
            // 
            // btnCLose
            // 
            btnCLose.Font = new Font("Segoe UI", 12F);
            btnCLose.Location = new Point(422, 425);
            btnCLose.Name = "btnCLose";
            btnCLose.Size = new Size(138, 31);
            btnCLose.TabIndex = 40;
            btnCLose.Text = "Закрити завдання";
            btnCLose.UseVisualStyleBackColor = true;
            btnCLose.Click += button2_Click;
            // 
            // dtp2
            // 
            dtp2.Enabled = false;
            dtp2.Font = new Font("Segoe UI", 12F);
            dtp2.Location = new Point(202, 280);
            dtp2.Name = "dtp2";
            dtp2.Size = new Size(214, 29);
            dtp2.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(84, 286);
            label8.Name = "label8";
            label8.Size = new Size(87, 21);
            label8.TabIndex = 37;
            label8.Text = "Дата кінця";
            // 
            // dtp1
            // 
            dtp1.Enabled = false;
            dtp1.Font = new Font("Segoe UI", 12F);
            dtp1.Location = new Point(202, 245);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(214, 29);
            dtp1.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(84, 251);
            label7.Name = "label7";
            label7.Size = new Size(106, 21);
            label7.TabIndex = 35;
            label7.Text = "Дата початку";
            // 
            // cmbUsedRes
            // 
            cmbUsedRes.Font = new Font("Segoe UI", 12F);
            cmbUsedRes.FormattingEnabled = true;
            cmbUsedRes.Location = new Point(700, 78);
            cmbUsedRes.Name = "cmbUsedRes";
            cmbUsedRes.Size = new Size(121, 29);
            cmbUsedRes.TabIndex = 34;
            cmbUsedRes.SelectedValueChanged += comboBox2_SelectedValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(535, 78);
            label6.Name = "label6";
            label6.Size = new Size(159, 21);
            label6.TabIndex = 33;
            label6.Text = "Використані ресурси";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F);
            txtAddress.Location = new Point(154, 107);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(262, 29);
            txtAddress.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(84, 110);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 29;
            label4.Text = "Адреса";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(154, 70);
            txtName.Name = "txtName";
            txtName.Size = new Size(262, 29);
            txtName.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(84, 73);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 26;
            label2.Text = "Назва";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(444, 9);
            label1.Name = "label1";
            label1.Size = new Size(138, 21);
            label1.TabIndex = 25;
            label1.Text = "Закритя завдання";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(535, 112);
            label5.Name = "label5";
            label5.Size = new Size(169, 21);
            label5.TabIndex = 50;
            label5.Text = "Запланована кількість";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPlannedCount
            // 
            txtPlannedCount.Font = new Font("Segoe UI", 12F);
            txtPlannedCount.Location = new Point(700, 112);
            txtPlannedCount.Name = "txtPlannedCount";
            txtPlannedCount.ReadOnly = true;
            txtPlannedCount.Size = new Size(121, 29);
            txtPlannedCount.TabIndex = 49;
            txtPlannedCount.Text = "1";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(543, 219);
            label11.Name = "label11";
            label11.Size = new Size(138, 21);
            label11.TabIndex = 52;
            label11.Text = "Запланована ціна";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPlannedPrice
            // 
            txtPlannedPrice.Font = new Font("Segoe UI", 12F);
            txtPlannedPrice.Location = new Point(678, 214);
            txtPlannedPrice.Name = "txtPlannedPrice";
            txtPlannedPrice.ReadOnly = true;
            txtPlannedPrice.Size = new Size(121, 29);
            txtPlannedPrice.TabIndex = 51;
            txtPlannedPrice.Text = "1";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(543, 254);
            label12.Name = "label12";
            label12.Size = new Size(115, 21);
            label12.TabIndex = 54;
            label12.Text = "Фактична ціна";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtActualPrice
            // 
            txtActualPrice.Font = new Font("Segoe UI", 12F);
            txtActualPrice.Location = new Point(678, 249);
            txtActualPrice.Name = "txtActualPrice";
            txtActualPrice.ReadOnly = true;
            txtActualPrice.Size = new Size(121, 29);
            txtActualPrice.TabIndex = 53;
            txtActualPrice.Text = "1";
            // 
            // CloseTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 709);
            Controls.Add(label12);
            Controls.Add(txtActualPrice);
            Controls.Add(label11);
            Controls.Add(txtPlannedPrice);
            Controls.Add(label5);
            Controls.Add(txtPlannedCount);
            Controls.Add(btnCalc);
            Controls.Add(txtDesc);
            Controls.Add(label9);
            Controls.Add(txtActualCount);
            Controls.Add(btnAddRess);
            Controls.Add(btnCLose);
            Controls.Add(dtp2);
            Controls.Add(label8);
            Controls.Add(dtp1);
            Controls.Add(label7);
            Controls.Add(cmbUsedRes);
            Controls.Add(label6);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "CloseTask";
            Text = "CloseTask";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dgv2;
        private DataGridView dgv1;
        private Button btnCalc;
        private RichTextBox txtDesc;
        private Label label9;
        private TextBox txtActualCount;
        private Button btnAddRess;
        private Button btnCLose;
        private DateTimePicker dtp2;
        private Label label8;
        private DateTimePicker dtp1;
        private Label label7;
        private ComboBox cmbUsedRes;
        private Label label6;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox txtPlannedCount;
        private Label label11;
        private TextBox txtPlannedPrice;
        private Label label12;
        private TextBox txtActualPrice;
    }
}