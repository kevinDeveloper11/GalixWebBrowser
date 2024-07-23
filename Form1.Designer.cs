namespace GalixWEB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnIR = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUPDATE = new System.Windows.Forms.Button();
            this.btnSTOP = new System.Windows.Forms.Button();
            this.btnADELANTE = new System.Windows.Forms.Button();
            this.btnATRAS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIR
            // 
            this.btnIR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIR.Image = ((System.Drawing.Image)(resources.GetObject("btnIR.Image")));
            this.btnIR.Location = new System.Drawing.Point(978, 6);
            this.btnIR.Name = "btnIR";
            this.btnIR.Size = new System.Drawing.Size(38, 43);
            this.btnIR.TabIndex = 4;
            this.btnIR.UseVisualStyleBackColor = true;
            this.btnIR.Click += new System.EventHandler(this.btnIR_Click);
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.Location = new System.Drawing.Point(232, 18);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(689, 20);
            this.txtURL.TabIndex = 5;
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(13, 64);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(500, 250);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(1003, 600);
            this.webBrowser1.TabIndex = 6;
            this.webBrowser1.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(927, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 43);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(188, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 43);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.Image = ((System.Drawing.Image)(resources.GetObject("btnUPDATE.Image")));
            this.btnUPDATE.Location = new System.Drawing.Point(144, 6);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(38, 43);
            this.btnUPDATE.TabIndex = 3;
            this.btnUPDATE.UseVisualStyleBackColor = true;
            this.btnUPDATE.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSTOP
            // 
            this.btnSTOP.Image = ((System.Drawing.Image)(resources.GetObject("btnSTOP.Image")));
            this.btnSTOP.Location = new System.Drawing.Point(100, 6);
            this.btnSTOP.Name = "btnSTOP";
            this.btnSTOP.Size = new System.Drawing.Size(38, 43);
            this.btnSTOP.TabIndex = 2;
            this.btnSTOP.UseVisualStyleBackColor = true;
            this.btnSTOP.Click += new System.EventHandler(this.btnSTOP_Click);
            // 
            // btnADELANTE
            // 
            this.btnADELANTE.Image = ((System.Drawing.Image)(resources.GetObject("btnADELANTE.Image")));
            this.btnADELANTE.Location = new System.Drawing.Point(56, 6);
            this.btnADELANTE.Name = "btnADELANTE";
            this.btnADELANTE.Size = new System.Drawing.Size(38, 43);
            this.btnADELANTE.TabIndex = 1;
            this.btnADELANTE.UseVisualStyleBackColor = true;
            this.btnADELANTE.Click += new System.EventHandler(this.btnADELANTE_Click);
            // 
            // btnATRAS
            // 
            this.btnATRAS.Image = ((System.Drawing.Image)(resources.GetObject("btnATRAS.Image")));
            this.btnATRAS.Location = new System.Drawing.Point(12, 6);
            this.btnATRAS.Name = "btnATRAS";
            this.btnATRAS.Size = new System.Drawing.Size(38, 43);
            this.btnATRAS.TabIndex = 0;
            this.btnATRAS.UseVisualStyleBackColor = true;
            this.btnATRAS.Click += new System.EventHandler(this.btnATRAS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 687);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnIR);
            this.Controls.Add(this.btnUPDATE);
            this.Controls.Add(this.btnSTOP);
            this.Controls.Add(this.btnADELANTE);
            this.Controls.Add(this.btnATRAS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galix Web Browser Beta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnATRAS;
        private System.Windows.Forms.Button btnADELANTE;
        private System.Windows.Forms.Button btnSTOP;
        private System.Windows.Forms.Button btnUPDATE;
        private System.Windows.Forms.Button btnIR;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

