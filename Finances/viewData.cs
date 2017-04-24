﻿using System;
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
    public partial class viewData : Form
    {
        private DataTable dt = new DataTable();
        public viewData()
        {
            InitializeComponent();

            string dataPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\FinanceData.mdf";

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"" + dataPath + "\"; Integrated Security = True";

            // Select to see if a row matches the user's designated table
            string validateName = "SELECT * FROM dbo.FinanceValues";
            SqlCommand cmd = new SqlCommand(validateName, conn);

            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

    }
}