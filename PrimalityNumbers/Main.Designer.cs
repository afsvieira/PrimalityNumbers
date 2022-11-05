using FermatPrimalityTest;

namespace PrimalityNumbers
{
    partial class Main
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
            this.lbNumbers = new System.Windows.Forms.Label();
            this.tbNumbers = new System.Windows.Forms.TextBox();
            this.btChecker = new System.Windows.Forms.Button();
            this.btLoadFile = new System.Windows.Forms.Button();
            this.lvReport = new System.Windows.Forms.ListView();
            this.Number = new System.Windows.Forms.ColumnHeader();
            this.lbReport = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNumbers
            // 
            this.lbNumbers.AutoSize = true;
            this.lbNumbers.Location = new System.Drawing.Point(12, 34);
            this.lbNumbers.Name = "lbNumbers";
            this.lbNumbers.Size = new System.Drawing.Size(67, 15);
            this.lbNumbers.TabIndex = 0;
            this.lbNumbers.Text = "Number(s):";
            // 
            // tbNumbers
            // 
            this.tbNumbers.Location = new System.Drawing.Point(85, 31);
            this.tbNumbers.Name = "tbNumbers";
            this.tbNumbers.Size = new System.Drawing.Size(218, 23);
            this.tbNumbers.TabIndex = 1;
            this.tbNumbers.Text = "Type the numbers to check (i.e: 1,2,3,4...)";
            // 
            // btChecker
            // 
            this.btChecker.Location = new System.Drawing.Point(90, 60);
            this.btChecker.Name = "btChecker";
            this.btChecker.Size = new System.Drawing.Size(75, 29);
            this.btChecker.TabIndex = 2;
            this.btChecker.Text = "Check";
            this.btChecker.UseVisualStyleBackColor = true;
            this.btChecker.Click += new System.EventHandler(this.btChecker_Click);
            // 
            // btLoadFile
            // 
            this.btLoadFile.Location = new System.Drawing.Point(171, 60);
            this.btLoadFile.Name = "btLoadFile";
            this.btLoadFile.Size = new System.Drawing.Size(75, 29);
            this.btLoadFile.TabIndex = 3;
            this.btLoadFile.Text = "Load File";
            this.btLoadFile.UseVisualStyleBackColor = true;
            this.btLoadFile.Click += new System.EventHandler(this.btLoadFile_Click);
            // 
            // lvReport
            // 
            this.lvReport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number});
            this.lvReport.Location = new System.Drawing.Point(12, 121);
            this.lvReport.Name = "lvReport";
            this.lvReport.Size = new System.Drawing.Size(291, 97);
            this.lvReport.TabIndex = 4;
            this.lvReport.TileSize = new System.Drawing.Size(260, 22);
            this.lvReport.UseCompatibleStateImageBehavior = false;
            this.lvReport.View = System.Windows.Forms.View.Tile;
            // 
            // lbReport
            // 
            this.lbReport.AutoSize = true;
            this.lbReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbReport.Location = new System.Drawing.Point(140, 103);
            this.lbReport.Name = "lbReport";
            this.lbReport.Size = new System.Drawing.Size(52, 15);
            this.lbReport.TabIndex = 5;
            this.lbReport.Text = "REPORT";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(90, 229);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(171, 229);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(318, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItem
            // 
            this.menuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newReportToolStripMenuItem,
            this.loadFileToolStripMenuItem,
            this.saveReportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuItem.Name = "menuItem";
            this.menuItem.Size = new System.Drawing.Size(50, 20);
            this.menuItem.Text = "Menu";
            // 
            // newReportToolStripMenuItem
            // 
            this.newReportToolStripMenuItem.Name = "newReportToolStripMenuItem";
            this.newReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newReportToolStripMenuItem.Text = "New report";
            this.newReportToolStripMenuItem.Click += new System.EventHandler(this.newReportToolStripMenuItem_Click);
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadFileToolStripMenuItem.Text = "Load file";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // saveReportToolStripMenuItem
            // 
            this.saveReportToolStripMenuItem.Name = "saveReportToolStripMenuItem";
            this.saveReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveReportToolStripMenuItem.Text = "Save report";
            this.saveReportToolStripMenuItem.Click += new System.EventHandler(this.saveReportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 266);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbReport);
            this.Controls.Add(this.lvReport);
            this.Controls.Add(this.btLoadFile);
            this.Controls.Add(this.btChecker);
            this.Controls.Add(this.tbNumbers);
            this.Controls.Add(this.lbNumbers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Primality Checker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbNumbers;
        private TextBox tbNumbers;
        private Button btChecker;
        private Button btLoadFile;
        private ListView lvReport;
        private Label lbReport;
        private Button btSave;
        private Button btCancel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuItem;
        private ToolStripMenuItem newReportToolStripMenuItem;
        private ToolStripMenuItem loadFileToolStripMenuItem;
        private ToolStripMenuItem saveReportToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ColumnHeader Number;
    }
}