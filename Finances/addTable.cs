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
using System.Text.RegularExpressions;

namespace Finances
{
    public partial class addTableForm : Form
    {
        //private DataTable dataTable = new DataTable();
        ErrorProvider ep = new ErrorProvider();
        public addTableForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "";

            // Ensure that all data is valid
            if (!validateData())
            { 
                return;
            }

            // Retrieve the account name
            string tableName = tableNameInput.Text;

            // Find the Database
            string dataPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\FinanceData.mdf";

            // Open a connection to the database
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"" + dataPath + "\"; Integrated Security = True";

            // Select to see if a row matches the user's designated table
            string validateName = "SELECT * FROM dbo.FinanceValues WHERE name = '" + tableName + "'";
            SqlCommand cmd = new SqlCommand(validateName, conn);

            conn.Open();

            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dataTable);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                this.ep.SetError(tableNameInput, "This account already exists");
                return;
            }

            if (isCreditCard.Checked)
            {
                Decimal val = Convert.ToDecimal(initValueInput.Text);
                insertQuery = "INSERT INTO dbo.FinanceValues (name, value, type, maxValue) " +
                    "VALUES ('" + tableName + "', 0, 'credit', " + val + ")";
            }

            else if (isBankAccount.Checked)
            {
                Decimal val = Convert.ToDecimal(initValueInput.Text);
                insertQuery = "INSERT INTO dbo.FinanceValues (name, value, type) " +
                    "VALUES ('" + tableName + "', " + val + ", 'bank')";
            }

            cmd = new SqlCommand(insertQuery, conn);
            cmd.ExecuteNonQuery();

            this.Close();
        }

        private bool validateData()
        {
            // Clear all errors, assume data is initially valid
            this.ep.SetError(initValueInput, "");
            this.ep.SetError(tableNameInput, "");
            bool isValid = true;

            // Make sure that the value field is monetary
            if (!Regex.IsMatch(initValueInput.Text, @"^[0-9]+(.$^[0-9]^[0-9])?"))
            {
                isValid = false;

                this.ep.SetError(initValueInput, "Please only enter monetary values");
            }

            // Make sure that neither field is empty
            if (tableNameInput.Text == "")
            {
                isValid = false;

                this.ep.SetError(tableNameInput, "Please Enter a Value");
            }

            if (initValueInput.Text == "")
            {
                isValid = false;

                this.ep.SetError(initValueInput, "Please Enter a Value");
            }

            return isValid;
        }
    }
}
