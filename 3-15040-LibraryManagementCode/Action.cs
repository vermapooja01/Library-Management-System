using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Library_Management
{
	/// <summary>
	/// Summary description for Actions.
	/// This form is used to select an action that needs to be performed by user 
	/// </summary>
	public class Actions : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox grpActions;
		private System.Windows.Forms.RadioButton rdoSearchBooks;
		private System.Windows.Forms.RadioButton rdoReturn;
		private System.Windows.Forms.RadioButton rdoCategory;
		private System.Windows.Forms.RadioButton rdoAddBooks;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.RadioButton rdoChgPwd;
		private System.Windows.Forms.Label lblWelcome;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Actions()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Actions));
			this.grpActions = new System.Windows.Forms.GroupBox();
			this.rdoChgPwd = new System.Windows.Forms.RadioButton();
			this.rdoAddBooks = new System.Windows.Forms.RadioButton();
			this.rdoCategory = new System.Windows.Forms.RadioButton();
			this.rdoReturn = new System.Windows.Forms.RadioButton();
			this.rdoSearchBooks = new System.Windows.Forms.RadioButton();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblWelcome = new System.Windows.Forms.Label();
			this.grpActions.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpActions
			// 
			this.grpActions.Controls.Add(this.rdoChgPwd);
			this.grpActions.Controls.Add(this.rdoAddBooks);
			this.grpActions.Controls.Add(this.rdoCategory);
			this.grpActions.Controls.Add(this.rdoReturn);
			this.grpActions.Controls.Add(this.rdoSearchBooks);
			this.grpActions.Location = new System.Drawing.Point(16, 40);
			this.grpActions.Name = "grpActions";
			this.grpActions.Size = new System.Drawing.Size(312, 273);
			this.grpActions.TabIndex = 0;
			this.grpActions.TabStop = false;
			this.grpActions.Text = "Actions";
			// 
			// rdoChgPwd
			// 
			this.rdoChgPwd.Location = new System.Drawing.Point(32, 224);
			this.rdoChgPwd.Name = "rdoChgPwd";
			this.rdoChgPwd.Size = new System.Drawing.Size(256, 24);
			this.rdoChgPwd.TabIndex = 4;
			this.rdoChgPwd.Text = "Change Password";
			// 
			// rdoAddBooks
			// 
			this.rdoAddBooks.Location = new System.Drawing.Point(32, 176);
			this.rdoAddBooks.Name = "rdoAddBooks";
			this.rdoAddBooks.Size = new System.Drawing.Size(256, 24);
			this.rdoAddBooks.TabIndex = 3;
			this.rdoAddBooks.Text = "Add/Remove Books";
			// 
			// rdoCategory
			// 
			this.rdoCategory.Location = new System.Drawing.Point(32, 128);
			this.rdoCategory.Name = "rdoCategory";
			this.rdoCategory.Size = new System.Drawing.Size(256, 24);
			this.rdoCategory.TabIndex = 2;
			this.rdoCategory.Text = "Manage Categories";
			// 
			// rdoReturn
			// 
			this.rdoReturn.Location = new System.Drawing.Point(32, 80);
			this.rdoReturn.Name = "rdoReturn";
			this.rdoReturn.Size = new System.Drawing.Size(256, 24);
			this.rdoReturn.TabIndex = 1;
			this.rdoReturn.Text = "Return Books";
			// 
			// rdoSearchBooks
			// 
			this.rdoSearchBooks.Checked = true;
			this.rdoSearchBooks.Location = new System.Drawing.Point(32, 32);
			this.rdoSearchBooks.Name = "rdoSearchBooks";
			this.rdoSearchBooks.Size = new System.Drawing.Size(256, 24);
			this.rdoSearchBooks.TabIndex = 0;
			this.rdoSearchBooks.TabStop = true;
			this.rdoSearchBooks.Text = "Search/Issue Books";
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(41, 328);
			this.btnOk.Name = "btnOk";
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "&Ok";
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(229, 328);
			this.btnExit.Name = "btnExit";
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "E&xit";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(135, 328);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// lblWelcome
			// 
			this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblWelcome.Location = new System.Drawing.Point(16, 16);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Size = new System.Drawing.Size(312, 23);
			this.lblWelcome.TabIndex = 7;
			// 
			// Actions
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(344, 359);
			this.Controls.Add(this.lblWelcome);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.grpActions);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Actions";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Actions";
			this.Load += new System.EventHandler(this.Actions_Load);
			this.grpActions.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
			this.Dispose();
			Application.Exit();
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			Globals.UserName = "";
			Globals.Password = "";
			this.Close();
			this.Dispose();
			MainForm frmLogin = new MainForm();
			frmLogin.ShowDialog();
		}

		private void btnOk_Click(object sender, System.EventArgs e)
		{
			this.Close();
			this.Dispose();
			if(rdoSearchBooks.Checked)
			{
				SearchBooks srch = new SearchBooks();
				srch.ShowDialog();
			}
			if(rdoReturn.Checked)
			{
				ReturnBook ret = new ReturnBook();
				ret.ShowDialog();
			}
			if(rdoAddBooks.Checked)
			{
				AddBooks add = new AddBooks();
				add.ShowDialog();
			}
			if(rdoCategory.Checked)
			{
				Category cat = new Category();
				cat.ShowDialog();
				
			}
			if(rdoChgPwd.Checked)
			{
				ChangePassword pwd = new ChangePassword();
				pwd.ShowDialog();
				
			}
		}

		private void Actions_Load(object sender, System.EventArgs e)
		{
			lblWelcome.Text = "Welcome " + Globals.UserName;
			// If user is administrator all actions are available
			if(Globals.isSystemUser)
			{
				rdoAddBooks.Enabled = true;
				rdoCategory.Enabled = true;
			}
			// If user is not administrator all Add books / remove books / 
			// /manage categories are not available
			else
			{
				rdoAddBooks.Enabled = false;
				rdoCategory.Enabled = false;
			}
		}
			
	}
}
