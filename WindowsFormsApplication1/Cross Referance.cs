using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //set up SQL variables
        string connectionString = "Data Source=AUTOMINTSQL;Initial Catalog=Automint;User ID=sa;Password=Aut0m1nt";
        SqlConnection connection;
        SqlCommand command;
        string sql = null;

        //to use datareader:
        SqlDataReader dataReader;

        //To use adapter:
        SqlDataAdapter adapter;


        //var for search
        string product = "%%%%%";
        string Number_Source = "%%%%%";
        string Cross_reference_Number = "%%%%%";
        string wildF = "%%%%%";
        string wildR = "%%%%%";


        //For colour
        bool isOn = true;


        private void Form1_Load(object sender, EventArgs e)
        {
            //Change listbox properties
            listSearch2.View = View.Details;
            listSearch2.FullRowSelect = true;

            //Create columns
            listSearch2.Columns.Add("Number", 80);
            listSearch2.Columns.Add("Source", 80);
            listSearch2.Columns.Add("Automint", 80);
            listSearch2.Columns.Add("Commnets", 150);
            listSearch2.Columns.Add("Product", 80);
            listSearch2.Columns.Add("ID", 80);


            listProduct.Columns.Add("Product", 80);
            listSource.Columns.Add("Source", 80);

        }

        public Form1()
        {
            InitializeComponent();
            productMethod();
            sourceMethod();
            resultsMethod();
            searchHistoryDisplay();
            
        }

        //fill in product list box
        private void productMethod()
        {

            sql = @"SELECT Product, Product_Grouping 
                        FROM Tbl_Product_Type_List 
                        GROUP BY Product, Product_Grouping";
            openRead();
            while (dataReader.Read())
            {
                    string Product = dataReader["Product"].ToString();
                    listProduct.Items.Add(Product);
            }
            
            closeConnection();
        }

        // fill source list box
        private void sourceMethod()
        {
            sql = @"SELECT Tbl_Cross_reference.Number_Source 
                        FROM Tbl_CR_Family 
                        INNER JOIN Tbl_Cross_Reference ON Tbl_CR_Family.CrossReference_ID = Tbl_Cross_Reference.CrossReference_ID 
                        INNER Join Tbl_Product_Type_List 
                        INNER JOIN Tbl_Product_Information ON Tbl_Product_Type_List.Product = Tbl_Product_Information.Product ON Tbl_CR_Family.Product_ID = Tbl_Product_Information.Product_ID 
                        LEFT OUTER JOIN Tbl_CrossRef_Exclude ON Tbl_Cross_Reference.Number_Source = Tbl_CrossRef_Exclude.Number_Source 
                        WHERE (COALESCE(Tbl_CrossRef_Exclude.Exclude,0) <> 1) 
                        GROUP BY dbo.Tbl_Cross_Reference.Number_Source 
                        HAVING (dbo.Tbl_Cross_reference.Number_Source <> '') 
                        AND (dbo.Tbl_Cross_reference.Number_Source IS NOT NULL) 
                        ORDER BY Tbl_Cross_reference.Number_Source";
            openRead();
            while (dataReader.Read())
            {
                string Number_Source = dataReader["Number_Source"].ToString();
                listSource.Items.Add(Number_Source);
            }
            closeConnection();
        }

        // fill source list box
        private void resultsMethod()
        {
            listSearch2.Items.Clear();


            try
            {
                sql = @"SELECT TOP 200 Tbl_Cross_reference.Cross_reference_Number, 
                          Tbl_Cross_reference.Number_Source, 
                          Tbl_Product_Information.Automint_Part_No, 
                          Tbl_Cross_reference.Comments, 
                          Tbl_Product_Information.Product, 
                          'PID' + CAST(Tbl_Product_Information.Product_ID AS Varchar) AS PID,
                          Tbl_Product_Type_List.Product_Grouping, 
                          Tbl_Cross_reference.CrossReference_ID
                          FROM Tbl_Product_Information INNER JOIN Tbl_Product_Type_List ON Tbl_Product_Information.Product = Tbl_Product_Type_List.Product
                          INNER Join Tbl_CR_Family ON Tbl_Product_Information.Product_ID = Tbl_CR_Family.Product_ID
                          INNER Join Tbl_Cross_Reference ON Tbl_CR_Family.CrossReference_ID = Tbl_Cross_Reference.CrossReference_ID
                          WHERE(Tbl_Cross_reference.Cross_reference_Number LIKE '%%'OR Tbl_Cross_reference.Cross_reference_Number LIKE '%%')
                          AND Tbl_Product_Information.Product LIKE '" + product + "' " +
                          "AND Tbl_Cross_reference.Number_Source LIKE '" + Number_Source + "' " +
                          "AND Tbl_Cross_reference.Cross_reference_Number LIKE '" + wildF + Cross_reference_Number + wildR + "'" +
                          "ORDER BY Tbl_Cross_reference.Cross_reference_Number";

                openRead();

                while (dataReader.Read())
                {
                    if (isOn)
                    {
                        string Cross_reference_Number = dataReader["Cross_reference_Number"].ToString();
                        string Number_Source = dataReader["Number_Source"].ToString();
                        string Automint_Part_No = dataReader["Automint_Part_No"].ToString();
                        string Comments = dataReader["Comments"].ToString();
                        string Product = dataReader["Product"].ToString();
                        string CrossReference_ID = dataReader["CrossReference_ID"].ToString();

                        string[] row = { Cross_reference_Number, Number_Source, Automint_Part_No, Comments, Product, CrossReference_ID };
                        ListViewItem item = new ListViewItem(row);
                        listSearch2.Items.Add(item);
                        isOn = false;
                    }
                    else
                    {
                        string Cross_reference_Number = dataReader["Cross_reference_Number"].ToString();
                        string Number_Source = dataReader["Number_Source"].ToString();
                        string Automint_Part_No = dataReader["Automint_Part_No"].ToString();
                        string Comments = dataReader["Comments"].ToString();
                        string Product = dataReader["Product"].ToString();
                        string CrossReference_ID = dataReader["CrossReference_ID"].ToString();

                        string[] row = { Cross_reference_Number, Number_Source, Automint_Part_No, Comments, Product, CrossReference_ID };
                        ListViewItem item = new ListViewItem(row);
                        item.BackColor = Color.LightYellow;

                        listSearch2.Items.Add(item);
                        isOn = true;
                    }
                }

            }
            //catch any sql error and show it
            catch (SqlException ex)
            {
                DisplaySqlErrors(ex);
            }
            //at the end of everything close the connection 
            finally
            {
                if (dataReader != null)
                {
                    closeConnection();
                }

            }
        }

        // Method to open sql connection:
        public void openRead()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = new SqlCommand(sql, connection);
            dataReader = command.ExecuteReader();
            
        }

        public void openAdapter()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            adapter = new SqlDataAdapter(sql, connection);
        }

        // Method to close sql connection:
        public void closeConnection()
        {
            connection.Close();
            dataReader.Close();
            command.Dispose();
        }

        private static void DisplaySqlErrors(SqlException ex)
        {
            for (int i = 0; i < ex.Errors.Count; i++)
            {
                MessageBox.Show("Number of errors: " + ex.Errors.Count + "\n" + "Error: " + ex.Errors[i].ToString() + "\n");
            }
        }

        private void addBy5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Cross_reference_Number = cbSearch.Text;
            resultsMethod();
        }

        //select the product from the list and run search
        private void listProduct_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbProduct.CheckState = CheckState.Checked;

            if (listProduct.SelectedItems.Count == 0)
                return;
            ListViewItem item = listProduct.SelectedItems[0];

            product = item.Text;
            resultsMethod();
        }

        //highlight the selected items in the list and keep the item clour untill cleared or selected again
        private void listProduct_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listProduct.SelectedItems.Count == 0)
                return;
            ListViewItem item = listProduct.SelectedItems[0];

            if (item.BackColor == Color.LightYellow)
            {
                item.BackColor = listProduct.BackColor;
            }
            else
            {
                item.BackColor = Color.LightYellow;
            }
        }

        //select the source from the list and run search
        private void listSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSource.CheckState = CheckState.Checked;

            if (listSource.SelectedItems.Count == 0)
                return;
            ListViewItem item = listSource.SelectedItems[0];
            Number_Source = item.Text;

            resultsMethod();
            cbSource.CheckState = CheckState.Checked;
        }

        //clear button method
        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            //var for search
            product = "%%%%%";
            Number_Source = "%%%%%";
            Cross_reference_Number = "%%%%%";
            cbSearch.Text = null;
            listColourDefault(); //Clear the product list colour
            cbProduct.CheckState = CheckState.Unchecked;
            cbSource.CheckState = CheckState.Unchecked;
            cbFront.CheckState = CheckState.Checked;
            cbRear.CheckState = CheckState.Checked;
            resultsMethod();
        }

        //Clear the product list colour
        private void listColourDefault()
        {
            foreach (ListViewItem item in listProduct.Items)
            {
                item.BackColor = listProduct.BackColor;
            }
        }

        //press enter to search
        private void cbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cross_reference_Number = cbSearch.Text;
                resultsMethod();
            }
        }

        //use or unuse the search lists.
        private void cbProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (cbProduct.CheckState == CheckState.Unchecked)
            {
                product = "%%%%%";
                listColourDefault();
                resultsMethod();
            }
        }

        //use or unuse the search lists.
        private void cbSource_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSource.CheckState == CheckState.Unchecked)
            {
                Number_Source = "%%%%%";
                resultsMethod();
            }
        }

        private void cbRear_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRear.CheckState == CheckState.Unchecked)
            {
                wildR = "";
                resultsMethod();
            }
            else if (cbRear.CheckState == CheckState.Checked)
            {
                wildR = "%%%%%";
                resultsMethod();
            }
        }

        private void cbFront_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFront.CheckState == CheckState.Unchecked)
            {
                wildF = "";
                resultsMethod();
            }
            else if (cbFront.CheckState == CheckState.Checked)
            {
                wildF = "%%%%%";
                resultsMethod();
            }
        }
        
        void searchHistoryDisplay()
        {
            try
            {
                sql = @"SELECT SearchString, MAX(TimeOfSearch)AS Latest 
                            FROM Tbl_Search_History 
                            GROUP BY Searchstring HAVING(SearchString <> '" + cbSearch + "') ORDER BY Latest DESC";
            
                openRead();

                while (dataReader.Read())
                {
                    string SearchString = dataReader["SearchString"].ToString();
                    cbSearch.Items.Add(SearchString);
                }
            }
            catch (SqlException ex)
            {
                DisplaySqlErrors(ex);
            }
            //at the end of everything close the connection 
            finally
            {
                if (dataReader != null)
                {
                    closeConnection();
                }
            }
        }
    }
}
