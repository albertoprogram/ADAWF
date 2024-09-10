using ADAWF.Utilities;
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

        #region Constructors
        public Connections()
        {
            InitializeComponent();
        }
        #endregion

        #region btnTestConnection_Click
        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            string connectionString = ConnectionString(txtServerName.Text, txtDatabaseName.Text,
                cmbAuthenticationType.Text, txtUserName.Text, txtPassword.Text);

            if (TestSQLServerConnection(connectionString))
            {
                MessageBox.Show("OK", GlobalUtilities.systemName,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region ConnectionString
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
                        $"Password={password};";
                    break;
            }

            return connectionString;
        }
        #endregion

        #region TestSQLServerConnection
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
                    GlobalUtilities.systemName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("General Error:" + ex.Message + "-" + ex.StackTrace,
                    GlobalUtilities.systemName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }
        #endregion

    }
}
