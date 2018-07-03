namespace VisualMan
{
    partial class Window
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
            this.browseButton = new System.Windows.Forms.Button();
            this.enterSource = new System.Windows.Forms.TextBox();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.writeBox = new System.Windows.Forms.CheckBox();
            this.dryRunTip = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.renameTab = new System.Windows.Forms.TabPage();
            this.convertTab = new System.Windows.Forms.TabPage();
            this.aboutTab = new System.Windows.Forms.TabPage();
            this.author = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.renameTab.SuspendLayout();
            this.aboutTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(708, 398);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 20);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // enterSource
            // 
            this.enterSource.Location = new System.Drawing.Point(7, 398);
            this.enterSource.Name = "enterSource";
            this.enterSource.Size = new System.Drawing.Size(690, 20);
            this.enterSource.TabIndex = 1;
            this.enterSource.Leave += new System.EventHandler(this.enterSource_Leave);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(7, 8);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputBox.Size = new System.Drawing.Size(550, 355);
            this.outputBox.TabIndex = 2;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(482, 369);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 3;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // writeBox
            // 
            this.writeBox.AutoSize = true;
            this.writeBox.Location = new System.Drawing.Point(575, 10);
            this.writeBox.Name = "writeBox";
            this.writeBox.Size = new System.Drawing.Size(65, 17);
            this.writeBox.TabIndex = 4;
            this.writeBox.Text = "Dry Run";
            this.writeBox.UseVisualStyleBackColor = true;
            this.writeBox.CheckedChanged += new System.EventHandler(this.writeBox_CheckedChanged);
            this.writeBox.MouseEnter += new System.EventHandler(this.writeBox_MouseEnter);
            // 
            // dryRunTip
            // 
            this.dryRunTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.dryRunTip.ToolTipTitle = "Dry Run:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.renameTab);
            this.tabControl1.Controls.Add(this.convertTab);
            this.tabControl1.Controls.Add(this.aboutTab);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 450);
            this.tabControl1.TabIndex = 5;
            // 
            // renameTab
            // 
            this.renameTab.BackColor = System.Drawing.SystemColors.ControlDark;
            this.renameTab.Controls.Add(this.outputBox);
            this.renameTab.Controls.Add(this.enterSource);
            this.renameTab.Controls.Add(this.runButton);
            this.renameTab.Controls.Add(this.browseButton);
            this.renameTab.Controls.Add(this.writeBox);
            this.renameTab.Location = new System.Drawing.Point(4, 22);
            this.renameTab.Name = "renameTab";
            this.renameTab.Padding = new System.Windows.Forms.Padding(3);
            this.renameTab.Size = new System.Drawing.Size(794, 424);
            this.renameTab.TabIndex = 0;
            this.renameTab.Text = "Renamer";
            // 
            // convertTab
            // 
            this.convertTab.BackColor = System.Drawing.SystemColors.ControlDark;
            this.convertTab.Location = new System.Drawing.Point(4, 22);
            this.convertTab.Name = "convertTab";
            this.convertTab.Padding = new System.Windows.Forms.Padding(3);
            this.convertTab.Size = new System.Drawing.Size(794, 424);
            this.convertTab.TabIndex = 1;
            this.convertTab.Text = "Convert";
            // 
            // aboutTab
            // 
            this.aboutTab.BackColor = System.Drawing.SystemColors.ControlDark;
            this.aboutTab.Controls.Add(this.link);
            this.aboutTab.Controls.Add(this.author);
            this.aboutTab.Location = new System.Drawing.Point(4, 22);
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.Size = new System.Drawing.Size(794, 424);
            this.aboutTab.TabIndex = 2;
            this.aboutTab.Text = "About";
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author.Location = new System.Drawing.Point(18, 14);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(180, 25);
            this.author.TabIndex = 0;
            this.author.Text = "Made by: tbejos";
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link.Location = new System.Drawing.Point(18, 56);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(633, 25);
            this.link.TabIndex = 1;
            this.link.Text = "Get updates from: https://www.github.com/tbejos/VideoMan";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Window";
            this.Text = "Visual Media Manager";
            this.Load += new System.EventHandler(this.Windows_Load);
            this.tabControl1.ResumeLayout(false);
            this.renameTab.ResumeLayout(false);
            this.renameTab.PerformLayout();
            this.aboutTab.ResumeLayout(false);
            this.aboutTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox enterSource;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.CheckBox writeBox;
        private System.Windows.Forms.ToolTip dryRunTip;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage renameTab;
        private System.Windows.Forms.TabPage convertTab;
        private System.Windows.Forms.TabPage aboutTab;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label link;
    }
}

