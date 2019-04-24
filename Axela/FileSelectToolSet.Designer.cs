namespace Axela
{
    partial class FileSelectToolSet
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FileDialogButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.FileName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label.Location = new System.Drawing.Point(0, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(55, 25);
            this.Label.TabIndex = 0;
            this.Label.Text = "Label";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FileName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 25);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(55, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(7, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.FileDialogButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 23);
            this.panel2.TabIndex = 2;
            // 
            // FileDialogButton
            // 
            this.FileDialogButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.FileDialogButton.Location = new System.Drawing.Point(173, 0);
            this.FileDialogButton.Name = "FileDialogButton";
            this.FileDialogButton.Size = new System.Drawing.Size(25, 23);
            this.FileDialogButton.TabIndex = 0;
            this.FileDialogButton.Text = "...";
            this.FileDialogButton.UseVisualStyleBackColor = true;
            this.FileDialogButton.Click += new System.EventHandler(this.FileDialogButton_Click);
            // 
            // FileName
            // 
            this.FileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileName.Location = new System.Drawing.Point(62, 0);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(136, 25);
            this.FileName.TabIndex = 2;
            this.FileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FileSelectToolSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FileSelectToolSet";
            this.Size = new System.Drawing.Size(198, 48);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button FileDialogButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label FileName;
    }
}
