namespace A1_ShopManagement
{
    partial class frmUser_Register
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
            this.cmbbxContry = new System.Windows.Forms.ComboBox();
            this.lblContry = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbbxCity = new System.Windows.Forms.ComboBox();
            this.cmbbxState = new System.Windows.Forms.ComboBox();
            this.rdbtnOther = new System.Windows.Forms.RadioButton();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.cmbbxType = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbbxContry
            // 
            this.cmbbxContry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxContry.FormattingEnabled = true;
            this.cmbbxContry.Items.AddRange(new object[] {
            "India",
            "Japan",
            "America",
            "Russia",
            "Germany"});
            this.cmbbxContry.Location = new System.Drawing.Point(364, 297);
            this.cmbbxContry.Name = "cmbbxContry";
            this.cmbbxContry.Size = new System.Drawing.Size(213, 30);
            this.cmbbxContry.TabIndex = 39;
            this.cmbbxContry.SelectedIndexChanged += new System.EventHandler(this.cmbbxContry_SelectedIndexChanged);
            // 
            // lblContry
            // 
            this.lblContry.AutoSize = true;
            this.lblContry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContry.Location = new System.Drawing.Point(206, 303);
            this.lblContry.Name = "lblContry";
            this.lblContry.Size = new System.Drawing.Size(74, 24);
            this.lblContry.TabIndex = 38;
            this.lblContry.Text = "Contry :";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(364, 462);
            this.txtPassword.MaxLength = 30;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(213, 28);
            this.txtPassword.TabIndex = 37;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // cmbbxCity
            // 
            this.cmbbxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCity.FormattingEnabled = true;
            this.cmbbxCity.Location = new System.Drawing.Point(364, 410);
            this.cmbbxCity.Name = "cmbbxCity";
            this.cmbbxCity.Size = new System.Drawing.Size(213, 30);
            this.cmbbxCity.TabIndex = 36;
            this.cmbbxCity.SelectedIndexChanged += new System.EventHandler(this.cmbbxCity_SelectedIndexChanged);
            // 
            // cmbbxState
            // 
            this.cmbbxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxState.FormattingEnabled = true;
            this.cmbbxState.Location = new System.Drawing.Point(364, 355);
            this.cmbbxState.Name = "cmbbxState";
            this.cmbbxState.Size = new System.Drawing.Size(213, 30);
            this.cmbbxState.TabIndex = 35;
            this.cmbbxState.SelectedIndexChanged += new System.EventHandler(this.cmbbxState_SelectedIndexChanged);
            // 
            // rdbtnOther
            // 
            this.rdbtnOther.AutoSize = true;
            this.rdbtnOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnOther.Location = new System.Drawing.Point(532, 249);
            this.rdbtnOther.Name = "rdbtnOther";
            this.rdbtnOther.Size = new System.Drawing.Size(78, 28);
            this.rdbtnOther.TabIndex = 34;
            this.rdbtnOther.TabStop = true;
            this.rdbtnOther.Text = "Other";
            this.rdbtnOther.UseVisualStyleBackColor = true;
            this.rdbtnOther.CheckedChanged += new System.EventHandler(this.rdbtnOther_CheckedChanged);
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnFemale.Location = new System.Drawing.Point(431, 249);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(95, 28);
            this.rdbtnFemale.TabIndex = 33;
            this.rdbtnFemale.TabStop = true;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            this.rdbtnFemale.CheckedChanged += new System.EventHandler(this.rdbtnFemale_CheckedChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(364, 198);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(213, 28);
            this.txtEmail.TabIndex = 32;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(206, 466);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(102, 24);
            this.lblPassword.TabIndex = 31;
            this.lblPassword.Text = "Password :";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(206, 416);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(50, 24);
            this.lblCity.TabIndex = 30;
            this.lblCity.Text = "City :";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(206, 361);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(61, 24);
            this.lblState.TabIndex = 29;
            this.lblState.Text = "State :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(206, 252);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(84, 24);
            this.lblGender.TabIndex = 28;
            this.lblGender.Text = "Gender :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(206, 202);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 24);
            this.lblEmail.TabIndex = 27;
            this.lblEmail.Text = "E-Mail :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(206, 157);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 24);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Name :";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(413, 530);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 40);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(238, 530);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(99, 40);
            this.btnRegister.TabIndex = 24;
            this.btnRegister.Text = "Register ";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnMale.Location = new System.Drawing.Point(353, 248);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(72, 28);
            this.rdbtnMale.TabIndex = 23;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            this.rdbtnMale.CheckedChanged += new System.EventHandler(this.rdbtnMale_CheckedChanged);
            // 
            // cmbbxType
            // 
            this.cmbbxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxType.FormattingEnabled = true;
            this.cmbbxType.Items.AddRange(new object[] {
            "Admin",
            "Customer"});
            this.cmbbxType.Location = new System.Drawing.Point(364, 99);
            this.cmbbxType.Name = "cmbbxType";
            this.cmbbxType.Size = new System.Drawing.Size(213, 30);
            this.cmbbxType.TabIndex = 22;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(364, 153);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 28);
            this.txtName.TabIndex = 21;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(206, 105);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(63, 24);
            this.lblType.TabIndex = 20;
            this.lblType.Text = "Type :";
            // 
            // frmUser_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 705);
            this.Controls.Add(this.cmbbxContry);
            this.Controls.Add(this.lblContry);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cmbbxCity);
            this.Controls.Add(this.cmbbxState);
            this.Controls.Add(this.rdbtnOther);
            this.Controls.Add(this.rdbtnFemale);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.rdbtnMale);
            this.Controls.Add(this.cmbbxType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblType);
            this.Name = "frmUser_Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.frmUser_Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbbxContry;
        private System.Windows.Forms.Label lblContry;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbbxCity;
        private System.Windows.Forms.ComboBox cmbbxState;
        private System.Windows.Forms.RadioButton rdbtnOther;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.ComboBox cmbbxType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblType;
    }
}