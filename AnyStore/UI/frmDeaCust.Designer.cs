namespace AnyStore.UI
{
    partial class frmDeaCust
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
            this.pnlDeaCust = new System.Windows.Forms.Panel();
            this.cmbDeaCust = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvDeaCust = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtDeaCustID = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblDeaCustID = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblTop = new System.Windows.Forms.Label();
            this.pnlDeaCust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeaCust)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDeaCust
            // 
            this.pnlDeaCust.Controls.Add(this.cmbDeaCust);
            this.pnlDeaCust.Controls.Add(this.btnDelete);
            this.pnlDeaCust.Controls.Add(this.btnUpdate);
            this.pnlDeaCust.Controls.Add(this.btnAdd);
            this.pnlDeaCust.Controls.Add(this.dgvDeaCust);
            this.pnlDeaCust.Controls.Add(this.txtSearch);
            this.pnlDeaCust.Controls.Add(this.txtDeaCustID);
            this.pnlDeaCust.Controls.Add(this.lblSearch);
            this.pnlDeaCust.Controls.Add(this.lblDeaCustID);
            this.pnlDeaCust.Controls.Add(this.txtAddress);
            this.pnlDeaCust.Controls.Add(this.txtContact);
            this.pnlDeaCust.Controls.Add(this.txtEmail);
            this.pnlDeaCust.Controls.Add(this.txtName);
            this.pnlDeaCust.Controls.Add(this.lblAddress);
            this.pnlDeaCust.Controls.Add(this.lblContact);
            this.pnlDeaCust.Controls.Add(this.lblEmail);
            this.pnlDeaCust.Controls.Add(this.lblName);
            this.pnlDeaCust.Controls.Add(this.lblType);
            this.pnlDeaCust.Controls.Add(this.panel2);
            this.pnlDeaCust.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDeaCust.Location = new System.Drawing.Point(0, 0);
            this.pnlDeaCust.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDeaCust.Name = "pnlDeaCust";
            this.pnlDeaCust.Size = new System.Drawing.Size(1225, 474);
            this.pnlDeaCust.TabIndex = 0;
            // 
            // cmbDeaCust
            // 
            this.cmbDeaCust.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeaCust.FormattingEnabled = true;
            this.cmbDeaCust.Items.AddRange(new object[] {
            "Dealer",
            "Customer"});
            this.cmbDeaCust.Location = new System.Drawing.Point(133, 118);
            this.cmbDeaCust.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDeaCust.Name = "cmbDeaCust";
            this.cmbDeaCust.Size = new System.Drawing.Size(341, 29);
            this.cmbDeaCust.TabIndex = 61;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(764, 426);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(227, 37);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Chartreuse;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(497, 426);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(227, 37);
            this.btnUpdate.TabIndex = 59;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(249, 426);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(227, 37);
            this.btnAdd.TabIndex = 58;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvDeaCust
            // 
            this.dgvDeaCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeaCust.Location = new System.Drawing.Point(517, 108);
            this.dgvDeaCust.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDeaCust.Name = "dgvDeaCust";
            this.dgvDeaCust.RowHeadersWidth = 51;
            this.dgvDeaCust.Size = new System.Drawing.Size(685, 299);
            this.dgvDeaCust.TabIndex = 57;
            this.dgvDeaCust.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDeaCust_RowHeaderMouseClick);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(620, 68);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(554, 29);
            this.txtSearch.TabIndex = 56;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtDeaCustID
            // 
            this.txtDeaCustID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeaCustID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeaCustID.Location = new System.Drawing.Point(133, 68);
            this.txtDeaCustID.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeaCustID.Name = "txtDeaCustID";
            this.txtDeaCustID.ReadOnly = true;
            this.txtDeaCustID.Size = new System.Drawing.Size(342, 29);
            this.txtDeaCustID.TabIndex = 55;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(513, 73);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(72, 23);
            this.lblSearch.TabIndex = 54;
            this.lblSearch.Text = "Search:-";
            // 
            // lblDeaCustID
            // 
            this.lblDeaCustID.AutoSize = true;
            this.lblDeaCustID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeaCustID.Location = new System.Drawing.Point(23, 73);
            this.lblDeaCustID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeaCustID.Name = "lblDeaCustID";
            this.lblDeaCustID.Size = new System.Drawing.Size(107, 23);
            this.lblDeaCustID.TabIndex = 53;
            this.lblDeaCustID.Text = "DeaCust ID:-";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(133, 315);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(342, 92);
            this.txtAddress.TabIndex = 52;
            // 
            // txtContact
            // 
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(133, 265);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(342, 29);
            this.txtContact.TabIndex = 51;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(133, 217);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(342, 29);
            this.txtEmail.TabIndex = 50;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(133, 167);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(342, 29);
            this.txtName.TabIndex = 49;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(44, 320);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(81, 23);
            this.lblAddress.TabIndex = 48;
            this.lblAddress.Text = "Address:-";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(49, 270);
            this.lblContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(81, 23);
            this.lblContact.TabIndex = 47;
            this.lblContact.Text = "Contact:-";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(71, 222);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 23);
            this.lblEmail.TabIndex = 46;
            this.lblEmail.Text = "Emal:-";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(61, 172);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 23);
            this.lblName.TabIndex = 45;
            this.lblName.Text = "Name:-";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(72, 123);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(56, 23);
            this.lblType.TabIndex = 44;
            this.lblType.Text = "Type:-";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.pictureBoxClose);
            this.panel2.Controls.Add(this.lblTop);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1225, 49);
            this.panel2.TabIndex = 43;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxClose.Image = global::AnyStore.Properties.Resources.Close_red;
            this.pictureBoxClose.Location = new System.Drawing.Point(1172, 0);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(53, 49);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(492, 12);
            this.lblTop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(224, 28);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "DEALER and CUSTOMER";
            // 
            // frmDeaCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1225, 474);
            this.Controls.Add(this.pnlDeaCust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDeaCust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "femDeaCust";
            this.Load += new System.EventHandler(this.frmDeaCust_Load);
            this.pnlDeaCust.ResumeLayout(false);
            this.pnlDeaCust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeaCust)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDeaCust;
        private System.Windows.Forms.ComboBox cmbDeaCust;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvDeaCust;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtDeaCustID;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblDeaCustID;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label lblTop;
    }
}