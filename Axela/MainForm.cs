using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Axela
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Source != "")
                Source.SelectedFileInfo = new System.IO.FileInfo(Properties.Settings.Default.Source);
            if (Properties.Settings.Default.DiffBase != "")
                DiffBase.SelectedFileInfo = new System.IO.FileInfo(Properties.Settings.Default.DiffBase);
        }

        private List<System.IO.FileInfo> list { get; set; }

        private void DoProcess_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Source == null || Properties.Settings.Default.DiffBase == null) { return; }
            Properties.Settings.Default.Source = Source.SelectedFileInfo.FullName;
            Properties.Settings.Default.DiffBase = DiffBase.SelectedFileInfo.FullName;
            Properties.Settings.Default.Save();

            list = new List<System.IO.FileInfo>();
            System.IO.FileInfo source = Source.SelectedFileInfo;
            System.IO.FileInfo diffbase = DiffBase.SelectedFileInfo;

            // 差分リスト作成
            RecursiveFunction(source.Directory, diffbase.Directory);

            // コピー先の作成
            System.IO.DirectoryInfo location = new System.IO.DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            string newlocpath = location + @"\Axela\" + source.Directory.Name;
            if (System.IO.Directory.Exists(location + @"\Axela"))
            {
                System.IO.Directory.Delete(location + @"\Axela", true);
            }
            System.IO.Directory.CreateDirectory(newlocpath);

            // コピー
            foreach (var item in list)
            {

                // パスの生成
                string itempath = newlocpath + item.FullName.Replace(source.DirectoryName, "");
                SafeCreateDirectory(itempath.Replace(item.Name, ""));
                item.CopyTo(itempath);
            }
        }

        private void RecursiveFunction(System.IO.DirectoryInfo sroot, System.IO.DirectoryInfo droot)
        {
            // ファイルが対象
            if (droot != null)
            {
                foreach (var item in sroot.GetFiles())
                {
                    var select = new List<System.IO.FileInfo>(droot.GetFiles()).Find(x => x.Name == item.Name);
                    if (select == null)
                    {
                        list.Add(item);
                    }
                    else
                    {
                        // 同名ファイルが存在した
                        if (!ContentComparison(item, select))
                        {
                            list.Add(item);
                        }
                    }
                }
            }

            // フォルダが対象
            foreach (var item in sroot.GetDirectories())
            {
                System.IO.DirectoryInfo select = null;
                if (droot != null)
                {
                    select = new List<System.IO.DirectoryInfo>(droot.GetDirectories()).Find(x => x.Name == item.Name);
                }
                if (select == null)
                {
                    foreach (var file in item.GetFiles())
                    {
                        list.Add(file);
                    }
                }
                RecursiveFunction(item, select);
            }
        }

        private bool ContentComparison(System.IO.FileInfo sinfo, System.IO.FileInfo dinfo)
        {
            bool ret = true;

            string scont, dcont;
            using (System.IO.StreamReader sfs = new System.IO.StreamReader(sinfo.FullName))
            using (System.IO.StreamReader dfs = new System.IO.StreamReader(dinfo.FullName))
            {
                scont = sfs.ReadToEnd();
                dcont = dfs.ReadToEnd();
            }
            if (scont != dcont) { ret = false; }

            return ret;
        }

        public static System.IO.DirectoryInfo SafeCreateDirectory(string path)
        {
            if (System.IO.Directory.Exists(path))
            {
                return null;
            }
            return System.IO.Directory.CreateDirectory(path);
        }
    }
}
