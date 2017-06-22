using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Library_Management
{
	/// <summary>
	/// Summary description for AddBooks.
	/// </summary>
	public class AddBooks : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblAuthor;
		private System.Windows.Forms.Label lblcat;
		private System.Windows.Forms.Label lblQty;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.TextBox txtAuthor;
		private System.Windows.Forms.TextBox txtQty;
		private System.Windows.Forms.ComboBox cmbCat;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnAction;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.GroupBox grpAdd;
		private System.Windows.Forms.GroupBox grpRemove;
		private System.Windows.Forms.Label lblRemBook;
		private System.Windows.Forms.ComboBox cmbRemoveBook;
		private System.Windows.Forms.Label lblAvlQty;
		private System.Windows.Forms.TextBox txtAvailQty;
		private System.Windows.Forms.TextBox txtRemQty;
		private System.Windows.Forms.Label lblRemQty;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.TextBox txtViewAuthor;
		private System.Windows.Forms.Label lblViewAuthor;
		private System.Windows.Forms.TextBox txtViewCat;
		private System.Windows.Forms.Label lblViewCat;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private Hashtable _BookList = new Hashtable();

		public AddBooks()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AddBooks));
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblAuthor = new System.Windows.Forms.Label();
			this.lblcat = new System.Windows.Forms.Label();
			this.lblQty = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtAuthor = new System.Windows.Forms.TextBox();
			this.txtQty = new System.Windows.Forms.TextBox();
			this.cmbCat = new System.Windows.Forms.ComboBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnAction = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.grpAdd = new System.Windows.Forms.GroupBox();
			this.grpRemove = new System.Windows.Forms.GroupBox();
			this.txtViewCat = new System.Windows.Forms.TextBox();
			this.lblViewCat = new System.Windows.Forms.Label();
			this.txtViewAuthor = new System.Windows.Forms.TextBox();
			this.lblViewAuthor = new System.Windows.Forms.Label();
			this.txtRemQty = new System.Windows.Forms.TextBox();
			this.lblRemQty = new System.Windows.Forms.Label();
			this.txtAvailQty = new System.Windows.Forms.TextBox();
			this.lblAvlQty = new System.Windows.Forms.Label();
			this.cmbRemoveBook = new System.Windows.Forms.ComboBox();
			this.lblRemBook = new System.Windows.Forms.Label();
			this.btnRemove = new System.Windows.Forms.Button();
			this.grpAdd.SuspendLayout();
			this.grpRemove.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(24, 21);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(112, 24);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Book Title";
			// 
			// lblAuthor
			// 
			this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblAuthor.Location = new System.Drawing.Point(24, 61);
			this.lblAuthor.Name = "lblAuthor";
			this.lblAuthor.Size = new System.Drawing.Size(112, 24);
			this.lblAuthor.TabIndex = 2;
			this.lblAuthor.Text = "Author Name";
			// 
			// lblcat
			// 
			this.lblcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblcat.Location = new System.Drawing.Point(24, 101);
			this.lblcat.Name = "lblcat";
			this.lblcat.Size = new System.Drawing.Size(112, 24);
			this.lblcat.TabIndex = 4;
			this.lblcat.Text = "Category";
			// 
			// lblQty
			// 
			this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblQty.Location = new System.Drawing.Point(24, 141);
			this.lblQty.Name = "lblQty";
			this.lblQty.Size = new System.Drawing.Size(112, 24);
			this.lblQty.TabIndex = 6;
			this.lblQty.Text = "Quantity";
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(160, 21);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(176, 20);
			this.txtTitle.TabIndex = 1;
			this.txtTitle.Text = "";
			// 
			// txtAuthor
			// 
			this.txtAuthor.Location = new System.Drawing.Point(160, 61);
			this.txtAuthor.Name = "txtAuthor";
			this.txtAuthor.Size = new System.Drawing.Size(176, 20);
			this.txtAuthor.TabIndex = 3;
			this.txtAuthor.Text = "";
			// 
			// txtQty
			// 
			this.txtQty.Location = new System.Drawing.Point(160, 141);
			this.txtQty.Name = "txtQty";
			this.txtQty.Size = new System.Drawing.Size(176, 20);
			this.txtQty.TabIndex = 7;
			this.txtQty.Text = "";
			// 
			// cmbCat
			// 
			this.cmbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCat.Location = new System.Drawing.Point(160, 101);
			this.cmbCat.Name = "cmbCat";
			this.cmbCat.Size = new System.Drawing.Size(176, 21);
			this.cmbCat.TabIndex = 5;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(224, 528);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(72, 24);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "E&xit";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnAction
			// 
			this.btnAction.Location = new System.Drawing.Point(136, 528);
			this.btnAction.Name = "btnAction";
			this.btnAction.Size = new System.Drawing.Size(72, 24);
			this.btnAction.TabIndex = 4;
			this.btnAction.Text = "A&ctions";
			this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(296, 195);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(72, 24);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "&Add";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// grpAdd
			// 
			this.grpAdd.Controls.Add(this.txtTitle);
			this.grpAdd.Controls.Add(this.txtQty);
			this.grpAdd.Controls.Add(this.txtAuthor);
			this.grpAdd.Controls.Add(this.lblQty);
			this.grpAdd.Controls.Add(this.cmbCat);
			this.grpAdd.Controls.Add(this.lblTitle);
			this.grpAdd.Controls.Add(this.lblAuthor);
			this.grpAdd.Controls.Add(this.lblcat);
			this.grpAdd.Location = new System.Drawing.Point(15, 14);
			this.grpAdd.Name = "grpAdd";
			this.grpAdd.Size = new System.Drawing.Size(352, 170);
			this.grpAdd.TabIndex = 0;
			this.grpAdd.TabStop = false;
			this.grpAdd.Text = "Add Books";
			// 
			// grpRemove
			// 
			this.grpRemove.Controls.Add(this.txtViewCat);
			this.grpRemove.Controls.Add(this.lblViewCat);
			this.grpRemove.Controls.Add(this.txtViewAuthor);
			this.grpRemove.Controls.Add(this.lblViewAuthor);
			this.grpRemove.Controls.Add(this.txtRemQty);
			this.grpRemove.Controls.Add(this.lblRemQty);
			this.grpRemove.Controls.Add(this.txtAvailQty);
			this.grpRemove.Controls.Add(this.lblAvlQty);
			this.grpRemove.Controls.Add(this.cmbRemoveBook);
			this.grpRemove.Controls.Add(this.lblRemBook);
			this.grpRemove.Location = new System.Drawing.Point(15, 227);
			this.grpRemove.Name = "grpRemove";
			this.grpRemove.Size = new System.Drawing.Size(352, 245);
			this.grpRemove.TabIndex = 2;
			this.grpRemove.TabStop = false;
			this.grpRemove.Text = "Remove Books";
			// 
			// txtViewCat
			// 
			this.txtViewCat.Location = new System.Drawing.Point(159, 72);
			this.txtViewCat.Name = "txtViewCat";
			this.txtViewCat.ReadOnly = true;
			this.txtViewCat.Size = new System.Drawing.Size(176, 20);
			this.txtViewCat.TabIndex = 3;
			this.txtViewCat.Text = "";
			// 
			// lblViewCat
			// 
			this.lblViewCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblViewCat.Location = new System.Drawing.Point(17, 72);
			this.lblViewCat.Name = "lblViewCat";
			this.lblViewCat.Size = new System.Drawing.Size(112, 32);
			this.lblViewCat.TabIndex = 2;
			this.lblViewCat.Text = "Category";
			// 
			// txtViewAuthor
			// 
			this.txtViewAuthor.Location = new System.Drawing.Point(160, 116);
			this.txtViewAuthor.Name = "txtViewAuthor";
			this.txtViewAuthor.ReadOnly = true;
			this.txtViewAuthor.Size = new System.Drawing.Size(176, 20);
			this.txtViewAuthor.TabIndex = 5;
			this.txtViewAuthor.Text = "";
			// 
			// lblViewAuthor
			// 
			this.lblViewAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblViewAuthor.Location = new System.Drawing.Point(18, 116);
			this.lblViewAuthor.Name = "lblViewAuthor";
			this.lblViewAuthor.Size = new System.Drawing.Size(112, 32);
			this.lblViewAuthor.TabIndex = 4;
			this.lblViewAuthor.Text = "Author Name";
			// 
			// txtRemQty
			// 
			this.txtRemQty.Location = new System.Drawing.Point(160, 195);
			this.txtRemQty.Name = "txtRemQty";
			this.txtRemQty.Size = new System.Drawing.Size(176, 20);
			this.txtRemQty.TabIndex = 9;
			this.txtRemQty.Text = "";
			// 
			// lblRemQty
			// 
			this.lblRemQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblRemQty.Location = new System.Drawing.Point(20, 195);
			this.lblRemQty.Name = "lblRemQty";
			this.lblRemQty.Size = new System.Drawing.Size(112, 40);
			this.lblRemQty.TabIndex = 8;
			this.lblRemQty.Text = "Quantity To Be Removed Of Book Selected ";
			// 
			// txtAvailQty
			// 
			this.txtAvailQty.Location = new System.Drawing.Point(160, 155);
			this.txtAvailQty.Name = "txtAvailQty";
			this.txtAvailQty.ReadOnly = true;
			this.txtAvailQty.Size = new System.Drawing.Size(176, 20);
			this.txtAvailQty.TabIndex = 7;
			this.txtAvailQty.Text = "";
			// 
			// lblAvlQty
			// 
			this.lblAvlQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblAvlQty.Location = new System.Drawing.Point(20, 155);
			this.lblAvlQty.Name = "lblAvlQty";
			this.lblAvlQty.Size = new System.Drawing.Size(112, 32);
			this.lblAvlQty.TabIndex = 6;
			this.lblAvlQty.Text = "Quantity Available Of Book Selected ";
			// 
			// cmbRemoveBook
			// 
			this.cmbRemoveBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRemoveBook.Location = new System.Drawing.Point(160, 32);
			this.cmbRemoveBook.Name = "cmbRemoveBook";
			this.cmbRemoveBook.Size = new System.Drawing.Size(176, 21);
			this.cmbRemoveBook.TabIndex = 1;
			this.cmbRemoveBook.SelectedIndexChanged += new System.EventHandler(this.cmbRemoveBook_SelectedIndexChanged);
			// 
			// lblRemBook
			// 
			this.lblRemBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblRemBook.Location = new System.Drawing.Point(20, 32);
			this.lblRemBook.Name = "lblRemBook";
			this.lblRemBook.Size = new System.Drawing.Size(112, 21);
			this.lblRemBook.TabIndex = 0;
			this.lblRemBook.Text = "Book Title";
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(296, 481);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(72, 24);
			this.btnRemove.TabIndex = 3;
			this.btnRemove.Text = "&Remove";
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// AddBooks
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(386, 567);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.grpRemove);
			this.Controls.Add(this.grpAdd);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnAction);
			this.Controls.Add(this.btnAdd);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "AddBooks";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add/Remove Books";
			this.Load += new System.EventHandler(this.AddBooks_Load);
			this.grpAdd.ResumeLayout(false);
			this.grpRemove.ResumeLayout(false);
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

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			if(txtTitle.Text.Equals(""))
			{
				MessageBox.Show("Please Enter Book Title","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			if(txtAuthor.Text.Equals(""))
			{
				MessageBox.Show("Please Enter Author Name","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			if(txtQty.Text.Equals(""))
			{
				MessageBox.Show("Please Enter Quantity of books in numeric format","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			else
			{
				bool isNumber = isNumeric(txtQty.Text, System.Globalization.NumberStyles.Integer);
				if(!isNumber)
				{
					MessageBox.Show("Please Enter Quantity of books in numeric format","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
					return;
				}
			}
			bool IsSuccesfulAdd = false;
			bool isNewEntry = true;
			try
			{
				int iCatId = 0;
				if(Globals.CategoryList!=null && Globals.CategoryList.Count > 0)
				{					
					IDictionaryEnumerator myEnumerator = Globals.CategoryList.GetEnumerator();
					while ( myEnumerator.MoveNext() )
					{
						if(cmbCat.SelectedItem.Equals(myEnumerator.Value))
						{
							iCatId = Convert.ToInt32(myEnumerator.Key);
							break;
						}
					}
				}
				else
				{
					MessageBox.Show("Please add a category first","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
					return;
				}
				
				IsSuccesfulAdd = Globals.AddBook(txtTitle.Text,txtAuthor.Text,iCatId,Convert.ToInt32(txtQty.Text),ref isNewEntry);
				
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Library Management",MessageBoxButtons.OK,MessageBoxIcon.Error);
				this.Close();
				this.Dispose();
				Application.Exit();
				return;
			}
			if(!IsSuccesfulAdd)
			{
				MessageBox.Show("Please check the book data entered","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			else
			{
				MessageBox.Show("Book(s) succesfully added.","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				// Launch Action Form
				if(Globals.BookList.ContainsKey(txtTitle.Text + "~" + txtAuthor.Text + "#" + cmbCat.SelectedItem.ToString()))
					Globals.BookList[txtTitle.Text + "~" + txtAuthor.Text + "#" + cmbCat.SelectedItem.ToString()] = Convert.ToInt32(Globals.BookList[txtTitle.Text + "~" + txtAuthor.Text + "#" + cmbCat.SelectedItem.ToString()]) + Convert.ToInt32(txtQty.Text);
				else
				{
					Globals.BookList.Add(txtTitle.Text + "~" + txtAuthor.Text + "#" + cmbCat.SelectedItem.ToString(),txtQty.Text);
				}
				
				this.Close();
				this.Dispose();
				Actions act = new Actions();
				act.ShowDialog();
			}
		
		}
		private bool isNumeric(string val, System.Globalization.NumberStyles NumberStyle)
		{
		  Double result;
		  return Double.TryParse(val,NumberStyle,System.Globalization.CultureInfo.CurrentCulture,out result);
		}
		

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
			this.Dispose();
			Application.Exit();			
		}

		private void btnRemove_Click(object sender, System.EventArgs e)
		{			
			if(cmbRemoveBook.Items.Count == 0)
			{
				MessageBox.Show("No books available to be removed","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			if(txtRemQty.Text.Equals(""))
			{
				MessageBox.Show("Please Enter Quantity of books in numeric format","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			else
			{
				bool isNumber = isNumeric(txtRemQty.Text, System.Globalization.NumberStyles.Integer);
				if(!isNumber)
				{
					MessageBox.Show("Please Enter Quantity of books in numeric format","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
					return;
				}
			}
			if(Convert.ToInt32(txtRemQty.Text) > Convert.ToInt32(txtAvailQty.Text))
			{
				MessageBox.Show("Quantity of books to be removed should be less than available quantity","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			bool IsSucessFulRemove = false;
			try
			{
				IsSucessFulRemove = Globals.RemoveBook(cmbRemoveBook.SelectedItem.ToString(),Convert.ToInt32(txtRemQty.Text),txtViewAuthor.Text,txtViewCat.Text);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Library Management",MessageBoxButtons.OK,MessageBoxIcon.Error);
				this.Close();
				this.Dispose();
				Application.Exit();
				return;
			}
			if(!IsSucessFulRemove)
			{
				MessageBox.Show("Please check the book data entered","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}
			else
			{
				MessageBox.Show("Book(s) succesfully removed.","Library Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
				// Launch Action Form
				int BooksLeft = Convert.ToInt32(txtAvailQty.Text) - Convert.ToInt32(txtRemQty.Text);
				if(BooksLeft == 0)
					Globals.BookList.Remove(cmbRemoveBook.SelectedItem.ToString() + "~" + txtViewAuthor.Text + "#" + txtViewCat.Text);
				else
					Globals.BookList[cmbRemoveBook.SelectedItem.ToString() + "~" + txtViewAuthor.Text + "#" + txtViewCat.Text] = BooksLeft; 

				this.Close();
				this.Dispose();
				Actions act = new Actions();
				act.ShowDialog();
			}
		
		}

		private void AddBooks_Load(object sender, System.EventArgs e)
		{
			if(Globals.CategoryList!=null && Globals.CategoryList.Count > 0)
			{
				IDictionaryEnumerator myEnumerator = Globals.CategoryList.GetEnumerator();
				while ( myEnumerator.MoveNext() )
					cmbCat.Items.Add(myEnumerator.Value);

				cmbCat.SelectedIndex = 0;
			}
			if(Globals.BookList!=null && Globals.BookList.Count > 0)
			{
				IDictionaryEnumerator myEnumerator = Globals.BookList.GetEnumerator();
				int ComboIndex = 0;
				while ( myEnumerator.MoveNext() )
				{
					string Key = myEnumerator.Key.ToString();
					int Bookindex = Key.IndexOf("~");
					
					if(Bookindex!=-1)
					{
						string BookTitle = Key.Substring(0,Bookindex);
						cmbRemoveBook.Items.Add(BookTitle);
						Key = Key.Substring(Bookindex + 1, Key.Length - (Bookindex + 1));
						int Categoryindex = Key.IndexOf("#");
						string AuthorName = Key.Substring(0 , Categoryindex);
						string CategoryName = Key.Substring(Categoryindex + 1, Key.Length - (Categoryindex +1));
						_BookList.Add(ComboIndex,AuthorName + "~" + CategoryName + "#" + myEnumerator.Value.ToString());
						ComboIndex++;
					}
				}
				cmbRemoveBook.SelectedIndex = 0;
			}
		
		}

		private void cmbRemoveBook_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			IDictionaryEnumerator myEnumerator = _BookList.GetEnumerator();
			while( myEnumerator.MoveNext() )
			{	
				if(cmbRemoveBook.SelectedIndex.Equals(myEnumerator.Key))
				{
					string Value = myEnumerator.Value.ToString();
					int Authorindex = Value.IndexOf("~");
					
					if(Authorindex!=-1)
					{
						string AuthorName = Value.Substring(0,Authorindex);
						txtViewAuthor.Text = AuthorName;
						Value = Value.Substring(Authorindex + 1, Value.Length - (Authorindex + 1));
						int Categoryindex = Value.IndexOf("#");
						string CategoryName = Value.Substring(0 , Categoryindex);
						string AvailQty = Value.Substring(Categoryindex + 1, Value.Length - (Categoryindex +1));
						txtViewCat.Text = CategoryName;
						txtAvailQty.Text = AvailQty;
						break;
					}
				}
			}
		}

		
	
	}
}
