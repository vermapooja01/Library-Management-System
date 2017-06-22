using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Library_Management
{
	/// <summary>
	/// Summary description for RegisterUser.
	/// </summary>
	public class RegisterUser : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.TextBox txtpwd;
		private System.Windows.Forms.TextBox txtuser;
		private System.Windows.Forms.Label lblpwd;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.TextBox txtConfirm;
		private System.Windows.Forms.Label lblConfirm;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public RegisterUser()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(RegisterUser));
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnRegister = new System.Windows.Forms.Button();
			this.txtpwd = new System.Windows.Forms.TextBox();
			this.txtuser = new System.Windows.Forms.TextBox();
			this.lblpwd = new System.Windows.Forms.Label();
			this.lblUser = new System.Windows.Forms.Label();
			this.txtConfirm = new System.Windows.Forms.TextBox();
			this.lblConfirm = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(229, 222);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "C&ancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(134, 222);
			this.btnClear.Name = "btnClear";
			this.btnClear.TabIndex = 7;
			this.btnClear.Text = "&Clear";
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnRegister
			// 
			this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnRegister.Location = new System.Drawing.Point(39, 222);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.TabIndex = 6;
			this.btnRegister.Text = "&Register";
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// txtpwd
			// 
			this.txtpwd.Location = new System.Drawing.Point(183, 126);
			this.txtpwd.Name = "txtpwd";
			this.txtpwd.PasswordChar = '*';
			this.txtpwd.TabIndex = 3;
			this.txtpwd.Text = "";
			// 
			// txtuser
			// 
			this.txtuser.Location = new System.Drawing.Point(183, 77);
			this.txtuser.Name = "txtuser";
			this.txtuser.TabIndex = 1;
			this.txtuser.Text = "";
			// 
			// lblpwd
			// 
			this.lblpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblpwd.Location = new System.Drawing.Point(60, 126);
			this.lblpwd.Name = "lblpwd";
			this.lblpwd.TabIndex = 2;
			this.lblpwd.Text = "Password";
			// 
			// lblUser
			// 
			this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblUser.Location = new System.Drawing.Point(60, 77);
			this.lblUser.Name = "lblUser";
			this.lblUser.TabIndex = 0;
			this.lblUser.Text = "User Name";
			// 
			// txtConfirm
			// 
			this.txtConfirm.Location = new System.Drawing.Point(183, 175);
			this.txtConfirm.Name = "txtConfirm";
			this.txtConfirm.PasswordChar = '*';
			this.txtConfirm.TabIndex = 5;
			this.txtConfirm.Text = "";
			// 
			// lblConfirm
			// 
			this.lblConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblConfirm.Location = new System.Drawing.Point(60, 175);
			this.lblConfirm.Name = "lblConfirm";
			this.lblConfirm.TabIndex = 4;
			this.lblConfirm.Text = "Confirm Password";
			// 
			// RegisterUser
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(342, 323);
			this.Controls.Add(this.txtConfirm);
			this.Controls.Add(this.txtpwd);
			this.Controls.Add(this.txtuser);
			this.Controls.Add(this.lblConfirm);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.lblpwd);
			this.Controls.Add(this.lblUser);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "RegisterUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Register User";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
			this.Dispose();
			MainForm frmLogin = new MainForm();
			frmLogin.ShowDialog();
		}

		private void btnClear_Click(object sender, System.EventArgs e)
		{
			txtuser.Text = "";
			txtpwd.Text = "";
			txtConfirm.Text = "";
		}

		private void btnRegister_Click(object sender, System.EventArgs e)
		{
			if(txtuser.Text.Equals(""))
			{
				MessageBox.Show("Please Enter User Name","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			if(txtpwd.Text.Equals(""))
			{
				MessageBox.Show("Please Enter Password","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			if(txtConfirm.Text.Equals(""))
			{
				MessageBox.Show("Please Confirm Password","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			if(!txtConfirm.Text.Equals(txtpwd.Text))
			{
				MessageBox.Show("Password not confirmed","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			bool IsSuccesfulRegister = false;
			try
			{
				IsSuccesfulRegister = Globals.RegisterUser(txtuser.Text,txtpwd.Text);;
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Library Management",MessageBoxButtons.OK,MessageBoxIcon.Error);
				this.Close();
				this.Dispose();
				Application.Exit();
				return;
			}
			if(!IsSuccesfulRegister)
			{
				MessageBox.Show("This user already exists. Please enter some other user name","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				txtuser.Text = "";
				txtpwd.Text = "";
				txtConfirm.Text = "";
				txtuser.Focus();
				return;
			}
			else
			{
				MessageBox.Show("User succesfully registered.","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				Globals.UsersList.Add(txtuser.Text,0);
				Globals.UserName = txtuser.Text;
				Globals.Password = txtpwd.Text;
				Globals.isSystemUser = false;
				this.Close();
				this.Dispose();
				Actions act = new Actions();
				act.ShowDialog();
				
			}
			
		}

		

		
	}
}
