using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADAWF.Forms
{
    public partial class Connections : Form
    {
        public Connections()
        {
            InitializeComponent();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            string connectionString = ConnectionString(txtServerName.Text, txtDatabaseName.Text,
                cmbAuthenticationType.Text, txtUserName.Text, txtPassword.Text);

            TestSQLServerConnection(connectionString);
        }

        private string ConnectionString(string serverName, string databaseName,
            string authenticationType, string userName, string password)
        {
            string connectionString =
                $"Server={serverName};" +
                $"Database={databaseName};";

            switch (authenticationType)
            {
                case "Windows Authentication":
                    connectionString += "Integrated Security=True;";
                    break;
                case "SQL Server Authentication":
                    connectionString += $"User Id={userName};" +
                        $"Password={password}";
                    break;
            }

            return connectionString;
        }

        private bool TestSQLServerConnection(string connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    return true;
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error:" + sqlEx.Message + "-" + sqlEx.StackTrace,
                    "System", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("General Error:" + ex.Message + "-" + ex.StackTrace,
                    "System", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }
    }
}
