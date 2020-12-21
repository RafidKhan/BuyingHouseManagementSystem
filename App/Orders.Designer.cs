namespace App
{
    partial class Orders
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
            this.OrderNoLbl = new System.Windows.Forms.Label();
            this.CostLbl = new System.Windows.Forms.Label();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.OrderTypeLbl = new System.Windows.Forms.Label();
            this.ClientNumLbl = new System.Windows.Forms.Label();
            this.OrderTable = new System.Windows.Forms.DataGridView();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Label();
            this.SearchTb = new System.Windows.Forms.TextBox();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.OrderNoTb = new System.Windows.Forms.TextBox();
            this.OrderTypeTb = new System.Windows.Forms.TextBox();
            this.CostTb = new System.Windows.Forms.TextBox();
            this.QualityTb = new System.Windows.Forms.TextBox();
            this.ClientNumberTb1 = new System.Windows.Forms.TextBox();
            this.ClientNumberTb2 = new System.Windows.Forms.TextBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.clientnamelbl = new System.Windows.Forms.Label();
            this.clientnametb = new System.Windows.Forms.TextBox();
            this.clientemaillbl = new System.Windows.Forms.Label();
            this.clientemailtb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderNoLbl
            // 
            this.OrderNoLbl.AutoSize = true;
            this.OrderNoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderNoLbl.Location = new System.Drawing.Point(41, 159);
            this.OrderNoLbl.Name = "OrderNoLbl";
            this.OrderNoLbl.Size = new System.Drawing.Size(98, 25);
            this.OrderNoLbl.TabIndex = 0;
            this.OrderNoLbl.Text = "Order No:";
            // 
            // CostLbl
            // 
            this.CostLbl.AutoSize = true;
            this.CostLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLbl.Location = new System.Drawing.Point(41, 314);
            this.CostLbl.Name = "CostLbl";
            this.CostLbl.Size = new System.Drawing.Size(59, 25);
            this.CostLbl.TabIndex = 1;
            this.CostLbl.Text = "Cost:";
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLbl.Location = new System.Drawing.Point(41, 264);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(91, 25);
            this.QuantityLbl.TabIndex = 2;
            this.QuantityLbl.Text = "Quantity:";
            // 
            // OrderTypeLbl
            // 
            this.OrderTypeLbl.AutoSize = true;
            this.OrderTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderTypeLbl.Location = new System.Drawing.Point(41, 209);
            this.OrderTypeLbl.Name = "OrderTypeLbl";
            this.OrderTypeLbl.Size = new System.Drawing.Size(118, 25);
            this.OrderTypeLbl.TabIndex = 3;
            this.OrderTypeLbl.Text = "Order Type:";
            // 
            // ClientNumLbl
            // 
            this.ClientNumLbl.AutoSize = true;
            this.ClientNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNumLbl.Location = new System.Drawing.Point(41, 390);
            this.ClientNumLbl.Name = "ClientNumLbl";
            this.ClientNumLbl.Size = new System.Drawing.Size(142, 25);
            this.ClientNumLbl.TabIndex = 4;
            this.ClientNumLbl.Text = "Client Number:";
            // 
            // OrderTable
            // 
            this.OrderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderTable.Location = new System.Drawing.Point(479, 105);
            this.OrderTable.Name = "OrderTable";
            this.OrderTable.RowTemplate.Height = 24;
            this.OrderTable.Size = new System.Drawing.Size(489, 193);
            this.OrderTable.TabIndex = 5;
            this.OrderTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderCellClick);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Red;
            this.LogoutBtn.Location = new System.Drawing.Point(935, 3);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(75, 42);
            this.LogoutBtn.TabIndex = 6;
            this.LogoutBtn.Text = "LogOut";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.logoutbtnclick);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(30, 487);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(107, 39);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.backbtnclick);
            // 
            // SearchBtn
            // 
            this.SearchBtn.AutoSize = true;
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(475, 304);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(59, 18);
            this.SearchBtn.TabIndex = 8;
            this.SearchBtn.Text = "Search:";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchTb
            // 
            this.SearchTb.Location = new System.Drawing.Point(540, 304);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(428, 22);
            this.SearchTb.TabIndex = 9;
            this.SearchTb.TextChanged += new System.EventHandler(this.Searchtbchange);
            // 
            // InsertBtn
            // 
            this.InsertBtn.Location = new System.Drawing.Point(46, 427);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(75, 31);
            this.InsertBtn.TabIndex = 10;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.insertbtnclick);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(289, 427);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 31);
            this.LoadBtn.TabIndex = 11;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.loadbtnclick);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(208, 427);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 31);
            this.DeleteBtn.TabIndex = 12;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.deletebtnclick);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(127, 427);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 31);
            this.UpdateBtn.TabIndex = 13;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.updatebtnclick);
            // 
            // OrderNoTb
            // 
            this.OrderNoTb.Location = new System.Drawing.Point(162, 159);
            this.OrderNoTb.Name = "OrderNoTb";
            this.OrderNoTb.Size = new System.Drawing.Size(186, 22);
            this.OrderNoTb.TabIndex = 14;
            this.OrderNoTb.TextChanged += new System.EventHandler(this.OrderNoTb_TextChanged);
            // 
            // OrderTypeTb
            // 
            this.OrderTypeTb.Location = new System.Drawing.Point(165, 213);
            this.OrderTypeTb.Name = "OrderTypeTb";
            this.OrderTypeTb.Size = new System.Drawing.Size(183, 22);
            this.OrderTypeTb.TabIndex = 14;
            // 
            // CostTb
            // 
            this.CostTb.Location = new System.Drawing.Point(165, 314);
            this.CostTb.Name = "CostTb";
            this.CostTb.Size = new System.Drawing.Size(183, 22);
            this.CostTb.TabIndex = 15;
            // 
            // QualityTb
            // 
            this.QualityTb.Location = new System.Drawing.Point(165, 264);
            this.QualityTb.Name = "QualityTb";
            this.QualityTb.Size = new System.Drawing.Size(183, 22);
            this.QualityTb.TabIndex = 16;
            // 
            // ClientNumberTb1
            // 
            this.ClientNumberTb1.Location = new System.Drawing.Point(183, 394);
            this.ClientNumberTb1.Name = "ClientNumberTb1";
            this.ClientNumberTb1.ReadOnly = true;
            this.ClientNumberTb1.Size = new System.Drawing.Size(45, 22);
            this.ClientNumberTb1.TabIndex = 17;
            this.ClientNumberTb1.Text = "+880";
            this.ClientNumberTb1.TextChanged += new System.EventHandler(this.ClientNumberTb1_TextChanged);
            // 
            // ClientNumberTb2
            // 
            this.ClientNumberTb2.Location = new System.Drawing.Point(239, 394);
            this.ClientNumberTb2.Name = "ClientNumberTb2";
            this.ClientNumberTb2.Size = new System.Drawing.Size(109, 22);
            this.ClientNumberTb2.TabIndex = 18;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(46, 57);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(318, 31);
            this.RefreshBtn.TabIndex = 19;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.refreshbtnclick);
            // 
            // ViewBtn
            // 
            this.ViewBtn.Location = new System.Drawing.Point(479, 68);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(489, 31);
            this.ViewBtn.TabIndex = 20;
            this.ViewBtn.Text = "View All Orders";
            this.ViewBtn.UseVisualStyleBackColor = true;
            this.ViewBtn.Click += new System.EventHandler(this.viewallbtnclick);
            // 
            // clientnamelbl
            // 
            this.clientnamelbl.AutoSize = true;
            this.clientnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientnamelbl.Location = new System.Drawing.Point(41, 105);
            this.clientnamelbl.Name = "clientnamelbl";
            this.clientnamelbl.Size = new System.Drawing.Size(125, 25);
            this.clientnamelbl.TabIndex = 21;
            this.clientnamelbl.Text = "Client Name:";
            // 
            // clientnametb
            // 
            this.clientnametb.Location = new System.Drawing.Point(162, 109);
            this.clientnametb.Name = "clientnametb";
            this.clientnametb.Size = new System.Drawing.Size(186, 22);
            this.clientnametb.TabIndex = 22;
            // 
            // clientemaillbl
            // 
            this.clientemaillbl.AutoSize = true;
            this.clientemaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientemaillbl.Location = new System.Drawing.Point(41, 356);
            this.clientemaillbl.Name = "clientemaillbl";
            this.clientemaillbl.Size = new System.Drawing.Size(121, 25);
            this.clientemaillbl.TabIndex = 23;
            this.clientemaillbl.Text = "Client Email:";
            // 
            // clientemailtb
            // 
            this.clientemailtb.Location = new System.Drawing.Point(162, 356);
            this.clientemailtb.Name = "clientemailtb";
            this.clientemailtb.Size = new System.Drawing.Size(183, 22);
            this.clientemailtb.TabIndex = 24;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1022, 538);
            this.Controls.Add(this.clientemailtb);
            this.Controls.Add(this.clientemaillbl);
            this.Controls.Add(this.clientnametb);
            this.Controls.Add(this.clientnamelbl);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.ClientNumberTb2);
            this.Controls.Add(this.ClientNumberTb1);
            this.Controls.Add(this.QualityTb);
            this.Controls.Add(this.CostTb);
            this.Controls.Add(this.OrderTypeTb);
            this.Controls.Add(this.OrderNoTb);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.SearchTb);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.OrderTable);
            this.Controls.Add(this.ClientNumLbl);
            this.Controls.Add(this.OrderTypeLbl);
            this.Controls.Add(this.QuantityLbl);
            this.Controls.Add(this.CostLbl);
            this.Controls.Add(this.OrderNoLbl);
            this.Name = "Orders";
            this.ShowIcon = false;
            this.Text = "Buying House Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderNoLbl;
        private System.Windows.Forms.Label CostLbl;
        private System.Windows.Forms.Label QuantityLbl;
        private System.Windows.Forms.Label OrderTypeLbl;
        private System.Windows.Forms.Label ClientNumLbl;
        private System.Windows.Forms.DataGridView OrderTable;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label SearchBtn;
        private System.Windows.Forms.TextBox SearchTb;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox OrderNoTb;
        private System.Windows.Forms.TextBox OrderTypeTb;
        private System.Windows.Forms.TextBox CostTb;
        private System.Windows.Forms.TextBox QualityTb;
        private System.Windows.Forms.TextBox ClientNumberTb1;
        private System.Windows.Forms.TextBox ClientNumberTb2;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Label clientnamelbl;
        private System.Windows.Forms.TextBox clientnametb;
        private System.Windows.Forms.Label clientemaillbl;
        private System.Windows.Forms.TextBox clientemailtb;
    }
}