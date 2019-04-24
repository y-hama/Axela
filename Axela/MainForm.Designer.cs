namespace Axela
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DoProcess = new System.Windows.Forms.Button();
            this.Source = new Axela.FileSelectToolSet();
            this.DiffBase = new Axela.FileSelectToolSet();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Source);
            this.groupBox1.Controls.Add(this.DiffBase);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 119);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // DoProcess
            // 
            this.DoProcess.Location = new System.Drawing.Point(206, 125);
            this.DoProcess.Name = "DoProcess";
            this.DoProcess.Size = new System.Drawing.Size(75, 23);
            this.DoProcess.TabIndex = 3;
            this.DoProcess.Text = "Process";
            this.DoProcess.UseVisualStyleBackColor = true;
            this.DoProcess.Click += new System.EventHandler(this.DoProcess_Click);
            // 
            // Source
            // 
            this.Source.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Source.Dock = System.Windows.Forms.DockStyle.Top;
            this.Source.Location = new System.Drawing.Point(3, 63);
            this.Source.Name = "Source";
            this.Source.NameLabel = "ソース";
            this.Source.SelectedFileInfo = null;
            this.Source.Size = new System.Drawing.Size(278, 48);
            this.Source.TabIndex = 1;
            // 
            // DiffBase
            // 
            this.DiffBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiffBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.DiffBase.Location = new System.Drawing.Point(3, 15);
            this.DiffBase.Name = "DiffBase";
            this.DiffBase.NameLabel = "差分元";
            this.DiffBase.SelectedFileInfo = null;
            this.DiffBase.Size = new System.Drawing.Size(278, 48);
            this.DiffBase.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 166);
            this.Controls.Add(this.DoProcess);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Axela";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FileSelectToolSet DiffBase;
        private FileSelectToolSet Source;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DoProcess;
    }
}

