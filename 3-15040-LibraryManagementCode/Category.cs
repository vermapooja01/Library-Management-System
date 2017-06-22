using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Library_Management
{
	/// <summary>
	/// Summary description for Category.
	/// </summary>
	public class Category : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblCat;
		private System.Windows.Forms.TextBox txtCatName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnAction;
		private System.Windows.Forms.Button btnAdd;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Category()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Category));
			this.lblCat = new System.Windows.Forms.Label();
			this.txtCatName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnAction = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblCat
			// 
			this.lblCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblCat.Location = new System.Drawing.Point(13, 16);
			this.lblCat.Name = "lblCat";
			this.lblCat.Size = new System.Drawing.Size(264, 24);
			this.lblCat.TabIndex = 0;
			this.lblCat.Text = "Add New Category";
			// 
			// txtCatName
			// 
			this.txtCatName.Location = new System.Drawing.Point(16, 88);
			this.txtCatName.Name = "txtCatName";
			this.txtCatName.Size = new System.Drawing.Size(264, 20);
			this.txtCatName.TabIndex = 2;
			this.txtCatName.Text = "";
			// 
			// lblName
			// 
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblName.Location = new System.Drawing.Point(14, 48);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(264, 24);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Category Name";
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(186, 128);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(72, 24);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "E&xit";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnAction
			// 
			this.btnAction.Location = new System.Drawing.Point(110, 128);
			this.btnAction.Name = "btnAction";
			this.btnAction.Size = new System.Drawing.Size(72, 24);
			this.btnAction.TabIndex = 4;
			this.btnAction.Text = "A&ctions";
			this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(34, 128);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(72, 24);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "&Add";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// Category
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnAction);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtCatName);
			this.Controls.Add(this.lblCat);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Category";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Category";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnAction_Click(object sender, System.EventArgs e)
		{
			this.Close();
			this.Dispose();
			Actions act = new Actions();
			act.ShowDialog();
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
			this.Dispose();
			Application.Exit();	
		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			if(txtCatName.Text.Equals(""))
			{
				MessageBox.Show("Please Enter a category ","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			bool isSuccesfulAddition = false;
			try
			{
				isSuccesfulAddition = Globals.AddCategory(txtCatName.Text);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Library Management",MessageBoxButtons.OK,MessageBoxIcon.Error);
				this.Close();
				this.Dispose();
				Application.Exit();
				return;
			}
			if(!isSuccesfulAddition)
			{
				MessageBox.Show("This category already exists. Please enter some other category","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			else
			{
				MessageBox.Show("Category succesfully entered.","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				Globals.CategoryList.Add(Globals.CategoryList.Count + 1, txtCatName.Text);
				this.Close();
				this.Dispose();
				Actions act = new Actions();
				act.ShowDialog();
			}
		}
	}
}
