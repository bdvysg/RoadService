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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            додатиНовеЗавданняToolStripMenuItem = new ToolStripMenuItem();
            додатиДаніToolStripMenuItem = new ToolStripMenuItem();
            оновитиToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 426);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { додатиНовеЗавданняToolStripMenuItem, додатиДаніToolStripMenuItem, оновитиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // додатиНовеЗавданняToolStripMenuItem
            // 
            додатиНовеЗавданняToolStripMenuItem.Name = "додатиНовеЗавданняToolStripMenuItem";
            додатиНовеЗавданняToolStripMenuItem.Size = new Size(139, 20);
            додатиНовеЗавданняToolStripMenuItem.Text = "Додати нове завдання";
            додатиНовеЗавданняToolStripMenuItem.Click += додатиНовеЗавданняToolStripMenuItem_Click;
            // 
            // додатиДаніToolStripMenuItem
            // 
            додатиДаніToolStripMenuItem.Name = "додатиДаніToolStripMenuItem";
            додатиДаніToolStripMenuItem.Size = new Size(83, 20);
            додатиДаніToolStripMenuItem.Text = "Додати дані";
            додатиДаніToolStripMenuItem.Click += додатиДаніToolStripMenuItem_Click;
            // 
            // оновитиToolStripMenuItem
            // 
            оновитиToolStripMenuItem.Name = "оновитиToolStripMenuItem";
            оновитиToolStripMenuItem.Size = new Size(67, 20);
            оновитиToolStripMenuItem.Text = "Оновити";
            оновитиToolStripMenuItem.Click += оновитиToolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Form1";
            FormClosed += Main_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem додатиНовеЗавданняToolStripMenuItem;
        private ToolStripMenuItem додатиДаніToolStripMenuItem;
        private ToolStripMenuItem оновитиToolStripMenuItem;
    }
}
