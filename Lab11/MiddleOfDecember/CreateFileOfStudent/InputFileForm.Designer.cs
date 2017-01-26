namespace CreateFileOfStudent
{
    partial class InputFileForm
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
            this.uiFileInput = new FileO.UIFileInput();
            this.SuspendLayout();
            // 
            // uiFileInput
            // 
            this.uiFileInput.Course = "";
            this.uiFileInput.FirstName = "";
            this.uiFileInput.Grade = "";
            this.uiFileInput.Id = "";
            this.uiFileInput.LastName = "";
            this.uiFileInput.Location = new System.Drawing.Point(31, 24);
            this.uiFileInput.Name = "uiFileInput";
            this.uiFileInput.Size = new System.Drawing.Size(328, 170);
            this.uiFileInput.TabIndex = 0;
            this.uiFileInput.FileOpen += new FileO.FileOpenEventHandler(this.SelectFileName);
            // 
            // InputFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 299);
            this.Controls.Add(this.uiFileInput);
            this.Name = "InputFileForm";
            this.Text = "CreateSErializable records";
            this.ResumeLayout(false);

        }

        #endregion

        private FileO.UIFileInput uiFileInput;
    }
}

