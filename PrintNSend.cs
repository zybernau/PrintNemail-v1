/*
 * Created by SharpDevelop.
 * User: Raja
 * Date: 8/5/2012
 * Time: 11:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Mime;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Threading;

namespace PrintNSend
{
	/// <summary>
	/// Description of PrintNSend.
	/// </summary>
	public class PrintNSend : IDisposable
	{
		
		private string FILE_PATH = "";
		/*private string USERNAME = "m.rajamohan@gmail.com";
		private string PASSWORD = "Zybernau";
		private string RECIPIENT = "m.rajamohan@gmail.com";
		
		private string MAIL_SUBJECT = "[b] bills/informations/screenshots/payment information #SGM#";
		private string MAIL_BODY = "PFA, <br> system generated email, do not reply back.";
		
		private string SMTP_CLIENT = "smtp.gmail.com";
		private int SMTP_PORT = 587;*/
		
		private iSettingsRO settM;
		public PrintNSend()
		{
			settM = new settingsModel();
			FILE_PATH = getTempPath();
		}
		
		/* main method for taking screen printing
		 * 1. take print shot
		 * 2. save the jpeg in the temprory folder
		 * 3. make logics so that the name is not clashing, u can use the temp name.
		 * 4. configure the mail assitance so that the mail with the attachment is sent as required.
		 * 5. if possible label the mail so that the mail resdes in the allocated label and archived, for this u 
		 * need to use the google mail api.
		 * 6. after sending the mail, delete the jpeg used./ or save it with time stamp in the my documents folders.
	*/
		
		private string getFileName(string pat)
		{
			return Path.Combine(pat,Path.GetFileNameWithoutExtension(System.IO.Path.GetTempFileName()));
		}
		
		private string getTempPath()
		{
			string retpath = "";
			string filename = "";
			if(settM.filepath != string.Empty && System.IO.Directory.Exists(settM.filepath))
			{
				filename = getFileName(settM.filepath);
			}
			else
			{
				filename = System.IO.Path.GetTempFileName();
			}
			
			retpath =  filename + ".jpg";
			return retpath;
		}
	
		public string Pns(IntPtr handl)
		{
			string path = string.Empty;
			Attachment att = null;
			Bitmap printscreen = null;
			Graphics graphics = null;
			MailMessage mm = null;
            path = FILE_PATH;
			try 
			{

               /* ScreenCapture sc = new ScreenCapture();

                // capture this window, and save it
                sc.CaptureWindowToFile(handl, path, ImageFormat.Jpeg);*/

				//print the screen
				printscreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);  
	  		    graphics = Graphics.FromImage(printscreen as Image);    
			    graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);  
		  		
				printscreen.Save(path, ImageFormat.Jpeg );
			    

                // capture only the current window
                /*Rectangle bounds = Screen.GetBounds(Point.Empty);
                using ( printscreen = new Bitmap(bounds.Width, bounds.Height))
                {
                    using (graphics = Graphics.FromImage(printscreen))
                    {
                        graphics.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                    }
                    printscreen.Save(path, ImageFormat.Jpeg);
                }*/

				//prepare the mail message with attachment
			    mm = new MailMessage();
				mm.From = new MailAddress(settM.username);
				mm.To.Add(settM.mailto);
				mm.Subject = settM.mailsubject ;
				mm.Body = settM.mailbody;
				mm.IsBodyHtml  = true;
				att = new Attachment(path,MediaTypeNames.Image.Jpeg);
				mm.Attachments.Add(att);
				
				Preview np = new Preview(path, mm);
				np.TopMost = true;

				// make center
				np.StartPosition = FormStartPosition.CenterScreen;
				np.Show();
				
				//send the mail
				//sendEmail(mm);
				
				
			} 
			catch (Exception ex) 
			{
				throw ex;
			}
			finally
			{
				// dispose shits off.
				
				printscreen.Dispose();
				graphics.Dispose();
				
			}
			
			
			//no use in returning the path.
			return path;
		}
		
		
		
		private void sendEmail(MailMessage mm)
		{
			var client = new SmtpClient(settM.smtpclient, settM.smtpport)
            {
                Credentials = new NetworkCredential(settM.username, settM.password ),
                EnableSsl = true
            };
			client.Send(mm);
			
			client.Dispose();
		}
		
		public void Dispose()
		{
			settM = null;
		}
	}
}

