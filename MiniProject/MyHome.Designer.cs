namespace MiniProject
{
    partial class MyHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluateIndividualsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.instructorToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.evaluationToolStripMenuItem,
            this.evaluateIndividualsToolStripMenuItem,
            this.projectToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(3, 54);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(125, 198);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(122, 19);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // instructorToolStripMenuItem
            // 
            this.instructorToolStripMenuItem.Name = "instructorToolStripMenuItem";
            this.instructorToolStripMenuItem.Size = new System.Drawing.Size(122, 19);
            this.instructorToolStripMenuItem.Text = "Advisor";
            this.instructorToolStripMenuItem.Click += new System.EventHandler(this.instructorToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentsToolStripMenuItem,
            this.studentRecordToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(122, 19);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // addStudentsToolStripMenuItem
            // 
            this.addStudentsToolStripMenuItem.Name = "addStudentsToolStripMenuItem";
            this.addStudentsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.addStudentsToolStripMenuItem.Text = "Add Students";
            this.addStudentsToolStripMenuItem.Click += new System.EventHandler(this.addStudentsToolStripMenuItem_Click);
            // 
            // studentRecordToolStripMenuItem
            // 
            this.studentRecordToolStripMenuItem.Name = "studentRecordToolStripMenuItem";
            this.studentRecordToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.studentRecordToolStripMenuItem.Text = "Student Record";
            this.studentRecordToolStripMenuItem.Click += new System.EventHandler(this.studentRecordToolStripMenuItem_Click);
            // 
            // evaluationToolStripMenuItem
            // 
            this.evaluationToolStripMenuItem.Name = "evaluationToolStripMenuItem";
            this.evaluationToolStripMenuItem.Size = new System.Drawing.Size(122, 19);
            this.evaluationToolStripMenuItem.Text = "Evaluation";
            this.evaluationToolStripMenuItem.Click += new System.EventHandler(this.evaluationToolStripMenuItem_Click);
            // 
            // evaluateIndividualsToolStripMenuItem
            // 
            this.evaluateIndividualsToolStripMenuItem.Name = "evaluateIndividualsToolStripMenuItem";
            this.evaluateIndividualsToolStripMenuItem.Size = new System.Drawing.Size(122, 19);
            this.evaluateIndividualsToolStripMenuItem.Text = "Evaluate Individuals";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 150);
            this.toolStripContainer1.Location = new System.Drawing.Point(3, 87);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.TabIndex = 7;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "FYP Management System(Mini Project)";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProjectToolStripMenuItem,
            this.projectRecordsToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(118, 19);
            this.projectToolStripMenuItem.Text = "Project";
            this.projectToolStripMenuItem.Click += new System.EventHandler(this.projectToolStripMenuItem_Click);
            // 
            // addProjectToolStripMenuItem
            // 
            this.addProjectToolStripMenuItem.Name = "addProjectToolStripMenuItem";
            this.addProjectToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.addProjectToolStripMenuItem.Text = "Add Project";
            this.addProjectToolStripMenuItem.Click += new System.EventHandler(this.addProjectToolStripMenuItem_Click);
            // 
            // projectRecordsToolStripMenuItem
            // 
            this.projectRecordsToolStripMenuItem.Name = "projectRecordsToolStripMenuItem";
            this.projectRecordsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.projectRecordsToolStripMenuItem.Text = "Project Records";
            this.projectRecordsToolStripMenuItem.Click += new System.EventHandler(this.projectRecordsToolStripMenuItem_Click);
            // 
            // MyHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 261);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MyHome";
            this.Text = "MyHome";
            this.Load += new System.EventHandler(this.MyHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluateIndividualsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectRecordsToolStripMenuItem;
    }
}