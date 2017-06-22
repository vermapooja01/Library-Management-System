using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Library_Management
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.Label lblpwd;
		private System.Windows.Forms.TextBox txtuser;
		private System.Windows.Forms.TextBox txtpwd;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			this.Load+=new EventHandler(MainForm_Load);

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
				if (components != null) 
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
			this.lblUser = new System.Windows.Forms.Label();
			this.lblpwd = new System.Windows.Forms.Label();
			this.txtuser = new System.Windows.Forms.TextBox();
			this.txtpwd = new System.Windows.Forms.TextBox();
			this.btnRegister = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblUser
			// 
			this.lblUser.BackColor = System.Drawing.SystemColors.Control;
			this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblUser.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblUser.Location = new System.Drawing.Point(61, 106);
			this.lblUser.Name = "lblUser";
			this.lblUser.TabIndex = 0;
			this.lblUser.Text = "User Name";
			// 
			// lblpwd
			// 
			this.lblpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblpwd.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblpwd.Location = new System.Drawing.Point(61, 154);
			this.lblpwd.Name = "lblpwd";
			this.lblpwd.TabIndex = 2;
			this.lblpwd.Text = "Password";
			// 
			// txtuser
			// 
			this.txtuser.Location = new System.Drawing.Point(184, 106);
			this.txtuser.MaxLength = 20;
			this.txtuser.Name = "txtuser";
			this.txtuser.TabIndex = 1;
			this.txtuser.Text = "";
			// 
			// txtpwd
			// 
			this.txtpwd.Location = new System.Drawing.Point(184, 154);
			this.txtpwd.MaxLength = 8;
			this.txtpwd.Name = "txtpwd";
			this.txtpwd.PasswordChar = '*';
			this.txtpwd.TabIndex = 3;
			this.txtpwd.Text = "";
			// 
			// btnRegister
			// 
			this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnRegister.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnRegister.Location = new System.Drawing.Point(40, 226);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.TabIndex = 4;
			this.btnRegister.Text = "&Register";
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnLogin.Location = new System.Drawing.Point(135, 226);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "&Login";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnExit.Location = new System.Drawing.Point(230, 226);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 6;
			this.btnExit.Text = "E&xit";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(72, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "Library Management System";
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(344, 295);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.txtpwd);
			this.Controls.Add(this.txtuser);
			this.Controls.Add(this.lblpwd);
			this.Controls.Add(this.lblUser);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			MainForm frmLogin = new MainForm();
			frmLogin.ShowDialog();
		}

		private void btnLogin_Click(object sender, System.EventArgs e)
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
			bool IsSuccesfulLogin = false;
			try
			{
				// Validates User 
				IsSuccesfulLogin = Globals.ValidateId(txtuser.Text,txtpwd.Text);
								
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Library Management",MessageBoxButtons.OK,MessageBoxIcon.Error);
				this.Close();
				this.Dispose();
				Application.Exit();
				return;
			}
			if(!IsSuccesfulLogin)
			{
				MessageBox.Show("Please Enter Valid User Name/Password Combination","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				txtpwd.Text = "";
				txtuser.Text = "";
				txtuser.Focus();
				return;
			}
			else
			{
				Globals.UserName = txtuser.Text; 
				Globals.Password = txtpwd.Text;
				// Launch Action Form
				this.Close();
				this.Dispose();
				Actions act = new Actions();
				act.ShowDialog();
			}
			
		}
		private void btnRegister_Click(object sender, System.EventArgs e)
		{
			RegisterUser regUser = new RegisterUser();
			this.Close();
			this.Dispose();
			regUser.ShowDialog();
		}
		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
			this.Dispose();
			Application.Exit();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			try
			{
				// Populates Users, Categories, Books present in system
				if(!Globals.PopulateAppData())
				{
					MessageBox.Show("DB Config File Missing","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Error);
					this.Close();
					this.Dispose();
					Application.Exit();
					return;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Library Management",MessageBoxButtons.OK,MessageBoxIcon.Error);
				this.Close();
				this.Dispose();
				Application.Exit();
				return;
			}
		}
	}
}
