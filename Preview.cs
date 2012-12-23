/*
 * Created by SharpDevelop.
 * User: Raja
 * Date: 8/6/2012
 * Time: 8:02 PM
 * 
 */
#region "Using"

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.Mime;
using System.Net;

#endregion

namespace PrintNSend
{
    /// <summary>
    /// Description of Preview.
    /// </summary>
    public partial class Preview : Form
    {
        #region "Declaration part"

        string previewPath = string.Empty;
        MailMessage mmsg = null;
        settingsModel settM = null;
        bool fileSaved = false;


        #endregion

        #region "Constructors"
        public Preview()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        public Preview(string path, MailMessage mm)
        {
            InitializeComponent();
            this.txtFilename.TextChanged += new EventHandler(Preview_TextChanged);
            this.txtBank.TextChanged += new EventHandler(Preview_TextChanged);
            this.txtMonth.TextChanged += new EventHandler(Preview_TextChanged);

            previewPath = path;
            pbPreview.Load(path);
            SetImage(pbPreview);
            backgroundWorker1.WorkerReportsProgress = true;
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Visible = false;
            mmsg = mm;
            settM = new settingsModel();
            lblText.Text = "The Picture is sent to the email, " + mm.To[0].Address;
            txtMonth.Text = getMonth();
            txtBank.Text = "HDFC";
            txtFilename.Text = "BILL";
            //txtBody.Focus();
            txtFilename.Focus();
            txtBody.DocumentText = mm.Body;
            txtBody.TabIndex = 0;
            btnOK.TabIndex = 1;
            btnCancel.TabIndex = 2;

        }


        #endregion

        #region "Events"

        void Preview_TextChanged(object sender, EventArgs e)
        {
            lblFilename.Text = "Filename:" + getFilename();
        }

        void txtprv_addText(bool toggleText)
        {
            txtBody.DocumentText = (toggleText) ? globalValue.textCopied : mmsg.Body;
            chkAdd.Checked = toggleText;
        }



        // save the file.
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            fileSave();
            fileSaved = true;
            btnSaveFile.Enabled = false;
        }

        private void btnTextPreview_Click(object sender, EventArgs e)
        {
            TextPreview txtprv = new TextPreview(globalValue.textCopied, chkAdd.Checked);
            txtprv.addText += txtprv_addText;
            txtprv.BringToFront();
            txtprv.TopMost = true;
            txtprv.ShowDialog();
        }



        //send ..
        void Button1Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            // change the attachment name.
            mmsg.Attachments[0].Name = getFilename() + ".jpg";
            if (!string.IsNullOrEmpty(txtBody.DocumentText))
            {
                mmsg.Body = txtBody.DocumentText;
            }

            if (!fileSaved)
                fileSave();

