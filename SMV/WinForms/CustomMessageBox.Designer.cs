namespace WinForms
{
	partial class CustomMessageBox
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
			this.header = new System.Windows.Forms.Panel();
			this.btn_close = new FlatUI.FlatClose();
			this.lbl_Title = new FlatUI.FlatLabel();
			this.body = new System.Windows.Forms.Panel();
			this.txtbox_content2 = new FlatUI.FlatTextBox();
			this.btn_cancelar = new FlatUI.FlatButton();
			this.btn_aceptar = new FlatUI.FlatButton();
			this.header.SuspendLayout();
			this.body.SuspendLayout();
			this.SuspendLayout();
			// 
			// header
			// 
			this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.header.Controls.Add(this.btn_close);
			this.header.Controls.Add(this.lbl_Title);
			this.header.Dock = System.Windows.Forms.DockStyle.Top;
			this.header.Location = new System.Drawing.Point(0, 0);
			this.header.Name = "header";
			this.header.Size = new System.Drawing.Size(250, 20);
			this.header.TabIndex = 0;
			this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.header_MouseMove);
			// 
			// btn_close
			// 
			this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_close.BackColor = System.Drawing.Color.White;
			this.btn_close.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.btn_close.Font = new System.Drawing.Font("Marlett", 10F);
			this.btn_close.Location = new System.Drawing.Point(232, 2);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(18, 18);
			this.btn_close.TabIndex = 1;
			this.btn_close.Text = "flatClose1";
			this.btn_close.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
			// 
			// lbl_Title
			// 
			this.lbl_Title.AutoSize = true;
			this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
			this.lbl_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
			this.lbl_Title.ForeColor = System.Drawing.Color.White;
			this.lbl_Title.Location = new System.Drawing.Point(5, 2);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(0, 19);
			this.lbl_Title.TabIndex = 0;
			// 
			// body
			// 
			this.body.Controls.Add(this.txtbox_content2);
			this.body.Controls.Add(this.btn_cancelar);
			this.body.Controls.Add(this.btn_aceptar);
			this.body.Dock = System.Windows.Forms.DockStyle.Fill;
			this.body.Location = new System.Drawing.Point(0, 20);
			this.body.Name = "body";
			this.body.Size = new System.Drawing.Size(250, 105);
			this.body.TabIndex = 1;
			// 
			// txtbox_content2
			// 
			this.txtbox_content2.BackColor = System.Drawing.Color.Transparent;
			this.txtbox_content2.FocusOnHover = false;
			this.txtbox_content2.Location = new System.Drawing.Point(0, 20);
			this.txtbox_content2.MaxLength = 32000;
			this.txtbox_content2.Multiline = false;
			this.txtbox_content2.Name = "txtbox_content2";
			this.txtbox_content2.ReadOnly = false;
			this.txtbox_content2.Size = new System.Drawing.Size(250, 29);
			this.txtbox_content2.TabIndex = 4;
			this.txtbox_content2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.txtbox_content2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtbox_content2.UseSystemPasswordChar = true;
			// 
			// btn_cancelar
			// 
			this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
			this.btn_cancelar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btn_cancelar.Location = new System.Drawing.Point(155, 70);
			this.btn_cancelar.Name = "btn_cancelar";
			this.btn_cancelar.Rounded = true;
			this.btn_cancelar.Size = new System.Drawing.Size(85, 21);
			this.btn_cancelar.TabIndex = 2;
			this.btn_cancelar.Text = "Cancelar";
			this.btn_cancelar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
			// 
			// btn_aceptar
			// 
			this.btn_aceptar.BackColor = System.Drawing.Color.Transparent;
			this.btn_aceptar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
			this.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btn_aceptar.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btn_aceptar.Location = new System.Drawing.Point(12, 70);
			this.btn_aceptar.Name = "btn_aceptar";
			this.btn_aceptar.Rounded = true;
			this.btn_aceptar.Size = new System.Drawing.Size(84, 21);
			this.btn_aceptar.TabIndex = 1;
			this.btn_aceptar.Text = "Aceptar";
			this.btn_aceptar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
			// 
			// CustomMessageBox
			// 
			this.AcceptButton = this.btn_aceptar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
			this.CancelButton = this.btn_cancelar;
			this.ClientSize = new System.Drawing.Size(250, 125);
			this.Controls.Add(this.body);
			this.Controls.Add(this.header);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CustomMessageBox";
			this.Text = "CustomMessageBox";
			this.header.ResumeLayout(false);
			this.header.PerformLayout();
			this.body.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel header;
		private System.Windows.Forms.Panel body;
		private FlatUI.FlatLabel lbl_Title;
		private FlatUI.FlatButton btn_cancelar;
		private FlatUI.FlatButton btn_aceptar;
		private FlatUI.FlatClose btn_close;
		public FlatUI.FlatTextBox txtbox_content2;
	}
}