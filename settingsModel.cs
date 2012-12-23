/*
 * Created by SharpDevelop.
 * User: Raja
 * Date: 8/6/2012
 * Time: 11:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Configuration;

using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PrintNSend
{
	/// <summary>
	/// Description of settingsModel.
	/// </summary>
	public class settingsModel : iSettings,iSettingsRO
	{
		public settingsModel()
		{
			load();
		}
		/*
		  * 
		<add key="username" value="m.rajamohan@gmail.com">
		</add>
		<add key="password" value="Zybernau" />
		<add key="file_path" value="" />
		<add key="mail_to" value="m.rajamohan@gmail.com" />
		<add key="subject" value="[b] bills/informations/screenshots/payment information #SGM#" />
		<add key="body" value="PFA, system generated email, do not reply back." />
		<add key="smtp_client" value="smtp.gmail.com" />
		<add key="smtp_port" value="587" />
		  * 
		  * */
		public void save()
		{
			try {
				
			
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			AppSettingsSection app = config.AppSettings;
			
			app.Settings.Remove("username");
			app.Settings.Add("username", _username);
			
			app.Settings.Remove("password");
			app.Settings.Add("password", _password);
			
			app.Settings.Remove("file_path");
			app.Settings.Add("file_path", _filepath);
			
			app.Settings.Remove("mail_to");
			app.Settings.Add("mail_to", _mailto);
			
			app.Settings.Remove("subject");
			app.Settings.Add("subject", _mailsubject);
			
			app.Settings.Remove("body");
			app.Settings.Add("body", _mailbody);
			
			app.Settings.Remove("smtp_client");
			app.Settings.Add("smtp_client", _smtpclient);
			
			app.Settings.Remove("smtp_port");
			app.Settings.Add("smtp_port", _smtpport.ToString());
			
			config.Save(ConfigurationSaveMode.Modified);
			
			} catch (Exception ex) {
				
				throw ex;
			}
		}
		
		public void load()
		{
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			AppSettingsSection app = config.AppSettings;
			
						
			_username = 	app.Settings["username"].Value;
			_password = 	app.Settings["password"].Value;
			_filepath = 	app.Settings["file_path"].Value;
			_mailto =   	app.Settings["mail_to"].Value;
			_mailsubject = 	app.Settings["subject"].Value;
			_mailbody = 	app.Settings["body"].Value;
			_smtpclient = 	app.Settings["smtp_client"].Value;
			_smtpport = 	int.Parse(app.Settings["smtp_port"].Value);
		}
		
		private string _username = string.Empty;
		public string username 
		{ 
			get
			{
				return _username;
			}
			set
			{
				_username = value;
			}
		}
		
		private string _password = string.Empty;
		public string password 
		{ 
			get
			{
				return _password;
			}
			set
			{
				_password = value;
			}
		}
		
		private string _filepath = string.Empty;
		public string filepath 
		{ 
			get
			{
				return _filepath;
			}
			set
			{
				_filepath = value;
			}
		}
		
		private string _mailto = string.Empty;
		public string mailto 
		{ 
			get
			{
				return _mailto;
			}
			set
			{
				_mailto = value;
			}
		}
		
		private string _mailsubject = string.Empty;
		public string mailsubject 
		{ 
			get
			{
				return _mailsubject;
			}
			set
			{
				_mailsubject = value;
			}
		}
		
		private string _mailbody = string.Empty;
		public string mailbody 
		{ 
			get
			{
				return _mailbody;
			}
			set
			{
				_mailbody = value;
			}
		}
		
		private string _smtpclient = string.Empty;
		public string smtpclient 
		{ 
			get
			{
				return _smtpclient;
			}
			set
			{
				_smtpclient = value;
			}
		}
		
		private int _smtpport = 25;
		public int smtpport
		{ 
			get
			{
				return _smtpport;
			}
			set
			{
				_smtpport = value;
			}
		}
		
	}
}
