/*
 * Created by SharpDevelop.
 * User: Raja
 * Date: 8/5/2012
 * Time: 11:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrintNSend
{
	/// <summary>
	/// Description of Settings.
	/// </summary>
	public partial class Settings : Form
	{
		private iSettings settingsM;
		
		public Settings()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			InitializeComponent();
			settingsM = new settingsModel();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void BtnBrowseClick(object sender, EventArgs e)
		{
			fbd.ShowDialog();
			txtSaveFolder.Text = fbd.SelectedPath;
		}
		
		void SettingsLoad(object sender, EventArgs e)
		{
			loadData();
		}
		
		private void loadData()
		{
			txtID.Text = settingsM.username;
			txtPass.Text = settingsM.password;
			txtSMTP.Text = settingsM.smtpclient;
			txtPort.Text = settingsM.smtpport.ToString();
			txtSub.Text = settingsM.mailsubject;
			txtTo.Text = settingsM.mailto;
			txtSaveFolder.Text = settingsM.filepath;
			txtBody.Text = settingsM.mailbody;
		}
		
		
		void BtnSaveClick(object sender, EventArgs e)
		{
			settingsM.username	= txtID.Text ;			
			settingsM.password= txtPass.Text ;		
			settingsM.smtpclient= txtSMTP.Text; 		
			
			try {
				settingsM.smtpport= int.Parse(txtPort.Text);
			} catch (Exception ex) {
				
				throw ex;
			}
			
			
			settingsM.mailsubject= txtSub.Text; 		
			settingsM.mailto= txtTo.Text ;			
			settingsM.filepath= txtSaveFolder.Text 	;
			settingsM.mailbody= txtBody.Text 		;
			
				settingsM.save();
		}
		
		void BtnRstClick(object sender, EventArgs e)
		{
			loadData();
		}
	}
}
