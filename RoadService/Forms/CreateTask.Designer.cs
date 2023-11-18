namespace RoadService.Forms
{
    partial class CreateTask
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            label1 = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblDescription = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            lblEmployees = new Label();
            cmbEmployees = new ComboBox();
            cmbResources = new ComboBox();
            lblResources = new Label();
            lblDateStart = new Label();
            dtp1 = new DateTimePicker();
            dpt2 = new DateTimePicker();
            lblDateEnd = new Label();
            btnCheckAddress = new Button();
            btnCreate = new Button();
            btnAddEmployee = new Button();
            btnAddResources = new Button();
            btnFilter = new Button();
            txtCount = new TextBox();
            lblCount = new Label();
            rtxtDescription = new RichTextBox();
            btnCalcPrice = new Button();
            label10 = new Label();
            panel1 = new Panel();
            dgvResources = new DataGridView();
            dgvEmployees = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResources).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(460, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 21);
            label1.TabIndex = 0;
            label1.Text = "Створення завдання";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.Location = new Point(51, 52);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 21);
            lblName.TabIndex = 1;
            lblName.Text = "Назва";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(107, 49);
            txtName.Name = "txtName";
            txtName.Size = new Size(177, 29);
            txtName.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F);
            lblDescription.Location = new Point(51, 120);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(47, 21);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Опис";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F);
            txtAddress.Location = new Point(109, 81);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(175, 29);
            txtAddress.TabIndex = 6;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 12F);
            lblAddress.Location = new Point(53, 84);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(61, 21);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "Адреса";
            // 
            // lblEmployees
            // 
            lblEmployees.AutoSize = true;
            lblEmployees.Font = new Font("Segoe UI", 12F);
            lblEmployees.Location = new Point(572, 213);
            lblEmployees.Name = "lblEmployees";
            lblEmployees.Size = new Size(95, 21);
            lblEmployees.TabIndex = 7;
            lblEmployees.Text = "Працівники";
            // 
            // cmbEmployees
            // 
            cmbEmployees.Enabled = false;
            cmbEmployees.Font = new Font("Segoe UI", 12F);
            cmbEmployees.FormattingEnabled = true;
            cmbEmployees.Location = new Point(673, 210);
            cmbEmployees.Name = "cmbEmployees";
            cmbEmployees.Size = new Size(190, 29);
            cmbEmployees.TabIndex = 8;
            // 
            // cmbResources
            // 
            cmbResources.Enabled = false;
            cmbResources.Font = new Font("Segoe UI", 12F);
            cmbResources.FormattingEnabled = true;
            cmbResources.Location = new Point(673, 245);
            cmbResources.Name = "cmbResources";
            cmbResources.Size = new Size(190, 29);
            cmbResources.TabIndex = 10;
            cmbResources.SelectedValueChanged += comboBox2_SelectedValueChanged;
            // 
            // lblResources
            // 
            lblResources.AutoSize = true;
            lblResources.Font = new Font("Segoe UI", 12F);
            lblResources.Location = new Point(600, 248);
            lblResources.Name = "lblResources";
            lblResources.Size = new Size(67, 21);
            lblResources.TabIndex = 9;
            lblResources.Text = "Ресурси";
            // 
            // lblDateStart
            // 
            lblDateStart.AutoSize = true;
            lblDateStart.Font = new Font("Segoe UI", 12F);
            lblDateStart.Location = new Point(563, 58);
            lblDateStart.Name = "lblDateStart";
            lblDateStart.Size = new Size(106, 21);
            lblDateStart.TabIndex = 11;
            lblDateStart.Text = "Дата початку";
            // 
            // dtp1
            // 
            dtp1.Enabled = false;
            dtp1.Font = new Font("Segoe UI", 12F);
            dtp1.Location = new Point(673, 52);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(200, 29);
            dtp1.TabIndex = 12;
            // 
            // dpt2
            // 
            dpt2.Enabled = false;
            dpt2.Font = new Font("Segoe UI", 12F);
            dpt2.Location = new Point(673, 84);
            dpt2.Name = "dpt2";
            dpt2.Size = new Size(200, 29);
            dpt2.TabIndex = 14;
            // 
            // lblDateEnd
            // 
            lblDateEnd.AutoSize = true;
            lblDateEnd.Font = new Font("Segoe UI", 12F);
            lblDateEnd.Location = new Point(563, 87);
            lblDateEnd.Name = "lblDateEnd";
            lblDateEnd.Size = new Size(87, 21);
            lblDateEnd.TabIndex = 13;
            lblDateEnd.Text = "Дата кінця";
            // 
            // btnCheckAddress
            // 
            btnCheckAddress.Font = new Font("Segoe UI", 12F);
            btnCheckAddress.Location = new Point(290, 81);
            btnCheckAddress.Name = "btnCheckAddress";
            btnCheckAddress.Size = new Size(161, 29);
            btnCheckAddress.TabIndex = 15;
            btnCheckAddress.Text = "Перевірити адресу";
            btnCheckAddress.UseVisualStyleBackColor = true;
            btnCheckAddress.Click += btnCheckAddress_Click;
            // 
            // btnCreate
            // 
            btnCreate.Enabled = false;
            btnCreate.Font = new Font("Segoe UI", 12F);
            btnCreate.Location = new Point(482, 338);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(114, 31);
            btnCreate.TabIndex = 16;
            btnCreate.Text = "Створити";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnClose_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Enabled = false;
            btnAddEmployee.Font = new Font("Segoe UI", 12F);
            btnAddEmployee.Location = new Point(869, 210);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(101, 29);
            btnAddEmployee.TabIndex = 17;
            btnAddEmployee.Text = "Додати";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddResources_Click;
            // 
            // btnAddResources
            // 
            btnAddResources.Enabled = false;
            btnAddResources.Font = new Font("Segoe UI", 12F);
            btnAddResources.Location = new Point(869, 245);
            btnAddResources.Name = "btnAddResources";
            btnAddResources.Size = new Size(98, 29);
            btnAddResources.TabIndex = 18;
            btnAddResources.Text = "Додати";
            btnAddResources.UseVisualStyleBackColor = true;
            btnAddResources.Click += btnAddResources_Click;
            // 
            // btnFilter
            // 
            btnFilter.Enabled = false;
            btnFilter.Font = new Font("Segoe UI", 12F);
            btnFilter.Location = new Point(673, 119);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(200, 29);
            btnFilter.TabIndex = 19;
            btnFilter.Text = "Відфільтрувати ";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnAddResources_Click;
            // 
            // txtCount
            // 
            txtCount.Enabled = false;
            txtCount.Font = new Font("Segoe UI", 12F);
            txtCount.Location = new Point(673, 280);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(190, 29);
            txtCount.TabIndex = 20;
            txtCount.Text = "1";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 12F);
            lblCount.Location = new Point(594, 283);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(73, 21);
            lblCount.TabIndex = 21;
            lblCount.Text = "Кількість";
            lblCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Enabled = false;
            rtxtDescription.Font = new Font("Segoe UI", 12F);
            rtxtDescription.Location = new Point(104, 116);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(344, 82);
            rtxtDescription.TabIndex = 22;
            rtxtDescription.Text = "";
            // 
            // btnCalcPrice
            // 
            btnCalcPrice.Enabled = false;
            btnCalcPrice.Font = new Font("Segoe UI", 12F);
            btnCalcPrice.Location = new Point(53, 275);
            btnCalcPrice.Name = "btnCalcPrice";
            btnCalcPrice.Size = new Size(104, 29);
            btnCalcPrice.TabIndex = 23;
            btnCalcPrice.Text = "Обчислити ціну";
            btnCalcPrice.UseVisualStyleBackColor = true;
            btnCalcPrice.Click += btnCalcPrice_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(163, 279);
            label10.Name = "label10";
            label10.Size = new Size(124, 21);
            label10.TabIndex = 24;
            label10.Text = "Приблизна ціна";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvResources);
            panel1.Controls.Add(dgvEmployees);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 375);
            panel1.Name = "panel1";
            panel1.Size = new Size(1057, 244);
            panel1.TabIndex = 25;
            // 
            // dgvResources
            // 
            dgvResources.AllowUserToAddRows = false;
            dgvResources.AllowUserToDeleteRows = false;
            dgvResources.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvResources.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvResources.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvResources.DefaultCellStyle = dataGridViewCellStyle6;
            dgvResources.Dock = DockStyle.Fill;
            dgvResources.Location = new Point(548, 0);
            dgvResources.Name = "dgvResources";
            dgvResources.ReadOnly = true;
            dgvResources.Size = new Size(509, 244);
            dgvResources.TabIndex = 1;
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvEmployees.DefaultCellStyle = dataGridViewCellStyle8;
            dgvEmployees.Dock = DockStyle.Left;
            dgvEmployees.Location = new Point(0, 0);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.Size = new Size(548, 244);
            dgvEmployees.TabIndex = 0;
            // 
            // CreateTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 619);
            Controls.Add(panel1);
            Controls.Add(label10);
            Controls.Add(btnCalcPrice);
            Controls.Add(rtxtDescription);
            Controls.Add(lblCount);
            Controls.Add(txtCount);
            Controls.Add(btnFilter);
            Controls.Add(btnAddResources);
            Controls.Add(btnAddEmployee);
            Controls.Add(btnCreate);
            Controls.Add(btnCheckAddress);
            Controls.Add(dpt2);
            Controls.Add(lblDateEnd);
            Controls.Add(dtp1);
            Controls.Add(lblDateStart);
            Controls.Add(cmbResources);
            Controls.Add(lblResources);
            Controls.Add(cmbEmployees);
            Controls.Add(lblEmployees);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(lblDescription);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(label1);
            Name = "CreateTask";
            Text = "Task";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResources).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblName;
        private TextBox txtName;
        private Label lblDescription;
        private TextBox txtAddress;
        private Label lblAddress;
        private Label lblEmployees;
        private ComboBox cmbEmployees;
        private ComboBox cmbResources;
        private Label lblResources;
        private Label lblDateStart;
        private DateTimePicker dtp1;
        private DateTimePicker dpt2;
        private Label lblDateEnd;
        private Button btnCheckAddress;
        private Button btnCreate;
        private Button btnAddEmployee;
        private Button btnAddResources;
        private Button btnFilter;
        private TextBox txtCount;
        private Label lblCount;
        private RichTextBox rtxtDescription;
        private Button btnCalcPrice;
        private Label label10;
        private Panel panel1;
        private DataGridView dgvResources;
        private DataGridView dgvEmployees;
    }
}