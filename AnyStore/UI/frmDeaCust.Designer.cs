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
            this.lblTop = new System.Windows.Forms.Label();
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
            this.pnlDeaCust.Name = "pnlDeaCust";
            this.pnlDeaCust.Size = new System.Drawing.Size(919, 385);
            this.pnlDeaCust.TabIndex = 0;
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(369, 10);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(180, 21);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "DEALER and CUSTOMER";
            // 
            // cmbDeaCust
            // 
            this.cmbDeaCust.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeaCust.FormattingEnabled = true;
            this.cmbDeaCust.Items.AddRange(new object[] {
            "Dealer",
            "Customer"});
            this.cmbDeaCust.Location = new System.Drawing.Point(100, 96);
            this.cmbDeaCust.Name = "cmbDeaCust";
            this.cmbDeaCust.Size = new System.Drawing.Size(257, 25);
            this.cmbDeaCust.TabIndex = 61;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(573, 346);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 30);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Chartreuse;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(373, 346);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(170, 30);
            this.btnUpdate.TabIndex = 59;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(187, 346);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 30);
            this.btnAdd.TabIndex = 58;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // dgvDeaCust
            // 
            this.dgvDeaCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeaCust.Location = new System.Drawing.Point(388, 88);
            this.dgvDeaCust.Name = "dgvDeaCust";
            this.dgvDeaCust.Size = new System.Drawing.Size(514, 243);
            this.dgvDeaCust.TabIndex = 57;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(465, 55);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(416, 25);
            this.txtSearch.TabIndex = 56;
            // 
            // txtDeaCustID
            // 
            this.txtDeaCustID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeaCustID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeaCustID.Location = new System.Drawing.Point(100, 55);
            this.txtDeaCustID.Name = "txtDeaCustID";
            this.txtDeaCustID.ReadOnly = true;
            this.txtDeaCustID.Size = new System.Drawing.Size(257, 25);
            this.txtDeaCustID.TabIndex = 55;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(385, 59);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(55, 17);
            this.lblSearch.TabIndex = 54;
            this.lblSearch.Text = "Search:-";
            // 
            // lblDeaCustID
            // 
            this.lblDeaCustID.AutoSize = true;
            this.lblDeaCustID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeaCustID.Location = new System.Drawing.Point(17, 59);
            this.lblDeaCustID.Name = "lblDeaCustID";
            this.lblDeaCustID.Size = new System.Drawing.Size(80, 17);
            this.lblDeaCustID.TabIndex = 53;
            this.lblDeaCustID.Text = "DeaCust ID:-";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(100, 256);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(257, 75);
            this.txtAddress.TabIndex = 52;
            // 
            // txtContact
            // 
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(100, 215);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(257, 25);
            this.txtContact.TabIndex = 51;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(100, 176);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(257, 25);
            this.txtEmail.TabIndex = 50;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(100, 136);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(257, 25);
            this.txtName.TabIndex = 49;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(33, 260);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 17);
            this.lblAddress.TabIndex = 48;
            this.lblAddress.Text = "Address:-";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(37, 219);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(60, 17);
            this.lblContact.TabIndex = 47;
            this.lblContact.Text = "Contact:-";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(53, 180);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 17);
            this.lblEmail.TabIndex = 46;
            this.lblEmail.Text = "Emal:-";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(46, 140);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 17);
            this.lblName.TabIndex = 45;
            this.lblName.Text = "Name:-";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(54, 100);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 17);
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
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 40);
            this.panel2.TabIndex = 43;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxClose.Image = global::AnyStore.Properties.Resources.Close_red;
            this.pictureBoxClose.Location = new System.Drawing.Point(879, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            // 
            // frmDeaCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(919, 385);
            this.Controls.Add(this.pnlDeaCust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeaCust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "femDeaCust";
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