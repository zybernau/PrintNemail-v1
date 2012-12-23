/*
 * Created by SharpDevelop.
 * User: Raja
 * Date: 8/5/2012
 * Time: 11:43 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PrintNSend
{
	public sealed class NotificationIcon
    {
        #region Declaration
        private NotifyIcon notifyIcon;
		private ContextMenu notificationMenu;
		private PrintNSend pns1;
        private IntPtr Handle;
        #endregion

        #region win32 API
        [DllImport("user32.dll")]
        static extern int GetFocus();

        [DllImport("user32.dll")]
        static extern bool AttachThreadInput(uint idAttach, uint idAttachTo, bool fAttach);

        [DllImport("kernel32.dll")]
        static extern uint GetCurrentThreadId();

        [DllImport("user32.dll")]
        static extern uint GetWindowThreadProcessId(int hWnd, int ProcessId);

        [DllImport("user32.dll")]
        static extern int GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern int SendMessage(int hWnd, int Msg, int wParam, StringBuilder lParam);

        const int WM_SETTEXT = 12;
        const int WM_GETTEXT = 13;
        const int WM_COPYTEXT = 769;
        #endregion

		#region Initialize icon and menu
		public NotificationIcon()
		{
			notifyIcon = new NotifyIcon();
            
			notificationMenu = new ContextMenu(InitializeMenu());
			notifyIcon.DoubleClick += IconDoubleClick;
            
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationIcon));
			notifyIcon.Icon = (Icon)resources.GetObject("send");
			notifyIcon.ContextMenu = notificationMenu;
		}
		
		private MenuItem[] InitializeMenu()
		{
			MenuItem[] menu = new MenuItem[] {
				new MenuItem("&Settings",menuSettingsClick),
				new MenuItem("Exit", menuExitClick)
			};
			return menu;
		}
		#endregion
		
		#region Main - Program entry point
		/// <summary>Program entry point.</summary>
		/// <param name="args">Command Line Arguments</param>
		[STAThread]
		public static void Main(string[] args)
		{

            NotificationIcon notifi = new NotificationIcon();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            dummyForm dummyForm = new dummyForm();
            //minimise, make false the following, control bos, shhow icon, show in task bar, 
            // and the size grip style is none
            dummyForm.ControlBox = false;
            dummyForm.ShowIcon = false;
            dummyForm.ShowInTaskbar = false;
            dummyForm.WindowState = FormWindowState.Minimized;
            //dummyForm.Opacity= 20
            //dummyForm.Size = new Size(140, 150);
            dummyForm.TopMost = true;
            dummyForm.Visible = false;
            dummyForm.ShowInTaskbar = false;
            dummyForm.Show();

            Hotkey hk = new Hotkey();
            //Keys.O,true,false,false,false
            //Hotkey hk = new Hotkey(Keys.P,false,true,false,false);
            hk.KeyCode = Keys.F9;
            hk.Windows = true;
            //hk.Pressed += delegate { MessageBox.Show("windows Key pressed"); };
            hk.Pressed += notifi.IconDoubleClick;

            if (!hk.GetCanRegister(dummyForm))
            {
                Console.WriteLine("Whoops, looks like attempts to register will fail " +
                                  "or throw an exception, show error to user");
            }
            else
            {
                hk.Register(dummyForm);
            }


			bool isFirstInstance;
			// Please use a unique name for the mutex to prevent conflicts with other programs
			using (Mutex mtx = new Mutex(true, "PrintNSend", out isFirstInstance)) {
				if (isFirstInstance) {
					NotificationIcon notificationIcon = new NotificationIcon();
					notificationIcon.notifyIcon.Visible = true;
                    
					Application.Run();
					notificationIcon.notifyIcon.Dispose();
				} else {
					// The application is already running
					// TODO: Display message box or change focus to existing application instance
				}
			} // releases the Mutex
		}
		#endregion
		
		#region Event Handlers


		private void menuSettingsClick(object sender, EventArgs e)
		{
			
			Settings sets = new Settings();
			sets.TopMost = true;
			
		// make center
			sets.StartPosition = FormStartPosition.CenterScreen;
			sets.Show();
				
		}
		
		private void menuExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		private void IconDoubleClick(object sender, EventArgs e)
		{
			CaptureAndSend();
		}
		
		private void CaptureAndSend()
		{
			
			try {
                getSaveText();
				pns1 = new PrintNSend();
				string result = pns1.Pns(this.Handle);
				
			} 
			catch (Exception ex) {
				MessageBox.Show("error occurs: " + ex.ToString());
				
			}
			finally
			{
				pns1.Dispose();
			}
		}

        /// <summary>
        /// gets the selected text from the window and have it in soe static classes.
        /// </summary>
        private void getSaveText()
        {
            StringBuilder builder = new StringBuilder(500);

            int foregroundWindowHandle = GetForegroundWindow();
            uint remoteThreadId = GetWindowThreadProcessId(foregroundWindowHandle, 0);
            uint currentThreadId = GetCurrentThreadId();

            //AttachTrheadInput is needed so we can get the handle of a focused window in another app
            AttachThreadInput(remoteThreadId, currentThreadId, true);
            //Get the handle of a focused window
            int focused = GetFocus();
            //Now detach since we got the focused handle
            AttachThreadInput(remoteThreadId, currentThreadId, false);

            //Get the text from the active window into the stringbuilder
            SendMessage(focused, WM_COPYTEXT, builder.Capacity, builder);
            ClipboardAsync clip = new ClipboardAsync();
            globalValue.textCopied = clip.GetText(TextDataFormat.Html);
        }

		#endregion
	}

    public static class globalValue
    {
        public static string textCopied = "";

    }
}
