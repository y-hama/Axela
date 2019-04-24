using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Axela
{
    public partial class FileSelectToolSet : UserControl
    {
        public string NameLabel
        {
            get { return Label.Text; }
            set { Label.Text = value; }
        }

        private System.IO.FileInfo selectedFileInfo;
        public System.IO.FileInfo SelectedFileInfo
        {
            get { return selectedFileInfo; }
            set
            {
                selectedFileInfo = value;
                if (selectedFileInfo != null)
                {
                    FileName.Text = selectedFileInfo.Name;
                    toolTip1.SetToolTip(FileName, selectedFileInfo.Directory.FullName);
                }
            }
        }

        public FileSelectToolSet()
        {
            InitializeComponent();
        }

        private void FileDialogButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SelectedFileInfo = new System.IO.FileInfo(ofd.FileName);
            }
        }
    }
}
