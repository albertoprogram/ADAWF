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
            // Connections
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 561);
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
    }
}