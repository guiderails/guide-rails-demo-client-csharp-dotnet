using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;

namespace Client
{
    public partial class MainForm : Form
    {
		public MainForm() {
			InitializeComponent();
		}

		void MakeRequest() {
			HttpClientHandler handler = new HttpClientHandler();
			HttpClient httpClient = new HttpClient(handler);
			HttpResponseMessage response;
			try {
				response = httpClient.GetAsync(textBoxURL.Text).Result;
				labelMessage.Text = response.Content.ReadAsStringAsync().Result;
			} catch (Exception ex) {
				labelMessage.Text = ex.Message;
			}
		}

		private void MainForm_Load(object sender, EventArgs e) {
			SharedLib.MathOperations m = new SharedLib.MathOperations();
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			labelMath.Text = "From shared library: 1 + 1 = " + m.Add(1, 1).ToString();
		}

		private void buttonGetMessage_Click(object sender, EventArgs e) {
			labelMessage.Text = "";
			if (0 < textBoxURL.Text.Length) {
				textBoxURL.BackColor = Color.White;
				MakeRequest();
			} else {
				textBoxURL.Focus();
				textBoxURL.BackColor = Color.Pink;
			}
		}

		private void textBoxURL_TextChanged(object sender, EventArgs e) {
			TextBox t = (TextBox)sender;
			if (t.Text.Length > 0) {
				t.BackColor = Color.White;
			} else {
				t.BackColor = Color.Pink;
			}
		}
	}
}
