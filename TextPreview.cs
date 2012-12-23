using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintNSend
{
    public partial class TextPreview : Form
    {
        private string textCopied = "";
        public delegate void addTextHandler(bool toggleText);
        public event addTextHandler addText;
        private bool textAttached;
        //constr
        public TextPreview(string _textCopied,bool _textAttached)
        {
            InitializeComponent();
            textCopied = _textCopied;
            textAttached = _textAttached;
        }

        #region Events

        //load the form 
        private void TextPreview_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = textCopied;
            btnAttachBody.Checked = textAttached;
            webBrowser.DocumentText = textCopied;
            btnTglSource.Checked = true;
            btnTglSource_Click(null, null);
        }

        //save button
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            globalValue.textCopied = textCopied = richTextBox1.Text;
        }

        private void TextPreview_FormClosing(object sender, FormClosingEventArgs e)
        {
            globalValue.textCopied = richTextBox1.Text;
        }

        // trigger the event to insert the text in body
        private void btnAttachBody_Click(object sender, EventArgs e)
        {
            if (addText != null)
                addText(btnAttachBody.Checked);
            btnAttachBody.Text = (btnAttachBody.Checked) ? "Remove" : "Attach";
        }
        private void btnTglSource_Click(object sender, EventArgs e)
        {
            btnTglSource.Text = (btnTglSource.Checked) ? "Design" : "Source";
            richTextBox1.Visible = btnTglSource.Checked;
            webBrowser.Visible = !btnTglSource.Checked;
            webBrowser.DocumentText = textCopied;
        }

    #endregion

  


    }
}
