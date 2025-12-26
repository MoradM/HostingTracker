namespace HostingTracker
{
    partial class HostingTracker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            l_hostingerKey = new Label();
            t_hostingerKey = new TextBox();
            b_fetch = new Button();
            g_Domains = new DataGridView();
            Domain = new DataGridViewTextBoxColumn();
            Expiration = new DataGridViewTextBoxColumn();
            Provider = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)g_Domains).BeginInit();
            SuspendLayout();
            // 
            // l_hostingerKey
            // 
            l_hostingerKey.AutoSize = true;
            l_hostingerKey.Location = new Point(12, 15);
            l_hostingerKey.Name = "l_hostingerKey";
            l_hostingerKey.Size = new Size(84, 15);
            l_hostingerKey.TabIndex = 0;
            l_hostingerKey.Text = "Hostinger Key:";
            l_hostingerKey.Click += label1_Click;
            // 
            // t_hostingerKey
            // 
            t_hostingerKey.Location = new Point(102, 12);
            t_hostingerKey.Name = "t_hostingerKey";
            t_hostingerKey.Size = new Size(241, 23);
            t_hostingerKey.TabIndex = 1;
            // 
            // b_fetch
            // 
            b_fetch.Location = new Point(580, 15);
            b_fetch.Name = "b_fetch";
            b_fetch.Size = new Size(75, 23);
            b_fetch.TabIndex = 2;
            b_fetch.Text = "Fetch";
            b_fetch.UseVisualStyleBackColor = true;
            b_fetch.Click += button1_Click;
            // 
            // g_Domains
            // 
            g_Domains.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            g_Domains.Columns.AddRange(new DataGridViewColumn[] { Domain, Expiration, Provider });
            g_Domains.Location = new Point(12, 99);
            g_Domains.Name = "g_Domains";
            g_Domains.Size = new Size(643, 339);
            g_Domains.TabIndex = 3;
            g_Domains.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Domain
            // 
            Domain.HeaderText = "Domain";
            Domain.Name = "Domain";
            Domain.ReadOnly = true;
            Domain.Resizable = DataGridViewTriState.False;
            Domain.Width = 300;
            // 
            // Expiration
            // 
            Expiration.HeaderText = "Expiration";
            Expiration.Name = "Expiration";
            Expiration.ReadOnly = true;
            Expiration.Resizable = DataGridViewTriState.False;
            Expiration.Width = 200;
            // 
            // Provider
            // 
            Provider.HeaderText = "Provider";
            Provider.Name = "Provider";
            Provider.ReadOnly = true;
            Provider.Resizable = DataGridViewTriState.False;
            // 
            // HostingTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 450);
            Controls.Add(g_Domains);
            Controls.Add(b_fetch);
            Controls.Add(t_hostingerKey);
            Controls.Add(l_hostingerKey);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HostingTracker";
            Text = "HostingTracker";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)g_Domains).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l_hostingerKey;
        private TextBox t_hostingerKey;
        private Button b_fetch;
        private DataGridView g_Domains;
        private DataGridViewTextBoxColumn Domain;
        private DataGridViewTextBoxColumn Expiration;
        private DataGridViewTextBoxColumn Provider;
    }
}
