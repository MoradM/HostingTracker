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
            g_Products = new DataGridView();
            Product = new DataGridViewTextBoxColumn();
            Expiration = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            IsAutoRenewed = new DataGridViewTextBoxColumn();
            Provider = new DataGridViewTextBoxColumn();
            t_godaddyKey = new TextBox();
            l_godaddyKey = new Label();
            l_status = new Label();
            ((System.ComponentModel.ISupportInitialize)g_Products).BeginInit();
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
            b_fetch.Location = new Point(784, 15);
            b_fetch.Name = "b_fetch";
            b_fetch.Size = new Size(75, 23);
            b_fetch.TabIndex = 2;
            b_fetch.Text = "Fetch";
            b_fetch.UseVisualStyleBackColor = true;
            b_fetch.Click += button1_Click;
            // 
            // g_Products
            // 
            g_Products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            g_Products.Columns.AddRange(new DataGridViewColumn[] { Product, Expiration, Type, IsAutoRenewed, Provider });
            g_Products.Location = new Point(12, 99);
            g_Products.Name = "g_Products";
            g_Products.Size = new Size(854, 339);
            g_Products.TabIndex = 3;
            g_Products.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Product
            // 
            Product.HeaderText = "Product";
            Product.Name = "Product";
            Product.ReadOnly = true;
            Product.Resizable = DataGridViewTriState.False;
            Product.Width = 300;
            // 
            // Expiration
            // 
            Expiration.HeaderText = "Expiration";
            Expiration.Name = "Expiration";
            Expiration.ReadOnly = true;
            Expiration.Resizable = DataGridViewTriState.False;
            Expiration.Width = 200;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.Name = "Type";
            Type.ReadOnly = true;
            // 
            // IsAutoRenewed
            // 
            IsAutoRenewed.HeaderText = "IsAutoRenewed";
            IsAutoRenewed.Name = "IsAutoRenewed";
            IsAutoRenewed.ReadOnly = true;
            // 
            // Provider
            // 
            Provider.HeaderText = "Provider";
            Provider.Name = "Provider";
            Provider.ReadOnly = true;
            Provider.Resizable = DataGridViewTriState.False;
            Provider.Width = 125;
            // 
            // t_godaddyKey
            // 
            t_godaddyKey.Location = new Point(102, 41);
            t_godaddyKey.Name = "t_godaddyKey";
            t_godaddyKey.Size = new Size(241, 23);
            t_godaddyKey.TabIndex = 4;
            // 
            // l_godaddyKey
            // 
            l_godaddyKey.AutoSize = true;
            l_godaddyKey.Location = new Point(12, 44);
            l_godaddyKey.Name = "l_godaddyKey";
            l_godaddyKey.Size = new Size(81, 15);
            l_godaddyKey.TabIndex = 5;
            l_godaddyKey.Text = "GoDaddy Key:";
            // 
            // l_status
            // 
            l_status.AutoSize = true;
            l_status.Location = new Point(12, 72);
            l_status.Name = "l_status";
            l_status.Size = new Size(64, 15);
            l_status.TabIndex = 6;
            l_status.Text = "Status: Idle";
            // 
            // HostingTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 450);
            Controls.Add(l_status);
            Controls.Add(l_godaddyKey);
            Controls.Add(t_godaddyKey);
            Controls.Add(g_Products);
            Controls.Add(b_fetch);
            Controls.Add(t_hostingerKey);
            Controls.Add(l_hostingerKey);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HostingTracker";
            Text = "HostingTracker";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)g_Products).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l_hostingerKey;
        private TextBox t_hostingerKey;
        private Button b_fetch;
        private DataGridView g_Products;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Expiration;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn IsAutoRenewed;
        private DataGridViewTextBoxColumn Provider;
        private TextBox t_godaddyKey;
        private Label l_godaddyKey;
        private Label l_status;
    }
}
