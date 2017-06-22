using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Configuration ;
namespace Library_Management
{
	/// <summary>
	/// Summary description for Globals.
	/// </summary>
	public class Globals
	{
		//public const string CONNECTION_STRING = "initial catalog=Library;data source=(local);Connect Timeout=30;user id=sa;password=''"; 
		public static string ConnectionString = "";		
		public static string UserName = "";		
		public static string Password = "";		
		// Users available in system
		public static Hashtable UsersList = new Hashtable();
		// Categories available in system
		public static Hashtable CategoryList = new Hashtable();
		// Books available in system
		public static Hashtable BookList = new Hashtable();
		public static bool isSystemUser = false;
		public static int NUMBER_OF_BOOKS_ALLOWED = 3;
		public Globals()
		{
			//
			// TODO: Add constructor logic here
			//

		}
		/// <summary>
		/// Get all the application data available in system at system start up
		/// </summary>
		public static bool PopulateAppData()
		{
	
			Globals.ConnectionString = ConfigurationSettings.AppSettings["ConnectionString"].ToString();

			UsersList.Clear();
			CategoryList.Clear();
			BookList.Clear();
			try
			{
				DataSet ds = new DataSet();
				string SQLCommand = "select * from lib_users ";
				SQLCommand += "select * from Lib_Book_Categories ";
				SQLCommand += "select a.lib_book_title,a.lib_book_author_name,b.category_name,count(*) as Qty from lib_book_details a "; 
				SQLCommand += "join lib_book_categories b on b.category_id = a.lib_book_category where a.lib_book_issue_status = 0 and a.lib_book_in_inventory = 1 ";
				SQLCommand += "group by a.lib_book_title,a.lib_book_author_name,b.category_name";
				SqlDataAdapter Adapter = new SqlDataAdapter(SQLCommand,Globals.ConnectionString);
				Adapter.Fill(ds);	
				Adapter.SelectCommand.Connection.Close();	
				if(ds.Tables[0].Rows.Count >0)
				{
					for(int i =0 ; i < ds.Tables[0].Rows.Count; i++)
					{
						UsersList.Add(ds.Tables[0].Rows[i][1].ToString(),ds.Tables[0].Rows[i][5].ToString());
					}
				}
				if(ds.Tables[1].Rows.Count >0)
				{
					for(int i =0 ; i < ds.Tables[1].Rows.Count; i++)
					{
						CategoryList.Add(ds.Tables[1].Rows[i][0].ToString(),ds.Tables[1].Rows[i][1].ToString());
					}
				}
				if(ds.Tables[2].Rows.Count >0)
				{
					for(int i =0 ; i < ds.Tables[2].Rows.Count; i++)
					{
						BookList.Add(ds.Tables[2].Rows[i][0].ToString() + "~" + ds.Tables[2].Rows[i][1].ToString() + "#" + ds.Tables[2].Rows[i][2].ToString(),ds.Tables[2].Rows[i][3].ToString());
					}
				}
				return true;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		/// <summary>
		/// Adding category in system
		/// </summary>
		/// <param name="CategoryName"></param>
		/// <returns></returns>
		public static bool AddCategory(string CategoryName)
		{
			bool IsSuccess = false;
			if(CategoryList.ContainsValue (CategoryName))
			{
				return IsSuccess;
			}
			try
			{
				SqlConnection conn = new SqlConnection(Globals.ConnectionString);
				conn.Open();
				SqlCommand cmd = new SqlCommand("",conn);
				String SQLCommand = "BEGIN TRANSACTION\r\n";
				SQLCommand += "INSERT INTO Lib_Book_Categories (Category_Name) values ('" + CategoryName + "'\r\n)"; 
				SQLCommand += "Commit Transaction";
				cmd.CommandText = SQLCommand;
				int Count = cmd.ExecuteNonQuery();
				if (Count == 1)
				{
					IsSuccess = true;
				}
				conn.Close();
			}
			catch(Exception ex)
			{
				throw ex;
			}
			return IsSuccess;

		}
		/// <summary>
		/// Login validation
		/// </summary>
		/// <param name="UserName"></param>
		/// <param name="Password"></param>
		/// <returns></returns>
		public static bool ValidateId(string UserName,string Password)
		{
			try
			{
				DataSet ds = new DataSet();
				string SQLCommand =  "select user_is_system from lib_users where user_name='" + UserName + "' and user_password ='" + EncryptDecrypt.Encode(Password) + "'";
				SqlDataAdapter Adapter = new SqlDataAdapter(SQLCommand,Globals.ConnectionString);
				Adapter.Fill(ds);	
				Adapter.SelectCommand.Connection.Close();	
				if(ds.Tables[0].Rows.Count >0)
				{
					if(Convert.ToBoolean(ds.Tables[0].Rows[0]["user_is_system"]))
						isSystemUser = true;
					else
						isSystemUser = false;
					return true;
					
				}
			}
			catch(Exception ex)
			{
				throw ex;
			}
			return false;
		}
		/// <summary>
		/// Register a new user
		/// </summary>
		/// <param name="UserName"></param>
		/// <param name="Password"></param>
		/// <returns></returns>
		public static bool RegisterUser(string UserName,string Password)
		{
			bool IsSuccess = false;
			if(UsersList.ContainsKey(UserName))
			{
				return IsSuccess;
			}
			try
			{
				SqlConnection conn = new SqlConnection(Globals.ConnectionString);
				conn.Open();
				SqlCommand cmd = new SqlCommand("",conn);
				String SQLCommand = "BEGIN TRANSACTION\r\n";
				SQLCommand += "INSERT INTO lib_users (User_Name,User_Password,User_Is_System) values ('" + UserName + "','" + EncryptDecrypt.Encode(Password) + "'," + "0)\r\n"; 
				SQLCommand += "Commit Transaction";
				cmd.CommandText = SQLCommand;
				int Count = cmd.ExecuteNonQuery();
				if (Count == 1)
				{
					IsSuccess = true;
				}
				conn.Close();
			}
			catch(Exception ex)
			{
				throw ex;
			}
			return IsSuccess;
		}
		/// <summary>
		/// change user password
		/// </summary>
		/// <param name="UserName"></param>
		/// <param name="Password"></param>
		/// <returns></returns>
		public static bool ChangePassword(string UserName,string Password)
		{
			bool IsSuccess = false;
			try
			{
				SqlConnection conn = new SqlConnection(Globals.ConnectionString);
				conn.Open();
				SqlCommand cmd = new SqlCommand("",conn);
				String SQLCommand = "BEGIN TRANSACTION\r\n";
				SQLCommand += "update lib_users set User_Password = '" + EncryptDecrypt.Encode(Password) + "' where user_name = '" + UserName + "'\r\n"; 
				SQLCommand += "Commit Transaction";
				cmd.CommandText = SQLCommand;
				int Count = cmd.ExecuteNonQuery();
				if (Count == 1)
				{
					IsSuccess = true;
				}
				conn.Close();
			}
			catch(Exception ex)
			{
				throw ex;
			}
			return IsSuccess;
		}
		/// <summary>
		/// Add book in system
		/// </summary>
		/// <param name="BookTitle"></param>
		/// <param name="AuthorName"></param>
		/// <param name="catId"></param>
		/// <param name="Quantity"></param>
		/// <param name="isNewEntry"></param>
		/// <returns></returns>
		public static bool AddBook(string BookTitle,string AuthorName,int catId,int Quantity,ref bool isNewEntry)
		{
			bool IsSuccess = false;
			try
			{
				DataSet ds =new DataSet();
				String SQLCommand = "BEGIN TRANSACTION\r\n";
				SQLCommand+= "select lib_book_id from lib_book_details where lib_book_issue_status = 0 and lib_book_in_inventory = 0 and lib_book_title='" + BookTitle + "' and Lib_Book_Category = '" + catId + "' and Lib_Book_Author_Name = '" + AuthorName + "'\r\n";
				SQLCommand += "Commit Transaction";
				// Check if there is any record for which inventory status is set to false
				SqlDataAdapter Adapter = new SqlDataAdapter(SQLCommand,Globals.ConnectionString);
				Adapter.Fill(ds);	
				Adapter.SelectCommand.Connection.Close();	

				int iCount = 0;
				bool InsertBookData = true;
				if(ds.Tables[0].Rows.Count >0)
				{
					iCount = ds.Tables[0].Rows.Count;
				}
				SqlConnection conn = new SqlConnection(Globals.ConnectionString);
				conn.Open();
				SqlCommand cmd = new SqlCommand("",conn);;
				if(iCount > 0)
				{
					isNewEntry =false;
					int LoopCount = 0;
					if(iCount >= Quantity)
					{
						LoopCount = Quantity;
						Quantity = 0;
						iCount = 0;
						InsertBookData = false;
					}
					else
					{
						LoopCount = iCount;
						Quantity = Quantity - iCount;
					}
					SQLCommand = "BEGIN TRANSACTION\r\n";
					// for records having inventory status as false update status to true
					for(int i=0;i<LoopCount;i++)
						SQLCommand += "Update Lib_Book_Details set lib_book_in_inventory = 1 where Lib_Book_id ='" + Convert.ToInt32(ds.Tables[0].Rows[i][0]) + "'\r\n"; 
					SQLCommand += "Commit Transaction";
					cmd.CommandText = SQLCommand;
					int Count = cmd.ExecuteNonQuery();
					if (Count >= 1)
					{
						IsSuccess = true;
					}
				}
				// insert new rows if there are no records or no records with inventory status as false
				// or there are some row with inventory status false but those are less than quantity of
				// books being added 
				if(InsertBookData)
				{
					SQLCommand = "BEGIN TRANSACTION\r\n";
					for(int i=0;i<Quantity;i++)
						SQLCommand += "INSERT INTO Lib_Book_Details (Lib_Book_Title,Lib_Book_Category,Lib_Book_Author_Name) values ('" + BookTitle + "'," + catId + ",'" + AuthorName + "'\r\n)"; 
					SQLCommand += "Commit Transaction";
					cmd.CommandText = SQLCommand;
					int Count = cmd.ExecuteNonQuery();
					if (Count >= 1)
					{
						IsSuccess = true;
					}
				}
				conn.Close();
			}
			catch(Exception ex)
			{
				throw ex;
			}
			return IsSuccess;

		}
		/// <summary>
		/// Remove book from system
		/// </summary>
		/// <param name="BookTitle"></param>
		/// <param name="Quantity"></param>
		/// <param name="AuthorName"></param>
		/// <param name="CategoryName"></param>
		/// <returns></returns>
		public static bool RemoveBook(string BookTitle,int Quantity, string AuthorName, string CategoryName)
		{
			bool IsSuccess = false;
			try
			{
				SqlConnection conn = new SqlConnection(Globals.ConnectionString);
				conn.Open();
				SqlCommand cmd = new SqlCommand("",conn);
				String SQLCommand = "BEGIN TRANSACTION\r\n";
				// rows are not removed from system but inventory status is set as false and such records
				// are not at all considered in system for issue etc.
				for(int i=0;i<Quantity;i++)
				{
					SQLCommand += "update lib_book_details set lib_book_in_inventory = 0 where lib_book_id = ";
					SQLCommand+="(select top 1 lib_book_id from lib_book_details a join lib_book_categories b on b.category_id = a.lib_book_category where a.lib_book_title = '" + BookTitle + "' and a.lib_book_issue_status = 0 and a.lib_book_in_inventory = 1 ";
					SQLCommand+="and a.lib_book_author_name= '" + AuthorName + "' and b.category_name = '" + CategoryName + "')\r\n"; 
				}
				SQLCommand += "Commit Transaction";
				cmd.CommandText = SQLCommand;
				int Count = cmd.ExecuteNonQuery();
				if (Count >= 1)
				{
					IsSuccess = true;
				}
				conn.Close();
			}
			catch(Exception ex)
			{
				throw ex;
			}
			return IsSuccess;

		}
		/// <summary>
		/// Search books
		/// </summary>
		/// <param name="BookTitle"></param>
		/// <param name="Category"></param>
		/// <returns></returns>
		public static DataSet SearchBook(string BookTitle,string Category)
		{
			DataSet ds = new DataSet();
			string SQLCommand = "";
			// Book and category both criterias are mentioned by user
			// records retrieved will be those books which are there in inventory and not issued
			if(!BookTitle.Equals("") && !Category.Equals(""))
			{
				SQLCommand = "select a.lib_book_title as Book,a.lib_book_author_name as Author,count(*) as AvailbleQty,b.category_name as Category from lib_book_details a join lib_book_categories b ";
				SQLCommand+= "on b.category_id = a.lib_book_category where lib_book_title = '" + BookTitle + "' and b.category_name = '" + Category + "' and lib_book_issue_status = 0 and a.lib_book_in_inventory = 1 group by a.lib_book_title,a.lib_book_author_name,b.category_name";
 
			}
			// Book criteria is mentioned by user
			// records retrieved will be those books which are there in inventory and not issued
			if(!BookTitle.Equals("") && Category.Equals(""))
			{
				SQLCommand = "select a.lib_book_title as Book,a.lib_book_author_name as Author,count(*) as AvailbleQty,b.category_name as Category from lib_book_details a join lib_book_categories b ";
				SQLCommand+= "on b.category_id = a.lib_book_category where lib_book_title = '" + BookTitle + "' and lib_book_issue_status = 0 and a.lib_book_in_inventory = 1 group by a.lib_book_title,a.lib_book_author_name,b.category_name";
			}
			// Category criteria is mentioned by user
			// records retrieved will be those books which are there in inventory and not issued
			if(BookTitle.Equals("") && !Category.Equals(""))
			{
				SQLCommand = "select a.lib_book_title as Book,a.lib_book_author_name as Author,count(*) as AvailbleQty,b.category_name as Category from lib_book_details a join lib_book_categories b ";
				SQLCommand+= "on b.category_id = a.lib_book_category where b.category_name = '" + Category + "' and lib_book_issue_status = 0 and a.lib_book_in_inventory = 1 group by a.lib_book_title,a.lib_book_author_name,b.category_name";
			}
			try
			{
				SqlDataAdapter Adapter = new SqlDataAdapter(SQLCommand,Globals.ConnectionString);
				Adapter.Fill(ds);	
				Adapter.SelectCommand.Connection.Close();	
			}
			catch(Exception ex)
			{
				throw ex;
			}
			return ds;
			
		}
		/// <summary>
		/// Chack if a book is already issued to requesting user
		/// </summary>
		/// <param name="BookTitle"></param>
		/// <param name="Author"></param>
		/// <param name="CategoryName"></param>
		/// <returns></returns>
		public static bool ValidateBook(string BookTitle,string Author,string CategoryName)
		{
			try
			{
				DataSet ds = new DataSet();
				string SQLCommand =  "select a.lib_book_title,a.lib_book_author_name as Author,b.category_name from lib_book_details a join lib_book_categories b on b.category_id = a.lib_book_category ";
				SQLCommand+="join lib_book_issue_details c on c.lib_book_id = a.lib_book_id where c.lib_book_issued_to = '" + Globals.UserName + "'";
				SqlDataAdapter Adapter = new SqlDataAdapter(SQLCommand,Globals.ConnectionString);
				Adapter.Fill(ds);	
				Adapter.SelectCommand.Connection.Close();	
				if(ds.Tables[0].Rows.Count >0)
				{
					for(int i = 0; i < ds.Tables[0].Rows.Count;i++)
					{
						if(ds.Tables[0].Rows[i][0].ToString().Equals(BookTitle)
							&& ds.Tables[0].Rows[i][1].ToString().Equals(Author)
							&& ds.Tables[0].Rows[i][2].ToString().Equals(CategoryName))
						{
							return false;
							
						}
					}
					
				}
				return true;
			}
			catch(Exception ex)
			{
				throw ex;
			}
			//return false;
		}
		/// <summary>
		/// Issue a book - set issue status as true, insert data in issue details table
		/// </summary>
		/// <param name="BookTitle"></param>
		/// <param name="Author"></param>
		/// <param name="Category"></param>
		/// <returns></returns>
		public static bool IssueBook(string BookTitle,string Author,string Category)
		{
			bool IsSuccess = false;
			try
			{
				SqlConnection conn = new SqlConnection(Globals.ConnectionString);
				conn.Open();
				SqlCommand cmd = new SqlCommand("",conn);
				String SQLCommand = "BEGIN TRANSACTION\r\n";
				SQLCommand+= "declare @bookid int\r\n";
				SQLCommand+="select top 1 @bookid =lib_book_id  from lib_book_details a join lib_book_categories b on b.category_id = a.lib_book_category ";
				SQLCommand+="where a.lib_book_title = '" + BookTitle + "'and a.lib_book_issue_status = 0 and a.lib_book_in_inventory = 1 and a.lib_book_author_name='" + Author + "'";
				SQLCommand+="and b.category_name = '" + Category + "'\r\n";
				SQLCommand+="insert into lib_book_issue_details (lib_book_id,lib_book_issued_on,lib_book_issued_to) values (@bookid,getdate(),'" + Globals.UserName + "')\r\n";
				SQLCommand+="update lib_book_details set lib_book_issue_status = 1 where lib_book_id = @bookid\r\n";
				SQLCommand+="update lib_users set Number_of_books_issued = Number_of_books_issued + 1 where user_name = '" + Globals.UserName + "'\r\n";
				SQLCommand += "Commit Transaction";
				cmd.CommandText = SQLCommand;
				int Count = cmd.ExecuteNonQuery();
				if (Count != 1)
				{
					IsSuccess = true;
				}
				conn.Close();
			}
			catch(Exception ex)
			{
				throw ex;
			}
			return IsSuccess;
		}
		/// <summary>
		/// Return book. Update issue status to false, delete entry from issue details table
		/// </summary>
		/// <param name="BookId"></param>
		/// <param name="IssueId"></param>
		/// <returns></returns>
		public static bool ReturnBook(int BookId,int IssueId)
		{
			bool IsSuccess = false;
			try
			{
				SqlConnection conn = new SqlConnection(Globals.ConnectionString);
				conn.Open();
				SqlCommand cmd = new SqlCommand("",conn);
				String SQLCommand = "BEGIN TRANSACTION\r\n";
				SQLCommand+="update lib_book_details set lib_book_issue_status=0 where lib_book_id =" + BookId + "\r\n";
				SQLCommand+="delete from lib_book_issue_details where lib_book_issue_id =" + IssueId + "\r\n";
				SQLCommand+="update lib_users set Number_of_books_issued = Number_of_books_issued - 1 where user_name = '" + Globals.UserName + "'\r\n";
				SQLCommand += "Commit Transaction";
				cmd.CommandText = SQLCommand;
				int Count = cmd.ExecuteNonQuery();
				if (Count != 1)
				{
					IsSuccess = true;
				}
				conn.Close();
			}
			catch(Exception ex)
			{
				throw ex;
			}
			return IsSuccess;
		}
		/// <summary>
		/// Issued books data to be used in return books screen
		/// </summary>
		/// <returns></returns>
		public static DataSet PopulateReturnBooks()
		{
			DataSet ds = new DataSet();
			string SQLCommand = "";
			SQLCommand = "select a.lib_book_id,a.lib_book_issue_id,b.lib_book_title,b.lib_book_author_name,c.category_name from Lib_Book_Issue_Details a ";
			SQLCommand+= "join Lib_Book_Details b on a.lib_book_id = b.lib_book_id join lib_book_categories c on b.lib_book_category = c.category_id ";
			SQLCommand+= "where a.lib_book_issued_to = '" + Globals.UserName + "'";
 			try
			{
				SqlDataAdapter Adapter = new SqlDataAdapter(SQLCommand,Globals.ConnectionString);
				Adapter.Fill(ds);	
				Adapter.SelectCommand.Connection.Close();	
			}
			catch(Exception ex)
			{
				throw ex;
			}
			return ds;
			
		}
	}
}
