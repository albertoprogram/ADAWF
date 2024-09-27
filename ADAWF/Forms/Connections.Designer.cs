namespace ADAWF.Forms
{
    partial class Connections
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblConnectionName = new Label();
            txtConnectionName = new TextBox();
            lblConnectionDescription = new Label();
            txtConnectionDescription = new TextBox();
            lblServerName = new Label();
            txtServerName = new TextBox();
            lblDatabaseName = new Label();
            txtDatabaseName = new TextBox();
            btnSelectDB = new Button();
            lblAuthenticationType = new Label();
            cmbAuthenticationType = new ComboBox();
            lblUserName = new Label();
            txtUserName = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnTestConnection = new Button();
            btnTestConnectionAndSave = new Button();
            btnSaveConnection = new Button();
            SuspendLayout();
            // 
            // lblConnectionName
            // 
            lblConnectionName.AutoSize = true;
            lblConnectionName.Location = new Point(66, 65);
            lblConnectionName.Name = "lblConnectionName";
            lblConnectionName.Size = new Size(141, 20);
            lblConnectionName.TabIndex = 0;
            lblConnectionName.Text = "lblConnectionName";
            // 
            // txtConnectionName
            // 
            txtConnectionName.Location = new Point(254, 62);
            txtConnectionName.Name = "txtConnectionName";
            txtConnectionName.Size = new Size(470, 27);
            txtConnectionName.TabIndex = 1;
            // 
            // lblConnectionDescription
            // 
            lblConnectionDescription.AutoSize = true;
            lblConnectionDescription.Location = new Point(64, 127);
            lblConnectionDescription.Name = "lblConnectionDescription";
            lblConnectionDescription.Size = new Size(177, 20);
            lblConnectionDescription.TabIndex = 2;
            lblConnectionDescription.Text = "lblConnectionDescription";
            // 
            // txtConnectionDescription
            // 
            txtConnectionDescription.Location = new Point(254, 124);
            txtConnectionDescription.Multiline = true;
            txtConnectionDescription.Name = "txtConnectionDescription";
            txtConnectionDescription.ScrollBars = ScrollBars.Vertical;
            txtConnectionDescription.Size = new Size(470, 90);
            txtConnectionDescription.TabIndex = 3;
            // 
            // lblServerName
            // 
            lblServerName.AutoSize = true;
            lblServerName.Location = new Point(66, 260);
            lblServerName.Name = "lblServerName";
            lblServerName.Size = new Size(107, 20);
            lblServerName.TabIndex = 4;
            lblServerName.Text = "lblServerName";
            // 
            // txtServerName
            // 
            txtServerName.Location = new Point(254, 257);
            txtServerName.Name = "txtServerName";
            txtServerName.Size = new Size(470, 27);
            txtServerName.TabIndex = 5;
            // 
            // lblDatabaseName
            // 
            lblDatabaseName.AutoSize = true;
            lblDatabaseName.Location = new Point(66, 326);
            lblDatabaseName.Name = "lblDatabaseName";
            lblDatabaseName.Size = new Size(129, 20);
            lblDatabaseName.TabIndex = 6;
            lblDatabaseName.Text = "lblDatabaseName";
            // 
            // txtDatabaseName
            // 
            txtDatabaseName.Location = new Point(254, 323);
            txtDatabaseName.Name = "txtDatabaseName";
            txtDatabaseName.Size = new Size(470, 27);
            txtDatabaseName.TabIndex = 7;
            // 
            // btnSelectDB
            // 
            btnSelectDB.Location = new Point(730, 322);
            btnSelectDB.Name = "btnSelectDB";
            btnSelectDB.Size = new Size(117, 29);
            btnSelectDB.TabIndex = 8;
            btnSelectDB.Text = "btnSelectDB";
            btnSelectDB.UseVisualStyleBackColor = true;
            // 
            // lblAuthenticationType
            // 
            lblAuthenticationType.AutoSize = true;
            lblAuthenticationType.Location = new Point(66, 393);
            lblAuthenticationType.Name = "lblAuthenticationType";
            lblAuthenticationType.Size = new Size(154, 20);
            lblAuthenticationType.TabIndex = 9;
            lblAuthenticationType.Text = "lblAuthenticationType";
            lblAuthenticationType.Visible = false;
            // 
            // cmbAuthenticationType
            // 
            cmbAuthenticationType.FormattingEnabled = true;
            cmbAuthenticationType.Items.AddRange(new object[] { "Windows Authentication", "SQL Server Authentication" });
            cmbAuthenticationType.Location = new Point(254, 390);
            cmbAuthenticationType.Name = "cmbAuthenticationType";
            cmbAuthenticationType.Size = new Size(470, 28);
            cmbAuthenticationType.TabIndex = 10;
            cmbAuthenticationType.Visible = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(66, 456);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(95, 20);
            lblUserName.TabIndex = 11;
            lblUserName.Text = "lblUserName";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(254, 453);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(470, 27);
            txtUserName.TabIndex = 12;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(66, 516);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 20);
            lblPassword.TabIndex = 13;
            lblPassword.Text = "lblPassword";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(254, 513);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(470, 27);
            txtPassword.TabIndex = 14;
            // 
            // btnTestConnection
            // 
            btnTestConnection.Location = new Point(75, 589);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(166, 29);
            btnTestConnection.TabIndex = 15;
            btnTestConnection.Text = "btnTestConnection";
            btnTestConnection.UseVisualStyleBackColor = true;
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // btnTestConnectionAndSave
            // 
            btnTestConnectionAndSave.Location = new Point(297, 589);
            btnTestConnectionAndSave.Name = "btnTestConnectionAndSave";
            btnTestConnectionAndSave.Size = new Size(228, 29);
            btnTestConnectionAndSave.TabIndex = 16;
            btnTestConnectionAndSave.Text = "btnTestConnectionAndSave";
            btnTestConnectionAndSave.UseVisualStyleBackColor = true;
            btnTestConnectionAndSave.Click += btnTestConnectionAndSave_Click;
            // 
            // btnSaveConnection
            // 
            btnSaveConnection.Location = new Point(590, 589);
            btnSaveConnection.Name = "btnSaveConnection";
            btnSaveConnection.Size = new Size(202, 29);
            btnSaveConnection.TabIndex = 17;
            btnSaveConnection.Text = "btnSaveConnection";
            btnSaveConnection.UseVisualStyleBackColor = true;
            btnSaveConnection.Click += btnSaveConnection_Click;
            // 
            // Connections
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 660);
            Controls.Add(btnSaveConnection);
            Controls.Add(btnTestConnectionAndSave);
            Controls.Add(btnTestConnection);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Controls.Add(cmbAuthenticationType);
            Controls.Add(lblAuthenticationType);
            Controls.Add(btnSelectDB);
            Controls.Add(txtDatabaseName);
            Controls.Add(lblDatabaseName);
            Controls.Add(txtServerName);
            Controls.Add(lblServerName);
            Controls.Add(txtConnectionDescription);
            Controls.Add(lblConnectionDescription);
            Controls.Add(txtConnectionName);
            Controls.Add(lblConnectionName);
            Name = "Connections";
            Text = "Connections";
            Load += Connections_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConnectionName;
        private TextBox txtConnectionName;
        private Label lblConnectionDescription;
        private TextBox txtConnectionDescription;
        private Label lblServerName;
        private TextBox txtServerName;
        private Label lblDatabaseName;
        private TextBox txtDatabaseName;
        private Button btnSelectDB;
        private Label lblAuthenticationType;
        private ComboBox cmbAuthenticationType;
        private Label lblUserName;
        private TextBox txtUserName;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnTestConnection;
        private Button btnTestConnectionAndSave;
        private Button btnSaveConnection;
    }
}