            //hdfc_sep_bill_10248
            backgroundWorker1.RunWorkerAsync();
        }

        void cancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

        void PbPreviewClick(object sender, EventArgs e)
        {
            Process.Start(pbPreview.ImageLocation);
        }

        //Check box changed
        private void chkAdd_CheckedChanged(object sender, EventArgs e)
        {
            // change the text - remove <-> add.
            chkAdd.Text = (chkAdd.Checked) ? "Remove Text" : "Add Text";
            if (chkAdd.Checked)
            {
                txtprv_addText(true);
            }
            else
            {
                txtprv_addText(false);
            }

            // call the event for adding the same.
        }

        #region Private Methods

        private string getMonth()
        {
            //DateTime.Today.
            return DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Today.Month).Substring(0, 3);

        }

        private string getFilename()
        {
            return string.Format("{0}_{1}_{2}", txtFilename.Text, txtBank.Text, txtMonth.Text);

        }
        void fileSave()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Path.GetDirectoryName(previewPath));
            sb.Append("\\");
            sb.Append(getFilename());
            sb.Append(Path.GetExtension(previewPath));
            string path2 = sb.ToString();

            if (txtFilename.Text.Trim() != string.Empty && !File.Exists(path2))
            {
                File.Copy(previewPath, path2);
                writeSelectedTextFile(sb.Append(".html").ToString());
            }
        }

        // Write Selected text to file/ copied text to file.
        private void writeSelectedTextFile(string fileName)
        {
            // get the text from the global and save it to the text
            if (globalValue.textCopied.Trim() == string.Empty)
                return;

            FileStream fs = File.Create(fileName);
            byte[] byteData = null;
            byteData = Encoding.ASCII.GetBytes(globalValue.textCopied);
            fs.Write(byteData,0,byteData.Length);
            fs.Close();
        }
        #endregion


        #endregion

        #region "BAck ground worker methods"

        void BackgroundWorker1DoWork(object sender, DoWorkEventArgs e)
        {
            var client = new SmtpClient(settM.smtpclient, settM.smtpport)
            {
                Credentials = new NetworkCredential(settM.username, settM.password),
                EnableSsl = true
            };
            backgroundWorker1.ReportProgress(60);
            client.Send(mmsg);

            client.Dispose();
            backgroundWorker1.ReportProgress(100);
        }

        void BackgroundWorker1RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Mail sent.", "Preview",
                            MessageBoxButtons.OK, MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly, false);
            this.Close();
        }

        void BackgroundWorker1ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar to the BackgroundWorker progress.
            progressBar1.Value = e.ProgressPercentage;
            // Set the text.
            this.Text = " Sending the File.";
        }
        #endregion

        #region "image stuff XXXXck"


        //Generate new image dimensions
        public Size GenerateImageDimensions(int currW, int currH, int destW, int destH)
        {
            //double to hold the final multiplier to use when scaling the image
            double multiplier = 0;

            //string for holding layout
            string layout;

            //determine if it's Portrait or Landscape
            if (currH > currW) layout = "portrait";
            else layout = "landscape";

            switch (layout.ToLower())
            {
                case "portrait":
                    //calculate multiplier on heights
                    if (destH > destW)
                    {
                        multiplier = (double)destW / (double)currW;
                    }

                    else
                    {
                        multiplier = (double)destH / (double)currH;
                    }
                    break;
                case "landscape":
                    //calculate multiplier on widths
                    if (destH > destW)
                    {
                        multiplier = (double)destW / (double)currW;
                    }

                    else
                    {
                        multiplier = (double)destH / (double)currH;
                    }
                    break;
            }

            //return the new image dimensions
            return new Size((int)(currW * multiplier), (int)(currH * multiplier));
        }

        //Resize the image
        private void SetImage(PictureBox pb)
        {
            try
            {
                //create a temp image
                Image img = pb.Image;

                //calculate the size of the image
                Size imgSize = GenerateImageDimensions(img.Width, img.Height, this.pbPreview.Width, this.pbPreview.Height);

                //create a new Bitmap with the proper dimensions
                Bitmap finalImg = new Bitmap(img, imgSize.Width, imgSize.Height);

                //create a new Graphics object from the image
                Graphics gfx = Graphics.FromImage(img);

                //clean up the image (take care of any image loss from resizing)
                gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

                //empty the PictureBox
                pb.Image = null;

                //center the new image
                pb.SizeMode = PictureBoxSizeMode.CenterImage;

                //set the new image
                pb.Image = finalImg;
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion







    }
}

/* code for getting the text in active browser window */
/*
using System;
using System.Text;
using System.Runtime.InteropServices;

public class Example
{
[DllImport("user32.dll")]
static extern int GetFocus();

[DllImport("user32.dll")]
static extern bool AttachThreadInput(uint idAttach, uint idAttachTo, bool fAttach);

[DllImport("kernel32.dll")]
static extern uint GetCurrentThreadId();

[DllImport("user32.dll")]
static extern uint GetWindowThreadProcessId(int hWnd, int ProcessId);    

[DllImport("user32.dll") ]
static extern int GetForegroundWindow();

[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
static extern int SendMessage(int hWnd, int Msg, int wParam, StringBuilder lParam);	

const int WM_SETTEXT = 12;
const int WM_GETTEXT = 13;

public static void Main() 
{
	//Wait 5 seconds to give us a chance to give focus to some edit window,
	//notepad for example
	System.Threading.Thread.Sleep(5000);
	StringBuilder builder = new StringBuilder(500);

	int foregroundWindowHandle = GetForegroundWindow();
	uint remoteThreadId = GetWindowThreadProcessId(foregroundWindowHandle, 0);
    uint currentThreadId = GetCurrentThreadId();

    //AttachTrheadInput is needed so we can get the handle of a focused window in another app
    AttachThreadInput(remoteThreadId, currentThreadId, true);
	//Get the handle of a focused window
    int  focused = GetFocus();
	//Now detach since we got the focused handle
	AttachThreadInput(remoteThreadId, currentThreadId, false);

	//Get the text from the active window into the stringbuilder
	SendMessage(focused, WM_GETTEXT, builder.Capacity, builder);
	Console.WriteLine("Text in active window was " + builder);
	builder.Append(" Extra text");
	//Change the text in the active window
	SendMessage(focused, WM_SETTEXT, 0, builder);
	Console.ReadKey();
    }
}
*/