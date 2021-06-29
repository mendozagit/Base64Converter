
namespace Base64Converter
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPath = new DevExpress.XtraEditors.TextEdit();
            this.BtnRestoreFile = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEncodeFile = new DevExpress.XtraEditors.SimpleButton();
            this.TxtEncodedFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPath.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "File Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(13, 108);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(589, 20);
            this.TxtName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Path";
            // 
            // TxtPath
            // 
            this.TxtPath.Location = new System.Drawing.Point(13, 151);
            this.TxtPath.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.Size = new System.Drawing.Size(589, 20);
            this.TxtPath.TabIndex = 4;
            // 
            // BtnRestoreFile
            // 
            this.BtnRestoreFile.Location = new System.Drawing.Point(301, 233);
            this.BtnRestoreFile.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRestoreFile.Name = "BtnRestoreFile";
            this.BtnRestoreFile.Size = new System.Drawing.Size(301, 53);
            this.BtnRestoreFile.TabIndex = 7;
            this.BtnRestoreFile.Text = "Restore file";
            this.BtnRestoreFile.Click += new System.EventHandler(this.BtnRestoreFile_Click);
            // 
            // BtnEncodeFile
            // 
            this.BtnEncodeFile.Location = new System.Drawing.Point(13, 233);
            this.BtnEncodeFile.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEncodeFile.Name = "BtnEncodeFile";
            this.BtnEncodeFile.Size = new System.Drawing.Size(280, 53);
            this.BtnEncodeFile.TabIndex = 8;
            this.BtnEncodeFile.Text = "Encode file";
            this.BtnEncodeFile.Click += new System.EventHandler(this.BtnEncodeFile_Click);
            // 
            // TxtEncodedFile
            // 
            this.TxtEncodedFile.Location = new System.Drawing.Point(12, 50);
            this.TxtEncodedFile.Name = "TxtEncodedFile";
            this.TxtEncodedFile.Size = new System.Drawing.Size(590, 22);
            this.TxtEncodedFile.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Encoded file";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 354);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtEncodedFile);
            this.Controls.Add(this.BtnEncodeFile);
            this.Controls.Add(this.BtnRestoreFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPath.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit TxtName;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit TxtPath;
        private DevExpress.XtraEditors.SimpleButton BtnRestoreFile;
        private DevExpress.XtraEditors.SimpleButton BtnEncodeFile;
        private System.Windows.Forms.TextBox TxtEncodedFile;
        private System.Windows.Forms.Label label4;
    }
}

