namespace ShopManagementA1
{
    partial class RegisterUser
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
            this.lblType = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbbxType = new System.Windows.Forms.ComboBox();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.rdbtnOther = new System.Windows.Forms.RadioButton();
            this.cmbbxState = new System.Windows.Forms.ComboBox();
            this.cmbbxCity = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbbxContry = new System.Windows.Forms.ComboBox();
            this.lblContry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(106, 65);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(63, 24);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type :";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(264, 113);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 28);
            this.txtName.TabIndex = 1;
            // 
            // cmbbxType
            // 
            this.cmbbxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxType.FormattingEnabled = true;
            this.cmbbxType.Items.AddRange(new object[] {
            "Admin",
            "Customer"});
            this.cmbbxType.Location = new System.Drawing.Point(264, 59);
            this.cmbbxType.Name = "cmbbxType";
            this.cmbbxType.Size = new System.Drawing.Size(213, 30);
            this.cmbbxType.TabIndex = 2;
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnMale.Location = new System.Drawing.Point(253, 208);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(72, 28);
            this.rdbtnMale.TabIndex = 3;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            this.rdbtnMale.CheckedChanged += new System.EventHandler(this.rdbtnMale_CheckedChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(138, 490);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(99, 40);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register ";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(313, 490);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 40);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(106, 117);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 24);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(106, 162);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 24);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-Mail :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(106, 212);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(84, 24);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Gender :";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(106, 321);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(61, 24);
            this.lblState.TabIndex = 9;
            this.lblState.Text = "State :";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(106, 376);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(50, 24);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "City :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(106, 426);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(102, 24);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password :";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(264, 158);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(213, 28);
            this.txtEmail.TabIndex = 12;
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnFemale.Location = new System.Drawing.Point(331, 209);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(95, 28);
            this.rdbtnFemale.TabIndex = 13;
            this.rdbtnFemale.TabStop = true;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            this.rdbtnFemale.CheckedChanged += new System.EventHandler(this.rdbtnFemale_CheckedChanged);
            // 
            // rdbtnOther
            // 
            this.rdbtnOther.AutoSize = true;
            this.rdbtnOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnOther.Location = new System.Drawing.Point(432, 209);
            this.rdbtnOther.Name = "rdbtnOther";
            this.rdbtnOther.Size = new System.Drawing.Size(78, 28);
            this.rdbtnOther.TabIndex = 14;
            this.rdbtnOther.TabStop = true;
            this.rdbtnOther.Text = "Other";
            this.rdbtnOther.UseVisualStyleBackColor = true;
            this.rdbtnOther.CheckedChanged += new System.EventHandler(this.rdbtnOther_CheckedChanged);
            // 
            // cmbbxState
            // 
            this.cmbbxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxState.FormattingEnabled = true;
            this.cmbbxState.Location = new System.Drawing.Point(264, 315);
            this.cmbbxState.Name = "cmbbxState";
            this.cmbbxState.Size = new System.Drawing.Size(213, 30);
            this.cmbbxState.TabIndex = 15;
            this.cmbbxState.SelectedIndexChanged += new System.EventHandler(this.cmbbxState_SelectedIndexChanged);
            // 
            // cmbbxCity
            // 
            this.cmbbxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCity.FormattingEnabled = true;
            this.cmbbxCity.Location = new System.Drawing.Point(264, 370);
            this.cmbbxCity.Name = "cmbbxCity";
            this.cmbbxCity.Size = new System.Drawing.Size(213, 30);
            this.cmbbxCity.TabIndex = 16;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(264, 422);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(213, 28);
            this.txtPassword.TabIndex = 17;
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
            this.cmbbxContry.Location = new System.Drawing.Point(264, 257);
            this.cmbbxContry.Name = "cmbbxContry";
            this.cmbbxContry.Size = new System.Drawing.Size(213, 30);
            this.cmbbxContry.TabIndex = 19;
            this.cmbbxContry.SelectedIndexChanged += new System.EventHandler(this.cmbbxContry_SelectedIndexChanged);
            // 
            // lblContry
            // 
            this.lblContry.AutoSize = true;
            this.lblContry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContry.Location = new System.Drawing.Point(106, 263);
            this.lblContry.Name = "lblContry";
            this.lblContry.Size = new System.Drawing.Size(74, 24);
            this.lblContry.TabIndex = 18;
            this.lblContry.Text = "Contry :";
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 579);
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
            this.Name = "RegisterUser";
            this.Text = "RegisterUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbbxType;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.RadioButton rdbtnOther;
        private System.Windows.Forms.ComboBox cmbbxState;
        private System.Windows.Forms.ComboBox cmbbxCity;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbbxContry;
        private System.Windows.Forms.Label lblContry;
    }
}