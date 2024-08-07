namespace GstErpPlacement
{
    partial class frmLogin
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
            this.lblLogin = new Siticone.UI.WinForms.SiticoneLabel();
            this.btnLogin = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.txtUserName = new Siticone.UI.WinForms.SiticoneTextBox();
            this.txtPassword = new Siticone.UI.WinForms.SiticoneTextBox();
            this.siticoneGradientPanel1 = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.cmbbxType = new Siticone.UI.WinForms.SiticoneComboBox();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.Check = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.lblValidationMessage = new Siticone.UI.WinForms.SiticoneLabel();
            this.lblEmailvalidation = new Siticone.UI.WinForms.SiticoneLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.siticoneGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = false;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(241, 30);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(147, 54);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BorderColor = System.Drawing.Color.White;
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.BorderThickness = 3;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoveredState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(72, 549);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(180, 45);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "UserName";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.Parent = this.txtUserName;
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.FocusedState.Parent = this.txtUserName;
            this.txtUserName.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.HoveredState.Parent = this.txtUserName;
            this.txtUserName.Location = new System.Drawing.Point(72, 264);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.SelectedText = "";
            this.txtUserName.ShadowDecoration.Parent = this.txtUserName;
            this.txtUserName.Size = new System.Drawing.Size(267, 44);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "Password";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoveredState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(72, 431);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(267, 44);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.siticoneGradientPanel1.Controls.Add(this.cmbbxType);
            this.siticoneGradientPanel1.Controls.Add(this.siticoneLabel1);
            this.siticoneGradientPanel1.Controls.Add(this.Check);
            this.siticoneGradientPanel1.Controls.Add(this.lblValidationMessage);
            this.siticoneGradientPanel1.Controls.Add(this.lblEmailvalidation);
            this.siticoneGradientPanel1.Controls.Add(this.label1);
            this.siticoneGradientPanel1.Controls.Add(this.lblPassword);
            this.siticoneGradientPanel1.Controls.Add(this.lblUserName);
            this.siticoneGradientPanel1.Controls.Add(this.lblLogin);
            this.siticoneGradientPanel1.Controls.Add(this.txtPassword);
            this.siticoneGradientPanel1.Controls.Add(this.btnLogin);
            this.siticoneGradientPanel1.Controls.Add(this.txtUserName);
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(25, 12);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.ShadowDecoration.Parent = this.siticoneGradientPanel1;
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(649, 629);
            this.siticoneGradientPanel1.TabIndex = 7;
            this.siticoneGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.siticoneGradientPanel1_Paint);
            // 
            // cmbbxType
            // 
            this.cmbbxType.BackColor = System.Drawing.Color.Transparent;
            this.cmbbxType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbbxType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbbxType.FormattingEnabled = true;
            this.cmbbxType.HoveredState.Parent = this.cmbbxType;
            this.cmbbxType.ItemHeight = 30;
            this.cmbbxType.ItemsAppearance.Parent = this.cmbbxType;
            this.cmbbxType.Location = new System.Drawing.Point(72, 131);
            this.cmbbxType.Name = "cmbbxType";
            this.cmbbxType.ShadowDecoration.Parent = this.cmbbxType;
            this.cmbbxType.Size = new System.Drawing.Size(267, 36);
            this.cmbbxType.TabIndex = 14;
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.AutoSize = false;
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.Location = new System.Drawing.Point(72, 88);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(93, 27);
            this.siticoneLabel1.TabIndex = 13;
            this.siticoneLabel1.Text = "Type";
            // 
            // Check
            // 
            this.Check.AutoSize = true;
            this.Check.BackColor = System.Drawing.Color.RoyalBlue;
            this.Check.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Check.CheckedState.BorderRadius = 2;
            this.Check.CheckedState.BorderThickness = 0;
            this.Check.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Check.CheckMarkColor = System.Drawing.Color.Black;
            this.Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check.Location = new System.Drawing.Point(370, 446);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(175, 29);
            this.Check.TabIndex = 12;
            this.Check.Text = "Show Password";
            this.Check.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Check.UncheckedState.BorderRadius = 2;
            this.Check.UncheckedState.BorderThickness = 0;
            this.Check.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Check.UseVisualStyleBackColor = false;
            this.Check.CheckedChanged += new System.EventHandler(this.Check_CheckedChanged);
            // 
            // lblValidationMessage
            // 
            this.lblValidationMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblValidationMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidationMessage.Location = new System.Drawing.Point(72, 496);
            this.lblValidationMessage.Name = "lblValidationMessage";
            this.lblValidationMessage.Size = new System.Drawing.Size(178, 27);
            this.lblValidationMessage.TabIndex = 11;
            this.lblValidationMessage.Text = "password Validation";
            this.lblValidationMessage.Visible = false;
            // 
            // lblEmailvalidation
            // 
            this.lblEmailvalidation.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailvalidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailvalidation.Location = new System.Drawing.Point(72, 327);
            this.lblEmailvalidation.Name = "lblEmailvalidation";
            this.lblEmailvalidation.Size = new System.Drawing.Size(133, 27);
            this.lblEmailvalidation.TabIndex = 10;
            this.lblEmailvalidation.Text = "Emailvalidation";
            this.lblEmailvalidation.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 569);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "ForgotPassword";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(67, 387);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(98, 25);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(67, 219);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(105, 25);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "UserName";
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(699, 660);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.siticoneGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneLabel lblLogin;
        private Siticone.UI.WinForms.SiticoneTextBox txtUserName;
        private Siticone.UI.WinForms.SiticoneTextBox txtPassword;
        private Siticone.UI.WinForms.SiticoneGradientButton btnLogin;
        private Siticone.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneLabel lblEmailvalidation;
        private Siticone.UI.WinForms.SiticoneLabel lblValidationMessage;
        private Siticone.UI.WinForms.SiticoneCheckBox Check;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private Siticone.UI.WinForms.SiticoneComboBox cmbbxType;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
    }
}

