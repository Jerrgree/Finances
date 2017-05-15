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
    public partial class addTransactionForm : Form
    {
        ErrorProvider ep = new ErrorProvider();
        private DataTable dt = new DataTable();
        static string dataPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\FinanceData.mdf";
        public addTransactionForm()
        {
            InitializeComponent();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"" + dataPath + "\"; Integrated Security = True";

            // Select to see if a row matches the user's designated table
            string query = "SELECT name FROM dbo.FinanceValues";
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            transactionSource.DataSource = dt.AsEnumerable().Select(x => x[0].ToString()).ToList();
            transactionSource.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private bool validateData()
        {
            // Clear all errors, assume data is initially valid
            this.ep.SetError(transactionValueInput, "");
            bool isValid = true;

            // Make sure that the value field is monetary
            if (!Regex.IsMatch(transactionValueInput.Text, @"^[-]?[0-9]+(\.[0-9][0-9])?$"))
            {
                isValid = false;

                this.ep.SetError(transactionValueInput, "Please only enter monetary values");
            }

            if (transactionValueInput.Text == "")
            {
                isValid = false;

                this.ep.SetError(transactionValueInput, "Please Enter a Value");
            }

            return isValid;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (!validateData()) return;

            // Update the summary value
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"" + dataPath + "\"; Integrated Security = True";

            string sourceName = transactionSource.Text;
            Decimal transactionValue = Convert.ToDecimal(transactionValueInput.Text);

            string query = "update dbo.FinanceValues SET value = " + 
                "(SELECT value FROM dbo.FinanceValues WHERE name = '" + sourceName + "') + " + transactionValue + " WHERE Id = " + 
                "(SELECT Id FROM dbo.FinanceValues WHERE name = '" + sourceName + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();

            query = "INSERT INTO dbo.Transactions (Note, Amount, Date, Source) VALUES " + 
                "('" + noteInput.Text + "', " + transactionValue + ", '" + transactionDateSource.SelectionRange.Start.ToShortDateString() + "', " +
                "(SELECT Id FROM dbo.FinanceValues WHERE name = '" + sourceName + "'))";

            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
