namespace Hospital_MS
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.DocBtn = new System.Windows.Forms.Button();
            this.PatientBtn = new System.Windows.Forms.Button();
            this.DiagBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.CrossBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOME";
            // 
            // DocBtn
            // 
            this.DocBtn.BackColor = System.Drawing.SystemColors.Control;
            this.DocBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DocBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocBtn.Location = new System.Drawing.Point(405, 130);
            this.DocBtn.Name = "DocBtn";
            this.DocBtn.Size = new System.Drawing.Size(139, 36);
            this.DocBtn.TabIndex = 6;
            this.DocBtn.Text = "Doctor";
            this.DocBtn.UseVisualStyleBackColor = false;
            this.DocBtn.Click += new System.EventHandler(this.DocBtn_Click);
            // 
            // PatientBtn
            // 
            this.PatientBtn.BackColor = System.Drawing.SystemColors.Control;
            this.PatientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PatientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientBtn.Location = new System.Drawing.Point(405, 214);
            this.PatientBtn.Name = "PatientBtn";
            this.PatientBtn.Size = new System.Drawing.Size(139, 36);
            this.PatientBtn.TabIndex = 7;
            this.PatientBtn.Text = "Patient";
            this.PatientBtn.UseVisualStyleBackColor = false;
            this.PatientBtn.Click += new System.EventHandler(this.PatientBtn_Click);
            // 
            // DiagBtn
            // 
            this.DiagBtn.BackColor = System.Drawing.SystemColors.Control;
            this.DiagBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DiagBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagBtn.Location = new System.Drawing.Point(405, 298);
            this.DiagBtn.Name = "DiagBtn";
            this.DiagBtn.Size = new System.Drawing.Size(139, 36);
            this.DiagBtn.TabIndex = 8;
            this.DiagBtn.Text = "Diagnosis";
            this.DiagBtn.UseVisualStyleBackColor = false;
            this.DiagBtn.Click += new System.EventHandler(this.DiagBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.SystemColors.Control;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(405, 375);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(139, 36);
            this.LogoutBtn.TabIndex = 9;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // CrossBtn
            // 
            this.CrossBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CrossBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrossBtn.Location = new System.Drawing.Point(912, -3);
            this.CrossBtn.Name = "CrossBtn";
            this.CrossBtn.Size = new System.Drawing.Size(52, 48);
            this.CrossBtn.TabIndex = 10;
            this.CrossBtn.Text = "X";
            this.CrossBtn.UseVisualStyleBackColor = true;
            this.CrossBtn.Click += new System.EventHandler(this.CrossBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(992, 555);
            this.Controls.Add(this.CrossBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.DiagBtn);
            this.Controls.Add(this.PatientBtn);
            this.Controls.Add(this.DocBtn);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DocBtn;
        private System.Windows.Forms.Button PatientBtn;
        private System.Windows.Forms.Button DiagBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button CrossBtn;
    }
}