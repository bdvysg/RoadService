namespace RoadService.Forms
{
    partial class InsertData
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnRefrEmpTT = new Button();
            dgvEmpTT = new DataGridView();
            btnAddEmpTT = new Button();
            cmbEmpTT = new ComboBox();
            label2 = new Label();
            btnCheck = new Button();
            dtp2ETT = new DateTimePicker();
            label8 = new Label();
            dtpETT = new DateTimePicker();
            label7 = new Label();
            label1 = new Label();
            tabPage3 = new TabPage();
            txtBResTTCount = new TextBox();
            label29 = new Label();
            dgvResTT = new DataGridView();
            btnRefrResTT = new Button();
            btnAddResTT = new Button();
            label28 = new Label();
            btnCheckResTT = new Button();
            cmbResTT = new ComboBox();
            dtp2ResTT = new DateTimePicker();
            label25 = new Label();
            dtp1ResTT = new DateTimePicker();
            label26 = new Label();
            label27 = new Label();
            pageRes = new TabPage();
            btnUpdResDgv = new Button();
            btnCntResDvg = new Button();
            lblCountRes = new Label();
            label4 = new Label();
            cmbTypeRes = new ComboBox();
            dgvRes = new DataGridView();
            pnlTools = new Panel();
            btnRegRes = new Button();
            txtBManuf = new TextBox();
            label13 = new Label();
            txtBPrice = new TextBox();
            label15 = new Label();
            txtBDesc = new TextBox();
            label16 = new Label();
            txtBName = new TextBox();
            label17 = new Label();
            label18 = new Label();
            pnlMaterial = new Panel();
            button5 = new Button();
            textBox5 = new TextBox();
            label12 = new Label();
            textBox3 = new TextBox();
            label10 = new Label();
            textBox2 = new TextBox();
            label9 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            pnlTransport = new Panel();
            button9 = new Button();
            textBox11 = new TextBox();
            label19 = new Label();
            textBox13 = new TextBox();
            label21 = new Label();
            textBox14 = new TextBox();
            label22 = new Label();
            textBox15 = new TextBox();
            label23 = new Label();
            label24 = new Label();
            pageStock = new TabPage();
            label14 = new Label();
            cmbRes = new ComboBox();
            label11 = new Label();
            txtBCount = new TextBox();
            btnDelRes = new Button();
            btnAddRes = new Button();
            dgvStock = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpTT).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResTT).BeginInit();
            pageRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRes).BeginInit();
            pnlTools.SuspendLayout();
            pnlMaterial.SuspendLayout();
            pnlTransport.SuspendLayout();
            pageStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(pageRes);
            tabControl1.Controls.Add(pageStock);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(886, 636);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRefrEmpTT);
            tabPage1.Controls.Add(dgvEmpTT);
            tabPage1.Controls.Add(btnAddEmpTT);
            tabPage1.Controls.Add(cmbEmpTT);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(btnCheck);
            tabPage1.Controls.Add(dtp2ETT);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(dtpETT);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(878, 608);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "EmpTT";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRefrEmpTT
            // 
            btnRefrEmpTT.Location = new Point(587, 181);
            btnRefrEmpTT.Name = "btnRefrEmpTT";
            btnRefrEmpTT.Size = new Size(163, 23);
            btnRefrEmpTT.TabIndex = 24;
            btnRefrEmpTT.Text = "Оновити дані";
            btnRefrEmpTT.UseVisualStyleBackColor = true;
            btnRefrEmpTT.Click += button3_Click;
            // 
            // dgvEmpTT
            // 
            dgvEmpTT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpTT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpTT.Dock = DockStyle.Bottom;
            dgvEmpTT.Location = new Point(3, 398);
            dgvEmpTT.Name = "dgvEmpTT";
            dgvEmpTT.Size = new Size(872, 207);
            dgvEmpTT.TabIndex = 23;
            // 
            // btnAddEmpTT
            // 
            btnAddEmpTT.Location = new Point(324, 181);
            btnAddEmpTT.Name = "btnAddEmpTT";
            btnAddEmpTT.Size = new Size(118, 23);
            btnAddEmpTT.TabIndex = 22;
            btnAddEmpTT.Text = "Додати ";
            btnAddEmpTT.UseVisualStyleBackColor = true;
            btnAddEmpTT.Click += button2_Click;
            // 
            // cmbEmpTT
            // 
            cmbEmpTT.FormattingEnabled = true;
            cmbEmpTT.Location = new Point(483, 70);
            cmbEmpTT.Name = "cmbEmpTT";
            cmbEmpTT.Size = new Size(121, 23);
            cmbEmpTT.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 187);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 20;
            label2.Text = "Сount";
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(6, 183);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(75, 23);
            btnCheck.TabIndex = 19;
            btnCheck.Text = "Check count";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += button1_Click;
            // 
            // dtp2ETT
            // 
            dtp2ETT.Location = new Point(147, 84);
            dtp2ETT.Name = "dtp2ETT";
            dtp2ETT.Size = new Size(200, 23);
            dtp2ETT.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(62, 90);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 17;
            label8.Text = "Дата кінця";
            // 
            // dtpETT
            // 
            dtpETT.Location = new Point(147, 55);
            dtpETT.Name = "dtpETT";
            dtpETT.Size = new Size(200, 23);
            dtpETT.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(62, 61);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 15;
            label7.Text = "Дата початку";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(315, 22);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 0;
            label1.Text = "EmployeeTimeTable";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(txtBResTTCount);
            tabPage3.Controls.Add(label29);
            tabPage3.Controls.Add(dgvResTT);
            tabPage3.Controls.Add(btnRefrResTT);
            tabPage3.Controls.Add(btnAddResTT);
            tabPage3.Controls.Add(label28);
            tabPage3.Controls.Add(btnCheckResTT);
            tabPage3.Controls.Add(cmbResTT);
            tabPage3.Controls.Add(dtp2ResTT);
            tabPage3.Controls.Add(label25);
            tabPage3.Controls.Add(dtp1ResTT);
            tabPage3.Controls.Add(label26);
            tabPage3.Controls.Add(label27);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(878, 608);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "ResTT";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtBResTTCount
            // 
            txtBResTTCount.Location = new Point(376, 126);
            txtBResTTCount.Name = "txtBResTTCount";
            txtBResTTCount.Size = new Size(100, 23);
            txtBResTTCount.TabIndex = 34;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(301, 129);
            label29.Name = "label29";
            label29.Size = new Size(56, 15);
            label29.TabIndex = 33;
            label29.Text = "Кількість";
            // 
            // dgvResTT
            // 
            dgvResTT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResTT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResTT.Dock = DockStyle.Bottom;
            dgvResTT.Location = new Point(3, 398);
            dgvResTT.Name = "dgvResTT";
            dgvResTT.Size = new Size(872, 207);
            dgvResTT.TabIndex = 32;
            // 
            // btnRefrResTT
            // 
            btnRefrResTT.Location = new Point(621, 166);
            btnRefrResTT.Name = "btnRefrResTT";
            btnRefrResTT.Size = new Size(163, 23);
            btnRefrResTT.TabIndex = 31;
            btnRefrResTT.Text = "Оновити дані";
            btnRefrResTT.UseVisualStyleBackColor = true;
            btnRefrResTT.Click += button10_Click;
            // 
            // btnAddResTT
            // 
            btnAddResTT.Location = new Point(358, 166);
            btnAddResTT.Name = "btnAddResTT";
            btnAddResTT.Size = new Size(118, 23);
            btnAddResTT.TabIndex = 30;
            btnAddResTT.Text = "Додати ";
            btnAddResTT.UseVisualStyleBackColor = true;
            btnAddResTT.Click += button11_Click;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(121, 172);
            label28.Name = "label28";
            label28.Size = new Size(40, 15);
            label28.TabIndex = 29;
            label28.Text = "Сount";
            // 
            // btnCheckResTT
            // 
            btnCheckResTT.Location = new Point(40, 168);
            btnCheckResTT.Name = "btnCheckResTT";
            btnCheckResTT.Size = new Size(75, 23);
            btnCheckResTT.TabIndex = 28;
            btnCheckResTT.Text = "Check count";
            btnCheckResTT.UseVisualStyleBackColor = true;
            btnCheckResTT.Click += button12_Click;
            // 
            // cmbResTT
            // 
            cmbResTT.FormattingEnabled = true;
            cmbResTT.Location = new Point(526, 66);
            cmbResTT.Name = "cmbResTT";
            cmbResTT.Size = new Size(121, 23);
            cmbResTT.TabIndex = 27;
            // 
            // dtp2ResTT
            // 
            dtp2ResTT.Location = new Point(190, 80);
            dtp2ResTT.Name = "dtp2ResTT";
            dtp2ResTT.Size = new Size(200, 23);
            dtp2ResTT.TabIndex = 26;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(105, 86);
            label25.Name = "label25";
            label25.Size = new Size(64, 15);
            label25.TabIndex = 25;
            label25.Text = "Дата кінця";
            // 
            // dtp1ResTT
            // 
            dtp1ResTT.Location = new Point(190, 51);
            dtp1ResTT.Name = "dtp1ResTT";
            dtp1ResTT.Size = new Size(200, 23);
            dtp1ResTT.TabIndex = 24;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(105, 57);
            label26.Name = "label26";
            label26.Size = new Size(79, 15);
            label26.TabIndex = 23;
            label26.Text = "Дата початку";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(358, 18);
            label27.Name = "label27";
            label27.Size = new Size(108, 15);
            label27.TabIndex = 22;
            label27.Text = "ResourceTimeTable";
            // 
            // pageRes
            // 
            pageRes.Controls.Add(btnUpdResDgv);
            pageRes.Controls.Add(btnCntResDvg);
            pageRes.Controls.Add(lblCountRes);
            pageRes.Controls.Add(label4);
            pageRes.Controls.Add(cmbTypeRes);
            pageRes.Controls.Add(dgvRes);
            pageRes.Controls.Add(pnlTools);
            pageRes.Controls.Add(pnlMaterial);
            pageRes.Controls.Add(pnlTransport);
            pageRes.Font = new Font("Segoe UI", 12F);
            pageRes.Location = new Point(4, 24);
            pageRes.Name = "pageRes";
            pageRes.Padding = new Padding(3);
            pageRes.Size = new Size(878, 608);
            pageRes.TabIndex = 1;
            pageRes.Text = "Ресурси";
            pageRes.UseVisualStyleBackColor = true;
            // 
            // btnUpdResDgv
            // 
            btnUpdResDgv.Font = new Font("Segoe UI", 12F);
            btnUpdResDgv.Location = new Point(784, 380);
            btnUpdResDgv.Name = "btnUpdResDgv";
            btnUpdResDgv.Size = new Size(91, 31);
            btnUpdResDgv.TabIndex = 8;
            btnUpdResDgv.Text = "Оновити таблицю";
            btnUpdResDgv.UseVisualStyleBackColor = true;
            btnUpdResDgv.Click += button7_Click;
            // 
            // btnCntResDvg
            // 
            btnCntResDvg.Font = new Font("Segoe UI", 12F);
            btnCntResDvg.Location = new Point(6, 380);
            btnCntResDvg.Name = "btnCntResDvg";
            btnCntResDvg.Size = new Size(91, 31);
            btnCntResDvg.TabIndex = 7;
            btnCntResDvg.Text = "Кількість";
            btnCntResDvg.UseVisualStyleBackColor = true;
            btnCntResDvg.Visible = false;
            btnCntResDvg.Click += button6_Click;
            // 
            // lblCountRes
            // 
            lblCountRes.AutoSize = true;
            lblCountRes.Font = new Font("Segoe UI", 12F);
            lblCountRes.Location = new Point(103, 385);
            lblCountRes.Name = "lblCountRes";
            lblCountRes.Size = new Size(73, 21);
            lblCountRes.TabIndex = 6;
            lblCountRes.Text = "Кількість";
            lblCountRes.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(660, 9);
            label4.Name = "label4";
            label4.Size = new Size(36, 21);
            label4.TabIndex = 3;
            label4.Text = "Тип";
            // 
            // cmbTypeRes
            // 
            cmbTypeRes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTypeRes.Font = new Font("Segoe UI", 12F);
            cmbTypeRes.FormattingEnabled = true;
            cmbTypeRes.Location = new Point(702, 6);
            cmbTypeRes.Name = "cmbTypeRes";
            cmbTypeRes.Size = new Size(173, 29);
            cmbTypeRes.TabIndex = 2;
            cmbTypeRes.SelectedIndexChanged += cmbTypeRes_SelectedIndexChanged;
            // 
            // dgvRes
            // 
            dgvRes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRes.Dock = DockStyle.Bottom;
            dgvRes.Location = new Point(3, 417);
            dgvRes.Name = "dgvRes";
            dgvRes.Size = new Size(872, 188);
            dgvRes.TabIndex = 0;
            // 
            // pnlTools
            // 
            pnlTools.Controls.Add(btnRegRes);
            pnlTools.Controls.Add(txtBManuf);
            pnlTools.Controls.Add(label13);
            pnlTools.Controls.Add(txtBPrice);
            pnlTools.Controls.Add(label15);
            pnlTools.Controls.Add(txtBDesc);
            pnlTools.Controls.Add(label16);
            pnlTools.Controls.Add(txtBName);
            pnlTools.Controls.Add(label17);
            pnlTools.Controls.Add(label18);
            pnlTools.Font = new Font("Segoe UI", 12F);
            pnlTools.Location = new Point(3, 35);
            pnlTools.Name = "pnlTools";
            pnlTools.Size = new Size(872, 339);
            pnlTools.TabIndex = 12;
            pnlTools.Visible = false;
            // 
            // btnRegRes
            // 
            btnRegRes.Location = new Point(376, 291);
            btnRegRes.Name = "btnRegRes";
            btnRegRes.Size = new Size(91, 33);
            btnRegRes.TabIndex = 11;
            btnRegRes.Text = "Створити";
            btnRegRes.UseVisualStyleBackColor = true;
            btnRegRes.Click += button8_Click;
            // 
            // txtBManuf
            // 
            txtBManuf.Location = new Point(370, 182);
            txtBManuf.Name = "txtBManuf";
            txtBManuf.Size = new Size(157, 29);
            txtBManuf.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(283, 185);
            label13.Name = "label13";
            label13.Size = new Size(81, 21);
            label13.TabIndex = 9;
            label13.Text = "Виробник";
            // 
            // txtBPrice
            // 
            txtBPrice.Location = new Point(370, 147);
            txtBPrice.Name = "txtBPrice";
            txtBPrice.Size = new Size(157, 29);
            txtBPrice.TabIndex = 6;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(283, 147);
            label15.Name = "label15";
            label15.Size = new Size(43, 21);
            label15.TabIndex = 5;
            label15.Text = "Ціна";
            // 
            // txtBDesc
            // 
            txtBDesc.Location = new Point(370, 118);
            txtBDesc.Name = "txtBDesc";
            txtBDesc.Size = new Size(157, 29);
            txtBDesc.TabIndex = 4;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(283, 118);
            label16.Name = "label16";
            label16.Size = new Size(47, 21);
            label16.TabIndex = 3;
            label16.Text = "Опис";
            // 
            // txtBName
            // 
            txtBName.Location = new Point(370, 89);
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(157, 29);
            txtBName.TabIndex = 2;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(283, 89);
            label17.Name = "label17";
            label17.Size = new Size(52, 21);
            label17.TabIndex = 1;
            label17.Text = "Назва";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(382, 29);
            label18.Name = "label18";
            label18.Size = new Size(89, 21);
            label18.TabIndex = 0;
            label18.Text = "Інструмент";
            // 
            // pnlMaterial
            // 
            pnlMaterial.Controls.Add(button5);
            pnlMaterial.Controls.Add(textBox5);
            pnlMaterial.Controls.Add(label12);
            pnlMaterial.Controls.Add(textBox3);
            pnlMaterial.Controls.Add(label10);
            pnlMaterial.Controls.Add(textBox2);
            pnlMaterial.Controls.Add(label9);
            pnlMaterial.Controls.Add(textBox1);
            pnlMaterial.Controls.Add(label6);
            pnlMaterial.Controls.Add(label5);
            pnlMaterial.Font = new Font("Segoe UI", 12F);
            pnlMaterial.Location = new Point(3, 35);
            pnlMaterial.Name = "pnlMaterial";
            pnlMaterial.Size = new Size(872, 339);
            pnlMaterial.TabIndex = 5;
            // 
            // button5
            // 
            button5.Location = new Point(370, 283);
            button5.Name = "button5";
            button5.Size = new Size(104, 31);
            button5.TabIndex = 11;
            button5.Text = "Створити";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(411, 201);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(155, 29);
            textBox5.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(279, 204);
            label12.Name = "label12";
            label12.Size = new Size(125, 21);
            label12.TabIndex = 9;
            label12.Text = "Одиниці виміру";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(411, 167);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 29);
            textBox3.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(279, 170);
            label10.Name = "label10";
            label10.Size = new Size(43, 21);
            label10.TabIndex = 5;
            label10.Text = "Ціна";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(411, 132);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 29);
            textBox2.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(279, 132);
            label9.Name = "label9";
            label9.Size = new Size(47, 21);
            label9.TabIndex = 3;
            label9.Text = "Опис";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(411, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 29);
            textBox1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(279, 97);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 1;
            label6.Text = "Назва";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(385, 17);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 0;
            label5.Text = "Матеріал";
            // 
            // pnlTransport
            // 
            pnlTransport.Controls.Add(button9);
            pnlTransport.Controls.Add(textBox11);
            pnlTransport.Controls.Add(label19);
            pnlTransport.Controls.Add(textBox13);
            pnlTransport.Controls.Add(label21);
            pnlTransport.Controls.Add(textBox14);
            pnlTransport.Controls.Add(label22);
            pnlTransport.Controls.Add(textBox15);
            pnlTransport.Controls.Add(label23);
            pnlTransport.Controls.Add(label24);
            pnlTransport.Font = new Font("Segoe UI", 12F);
            pnlTransport.Location = new Point(0, 35);
            pnlTransport.Name = "pnlTransport";
            pnlTransport.Size = new Size(872, 339);
            pnlTransport.TabIndex = 13;
            pnlTransport.Visible = false;
            // 
            // button9
            // 
            button9.Location = new Point(370, 291);
            button9.Name = "button9";
            button9.Size = new Size(100, 33);
            button9.TabIndex = 11;
            button9.Text = "Створити";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(373, 216);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(146, 29);
            textBox11.TabIndex = 10;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(269, 219);
            label19.Name = "label19";
            label19.Size = new Size(102, 21);
            label19.TabIndex = 9;
            label19.Text = "Номер знаку";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(373, 184);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(146, 29);
            textBox13.TabIndex = 6;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(269, 184);
            label21.Name = "label21";
            label21.Size = new Size(43, 21);
            label21.TabIndex = 5;
            label21.Text = "Ціна";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(373, 155);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(146, 29);
            textBox14.TabIndex = 4;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(269, 155);
            label22.Name = "label22";
            label22.Size = new Size(47, 21);
            label22.TabIndex = 3;
            label22.Text = "Опис";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(373, 126);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(146, 29);
            textBox15.TabIndex = 2;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(269, 126);
            label23.Name = "label23";
            label23.Size = new Size(52, 21);
            label23.TabIndex = 1;
            label23.Text = "Назва";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(385, 29);
            label24.Name = "label24";
            label24.Size = new Size(85, 21);
            label24.TabIndex = 0;
            label24.Text = "Транспорт";
            // 
            // pageStock
            // 
            pageStock.Controls.Add(label14);
            pageStock.Controls.Add(cmbRes);
            pageStock.Controls.Add(label11);
            pageStock.Controls.Add(txtBCount);
            pageStock.Controls.Add(btnDelRes);
            pageStock.Controls.Add(btnAddRes);
            pageStock.Controls.Add(dgvStock);
            pageStock.Location = new Point(4, 24);
            pageStock.Name = "pageStock";
            pageStock.Size = new Size(878, 608);
            pageStock.TabIndex = 3;
            pageStock.Text = "Склад";
            pageStock.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(394, 17);
            label14.Name = "label14";
            label14.Size = new Size(53, 21);
            label14.TabIndex = 6;
            label14.Text = "Склад";
            // 
            // cmbRes
            // 
            cmbRes.Font = new Font("Segoe UI", 12F);
            cmbRes.FormattingEnabled = true;
            cmbRes.Location = new Point(319, 137);
            cmbRes.Name = "cmbRes";
            cmbRes.Size = new Size(203, 29);
            cmbRes.TabIndex = 5;
            cmbRes.SelectedValueChanged += comboBox4_SelectedValueChanged;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(260, 175);
            label11.Name = "label11";
            label11.Size = new Size(156, 21);
            label11.TabIndex = 4;
            label11.Text = "Кількість";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtBCount
            // 
            txtBCount.Font = new Font("Segoe UI", 12F);
            txtBCount.Location = new Point(422, 172);
            txtBCount.Name = "txtBCount";
            txtBCount.Size = new Size(100, 29);
            txtBCount.TabIndex = 3;
            // 
            // btnDelRes
            // 
            btnDelRes.Font = new Font("Segoe UI", 12F);
            btnDelRes.Location = new Point(431, 238);
            btnDelRes.Name = "btnDelRes";
            btnDelRes.Size = new Size(95, 37);
            btnDelRes.TabIndex = 2;
            btnDelRes.Text = "Списати";
            btnDelRes.UseVisualStyleBackColor = true;
            btnDelRes.Click += button14_Click;
            // 
            // btnAddRes
            // 
            btnAddRes.Font = new Font("Segoe UI", 12F);
            btnAddRes.Location = new Point(319, 238);
            btnAddRes.Name = "btnAddRes";
            btnAddRes.Size = new Size(106, 37);
            btnAddRes.TabIndex = 1;
            btnAddRes.Text = "Додати";
            btnAddRes.UseVisualStyleBackColor = true;
            btnAddRes.Click += button13_Click;
            // 
            // dgvStock
            // 
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvStock.DefaultCellStyle = dataGridViewCellStyle4;
            dgvStock.Dock = DockStyle.Bottom;
            dgvStock.Location = new Point(0, 367);
            dgvStock.Name = "dgvStock";
            dgvStock.Size = new Size(878, 241);
            dgvStock.TabIndex = 0;
            // 
            // InsertData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 636);
            Controls.Add(tabControl1);
            Name = "InsertData";
            Text = "Додавання даних";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpTT).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResTT).EndInit();
            pageRes.ResumeLayout(false);
            pageRes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRes).EndInit();
            pnlTools.ResumeLayout(false);
            pnlTools.PerformLayout();
            pnlMaterial.ResumeLayout(false);
            pnlMaterial.PerformLayout();
            pnlTransport.ResumeLayout(false);
            pnlTransport.PerformLayout();
            pageStock.ResumeLayout(false);
            pageStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private TabPage pageRes;
        private DateTimePicker dtp2ETT;
        private Label label8;
        private DateTimePicker dtpETT;
        private Label label7;
        private ComboBox cmbEmpTT;
        private Label label2;
        private Button btnCheck;
        private Button btnAddEmpTT;
        private Button btnRefrEmpTT;
        private DataGridView dgvEmpTT;
        private DataGridView dgvRes;
        private Label label4;
        private ComboBox cmbTypeRes;
        private Panel pnlMaterial;
        private TextBox textBox2;
        private Label label9;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private TextBox textBox3;
        private Label label10;
        private TextBox textBox5;
        private Label label12;
        private Button btnUpdResDgv;
        private Button btnCntResDvg;
        private Label lblCountRes;
        private Button button5;
        private Panel pnlTools;
        private Button btnRegRes;
        private TextBox txtBManuf;
        private Label label13;
        private TextBox txtBPrice;
        private Label label15;
        private TextBox txtBDesc;
        private Label label16;
        private TextBox txtBName;
        private Label label17;
        private Label label18;
        private Panel pnlTransport;
        private Button button9;
        private TextBox textBox11;
        private Label label19;
        private TextBox textBox13;
        private Label label21;
        private TextBox textBox14;
        private Label label22;
        private TextBox textBox15;
        private Label label23;
        private Label label24;
        private TabPage tabPage3;
        private DataGridView dgvResTT;
        private Button btnRefrResTT;
        private Button btnAddResTT;
        private Label label28;
        private Button btnCheckResTT;
        private ComboBox cmbResTT;
        private DateTimePicker dtp2ResTT;
        private Label label25;
        private DateTimePicker dtp1ResTT;
        private Label label26;
        private Label label27;
        private TextBox txtBResTTCount;
        private Label label29;
        private TabPage pageStock;
        private DataGridView dgvStock;
        private ComboBox cmbRes;
        private Label label11;
        private TextBox txtBCount;
        private Button btnDelRes;
        private Button btnAddRes;
        private Label label14;
    }
}