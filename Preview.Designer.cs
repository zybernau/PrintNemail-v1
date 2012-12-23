/*
 * Created by SharpDevelop.
 * User: Raja
 * Date: 8/6/2012
 * Time: 8:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PrintNSend
{
	partial class Preview
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preview));
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkAdd = new System.Windows.Forms.CheckBox();
            this.btnTextPreview = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.lblFilename = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.lblText = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtBody = new System.Windows.Forms.WebBrowser();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkAdd);
            this.panel1.Controls.Add(this.btnTextPreview);
            this.panel1.Controls.Add(this.btnSaveFile);
            this.panel1.Controls.Add(this.lblFilename);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMonth);
            this.panel1.Controls.Add(this.txtBank);
            this.panel1.Controls.Add(this.txtFilename);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.pbPreview);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 276);
            this.panel1.TabIndex = 0;
            // 
            // chkAdd
            // 
            this.chkAdd.AutoSize = true;
            this.chkAdd.Location = new System.Drawing.Point(306, 248);
            this.chkAdd.Name = "chkAdd";
            this.chkAdd.Size = new System.Drawing.Size(76, 17);
            this.chkAdd.TabIndex = 9;
            this.chkAdd.Text = "Add Text";
            this.chkAdd.UseVisualStyleBackColor = true;
            this.chkAdd.CheckedChanged += new System.EventHandler(this.chkAdd_CheckedChanged);
            // 
            // btnTextPreview
            // 
            this.btnTextPreview.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextPreview.Location = new System.Drawing.Point(212, 243);
            this.btnTextPreview.Name = "btnTextPreview";
            this.btnTextPreview.Size = new System.Drawing.Size(88, 24);
            this.btnTextPreview.TabIndex = 8;
            this.btnTextPreview.Text = "Text Preview";
            this.btnTextPreview.UseVisualStyleBackColor = true;
            this.btnTextPreview.Click += new System.EventHandler(this.btnTextPreview_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFile.Location = new System.Drawing.Point(155, 243);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(51, 24);
            this.btnSaveFile.TabIndex = 6;
            this.btnSaveFile.Text = "&Save";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // lblFilename
            // 
            this.lblFilename.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilename.Location = new System.Drawing.Point(10, 241);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(139, 26);
            this.lblFilename.TabIndex = 7;
            this.lblFilename.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "filename";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(230, 211);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(95, 21);
            this.txtMonth.TabIndex = 2;
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(146, 211);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(70, 21);
            this.txtBank.TabIndex = 1;
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(55, 211);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(77, 21);
            this.txtFilename.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(388, 213);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.cancelClick);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(331, 213);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(51, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "&Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.Button1Click);
            // 
            // pbPreview
            // 
            this.pbPreview.Location = new System.Drawing.Point(0, 0);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(448, 206);
            this.pbPreview.TabIndex = 0;
            this.pbPreview.TabStop = false;
            this.pbPreview.Click += new System.EventHandler(this.PbPreviewClick);
            // 
            // lblText
            // 
            this.lblText.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(0, 283);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(236, 21);
            this.lblText.TabIndex = 10;
            this.lblText.Text = "Preview, image saved and send to gmail.";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker1ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1RunWorkerCompleted);
            // 
            // txtBody
            // 
            this.txtBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBody.Location = new System.Drawing.Point(2, 307);
            this.txtBody.MinimumSize = new System.Drawing.Size(20, 20);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(448, 176);
            this.txtBody.TabIndex = 11;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 485);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(453, 10);
            this.progressBar1.TabIndex = 12;
            // 
            // Preview
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(453, 495);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Preview";
            this.Opacity = 0.95D;
            this.Text = "Preview and Send";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label label1;

		

	
		private System.Windows.Forms.Label lblFilename;
		private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.TextBox txtMonth;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblText;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.PictureBox pbPreview;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnTextPreview;
        private System.Windows.Forms.CheckBox chkAdd;
        private System.Windows.Forms.WebBrowser txtBody;
        private System.Windows.Forms.ProgressBar progressBar1;
	}
}
