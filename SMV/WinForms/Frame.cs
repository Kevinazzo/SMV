using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BusinessLogic;

namespace WinForms
{
	public partial class Frame : Form
	{
		public Frame()
		{
			InitializeComponent();
		}
		#region Variables

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		#endregion

		#region methods

		#region colorChangeOnEmptySignInFields
		private bool signInFormEmptyField()
		{//Username textbox is empty
			if (txtbox_tab2_nombreUsuario.Text.Length == (0) || txtbox_tab2_nombreUsuario.Text.Length < 0x4)
			{
				lbl_tab2_nombreUsuario.ForeColor = Color.Red;
				lbl_tab2_contraseña.ForeColor = Color.White;
				lbl_tab2_confirmarcontra.ForeColor = Color.White;
				lbl_tab2_nombres.ForeColor = Color.White;
				lbl_tab2_apellidos.ForeColor = Color.White;
				return false;
			}//Name TextBox is empty
			else if (txtbox_tab2_nombres.Text.Length == 0 || txtbox_tab2_nombres.Text.Length < 0x2)
			{
				lbl_tab2_nombres.ForeColor = Color.Red;
				lbl_tab2_nombreUsuario.ForeColor = Color.White;
				lbl_tab2_contraseña.ForeColor = Color.White;
				lbl_tab2_confirmarcontra.ForeColor = Color.White;
				lbl_tab2_apellidos.ForeColor = Color.White;
				return false;
			}// Last Name textbox is empty
			else if (txtbox_tab2_apellidos.Text.Length == 0 || txtbox_tab2_apellidos.Text.Length < 0x4)
			{
				lbl_tab2_apellidos.ForeColor = Color.Red;
				lbl_tab2_nombreUsuario.ForeColor = Color.White;
				lbl_tab2_contraseña.ForeColor = Color.White;
				lbl_tab2_confirmarcontra.ForeColor = Color.White;
				lbl_tab2_nombres.ForeColor = Color.White;
				return false;
			}//Password textbox is empty
			else if (txtbox_tab2_contraseña.Text.Length == 0 || txtbox_tab2_contraseña.Text.Length < 0x4)
			{
				lbl_tab2_contraseña.ForeColor = Color.Red;
				lbl_tab2_nombreUsuario.ForeColor = Color.White;
				lbl_tab2_confirmarcontra.ForeColor = Color.White;
				lbl_tab2_nombres.ForeColor = Color.White;
				lbl_tab2_apellidos.ForeColor = Color.White;
				return false;
			}//confirm password textbox is empty
			else if (txtbox_tab2_conficontraseña.Text != txtbox_tab2_contraseña.Text)
			{
				lbl_tab2_confirmarcontra.ForeColor = Color.Red;
				lbl_tab2_nombreUsuario.ForeColor = Color.White;
				lbl_tab2_contraseña.ForeColor = Color.White;
				lbl_tab2_nombres.ForeColor = Color.White;
				lbl_tab2_apellidos.ForeColor = Color.White;
				return false;
			}
			else
			{
				lbl_tab2_nombreUsuario.ForeColor = Color.White;
				lbl_tab2_contraseña.ForeColor = Color.White;
				lbl_tab2_confirmarcontra.ForeColor = Color.White;
				lbl_tab2_nombres.ForeColor = Color.White;
				lbl_tab2_apellidos.ForeColor = Color.White;
				return true;
			}
		}
		#endregion
		#region pswMatch
		private void tmr_psw_Tick(object sender, EventArgs e)
		{
			if ((txtbox_tab2_contraseña.Text.Length == 0 && txtbox_tab2_conficontraseña.Text.Length == 0))
			{
				lbl_tab2_pswMatch.Text = "";
			}
			else if ((txtbox_tab2_contraseña.Text == txtbox_tab2_conficontraseña.Text))
			{
				lbl_tab2_pswMatch.Text = "Las contraselas coinciden:)";
				lbl_tab2_pswMatch.ForeColor = Color.Green;
			}
			else
			{
				lbl_tab2_pswMatch.Text = "Las contraseñas no coinciden:(";
				lbl_tab2_pswMatch.ForeColor = Color.Red;
			}
		}
		#endregion

		public void cleanTab2Txtbox()
		{
			txtbox_tab2_apellidos.Text = "";
			txtbox_tab2_conficontraseña.Text = "";
			txtbox_tab2_contraseña.Text = "";
			txtbox_tab2_email.Text = "";
			txtbox_tab2_nombres.Text = "";
			txtbox_tab2_nombreUsuario.Text = "";
		}
		public void changeColorTab2Labels()
		{
			lbl_tab2_apellidos.ForeColor = Color.White;
			lbl_tab2_confirmarcontra.ForeColor = Color.White;
			lbl_tab2_contraseña.ForeColor = Color.White;
			lbl_tab2_nombres.ForeColor = Color.White;
			lbl_tab2_nombreUsuario.ForeColor = Color.White;
		}

		#endregion

		#region Events

		#region windowBorder
		private void pnl_header_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
		private void flatLabel3_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}






		#endregion

		private void llb_CrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			tabControl.SelectedTab = tab2_registro;
			cleanTab2Txtbox();
			tmr_psw.Enabled = true;
		}
		private void btn_tab2_cancelar_Click(object sender, EventArgs e)
		{
			tabControl.SelectedTab = tab1_login;
			txtbox_contraseña.Text = "";
			changeColorTab2Labels();
			tmr_psw.Enabled = false;
		}
		private void flatClose1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btn_tab2_aceptar_Click(object sender, EventArgs e)
		{
			if (signInFormEmptyField())
			{
				MessageBox.Show("correcto");
			}
		}


		#endregion


	}
}
