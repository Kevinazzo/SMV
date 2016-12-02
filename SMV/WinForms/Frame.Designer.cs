namespace WinForms
{
	partial class Frame
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
			this.components = new System.ComponentModel.Container();
			this.pnl_header = new System.Windows.Forms.Panel();
			this.flatClose1 = new FlatUI.FlatClose();
			this.flatMini1 = new FlatUI.FlatMini();
			this.flatLabel3 = new FlatUI.FlatLabel();
			this.pnl_body = new System.Windows.Forms.Panel();
			this.tabControl = new FlatUI.FlatTabControl();
			this.tab0_Startup = new System.Windows.Forms.TabPage();
			this.lbl_rootPsw = new FlatUI.FlatLabel();
			this.txtbox_rootPsw = new FlatUI.FlatTextBox();
			this.btn_connectToDB = new FlatUI.FlatButton();
			this.BY_EPI = new iTalk.iTalk_Label();
			this.SMV_LOGO = new System.Windows.Forms.Label();
			this.tab1_login = new System.Windows.Forms.TabPage();
			this.llb_CrearCuenta = new System.Windows.Forms.LinkLabel();
			this.flatLabel4 = new FlatUI.FlatLabel();
			this.trash_lblContraseña = new FlatUI.FlatLabel();
			this.lbl_Usuario = new FlatUI.FlatLabel();
			this.btn_ingresar = new FlatUI.FlatButton();
			this.txtbox_contraseña = new FlatUI.FlatTextBox();
			this.txtbox_usuario = new FlatUI.FlatTextBox();
			this.tab2_registro = new System.Windows.Forms.TabPage();
			this.iTalk_Label2 = new iTalk.iTalk_Label();
			this.lbl_tab2_pswMatch = new System.Windows.Forms.Label();
			this.iTalk_Label1 = new iTalk.iTalk_Label();
			this.lbl_tab2_dejeseBlanco = new FlatUI.FlatLabel();
			this.btn_tab2_cancelar = new FlatUI.FlatButton();
			this.btn_tab2_aceptar = new FlatUI.FlatButton();
			this.txtbox_tab2_conficontraseña = new FlatUI.FlatTextBox();
			this.lbl_tab2_confirmarcontra = new FlatUI.FlatLabel();
			this.txtbox_tab2_contraseña = new FlatUI.FlatTextBox();
			this.lbl_tab2_contraseña = new FlatUI.FlatLabel();
			this.txtbox_tab2_codigo = new FlatUI.FlatTextBox();
			this.lbl_tab2_codigoDocente = new FlatUI.FlatLabel();
			this.txtbox_tab2_registro = new FlatUI.FlatTextBox();
			this.lbl_tab2_apellidos = new FlatUI.FlatLabel();
			this.lbl_tab2_nombres = new FlatUI.FlatLabel();
			this.txtbox_tab2_nombres = new FlatUI.FlatTextBox();
			this.lbl_tab2_registro = new FlatUI.FlatLabel();
			this.txtbox_tab2_nombreUsuario = new FlatUI.FlatTextBox();
			this.lbl_tab2_nombreUsuario = new FlatUI.FlatLabel();
			this.tab3_Alumno_VistaGeneral = new System.Windows.Forms.TabPage();
			this.llb_tab3_PromedioGeneral = new System.Windows.Forms.LinkLabel();
			this.llb_tab3_materia4 = new System.Windows.Forms.LinkLabel();
			this.llb_tab3_materia3 = new System.Windows.Forms.LinkLabel();
			this.llb_tab3_materia2 = new System.Windows.Forms.LinkLabel();
			this.llb_tab3_materia1 = new System.Windows.Forms.LinkLabel();
			this.lbl_tab3_NombreAlumno = new System.Windows.Forms.Label();
			this.btn_tab3_listagrupo = new FlatUI.FlatStickyButton();
			this.btn_tab3_GrupoInscrito = new FlatUI.FlatStickyButton();
			this.radGrp_tab3_Progresototal5 = new iTalk.iTalk_ProgressBar();
			this.radGrp_tab3_Progresototal3 = new iTalk.iTalk_ProgressBar();
			this.radGrp_tab3_Progresototal4 = new iTalk.iTalk_ProgressBar();
			this.radGrp_tab3_Progresototal2 = new iTalk.iTalk_ProgressBar();
			this.radGrp_tab3_Progresototal = new iTalk.iTalk_ProgressBar();
			this.tab3_Docente_VistaGeneral = new System.Windows.Forms.TabPage();
			this.lbl_tab3_selectOpcion = new FlatUI.FlatLabel();
			this.btn_tab3_CrearGrupoPrf = new FlatUI.FlatButton();
			this.btn_tab3_GrupolistaProf = new FlatUI.FlatButton();
			this.btn_tab3_CursoGeneralProfesor = new FlatUI.FlatButton();
			this.lbl_tab3_NombreProfesor = new System.Windows.Forms.Label();
			this.tab4_Alumno_ListaDeCursos = new System.Windows.Forms.TabPage();
			this.radgrp_tab4_materiaProgreso = new iTalk.iTalk_ProgressBar();
			this.dataGridview_tab4 = new System.Windows.Forms.DataGridView();
			this.radGrp_tab3_PromedioGeneral = new iTalk.iTalk_ProgressBar();
			this.lbl_tab4_NombreAlumno = new FlatUI.FlatLabel();
			this.tab4_Docente_CursoGeneral = new System.Windows.Forms.TabPage();
			this.regresar = new FlatUI.FlatButton();
			this.lbl_tab4_AlumnosVuln = new System.Windows.Forms.Label();
			this.dgv_tab4_Vulnerables = new System.Windows.Forms.DataGridView();
			this.lbl_tab4_NombreCurso = new System.Windows.Forms.Label();
			this.tab5_Alumno_VistaGeneralCurso = new System.Windows.Forms.TabPage();
			this.tab5_Docente_CrearCurso = new System.Windows.Forms.TabPage();
			this.flatLabel1 = new FlatUI.FlatLabel();
			this.txtbox_tab5_courseName = new FlatUI.FlatTextBox();
			this.lbl_tab5_ejemplo = new FlatUI.FlatLabel();
			this.btn_tab5_cancelar = new FlatUI.FlatButton();
			this.btn_tab5_aceptar = new FlatUI.FlatButton();
			this.lbl_tab5_NombreMateria = new FlatUI.FlatLabel();
			this.lbl_tab5_NombCortGrupo = new FlatUI.FlatLabel();
			this.txtbox_tab5_grup = new FlatUI.FlatTextBox();
			this.txtbox_tab5_grade = new FlatUI.FlatTextBox();
			this.lbl_tab5_Creargrupo = new System.Windows.Forms.Label();
			this.tab6_Docente_ListaDeCursos = new System.Windows.Forms.TabPage();
			this.flatButton1 = new FlatUI.FlatButton();
			this.btn_tab6_EditCourse = new FlatUI.FlatButton();
			this.btn_tab6_EraseCourse = new FlatUI.FlatButton();
			this.lvw_tab6_GroupList = new System.Windows.Forms.ListView();
			this.col_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_Grade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.col_group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btn_tab6_EnrollStudents = new FlatUI.FlatButton();
			this.btn_tab6_regresar = new FlatUI.FlatButton();
			this.lbl_tab6_listagrupos = new FlatUI.FlatLabel();
			this.tab7_Docente_InscripcionAlumnos = new System.Windows.Forms.TabPage();
			this.btn_tab7_regresarAListaDeCurso = new FlatUI.FlatButton();
			this.btn_tab7_eliminar = new FlatUI.FlatButton();
			this.btn_tab7_insciribir = new FlatUI.FlatButton();
			this.txtbox_tab7_userName = new FlatUI.FlatTextBox();
			this.lvw_tab7_enrolledStudents = new System.Windows.Forms.ListView();
			this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lbl_tab7_inscribira = new FlatUI.FlatLabel();
			this.tmr_psw = new System.Windows.Forms.Timer(this.components);
			this.cal1 = new FlatUI.FlatTextBox();
			this.cal2 = new FlatUI.FlatTextBox();
			this.cal3 = new FlatUI.FlatTextBox();
			this.cal4 = new FlatUI.FlatTextBox();
			this.cal5 = new FlatUI.FlatTextBox();
			this.cal6 = new FlatUI.FlatTextBox();
			this.btn_tab7_upgradeCALS = new FlatUI.FlatButton();
			this.pnl_header.SuspendLayout();
			this.pnl_body.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tab0_Startup.SuspendLayout();
			this.tab1_login.SuspendLayout();
			this.tab2_registro.SuspendLayout();
			this.tab3_Alumno_VistaGeneral.SuspendLayout();
			this.tab3_Docente_VistaGeneral.SuspendLayout();
			this.tab4_Alumno_ListaDeCursos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridview_tab4)).BeginInit();
			this.tab4_Docente_CursoGeneral.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_tab4_Vulnerables)).BeginInit();
			this.tab5_Docente_CrearCurso.SuspendLayout();
			this.tab6_Docente_ListaDeCursos.SuspendLayout();
			this.tab7_Docente_InscripcionAlumnos.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnl_header
			// 
			this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.pnl_header.Controls.Add(this.flatClose1);
			this.pnl_header.Controls.Add(this.flatMini1);
			this.pnl_header.Controls.Add(this.flatLabel3);
			this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_header.Location = new System.Drawing.Point(0, 0);
			this.pnl_header.Name = "pnl_header";
			this.pnl_header.Size = new System.Drawing.Size(540, 36);
			this.pnl_header.TabIndex = 0;
			this.pnl_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_header_MouseMove);
			// 
			// flatClose1
			// 
			this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.flatClose1.BackColor = System.Drawing.Color.White;
			this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
			this.flatClose1.Location = new System.Drawing.Point(510, 10);
			this.flatClose1.Name = "flatClose1";
			this.flatClose1.Size = new System.Drawing.Size(18, 18);
			this.flatClose1.TabIndex = 0;
			this.flatClose1.TabStop = false;
			this.flatClose1.Text = "flatClose1";
			this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.flatClose1.Click += new System.EventHandler(this.Cerrar_Click_1);
			// 
			// flatMini1
			// 
			this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.flatMini1.BackColor = System.Drawing.Color.White;
			this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
			this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
			this.flatMini1.Location = new System.Drawing.Point(492, 10);
			this.flatMini1.Name = "flatMini1";
			this.flatMini1.Size = new System.Drawing.Size(18, 18);
			this.flatMini1.TabIndex = 2;
			this.flatMini1.TabStop = false;
			this.flatMini1.Text = "flatMini1";
			this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			// 
			// flatLabel3
			// 
			this.flatLabel3.AutoSize = true;
			this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
			this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.flatLabel3.ForeColor = System.Drawing.Color.White;
			this.flatLabel3.Location = new System.Drawing.Point(11, 7);
			this.flatLabel3.Name = "flatLabel3";
			this.flatLabel3.Size = new System.Drawing.Size(205, 21);
			this.flatLabel3.TabIndex = 0;
			this.flatLabel3.Text = "System Master Vulnerability";
			this.flatLabel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flatLabel3_MouseMove);
			// 
			// pnl_body
			// 
			this.pnl_body.Controls.Add(this.tabControl);
			this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_body.Location = new System.Drawing.Point(0, 36);
			this.pnl_body.Name = "pnl_body";
			this.pnl_body.Size = new System.Drawing.Size(540, 444);
			this.pnl_body.TabIndex = 1;
			// 
			// tabControl
			// 
			this.tabControl.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.tabControl.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
			this.tabControl.Controls.Add(this.tab0_Startup);
			this.tabControl.Controls.Add(this.tab1_login);
			this.tabControl.Controls.Add(this.tab2_registro);
			this.tabControl.Controls.Add(this.tab3_Alumno_VistaGeneral);
			this.tabControl.Controls.Add(this.tab3_Docente_VistaGeneral);
			this.tabControl.Controls.Add(this.tab4_Alumno_ListaDeCursos);
			this.tabControl.Controls.Add(this.tab4_Docente_CursoGeneral);
			this.tabControl.Controls.Add(this.tab5_Alumno_VistaGeneralCurso);
			this.tabControl.Controls.Add(this.tab5_Docente_CrearCurso);
			this.tabControl.Controls.Add(this.tab6_Docente_ListaDeCursos);
			this.tabControl.Controls.Add(this.tab7_Docente_InscripcionAlumnos);
			this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.tabControl.ItemSize = new System.Drawing.Size(120, 40);
			this.tabControl.Location = new System.Drawing.Point(0, -44);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(540, 488);
			this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControl.TabIndex = 0;
			// 
			// tab0_Startup
			// 
			this.tab0_Startup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
			this.tab0_Startup.Controls.Add(this.lbl_rootPsw);
			this.tab0_Startup.Controls.Add(this.txtbox_rootPsw);
			this.tab0_Startup.Controls.Add(this.btn_connectToDB);
			this.tab0_Startup.Controls.Add(this.BY_EPI);
			this.tab0_Startup.Controls.Add(this.SMV_LOGO);
			this.tab0_Startup.Location = new System.Drawing.Point(4, 44);
			this.tab0_Startup.Name = "tab0_Startup";
			this.tab0_Startup.Size = new System.Drawing.Size(532, 440);
			this.tab0_Startup.TabIndex = 10;
			this.tab0_Startup.Text = "tabPage1";
			// 
			// lbl_rootPsw
			// 
			this.lbl_rootPsw.AutoSize = true;
			this.lbl_rootPsw.BackColor = System.Drawing.Color.Transparent;
			this.lbl_rootPsw.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lbl_rootPsw.ForeColor = System.Drawing.Color.White;
			this.lbl_rootPsw.Location = new System.Drawing.Point(190, 199);
			this.lbl_rootPsw.Name = "lbl_rootPsw";
			this.lbl_rootPsw.Size = new System.Drawing.Size(121, 13);
			this.lbl_rootPsw.TabIndex = 12;
			this.lbl_rootPsw.Text = "MySQL Root Password";
			// 
			// txtbox_rootPsw
			// 
			this.txtbox_rootPsw.BackColor = System.Drawing.Color.Transparent;
			this.txtbox_rootPsw.FocusOnHover = false;
			this.txtbox_rootPsw.Location = new System.Drawing.Point(190, 218);
			this.txtbox_rootPsw.MaxLength = 32767;
			this.txtbox_rootPsw.Multiline = false;
			this.txtbox_rootPsw.Name = "txtbox_rootPsw";
			this.txtbox_rootPsw.ReadOnly = false;
			this.txtbox_rootPsw.Size = new System.Drawing.Size(160, 29);
			this.txtbox_rootPsw.TabIndex = 11;
			this.txtbox_rootPsw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtbox_rootPsw.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtbox_rootPsw.UseSystemPasswordChar = true;
			// 
			// btn_connectToDB
			// 
			this.btn_connectToDB.BackColor = System.Drawing.Color.Transparent;
			this.btn_connectToDB.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.btn_connectToDB.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_connectToDB.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btn_connectToDB.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btn_connectToDB.Location = new System.Drawing.Point(210, 253);
			this.btn_connectToDB.Name = "btn_connectToDB";
			this.btn_connectToDB.Rounded = false;
			this.btn_connectToDB.Size = new System.Drawing.Size(123, 59);
			this.btn_connectToDB.TabIndex = 10;
			this.btn_connectToDB.Text = "Conectar al servidor";
			this.btn_connectToDB.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.btn_connectToDB.Click += new System.EventHandler(this.btn_connectToDataBase_Click);
			// 
			// BY_EPI
			// 
			this.BY_EPI.AutoSize = true;
			this.BY_EPI.BackColor = System.Drawing.Color.Transparent;
			this.BY_EPI.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.BY_EPI.ForeColor = System.Drawing.Color.Silver;
			this.BY_EPI.Location = new System.Drawing.Point(313, 62);
			this.BY_EPI.Name = "BY_EPI";
			this.BY_EPI.Size = new System.Drawing.Size(37, 13);
			this.BY_EPI.TabIndex = 9;
			this.BY_EPI.Text = "By EPI";
			// 
			// SMV_LOGO
			// 
			this.SMV_LOGO.AutoSize = true;
			this.SMV_LOGO.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SMV_LOGO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.SMV_LOGO.Location = new System.Drawing.Point(187, 19);
			this.SMV_LOGO.Name = "SMV_LOGO";
			this.SMV_LOGO.Size = new System.Drawing.Size(146, 73);
			this.SMV_LOGO.TabIndex = 0;
			this.SMV_LOGO.Text = "SMV";
			// 
			// tab1_login
			// 
			this.tab1_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
			this.tab1_login.Controls.Add(this.llb_CrearCuenta);
			this.tab1_login.Controls.Add(this.flatLabel4);
			this.tab1_login.Controls.Add(this.trash_lblContraseña);
			this.tab1_login.Controls.Add(this.lbl_Usuario);
			this.tab1_login.Controls.Add(this.btn_ingresar);
			this.tab1_login.Controls.Add(this.txtbox_contraseña);
			this.tab1_login.Controls.Add(this.txtbox_usuario);
			this.tab1_login.Location = new System.Drawing.Point(4, 44);
			this.tab1_login.Name = "tab1_login";
			this.tab1_login.Size = new System.Drawing.Size(532, 440);
			this.tab1_login.TabIndex = 0;
			this.tab1_login.Text = "tabPage3";
			// 
			// llb_CrearCuenta
			// 
			this.llb_CrearCuenta.ActiveLinkColor = System.Drawing.Color.Teal;
			this.llb_CrearCuenta.AutoSize = true;
			this.llb_CrearCuenta.LinkColor = System.Drawing.SystemColors.MenuHighlight;
			this.llb_CrearCuenta.Location = new System.Drawing.Point(209, 301);
			this.llb_CrearCuenta.Name = "llb_CrearCuenta";
			this.llb_CrearCuenta.Size = new System.Drawing.Size(117, 19);
			this.llb_CrearCuenta.TabIndex = 7;
			this.llb_CrearCuenta.TabStop = true;
			this.llb_CrearCuenta.Text = "Crear una Cuenta";
			this.llb_CrearCuenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_CrearCuenta_LinkClicked);
			// 
			// flatLabel4
			// 
			this.flatLabel4.AutoSize = true;
			this.flatLabel4.BackColor = System.Drawing.Color.Transparent;
			this.flatLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.flatLabel4.ForeColor = System.Drawing.Color.White;
			this.flatLabel4.Location = new System.Drawing.Point(30, 30);
			this.flatLabel4.Name = "flatLabel4";
			this.flatLabel4.Size = new System.Drawing.Size(137, 30);
			this.flatLabel4.TabIndex = 6;
			this.flatLabel4.Text = "Iniciar Sesion";
			// 
			// trash_lblContraseña
			// 
			this.trash_lblContraseña.AutoSize = true;
			this.trash_lblContraseña.BackColor = System.Drawing.Color.Transparent;
			this.trash_lblContraseña.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.trash_lblContraseña.ForeColor = System.Drawing.Color.White;
			this.trash_lblContraseña.Location = new System.Drawing.Point(131, 203);
			this.trash_lblContraseña.Name = "trash_lblContraseña";
			this.trash_lblContraseña.Size = new System.Drawing.Size(66, 13);
			this.trash_lblContraseña.TabIndex = 5;
			this.trash_lblContraseña.Text = "Contraseña";
			// 
			// lbl_Usuario
			// 
			this.lbl_Usuario.AutoSize = true;
			this.lbl_Usuario.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Usuario.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lbl_Usuario.ForeColor = System.Drawing.Color.White;
			this.lbl_Usuario.Location = new System.Drawing.Point(131, 141);
			this.lbl_Usuario.Name = "lbl_Usuario";
			this.lbl_Usuario.Size = new System.Drawing.Size(47, 13);
			this.lbl_Usuario.TabIndex = 4;
			this.lbl_Usuario.Text = "Usuario";
			// 
			// btn_ingresar
			// 
			this.btn_ingresar.BackColor = System.Drawing.Color.Transparent;
			this.btn_ingresar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.btn_ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_ingresar.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btn_ingresar.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btn_ingresar.Location = new System.Drawing.Point(191, 266);
			this.btn_ingresar.Name = "btn_ingresar";
			this.btn_ingresar.Rounded = false;
			this.btn_ingresar.Size = new System.Drawing.Size(145, 32);
			this.btn_ingresar.TabIndex = 0;
			this.btn_ingresar.Text = "Ingresar";
			this.btn_ingresar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
			// 
			// txtbox_contraseña
			// 
			this.txtbox_contraseña.BackColor = System.Drawing.Color.Transparent;
			this.txtbox_contraseña.FocusOnHover = false;
			this.txtbox_contraseña.Location = new System.Drawing.Point(134, 219);
			this.txtbox_contraseña.MaxLength = 32767;
			this.txtbox_contraseña.Multiline = false;
			this.txtbox_contraseña.Name = "txtbox_contraseña";
			this.txtbox_contraseña.ReadOnly = false;
			this.txtbox_contraseña.Size = new System.Drawing.Size(259, 29);
			this.txtbox_contraseña.TabIndex = 3;
			this.txtbox_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtbox_contraseña.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtbox_contraseña.UseSystemPasswordChar = true;
			// 
			// txtbox_usuario
			// 
			this.txtbox_usuario.BackColor = System.Drawing.Color.Transparent;
			this.txtbox_usuario.FocusOnHover = false;
			this.txtbox_usuario.Location = new System.Drawing.Point(134, 157);
			this.txtbox_usuario.MaxLength = 32767;
			this.txtbox_usuario.Multiline = false;
			this.txtbox_usuario.Name = "txtbox_usuario";
			this.txtbox_usuario.ReadOnly = false;
			this.txtbox_usuario.Size = new System.Drawing.Size(259, 29);
			this.txtbox_usuario.TabIndex = 2;
			this.txtbox_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtbox_usuario.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtbox_usuario.UseSystemPasswordChar = false;
			// 
			// tab2_registro
			// 
			this.tab2_registro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
			this.tab2_registro.Controls.Add(this.iTalk_Label2);
			this.tab2_registro.Controls.Add(this.lbl_tab2_pswMatch);
			this.tab2_registro.Controls.Add(this.iTalk_Label1);
			this.tab2_registro.Controls.Add(this.lbl_tab2_dejeseBlanco);
			this.tab2_registro.Controls.Add(this.btn_tab2_cancelar);
			this.tab2_registro.Controls.Add(this.btn_tab2_aceptar);
			this.tab2_registro.Controls.Add(this.txtbox_tab2_conficontraseña);
			this.tab2_registro.Controls.Add(this.lbl_tab2_confirmarcontra);
			this.tab2_registro.Controls.Add(this.txtbox_tab2_contraseña);
			this.tab2_registro.Controls.Add(this.lbl_tab2_contraseña);
			this.tab2_registro.Controls.Add(this.txtbox_tab2_codigo);
			this.tab2_registro.Controls.Add(this.lbl_tab2_codigoDocente);
			this.tab2_registro.Controls.Add(this.txtbox_tab2_registro);
			this.tab2_registro.Controls.Add(this.lbl_tab2_apellidos);
			this.tab2_registro.Controls.Add(this.lbl_tab2_nombres);
			this.tab2_registro.Controls.Add(this.txtbox_tab2_nombres);
			this.tab2_registro.Controls.Add(this.lbl_tab2_registro);
			this.tab2_registro.Controls.Add(this.txtbox_tab2_nombreUsuario);
			this.tab2_registro.Controls.Add(this.lbl_tab2_nombreUsuario);
			this.tab2_registro.Location = new System.Drawing.Point(4, 44);
			this.tab2_registro.Name = "tab2_registro";
			this.tab2_registro.Size = new System.Drawing.Size(532, 440);
			this.tab2_registro.TabIndex = 1;
			this.tab2_registro.Text = "tabPage1";
			// 
			// iTalk_Label2
			// 
			this.iTalk_Label2.AutoSize = true;
			this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
			this.iTalk_Label2.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.iTalk_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
			this.iTalk_Label2.Location = new System.Drawing.Point(266, 252);
			this.iTalk_Label2.Name = "iTalk_Label2";
			this.iTalk_Label2.Size = new System.Drawing.Size(116, 13);
			this.iTalk_Label2.TabIndex = 0;
			this.iTalk_Label2.Text = "32 caracteres Maximo";
			// 
			// lbl_tab2_pswMatch
			// 
			this.lbl_tab2_pswMatch.AutoSize = true;
			this.lbl_tab2_pswMatch.Location = new System.Drawing.Point(265, 284);
			this.lbl_tab2_pswMatch.Name = "lbl_tab2_pswMatch";
			this.lbl_tab2_pswMatch.Size = new System.Drawing.Size(0, 19);
			this.lbl_tab2_pswMatch.TabIndex = 19;
			// 
			// iTalk_Label1
			// 
			this.iTalk_Label1.AutoSize = true;
			this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
			this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
			this.iTalk_Label1.Location = new System.Drawing.Point(212, 92);
			this.iTalk_Label1.Name = "iTalk_Label1";
			this.iTalk_Label1.Size = new System.Drawing.Size(111, 13);
			this.iTalk_Label1.TabIndex = 0;
			this.iTalk_Label1.Text = "25 carateres Maximo";
			// 
			// lbl_tab2_dejeseBlanco
			// 
			this.lbl_tab2_dejeseBlanco.AutoSize = true;
			this.lbl_tab2_dejeseBlanco.BackColor = System.Drawing.Color.Transparent;
			this.lbl_tab2_dejeseBlanco.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lbl_tab2_dejeseBlanco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
			this.lbl_tab2_dejeseBlanco.Location = new System.Drawing.Point(215, 204);
			this.lbl_tab2_dejeseBlanco.Name = "lbl_tab2_dejeseBlanco";
			this.lbl_tab2_dejeseBlanco.Size = new System.Drawing.Size(212, 13);
			this.lbl_tab2_dejeseBlanco.TabIndex = 0;
			this.lbl_tab2_dejeseBlanco.Text = "*Dejese en blanco sino cuenta con uno ";
			// 
			// btn_tab2_cancelar
			// 
			this.btn_tab2_cancelar.BackColor = System.Drawing.Color.Transparent;
			this.btn_tab2_cancelar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.btn_tab2_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_tab2_cancelar.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btn_tab2_cancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btn_tab2_cancelar.Location = new System.Drawing.Point(400, 384);
			this.btn_tab2_cancelar.Name = "btn_tab2_cancelar";
			this.btn_tab2_cancelar.Rounded = false;
			this.btn_tab2_cancelar.Size = new System.Drawing.Size(106, 32);
			this.btn_tab2_cancelar.TabIndex = 7;
			this.btn_tab2_cancelar.Text = "Cancelar ";
			this.btn_tab2_cancelar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.btn_tab2_cancelar.Click += new System.EventHandler(this.btn_tab2_cancelar_Click);
			// 
			// btn_tab2_aceptar
			// 
			this.btn_tab2_aceptar.BackColor = System.Drawing.Color.Transparent;
			this.btn_tab2_aceptar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.btn_tab2_aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_tab2_aceptar.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btn_tab2_aceptar.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btn_tab2_aceptar.Location = new System.Drawing.Point(269, 384);
			this.btn_tab2_aceptar.Name = "btn_tab2_aceptar";
			this.btn_tab2_aceptar.Rounded = false;
			this.btn_tab2_aceptar.Size = new System.Drawing.Size(106, 32);
			this.btn_tab2_aceptar.TabIndex = 6;
			this.btn_tab2_aceptar.Text = "Registro";
			this.btn_tab2_aceptar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.btn_tab2_aceptar.Click += new System.EventHandler(this.btn_tab2_aceptar_Click);
			// 
			// txtbox_tab2_conficontraseña
			// 
			this.txtbox_tab2_conficontraseña.BackColor = System.Drawing.Color.Transparent;
			this.txtbox_tab2_conficontraseña.FocusOnHover = false;
			this.txtbox_tab2_conficontraseña.Location = new System.Drawing.Point(36, 300);
			this.txtbox_tab2_conficontraseña.MaxLength = 32767;
			this.txtbox_tab2_conficontraseña.Multiline = false;
			this.txtbox_tab2_conficontraseña.Name = "txtbox_tab2_conficontraseña";
			this.txtbox_tab2_conficontraseña.ReadOnly = false;
			this.txtbox_tab2_conficontraseña.Size = new System.Drawing.Size(219, 29);
			this.txtbox_tab2_conficontraseña.TabIndex = 5;
			this.txtbox_tab2_conficontraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtbox_tab2_conficontraseña.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtbox_tab2_conficontraseña.UseSystemPasswordChar = true;
			// 
			// lbl_tab2_confirmarcontra
			// 
			this.lbl_tab2_confirmarcontra.AutoSize = true;
			this.lbl_tab2_confirmarcontra.BackColor = System.Drawing.Color.Transparent;
			this.lbl_tab2_confirmarcontra.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lbl_tab2_confirmarcontra.ForeColor = System.Drawing.Color.White;
			this.lbl_tab2_confirmarcontra.Location = new System.Drawing.Point(39, 284);
			this.lbl_tab2_confirmarcontra.Name = "lbl_tab2_confirmarcontra";
			this.lbl_tab2_confirmarcontra.Size = new System.Drawing.Size(121, 13);
			this.lbl_tab2_confirmarcontra.TabIndex = 0;
			this.lbl_tab2_confirmarcontra.Text = "Confirmar contraseña ";
			// 
			// txtbox_tab2_contraseña
			// 
			this.txtbox_tab2_contraseña.BackColor = System.Drawing.Color.Transparent;
			this.txtbox_tab2_contraseña.FocusOnHover = false;
			this.txtbox_tab2_contraseña.Location = new System.Drawing.Point(36, 252);
			this.txtbox_tab2_contraseña.MaxLength = 32767;
			this.txtbox_tab2_contraseña.Multiline = false;
			this.txtbox_tab2_contraseña.Name = "txtbox_tab2_contraseña";
			this.txtbox_tab2_contraseña.ReadOnly = false;
			this.txtbox_tab2_contraseña.Size = new System.Drawing.Size(219, 29);
			this.txtbox_tab2_contraseña.TabIndex = 4;
			this.txtbox_tab2_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtbox_tab2_contraseña.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtbox_tab2_contraseña.UseSystemPasswordChar = true;
			// 
			// lbl_tab2_contraseña
			// 
			this.lbl_tab2_contraseña.AutoSize = true;
			this.lbl_tab2_contraseña.BackColor = System.Drawing.Color.Transparent;
			this.lbl_tab2_contraseña.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lbl_tab2_contraseña.ForeColor = System.Drawing.Color.White;
			this.lbl_tab2_contraseña.Location = new System.Drawing.Point(39, 236);
			this.lbl_tab2_contraseña.Name = "lbl_tab2_contraseña";
			this.lbl_tab2_contraseña.Size = new System.Drawing.Size(64, 13);
			this.lbl_tab2_contraseña.TabIndex = 0;
			this.lbl_tab2_contraseña.Text = "Contraeña ";
			// 
			// txtbox_tab2_codigo
			// 
			this.txtbox_tab2_codigo.BackColor = System.Drawing.Color.Transparent;
			this.txtbox_tab2_codigo.FocusOnHover = false;
			this.txtbox_tab2_codigo.Location = new System.Drawing.Point(36, 204);
			this.txtbox_tab2_codigo.MaxLength = 32767;
			this.txtbox_tab2_codigo.Multiline = false;
			this.txtbox_tab2_codigo.Name = "txtbox_tab2_codigo";
			this.txtbox_tab2_codigo.ReadOnly = false;
			this.txtbox_tab2_codigo.Size = new System.Drawing.Size(173, 29);
			this.txtbox_tab2_codigo.TabIndex = 3;
			this.txtbox_tab2_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtbox_tab2_codigo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtbox_tab2_codigo.UseSystemPasswordChar = false;
			// 
			// lbl_tab2_codigoDocente
			// 
			this.lbl_tab2_codigoDocente.AutoSize = true;
			this.lbl_tab2_codigoDocente.BackColor = System.Drawing.Color.Transparent;
			this.lbl_tab2_codigoDocente.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lbl_tab2_codigoDocente.ForeColor = System.Drawing.Color.White;
			this.lbl_tab2_codigoDocente.Location = new System.Drawing.Point(39, 188);
			this.lbl_tab2_codigoDocente.Name = "lbl_tab2_codigoDocente";
			this.lbl_tab2_codigoDocente.Size = new System.Drawing.Size(109, 13);
			this.lbl_tab2_codigoDocente.TabIndex = 0;
			this.lbl_tab2_codigoDocente.Text = "Codigo de docente ";
			// 
			// txtbox_tab2_registro
			// 
			this.txtbox_tab2_registro.BackColor = System.Drawing.Color.Transparent;
			this.txtbox_tab2_registro.FocusOnHover = false;
			this.txtbox_tab2_registro.Location = new System.Drawing.Point(207, 156);
			this.txtbox_tab2_registro.MaxLength = 32767;
			this.txtbox_tab2_registro.Multiline = false;
			this.txtbox_tab2_registro.Name = "txtbox_tab2_registro";
			this.txtbox_tab2_registro.ReadOnly = false;
			this.txtbox_tab2_registro.Size = new System.Drawing.Size(235, 29);
			this.txtbox_tab2_registro.TabIndex = 2;
			this.txtbox_tab2_registro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtbox_tab2_registro.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtbox_tab2_registro.UseSystemPasswordChar = false;
			// 
			// lbl_tab2_apellidos
			// 
			this.lbl_tab2_apellidos.AutoSize = true;
			this.lbl_tab2_apellidos.BackColor = System.Drawing.Color.Transparent;
			this.lbl_tab2_apellidos.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lbl_tab2_apellidos.ForeColor = System.Drawing.Color.White;
			this.lbl_tab2_apellidos.Location = new System.Drawing.Point(212, 140);
			this.lbl_tab2_apellidos.Name = "lbl_tab2_apellidos";
			this.lbl_tab2_apellidos.Size = new System.Drawing.Size(55, 13);
			this.lbl_tab2_apellidos.TabIndex = 0;
			this.lbl_tab2_apellidos.Text = "Apellidos";
			// 
			// lbl_tab2_nombres
			// 
			this.lbl_tab2_nombres.AutoSize = true;
			this.lbl_tab2_nombres.BackColor = System.Drawing.Color.Transparent;
			this.lbl_tab2_nombres.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lbl_tab2_nombres.ForeColor = System.Drawing.Color.White;
			this.lbl_tab2_nombres.Location = new System.Drawing.Point(36, 140);
			this.lbl_tab2_nombres.Name = "lbl_tab2_nombres";
			this.lbl_tab2_nombres.Size = new System.Drawing.Size(56, 13);
			this.lbl_tab2_nombres.TabIndex = 0;
			this.lbl_tab2_nombres.Text = "Nombres ";
			// 
			// txtbox_tab2_nombres
			// 
			this.txtbox_tab2_nombres.BackColor = System.Drawing.Color.Transparent;
			this.txtbox_tab2_nombres.FocusOnHover = false;
			this.txtbox_tab2_nombres.Location = new System.Drawing.Point(36, 156);
			this.txtbox_tab2_nombres.MaxLength = 32767;
			this.txtbox_tab2_nombres.Multiline = false;
			this.txtbox_tab2_nombres.Name = "txtbox_tab2_nombres";
			this.txtbox_tab2_nombres.ReadOnly = false;
			this.txtbox_tab2_nombres.Size = new System.Drawing.Size(162, 29);
			this.txtbox_tab2_nombres.TabIndex = 1;
			this.txtbox_tab2_nombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtbox_tab2_nombres.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtbox_tab2_nombres.UseSystemPasswordChar = false;
			// 
			// lbl_tab2_registro
			// 
			this.lbl_tab2_registro.AutoSize = true;
			this.lbl_tab2_registro.BackColor = System.Drawing.Color.Transparent;
			this.lbl_tab2_registro.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_tab2_registro.ForeColor = System.Drawing.Color.White;
			this.lbl_tab2_registro.Location = new System.Drawing.Point(30, 30);
			this.lbl_tab2_registro.Name = "lbl_tab2_registro";
			this.lbl_tab2_registro.Size = new System.Drawing.Size(114, 37);
			this.lbl_tab2_registro.TabIndex = 0;
			this.lbl_tab2_registro.Text = "Registro";
			// 
			// txtbox_tab2_nombreUsuario
			// 
			this.txtbox_tab2_nombreUsuario.BackColor = System.Drawing.Color.Transparent;
			this.txtbox_tab2_nombreUsuario.FocusOnHover = false;
			this.txtbox_tab2_nombreUsuario.Location = new System.Drawing.Point(36, 108);
			this.txtbox_tab2_nombreUsuario.MaxLength = 32767;
			this.txtbox_tab2_nombreUsuario.Multiline = false;
			this.txtbox_tab2_nombreUsuario.Name = "txtbox_tab2_nombreUsuario";
			this.txtbox_tab2_nombreUsuario.ReadOnly = false;
			this.txtbox_tab2_nombreUsuario.Size = new System.Drawing.Size(239, 29);
			this.txtbox_tab2_nombreUsuario.TabIndex = 0;
			this.txtbox_tab2_nombreUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtbox_tab2_nombreUsuario.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtbox_tab2_nombreUsuario.UseSystemPasswordChar = false;
			// 
			// lbl_tab2_nombreUsuario
			// 
			this.lbl_tab2_nombreUsuario.AutoSize = true;
			this.lbl_tab2_nombreUsuario.BackColor = System.Drawing.Color.Transparent;
			this.lbl_tab2_nombreUsuario.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lbl_tab2_nombreUsuario.ForeColor = System.Drawing.Color.White;
			this.lbl_tab2_nombreUsuario.Location = new System.Drawing.Point(33, 92);
			this.lbl_tab2_nombreUsuario.Name = "lbl_tab2_nombreUsuario";
			this.lbl_tab2_nombreUsuario.Size = new System.Drawing.Size(109, 13);
			this.lbl_tab2_nombreUsuario.TabIndex = 0;
			this.lbl_tab2_nombreUsuario.Text = "Nombre de usuario ";
			// 
			// tab3_Alumno_VistaGeneral
			// 
			this.tab3_Alumno_VistaGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
			this.tab3_Alumno_VistaGeneral.Controls.Add(this.llb_tab3_PromedioGeneral);
			this.tab3_Alumno_VistaGeneral.Controls.Add(this.llb_tab3_materia4);
			this.tab3_Alumno_VistaGeneral.Controls.Add(this.llb_tab3_materia3);
			this.tab3_Alumno_VistaGeneral.Controls.Add(this.llb_tab3_materia2);
			this.tab3_Alumno_VistaGeneral.Controls.Add(this.llb_tab3_materia1);
			this.tab3_Alumno_VistaGeneral.Controls.Add(this.lbl_tab3_NombreAlumno);
			this.tab3_Alumno_VistaGeneral.Controls.Add(this.btn_tab3_listagrupo);
			this.tab3_Alumno_VistaGeneral.Controls.Add(this.btn_tab3_GrupoInscrito);
			this.tab3_Alumno_VistaGeneral.Controls.Add(this.radGrp_tab3_Progresototal5);
			this.tab3_Alumno_VistaGeneral.Controls.Add(this.radGrp_tab3_Progresototal3);
			this.tab3_Alumno_VistaGeneral.Controls.Add(this.radGrp_tab3_Progresototal4);
			this.tab3_Alumno_VistaGeneral.Controls.Add(this.radGrp_tab3_Progresototal2);
			this.tab3_Alumno_VistaGeneral.Controls.Add(this.radGrp_tab3_Progresototal);
			this.tab3_Alumno_VistaGeneral.Location = new System.Drawing.Point(4, 44);
			this.tab3_Alumno_VistaGeneral.MinimumSize = new System.Drawing.Size(126, 39);
			this.tab3_Alumno_VistaGeneral.Name = "tab3_Alumno_VistaGeneral";
			this.tab3_Alumno_VistaGeneral.Size = new System.Drawing.Size(532, 440);
			this.tab3_Alumno_VistaGeneral.TabIndex = 2;
			this.tab3_Alumno_VistaGeneral.Text = "tabPage1";
			// 
			// llb_tab3_PromedioGeneral
			// 
			this.llb_tab3_PromedioGeneral.AutoSize = true;
			this.llb_tab3_PromedioGeneral.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.llb_tab3_PromedioGeneral.Location = new System.Drawing.Point(72, 288);
			this.llb_tab3_PromedioGeneral.Name = "llb_tab3_PromedioGeneral";
			this.llb_tab3_PromedioGeneral.Size = new System.Drawing.Size(115, 19);
			this.llb_tab3_PromedioGeneral.TabIndex = 13;
			this.llb_tab3_PromedioGeneral.TabStop = true;
			this.llb_tab3_PromedioGeneral.Text = "Progreso General";
			// 
			// llb_tab3_materia4
			// 
			this.llb_tab3_materia4.AutoSize = true;
			this.llb_tab3_materia4.ForeColor = System.Drawing.Color.Blue;
			this.llb_tab3_materia4.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.llb_tab3_materia4.Location = new System.Drawing.Point(385, 280);
			this.llb_tab3_materia4.Name = "llb_tab3_materia4";
			this.llb_tab3_materia4.Size = new System.Drawing.Size(0, 19);
			this.llb_tab3_materia4.TabIndex = 12;
			// 
			// llb_tab3_materia3
			// 
			this.llb_tab3_materia3.AutoSize = true;
			this.llb_tab3_materia3.ForeColor = System.Drawing.Color.Blue;
			this.llb_tab3_materia3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.llb_tab3_materia3.Location = new System.Drawing.Point(276, 280);
			this.llb_tab3_materia3.Name = "llb_tab3_materia3";
			this.llb_tab3_materia3.Size = new System.Drawing.Size(0, 19);
			this.llb_tab3_materia3.TabIndex = 11;
			// 
			// llb_tab3_materia2
			// 
			this.llb_tab3_materia2.AutoSize = true;
			this.llb_tab3_materia2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.llb_tab3_materia2.Location = new System.Drawing.Point(383, 171);
			this.llb_tab3_materia2.Name = "llb_tab3_materia2";
			this.llb_tab3_materia2.Size = new System.Drawing.Size(0, 19);
			this.llb_tab3_materia2.TabIndex = 10;
			// 
			// llb_tab3_materia1
			// 
			this.llb_tab3_materia1.AutoSize = true;
			this.llb_tab3_materia1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.llb_tab3_materia1.Location = new System.Drawing.Point(277, 171);
			this.llb_tab3_materia1.Name = "llb_tab3_materia1";
			this.llb_tab3_materia1.Size = new System.Drawing.Size(0, 19);
			this.llb_tab3_materia1.TabIndex = 9;
			// 
			// lbl_tab3_NombreAlumno
			// 
			this.lbl_tab3_NombreAlumno.AutoSize = true;
			this.lbl_tab3_NombreAlumno.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_tab3_NombreAlumno.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lbl_tab3_NombreAlumno.Location = new System.Drawing.Point(30, 32);
			this.lbl_tab3_NombreAlumno.Name = "lbl_tab3_NombreAlumno";
			this.lbl_tab3_NombreAlumno.Size = new System.Drawing.Size(199, 32);
			this.lbl_tab3_NombreAlumno.TabIndex = 8;
			this.lbl_tab3_NombreAlumno.Text = "Student Name---";
			// 
			// btn_tab3_listagrupo
			// 
			this.btn_tab3_listagrupo.BackColor = System.Drawing.Color.Transparent;
			this.btn_tab3_listagrupo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.btn_tab3_listagrupo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_tab3_listagrupo.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btn_tab3_listagrupo.Location = new System.Drawing.Point(182, 377);
			this.btn_tab3_listagrupo.Name = "btn_tab3_listagrupo";
			this.btn_tab3_listagrupo.Rounded = false;
			this.btn_tab3_listagrupo.Size = new System.Drawing.Size(132, 32);
			this.btn_tab3_listagrupo.TabIndex = 6;
			this.btn_tab3_listagrupo.Text = "Lista de grupos";
			this.btn_tab3_listagrupo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			// 
			// btn_tab3_GrupoInscrito
			// 
			this.btn_tab3_GrupoInscrito.BackColor = System.Drawing.Color.Transparent;
			this.btn_tab3_GrupoInscrito.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.btn_tab3_GrupoInscrito.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_tab3_GrupoInscrito.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btn_tab3_GrupoInscrito.Location = new System.Drawing.Point(36, 377);
			this.btn_tab3_GrupoInscrito.Name = "btn_tab3_GrupoInscrito";
			this.btn_tab3_GrupoInscrito.Rounded = false;
			this.btn_tab3_GrupoInscrito.Size = new System.Drawing.Size(130, 32);
			this.btn_tab3_GrupoInscrito.TabIndex = 5;
			this.btn_tab3_GrupoInscrito.Text = "Grupos inscritos ";
			this.btn_tab3_GrupoInscrito.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.btn_tab3_GrupoInscrito.Click += new System.EventHandler(this.btn_tab3_GrupoInscrito_Click);
			// 
			// radGrp_tab3_Progresototal5
			// 
			this.radGrp_tab3_Progresototal5.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.radGrp_tab3_Progresototal5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.radGrp_tab3_Progresototal5.Location = new System.Drawing.Point(365, 185);
			this.radGrp_tab3_Progresototal5.Maximum = ((long)(100));
			this.radGrp_tab3_Progresototal5.MinimumSize = new System.Drawing.Size(100, 100);
			this.radGrp_tab3_Progresototal5.Name = "radGrp_tab3_Progresototal5";
			this.radGrp_tab3_Progresototal5.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
			this.radGrp_tab3_Progresototal5.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
			this.radGrp_tab3_Progresototal5.ProgressShape = iTalk.iTalk_ProgressBar._ProgressShape.Round;
			this.radGrp_tab3_Progresototal5.Size = new System.Drawing.Size(100, 100);
			this.radGrp_tab3_Progresototal5.TabIndex = 4;
			this.radGrp_tab3_Progresototal5.Text = "iTalk_ProgressBar5";
			this.radGrp_tab3_Progresototal5.Value = ((long)(0));
			// 
			// radGrp_tab3_Progresototal3
			// 
			this.radGrp_tab3_Progresototal3.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.radGrp_tab3_Progresototal3.Location = new System.Drawing.Point(365, 80);
			this.radGrp_tab3_Progresototal3.Maximum = ((long)(100));
			this.radGrp_tab3_Progresototal3.MinimumSize = new System.Drawing.Size(100, 100);
			this.radGrp_tab3_Progresototal3.Name = "radGrp_tab3_Progresototal3";
			this.radGrp_tab3_Progresototal3.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
			this.radGrp_tab3_Progresototal3.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
			this.radGrp_tab3_Progresototal3.ProgressShape = iTalk.iTalk_ProgressBar._ProgressShape.Round;
			this.radGrp_tab3_Progresototal3.Size = new System.Drawing.Size(100, 100);
			this.radGrp_tab3_Progresototal3.TabIndex = 3;
			this.radGrp_tab3_Progresototal3.Text = "iTalk_ProgressBar4";
			this.radGrp_tab3_Progresototal3.Value = ((long)(0));
			// 
			// radGrp_tab3_Progresototal4
			// 
			this.radGrp_tab3_Progresototal4.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.radGrp_tab3_Progresototal4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.radGrp_tab3_Progresototal4.Location = new System.Drawing.Point(260, 185);
			this.radGrp_tab3_Progresototal4.Maximum = ((long)(100));
			this.radGrp_tab3_Progresototal4.MinimumSize = new System.Drawing.Size(100, 100);
			this.radGrp_tab3_Progresototal4.Name = "radGrp_tab3_Progresototal4";
			this.radGrp_tab3_Progresototal4.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
			this.radGrp_tab3_Progresototal4.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
			this.radGrp_tab3_Progresototal4.ProgressShape = iTalk.iTalk_ProgressBar._ProgressShape.Round;
			this.radGrp_tab3_Progresototal4.Size = new System.Drawing.Size(100, 100);
			this.radGrp_tab3_Progresototal4.TabIndex = 2;
			this.radGrp_tab3_Progresototal4.Text = "iTalk_ProgressBar3";
			this.radGrp_tab3_Progresototal4.Value = ((long)(0));
			// 
			// radGrp_tab3_Progresototal2
			// 
			this.radGrp_tab3_Progresototal2.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.radGrp_tab3_Progresototal2.Location = new System.Drawing.Point(260, 80);
			this.radGrp_tab3_Progresototal2.Maximum = ((long)(100));
			this.radGrp_tab3_Progresototal2.MinimumSize = new System.Drawing.Size(100, 100);
			this.radGrp_tab3_Progresototal2.Name = "radGrp_tab3_Progresototal2";
			this.radGrp_tab3_Progresototal2.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
			this.radGrp_tab3_Progresototal2.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
			this.radGrp_tab3_Progresototal2.ProgressShape = iTalk.iTalk_ProgressBar._ProgressShape.Round;
			this.radGrp_tab3_Progresototal2.Size = new System.Drawing.Size(100, 100);
			this.radGrp_tab3_Progresototal2.TabIndex = 1;
			this.radGrp_tab3_Progresototal2.Text = "iTalk_ProgressBar2";
			this.radGrp_tab3_Progresototal2.Value = ((long)(0));
			// 
			// radGrp_tab3_Progresototal
			// 
			this.radGrp_tab3_Progresototal.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.radGrp_tab3_Progresototal.Location = new System.Drawing.Point(30, 85);
			this.radGrp_tab3_Progresototal.Maximum = ((long)(100));
			this.radGrp_tab3_Progresototal.MinimumSize = new System.Drawing.Size(100, 100);
			this.radGrp_tab3_Progresototal.Name = "radGrp_tab3_Progresototal";
			this.radGrp_tab3_Progresototal.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
			this.radGrp_tab3_Progresototal.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
			this.radGrp_tab3_Progresototal.ProgressShape = iTalk.iTalk_ProgressBar._ProgressShape.Round;
			this.radGrp_tab3_Progresototal.Size = new System.Drawing.Size(200, 200);
			this.radGrp_tab3_Progresototal.TabIndex = 0;
			this.radGrp_tab3_Progresototal.Text = "iTalk_ProgressBar1";
			this.radGrp_tab3_Progresototal.Value = ((long)(0));
			// 
			// tab3_Docente_VistaGeneral
			// 
			this.tab3_Docente_VistaGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
			this.tab3_Docente_VistaGeneral.Controls.Add(this.lbl_tab3_selectOpcion);
			this.tab3_Docente_VistaGeneral.Controls.Add(this.btn_tab3_CrearGrupoPrf);
			this.tab3_Docente_VistaGeneral.Controls.Add(this.btn_tab3_GrupolistaProf);
			this.tab3_Docente_VistaGeneral.Controls.Add(this.btn_tab3_CursoGeneralProfesor);
			this.tab3_Docente_VistaGeneral.Controls.Add(this.lbl_tab3_NombreProfesor);
			this.tab3_Docente_VistaGeneral.Location = new System.Drawing.Point(4, 44);
			this.tab3_Docente_VistaGeneral.Name = "tab3_Docente_VistaGeneral";
			this.tab3_Docente_VistaGeneral.Size = new System.Drawing.Size(532, 440);
			this.tab3_Docente_VistaGeneral.TabIndex = 5;
			this.tab3_Docente_VistaGeneral.Text = "tabPage1";
			// 
			// lbl_tab3_selectOpcion
			// 
			this.lbl_tab3_selectOpcion.AutoSize = true;
			this.lbl_tab3_selectOpcion.BackColor = System.Drawing.Color.Transparent;
			this.lbl_tab3_selectOpcion.Font = new System.Drawing.Font("High Tower Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_tab3_selectOpcion.ForeColor = System.Drawing.Color.Gold;
			this.lbl_tab3_selectOpcion.Location = new System.Drawing.Point(50, 385);
			this.lbl_tab3_selectOpcion.Name = "lbl_tab3_selectOpcion";
			this.lbl_tab3_selectOpcion.Size = new System.Drawing.Size(208, 25);
			this.lbl_tab3_selectOpcion.TabIndex = 4;
			this.lbl_tab3_selectOpcion.Text = "Selecciona la opcion...";
			// 
			// btn_tab3_CrearGrupoPrf
			// 
			this.btn_tab3_CrearGrupoPrf.BackColor = System.Drawing.Color.Transparent;
			this.btn_tab3_CrearGrupoPrf.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.btn_tab3_CrearGrupoPrf.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_tab3_CrearGrupoPrf.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btn_tab3_CrearGrupoPrf.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btn_tab3_CrearGrupoPrf.Location = new System.Drawing.Point(377, 267);
			this.btn_tab3_CrearGrupoPrf.Name = "btn_tab3_CrearGrupoPrf";
			this.btn_tab3_CrearGrupoPrf.Rounded = false;
			this.btn_tab3_CrearGrupoPrf.Size = new System.Drawing.Size(106, 50);
			this.btn_tab3_CrearGrupoPrf.TabIndex = 3;
			this.btn_tab3_CrearGrupoPrf.Text = "Crear grupo";
			this.btn_tab3_CrearGrupoPrf.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.btn_tab3_CrearGrupoPrf.Click += new System.EventHandler(this.btn_tab3_CrearGrupoPrf_Click);
			// 
			// btn_tab3_GrupolistaProf
			// 
			this.btn_tab3_GrupolistaProf.BackColor = System.Drawing.Color.Transparent;
			this.btn_tab3_GrupolistaProf.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.btn_tab3_GrupolistaProf.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_tab3_GrupolistaProf.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btn_tab3_GrupolistaProf.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btn_tab3_GrupolistaProf.Location = new System.Drawing.Point(212, 267);
			this.btn_tab3_GrupolistaProf.Name = "btn_tab3_GrupolistaProf";
			this.btn_tab3_GrupolistaProf.Rounded = false;
			this.btn_tab3_GrupolistaProf.Size = new System.Drawing.Size(106, 50);
			this.btn_tab3_GrupolistaProf.TabIndex = 2;
			this.btn_tab3_GrupolistaProf.Text = "Lista de Grupos";
			this.btn_tab3_GrupolistaProf.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.btn_tab3_GrupolistaProf.Click += new System.EventHandler(this.btn_tab3_GrupolistaProf_Click);
			// 
			// btn_tab3_CursoGeneralProfesor
			// 
			this.btn_tab3_CursoGeneralProfesor.BackColor = System.Drawing.Color.Transparent;
			this.btn_tab3_CursoGeneralProfesor.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.btn_tab3_CursoGeneralProfesor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_tab3_CursoGeneralProfesor.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btn_tab3_CursoGeneralProfesor.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btn_tab3_CursoGeneralProfesor.Location = new System.Drawing.Point(36, 267);
			this.btn_tab3_CursoGeneralProfesor.Name = "btn_tab3_CursoGeneralProfesor";
			this.btn_tab3_CursoGeneralProfesor.Rounded = false;
			this.btn_tab3_CursoGeneralProfesor.Size = new System.Drawing.Size(127, 50);
			this.btn_tab3_CursoGeneralProfesor.TabIndex = 1;
			this.btn_tab3_CursoGeneralProfesor.Text = "Curso General ";
			this.btn_tab3_CursoGeneralProfesor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			// 
			// lbl_tab3_NombreProfesor
			// 
			this.lbl_tab3_NombreProfesor.AutoSize = true;
			this.lbl_tab3_NombreProfesor.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_tab3_NombreProfesor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbl_tab3_NombreProfesor.Location = new System.Drawing.Point(30, 30);
			this.lbl_tab3_NombreProfesor.Name = "lbl_tab3_NombreProfesor";
			this.lbl_tab3_NombreProfesor.Size = new System.Drawing.Size(196, 30);
			this.lbl_tab3_NombreProfesor.TabIndex = 0;
			this.lbl_tab3_NombreProfesor.Text = "Nombre Profesor---";
			// 
			// tab4_Alumno_ListaDeCursos
			// 
			this.tab4_Alumno_ListaDeCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
			this.tab4_Alumno_ListaDeCursos.Controls.Add(this.radgrp_tab4_materiaProgreso);
			this.tab4_Alumno_ListaDeCursos.Controls.Add(this.dataGridview_tab4);
			this.tab4_Alumno_ListaDeCursos.Controls.Add(this.radGrp_tab3_PromedioGeneral);
			this.tab4_Alumno_ListaDeCursos.Controls.Add(this.lbl_tab4_NombreAlumno);
			this.tab4_Alumno_ListaDeCursos.Location = new System.Drawing.Point(4, 44);
			this.tab4_Alumno_ListaDeCursos.Name = "tab4_Alumno_ListaDeCursos";
			this.tab4_Alumno_ListaDeCursos.Size = new System.Drawing.Size(532, 440);
			this.tab4_Alumno_ListaDeCursos.TabIndex = 3;
			this.tab4_Alumno_ListaDeCursos.Text = "tabPage1";
			// 
			// radgrp_tab4_materiaProgreso
			// 
			this.radgrp_tab4_materiaProgreso.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.radgrp_tab4_materiaProgreso.Location = new System.Drawing.Point(346, 101);
			this.radgrp_tab4_materiaProgreso.Maximum = ((long)(100));
			this.radgrp_tab4_materiaProgreso.MinimumSize = new System.Drawing.Size(100, 100);
			this.radgrp_tab4_materiaProgreso.Name = "radgrp_tab4_materiaProgreso";
			this.radgrp_tab4_materiaProgreso.ProgressColor1 = System.Drawing.Color.Cyan;
			this.radgrp_tab4_materiaProgreso.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
			this.radgrp_tab4_materiaProgreso.ProgressShape = iTalk.iTalk_ProgressBar._ProgressShape.Round;
			this.radgrp_tab4_materiaProgreso.Size = new System.Drawing.Size(130, 130);
			this.radgrp_tab4_materiaProgreso.TabIndex = 3;
			this.radgrp_tab4_materiaProgreso.Text = "iTalk_ProgressBar2";
			this.radgrp_tab4_materiaProgreso.Value = ((long)(75));
			// 
			// dataGridview_tab4
			// 
			this.dataGridview_tab4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridview_tab4.Location = new System.Drawing.Point(11, 276);
			this.dataGridview_tab4.Name = "dataGridview_tab4";
			this.dataGridview_tab4.Size = new System.Drawing.Size(335, 150);
			this.dataGridview_tab4.TabIndex = 2;
			// 
			// radGrp_tab3_PromedioGeneral
			// 
			this.radGrp_tab3_PromedioGeneral.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.radGrp_tab3_PromedioGeneral.Location = new System.Drawing.Point(43, 101);
			this.radGrp_tab3_PromedioGeneral.Maximum = ((long)(100));
			this.radGrp_tab3_PromedioGeneral.MinimumSize = new System.Drawing.Size(100, 100);
			this.radGrp_tab3_PromedioGeneral.Name = "radGrp_tab3_PromedioGeneral";
			this.radGrp_tab3_PromedioGeneral.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
			this.radGrp_tab3_PromedioGeneral.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
			this.radGrp_tab3_PromedioGeneral.ProgressShape = iTalk.iTalk_ProgressBar._ProgressShape.Round;
			this.radGrp_tab3_PromedioGeneral.Size = new System.Drawing.Size(169, 169);
			this.radGrp_tab3_PromedioGeneral.TabIndex = 1;
			this.radGrp_tab3_PromedioGeneral.Text = "iTalk_ProgressBar1";
			this.radGrp_tab3_PromedioGeneral.Value = ((long)(0));
			// 
			// lbl_tab4_NombreAlumno
			// 
			this.lbl_tab4_NombreAlumno.AutoSize = true;
			this.lbl_tab4_NombreAlumno.BackColor = System.Drawing.Color.Transparent;
			this.lbl_tab4_NombreAlumno.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_tab4_NombreAlumno.ForeColor = System.Drawing.Color.White;
			this.lbl_tab4_NombreAlumno.Location = new System.Drawing.Point(30, 30);
			this.lbl_tab4_NombreAlumno.Name = "lbl_tab4_NombreAlumno";
			this.lbl_tab4_NombreAlumno.Size = new System.Drawing.Size(214, 32);
			this.lbl_tab4_NombreAlumno.TabIndex = 0;
			this.lbl_tab4_NombreAlumno.Text = "Nombre Alumno--";
			// 
			// tab4_Docente_CursoGeneral
			// 
			this.tab4_Docente_CursoGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
			this.tab4_Docente_CursoGeneral.Controls.Add(this.regresar);
			this.tab4_Docente_CursoGeneral.Controls.Add(this.lbl_tab4_AlumnosVuln);
			this.tab4_Docente_CursoGeneral.Controls.Add(this.dgv_tab4_Vulnerables);
			this.tab4_Docente_CursoGeneral.Controls.Add(this.lbl_tab4_NombreCurso);
			this.tab4_Docente_CursoGeneral.Location = new System.Drawing.Point(4, 44);
			this.tab4_Docente_CursoGeneral.Name = "tab4_Docente_CursoGeneral";
			this.tab4_Docente_CursoGeneral.Size = new System.Drawing.Size(532, 440);
			this.tab4_Docente_CursoGeneral.TabIndex = 6;
			this.tab4_Docente_CursoGeneral.Text = "tabPage1";
			// 
			// regresar
			// 
			this.regresar.BackColor = System.Drawing.Color.Transparent;
			this.regresar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.regresar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.regresar.DialogResult = System.Windows.Forms.DialogResult.None;
			this.regresar.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.regresar.Location = new System.Drawing.Point(36, 376);
			this.regresar.Name = "regresar";
			this.regresar.Rounded = false;
			this.regresar.Size = new System.Drawing.Size(106, 32);
			this.regresar.TabIndex = 3;
			this.regresar.Text = "flatButton1";
			this.regresar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			// 
			// lbl_tab4_AlumnosVuln
			// 
			this.lbl_tab4_AlumnosVuln.AutoSize = true;
			this.lbl_tab4_AlumnosVuln.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_tab4_AlumnosVuln.ForeColor = System.Drawing.Color.Red;
			this.lbl_tab4_AlumnosVuln.Location = new System.Drawing.Point(194, 183);
			this.lbl_tab4_AlumnosVuln.Name = "lbl_tab4_AlumnosVuln";
			this.lbl_tab4_AlumnosVuln.Size = new System.Drawing.Size(214, 30);
			this.lbl_tab4_AlumnosVuln.TabIndex = 2;
			this.lbl_tab4_AlumnosVuln.Text = "Alumnos Vulnerables ";
			// 
			// dgv_tab4_Vulnerables
			// 
			this.dgv_tab4_Vulnerables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_tab4_Vulnerables.Location = new System.Drawing.Point(177, 243);
			this.dgv_tab4_Vulnerables.Name = "dgv_tab4_Vulnerables";
			this.dgv_tab4_Vulnerables.Size = new System.Drawing.Size(314, 150);
			this.dgv_tab4_Vulnerables.TabIndex = 1;
			// 
			// lbl_tab4_NombreCurso
			// 
			this.lbl_tab4_NombreCurso.AutoSize = true;
			this.lbl_tab4_NombreCurso.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_tab4_NombreCurso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lbl_tab4_NombreCurso.Location = new System.Drawing.Point(30, 30);
			this.lbl_tab4_NombreCurso.Name = "lbl_tab4_NombreCurso";
			this.lbl_tab4_NombreCurso.Size = new System.Drawing.Size(171, 32);
			this.lbl_tab4_NombreCurso.TabIndex = 0;
			this.lbl_tab4_NombreCurso.Text = "Nombre Curso";
			// 
			// tab5_Alumno_VistaGeneralCurso
			// 
			this.tab5_Alumno_VistaGeneralCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
			this.tab5_Alumno_VistaGeneralCurso.Location = new System.Drawing.Point(4, 44);
			this.tab5_Alumno_VistaGeneralCurso.Name = "tab5_Alumno_VistaGeneralCurso";
			this.tab5_Alumno_VistaGeneralCurso.Size = new System.Drawing.Size(532, 440);
			this.tab5_Alumno_VistaGeneralCurso.TabIndex = 4;
			this.tab5_Alumno_VistaGeneralCurso.Text = "tabPage1";
			// 
			// tab5_Docente_CrearCurso
			// 
			this.tab5_Docente_CrearCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
			this.tab5_Docente_CrearCurso.Controls.Add(this.flatLabel1);
			this.tab5_Docente_CrearCurso.Controls.Add(this.txtbox_tab5_courseName);
			this.tab5_Docente_CrearCurso.Controls.Add(this.lbl_tab5_ejemplo);
			this.tab5_Docente_CrearCurso.Controls.Add(this.btn_tab5_cancelar);
			this.tab5_Docente_CrearCurso.Controls.Add(this.btn_tab5_aceptar);
			this.tab5_Docente_CrearCurso.Controls.Add(this.lbl_tab5_NombreMateria);
			this.tab5_Docente_CrearCurso.Controls.Add(this.lbl_tab5_NombCortGrupo);
			this.tab5_Docente_CrearCurso.Controls.Add(this.txtbox_tab5_grup);
			this.tab5_Docente_CrearCurso.Controls.Add(this.txtbox_tab5_grade);
			this.tab5_Docente_CrearCurso.Controls.Add(this.lbl_tab5_Creargrupo);
			this.tab5_Docente_CrearCurso.Location = new System.Drawing.Point(4, 44);
			this.tab5_Docente_CrearCurso.Name = "tab5_Docente_CrearCurso";
			this.tab5_Docente_CrearCurso.Size = new System.Drawing.Size(532, 440);
			this.tab5_Docente_CrearCurso.TabIndex = 7;
			this.tab5_Docente_CrearCurso.Text = "tabPage1";
			// 
			// flatLabel1
			// 
			this.flatLabel1.AutoSize = true;
			this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
			this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.flatLabel1.ForeColor = System.Drawing.Color.White;
			this.flatLabel1.Location = new System.Drawing.Point(39, 90);
			this.flatLabel1.Name = "flatLabel1";
			this.flatLabel1.Size = new System.Drawing.Size(100, 13);
			this.flatLabel1.TabIndex = 14;
			this.flatLabel1.Text = "Nombre del Curso";
			// 
			// txtbox_tab5_courseName
			// 
			this.txtbox_tab5_courseName.BackColor = System.Drawing.Color.Transparent;
			this.txtbox_tab5_courseName.FocusOnHover = false;
			this.txtbox_tab5_courseName.Location = new System.Drawing.Point(36, 107);
			this.txtbox_tab5_courseName.MaxLength = 32767;
			this.txtbox_tab5_courseName.Multiline = false;
			this.txtbox_tab5_courseName.Name = "txtbox_tab5_courseName";
			this.txtbox_tab5_courseName.ReadOnly = false;
			this.txtbox_tab5_courseName.Size = new System.Drawing.Size(176, 29);
			this.txtbox_tab5_courseName.TabIndex = 0;
			this.txtbox_tab5_courseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtbox_tab5_courseName.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtbox_tab5_courseName.UseSystemPasswordChar = false;
			// 
			// lbl_tab5_ejemplo
			// 
			this.lbl_tab5_ejemplo.AutoSize = true;
			this.lbl_tab5_ejemplo.BackColor = System.Drawing.Color.Transparent;
			this.lbl_tab5_ejemplo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_tab5_ejemplo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
			this.lbl_tab5_ejemplo.Location = new System.Drawing.Point(218, 107);
			this.lbl_tab5_ejemplo.Name = "lbl_tab5_ejemplo";
			this.lbl_tab5_ejemplo.Size = new System.Drawing.Size(162, 17);
			this.lbl_tab5_ejemplo.TabIndex = 11;
			this.lbl_tab5_ejemplo.Text = "//Ejemplo Programacion 1";
			// 
			// btn_tab5_cancelar
			// 
			this.btn_tab5_cancelar.BackColor = System.Drawing.Color.Transparent;
			this.btn_tab5_cancelar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.btn_tab5_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_tab5_cancelar.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btn_tab5_cancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btn_tab5_cancelar.Location = new System.Drawing.Point(173, 370);
			this.btn_tab5_cancelar.Name = "btn_tab5_cancelar";
			this.btn_tab5_cancelar.Rounded = false;
			this.btn_tab5_cancelar.Size = new System.Drawing.Size(106, 32);
			this.btn_tab5_cancelar.TabIndex = 10;
			this.btn_tab5_cancelar.Text = "Cancelar ";
			this.btn_tab5_cancelar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.btn_tab5_cancelar.Click += new System.EventHandler(this.btn_tab5_cancelar_Click);
			// 
			// btn_tab5_aceptar
			// 
			this.btn_tab5_aceptar.BackColor = System.Drawing.Color.Transparent;
			this.btn_tab5_aceptar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.btn_tab5_aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_tab5_aceptar.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btn_tab5_aceptar.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btn_tab5_aceptar.Location = new System.Drawing.Point(36, 370);
			this.btn_tab5_aceptar.Name = "btn_tab5_aceptar";
			this.btn_tab5_aceptar.Rounded = false;
			this.btn_tab5_aceptar.Size = new System.Drawing.Size(106, 32);
			this.btn_tab5_aceptar.TabIndex = 9;
			this.btn_tab5_aceptar.Text = "Aceptar";
			this.btn_tab5_aceptar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.btn_tab5_aceptar.Click += new System.EventHandler(this.btn_tab5_aceptar_Click);
			// 
			// lbl_tab5_NombreMateria
			// 
			this.lbl_tab5_NombreMateria.AutoSize = true;
			this.lbl_tab5_NombreMateria.BackColor = System.Drawing.Color.Transparent;
			this.lbl_tab5_NombreMateria.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lbl_tab5_NombreMateria.ForeColor = System.Drawing.Color.White;
			this.lbl_tab5_NombreMateria.Location = new System.Drawing.Point(39, 203);
			this.lbl_tab5_NombreMateria.Name = "lbl_tab5_NombreMateria";
			this.lbl_tab5_NombreMateria.Size = new System.Drawing.Size(40, 13);
			this.lbl_tab5_NombreMateria.TabIndex = 4;
			this.lbl_tab5_NombreMateria.Text = "Grupo";
			// 
			// lbl_tab5_NombCortGrupo
			// 
			this.lbl_tab5_NombCortGrupo.AutoSize = true;
			this.lbl_tab5_NombCortGrupo.BackColor = System.Drawing.Color.Transparent;
			this.lbl_tab5_NombCortGrupo.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.lbl_tab5_NombCortGrupo.ForeColor = System.Drawing.Color.White;
			this.lbl_tab5_NombCortGrupo.Location = new System.Drawing.Point(39, 147);
			this.lbl_tab5_NombCortGrupo.Name = "lbl_tab5_NombCortGrupo";
			this.lbl_tab5_NombCortGrupo.Size = new System.Drawing.Size(39, 13);
			this.lbl_tab5_NombCortGrupo.TabIndex = 3;
			this.lbl_tab5_NombCortGrupo.Text = "Grado";
			// 
			// txtbox_tab5_grup
			// 
			this.txtbox_tab5_grup.BackColor = System.Drawing.Color.Transparent;
			this.txtbox_tab5_grup.FocusOnHover = false;
			this.txtbox_tab5_grup.Location = new System.Drawing.Point(36, 219);
			this.txtbox_tab5_grup.MaxLength = 1;
			this.txtbox_tab5_grup.Multiline = false;
			this.txtbox_tab5_grup.Name = "txtbox_tab5_grup";
			this.txtbox_tab5_grup.ReadOnly = false;
			this.txtbox_tab5_grup.Size = new System.Drawing.Size(55, 29);
			this.txtbox_tab5_grup.TabIndex = 2;
			this.txtbox_tab5_grup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtbox_tab5_grup.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtbox_tab5_grup.UseSystemPasswordChar = false;
			// 
			// txtbox_tab5_grade
			// 
			this.txtbox_tab5_grade.BackColor = System.Drawing.Color.Transparent;
			this.txtbox_tab5_grade.FocusOnHover = false;
			this.txtbox_tab5_grade.Location = new System.Drawing.Point(36, 163);
			this.txtbox_tab5_grade.MaxLength = 1;
			this.txtbox_tab5_grade.Multiline = false;
			this.txtbox_tab5_grade.Name = "txtbox_tab5_grade";
			this.txtbox_tab5_grade.ReadOnly = false;
			this.txtbox_tab5_grade.Size = new System.Drawing.Size(55, 29);
			this.txtbox_tab5_grade.TabIndex = 1;
			this.txtbox_tab5_grade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtbox_tab5_grade.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtbox_tab5_grade.UseSystemPasswordChar = false;
			// 
			// lbl_tab5_Creargrupo
			// 
			this.lbl_tab5_Creargrupo.AutoSize = true;
			this.lbl_tab5_Creargrupo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_tab5_Creargrupo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbl_tab5_Creargrupo.Location = new System.Drawing.Point(30, 30);
			this.lbl_tab5_Creargrupo.Name = "lbl_tab5_Creargrupo";
			this.lbl_tab5_Creargrupo.Size = new System.Drawing.Size(144, 32);
			this.lbl_tab5_Creargrupo.TabIndex = 0;
			this.lbl_tab5_Creargrupo.Text = "Crear Grupo";
			// 
			// tab6_Docente_ListaDeCursos
			// 
			this.tab6_Docente_ListaDeCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
			this.tab6_Docente_ListaDeCursos.Controls.Add(this.flatButton1);
			this.tab6_Docente_ListaDeCursos.Controls.Add(this.btn_tab6_EditCourse);
			this.tab6_Docente_ListaDeCursos.Controls.Add(this.btn_tab6_EraseCourse);
			this.tab6_Docente_ListaDeCursos.Controls.Add(this.lvw_tab6_GroupList);
			this.tab6_Docente_ListaDeCursos.Controls.Add(this.btn_tab6_EnrollStudents);
			this.tab6_Docente_ListaDeCursos.Controls.Add(this.btn_tab6_regresar);
			this.tab6_Docente_ListaDeCursos.Controls.Add(this.lbl_tab6_listagrupos);
			this.tab6_Docente_ListaDeCursos.Location = new System.Drawing.Point(4, 44);
			this.tab6_Docente_ListaDeCursos.Name = "tab6_Docente_ListaDeCursos";
			this.tab6_Docente_ListaDeCursos.Size = new System.Drawing.Size(532, 440);
			this.tab6_Docente_ListaDeCursos.TabIndex = 8;
			this.tab6_Docente_ListaDeCursos.Text = "tabPage1";
			this.tab6_Docente_ListaDeCursos.Click += new System.EventHandler(this.tab6_Docente_CursoLista_Click);
			// 
			// flatButton1
			// 
			this.flatButton1.BackColor = System.Drawing.Color.Transparent;
			this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.flatButton1.DialogResult = System.Windows.Forms.DialogResult.None;
			this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.flatButton1.Location = new System.Drawing.Point(383, 235);
			this.flatButton1.Name = "flatButton1";
			this.flatButton1.Rounded = false;
			this.flatButton1.Size = new System.Drawing.Size(106, 32);
			this.flatButton1.TabIndex = 6;
			this.flatButton1.Text = "flatButton1";
			this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
			// 
			// btn_tab6_EditCourse
			// 
			this.btn_tab6_EditCourse.BackColor = System.Drawing.Color.Transparent;
			this.btn_tab6_EditCourse.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.btn_tab6_EditCourse.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_tab6_EditCourse.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btn_tab6_EditCourse.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btn_tab6_EditCourse.Location = new System.Drawing.Point(361, 172);
			this.btn_tab6_EditCourse.Name = "btn_tab6_EditCourse";
			this.btn_tab6_EditCourse.Rounded = false;
			this.btn_tab6_EditCourse.Size = new System.Drawing.Size(145, 32);
			this.btn_tab6_EditCourse.TabIndex = 5;
			this.btn_tab6_EditCourse.Text = "Calificar Curso";
			this.btn_tab6_EditCourse.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			// 
			// btn_tab6_EraseCourse
			// 
			this.btn_tab6_EraseCourse.BackColor = System.Drawing.Color.Transparent;
			this.btn_tab6_EraseCourse.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.btn_tab6_EraseCourse.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_tab6_EraseCourse.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btn_tab6_EraseCourse.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btn_tab6_EraseCourse.Location = new System.Drawing.Point(361, 134);
			this.btn_tab6_EraseCourse.Name = "btn_tab6_EraseCourse";
			this.btn_tab6_EraseCourse.Rounded = false;
			this.btn_tab6_EraseCourse.Size = new System.Drawing.Size(145, 32);
			this.btn_tab6_EraseCourse.TabIndex = 4;
			this.btn_tab6_EraseCourse.Text = "Eliminar Curso";
			this.btn_tab6_EraseCourse.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.btn_tab6_EraseCourse.Click += new System.EventHandler(this.btn_tab6_EraseCourse_Click);
			// 
			// lvw_tab6_GroupList
			// 
			this.lvw_tab6_GroupList.BackColor = System.Drawing.Color.Gray;
			this.lvw_tab6_GroupList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvw_tab6_GroupList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Name,
            this.col_Grade,
            this.col_group});
			this.lvw_tab6_GroupList.FullRowSelect = true;
			this.lvw_tab6_GroupList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvw_tab6_GroupList.LabelWrap = false;
			this.lvw_tab6_GroupList.Location = new System.Drawing.Point(27, 96);
			this.lvw_tab6_GroupList.MultiSelect = false;
			this.lvw_tab6_GroupList.Name = "lvw_tab6_GroupList";
			this.lvw_tab6_GroupList.Size = new System.Drawing.Size(292, 303);
			this.lvw_tab6_GroupList.TabIndex = 3;
			this.lvw_tab6_GroupList.UseCompatibleStateImageBehavior = false;
			this.lvw_tab6_GroupList.View = System.Windows.Forms.View.Details;
			// 
			// col_Name
			// 
			this.col_Name.Text = "Nombre";
			this.col_Name.Width = 214;
			// 
			// col_Grade
			// 
			this.col_Grade.Text = "Grado";
			this.col_Grade.Width = 37;
			// 
			// col_group
			// 
			this.col_group.Text = "Grupo";
			this.col_group.Width = 38;
			// 
			// btn_tab6_EnrollStudents
			// 
			this.btn_tab6_EnrollStudents.BackColor = System.Drawing.Color.Transparent;
			this.btn_tab6_EnrollStudents.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.btn_tab6_EnrollStudents.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_tab6_EnrollStudents.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btn_tab6_EnrollStudents.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btn_tab6_EnrollStudents.Location = new System.Drawing.Point(361, 96);
			this.btn_tab6_EnrollStudents.Name = "btn_tab6_EnrollStudents";
			this.btn_tab6_EnrollStudents.Rounded = false;
			this.btn_tab6_EnrollStudents.Size = new System.Drawing.Size(145, 32);
			this.btn_tab6_EnrollStudents.TabIndex = 2;
			this.btn_tab6_EnrollStudents.Text = "inscribir Alumnos";
			this.btn_tab6_EnrollStudents.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.btn_tab6_EnrollStudents.Click += new System.EventHandler(this.btn_tab6_EnrollStudents_Click);
			// 
			// btn_tab6_regresar
			// 
			this.btn_tab6_regresar.BackColor = System.Drawing.Color.Transparent;
			this.btn_tab6_regresar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.btn_tab6_regresar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_tab6_regresar.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btn_tab6_regresar.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btn_tab6_regresar.Location = new System.Drawing.Point(361, 367);
			this.btn_tab6_regresar.Name = "btn_tab6_regresar";
			this.btn_tab6_regresar.Rounded = false;
			this.btn_tab6_regresar.Size = new System.Drawing.Size(145, 32);
			this.btn_tab6_regresar.TabIndex = 1;
			this.btn_tab6_regresar.Text = "Regresar";
			this.btn_tab6_regresar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.btn_tab6_regresar.Click += new System.EventHandler(this.btn_tab6_regresar_Click);
			// 
			// lbl_tab6_listagrupos
			// 
			this.lbl_tab6_listagrupos.AutoSize = true;
			this.lbl_tab6_listagrupos.BackColor = System.Drawing.Color.Transparent;
			this.lbl_tab6_listagrupos.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_tab6_listagrupos.ForeColor = System.Drawing.Color.White;
			this.lbl_tab6_listagrupos.Location = new System.Drawing.Point(30, 30);
			this.lbl_tab6_listagrupos.Name = "lbl_tab6_listagrupos";
			this.lbl_tab6_listagrupos.Size = new System.Drawing.Size(205, 37);
			this.lbl_tab6_listagrupos.TabIndex = 0;
			this.lbl_tab6_listagrupos.Text = "Lista de grupos ";
			// 
			// tab7_Docente_InscripcionAlumnos
			// 
			this.tab7_Docente_InscripcionAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
			this.tab7_Docente_InscripcionAlumnos.Controls.Add(this.btn_tab7_upgradeCALS);
			this.tab7_Docente_InscripcionAlumnos.Controls.Add(this.cal6);
			this.tab7_Docente_InscripcionAlumnos.Controls.Add(this.cal5);
			this.tab7_Docente_InscripcionAlumnos.Controls.Add(this.cal4);
			this.tab7_Docente_InscripcionAlumnos.Controls.Add(this.cal3);
			this.tab7_Docente_InscripcionAlumnos.Controls.Add(this.cal2);
			this.tab7_Docente_InscripcionAlumnos.Controls.Add(this.cal1);
			this.tab7_Docente_InscripcionAlumnos.Controls.Add(this.btn_tab7_regresarAListaDeCurso);
			this.tab7_Docente_InscripcionAlumnos.Controls.Add(this.btn_tab7_eliminar);
			this.tab7_Docente_InscripcionAlumnos.Controls.Add(this.btn_tab7_insciribir);
			this.tab7_Docente_InscripcionAlumnos.Controls.Add(this.txtbox_tab7_userName);
			this.tab7_Docente_InscripcionAlumnos.Controls.Add(this.lvw_tab7_enrolledStudents);
			this.tab7_Docente_InscripcionAlumnos.Controls.Add(this.lbl_tab7_inscribira);
			this.tab7_Docente_InscripcionAlumnos.Location = new System.Drawing.Point(4, 44);
			this.tab7_Docente_InscripcionAlumnos.Name = "tab7_Docente_InscripcionAlumnos";
			this.tab7_Docente_InscripcionAlumnos.Size = new System.Drawing.Size(532, 440);
			this.tab7_Docente_InscripcionAlumnos.TabIndex = 9;
			this.tab7_Docente_InscripcionAlumnos.Text = "ActualizarCalificaciones";
			// 
			// btn_tab7_regresarAListaDeCurso
			// 
			this.btn_tab7_regresarAListaDeCurso.BackColor = System.Drawing.Color.Transparent;
			this.btn_tab7_regresarAListaDeCurso.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.btn_tab7_regresarAListaDeCurso.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_tab7_regresarAListaDeCurso.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btn_tab7_regresarAListaDeCurso.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btn_tab7_regresarAListaDeCurso.Location = new System.Drawing.Point(400, 376);
			this.btn_tab7_regresarAListaDeCurso.Name = "btn_tab7_regresarAListaDeCurso";
			this.btn_tab7_regresarAListaDeCurso.Rounded = false;
			this.btn_tab7_regresarAListaDeCurso.Size = new System.Drawing.Size(106, 32);
			this.btn_tab7_regresarAListaDeCurso.TabIndex = 5;
			this.btn_tab7_regresarAListaDeCurso.Text = "Regresar";
			this.btn_tab7_regresarAListaDeCurso.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.btn_tab7_regresarAListaDeCurso.Click += new System.EventHandler(this.btn_tab7_regresarAListaDeCurso_Click);
			// 
			// btn_tab7_eliminar
			// 
			this.btn_tab7_eliminar.BackColor = System.Drawing.Color.Transparent;
			this.btn_tab7_eliminar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.btn_tab7_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_tab7_eliminar.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btn_tab7_eliminar.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btn_tab7_eliminar.Location = new System.Drawing.Point(298, 164);
			this.btn_tab7_eliminar.Name = "btn_tab7_eliminar";
			this.btn_tab7_eliminar.Rounded = false;
			this.btn_tab7_eliminar.Size = new System.Drawing.Size(162, 32);
			this.btn_tab7_eliminar.TabIndex = 4;
			this.btn_tab7_eliminar.Text = "Eliminar";
			this.btn_tab7_eliminar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.btn_tab7_eliminar.Click += new System.EventHandler(this.btn_tab7_eliminar_Click);
			// 
			// btn_tab7_insciribir
			// 
			this.btn_tab7_insciribir.BackColor = System.Drawing.Color.Transparent;
			this.btn_tab7_insciribir.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.btn_tab7_insciribir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_tab7_insciribir.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btn_tab7_insciribir.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btn_tab7_insciribir.Location = new System.Drawing.Point(298, 125);
			this.btn_tab7_insciribir.Name = "btn_tab7_insciribir";
			this.btn_tab7_insciribir.Rounded = false;
			this.btn_tab7_insciribir.Size = new System.Drawing.Size(162, 32);
			this.btn_tab7_insciribir.TabIndex = 3;
			this.btn_tab7_insciribir.Text = "Inscribir";
			this.btn_tab7_insciribir.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.btn_tab7_insciribir.Click += new System.EventHandler(this.flatButton2_Click);
			// 
			// txtbox_tab7_userName
			// 
			this.txtbox_tab7_userName.BackColor = System.Drawing.Color.Transparent;
			this.txtbox_tab7_userName.FocusOnHover = false;
			this.txtbox_tab7_userName.Location = new System.Drawing.Point(298, 89);
			this.txtbox_tab7_userName.MaxLength = 32767;
			this.txtbox_tab7_userName.Multiline = false;
			this.txtbox_tab7_userName.Name = "txtbox_tab7_userName";
			this.txtbox_tab7_userName.ReadOnly = false;
			this.txtbox_tab7_userName.Size = new System.Drawing.Size(162, 29);
			this.txtbox_tab7_userName.TabIndex = 2;
			this.txtbox_tab7_userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtbox_tab7_userName.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtbox_tab7_userName.UseSystemPasswordChar = false;
			// 
			// lvw_tab7_enrolledStudents
			// 
			this.lvw_tab7_enrolledStudents.BackColor = System.Drawing.Color.Silver;
			this.lvw_tab7_enrolledStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre});
			this.lvw_tab7_enrolledStudents.FullRowSelect = true;
			this.lvw_tab7_enrolledStudents.Location = new System.Drawing.Point(37, 89);
			this.lvw_tab7_enrolledStudents.Name = "lvw_tab7_enrolledStudents";
			this.lvw_tab7_enrolledStudents.Size = new System.Drawing.Size(242, 319);
			this.lvw_tab7_enrolledStudents.TabIndex = 1;
			this.lvw_tab7_enrolledStudents.UseCompatibleStateImageBehavior = false;
			this.lvw_tab7_enrolledStudents.View = System.Windows.Forms.View.Details;
			// 
			// Nombre
			// 
			this.Nombre.Text = "Nombre";
			this.Nombre.Width = 227;
			// 
			// lbl_tab7_inscribira
			// 
			this.lbl_tab7_inscribira.AutoSize = true;
			this.lbl_tab7_inscribira.BackColor = System.Drawing.Color.Transparent;
			this.lbl_tab7_inscribira.Font = new System.Drawing.Font("Segoe UI", 20.25F);
			this.lbl_tab7_inscribira.ForeColor = System.Drawing.Color.White;
			this.lbl_tab7_inscribira.Location = new System.Drawing.Point(30, 30);
			this.lbl_tab7_inscribira.Name = "lbl_tab7_inscribira";
			this.lbl_tab7_inscribira.Size = new System.Drawing.Size(249, 37);
			this.lbl_tab7_inscribira.TabIndex = 0;
			this.lbl_tab7_inscribira.Text = "Inscribir Alumnos a ";
			// 
			// tmr_psw
			// 
			this.tmr_psw.Interval = 500;
			this.tmr_psw.Tick += new System.EventHandler(this.tmr_psw_Tick);
			// 
			// cal1
			// 
			this.cal1.BackColor = System.Drawing.Color.Transparent;
			this.cal1.FocusOnHover = false;
			this.cal1.Location = new System.Drawing.Point(298, 222);
			this.cal1.MaxLength = 32767;
			this.cal1.Multiline = false;
			this.cal1.Name = "cal1";
			this.cal1.ReadOnly = false;
			this.cal1.Size = new System.Drawing.Size(37, 29);
			this.cal1.TabIndex = 6;
			this.cal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.cal1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.cal1.UseSystemPasswordChar = false;
			// 
			// cal2
			// 
			this.cal2.BackColor = System.Drawing.Color.Transparent;
			this.cal2.FocusOnHover = false;
			this.cal2.Location = new System.Drawing.Point(341, 222);
			this.cal2.MaxLength = 32767;
			this.cal2.Multiline = false;
			this.cal2.Name = "cal2";
			this.cal2.ReadOnly = false;
			this.cal2.Size = new System.Drawing.Size(36, 29);
			this.cal2.TabIndex = 7;
			this.cal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.cal2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.cal2.UseSystemPasswordChar = false;
			// 
			// cal3
			// 
			this.cal3.BackColor = System.Drawing.Color.Transparent;
			this.cal3.FocusOnHover = false;
			this.cal3.Location = new System.Drawing.Point(383, 222);
			this.cal3.MaxLength = 32767;
			this.cal3.Multiline = false;
			this.cal3.Name = "cal3";
			this.cal3.ReadOnly = false;
			this.cal3.Size = new System.Drawing.Size(39, 29);
			this.cal3.TabIndex = 8;
			this.cal3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.cal3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.cal3.UseSystemPasswordChar = false;
			// 
			// cal4
			// 
			this.cal4.BackColor = System.Drawing.Color.Transparent;
			this.cal4.FocusOnHover = false;
			this.cal4.Location = new System.Drawing.Point(298, 257);
			this.cal4.MaxLength = 32767;
			this.cal4.Multiline = false;
			this.cal4.Name = "cal4";
			this.cal4.ReadOnly = false;
			this.cal4.Size = new System.Drawing.Size(37, 29);
			this.cal4.TabIndex = 9;
			this.cal4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.cal4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.cal4.UseSystemPasswordChar = false;
			// 
			// cal5
			// 
			this.cal5.BackColor = System.Drawing.Color.Transparent;
			this.cal5.FocusOnHover = false;
			this.cal5.Location = new System.Drawing.Point(341, 257);
			this.cal5.MaxLength = 32767;
			this.cal5.Multiline = false;
			this.cal5.Name = "cal5";
			this.cal5.ReadOnly = false;
			this.cal5.Size = new System.Drawing.Size(36, 29);
			this.cal5.TabIndex = 10;
			this.cal5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.cal5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.cal5.UseSystemPasswordChar = false;
			// 
			// cal6
			// 
			this.cal6.BackColor = System.Drawing.Color.Transparent;
			this.cal6.FocusOnHover = false;
			this.cal6.Location = new System.Drawing.Point(383, 257);
			this.cal6.MaxLength = 32767;
			this.cal6.Multiline = false;
			this.cal6.Name = "cal6";
			this.cal6.ReadOnly = false;
			this.cal6.Size = new System.Drawing.Size(39, 29);
			this.cal6.TabIndex = 11;
			this.cal6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.cal6.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.cal6.UseSystemPasswordChar = false;
			// 
			// btn_tab7_upgradeCALS
			// 
			this.btn_tab7_upgradeCALS.BackColor = System.Drawing.Color.Transparent;
			this.btn_tab7_upgradeCALS.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.btn_tab7_upgradeCALS.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_tab7_upgradeCALS.DialogResult = System.Windows.Forms.DialogResult.None;
			this.btn_tab7_upgradeCALS.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btn_tab7_upgradeCALS.Location = new System.Drawing.Point(298, 293);
			this.btn_tab7_upgradeCALS.Name = "btn_tab7_upgradeCALS";
			this.btn_tab7_upgradeCALS.Rounded = false;
			this.btn_tab7_upgradeCALS.Size = new System.Drawing.Size(162, 43);
			this.btn_tab7_upgradeCALS.TabIndex = 12;
			this.btn_tab7_upgradeCALS.Text = "Actualizar Calificaciones ";
			this.btn_tab7_upgradeCALS.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.btn_tab7_upgradeCALS.Click += new System.EventHandler(this.btn_tab7_upgradeCALS_Click);
			// 
			// Frame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(540, 480);
			this.Controls.Add(this.pnl_body);
			this.Controls.Add(this.pnl_header);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Frame";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "iTalk_ThemeContainer1";
			this.TransparencyKey = System.Drawing.Color.Fuchsia;
			this.pnl_header.ResumeLayout(false);
			this.pnl_header.PerformLayout();
			this.pnl_body.ResumeLayout(false);
			this.tabControl.ResumeLayout(false);
			this.tab0_Startup.ResumeLayout(false);
			this.tab0_Startup.PerformLayout();
			this.tab1_login.ResumeLayout(false);
			this.tab1_login.PerformLayout();
			this.tab2_registro.ResumeLayout(false);
			this.tab2_registro.PerformLayout();
			this.tab3_Alumno_VistaGeneral.ResumeLayout(false);
			this.tab3_Alumno_VistaGeneral.PerformLayout();
			this.tab3_Docente_VistaGeneral.ResumeLayout(false);
			this.tab3_Docente_VistaGeneral.PerformLayout();
			this.tab4_Alumno_ListaDeCursos.ResumeLayout(false);
			this.tab4_Alumno_ListaDeCursos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridview_tab4)).EndInit();
			this.tab4_Docente_CursoGeneral.ResumeLayout(false);
			this.tab4_Docente_CursoGeneral.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_tab4_Vulnerables)).EndInit();
			this.tab5_Docente_CrearCurso.ResumeLayout(false);
			this.tab5_Docente_CrearCurso.PerformLayout();
			this.tab6_Docente_ListaDeCursos.ResumeLayout(false);
			this.tab6_Docente_ListaDeCursos.PerformLayout();
			this.tab7_Docente_InscripcionAlumnos.ResumeLayout(false);
			this.tab7_Docente_InscripcionAlumnos.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnl_header;
		private System.Windows.Forms.Panel pnl_body;
		private FlatUI.FlatTabControl tabControl;
		private System.Windows.Forms.TabPage tab1_login;
		private FlatUI.FlatLabel flatLabel3;
		private FlatUI.FlatLabel trash_lblContraseña;
		private FlatUI.FlatLabel lbl_Usuario;
		private FlatUI.FlatButton btn_ingresar;
		private FlatUI.FlatTextBox txtbox_contraseña;
		private FlatUI.FlatTextBox txtbox_usuario;
		private FlatUI.FlatLabel flatLabel4;
		private System.Windows.Forms.LinkLabel llb_CrearCuenta;
		private System.Windows.Forms.TabPage tab2_registro;
		private System.Windows.Forms.TabPage tab3_Alumno_VistaGeneral;
		private System.Windows.Forms.TabPage tab4_Alumno_ListaDeCursos;
		private System.Windows.Forms.TabPage tab5_Alumno_VistaGeneralCurso;
		private System.Windows.Forms.TabPage tab3_Docente_VistaGeneral;
		private System.Windows.Forms.TabPage tab4_Docente_CursoGeneral;
		private System.Windows.Forms.TabPage tab5_Docente_CrearCurso;
		private System.Windows.Forms.TabPage tab6_Docente_ListaDeCursos;
		private System.Windows.Forms.TabPage tab7_Docente_InscripcionAlumnos;
		private FlatUI.FlatMini flatMini1;
		private FlatUI.FlatStickyButton btn_tab3_GrupoInscrito;
		private iTalk.iTalk_ProgressBar radGrp_tab3_Progresototal5;
		private iTalk.iTalk_ProgressBar radGrp_tab3_Progresototal3;
		private iTalk.iTalk_ProgressBar radGrp_tab3_Progresototal4;
		private iTalk.iTalk_ProgressBar radGrp_tab3_Progresototal2;
		private iTalk.iTalk_ProgressBar radGrp_tab3_Progresototal;
		private System.Windows.Forms.LinkLabel llb_tab3_PromedioGeneral;
		private System.Windows.Forms.LinkLabel llb_tab3_materia4;
		private System.Windows.Forms.LinkLabel llb_tab3_materia3;
		private System.Windows.Forms.LinkLabel llb_tab3_materia2;
		private System.Windows.Forms.LinkLabel llb_tab3_materia1;
		private System.Windows.Forms.Label lbl_tab3_NombreAlumno;
		private FlatUI.FlatStickyButton btn_tab3_listagrupo;
		private FlatUI.FlatButton btn_tab3_CrearGrupoPrf;
		private FlatUI.FlatButton btn_tab3_GrupolistaProf;
		private FlatUI.FlatButton btn_tab3_CursoGeneralProfesor;
		private System.Windows.Forms.Label lbl_tab3_NombreProfesor;
		private FlatUI.FlatLabel lbl_tab3_selectOpcion;
		private iTalk.iTalk_ProgressBar radgrp_tab4_materiaProgreso;
		private System.Windows.Forms.DataGridView dataGridview_tab4;
		private iTalk.iTalk_ProgressBar radGrp_tab3_PromedioGeneral;
		private FlatUI.FlatLabel lbl_tab4_NombreAlumno;
		private System.Windows.Forms.Label lbl_tab4_AlumnosVuln;
		private System.Windows.Forms.DataGridView dgv_tab4_Vulnerables;
		private System.Windows.Forms.Label lbl_tab4_NombreCurso;
		private FlatUI.FlatButton btn_tab5_cancelar;
		private FlatUI.FlatButton btn_tab5_aceptar;
		private FlatUI.FlatLabel lbl_tab5_NombreMateria;
		private FlatUI.FlatLabel lbl_tab5_NombCortGrupo;
		private FlatUI.FlatTextBox txtbox_tab5_grup;
		private FlatUI.FlatTextBox txtbox_tab5_grade;
		private System.Windows.Forms.Label lbl_tab5_Creargrupo;
		private FlatUI.FlatLabel lbl_tab5_ejemplo;
		private FlatUI.FlatButton btn_tab6_EnrollStudents;
		private FlatUI.FlatButton btn_tab6_regresar;
		private FlatUI.FlatLabel lbl_tab6_listagrupos;
		private FlatUI.FlatLabel lbl_tab2_dejeseBlanco;
		private FlatUI.FlatButton btn_tab2_cancelar;
		private FlatUI.FlatButton btn_tab2_aceptar;
		private FlatUI.FlatTextBox txtbox_tab2_conficontraseña;
		private FlatUI.FlatLabel lbl_tab2_confirmarcontra;
		private FlatUI.FlatTextBox txtbox_tab2_contraseña;
		private FlatUI.FlatLabel lbl_tab2_contraseña;
		private FlatUI.FlatTextBox txtbox_tab2_codigo;
		private FlatUI.FlatLabel lbl_tab2_codigoDocente;
		private FlatUI.FlatTextBox txtbox_tab2_registro;
		private FlatUI.FlatLabel lbl_tab2_apellidos;
		private FlatUI.FlatLabel lbl_tab2_nombres;
		private FlatUI.FlatTextBox txtbox_tab2_nombres;
		private FlatUI.FlatLabel lbl_tab2_registro;
		private FlatUI.FlatTextBox txtbox_tab2_nombreUsuario;
		private FlatUI.FlatLabel lbl_tab2_nombreUsuario;
		private iTalk.iTalk_Label iTalk_Label2;
		private System.Windows.Forms.Label lbl_tab2_pswMatch;
		private iTalk.iTalk_Label iTalk_Label1;
		private System.Windows.Forms.Timer tmr_psw;
		private System.Windows.Forms.TabPage tab0_Startup;
		private System.Windows.Forms.Label SMV_LOGO;
		private iTalk.iTalk_Label BY_EPI;
		private FlatUI.FlatClose flatClose1;
		private FlatUI.FlatButton btn_connectToDB;
		private FlatUI.FlatLabel lbl_rootPsw;
		private FlatUI.FlatTextBox txtbox_rootPsw;
		private FlatUI.FlatButton regresar;
		private FlatUI.FlatLabel flatLabel1;
		private FlatUI.FlatTextBox txtbox_tab5_courseName;
		private System.Windows.Forms.ListView lvw_tab6_GroupList;
		private System.Windows.Forms.ColumnHeader col_Name;
		private System.Windows.Forms.ColumnHeader col_Grade;
		private System.Windows.Forms.ColumnHeader col_group;
		private FlatUI.FlatButton btn_tab6_EraseCourse;
		private FlatUI.FlatButton btn_tab6_EditCourse;
		private FlatUI.FlatButton flatButton1;
		private FlatUI.FlatLabel lbl_tab7_inscribira;
		private FlatUI.FlatButton btn_tab7_regresarAListaDeCurso;
		private FlatUI.FlatButton btn_tab7_eliminar;
		private FlatUI.FlatButton btn_tab7_insciribir;
		private FlatUI.FlatTextBox txtbox_tab7_userName;
		private System.Windows.Forms.ListView lvw_tab7_enrolledStudents;
		private System.Windows.Forms.ColumnHeader Nombre;
		private FlatUI.FlatTextBox cal6;
		private FlatUI.FlatTextBox cal5;
		private FlatUI.FlatTextBox cal4;
		private FlatUI.FlatTextBox cal3;
		private FlatUI.FlatTextBox cal2;
		private FlatUI.FlatTextBox cal1;
		private FlatUI.FlatButton btn_tab7_upgradeCALS;
	}
}

