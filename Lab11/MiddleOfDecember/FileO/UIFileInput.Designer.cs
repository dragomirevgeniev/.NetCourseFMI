namespace FileO
{
    partial class UIFileInput
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnReadFromFile = new System.Windows.Forms.Button();
            this.btnWriteInFile = new System.Windows.Forms.Button();
            this.btnButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(127, 51);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 0;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(24, 51);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(55, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "LastName";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(24, 25);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(54, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "FirstName";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(127, 25);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(127, 103);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(100, 20);
            this.txtCourse.TabIndex = 5;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(24, 103);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(40, 13);
            this.lblCourse.TabIndex = 4;
            this.lblCourse.Text = "Course";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(127, 77);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 7;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(24, 77);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(127, 129);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(100, 20);
            this.txtGrade.TabIndex = 9;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(24, 129);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(36, 13);
            this.lblGrade.TabIndex = 8;
            this.lblGrade.Text = "Grade";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(243, 83);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(85, 23);
            this.btnOpenFile.TabIndex = 10;
            this.btnOpenFile.Text = "OpenFile";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnReadFromFile
            // 
            this.btnReadFromFile.Location = new System.Drawing.Point(240, 112);
            this.btnReadFromFile.Name = "btnReadFromFile";
            this.btnReadFromFile.Size = new System.Drawing.Size(85, 23);
            this.btnReadFromFile.TabIndex = 11;
            this.btnReadFromFile.Text = "ReadFromFile";
            this.btnReadFromFile.UseVisualStyleBackColor = true;
            this.btnReadFromFile.Click += new System.EventHandler(this.btnReadFromFile_Click);
            // 
            // btnWriteInFile
            // 
            this.btnWriteInFile.Location = new System.Drawing.Point(240, 54);
            this.btnWriteInFile.Name = "btnWriteInFile";
            this.btnWriteInFile.Size = new System.Drawing.Size(85, 23);
            this.btnWriteInFile.TabIndex = 12;
            this.btnWriteInFile.Text = "WriteInFile";
            this.btnWriteInFile.UseVisualStyleBackColor = true;
            this.btnWriteInFile.Click += new System.EventHandler(this.btnWriteInFile_Click);
            // 
            // btnButton1
            // 
            this.btnButton1.Location = new System.Drawing.Point(243, 25);
            this.btnButton1.Name = "btnButton1";
            this.btnButton1.Size = new System.Drawing.Size(75, 23);
            this.btnButton1.TabIndex = 13;
            this.btnButton1.Text = "button1";
            this.btnButton1.UseVisualStyleBackColor = true;
            this.btnButton1.Click += new System.EventHandler(this.btnButton1_Click);
            // 
            // UIFileInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnButton1);
            this.Controls.Add(this.btnWriteInFile);
            this.Controls.Add(this.btnReadFromFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Name = "UIFileInput";
            this.Size = new System.Drawing.Size(328, 170);
            this.Load += new System.EventHandler(this.UIFileInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnReadFromFile;
        private System.Windows.Forms.Button btnWriteInFile;
        private System.Windows.Forms.Button btnButton1;
    }
}
