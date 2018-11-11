﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using static ipfs_uploader.API;

namespace ipfs_uploader
{
    public partial class Form1 : Form
    {
        private string currentPath = "/";
        private List<string> UploadToFolder = new List<string> { };
        private List<string> FileHashes = new List<string> { };
        public Form1()
        {
            InitializeComponent();
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            while (UploadQueue.Items.Count > 0)
            {
                if (UploadFile(UploadToFolder[0], UploadQueue.Items[0].ToString()) == "")
                {
                    UpdateContent();
                    UploadQueue.Items.RemoveAt(0);
                    UploadToFolder.RemoveAt(0);
                }
            }
        }
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string file in (string[])e.Data.GetData(DataFormats.FileDrop))
            {
                UploadQueue.Items.Add(file);
                UploadToFolder.Add(currentPath);
            }
        }

        private void NewFolderBtn_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter Folder Name", "New Folder", "", -1, -1);
            if (!string.IsNullOrEmpty(input))
            {
                if (MakeDir(currentPath + "/" + input) == "")
                    UpdateContent();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateContent();
        }

        private void UpdateContent()
        {
            dynamic content = JsonConvert.DeserializeObject(ListContent(currentPath));
            FoldersListBox.Items.Clear();
            FilesListBox.Items.Clear();
            FileHashes.Clear();
            if (content["Entries"] != null)
            {
                foreach (dynamic entry in content["Entries"])
                {
                    dynamic entry_details = JsonConvert.DeserializeObject(Stat(currentPath + "/" + entry["Name"]));
                    if (entry_details["Type"] == "directory")
                        FoldersListBox.Items.Add(entry["Name"]);
                    else
                    {
                        FilesListBox.Items.Add(entry["Name"]);
                        FileHashes.Add(entry_details["Hash"].ToString());
                    }
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (currentPath != "/")
            {
                string[] split_path = currentPath.Split('/');
                for (int i = 0; i < split_path.Length - 2; i++)
                {
                    currentPath = "/" + split_path[i];
                }
                if (currentPath != "/")
                    currentPath += "/";
                UpdateContent();
                ipfs_path_txt.Text = currentPath;
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FoldersListBox.SelectedItem != null)
            {
                if (RemovePath(currentPath + "/" + FoldersListBox.SelectedItem) == "")
                    UpdateContent();
            }
        }

        private void FoldersListBox_DoubleClick(object sender, EventArgs e)
        {
            if (FoldersListBox.SelectedItem != null)
            {
                currentPath += FoldersListBox.SelectedItem + "/";
                UpdateContent();
                ipfs_path_txt.Text = currentPath;
            }
        }

        private void FilesListBox_DoubleClick(object sender, EventArgs e)
        {
            if (FilesListBox.SelectedItem != null)
            {
                Process.Start("http://localhost:8082/ipfs/" + FileHashes[FilesListBox.SelectedIndex]);
            }
        }
        private void RemoveFile_Click(object sender, EventArgs e)
        {
            if (FilesListBox.SelectedItem != null)
            {
                if (RemovePath(currentPath + "/" + FilesListBox.SelectedItem) == "")
                    UpdateContent();
            }
        }
    }
}
