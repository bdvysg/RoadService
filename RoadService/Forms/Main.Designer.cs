namespace RoadService
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dgv = new DataGridView();
            menuStrip1 = new MenuStrip();
            додатиНовеЗавданняToolStripMenuItem = new ToolStripMenuItem();
            додатиДаніToolStripMenuItem = new ToolStripMenuItem();
            оновитиToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            видалитиToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgv);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle2;
            dgv.Dock = DockStyle.Fill;
            dgv.Location = new Point(0, 29);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.Size = new Size(800, 421);
            dgv.TabIndex = 0;
            dgv.CellDoubleClick += dgv_CellDoubleClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { додатиНовеЗавданняToolStripMenuItem, додатиДаніToolStripMenuItem, оновитиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 29);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // додатиНовеЗавданняToolStripMenuItem
            // 
            додатиНовеЗавданняToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            додатиНовеЗавданняToolStripMenuItem.Name = "додатиНовеЗавданняToolStripMenuItem";
            додатиНовеЗавданняToolStripMenuItem.Size = new Size(183, 25);
            додатиНовеЗавданняToolStripMenuItem.Text = "Додати нове завдання";
            додатиНовеЗавданняToolStripMenuItem.Click += додатиНовеЗавданняToolStripMenuItem_Click;
            // 
            // додатиДаніToolStripMenuItem
            // 
            додатиДаніToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            додатиДаніToolStripMenuItem.Name = "додатиДаніToolStripMenuItem";
            додатиДаніToolStripMenuItem.Size = new Size(109, 25);
            додатиДаніToolStripMenuItem.Text = "Додати дані";
            додатиДаніToolStripMenuItem.Click += додатиДаніToolStripMenuItem_Click;
            // 
            // оновитиToolStripMenuItem
            // 
            оновитиToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            оновитиToolStripMenuItem.Name = "оновитиToolStripMenuItem";
            оновитиToolStripMenuItem.Size = new Size(85, 25);
            оновитиToolStripMenuItem.Text = "Оновити";
            оновитиToolStripMenuItem.Click += оновитиToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { видалитиToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(127, 26);
            // 
            // видалитиToolStripMenuItem
            // 
            видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            видалитиToolStripMenuItem.Size = new Size(126, 22);
            видалитиToolStripMenuItem.Text = "Видалити";
            видалитиToolStripMenuItem.Click += видалитиToolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Список завдань";
            FormClosed += Main_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgv;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem додатиНовеЗавданняToolStripMenuItem;
        private ToolStripMenuItem додатиДаніToolStripMenuItem;
        private ToolStripMenuItem оновитиToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem видалитиToolStripMenuItem;
    }
}
