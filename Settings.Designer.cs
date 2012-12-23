/*
 * Created by SharpDevelop.
 * User: Raja
 * Date: 8/5/2012
 * Time: 11:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PrintNSend
{
	partial class Settings
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
			this.pnl = new System.Windows.Forms.Panel();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.txtSMTP = new System.Windows.Forms.TextBox();
			this.txtBody = new System.Windows.Forms.TextBox();
			this.txtSaveFolder = new System.Windows.Forms.TextBox();
			this.txtTo = new System.Windows.Forms.TextBox();
			this.txtSub = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnRst = new System.Windows.Forms.Button();
			this.fbd = new System.Windows.Forms.FolderBrowserDialog();
			this.pnl.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnl
			// 
			this.pnl.Controls.Add(this.btnBrowse);
			this.pnl.Controls.Add(this.label4);
			this.pnl.Controls.Add(this.label6);
			this.pnl.Controls.Add(this.label2);
			this.pnl.Controls.Add(this.label3);
			this.pnl.Controls.Add(this.label8);
			this.pnl.Controls.Add(this.label7);
			this.pnl.Controls.Add(this.label5);
			this.pnl.Controls.Add(this.label1);
			this.pnl.Controls.Add(this.txtPort);
			this.pnl.Controls.Add(this.txtSMTP);
			this.pnl.Controls.Add(this.txtBody);
			this.pnl.Controls.Add(this.txtSaveFolder);
			this.pnl.Controls.Add(this.txtTo);
			this.pnl.Controls.Add(this.txtSub);
			this.pnl.Controls.Add(this.txtPass);
			this.pnl.Controls.Add(this.txtID);
			this.pnl.Location = new System.Drawing.Point(12, 23);
			this.pnl.Name = "pnl";
			this.pnl.Size = new System.Drawing.Size(427, 219);
			this.pnl.TabIndex = 0;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(281, 69);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(97, 23);
			this.btnBrowse.TabIndex = 2;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.BtnBrowseClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(234, 43);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 20);
			this.label4.TabIndex = 1;
			this.label4.Text = "PORT";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(-1, 164);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(33, 20);
			this.label6.TabIndex = 1;
			this.label6.Text = "Body";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(-1, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Pwd";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(234, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 20);
			this.label3.TabIndex = 1;
			this.label3.Text = "SMTP";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(-2, 74);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(41, 20);
			this.label8.TabIndex = 1;
			this.label8.Text = "Folder";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(-1, 109);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(30, 20);
			this.label7.TabIndex = 1;
			this.label7.Text = "To";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(-1, 138);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 20);
			this.label5.TabIndex = 1;
			this.label5.Text = "Sub";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(-1, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "ID";
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(274, 40);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(54, 20);
			this.txtPort.TabIndex = 0;
			// 
			// txtSMTP
			// 
			this.txtSMTP.Location = new System.Drawing.Point(275, 11);
			this.txtSMTP.Name = "txtSMTP";
			this.txtSMTP.Size = new System.Drawing.Size(143, 20);
			this.txtSMTP.TabIndex = 0;
			// 
			// txtBody
			// 
			this.txtBody.Location = new System.Drawing.Point(46, 161);
			this.txtBody.Multiline = true;
			this.txtBody.Name = "txtBody";
			this.txtBody.Size = new System.Drawing.Size(369, 46);
			this.txtBody.TabIndex = 0;
			// 
			// txtSaveFolder
			// 
			this.txtSaveFolder.Location = new System.Drawing.Point(45, 71);
			this.txtSaveFolder.Name = "txtSaveFolder";
			this.txtSaveFolder.Size = new System.Drawing.Size(230, 20);
			this.txtSaveFolder.TabIndex = 0;
			// 
			// txtTo
			// 
			this.txtTo.Location = new System.Drawing.Point(45, 109);
			this.txtTo.Name = "txtTo";
			this.txtTo.Size = new System.Drawing.Size(369, 20);
			this.txtTo.TabIndex = 0;
			// 
			// txtSub
			// 
			this.txtSub.Location = new System.Drawing.Point(46, 135);
			this.txtSub.Name = "txtSub";
			this.txtSub.Size = new System.Drawing.Size(369, 20);
			this.txtSub.TabIndex = 0;
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(46, 40);
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '@';
			this.txtPass.Size = new System.Drawing.Size(166, 20);
			this.txtPass.TabIndex = 0;
			this.txtPass.UseSystemPasswordChar = true;
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(46, 11);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(182, 20);
			this.txtID.TabIndex = 0;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(364, 248);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// btnRst
			// 
			this.btnRst.Location = new System.Drawing.Point(282, 248);
			this.btnRst.Name = "btnRst";
			this.btnRst.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnRst.Size = new System.Drawing.Size(75, 23);
			this.btnRst.TabIndex = 1;
			this.btnRst.Text = "&Reset";
			this.btnRst.UseVisualStyleBackColor = true;
			this.btnRst.Click += new System.EventHandler(this.BtnRstClick);
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClientSize = new System.Drawing.Size(449, 293);
			this.Controls.Add(this.btnRst);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.pnl);
			this.Name = "Settings";
			this.Text = "Settings";
			this.Load += new System.EventHandler(this.SettingsLoad);
			this.pnl.ResumeLayout(false);
			this.pnl.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox txtSaveFolder;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.FolderBrowserDialog fbd;
		private System.Windows.Forms.Button btnRst;
		private System.Windows.Forms.TextBox txtTo;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtSub;
		private System.Windows.Forms.TextBox txtBody;
		private System.Windows.Forms.TextBox txtSMTP;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel pnl;
	}
}
