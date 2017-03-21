namespace Memory
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStart2x2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStart4x4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStart6x6 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStart8x8 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStart10x10 = new System.Windows.Forms.ToolStripMenuItem();
            this.gameTable = new System.Windows.Forms.TableLayoutPanel();
            this.hideCardsTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startNewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startNewToolStripMenuItem
            // 
            this.startNewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStart2x2,
            this.menuStart4x4,
            this.menuStart6x6,
            this.menuStart8x8,
            this.menuStart10x10});
            this.startNewToolStripMenuItem.Name = "startNewToolStripMenuItem";
            this.startNewToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.startNewToolStripMenuItem.Text = "Start New";
            // 
            // menuStart2x2
            // 
            this.menuStart2x2.Name = "menuStart2x2";
            this.menuStart2x2.Size = new System.Drawing.Size(103, 22);
            this.menuStart2x2.Text = "2x2";
            this.menuStart2x2.Click += new System.EventHandler(this.menuStart2x2_Click);
            // 
            // menuStart4x4
            // 
            this.menuStart4x4.Name = "menuStart4x4";
            this.menuStart4x4.Size = new System.Drawing.Size(103, 22);
            this.menuStart4x4.Text = "4x4";
            this.menuStart4x4.Click += new System.EventHandler(this.menuStart4x4_Click);
            // 
            // menuStart6x6
            // 
            this.menuStart6x6.Name = "menuStart6x6";
            this.menuStart6x6.Size = new System.Drawing.Size(103, 22);
            this.menuStart6x6.Text = "6x6";
            this.menuStart6x6.Click += new System.EventHandler(this.menuStart6x6_Click);
            // 
            // menuStart8x8
            // 
            this.menuStart8x8.Name = "menuStart8x8";
            this.menuStart8x8.Size = new System.Drawing.Size(103, 22);
            this.menuStart8x8.Text = "8x8";
            this.menuStart8x8.Click += new System.EventHandler(this.menuStart8x8_Click);
            // 
            // menuStart10x10
            // 
            this.menuStart10x10.Name = "menuStart10x10";
            this.menuStart10x10.Size = new System.Drawing.Size(103, 22);
            this.menuStart10x10.Text = "10x10";
            this.menuStart10x10.Click += new System.EventHandler(this.menuStart10x10_Click);
            // 
            // gameTable
            // 
            this.gameTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameTable.ColumnCount = 2;
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameTable.Location = new System.Drawing.Point(12, 27);
            this.gameTable.Name = "gameTable";
            this.gameTable.RowCount = 2;
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gameTable.Size = new System.Drawing.Size(583, 424);
            this.gameTable.TabIndex = 1;
            this.gameTable.Paint += new System.Windows.Forms.PaintEventHandler(this.gameTable_Paint);
            // 
            // hideCardsTimer
            // 
            this.hideCardsTimer.Interval = 1000;
            this.hideCardsTimer.Tick += new System.EventHandler(this.hideCardsTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 463);
            this.Controls.Add(this.gameTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Memory";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStart2x2;
        private System.Windows.Forms.ToolStripMenuItem menuStart4x4;
        private System.Windows.Forms.ToolStripMenuItem menuStart6x6;
        private System.Windows.Forms.ToolStripMenuItem menuStart8x8;
        private System.Windows.Forms.ToolStripMenuItem menuStart10x10;
        private System.Windows.Forms.TableLayoutPanel gameTable;
        private System.Windows.Forms.Timer hideCardsTimer;
    }
}

