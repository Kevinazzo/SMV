using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
		static CustomMessageBox MsgBox;
		static DialogResult result;
		#endregion

		public static DialogResult Show(string title, string text)
		{
			MsgBox = new CustomMessageBox();
			MsgBox.lbl_Title.Text = title;
			MsgBox.txtbox_content.Text = text;
			MsgBox.ShowDialog();
			return result;
		}
		public static DialogResult Show(string title, string text, bool singleButton)
		{
			MsgBox = new CustomMessageBox();
			MsgBox.lbl_Title.Text = title;
			MsgBox.txtbox_content.Text = "Huele a"+Environment.NewLine+"KAKA";
			if (singleButton)
			{
				MsgBox.btn_aceptar.Location = new Point(86, 70);
				MsgBox.btn_cancelar.Visible = false;
			}
			MsgBox.ShowDialog();

			return result;
		}
		private void btn_aceptar_Click(object sender, EventArgs e)
		{
			result = DialogResult.Yes;
			this.Close();
		}
		private void btn_cancelar_Click(object sender, EventArgs e)
		{
			result = DialogResult.Cancel;
			this.Close();
		}
		private void btn_close_Click(object sender, EventArgs e)
		{
			result = DialogResult.Abort;
			this.Close();
		}
	}
}
