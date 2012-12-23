namespace PrintNSend
{
    partial class TextPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextPreview));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnAttachBody = new System.Windows.Forms.ToolStripButton();
            this.btnTglSource = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(339, 309);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnAttachBody,
            this.toolStripSeparator1,
            this.btnTglSource});
            this.toolStrip1.Location = new System.Drawing.Point(0, 284);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(339, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(339, 284);
            this.webBrowser.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::PrintNSend.Properties.Resources.saveImage;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(51, 22);
            this.btnSave.Text = "Save";
            this.btnSave.ToolTipText = "Save text";
            this.btnSave.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnAttachBody
            // 
            this.btnAttachBody.CheckOnClick = true;
            this.btnAttachBody.Image = global::PrintNSend.Properties.Resources.attach;
            this.btnAttachBody.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAttachBody.Name = "btnAttachBody";
            this.btnAttachBody.Size = new System.Drawing.Size(62, 22);
            this.btnAttachBody.Text = "Attach";
            this.btnAttachBody.ToolTipText = "Attach text to body";
            this.btnAttachBody.Click += new System.EventHandler(this.btnAttachBody_Click);
            // 
            // btnTglSource
            // 
            this.btnTglSource.CheckOnClick = true;
            this.btnTglSource.Image = global::PrintNSend.Properties.Resources.source;
            this.btnTglSource.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTglSource.Name = "btnTglSource";
            this.btnTglSource.Size = new System.Drawing.Size(54, 22);
            this.btnTglSource.Text = "Html";
            this.btnTglSource.Click += new System.EventHandler(this.btnTglSource_Click);
            // 
            // TextPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 309);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TextPreview";
            this.Text = "Text Preview";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextPreview_FormClosing);
            this.Load += new System.EventHandler(this.TextPreview_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnAttachBody;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnTglSource;
    }
}