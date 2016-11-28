using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinForms
{
	public partial class CustomMessageBox : Form
	{
		public CustomMessageBox()
		{
			InitializeComponent();
		}
		#region Variables
		public enum CustomMessageBoxButtons { Ok, OkCancel }
		public enum CustomMessageBoxTxtBoxState { VisibleChar, PasswordChar, VisibleCharReadOnly }
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();
		#endregion
		public DialogResult Show (string text, CustomMessageBoxButtons buttons)
		{
			txtbox_content2.Text = text;
			lbl_Title.Text = "";
			if (buttons == CustomMessageBoxButtons.Ok)
			{
				btn_aceptar.Location = new Point(86, 70);
				btn_cancelar.Visible = false;
			}
			ShowDialog();
			return DialogResult;
		}
		public DialogResult Show(string text, string title, CustomMessageBoxButtons buttons)
		{
			txtbox_content2.Text = text;
			lbl_Title.Text = title;
			if (buttons == CustomMessageBoxButtons.Ok)
			{
				btn_aceptar.Location = new Point(86, 70);
				btn_cancelar.Visible = false;
			}
			ShowDialog();
			return DialogResult;
		}
		public DialogResult Show(string text, string title, CustomMessageBoxButtons buttons,
			CustomMessageBoxTxtBoxState txtBoxState)
		{
			txtbox_content2.Text = text;
			lbl_Title.Text = title;
			if (buttons == CustomMessageBoxButtons.Ok)
			{
				btn_aceptar.Location = new Point(86, 70);
				btn_cancelar.Visible = false;
			}
			switch (txtBoxState)
			{
				case CustomMessageBoxTxtBoxState.VisibleChar:
					txtbox_content2.UseSystemPasswordChar = false;
					txtbox_content2.ReadOnly = false;
					break;
				case CustomMessageBoxTxtBoxState.PasswordChar:
					txtbox_content2.UseSystemPasswordChar = true;
					txtbox_content2.ReadOnly = false;
					break;
				case CustomMessageBoxTxtBoxState.VisibleCharReadOnly:
					txtbox_content2.UseSystemPasswordChar = false;
					txtbox_content2.ReadOnly = true;
					break;
				default:
					break;
			}
			ShowDialog();
			return DialogResult;
		}

		private void btn_aceptar_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void btn_cancelar_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}

		private void btn_close_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void header_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
	}
}
