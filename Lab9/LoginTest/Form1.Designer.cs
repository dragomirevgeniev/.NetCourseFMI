namespace LoginTest
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.loginControl1 = new UsrLibrary.LoginControl();
            this.SuspendLayout();
            // 
            // loginControl1
            // 
            this.loginControl1.Location = new System.Drawing.Point(28, 25);
            this.loginControl1.Name = "loginControl1";
            this.loginControl1.Password = "";
            this.loginControl1.Size = new System.Drawing.Size(235, 164);
            this.loginControl1.TabIndex = 0;
            this.loginControl1.Username = "asdghjkhd";
            this.loginControl1.Login += new UsrLibrary.LoginEventHandler(this.loginControl1_Login);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.loginControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private UsrLibrary.LoginControl loginControl1;
    }
}

