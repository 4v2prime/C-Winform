namespace GstErpPlacement
{
    partial class frmExam
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExam));
            this.grdvExam = new Siticone.UI.WinForms.SiticoneDataGridView();
            this.btnExternal = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.pnlExternalExam = new Siticone.UI.WinForms.SiticonePanel();
            this.btnExportPdf = new Siticone.UI.WinForms.SiticoneButton();
            this.btnExel = new Siticone.UI.WinForms.SiticoneButton();
            this.btnFilter = new Siticone.UI.WinForms.SiticoneButton();
            this.btnDelete = new Siticone.UI.WinForms.SiticoneButton();
            this.btnRefresh = new Siticone.UI.WinForms.SiticoneButton();
            this.btnAddExam = new Siticone.UI.WinForms.SiticoneButton();
            this.txtSearch = new Siticone.UI.WinForms.SiticoneTextBox();
            this.btnAllExam = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.btnConductedExam = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.btnPendingExam = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.btnAssignedExam = new Siticone.UI.WinForms.SiticoneGradientButton();
            this.pnlFilter = new Siticone.UI.WinForms.SiticonePanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbbxFilterExam = new Siticone.UI.WinForms.SiticoneComboBox();
            this.cmbbxFilterCourse = new Siticone.UI.WinForms.SiticoneComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdvExam)).BeginInit();
            this.pnlExternalExam.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdvExam
            // 
            this.grdvExam.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grdvExam.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdvExam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdvExam.BackgroundColor = System.Drawing.Color.White;
            this.grdvExam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdvExam.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdvExam.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdvExam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdvExam.ColumnHeadersHeight = 27;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdvExam.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdvExam.EnableHeadersVisualStyles = false;
            this.grdvExam.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdvExam.Location = new System.Drawing.Point(31, 250);
            this.grdvExam.Name = "grdvExam";
            this.grdvExam.RowHeadersVisible = false;
            this.grdvExam.RowHeadersWidth = 51;
            this.grdvExam.RowTemplate.Height = 24;
            this.grdvExam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdvExam.ShowEditingIcon = false;
            this.grdvExam.Size = new System.Drawing.Size(1848, 389);
            this.grdvExam.TabIndex = 2;
            this.grdvExam.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.grdvExam.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdvExam.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdvExam.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdvExam.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdvExam.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdvExam.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdvExam.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdvExam.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grdvExam.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdvExam.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdvExam.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdvExam.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdvExam.ThemeStyle.HeaderStyle.Height = 27;
            this.grdvExam.ThemeStyle.ReadOnly = false;
            this.grdvExam.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdvExam.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdvExam.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdvExam.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdvExam.ThemeStyle.RowsStyle.Height = 24;
            this.grdvExam.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdvExam.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdvExam.Visible = false;
            this.grdvExam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdvExam_CellContentClick);
            // 
            // btnExternal
            // 
            this.btnExternal.BorderColor = System.Drawing.Color.White;
            this.btnExternal.BorderRadius = 15;
            this.btnExternal.BorderThickness = 3;
            this.btnExternal.CheckedState.Parent = this.btnExternal;
            this.btnExternal.CustomImages.Parent = this.btnExternal;
            this.btnExternal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnExternal.ForeColor = System.Drawing.Color.White;
            this.btnExternal.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnExternal.HoveredState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnExternal.HoveredState.Parent = this.btnExternal;
            this.btnExternal.Location = new System.Drawing.Point(1536, 43);
            this.btnExternal.Name = "btnExternal";
            this.btnExternal.ShadowDecoration.Parent = this.btnExternal;
            this.btnExternal.Size = new System.Drawing.Size(208, 49);
            this.btnExternal.TabIndex = 4;
            this.btnExternal.Text = "External";
            this.btnExternal.Click += new System.EventHandler(this.btnExternal_Click);
            this.btnExternal.Leave += new System.EventHandler(this.btnExternal_Leave);
            // 
            // pnlExternalExam
            // 
            this.pnlExternalExam.BorderColor = System.Drawing.Color.Transparent;
            this.pnlExternalExam.BorderThickness = 1;
            this.pnlExternalExam.Controls.Add(this.btnExportPdf);
            this.pnlExternalExam.Controls.Add(this.btnExel);
            this.pnlExternalExam.Controls.Add(this.btnFilter);
            this.pnlExternalExam.Controls.Add(this.btnDelete);
            this.pnlExternalExam.Controls.Add(this.btnRefresh);
            this.pnlExternalExam.Controls.Add(this.btnAddExam);
            this.pnlExternalExam.Controls.Add(this.txtSearch);
            this.pnlExternalExam.Location = new System.Drawing.Point(213, 24);
            this.pnlExternalExam.Name = "pnlExternalExam";
            this.pnlExternalExam.ShadowDecoration.Parent = this.pnlExternalExam;
            this.pnlExternalExam.Size = new System.Drawing.Size(731, 49);
            this.pnlExternalExam.TabIndex = 5;
            this.pnlExternalExam.Visible = false;
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportPdf.BorderColor = System.Drawing.Color.Transparent;
            this.btnExportPdf.BorderThickness = 1;
            this.btnExportPdf.CheckedState.Parent = this.btnExportPdf;
            this.btnExportPdf.CustomImages.Parent = this.btnExportPdf;
            this.btnExportPdf.FillColor = System.Drawing.Color.White;
            this.btnExportPdf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnExportPdf.ForeColor = System.Drawing.Color.Black;
            this.btnExportPdf.HoveredState.Parent = this.btnExportPdf;
            this.btnExportPdf.Image = ((System.Drawing.Image)(resources.GetObject("btnExportPdf.Image")));
            this.btnExportPdf.ImageSize = new System.Drawing.Size(26, 28);
            this.btnExportPdf.Location = new System.Drawing.Point(493, 5);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.ShadowDecoration.Parent = this.btnExportPdf;
            this.btnExportPdf.Size = new System.Drawing.Size(48, 39);
            this.btnExportPdf.TabIndex = 2;
            this.btnExportPdf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // btnExel
            // 
            this.btnExel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExel.BorderColor = System.Drawing.Color.Transparent;
            this.btnExel.BorderThickness = 1;
            this.btnExel.CheckedState.Parent = this.btnExel;
            this.btnExel.CustomImages.Parent = this.btnExel;
            this.btnExel.FillColor = System.Drawing.Color.White;
            this.btnExel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnExel.ForeColor = System.Drawing.Color.Black;
            this.btnExel.HoveredState.Parent = this.btnExel;
            this.btnExel.Image = ((System.Drawing.Image)(resources.GetObject("btnExel.Image")));
            this.btnExel.ImageSize = new System.Drawing.Size(26, 28);
            this.btnExel.Location = new System.Drawing.Point(547, 5);
            this.btnExel.Name = "btnExel";
            this.btnExel.ShadowDecoration.Parent = this.btnExel;
            this.btnExel.Size = new System.Drawing.Size(48, 39);
            this.btnExel.TabIndex = 2;
            this.btnExel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnExel.Click += new System.EventHandler(this.btnExel_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFilter.BorderColor = System.Drawing.Color.Transparent;
            this.btnFilter.BorderThickness = 1;
            this.btnFilter.CheckedState.Parent = this.btnFilter;
            this.btnFilter.CustomImages.Parent = this.btnFilter;
            this.btnFilter.FillColor = System.Drawing.Color.White;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.Black;
            this.btnFilter.HoveredState.Parent = this.btnFilter;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.ImageSize = new System.Drawing.Size(26, 28);
            this.btnFilter.Location = new System.Drawing.Point(601, 5);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.ShadowDecoration.Parent = this.btnFilter;
            this.btnFilter.Size = new System.Drawing.Size(48, 39);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.HoveredState.Parent = this.btnDelete;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(28, 28);
            this.btnDelete.Location = new System.Drawing.Point(439, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(48, 39);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.BorderColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BorderThickness = 1;
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.White;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.HoveredState.Parent = this.btnRefresh;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageSize = new System.Drawing.Size(25, 25);
            this.btnRefresh.Location = new System.Drawing.Point(380, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(54, 39);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddExam
            // 
            this.btnAddExam.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddExam.BorderThickness = 1;
            this.btnAddExam.CheckedState.Parent = this.btnAddExam;
            this.btnAddExam.CustomImages.Parent = this.btnAddExam;
            this.btnAddExam.FillColor = System.Drawing.Color.White;
            this.btnAddExam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddExam.ForeColor = System.Drawing.Color.Black;
            this.btnAddExam.HoveredState.Parent = this.btnAddExam;
            this.btnAddExam.Image = ((System.Drawing.Image)(resources.GetObject("btnAddExam.Image")));
            this.btnAddExam.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddExam.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddExam.Location = new System.Drawing.Point(203, 5);
            this.btnAddExam.Name = "btnAddExam";
            this.btnAddExam.ShadowDecoration.Parent = this.btnAddExam;
            this.btnAddExam.Size = new System.Drawing.Size(171, 39);
            this.btnAddExam.TabIndex = 2;
            this.btnAddExam.Text = "Add Exam";
            this.btnAddExam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddExam.Click += new System.EventHandler(this.btnAddExam_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderRadius = 1;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoveredState.Parent = this.txtSearch;
            this.txtSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconLeft")));
            this.txtSearch.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtSearch.Location = new System.Drawing.Point(4, 5);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(194, 39);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAllExam
            // 
            this.btnAllExam.BorderColor = System.Drawing.Color.White;
            this.btnAllExam.BorderRadius = 15;
            this.btnAllExam.BorderThickness = 3;
            this.btnAllExam.CheckedState.Parent = this.btnAllExam;
            this.btnAllExam.CustomImages.Parent = this.btnAllExam;
            this.btnAllExam.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnAllExam.ForeColor = System.Drawing.Color.White;
            this.btnAllExam.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnAllExam.HoveredState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAllExam.HoveredState.Parent = this.btnAllExam;
            this.btnAllExam.Location = new System.Drawing.Point(1536, 115);
            this.btnAllExam.Name = "btnAllExam";
            this.btnAllExam.ShadowDecoration.Parent = this.btnAllExam;
            this.btnAllExam.Size = new System.Drawing.Size(208, 49);
            this.btnAllExam.TabIndex = 4;
            this.btnAllExam.Text = "All Exam";
            this.btnAllExam.Visible = false;
            this.btnAllExam.Click += new System.EventHandler(this.btnAllExam_Click);
            // 
            // btnConductedExam
            // 
            this.btnConductedExam.BorderColor = System.Drawing.Color.White;
            this.btnConductedExam.BorderRadius = 15;
            this.btnConductedExam.BorderThickness = 3;
            this.btnConductedExam.CheckedState.Parent = this.btnConductedExam;
            this.btnConductedExam.CustomImages.Parent = this.btnConductedExam;
            this.btnConductedExam.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnConductedExam.ForeColor = System.Drawing.Color.White;
            this.btnConductedExam.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnConductedExam.HoveredState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnConductedExam.HoveredState.Parent = this.btnConductedExam;
            this.btnConductedExam.Location = new System.Drawing.Point(1158, 115);
            this.btnConductedExam.Name = "btnConductedExam";
            this.btnConductedExam.ShadowDecoration.Parent = this.btnConductedExam;
            this.btnConductedExam.Size = new System.Drawing.Size(256, 49);
            this.btnConductedExam.TabIndex = 4;
            this.btnConductedExam.Text = "Conducted Exam";
            this.btnConductedExam.Visible = false;
            this.btnConductedExam.Click += new System.EventHandler(this.btnConductedExam_Click);
            // 
            // btnPendingExam
            // 
            this.btnPendingExam.BorderColor = System.Drawing.Color.White;
            this.btnPendingExam.BorderRadius = 15;
            this.btnPendingExam.BorderThickness = 3;
            this.btnPendingExam.CheckedState.Parent = this.btnPendingExam;
            this.btnPendingExam.CustomImages.Parent = this.btnPendingExam;
            this.btnPendingExam.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnPendingExam.ForeColor = System.Drawing.Color.White;
            this.btnPendingExam.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnPendingExam.HoveredState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnPendingExam.HoveredState.Parent = this.btnPendingExam;
            this.btnPendingExam.Location = new System.Drawing.Point(825, 115);
            this.btnPendingExam.Name = "btnPendingExam";
            this.btnPendingExam.ShadowDecoration.Parent = this.btnPendingExam;
            this.btnPendingExam.Size = new System.Drawing.Size(232, 49);
            this.btnPendingExam.TabIndex = 4;
            this.btnPendingExam.Text = "Pending Exam";
            this.btnPendingExam.Visible = false;
            this.btnPendingExam.Click += new System.EventHandler(this.btnPendingExam_Click);
            // 
            // btnAssignedExam
            // 
            this.btnAssignedExam.BorderColor = System.Drawing.Color.White;
            this.btnAssignedExam.BorderRadius = 15;
            this.btnAssignedExam.BorderThickness = 3;
            this.btnAssignedExam.CheckedState.Parent = this.btnAssignedExam;
            this.btnAssignedExam.CustomImages.Parent = this.btnAssignedExam;
            this.btnAssignedExam.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnAssignedExam.ForeColor = System.Drawing.Color.White;
            this.btnAssignedExam.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.btnAssignedExam.HoveredState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAssignedExam.HoveredState.Parent = this.btnAssignedExam;
            this.btnAssignedExam.Location = new System.Drawing.Point(443, 115);
            this.btnAssignedExam.Name = "btnAssignedExam";
            this.btnAssignedExam.ShadowDecoration.Parent = this.btnAssignedExam;
            this.btnAssignedExam.Size = new System.Drawing.Size(237, 49);
            this.btnAssignedExam.TabIndex = 4;
            this.btnAssignedExam.Text = "Arranged Exam";
            this.btnAssignedExam.Visible = false;
            this.btnAssignedExam.Click += new System.EventHandler(this.btnAssignedExam_Click);
            this.btnAssignedExam.Leave += new System.EventHandler(this.btnAssignedExam_Leave);
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.Controls.Add(this.cmbbxFilterExam);
            this.pnlFilter.Controls.Add(this.cmbbxFilterCourse);
            this.pnlFilter.Location = new System.Drawing.Point(164, 189);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.ShadowDecoration.Parent = this.pnlFilter;
            this.pnlFilter.Size = new System.Drawing.Size(899, 55);
            this.pnlFilter.TabIndex = 6;
            this.pnlFilter.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Exam :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Course :";
            // 
            // cmbbxFilterExam
            // 
            this.cmbbxFilterExam.BackColor = System.Drawing.Color.Transparent;
            this.cmbbxFilterExam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbbxFilterExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxFilterExam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxFilterExam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbbxFilterExam.FormattingEnabled = true;
            this.cmbbxFilterExam.HoveredState.Parent = this.cmbbxFilterExam;
            this.cmbbxFilterExam.ItemHeight = 30;
            this.cmbbxFilterExam.ItemsAppearance.Parent = this.cmbbxFilterExam;
            this.cmbbxFilterExam.Location = new System.Drawing.Point(510, 4);
            this.cmbbxFilterExam.Name = "cmbbxFilterExam";
            this.cmbbxFilterExam.ShadowDecoration.Parent = this.cmbbxFilterExam;
            this.cmbbxFilterExam.Size = new System.Drawing.Size(322, 36);
            this.cmbbxFilterExam.TabIndex = 7;
            this.cmbbxFilterExam.SelectedIndexChanged += new System.EventHandler(this.cmbbxFilterExam_SelectedIndexChanged);
            this.cmbbxFilterExam.Click += new System.EventHandler(this.cmbbxFilterExam_Click);
            // 
            // cmbbxFilterCourse
            // 
            this.cmbbxFilterCourse.BackColor = System.Drawing.Color.Transparent;
            this.cmbbxFilterCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbbxFilterCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxFilterCourse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxFilterCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbbxFilterCourse.FormattingEnabled = true;
            this.cmbbxFilterCourse.HoveredState.Parent = this.cmbbxFilterCourse;
            this.cmbbxFilterCourse.ItemHeight = 30;
            this.cmbbxFilterCourse.ItemsAppearance.Parent = this.cmbbxFilterCourse;
            this.cmbbxFilterCourse.Location = new System.Drawing.Point(137, 3);
            this.cmbbxFilterCourse.Name = "cmbbxFilterCourse";
            this.cmbbxFilterCourse.ShadowDecoration.Parent = this.cmbbxFilterCourse;
            this.cmbbxFilterCourse.Size = new System.Drawing.Size(267, 36);
            this.cmbbxFilterCourse.TabIndex = 8;
            this.cmbbxFilterCourse.SelectedIndexChanged += new System.EventHandler(this.cmbbxFilterCourse_SelectedIndexChanged);
            this.cmbbxFilterCourse.Click += new System.EventHandler(this.cmbbxFilterCourse_Click);
            // 
            // frmExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 773);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlExternalExam);
            this.Controls.Add(this.btnAssignedExam);
            this.Controls.Add(this.btnPendingExam);
            this.Controls.Add(this.btnConductedExam);
            this.Controls.Add(this.btnAllExam);
            this.Controls.Add(this.btnExternal);
            this.Controls.Add(this.grdvExam);
            this.Name = "frmExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "External Exam";
            this.Load += new System.EventHandler(this.frmExternalExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdvExam)).EndInit();
            this.pnlExternalExam.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.UI.WinForms.SiticoneDataGridView grdvExam;
        private Siticone.UI.WinForms.SiticoneGradientButton btnExternal;
        private Siticone.UI.WinForms.SiticonePanel pnlExternalExam;
        private Siticone.UI.WinForms.SiticoneButton btnAddExam;
        private Siticone.UI.WinForms.SiticoneTextBox txtSearch;
        private Siticone.UI.WinForms.SiticoneButton btnRefresh;
        private Siticone.UI.WinForms.SiticoneButton btnDelete;
        private Siticone.UI.WinForms.SiticoneGradientButton btnAllExam;
        private Siticone.UI.WinForms.SiticoneGradientButton btnConductedExam;
        private Siticone.UI.WinForms.SiticoneGradientButton btnPendingExam;
        private Siticone.UI.WinForms.SiticoneGradientButton btnAssignedExam;
        private Siticone.UI.WinForms.SiticoneButton btnFilter;
        private Siticone.UI.WinForms.SiticonePanel pnlFilter;
        private Siticone.UI.WinForms.SiticoneComboBox cmbbxFilterExam;
        private Siticone.UI.WinForms.SiticoneComboBox cmbbxFilterCourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneButton btnExel;
        private Siticone.UI.WinForms.SiticoneButton btnExportPdf;
    }
}

