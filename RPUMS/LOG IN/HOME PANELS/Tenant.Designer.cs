namespace RPUMS.HOME_PANELS
{
    partial class Tenant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tenant));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_tenant = new System.Windows.Forms.DataGridView();
            this.btn_deleteTD = new System.Windows.Forms.Button();
            this.cob_age = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btn_updateTE = new System.Windows.Forms.Button();
            this.btn_addTE = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_contact = new System.Windows.Forms.Label();
            this.lb_gender = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_contact = new System.Windows.Forms.TextBox();
            this.lb_age = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.tb_uid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cob_filter = new System.Windows.Forms.ComboBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tenant)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tenants";
            // 
            // dgv_tenant
            // 
            this.dgv_tenant.AllowUserToAddRows = false;
            this.dgv_tenant.AllowUserToDeleteRows = false;
            this.dgv_tenant.AllowUserToOrderColumns = true;
            this.dgv_tenant.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_tenant.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_tenant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tenant.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_tenant.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_tenant.ColumnHeadersHeight = 40;
            this.dgv_tenant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tenant.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_tenant.Location = new System.Drawing.Point(22, 102);
            this.dgv_tenant.Name = "dgv_tenant";
            this.dgv_tenant.ReadOnly = true;
            this.dgv_tenant.RowHeadersVisible = false;
            this.dgv_tenant.RowHeadersWidth = 51;
            this.dgv_tenant.RowTemplate.Height = 24;
            this.dgv_tenant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tenant.Size = new System.Drawing.Size(1015, 381);
            this.dgv_tenant.TabIndex = 7;
            this.dgv_tenant.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tenant_CellDoubleClick);
            // 
            // btn_deleteTD
            // 
            this.btn_deleteTD.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteTD.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_deleteTD.Image = global::RPUMS.Properties.Resources.delete;
            this.btn_deleteTD.Location = new System.Drawing.Point(939, 620);
            this.btn_deleteTD.Name = "btn_deleteTD";
            this.btn_deleteTD.Size = new System.Drawing.Size(83, 51);
            this.btn_deleteTD.TabIndex = 16;
            this.btn_deleteTD.UseVisualStyleBackColor = true;
            this.btn_deleteTD.Click += new System.EventHandler(this.btn_deleteTD_Click);
            // 
            // cob_age
            // 
            this.cob_age.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cob_age.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cob_age.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_age.FormattingEnabled = true;
            this.cob_age.Items.AddRange(new object[] {
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cob_age.Location = new System.Drawing.Point(107, 652);
            this.cob_age.Name = "cob_age";
            this.cob_age.Size = new System.Drawing.Size(81, 24);
            this.cob_age.TabIndex = 35;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(647, 558);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 20);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(550, 558);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 20);
            this.radioButton1.TabIndex = 33;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btn_updateTE
            // 
            this.btn_updateTE.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateTE.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_updateTE.Image = global::RPUMS.Properties.Resources.update;
            this.btn_updateTE.Location = new System.Drawing.Point(939, 560);
            this.btn_updateTE.Name = "btn_updateTE";
            this.btn_updateTE.Size = new System.Drawing.Size(83, 54);
            this.btn_updateTE.TabIndex = 32;
            this.btn_updateTE.UseVisualStyleBackColor = true;
            this.btn_updateTE.Click += new System.EventHandler(this.btn_updateTE_Click);
            // 
            // btn_addTE
            // 
            this.btn_addTE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_addTE.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addTE.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_addTE.Image = global::RPUMS.Properties.Resources.add;
            this.btn_addTE.Location = new System.Drawing.Point(939, 504);
            this.btn_addTE.Name = "btn_addTE";
            this.btn_addTE.Size = new System.Drawing.Size(83, 49);
            this.btn_addTE.TabIndex = 31;
            this.btn_addTE.UseVisualStyleBackColor = true;
            this.btn_addTE.Click += new System.EventHandler(this.btn_addTE_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(466, 654);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "Email";
            // 
            // lb_contact
            // 
            this.lb_contact.AutoSize = true;
            this.lb_contact.BackColor = System.Drawing.Color.Transparent;
            this.lb_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contact.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_contact.Location = new System.Drawing.Point(420, 608);
            this.lb_contact.Name = "lb_contact";
            this.lb_contact.Size = new System.Drawing.Size(105, 22);
            this.lb_contact.TabIndex = 29;
            this.lb_contact.Text = "Contact No.";
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.BackColor = System.Drawing.Color.Transparent;
            this.lb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gender.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_gender.Location = new System.Drawing.Point(450, 558);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(70, 22);
            this.lb_gender.TabIndex = 28;
            this.lb_gender.Text = "Gender";
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(545, 652);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(176, 24);
            this.tb_email.TabIndex = 27;
            // 
            // tb_contact
            // 
            this.tb_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_contact.Location = new System.Drawing.Point(545, 608);
            this.tb_contact.Name = "tb_contact";
            this.tb_contact.Size = new System.Drawing.Size(176, 24);
            this.tb_contact.TabIndex = 26;
            this.tb_contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_contact_KeyPress);
            // 
            // lb_age
            // 
            this.lb_age.AutoSize = true;
            this.lb_age.BackColor = System.Drawing.Color.Transparent;
            this.lb_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_age.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_age.Location = new System.Drawing.Point(39, 649);
            this.lb_age.Name = "lb_age";
            this.lb_age.Size = new System.Drawing.Size(42, 22);
            this.lb_age.TabIndex = 25;
            this.lb_age.Text = "Age";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(107, 558);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(234, 24);
            this.tb_name.TabIndex = 23;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_name.Location = new System.Drawing.Point(20, 560);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(57, 22);
            this.lb_name.TabIndex = 22;
            this.lb_name.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(13, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 53);
            this.label3.TabIndex = 21;
            this.label3.Text = "Edit Tenant Details";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(546, 519);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(25, 22);
            this.lbl_ID.TabIndex = 37;
            this.lbl_ID.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(493, 516);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 22);
            this.label5.TabIndex = 38;
            this.label5.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 608);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 22);
            this.label7.TabIndex = 44;
            this.label7.Text = "Unit ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 22);
            this.label8.TabIndex = 65;
            this.label8.Text = "Search";
            // 
            // tb_search
            // 
            this.tb_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_search.Location = new System.Drawing.Point(113, 63);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(235, 22);
            this.tb_search.TabIndex = 63;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // tb_uid
            // 
            this.tb_uid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_uid.Location = new System.Drawing.Point(107, 608);
            this.tb_uid.Name = "tb_uid";
            this.tb_uid.Size = new System.Drawing.Size(118, 24);
            this.tb_uid.TabIndex = 82;
            this.tb_uid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_uid_KeyPress);
            // 
            // button1
            // 
            this.button1.Image = global::RPUMS.Properties.Resources.icons8_home_button_50;
            this.button1.Location = new System.Drawing.Point(663, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 38);
            this.button1.TabIndex = 89;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cob_filter
            // 
            this.cob_filter.FormattingEnabled = true;
            this.cob_filter.Items.AddRange(new object[] {
            "Tenant ID",
            "Name",
            "Age",
            "Unit ID",
            "Gender",
            "Contact No.",
            "Email"});
            this.cob_filter.Location = new System.Drawing.Point(786, 61);
            this.cob_filter.Name = "cob_filter";
            this.cob_filter.Size = new System.Drawing.Size(179, 24);
            this.cob_filter.TabIndex = 90;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_refresh.Image = global::RPUMS.Properties.Resources.icons8_restart_24__2_;
            this.btn_refresh.Location = new System.Drawing.Point(981, 53);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(56, 38);
            this.btn_refresh.TabIndex = 91;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(643, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 92;
            this.label4.Text = "Search Filter";
            // 
            // Tenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 692);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.cob_filter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_uid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.cob_age);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btn_updateTE);
            this.Controls.Add(this.btn_addTE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_contact);
            this.Controls.Add(this.lb_gender);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_contact);
            this.Controls.Add(this.lb_age);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_deleteTD);
            this.Controls.Add(this.dgv_tenant);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tenant";
            this.ShowInTaskbar = false;
            this.Text = "TenantEdit";
            this.Load += new System.EventHandler(this.Tenant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tenant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_tenant;
        private System.Windows.Forms.Button btn_deleteTD;
        private System.Windows.Forms.ComboBox cob_age;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btn_updateTE;
        private System.Windows.Forms.Button btn_addTE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_contact;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_contact;
        private System.Windows.Forms.Label lb_age;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.TextBox tb_uid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cob_filter;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label4;
    }
}