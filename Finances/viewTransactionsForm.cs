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
using System.IO;

namespace Finances
{
    public partial class viewTransactionsForm : Form
    {
        private DataTable dt = new DataTable();
        private string nullDate;
        string dataPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\FinanceData.mdf";
        public viewTransactionsForm()
        {
            initializeDropDown();

            // Initialzie the table
            // Initially show all data
            string initialQuery = "SELECT FinanceValues.name, Transactions.Note, Transactions.Amount, Transactions.Date, Budgets.Name, BudgetCategories.Name " +
            "FROM FinanceValues " +
            "INNER JOIN Transactions ON FinanceValues.Id = Transactions.Source " + 
            "LEFT OUTER JOIN Budgets ON Transactions.Budget = Budgets.Id " +
            "LEFT OUTER JOIN BudgetCategories ON Transactions.Category = BudgetCategories.Id "; 

            fillTable(initialQuery);

            nullDate = beforeDateSource.TodayDate.ToShortDateString();
        }

        private void initializeDropDown()
        {
            List<string> ComboItems = new List<string>();
            ComboItems.Add("All");

            InitializeComponent();
            // Initialize the combo box

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"" + dataPath + "\"; Integrated Security = True";

            string query = "SELECT name FROM dbo.FinanceValues";

            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            ComboItems.AddRange(dt.AsEnumerable().Select(x => x[0].ToString()).ToList());

            transactionSource.DataSource = ComboItems;
            transactionSource.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private string constructQuery()
        {
            string SelectClause = "SELECT FinanceValues.name, Transactions.Note, Transactions.Amount, Transactions.Date ";
            string FromClause = "FROM FinanceValues ";
            string WhereClause = "";
            string JoinClause = "INNER JOIN Transactions ON FinanceValues.Id = Transactions.Source " +
            "LEFT OUTER JOIN Budgets ON Transactions.Budget = Budgets.Id " +
            "LEFT OUTER JOIN BudgetCategories ON Transactions.Category = BudgetCategories.Id ";

            string beforeDate = beforeDateSource.SelectionRange.Start.ToShortDateString();
            string afterDate = afterDateSource.SelectionRange.Start.ToShortDateString();
            string sourceName = transactionSource.Text;

            if (beforeDate != nullDate)
            {
                string statement = "Transactions.Date < '" + beforeDate + "' ";

                WhereClause = SQLQuery.appendQuery("WHERE ", WhereClause, statement);
            }

            if (afterDate != nullDate)
            {
                string statement = "Transactions.Date > '" + afterDate + "' ";

                WhereClause = SQLQuery.appendQuery("WHERE ", WhereClause, statement);
            }

            if (sourceName != "All")
            {
                string statement = "FinanceValues.name = '" + sourceName + "' ";

                WhereClause = SQLQuery.appendQuery("WHERE ", WhereClause, statement);
            }

            return SelectClause + FromClause + JoinClause + WhereClause;
        }

        private void fillTable(string query)
        {
            if (query == "ERROR") return;

            dt.Clear();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"" + dataPath + "\"; Integrated Security = True";

            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            fillTable(constructQuery());
        }
    }
}
