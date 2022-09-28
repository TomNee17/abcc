namespace Entity_Framework_Code_First
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.QLSV = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Them = new System.Windows.Forms.Button();
            this.button_Luu = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Huy = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.dgv_SV = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.Label();
            this.ten = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.button_Image = new System.Windows.Forms.Button();
            this.textID = new System.Windows.Forms.TextBox();
            this.textTen = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.qLSV1DataSet = new Entity_Framework_Code_First.QLSV1DataSet();
            this.qLSV1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new Entity_Framework_Code_First.QLSV1DataSetTableAdapters.StudentsTableAdapter();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picHinh = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSV1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSV1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // QLSV
            // 
            this.QLSV.AutoSize = true;
            this.QLSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLSV.Location = new System.Drawing.Point(12, 12);
            this.QLSV.Name = "QLSV";
            this.QLSV.Size = new System.Drawing.Size(301, 39);
            this.QLSV.TabIndex = 0;
            this.QLSV.Text = "Quản Lý Sinh Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picHinh);
            this.groupBox1.Controls.Add(this.textPhone);
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(this.textTen);
            this.groupBox1.Controls.Add(this.textID);
            this.groupBox1.Controls.Add(this.button_Image);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.ten);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 299);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(12, 378);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(75, 23);
            this.button_Them.TabIndex = 6;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            // 
            // button_Luu
            // 
            this.button_Luu.Location = new System.Drawing.Point(12, 415);
            this.button_Luu.Name = "button_Luu";
            this.button_Luu.Size = new System.Drawing.Size(75, 23);
            this.button_Luu.TabIndex = 9;
            this.button_Luu.Text = "Lưu";
            this.button_Luu.UseVisualStyleBackColor = true;
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(118, 378);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(75, 23);
            this.button_Xoa.TabIndex = 7;
            this.button_Xoa.Text = "Xoá";
            this.button_Xoa.UseVisualStyleBackColor = true;
            // 
            // button_Huy
            // 
            this.button_Huy.Location = new System.Drawing.Point(118, 415);
            this.button_Huy.Name = "button_Huy";
            this.button_Huy.Size = new System.Drawing.Size(75, 23);
            this.button_Huy.TabIndex = 10;
            this.button_Huy.Text = "Huỷ";
            this.button_Huy.UseVisualStyleBackColor = true;
            // 
            // button_Sua
            // 
            this.button_Sua.Location = new System.Drawing.Point(229, 378);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(75, 23);
            this.button_Sua.TabIndex = 8;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = true;
            // 
            // button_Thoat
            // 
            this.button_Thoat.Location = new System.Drawing.Point(229, 415);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(75, 23);
            this.button_Thoat.TabIndex = 11;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = true;
            // 
            // dgv_SV
            // 
            this.dgv_SV.AutoGenerateColumns = false;
            this.dgv_SV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn});
            this.dgv_SV.DataSource = this.studentsBindingSource;
            this.dgv_SV.Location = new System.Drawing.Point(327, 12);
            this.dgv_SV.Name = "dgv_SV";
            this.dgv_SV.RowHeadersWidth = 51;
            this.dgv_SV.RowTemplate.Height = 24;
            this.dgv_SV.Size = new System.Drawing.Size(676, 426);
            this.dgv_SV.TabIndex = 8;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(15, 30);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(20, 16);
            this.id.TabIndex = 0;
            this.id.Text = "ID";
            // 
            // ten
            // 
            this.ten.AutoSize = true;
            this.ten.Location = new System.Drawing.Point(15, 86);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(31, 16);
            this.ten.TabIndex = 1;
            this.ten.Text = "Tên";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(15, 138);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(41, 16);
            this.email.TabIndex = 2;
            this.email.Text = "Email";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(15, 196);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(46, 16);
            this.phone.TabIndex = 3;
            this.phone.Text = "Phone";
            // 
            // button_Image
            // 
            this.button_Image.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "image", true));
            this.button_Image.Location = new System.Drawing.Point(69, 244);
            this.button_Image.Name = "button_Image";
            this.button_Image.Size = new System.Drawing.Size(75, 23);
            this.button_Image.TabIndex = 5;
            this.button_Image.Text = "Image";
            this.button_Image.UseVisualStyleBackColor = true;
            this.button_Image.Click += new System.EventHandler(this.button_Image_Click);
            // 
            // textID
            // 
            this.textID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "studentID", true));
            this.textID.Location = new System.Drawing.Point(81, 30);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 22);
            this.textID.TabIndex = 1;
            // 
            // textTen
            // 
            this.textTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "name", true));
            this.textTen.Location = new System.Drawing.Point(81, 86);
            this.textTen.Name = "textTen";
            this.textTen.Size = new System.Drawing.Size(100, 22);
            this.textTen.TabIndex = 2;
            // 
            // textEmail
            // 
            this.textEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "email", true));
            this.textEmail.Location = new System.Drawing.Point(81, 138);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 22);
            this.textEmail.TabIndex = 3;
            // 
            // textPhone
            // 
            this.textPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "phoneNumber", true));
            this.textPhone.Location = new System.Drawing.Point(81, 190);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(100, 22);
            this.textPhone.TabIndex = 4;
            // 
            // qLSV1DataSet
            // 
            this.qLSV1DataSet.DataSetName = "QLSV1DataSet";
            this.qLSV1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLSV1DataSetBindingSource
            // 
            this.qLSV1DataSetBindingSource.DataSource = this.qLSV1DataSet;
            this.qLSV1DataSetBindingSource.Position = 0;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.qLSV1DataSetBindingSource;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "studentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "studentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "image";
            this.imageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            this.imageDataGridViewTextBoxColumn.Width = 125;
            // 
            // picHinh
            // 
            this.picHinh.Location = new System.Drawing.Point(187, 21);
            this.picHinh.Name = "picHinh";
            this.picHinh.Size = new System.Drawing.Size(105, 246);
            this.picHinh.TabIndex = 6;
            this.picHinh.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 450);
            this.Controls.Add(this.dgv_SV);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.button_Sua);
            this.Controls.Add(this.button_Huy);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Luu);
            this.Controls.Add(this.button_Them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.QLSV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSV1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSV1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QLSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_Luu;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Button button_Huy;
        private System.Windows.Forms.Button button_Sua;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.DataGridView dgv_SV;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textTen;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button button_Image;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label ten;
        private System.Windows.Forms.BindingSource qLSV1DataSetBindingSource;
        private QLSV1DataSet qLSV1DataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private QLSV1DataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox picHinh;
    }
}

