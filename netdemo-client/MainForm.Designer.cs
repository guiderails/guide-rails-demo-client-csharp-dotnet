namespace Client
{
    partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.labelURL = new System.Windows.Forms.Label();
			this.textBoxURL = new System.Windows.Forms.TextBox();
			this.labelMessage = new System.Windows.Forms.Label();
			this.buttonGetMessage = new System.Windows.Forms.Button();
			this.labelMath = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelURL
			// 
			this.labelURL.AutoSize = true;
			this.labelURL.Location = new System.Drawing.Point(12, 13);
			this.labelURL.Name = "labelURL";
			this.labelURL.Size = new System.Drawing.Size(63, 13);
			this.labelURL.TabIndex = 0;
			this.labelURL.Text = "Server URL";
			// 
			// textBoxURL
			// 
			this.textBoxURL.Location = new System.Drawing.Point(82, 10);
			this.textBoxURL.MaxLength = 64;
			this.textBoxURL.Name = "textBoxURL";
			this.textBoxURL.Size = new System.Drawing.Size(265, 20);
			this.textBoxURL.TabIndex = 1;
			this.textBoxURL.TextChanged += new System.EventHandler(this.textBoxURL_TextChanged);
			// 
			// labelMessage
			// 
			this.labelMessage.AutoSize = true;
			this.labelMessage.Location = new System.Drawing.Point(12, 77);
			this.labelMessage.Name = "labelMessage";
			this.labelMessage.Size = new System.Drawing.Size(16, 13);
			this.labelMessage.TabIndex = 2;
			this.labelMessage.Text = "...";
			// 
			// buttonGetMessage
			// 
			this.buttonGetMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonGetMessage.AutoSize = true;
			this.buttonGetMessage.Location = new System.Drawing.Point(577, 393);
			this.buttonGetMessage.Name = "buttonGetMessage";
			this.buttonGetMessage.Size = new System.Drawing.Size(80, 23);
			this.buttonGetMessage.TabIndex = 3;
			this.buttonGetMessage.Text = "Get Message";
			this.buttonGetMessage.UseVisualStyleBackColor = true;
			this.buttonGetMessage.Click += new System.EventHandler(this.buttonGetMessage_Click);
			// 
			// labelMath
			// 
			this.labelMath.AutoSize = true;
			this.labelMath.Location = new System.Drawing.Point(15, 402);
			this.labelMath.Name = "labelMath";
			this.labelMath.Size = new System.Drawing.Size(25, 13);
			this.labelMath.TabIndex = 4;
			this.labelMath.Text = "???";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(669, 428);
			this.Controls.Add(this.labelMath);
			this.Controls.Add(this.buttonGetMessage);
			this.Controls.Add(this.labelMessage);
			this.Controls.Add(this.textBoxURL);
			this.Controls.Add(this.labelURL);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Get Message";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label labelURL;
		private System.Windows.Forms.TextBox textBoxURL;
		private System.Windows.Forms.Label labelMessage;
		private System.Windows.Forms.Button buttonGetMessage;
		private System.Windows.Forms.Label labelMath;
	}
}

