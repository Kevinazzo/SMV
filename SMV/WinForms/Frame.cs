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
using MySql.Data.MySqlClient;


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

		CustomMessageBox MsgBox = new CustomMessageBox();

		#endregion

		#region methods

		#region startup

		public void startupConnectToDB()
		{

			MsgBox.Show("", "Contraseña de Usuario ROOT", CustomMessageBox.CustomMessageBoxButtons.OkCancel, CustomMessageBox.CustomMessageBoxTxtBoxState.PasswordChar);
			switch (MsgBox.DialogResult)
			{
				case DialogResult.None:
					break;
				case DialogResult.OK:
					try
					{
						BusinessLogic.Functions.connectToDB();
					}
					catch (MySqlException)
					{
						MessageBox.Show("Contraseña incorrecta");
						startupConnectToDB();
					}
					break;
				case DialogResult.Cancel:
					break;
				case DialogResult.Abort:
					break;
				case DialogResult.Retry:
					break;
				case DialogResult.Ignore:
					break;
				case DialogResult.Yes:
					break;
				case DialogResult.No:
					break;
				default:
					break;
			}
			try
			{
				BusinessLogic.Functions.connectToDB();
			}
			catch (MySqlException)
			{
				MsgBox.Show("La Contraseña es incorrecta", CustomMessageBox.CustomMessageBoxButtons.Ok);
			}
		}



		#endregion
		#region registerTabLabelColorChange

		private bool registerTabColorOnEmptyField()
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
			else if (txtbox_tab2_registro.Text.Length == 0 || txtbox_tab2_registro.Text.Length < 0x4)
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

		#region LGV

		public void refreshListView()
		{
			for (int i = 0; i < BusinessLogic.Functions.courseList[0].Select(a => a).Count(); i++)
			{
				ListViewItem item = new ListViewItem(BusinessLogic.Functions.courseList[0].ElementAt(i));
				item.SubItems.Add(BusinessLogic.Functions.courseList[1].ElementAt(i));
				item.SubItems.Add(BusinessLogic.Functions.courseList[2].ElementAt(i));
				item.Name = BusinessLogic.Functions.courseList[0].ElementAt(i);
				lvw_tab6_GroupList.Items.Add(item);
			}
		}
		public void refreshStudentListBiew()
		{
			for (int i = 0; i < BusinessLogic.Functions.BLLmasterList[0].Select(a=> a).Count(); i++)
			{
				ListViewItem item = new ListViewItem(BusinessLogic.Functions.BLLmasterList[0].ElementAt(i));
				item.Name = BusinessLogic.Functions.BLLmasterList[0].ElementAt(i);
				lvw_tab7_enrolledStudents.Items.Add(item);
			}
		}

		#endregion

		public void loadCurrentSession()
		{
			if (BusinessLogic.Functions.loggedAsTeacher)
			{
				lbl_tab3_NombreProfesor.Text = "Bienvenido " + BusinessLogic.Functions.currentSession.name;
				tabControl.SelectedTab = tab3_Docente_VistaGeneral;
				cleanTab1Txtbox();
			}
			else if (BusinessLogic.Functions.logged)
			{
				cleanTab1Txtbox();
				tabControl.SelectedTab = tab3_Alumno_VistaGeneral;
				lbl_tab3_NombreAlumno.Text = "Bienvenido " + BusinessLogic.Functions.currentSession.name;
				lbl_tab4_NombreAlumno.Text = BusinessLogic.Functions.currentSession.name;
			}
		}
		public void cleanTab1Txtbox()
		{
			txtbox_contraseña.Text = "";
			txtbox_rootPsw.Text = "";
			txtbox_usuario.Text = "";

		}
		public void cleanTab5TxtBox()
		{
			txtbox_tab5_courseName.Text = "";
			txtbox_tab5_grade.Text = "";
			txtbox_tab5_grup.Text = "";
		}
		public void cleanTab2Txtbox()
		{
			txtbox_tab2_registro.Text = "";
			txtbox_tab2_codigo.Text = "";
			txtbox_tab2_conficontraseña.Text = "";
			txtbox_tab2_contraseña.Text = "";
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
			if (registerTabColorOnEmptyField())
			{
				if (BusinessLogic.Functions.VerifyExistingUserToIns(txtbox_tab2_nombreUsuario.Text))
				{
					if (BusinessLogic.Functions.verifyCode(txtbox_tab2_codigo.Text))
					{
						BusinessLogic.Functions.registerNewUser(txtbox_tab2_nombreUsuario.Text, txtbox_tab2_nombres.Text,
							txtbox_tab2_registro.Text, txtbox_tab2_contraseña.Text, txtbox_tab2_codigo.Text);
						MsgBox.Show("Cuenta creada");
						cleanTab2Txtbox();
						tabControl.SelectedTab = tab1_login;
					}
					else
					{
						BusinessLogic.Functions.registerNewUser(txtbox_tab2_nombreUsuario.Text, txtbox_tab2_nombres.Text,
							txtbox_tab2_registro.Text, txtbox_tab2_contraseña.Text, txtbox_tab2_codigo.Text);
						MsgBox.Show("Cuenta creada");
						cleanTab2Txtbox();
						tabControl.SelectedTab = tab1_login;
					}
				}
				else
				{
					MsgBox.Show("El Usuario ya Existe");
				}
			}
			else
			{

				MsgBox.Show("Verifique los campos marcados de rojo");
			}
		}
		private void btn_ingresar_Click(object sender, EventArgs e)
		{
			if (BusinessLogic.Functions.logInEmptyFields(txtbox_usuario.Text, txtbox_contraseña.Text))
			{
				if (BusinessLogic.Functions.verifyUserDataTologIn(txtbox_usuario.Text, txtbox_contraseña.Text))
				{
					loadCurrentSession();
					BusinessLogic.Functions.selectCourses();
					BusinessLogic.Functions.importCourses();
				}
				else
				{

					MsgBox.Show("Datos Incorrectos");
				}
			}
			else
			{
				MsgBox.Show("Rellene Los campos Vacios");
			}
		}
		private void Cerrar_Click_1(object sender, EventArgs e)
		{
			try
			{
				BusinessLogic.Functions.closeConnection();
				this.Close();
			}
			catch (Exception)
			{
				this.Close();
			}
		}
		private void btn_connectToDataBase_Click(object sender, EventArgs e)
		{
			try
			{
				BusinessLogic.Functions.startupSETPassword(txtbox_rootPsw.Text);
				BusinessLogic.Functions.connectToDB();
				BusinessLogic.Functions.connectedToDB = true;
			}
			catch (MySqlException)
			{

				MsgBox.Show("Contraseña incorrecta");
			}
			if (BusinessLogic.Functions.connectedToDB)
			{
				try
				{
					BusinessLogic.Functions.BLLstartupVerifyDB();
					tabControl.SelectedTab = tab1_login;
				}
				catch (MySqlException)
				{

					if (MsgBox.Show("la Base de Datos no existe, Quiere crearla?") == DialogResult.OK)
					{
						try
						{
							BusinessLogic.Functions.startupCreateDatabase();
							tabControl.SelectedTab = tab1_login;
						}
						catch (MySqlException ef)
						{
							MessageBox.Show(ef.ToString());
						}
					}
					else
					{
						Application.Exit();
					}
				}
			}
		}
		private void btn_tab3_GrupoInscrito_Click(object sender, EventArgs e)
		{
			tabControl.SelectedTab = tab4_Alumno_ListaDeCursos;
		}

		private void btn_tab3_CrearGrupoPrf_Click(object sender, EventArgs e)
		{
			tabControl.SelectedTab = tab5_Docente_CrearCurso;
		}
		private void btn_tab5_aceptar_Click(object sender, EventArgs e)
		{
			BusinessLogic.Functions.createcourse(txtbox_tab5_courseName.Text, txtbox_tab5_grade.Text[0], txtbox_tab5_grup.Text[0]);
			cleanTab5TxtBox();
			BusinessLogic.Functions.clearCourseList();
			BusinessLogic.Functions.selectCourses();
			BusinessLogic.Functions.importCourses();
			refreshListView();
			tabControl.SelectedTab = tab6_Docente_ListaDeCursos;
			
		}

		private void btn_tab6_regresar_Click(object sender, EventArgs e)
		{
			tabControl.SelectedTab = tab3_Docente_VistaGeneral;
			lvw_tab6_GroupList.Items.Clear();
		}

		private void btn_tab3_GrupolistaProf_Click(object sender, EventArgs e)
		{
			tabControl.SelectedTab = tab6_Docente_ListaDeCursos;
			lvw_tab6_GroupList.Items.Clear();
			refreshListView();
		}

		private void tab6_Docente_CursoLista_Click(object sender, EventArgs e)
		{

		}

		private void dgv_courseList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void flatButton1_Click(object sender, EventArgs e)
		{

		}
		#endregion

		private void btn_tab5_cancelar_Click(object sender, EventArgs e)
		{
			tabControl.SelectedTab = tab3_Docente_VistaGeneral;
		}
		private void btn_tab6_EraseCourse_Click(object sender, EventArgs e)
		{
			if (lvw_tab6_GroupList.SelectedItems.Count >0)
			{
				if (MsgBox.Show("Desea eliminar el curso seleccionado?", CustomMessageBox.CustomMessageBoxButtons.OkCancel) == DialogResult.OK)
				{
					BusinessLogic.Functions.deleteCourse(lvw_tab6_GroupList.SelectedItems[0].Name);
					BusinessLogic.Functions.clearCourseList();
					BusinessLogic.Functions.selectCourses();
					BusinessLogic.Functions.importCourses();
					lvw_tab6_GroupList.Items[lvw_tab6_GroupList.SelectedItems[0].Name].Remove();
				}
			}
		}

		private void btn_tab7_regresarAListaDeCurso_Click(object sender, EventArgs e)
		{
			tabControl.SelectedTab = tab4_Alumno_ListaDeCursos;
		}
		private void flatButton2_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtbox_tab7_userName.Text.Length > 0)
				{
					BusinessLogic.Functions.enrollStudent(txtbox_tab7_userName.Text, BusinessLogic.Functions.getCourseID(lbl_tab7_inscribira.Text));
					ListViewItem item = new ListViewItem(txtbox_tab7_userName.Text);
					lvw_tab7_enrolledStudents.Items.Add(item);
					txtbox_tab7_userName.Text = "";
				}
			
			}
			catch (MySqlException)
			{ 

			}
		}
		private void btn_tab6_EnrollStudents_Click(object sender, EventArgs e)
		{
			if (lvw_tab6_GroupList.SelectedItems.Count > 0)
			{
				BusinessLogic.Functions.clearBLLMasterList();
				BusinessLogic.Functions.getMasterList(BusinessLogic.Functions.getCourseID(lvw_tab6_GroupList.SelectedItems[0].Text));
				BusinessLogic.Functions.importMasterList();
				refreshStudentListBiew();
				tabControl.SelectedTab = tab7_Docente_InscripcionAlumnos;
				lbl_tab7_inscribira.Text = lvw_tab6_GroupList.SelectedItems[0].Name;
			}
			
		}

		private void btn_tab7_eliminar_Click(object sender, EventArgs e)
		{
			if (lvw_tab7_enrolledStudents.SelectedItems.Count >0)
			{
				if (MsgBox.Show("Desea Borrar el Alumno Seleccionado?",CustomMessageBox.CustomMessageBoxButtons.OkCancel)==DialogResult.OK)
				{
					BusinessLogic.Functions.eraseStudent(lvw_tab7_enrolledStudents.SelectedItems[0].Text, BusinessLogic.Functions.getCourseID(txtbox_tab7_userName.Text));
					lvw_tab7_enrolledStudents.SelectedItems[0].Remove();
				}
			}	
		}

		private void btn_tab7_upgradeCALS_Click(object sender, EventArgs e)
		{
			try
			{
				BusinessLogic.Functions.updateCals(lvw_tab7_enrolledStudents.SelectedItems[0].Name, cal1.Text, cal2.Text, cal3.Text, cal4.Text, cal5.Text, cal6.Text);
			}
			catch (MySqlException)
			{
				MsgBox.Show("Error");
			}
		}
	}
}