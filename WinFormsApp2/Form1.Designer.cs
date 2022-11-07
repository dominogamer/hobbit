namespace WinFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.bnt1 = new System.Windows.Forms.Button();
            this.bnt2 = new System.Windows.Forms.Button();
            this.bnt3 = new System.Windows.Forms.Button();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.usuńWybraneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(120, 66);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 15);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Tytuł:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(120, 96);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(49, 15);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Reżyser:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(322, 66);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(83, 15);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "data premiery:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(322, 99);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(99, 15);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "główny aktor(ka):";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(178, 63);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 23);
            this.txt1.TabIndex = 4;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(178, 91);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 23);
            this.txt2.TabIndex = 5;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(420, 93);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(100, 23);
            this.txt4.TabIndex = 7;
            // 
            // bnt1
            // 
            this.bnt1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bnt1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bnt1.Location = new System.Drawing.Point(459, 144);
            this.bnt1.Name = "bnt1";
            this.bnt1.Size = new System.Drawing.Size(75, 29);
            this.bnt1.TabIndex = 8;
            this.bnt1.Text = "dodaj";
            this.bnt1.UseVisualStyleBackColor = false;
            this.bnt1.Click += new System.EventHandler(this.bnt1_Click);
            // 
            // bnt2
            // 
            this.bnt2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bnt2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bnt2.Location = new System.Drawing.Point(420, 391);
            this.bnt2.Name = "bnt2";
            this.bnt2.Size = new System.Drawing.Size(91, 36);
            this.bnt2.TabIndex = 9;
            this.bnt2.Text = "zapisz";
            this.bnt2.UseVisualStyleBackColor = false;
            this.bnt2.Click += new System.EventHandler(this.bnt2_Click);
            // 
            // bnt3
            // 
            this.bnt3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bnt3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bnt3.Location = new System.Drawing.Point(526, 391);
            this.bnt3.Name = "bnt3";
            this.bnt3.Size = new System.Drawing.Size(89, 36);
            this.bnt3.TabIndex = 10;
            this.bnt3.Text = "zamknij";
            this.bnt3.UseVisualStyleBackColor = false;
            // 
            // dt1
            // 
            this.dt1.Location = new System.Drawing.Point(415, 64);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(200, 23);
            this.dt1.TabIndex = 11;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(193, 199);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(451, 165);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tytuł:";
            this.columnHeader1.Width = 190;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Reżyser:";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "datapremiery";
            this.columnHeader3.Width = 180;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuńWybraneToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // usuńWybraneToolStripMenuItem
            // 
            this.usuńWybraneToolStripMenuItem.Name = "usuńWybraneToolStripMenuItem";
            this.usuńWybraneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuńWybraneToolStripMenuItem.Text = "usuń wybrane";
            this.usuńWybraneToolStripMenuItem.Click += new System.EventHandler(this.usuńWybraneToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dt1);
            this.Controls.Add(this.bnt3);
            this.Controls.Add(this.bnt2);
            this.Controls.Add(this.bnt1);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
        private TextBox txt1;
        private TextBox txt2;
        private TextBox txt4;
        private Button bnt1;
        private Button bnt2;
        private Button bnt3;
        private DateTimePicker dt1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem usuńWybraneToolStripMenuItem;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}