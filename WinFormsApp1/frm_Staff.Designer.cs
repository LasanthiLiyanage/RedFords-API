namespace RadFordsApp
{
    partial class frm_Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Staff));
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            button1 = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnCreate = new Button();
            cmbManger = new ComboBox();
            label11 = new Label();
            cmbStatus = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            txt_IrdNo = new TextBox();
            label8 = new Label();
            txt_Extension = new TextBox();
            label7 = new Label();
            txt_CellPone = new TextBox();
            label6 = new Label();
            txt_HomePhone = new TextBox();
            label5 = new Label();
            txt_Middle_Initial = new TextBox();
            label4 = new Label();
            txt_LastName = new TextBox();
            txt_firstName = new TextBox();
            label3 = new Label();
            cmbTitle = new ComboBox();
            label2 = new Label();
            cmbStaffType = new ComboBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            grd_Staff = new DataGridView();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd_Staff).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.7229919F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.2770081F));
            tableLayoutPanel1.Size = new Size(1103, 722);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Controls.Add(btnCreate);
            groupBox2.Controls.Add(cmbManger);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(cmbStatus);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txt_IrdNo);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txt_Extension);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txt_CellPone);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txt_HomePhone);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txt_Middle_Initial);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txt_LastName);
            groupBox2.Controls.Add(txt_firstName);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cmbTitle);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cmbStaffType);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 362);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1097, 357);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(797, 296);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 27;
            button1.Text = "Export";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(651, 296);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 26;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(507, 296);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(342, 296);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 24;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(172, 296);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 23;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // cmbManger
            // 
            cmbManger.FormattingEnabled = true;
            cmbManger.Location = new Point(490, 194);
            cmbManger.Name = "cmbManger";
            cmbManger.Size = new Size(201, 28);
            cmbManger.TabIndex = 22;
            cmbManger.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(368, 202);
            label11.Name = "label11";
            label11.Size = new Size(68, 20);
            label11.TabIndex = 21;
            label11.Text = "Manager";
            label11.Visible = false;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            cmbStatus.Location = new Point(131, 194);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(201, 28);
            cmbStatus.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 202);
            label10.Name = "label10";
            label10.Size = new Size(49, 20);
            label10.TabIndex = 19;
            label10.Text = "Status";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(736, 139);
            label9.Name = "label9";
            label9.Size = new Size(91, 20);
            label9.TabIndex = 17;
            label9.Text = "IRD Number";
            // 
            // txt_IrdNo
            // 
            txt_IrdNo.Location = new Point(858, 136);
            txt_IrdNo.Name = "txt_IrdNo";
            txt_IrdNo.Size = new Size(201, 27);
            txt_IrdNo.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(368, 139);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 15;
            label8.Text = "Office Extension";
            // 
            // txt_Extension
            // 
            txt_Extension.Location = new Point(490, 136);
            txt_Extension.Name = "txt_Extension";
            txt_Extension.Size = new Size(201, 27);
            txt_Extension.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 139);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 13;
            label7.Text = "Cell Phone";
            // 
            // txt_CellPone
            // 
            txt_CellPone.Location = new Point(131, 136);
            txt_CellPone.Name = "txt_CellPone";
            txt_CellPone.Size = new Size(201, 27);
            txt_CellPone.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(736, 85);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 11;
            label6.Text = "Home Phone";
            // 
            // txt_HomePhone
            // 
            txt_HomePhone.Location = new Point(858, 82);
            txt_HomePhone.Name = "txt_HomePhone";
            txt_HomePhone.Size = new Size(201, 27);
            txt_HomePhone.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(368, 84);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 9;
            label5.Text = "Middle Initial";
            // 
            // txt_Middle_Initial
            // 
            txt_Middle_Initial.Location = new Point(490, 81);
            txt_Middle_Initial.Name = "txt_Middle_Initial";
            txt_Middle_Initial.Size = new Size(201, 27);
            txt_Middle_Initial.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 85);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 7;
            label4.Text = "Last Name";
            // 
            // txt_LastName
            // 
            txt_LastName.Location = new Point(131, 78);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.Size = new Size(201, 27);
            txt_LastName.TabIndex = 6;
            // 
            // txt_firstName
            // 
            txt_firstName.Location = new Point(858, 20);
            txt_firstName.Name = "txt_firstName";
            txt_firstName.Size = new Size(201, 27);
            txt_firstName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(736, 23);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 4;
            label3.Text = "First Name";
            // 
            // cmbTitle
            // 
            cmbTitle.FormattingEnabled = true;
            cmbTitle.Location = new Point(490, 23);
            cmbTitle.Name = "cmbTitle";
            cmbTitle.Size = new Size(201, 28);
            cmbTitle.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(368, 23);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 2;
            label2.Text = "Title";
            // 
            // cmbStaffType
            // 
            cmbStaffType.FormattingEnabled = true;
            cmbStaffType.Location = new Point(131, 20);
            cmbStaffType.Name = "cmbStaffType";
            cmbStaffType.Size = new Size(201, 28);
            cmbStaffType.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 23);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Staff Type";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grd_Staff);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1097, 353);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Staff Details";
            // 
            // grd_Staff
            // 
            grd_Staff.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grd_Staff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd_Staff.Location = new Point(9, 26);
            grd_Staff.Name = "grd_Staff";
            grd_Staff.RowHeadersWidth = 51;
            grd_Staff.RowTemplate.Height = 29;
            grd_Staff.Size = new Size(1076, 321);
            grd_Staff.TabIndex = 0;
            grd_Staff.RowStateChanged += grd_Staff_RowStateChanged;
            // 
            // frm_Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 722);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_Staff";
            Text = "Staff Management";
            Load += frm_Staff_Load;
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd_Staff).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private DataGridView grd_Staff;
        private ComboBox cmbStaffType;
        private Label label1;
        private Label label5;
        private TextBox txt_Middle_Initial;
        private Label label4;
        private TextBox txt_LastName;
        private TextBox txt_firstName;
        private Label label3;
        private ComboBox cmbTitle;
        private Label label2;
        private Label label6;
        private TextBox txt_HomePhone;
        private Label label9;
        private TextBox txt_IrdNo;
        private Label label8;
        private TextBox txt_Extension;
        private Label label7;
        private TextBox txt_CellPone;
        private ComboBox cmbManger;
        private Label label11;
        private ComboBox cmbStatus;
        private Label label10;
        private Button btnClear;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnCreate;
        private Button button1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}