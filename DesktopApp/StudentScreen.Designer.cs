namespace DesktopApp
{
    partial class StudentScreen
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
            this.DgvStudents = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFullname = new System.Windows.Forms.TextBox();
            this.CmbGroups = new System.Windows.Forms.ComboBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.NmrGeneralPrice = new System.Windows.Forms.NumericUpDown();
            this.NmrPayment = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrGeneralPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvStudents
            // 
            this.DgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStudents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvStudents.Location = new System.Drawing.Point(0, 256);
            this.DgvStudents.Name = "DgvStudents";
            this.DgvStudents.RowHeadersWidth = 51;
            this.DgvStudents.RowTemplate.Height = 29;
            this.DgvStudents.Size = new System.Drawing.Size(800, 194);
            this.DgvStudents.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Name";
            // 
            // TxtFullname
            // 
            this.TxtFullname.Location = new System.Drawing.Point(12, 60);
            this.TxtFullname.Name = "TxtFullname";
            this.TxtFullname.Size = new System.Drawing.Size(221, 27);
            this.TxtFullname.TabIndex = 2;
            // 
            // CmbGroups
            // 
            this.CmbGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGroups.FormattingEnabled = true;
            this.CmbGroups.Location = new System.Drawing.Point(260, 59);
            this.CmbGroups.Name = "CmbGroups";
            this.CmbGroups.Size = new System.Drawing.Size(192, 28);
            this.CmbGroups.TabIndex = 3;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(12, 133);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(221, 27);
            this.TxtEmail.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // TxtNumber
            // 
            this.TxtNumber.Location = new System.Drawing.Point(12, 202);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(221, 27);
            this.TxtNumber.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Group";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(360, 202);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(94, 29);
            this.BtnUpdate.TabIndex = 9;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Visible = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(460, 202);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(94, 29);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Visible = false;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(260, 202);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(94, 29);
            this.BtnAdd.TabIndex = 11;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "General price";
            // 
            // NmrGeneralPrice
            // 
            this.NmrGeneralPrice.Location = new System.Drawing.Point(260, 134);
            this.NmrGeneralPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NmrGeneralPrice.Name = "NmrGeneralPrice";
            this.NmrGeneralPrice.Size = new System.Drawing.Size(192, 27);
            this.NmrGeneralPrice.TabIndex = 15;
            // 
            // NmrPayment
            // 
            this.NmrPayment.Location = new System.Drawing.Point(473, 134);
            this.NmrPayment.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NmrPayment.Name = "NmrPayment";
            this.NmrPayment.Size = new System.Drawing.Size(192, 27);
            this.NmrPayment.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Payment";
            // 
            // StudentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NmrPayment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NmrGeneralPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbGroups);
            this.Controls.Add(this.TxtFullname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvStudents);
            this.Name = "StudentScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.StudentScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrGeneralPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DgvStudents;
        private Label label1;
        private TextBox TxtFullname;
        private ComboBox CmbGroups;
        private TextBox TxtEmail;
        private Label label2;
        private TextBox TxtNumber;
        private Label label3;
        private Label label4;
        private Button BtnUpdate;
        private Button BtnDelete;
        private Button BtnAdd;
        private Label label5;
        private NumericUpDown NmrGeneralPrice;
        private NumericUpDown NmrPayment;
        private Label label6;
    }
}