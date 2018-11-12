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
            this.configGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IPFSGateway = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.APIEndpointTxt = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.FileInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.FileSizeTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.HashTxt = new System.Windows.Forms.TextBox();
            this.HashLabel = new System.Windows.Forms.Label();
            this.FileNameTxt = new System.Windows.Forms.TextBox();
            this.filenameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FolderHashTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FolderFilenameTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FolderListBoxContextMenu.SuspendLayout();
            this.FilesListBoxContextMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.configGroupBox.SuspendLayout();
            this.panel4.SuspendLayout();
            this.FileInfoGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.ipfs_path_txt.Size = new System.Drawing.Size(484, 20);
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
            this.UploadBtn.Size = new System.Drawing.Size(484, 23);
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
            this.FoldersListBox.Size = new System.Drawing.Size(485, 238);
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
            this.FilesListBox.Size = new System.Drawing.Size(482, 238);
            this.FilesListBox.TabIndex = 8;
            this.FilesListBox.SelectedIndexChanged += new System.EventHandler(this.FilesListBox_SelectedIndexChanged);
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
            this.UploadQueue.Size = new System.Drawing.Size(484, 251);
            this.UploadQueue.TabIndex = 10;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton.Location = new System.Drawing.Point(3, 283);
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
            this.NewFolderButton.Location = new System.Drawing.Point(96, 283);
            this.NewFolderButton.Name = "NewFolderButton";
            this.NewFolderButton.Size = new System.Drawing.Size(87, 23);
            this.NewFolderButton.TabIndex = 12;
            this.NewFolderButton.Text = "New Folder";
            this.NewFolderButton.UseVisualStyleBackColor = true;
            this.NewFolderButton.Click += new System.EventHandler(this.NewFolderBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1005, 636);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UploadQueue);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 312);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NewFolderButton);
            this.panel2.Controls.Add(this.FoldersListBox);
            this.panel2.Controls.Add(this.BackButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(505, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 312);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.configGroupBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.ipfs_path_txt);
            this.panel3.Controls.Add(this.UploadBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 321);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 312);
            this.panel3.TabIndex = 2;
            // 
            // configGroupBox
            // 
            this.configGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configGroupBox.Controls.Add(this.label6);
            this.configGroupBox.Controls.Add(this.IPFSGateway);
            this.configGroupBox.Controls.Add(this.label5);
            this.configGroupBox.Controls.Add(this.APIEndpointTxt);
            this.configGroupBox.Location = new System.Drawing.Point(12, 81);
            this.configGroupBox.Name = "configGroupBox";
            this.configGroupBox.Size = new System.Drawing.Size(480, 161);
            this.configGroupBox.TabIndex = 6;
            this.configGroupBox.TabStop = false;
            this.configGroupBox.Text = "Configuration:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "IPFS Gateway:";
            // 
            // IPFSGateway
            // 
            this.IPFSGateway.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IPFSGateway.Location = new System.Drawing.Point(6, 78);
            this.IPFSGateway.Name = "IPFSGateway";
            this.IPFSGateway.Size = new System.Drawing.Size(468, 20);
            this.IPFSGateway.TabIndex = 10;
            this.IPFSGateway.TextChanged += new System.EventHandler(this.IPFSGateway_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "API Endpoint:";
            // 
            // APIEndpointTxt
            // 
            this.APIEndpointTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.APIEndpointTxt.Location = new System.Drawing.Point(6, 34);
            this.APIEndpointTxt.Name = "APIEndpointTxt";
            this.APIEndpointTxt.Size = new System.Drawing.Size(468, 20);
            this.APIEndpointTxt.TabIndex = 8;
            this.APIEndpointTxt.TextChanged += new System.EventHandler(this.APIEndpointTxt_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.FilesListBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(505, 321);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(497, 312);
            this.panel4.TabIndex = 3;
            // 
            // FileInfoGroupBox
            // 
            this.FileInfoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FileInfoGroupBox.Controls.Add(this.FileSizeTxt);
            this.FileInfoGroupBox.Controls.Add(this.label7);
            this.FileInfoGroupBox.Controls.Add(this.HashTxt);
            this.FileInfoGroupBox.Controls.Add(this.HashLabel);
            this.FileInfoGroupBox.Controls.Add(this.FileNameTxt);
            this.FileInfoGroupBox.Controls.Add(this.filenameLabel);
            this.FileInfoGroupBox.Location = new System.Drawing.Point(1011, 126);
            this.FileInfoGroupBox.Name = "FileInfoGroupBox";
            this.FileInfoGroupBox.Size = new System.Drawing.Size(288, 151);
            this.FileInfoGroupBox.TabIndex = 14;
            this.FileInfoGroupBox.TabStop = false;
            this.FileInfoGroupBox.Text = "File Information:";
            // 
            // FileSizeTxt
            // 
            this.FileSizeTxt.Location = new System.Drawing.Point(9, 110);
            this.FileSizeTxt.Name = "FileSizeTxt";
            this.FileSizeTxt.Size = new System.Drawing.Size(273, 20);
            this.FileSizeTxt.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "File Size:";
            // 
            // HashTxt
            // 
            this.HashTxt.Location = new System.Drawing.Point(9, 71);
            this.HashTxt.Name = "HashTxt";
            this.HashTxt.Size = new System.Drawing.Size(273, 20);
            this.HashTxt.TabIndex = 3;
            // 
            // HashLabel
            // 
            this.HashLabel.AutoSize = true;
            this.HashLabel.Location = new System.Drawing.Point(6, 55);
            this.HashLabel.Name = "HashLabel";
            this.HashLabel.Size = new System.Drawing.Size(35, 13);
            this.HashLabel.TabIndex = 2;
            this.HashLabel.Text = "Hash:";
            // 
            // FileNameTxt
            // 
            this.FileNameTxt.Location = new System.Drawing.Point(9, 32);
            this.FileNameTxt.Name = "FileNameTxt";
            this.FileNameTxt.Size = new System.Drawing.Size(273, 20);
            this.FileNameTxt.TabIndex = 1;
            // 
            // filenameLabel
            // 
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.Location = new System.Drawing.Point(6, 16);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(52, 13);
            this.filenameLabel.TabIndex = 0;
            this.filenameLabel.Text = "Filename:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.FolderHashTxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.FolderFilenameTxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(1011, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 117);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folder Information:";
            // 
            // FolderHashTxt
            // 
            this.FolderHashTxt.Location = new System.Drawing.Point(9, 76);
            this.FolderHashTxt.Name = "FolderHashTxt";
            this.FolderHashTxt.Size = new System.Drawing.Size(273, 20);
            this.FolderHashTxt.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Hash:";
            // 
            // FolderFilenameTxt
            // 
            this.FolderFilenameTxt.Location = new System.Drawing.Point(9, 37);
            this.FolderFilenameTxt.Name = "FolderFilenameTxt";
            this.FolderFilenameTxt.Size = new System.Drawing.Size(273, 20);
            this.FolderFilenameTxt.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Filename:";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 637);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FileInfoGroupBox);
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
            this.configGroupBox.ResumeLayout(false);
            this.configGroupBox.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.FileInfoGroupBox.ResumeLayout(false);
            this.FileInfoGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox configGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox APIEndpointTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IPFSGateway;
        private System.Windows.Forms.GroupBox FileInfoGroupBox;
        private System.Windows.Forms.TextBox FileSizeTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox HashTxt;
        private System.Windows.Forms.Label HashLabel;
        private System.Windows.Forms.TextBox FileNameTxt;
        private System.Windows.Forms.Label filenameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox FolderHashTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox FolderFilenameTxt;
        private System.Windows.Forms.Label label9;
    }
}

