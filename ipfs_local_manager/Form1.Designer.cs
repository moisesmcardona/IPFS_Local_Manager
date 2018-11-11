namespace ipfs_uploader
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
            this.label1 = new System.Windows.Forms.Label();
            this.ipfs_path_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UploadBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FoldersListBox = new System.Windows.Forms.ListBox();
            this.FolderListBoxContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FilesListBox = new System.Windows.Forms.ListBox();
            this.FilesListBoxContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RemoveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.UploadQueue = new System.Windows.Forms.ListBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.NewFolderButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.FolderListBoxContextMenu.SuspendLayout();
            this.FilesListBoxContextMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IPFS Path:";
            // 
            // ipfs_path_txt
            // 
            this.ipfs_path_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipfs_path_txt.Location = new System.Drawing.Point(9, 26);
            this.ipfs_path_txt.Name = "ipfs_path_txt";
            this.ipfs_path_txt.Size = new System.Drawing.Size(538, 20);
            this.ipfs_path_txt.TabIndex = 1;
            this.ipfs_path_txt.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Upload Queue:";
            // 
            // UploadBtn
            // 
            this.UploadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UploadBtn.Location = new System.Drawing.Point(9, 52);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(538, 23);
            this.UploadBtn.TabIndex = 5;
            this.UploadBtn.Text = "upload";
            this.UploadBtn.UseVisualStyleBackColor = true;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FoldersListBox
            // 
            this.FoldersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FoldersListBox.ContextMenuStrip = this.FolderListBoxContextMenu;
            this.FoldersListBox.FormattingEnabled = true;
            this.FoldersListBox.Location = new System.Drawing.Point(3, 23);
            this.FoldersListBox.Name = "FoldersListBox";
            this.FoldersListBox.Size = new System.Drawing.Size(538, 186);
            this.FoldersListBox.TabIndex = 6;
            this.FoldersListBox.DoubleClick += new System.EventHandler(this.FoldersListBox_DoubleClick);
            // 
            // FolderListBoxContextMenu
            // 
            this.FolderListBoxContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.FolderListBoxContextMenu.Name = "FolderListBoxContextMenu";
            this.FolderListBoxContextMenu.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Folders:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Files:";
            // 
            // FilesListBox
            // 
            this.FilesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesListBox.ContextMenuStrip = this.FilesListBoxContextMenu;
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.Location = new System.Drawing.Point(6, 19);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.Size = new System.Drawing.Size(535, 186);
            this.FilesListBox.TabIndex = 8;
            this.FilesListBox.DoubleClick += new System.EventHandler(this.FilesListBox_DoubleClick);
            // 
            // FilesListBoxContextMenu
            // 
            this.FilesListBoxContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveFile});
            this.FilesListBoxContextMenu.Name = "FolderListBoxContextMenu";
            this.FilesListBoxContextMenu.Size = new System.Drawing.Size(118, 26);
            // 
            // RemoveFile
            // 
            this.RemoveFile.Name = "RemoveFile";
            this.RemoveFile.Size = new System.Drawing.Size(117, 22);
            this.RemoveFile.Text = "Remove";
            this.RemoveFile.Click += new System.EventHandler(this.RemoveFile_Click);
            // 
            // UploadQueue
            // 
            this.UploadQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UploadQueue.FormattingEnabled = true;
            this.UploadQueue.Location = new System.Drawing.Point(9, 23);
            this.UploadQueue.Name = "UploadQueue";
            this.UploadQueue.Size = new System.Drawing.Size(538, 199);
            this.UploadQueue.TabIndex = 10;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton.Location = new System.Drawing.Point(3, 222);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(87, 23);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // NewFolderButton
            // 
            this.NewFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewFolderButton.Location = new System.Drawing.Point(96, 222);
            this.NewFolderButton.Name = "NewFolderButton";
            this.NewFolderButton.Size = new System.Drawing.Size(87, 23);
            this.NewFolderButton.TabIndex = 12;
            this.NewFolderButton.Text = "New Folder";
            this.NewFolderButton.UseVisualStyleBackColor = true;
            this.NewFolderButton.Click += new System.EventHandler(this.NewFolderBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1112, 514);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UploadQueue);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 251);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NewFolderButton);
            this.panel2.Controls.Add(this.FoldersListBox);
            this.panel2.Controls.Add(this.BackButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(559, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 251);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.ipfs_path_txt);
            this.panel3.Controls.Add(this.UploadBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 260);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 251);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.FilesListBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(559, 260);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(550, 251);
            this.panel4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 514);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "IPFS Local Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.FolderListBoxContextMenu.ResumeLayout(false);
            this.FilesListBoxContextMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipfs_path_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox FoldersListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox FilesListBox;
        private System.Windows.Forms.ListBox UploadQueue;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button NewFolderButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ContextMenuStrip FolderListBoxContextMenu;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip FilesListBoxContextMenu;
        private System.Windows.Forms.ToolStripMenuItem RemoveFile;
    }
}

