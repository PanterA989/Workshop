
namespace Workshop.UserInterface.Forms
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jedenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnCall = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.panelTop = new System.Windows.Forms.Panel();
            this.placeholderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeholderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.placeholderToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.placeholderToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.placeholderToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.placeholderToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.placeholderToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.placeholderToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.placeholderToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.placeholderToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.placeholderToolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.placeholderToolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.placeholderToolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.placeholderToolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1080, 521);
            this.dataGridView1.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.dataGridView1);
            this.panelLeft.Controls.Add(this.menuStrip1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(1080, 545);
            this.panelLeft.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jedenToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // jedenToolStripMenuItem
            // 
            this.jedenToolStripMenuItem.Name = "jedenToolStripMenuItem";
            this.jedenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jedenToolStripMenuItem.Text = "jeden";
            // 
            // panelRight
            // 
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.btnCall);
            this.panelRight.Controls.Add(this.btnHistory);
            this.panelRight.Controls.Add(this.btnFinish);
            this.panelRight.Controls.Add(this.btnEdit);
            this.panelRight.Controls.Add(this.btnAdd);
            this.panelRight.Controls.Add(this.statusStrip1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(880, 24);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(200, 521);
            this.panelRight.TabIndex = 3;
            // 
            // btnCall
            // 
            this.btnCall.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCall.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCall.Image = global::Workshop.UserInterface.Properties.Resources.phone64;
            this.btnCall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCall.Location = new System.Drawing.Point(0, 417);
            this.btnCall.Name = "btnCall";
            this.btnCall.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCall.Size = new System.Drawing.Size(198, 80);
            this.btnCall.TabIndex = 4;
            this.btnCall.Text = "Zadzwoń";
            this.btnCall.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCall.UseVisualStyleBackColor = true;
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHistory.Image = global::Workshop.UserInterface.Properties.Resources.history64;
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.Location = new System.Drawing.Point(-2, 257);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHistory.Size = new System.Drawing.Size(200, 80);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "Historia zleceń";
            this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistory.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFinish.Image = global::Workshop.UserInterface.Properties.Resources.checked64;
            this.btnFinish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinish.Location = new System.Drawing.Point(-2, 171);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnFinish.Size = new System.Drawing.Size(200, 80);
            this.btnFinish.TabIndex = 2;
            this.btnFinish.Text = "Zakończ";
            this.btnFinish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinish.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdit.Image = global::Workshop.UserInterface.Properties.Resources.edit64;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(-2, 85);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEdit.Size = new System.Drawing.Size(200, 80);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Image = global::Workshop.UserInterface.Properties.Resources.add64;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(-2, -1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(200, 80);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(198, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(183, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Wersja: 1.0.0";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeholderToolStripMenuItem,
            this.placeholderToolStripMenuItem3,
            this.placeholderToolStripMenuItem6,
            this.placeholderToolStripMenuItem7});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1080, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip2";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.menuStrip);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1080, 24);
            this.panelTop.TabIndex = 2;
            // 
            // placeholderToolStripMenuItem
            // 
            this.placeholderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeholderToolStripMenuItem1,
            this.placeholderToolStripMenuItem2});
            this.placeholderToolStripMenuItem.Name = "placeholderToolStripMenuItem";
            this.placeholderToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.placeholderToolStripMenuItem.Text = "Placeholder";
            // 
            // placeholderToolStripMenuItem1
            // 
            this.placeholderToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeholderToolStripMenuItem9,
            this.placeholderToolStripMenuItem10});
            this.placeholderToolStripMenuItem1.Image = global::Workshop.UserInterface.Properties.Resources.add24;
            this.placeholderToolStripMenuItem1.Name = "placeholderToolStripMenuItem1";
            this.placeholderToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.placeholderToolStripMenuItem1.Text = "Placeholder";
            // 
            // placeholderToolStripMenuItem2
            // 
            this.placeholderToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeholderToolStripMenuItem11,
            this.placeholderToolStripMenuItem12,
            this.placeholderToolStripMenuItem13});
            this.placeholderToolStripMenuItem2.Name = "placeholderToolStripMenuItem2";
            this.placeholderToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.placeholderToolStripMenuItem2.Text = "Placeholder";
            // 
            // placeholderToolStripMenuItem3
            // 
            this.placeholderToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeholderToolStripMenuItem4,
            this.placeholderToolStripMenuItem5});
            this.placeholderToolStripMenuItem3.Name = "placeholderToolStripMenuItem3";
            this.placeholderToolStripMenuItem3.Size = new System.Drawing.Size(81, 20);
            this.placeholderToolStripMenuItem3.Text = "Placeholder";
            // 
            // placeholderToolStripMenuItem4
            // 
            this.placeholderToolStripMenuItem4.Name = "placeholderToolStripMenuItem4";
            this.placeholderToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.placeholderToolStripMenuItem4.Text = "Placeholder";
            // 
            // placeholderToolStripMenuItem5
            // 
            this.placeholderToolStripMenuItem5.Name = "placeholderToolStripMenuItem5";
            this.placeholderToolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.placeholderToolStripMenuItem5.Text = "Placeholder";
            // 
            // placeholderToolStripMenuItem6
            // 
            this.placeholderToolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeholderToolStripMenuItem8});
            this.placeholderToolStripMenuItem6.Name = "placeholderToolStripMenuItem6";
            this.placeholderToolStripMenuItem6.Size = new System.Drawing.Size(81, 20);
            this.placeholderToolStripMenuItem6.Text = "Placeholder";
            // 
            // placeholderToolStripMenuItem7
            // 
            this.placeholderToolStripMenuItem7.Name = "placeholderToolStripMenuItem7";
            this.placeholderToolStripMenuItem7.Size = new System.Drawing.Size(81, 20);
            this.placeholderToolStripMenuItem7.Text = "Placeholder";
            // 
            // placeholderToolStripMenuItem8
            // 
            this.placeholderToolStripMenuItem8.Name = "placeholderToolStripMenuItem8";
            this.placeholderToolStripMenuItem8.Size = new System.Drawing.Size(180, 22);
            this.placeholderToolStripMenuItem8.Text = "Placeholder";
            // 
            // placeholderToolStripMenuItem9
            // 
            this.placeholderToolStripMenuItem9.Name = "placeholderToolStripMenuItem9";
            this.placeholderToolStripMenuItem9.Size = new System.Drawing.Size(180, 22);
            this.placeholderToolStripMenuItem9.Text = "Placeholder";
            // 
            // placeholderToolStripMenuItem10
            // 
            this.placeholderToolStripMenuItem10.Name = "placeholderToolStripMenuItem10";
            this.placeholderToolStripMenuItem10.Size = new System.Drawing.Size(180, 22);
            this.placeholderToolStripMenuItem10.Text = "Placeholder";
            // 
            // placeholderToolStripMenuItem11
            // 
            this.placeholderToolStripMenuItem11.Name = "placeholderToolStripMenuItem11";
            this.placeholderToolStripMenuItem11.Size = new System.Drawing.Size(180, 22);
            this.placeholderToolStripMenuItem11.Text = "Placeholder";
            // 
            // placeholderToolStripMenuItem12
            // 
            this.placeholderToolStripMenuItem12.Name = "placeholderToolStripMenuItem12";
            this.placeholderToolStripMenuItem12.Size = new System.Drawing.Size(180, 22);
            this.placeholderToolStripMenuItem12.Text = "Placeholder";
            // 
            // placeholderToolStripMenuItem13
            // 
            this.placeholderToolStripMenuItem13.Name = "placeholderToolStripMenuItem13";
            this.placeholderToolStripMenuItem13.Size = new System.Drawing.Size(180, 22);
            this.placeholderToolStripMenuItem13.Text = "Placeholder";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 545);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1096, 584);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jedenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ToolStripMenuItem placeholderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeholderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem placeholderToolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem placeholderToolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem placeholderToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem placeholderToolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem placeholderToolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem placeholderToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem placeholderToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem placeholderToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem placeholderToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem placeholderToolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem placeholderToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem placeholderToolStripMenuItem13;
    }
}