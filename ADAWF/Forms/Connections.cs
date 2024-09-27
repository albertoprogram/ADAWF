using ADAWF.Utilities;
using Microsoft.Extensions.Configuration;
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

        #region btnSaveConnection_Click
        private void btnSaveConnection_Click(object sender, EventArgs e)
        {
            InsertConnection();
        }
        #endregion

        #region InsertConnection
        private void InsertConnection()
        {
            string connectionString = string.Empty;

            try
            {
                connectionString = ConfigurationHelper.GetConnectionString("DefaultConnection");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar obtener cadena de conexión de {GlobalUtilities.systemName}" +
                    ex.Message + "-" + ex.StackTrace,
                    GlobalUtilities.systemName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string encryptPassword = EncryptPassword(txtPassword.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Connections 
                         (ConnectionName, ConnectionDescription, ServerName, DatabaseName, AuthenticationType, UserName, EncryptedPassword) 
                         VALUES 
                         (@ConnectionName, @ConnectionDescription, @ServerName, @DatabaseName, @AuthenticationType, @UserName, @EncryptedPassword)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@ConnectionName", SqlDbType.NVarChar, 250).Value = txtConnectionName.Text;
                    command.Parameters.Add("@ConnectionDescription", SqlDbType.NVarChar, 2000).Value = txtConnectionDescription.Text;
                    command.Parameters.Add("@ServerName", SqlDbType.NVarChar, 250).Value = txtServerName.Text;
                    command.Parameters.Add("@DatabaseName", SqlDbType.NVarChar, 250).Value = txtDatabaseName.Text;
                    command.Parameters.Add("@AuthenticationType", SqlDbType.NVarChar, 50).Value = cmbAuthenticationType.Text;
                    command.Parameters.Add("@UserName", SqlDbType.NVarChar, 100).Value = txtUserName.Text;
                    command.Parameters.Add("@EncryptedPassword", SqlDbType.NVarChar, 2000).Value = encryptPassword;

                    try
                    {
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        MessageBox.Show($"{rowsAffected} registro(s) insertado(s) exitosamente.",
                            GlobalUtilities.systemName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("SQL Error:" + sqlEx.Message + "-" + sqlEx.StackTrace,
                            GlobalUtilities.systemName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("General Error:" + ex.Message + "-" + ex.StackTrace,
                            GlobalUtilities.systemName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion

        #region EncryptPassword
        private string EncryptPassword(string password)
        {
            try
            {
                var config = new ConfigurationBuilder()
                    .AddUserSecrets<Connections>()
                    .Build();

                string key = config["EncryptionKey"];
                string iv = config["EncryptionIV"];

                AesEncryption aes = new AesEncryption(key, iv);

                string encryptedText = aes.Encrypt(password);

                return encryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("General Error:" + ex.Message + "-" + ex.StackTrace,
                            GlobalUtilities.systemName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return "Error";
            }
        }
        #endregion

        #region btnTestConnectionAndSave_Click
        private void btnTestConnectionAndSave_Click(object sender, EventArgs e)
        {
            string connectionString = ConnectionString(txtServerName.Text, txtDatabaseName.Text,
                cmbAuthenticationType.Text, txtUserName.Text, txtPassword.Text);

            if (TestSQLServerConnection(connectionString))
            {
                MessageBox.Show("Se logró la conexión.", GlobalUtilities.systemName,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                InsertConnection();

                MessageBox.Show("Operación completada.", GlobalUtilities.systemName,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialogResult =
                    MessageBox.Show("No se pudo efectuar la conexión. ¿Todavía desea guardar la información de la conexión?",
                    GlobalUtilities.systemName,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    InsertConnection();
                }
                else
                {
                    MessageBox.Show("Operación cancelada", GlobalUtilities.systemName,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region Connections_Load
        private void Connections_Load(object sender, EventArgs e)
        {
            cmbAuthenticationType.Text = "SQL Server Authentication";
        }
        #endregion
    }
}
