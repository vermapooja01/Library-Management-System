using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Library_Management
{
	/// <summary>
	/// Summary description for SearchBooks.
	/// </summary>
	public class SearchBooks : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Label lblBookName;
		private System.Windows.Forms.Label lblCat;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label lblAvailable;
		private System.Windows.Forms.Button btnIssue;
		private System.Windows.Forms.Label lblNote;
		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.TextBox txtBook;
		private System.Windows.Forms.TextBox txtCat;
		private int SelecetedBook = -1; 
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SearchBooks()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			dataGrid1.MouseUp+=new MouseEventHandler(dataGrid1_MouseUp);
			btnIssue.Enabled = false;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SearchBooks));
			this.lblBookName = new System.Windows.Forms.Label();
			this.lblCat = new System.Windows.Forms.Label();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtCat = new System.Windows.Forms.TextBox();
			this.txtBook = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.lblAvailable = new System.Windows.Forms.Label();
			this.btnIssue = new System.Windows.Forms.Button();
			this.lblNote = new System.Windows.Forms.Label();
			this.btnReturn = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblBookName
			// 
			this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblBookName.Location = new System.Drawing.Point(24, 39);
			this.lblBookName.Name = "lblBookName";
			this.lblBookName.TabIndex = 0;
			this.lblBookName.Text = "Book Name";
			// 
			// lblCat
			// 
			this.lblCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblCat.Location = new System.Drawing.Point(24, 85);
			this.lblCat.Name = "lblCat";
			this.lblCat.TabIndex = 2;
			this.lblCat.Text = "Category";
			// 
			// dataGrid1
			// 
			this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(16, 312);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.PreferredColumnWidth = 94;
			this.dataGrid1.Size = new System.Drawing.Size(416, 149);
			this.dataGrid1.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtCat);
			this.groupBox1.Controls.Add(this.txtBook);
			this.groupBox1.Controls.Add(this.lblBookName);
			this.groupBox1.Controls.Add(this.lblCat);
			this.groupBox1.Location = new System.Drawing.Point(16, 72);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(416, 144);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Search Criteria-Enter Atleaset One Criteria";
			// 
			// txtCat
			// 
			this.txtCat.Location = new System.Drawing.Point(216, 85);
			this.txtCat.Name = "txtCat";
			this.txtCat.Size = new System.Drawing.Size(168, 20);
			this.txtCat.TabIndex = 3;
			this.txtCat.Text = "";
			// 
			// txtBook
			// 
			this.txtBook.Location = new System.Drawing.Point(216, 39);
			this.txtBook.Name = "txtBook";
			this.txtBook.Size = new System.Drawing.Size(168, 20);
			this.txtBook.TabIndex = 1;
			this.txtBook.Text = "";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(360, 232);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(72, 24);
			this.btnSearch.TabIndex = 1;
			this.btnSearch.Text = "&Search";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// lblAvailable
			// 
			this.lblAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblAvailable.Location = new System.Drawing.Point(22, 288);
			this.lblAvailable.Name = "lblAvailable";
			this.lblAvailable.Size = new System.Drawing.Size(408, 23);
			this.lblAvailable.TabIndex = 5;
			this.lblAvailable.Text = "Books Available For Issue (Please select 1 book for issue)";
			// 
			// btnIssue
			// 
			this.btnIssue.Location = new System.Drawing.Point(184, 472);
			this.btnIssue.Name = "btnIssue";
			this.btnIssue.Size = new System.Drawing.Size(72, 24);
			this.btnIssue.TabIndex = 3;
			this.btnIssue.Text = "&Issue";
			this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
			// 
			// lblNote
			// 
			this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblNote.Location = new System.Drawing.Point(18, 16);
			this.lblNote.Name = "lblNote";
			this.lblNote.Size = new System.Drawing.Size(408, 40);
			this.lblNote.TabIndex = 7;
			this.lblNote.Text = "Note:If Multiple Selection Criteria Are Entered Result Displayed Will Be Retrieve" +
				"d Using And Condition ";
			this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnReturn
			// 
			this.btnReturn.Location = new System.Drawing.Point(272, 472);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(72, 24);
			this.btnReturn.TabIndex = 4;
			this.btnReturn.Text = "&Actions";
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(360, 472);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(72, 24);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "E&xit";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// SearchBooks
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(444, 519);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.lblNote);
			this.Controls.Add(this.btnIssue);
			this.Controls.Add(this.lblAvailable);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGrid1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "SearchBooks";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Search/Issue Books";
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
			this.Dispose();
			Application.Exit();
		}

		private void btnReturn_Click(object sender, System.EventArgs e)
		{
			this.Close();
			this.Dispose();
			Actions act = new Actions();
			act.ShowDialog();
		}

		private void btnSearch_Click(object sender, System.EventArgs e)
		{
			if(txtBook.Text.Equals("") && txtCat.Text.Equals(""))
			{
				MessageBox.Show("Please enter atleast one of search criteria","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			try
			{
				DataSet ds = Globals.SearchBook(txtBook.Text,txtCat.Text);
				if(ds !=null && ds.Tables[0].Rows.Count > 0)
				{
					DataView dw = new DataView(ds.Tables[0]);
					dw.AllowEdit = false;
					dw.AllowDelete = false;
					dw.AllowNew = false;
					dataGrid1.CaptionText = "Available Books";	
					dataGrid1.DataSource = dw;
					btnIssue.Enabled = true;
					dataGrid1.Select(0);
					SelecetedBook = 0;
				}
				else
				{
					MessageBox.Show("No book found for entered search criteria","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
					btnIssue.Enabled = false;
					dataGrid1.DataSource = null;
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

		private void dataGrid1_MouseUp(object sender, MouseEventArgs e)
		{
			DataGrid.HitTestInfo ht =  dataGrid1.HitTest(e.X,e.Y);
			int row = ht.Row;
			if(row == -1 && SelecetedBook == -1)
			{
				dataGrid1.Select(0);
				SelecetedBook = 0;
			}
			else if(row == -1 && SelecetedBook !=-1)
			{
				dataGrid1.Select(SelecetedBook);
				
			}
			else
			{
				dataGrid1.Select(ht.Row);
				SelecetedBook = ht.Row;
			}
			
		}
		private void btnIssue_Click(object sender, System.EventArgs e)
		{			
			if(Convert.ToInt32(Globals.UsersList[Globals.UserName]) == Globals.NUMBER_OF_BOOKS_ALLOWED)
			{
				MessageBox.Show("You already have 3 books issued. Please return one of them to get requested book issued" ,"Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			DialogResult dr = MessageBox.Show("You have requested for book " + dataGrid1[SelecetedBook,0] + " authored by " + dataGrid1[SelecetedBook,1] + ". Are you sure you want this book?","Library Management",MessageBoxButtons.YesNo);
			if(dr == DialogResult.No)
				return;
			bool IsSuccess = false;
			try
			{
				if(!Globals.ValidateBook(dataGrid1[SelecetedBook,0].ToString(),dataGrid1[SelecetedBook,1].ToString(),dataGrid1[SelecetedBook,3].ToString()))
				{
					MessageBox.Show("Selected book is already issued to you","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
					return;
				}
				IsSuccess = Globals.IssueBook(dataGrid1[SelecetedBook,0].ToString(),dataGrid1[SelecetedBook,1].ToString(),dataGrid1[SelecetedBook,3].ToString());
				
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
				MessageBox.Show("Book Issued Succesfully.","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				Globals.UsersList[Globals.UserName] = Convert.ToInt32(Globals.UsersList[Globals.UserName]) + 1;
				Globals.BookList[dataGrid1[SelecetedBook,0].ToString() + "~" + dataGrid1[SelecetedBook,1].ToString() + "#" + dataGrid1[SelecetedBook,3].ToString()] = 
					Convert.ToInt32(Globals.BookList[dataGrid1[SelecetedBook,0].ToString() + "~" + dataGrid1[SelecetedBook,1].ToString() + "#" + dataGrid1[SelecetedBook,3].ToString()]) - 1; 
				
				this.Close();
				this.Dispose();
				Actions act = new Actions();
				act.ShowDialog();
				
			}
			

		}
	}
}
