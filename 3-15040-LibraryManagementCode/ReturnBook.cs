using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Library_Management
{
	/// <summary>
	/// Summary description for ReturnBook.
	/// </summary>
	public class ReturnBook : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblSelect;
		private System.Windows.Forms.ComboBox cmbreturn;
		private System.Windows.Forms.Button btnreturn;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnAction;
		private System.Windows.Forms.TextBox txtAuthor;
		private System.Windows.Forms.TextBox txtCat;
		private Hashtable IDTable = new Hashtable();
		private Hashtable BookDetail = new Hashtable();
		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ReturnBook()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			this.cmbreturn.SelectedIndexChanged+=new EventHandler(cmbreturn_SelectedIndexChanged);

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ReturnBook));
			this.lblSelect = new System.Windows.Forms.Label();
			this.cmbreturn = new System.Windows.Forms.ComboBox();
			this.btnreturn = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnAction = new System.Windows.Forms.Button();
			this.txtAuthor = new System.Windows.Forms.TextBox();
			this.txtCat = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblSelect
			// 
			this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblSelect.Location = new System.Drawing.Point(16, 24);
			this.lblSelect.Name = "lblSelect";
			this.lblSelect.Size = new System.Drawing.Size(248, 24);
			this.lblSelect.TabIndex = 0;
			this.lblSelect.Text = "Select Book To Be Returned";
			// 
			// cmbreturn
			// 
			this.cmbreturn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbreturn.Location = new System.Drawing.Point(16, 64);
			this.cmbreturn.Name = "cmbreturn";
			this.cmbreturn.Size = new System.Drawing.Size(256, 21);
			this.cmbreturn.TabIndex = 1;
			// 
			// btnreturn
			// 
			this.btnreturn.Location = new System.Drawing.Point(22, 182);
			this.btnreturn.Name = "btnreturn";
			this.btnreturn.Size = new System.Drawing.Size(80, 24);
			this.btnreturn.TabIndex = 4;
			this.btnreturn.Text = "&Return";
			this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(198, 182);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(72, 24);
			this.btnExit.TabIndex = 6;
			this.btnExit.Text = "E&xit";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnAction
			// 
			this.btnAction.Location = new System.Drawing.Point(114, 182);
			this.btnAction.Name = "btnAction";
			this.btnAction.Size = new System.Drawing.Size(72, 24);
			this.btnAction.TabIndex = 5;
			this.btnAction.Text = "&Actions";
			this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
			// 
			// txtAuthor
			// 
			this.txtAuthor.Location = new System.Drawing.Point(16, 104);
			this.txtAuthor.Name = "txtAuthor";
			this.txtAuthor.ReadOnly = true;
			this.txtAuthor.Size = new System.Drawing.Size(176, 20);
			this.txtAuthor.TabIndex = 2;
			this.txtAuthor.Text = "";
			// 
			// txtCat
			// 
			this.txtCat.Location = new System.Drawing.Point(16, 143);
			this.txtCat.Name = "txtCat";
			this.txtCat.ReadOnly = true;
			this.txtCat.Size = new System.Drawing.Size(176, 20);
			this.txtCat.TabIndex = 3;
			this.txtCat.Text = "";
			// 
			// ReturnBook
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 223);
			this.Controls.Add(this.txtCat);
			this.Controls.Add(this.txtAuthor);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnAction);
			this.Controls.Add(this.btnreturn);
			this.Controls.Add(this.cmbreturn);
			this.Controls.Add(this.lblSelect);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ReturnBook";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Return Book";
			this.Load += new System.EventHandler(this.ReturnBook_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
			this.Dispose();
			Application.Exit();
		}

		private void btnAction_Click(object sender, System.EventArgs e)
		{
			this.Close();
			this.Dispose();
			Actions act = new Actions();
			act.ShowDialog();
		}

		private void btnreturn_Click(object sender, System.EventArgs e)
		{
			bool IsSuccess=false;
			try
			{
				string selIndex = cmbreturn.SelectedIndex.ToString();
				string BookIssueId=	"";
				string BookId=	"";
				string SelectedIds= "";
				int Bookindex = -1;
				IDictionaryEnumerator myEnumerator = IDTable.GetEnumerator();
				while(myEnumerator.MoveNext())
				{
					if (selIndex.Equals(myEnumerator.Key.ToString()))
					{
						SelectedIds = myEnumerator.Value.ToString();	
						break;
					}
				}
				Bookindex = SelectedIds.IndexOf("~");
				if(Bookindex!=-1)
				{
					BookId = SelectedIds.Substring(0,Bookindex);
					BookIssueId = SelectedIds.Substring(Bookindex + 1, SelectedIds.Length - (Bookindex + 1));
				}
				IsSuccess = Globals.ReturnBook(Convert.ToInt32(BookId),Convert.ToInt32(BookIssueId));
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Library Management",MessageBoxButtons.OK,MessageBoxIcon.Error);
				this.Close();
				this.Dispose();
				Application.Exit();
				return;
			}
			if(!IsSuccess)
			{
				MessageBox.Show("Some error has occured","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			else
			{
				MessageBox.Show("Book Returned Succesfully.","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				Globals.UsersList[Globals.UserName] = Convert.ToInt32(Globals.UsersList[Globals.UserName]) - 1;
				Globals.BookList[cmbreturn.SelectedItem.ToString() + "~" + txtAuthor.Text + "#" + txtCat.Text] = 
					Convert.ToInt32(Globals.BookList[cmbreturn.SelectedItem.ToString() + "~" + txtAuthor.Text + "#" + txtCat.Text]) + 1; 
				
				this.Close();
				this.Dispose();
				Actions act = new Actions();
				act.ShowDialog();
				
			}
		}

		private void ReturnBook_Load(object sender, System.EventArgs e)
		{
			DataSet ds = Globals.PopulateReturnBooks();
			if(ds !=null && ds.Tables[0].Rows.Count > 0)
			{
				btnreturn.Enabled = true;
				int count = ds.Tables[0].Rows.Count - 1;
				for(int i =0 ;i< ds.Tables[0].Rows.Count;i++)
				{
					BookDetail.Add(i,ds.Tables[0].Rows[i][2].ToString() + "~" + ds.Tables[0].Rows[i][3].ToString() + "#" + ds.Tables[0].Rows[i][4].ToString());
					IDTable.Add(count,ds.Tables[0].Rows[i][0].ToString() + "~" + ds.Tables[0].Rows[i][1].ToString());
					count--;
				}
				
			}
			else
			{
				MessageBox.Show("No book Issued","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				btnreturn.Enabled = false;
				return;
			}
			if(BookDetail!=null && BookDetail.Count > 0)
			{
				IDictionaryEnumerator myEnumerator = BookDetail.GetEnumerator();
				while(myEnumerator.MoveNext())
				{
					string Key = myEnumerator.Value.ToString();
					int Bookindex = Key.IndexOf("~");
					if(Bookindex!=-1)
					{
						string BookTitle = Key.Substring(0,Bookindex);
						cmbreturn.Items.Add(BookTitle);
//						Key = Key.Substring(Bookindex + 1, Key.Length - (Bookindex + 1));
//						int Categoryindex = Key.IndexOf("#");
//						if(myEnumerator.Value.ToString().Equals("0"))
//						{
//							string AuthorName = Key.Substring(0 , Categoryindex);
//							string CategoryName = Key.Substring(Categoryindex + 1, Key.Length - (Categoryindex +1));
//							txtAuthor.Text = AuthorName;
//							txtCat.Text = CategoryName;
//						}
					}
				}
			}
			cmbreturn.SelectedIndex = cmbreturn.Items.Count - 1;
		}

		private void cmbreturn_SelectedIndexChanged(object sender, EventArgs e)
		{
			IDictionaryEnumerator myEnumerator = BookDetail.GetEnumerator();
			while( myEnumerator.MoveNext() )
			{	
//				if(cmbreturn.SelectedIndex.ToString().Equals(myEnumerator.Key.ToString()))
//				{
					string Value = myEnumerator.Value.ToString();
					int Bookindex = Value.IndexOf("~");
					if(Bookindex!=-1)
					{
						string BookTitle = Value.Substring(0,Bookindex);
						if(!BookTitle.Equals(cmbreturn.SelectedItem.ToString()))
							continue;
						Value= Value.Substring(Bookindex + 1, Value.Length - (Bookindex + 1));
						int Categoryindex = Value.IndexOf("#");
						string AuthorName = Value.Substring(0 , Categoryindex);
						string CategoryName = Value.Substring(Categoryindex + 1, Value.Length - (Categoryindex +1));
						txtAuthor.Text = AuthorName;
						txtCat.Text = CategoryName;
					
					}
			//	}
			}
		}
	}
}
