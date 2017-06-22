using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Library_Management
{
	/// <summary>
	/// Summary description for ChangePassword.
	/// </summary>
	public class ChangePassword : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblOld;
		private System.Windows.Forms.Label lblConfirm;
		private System.Windows.Forms.Label lblNew;
		private System.Windows.Forms.TextBox txtOld;
		private System.Windows.Forms.TextBox txtNew;
		private System.Windows.Forms.TextBox txtConfirm;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ChangePassword()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ChangePassword));
			this.lblOld = new System.Windows.Forms.Label();
			this.lblConfirm = new System.Windows.Forms.Label();
			this.lblNew = new System.Windows.Forms.Label();
			this.txtOld = new System.Windows.Forms.TextBox();
			this.txtNew = new System.Windows.Forms.TextBox();
			this.txtConfirm = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblOld
			// 
			this.lblOld.Location = new System.Drawing.Point(20, 45);
			this.lblOld.Name = "lblOld";
			this.lblOld.TabIndex = 0;
			this.lblOld.Text = "Old Password";
			// 
			// lblConfirm
			// 
			this.lblConfirm.Location = new System.Drawing.Point(20, 133);
			this.lblConfirm.Name = "lblConfirm";
			this.lblConfirm.Size = new System.Drawing.Size(136, 23);
			this.lblConfirm.TabIndex = 4;
			this.lblConfirm.Text = "Confirm New Password";
			// 
			// lblNew
			// 
			this.lblNew.Location = new System.Drawing.Point(20, 89);
			this.lblNew.Name = "lblNew";
			this.lblNew.TabIndex = 2;
			this.lblNew.Text = "New Password";
			// 
			// txtOld
			// 
			this.txtOld.Location = new System.Drawing.Point(173, 45);
			this.txtOld.MaxLength = 8;
			this.txtOld.Name = "txtOld";
			this.txtOld.PasswordChar = '*';
			this.txtOld.TabIndex = 1;
			this.txtOld.Text = "";
			// 
			// txtNew
			// 
			this.txtNew.Location = new System.Drawing.Point(172, 85);
			this.txtNew.MaxLength = 8;
			this.txtNew.Name = "txtNew";
			this.txtNew.PasswordChar = '*';
			this.txtNew.TabIndex = 3;
			this.txtNew.Text = "";
			// 
			// txtConfirm
			// 
			this.txtConfirm.Location = new System.Drawing.Point(172, 125);
			this.txtConfirm.MaxLength = 8;
			this.txtConfirm.Name = "txtConfirm";
			this.txtConfirm.PasswordChar = '*';
			this.txtConfirm.TabIndex = 5;
			this.txtConfirm.Text = "";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(65, 205);
			this.btnSave.Name = "btnSave";
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "&Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(153, 205);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// ChangePassword
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtConfirm);
			this.Controls.Add(this.txtNew);
			this.Controls.Add(this.txtOld);
			this.Controls.Add(this.lblNew);
			this.Controls.Add(this.lblConfirm);
			this.Controls.Add(this.lblOld);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ChangePassword";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Change Password";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
			this.Dispose();
			Actions act = new Actions();
			act.ShowDialog();
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if(txtOld.Text.Equals("") || txtNew.Text.Equals("") || txtConfirm.Text.Equals(""))
			{
				MessageBox.Show("All required data is not entered by you.","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			if(txtOld.Text != Globals.Password)
			{
				MessageBox.Show("Old password entered is not correct","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			if(txtNew.Text != txtConfirm.Text)
			{
				MessageBox.Show("Password confirmation is not correct","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			bool isSuccess = false;
			try
			{
				isSuccess = Globals.ChangePassword(Globals.UserName,txtNew.Text);

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Library Management",MessageBoxButtons.OK,MessageBoxIcon.Error);
				this.Close();
				this.Dispose();
				Application.Exit();
				return;

			}
			if(isSuccess)
			{
				Globals.Password = txtNew.Text;
				MessageBox.Show("Password Changed","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				this.Close();
				this.Dispose();
				Actions act = new Actions();
				act.ShowDialog();
			}
		}

	}
}
