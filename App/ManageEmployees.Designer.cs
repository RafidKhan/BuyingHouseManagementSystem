﻿namespace App
{
    partial class ManageEmployees
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
            this.EmployeeNamelbl = new System.Windows.Forms.Label();
            this.PhoneNumLbl = new System.Windows.Forms.Label();
            this.EmaiLbl = new System.Windows.Forms.Label();
            this.Sallbl = new System.Windows.Forms.Label();
            this.EmpIdLbl = new System.Windows.Forms.Label();
            this.DesignationLbl = new System.Windows.Forms.Label();
            this.EmpIdTb = new System.Windows.Forms.TextBox();
            this.EmailTb = new System.Windows.Forms.TextBox();
            this.PhoneNumberTb2 = new System.Windows.Forms.TextBox();
            this.EmpNameTb = new System.Windows.Forms.TextBox();
            this.EmpSalTb = new System.Windows.Forms.TextBox();
            this.DesignationTb = new System.Windows.Forms.TextBox();
            this.PhoneNumberTb1 = new System.Windows.Forms.TextBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.InsetBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.EmpTable = new System.Windows.Forms.DataGridView();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.Searchlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmpTable)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeNamelbl
            // 
            this.EmployeeNamelbl.AutoSize = true;
            this.EmployeeNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNamelbl.Location = new System.Drawing.Point(44, 100);
            this.EmployeeNamelbl.Name = "EmployeeNamelbl";
            this.EmployeeNamelbl.Size = new System.Drawing.Size(118, 18);
            this.EmployeeNamelbl.TabIndex = 0;
            this.EmployeeNamelbl.Text = "Employee Name";
            this.EmployeeNamelbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // PhoneNumLbl
            // 
            this.PhoneNumLbl.AutoSize = true;
            this.PhoneNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumLbl.Location = new System.Drawing.Point(44, 156);
            this.PhoneNumLbl.Name = "PhoneNumLbl";
            this.PhoneNumLbl.Size = new System.Drawing.Size(108, 18);
            this.PhoneNumLbl.TabIndex = 1;
            this.PhoneNumLbl.Text = "Phone Number";
            // 
            // EmaiLbl
            // 
            this.EmaiLbl.AutoSize = true;
            this.EmaiLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmaiLbl.Location = new System.Drawing.Point(44, 211);
            this.EmaiLbl.Name = "EmaiLbl";
            this.EmaiLbl.Size = new System.Drawing.Size(45, 18);
            this.EmaiLbl.TabIndex = 2;
            this.EmaiLbl.Text = "Email";
            // 
            // Sallbl
            // 
            this.Sallbl.AutoSize = true;
            this.Sallbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sallbl.Location = new System.Drawing.Point(44, 264);
            this.Sallbl.Name = "Sallbl";
            this.Sallbl.Size = new System.Drawing.Size(117, 18);
            this.Sallbl.TabIndex = 4;
            this.Sallbl.Text = "Employee salary";
            // 
            // EmpIdLbl
            // 
            this.EmpIdLbl.AutoSize = true;
            this.EmpIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpIdLbl.Location = new System.Drawing.Point(44, 50);
            this.EmpIdLbl.Name = "EmpIdLbl";
            this.EmpIdLbl.Size = new System.Drawing.Size(92, 18);
            this.EmpIdLbl.TabIndex = 5;
            this.EmpIdLbl.Text = "Employee ID";
            // 
            // DesignationLbl
            // 
            this.DesignationLbl.AutoSize = true;
            this.DesignationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesignationLbl.Location = new System.Drawing.Point(44, 327);
            this.DesignationLbl.Name = "DesignationLbl";
            this.DesignationLbl.Size = new System.Drawing.Size(86, 18);
            this.DesignationLbl.TabIndex = 6;
            this.DesignationLbl.Text = "Designation";
            // 
            // EmpIdTb
            // 
            this.EmpIdTb.Location = new System.Drawing.Point(185, 46);
            this.EmpIdTb.Name = "EmpIdTb";
            this.EmpIdTb.Size = new System.Drawing.Size(204, 22);
            this.EmpIdTb.TabIndex = 7;
            // 
            // EmailTb
            // 
            this.EmailTb.Location = new System.Drawing.Point(185, 211);
            this.EmailTb.Name = "EmailTb";
            this.EmailTb.Size = new System.Drawing.Size(204, 22);
            this.EmailTb.TabIndex = 8;
            // 
            // PhoneNumberTb2
            // 
            this.PhoneNumberTb2.Location = new System.Drawing.Point(228, 156);
            this.PhoneNumberTb2.Name = "PhoneNumberTb2";
            this.PhoneNumberTb2.Size = new System.Drawing.Size(161, 22);
            this.PhoneNumberTb2.TabIndex = 9;
            this.PhoneNumberTb2.TextChanged += new System.EventHandler(this.PhoneNumTb_TextChanged);
            // 
            // EmpNameTb
            // 
            this.EmpNameTb.Location = new System.Drawing.Point(185, 99);
            this.EmpNameTb.Name = "EmpNameTb";
            this.EmpNameTb.Size = new System.Drawing.Size(204, 22);
            this.EmpNameTb.TabIndex = 10;
            // 
            // EmpSalTb
            // 
            this.EmpSalTb.Location = new System.Drawing.Point(185, 260);
            this.EmpSalTb.Name = "EmpSalTb";
            this.EmpSalTb.Size = new System.Drawing.Size(204, 22);
            this.EmpSalTb.TabIndex = 11;
            // 
            // DesignationTb
            // 
            this.DesignationTb.Location = new System.Drawing.Point(185, 327);
            this.DesignationTb.Name = "DesignationTb";
            this.DesignationTb.Size = new System.Drawing.Size(204, 22);
            this.DesignationTb.TabIndex = 12;
            // 
            // PhoneNumberTb1
            // 
            this.PhoneNumberTb1.Location = new System.Drawing.Point(185, 156);
            this.PhoneNumberTb1.Name = "PhoneNumberTb1";
            this.PhoneNumberTb1.ReadOnly = true;
            this.PhoneNumberTb1.Size = new System.Drawing.Size(37, 22);
            this.PhoneNumberTb1.TabIndex = 13;
            this.PhoneNumberTb1.Text = "+880";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(47, 1);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(371, 23);
            this.RefreshBtn.TabIndex = 14;
            this.RefreshBtn.Text = "Refresh Data";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.refreshbtnclick);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(14, 487);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 15;
            this.ExitBtn.Text = "Back";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.backbtnclick);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(147, 418);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 29);
            this.UpdateBtn.TabIndex = 16;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.updatebtnclick);
            // 
            // InsetBtn
            // 
            this.InsetBtn.Location = new System.Drawing.Point(36, 418);
            this.InsetBtn.Name = "InsetBtn";
            this.InsetBtn.Size = new System.Drawing.Size(75, 29);
            this.InsetBtn.TabIndex = 17;
            this.InsetBtn.Text = "Insert";
            this.InsetBtn.UseVisualStyleBackColor = true;
            this.InsetBtn.Click += new System.EventHandler(this.Insertbtnclick);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(261, 418);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 29);
            this.DeleteBtn.TabIndex = 18;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.deletebtnclick);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(364, 418);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 29);
            this.LoadBtn.TabIndex = 19;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.loadbtnclick);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Red;
            this.LogoutBtn.Location = new System.Drawing.Point(1035, 1);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(75, 41);
            this.LogoutBtn.TabIndex = 20;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.logoutbtnclick);
            // 
            // EmpTable
            // 
            this.EmpTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpTable.Location = new System.Drawing.Point(528, 99);
            this.EmpTable.Name = "EmpTable";
            this.EmpTable.ReadOnly = true;
            this.EmpTable.RowTemplate.Height = 24;
            this.EmpTable.Size = new System.Drawing.Size(509, 212);
            this.EmpTable.TabIndex = 21;
            this.EmpTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpCellClick);
            // 
            // ViewBtn
            // 
            this.ViewBtn.Location = new System.Drawing.Point(528, 50);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(509, 43);
            this.ViewBtn.TabIndex = 22;
            this.ViewBtn.Text = "View All Employees";
            this.ViewBtn.UseVisualStyleBackColor = true;
            this.ViewBtn.Click += new System.EventHandler(this.viewallbtnclick);
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(596, 323);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(441, 27);
            this.SearchBox.TabIndex = 23;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchTBValueChanged);
            // 
            // Searchlbl
            // 
            this.Searchlbl.AutoSize = true;
            this.Searchlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlbl.Location = new System.Drawing.Point(528, 327);
            this.Searchlbl.Name = "Searchlbl";
            this.Searchlbl.Size = new System.Drawing.Size(62, 20);
            this.Searchlbl.TabIndex = 24;
            this.Searchlbl.Text = "Search";
            // 
            // ManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1122, 536);
            this.Controls.Add(this.Searchlbl);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.EmpTable);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.InsetBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.PhoneNumberTb1);
            this.Controls.Add(this.DesignationTb);
            this.Controls.Add(this.EmpSalTb);
            this.Controls.Add(this.EmpNameTb);
            this.Controls.Add(this.PhoneNumberTb2);
            this.Controls.Add(this.EmailTb);
            this.Controls.Add(this.EmpIdTb);
            this.Controls.Add(this.DesignationLbl);
            this.Controls.Add(this.EmpIdLbl);
            this.Controls.Add(this.Sallbl);
            this.Controls.Add(this.EmaiLbl);
            this.Controls.Add(this.PhoneNumLbl);
            this.Controls.Add(this.EmployeeNamelbl);
            this.MaximizeBox = false;
            this.Name = "ManageEmployees";
            this.ShowIcon = false;
            this.Text = "Buying House Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            ((System.ComponentModel.ISupportInitialize)(this.EmpTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeNamelbl;
        private System.Windows.Forms.Label PhoneNumLbl;
        private System.Windows.Forms.Label EmaiLbl;
        private System.Windows.Forms.Label Sallbl;
        private System.Windows.Forms.Label EmpIdLbl;
        private System.Windows.Forms.Label DesignationLbl;
        private System.Windows.Forms.TextBox EmpIdTb;
        private System.Windows.Forms.TextBox EmailTb;
        private System.Windows.Forms.TextBox PhoneNumberTb2;
        private System.Windows.Forms.TextBox EmpNameTb;
        private System.Windows.Forms.TextBox EmpSalTb;
        private System.Windows.Forms.TextBox DesignationTb;
        private System.Windows.Forms.TextBox PhoneNumberTb1;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button InsetBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.DataGridView EmpTable;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label Searchlbl;
    }
}