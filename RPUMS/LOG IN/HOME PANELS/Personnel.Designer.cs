namespace RPUMS.HOME_PANELS
{
    partial class Maintenance_Personnel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maintenance_Personnel));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_personnel = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_deleteTD = new System.Windows.Forms.Button();
            this.btn_updatePeE = new System.Windows.Forms.Button();
            this.btn_addPeE = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_contact = new System.Windows.Forms.Label();
            this.tb_contact = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_profession = new System.Windows.Forms.TextBox();
            this.lb_unit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cob_filter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personnel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 42);
            this.label1.TabIndex = 26;
            // 
            // dgv_personnel
            // 
            this.dgv_personnel.AllowUserToAddRows = false;
            this.dgv_personnel.AllowUserToDeleteRows = false;
            this.dgv_personnel.AllowUserToOrderColumns = true;
            this.dgv_personnel.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_personnel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_personnel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_personnel.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_personnel.ColumnHeadersHeight = 40;
            this.dgv_personnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_personnel.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_personnel.Location = new System.Drawing.Point(22, 108);
            this.dgv_personnel.Name = "dgv_personnel";
            this.dgv_personnel.ReadOnly = true;
            this.dgv_personnel.RowHeadersVisible = false;
            this.dgv_personnel.RowHeadersWidth = 51;
            this.dgv_personnel.RowTemplate.Height = 24;
            this.dgv_personnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_personnel.Size = new System.Drawing.Size(1015, 381);
            this.dgv_personnel.TabIndex = 30;
            this.dgv_personnel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_personnel_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 51);
            this.label2.TabIndex = 27;
            this.label2.Text = "Personnel";
            // 
            // btn_deleteTD
            // 
            this.btn_deleteTD.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteTD.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_deleteTD.Image = global::RPUMS.Properties.Resources.delete;
            this.btn_deleteTD.Location = new System.Drawing.Point(930, 624);
            this.btn_deleteTD.Name = "btn_deleteTD";
            this.btn_deleteTD.Size = new System.Drawing.Size(91, 46);
            this.btn_deleteTD.TabIndex = 31;
            this.btn_deleteTD.UseVisualStyleBackColor = true;
            this.btn_deleteTD.Click += new System.EventHandler(this.btn_deleteTD_Click);
            // 
            // btn_updatePeE
            // 
            this.btn_updatePeE.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updatePeE.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_updatePeE.Image = global::RPUMS.Properties.Resources.update;
            this.btn_updatePeE.Location = new System.Drawing.Point(930, 569);
            this.btn_updatePeE.Name = "btn_updatePeE";
            this.btn_updatePeE.Size = new System.Drawing.Size(91, 51);
            this.btn_updatePeE.TabIndex = 57;
            this.btn_updatePeE.UseVisualStyleBackColor = true;
            this.btn_updatePeE.Click += new System.EventHandler(this.btn_updatePeE_Click);
            // 
            // btn_addPeE
            // 
            this.btn_addPeE.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addPeE.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_addPeE.Image = global::RPUMS.Properties.Resources.add;
            this.btn_addPeE.Location = new System.Drawing.Point(930, 519);
            this.btn_addPeE.Name = "btn_addPeE";
            this.btn_addPeE.Size = new System.Drawing.Size(91, 44);
            this.btn_addPeE.TabIndex = 56;
            this.btn_addPeE.UseVisualStyleBackColor = true;
            this.btn_addPeE.Click += new System.EventHandler(this.btn_addPeE_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(15, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(412, 44);
            this.label3.TabIndex = 55;
            this.label3.Text = "Edit Personnel Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(469, 626);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 22);
            this.label4.TabIndex = 54;
            this.label4.Text = "Contact No.";
            // 
            // lb_contact
            // 
            this.lb_contact.AutoSize = true;
            this.lb_contact.BackColor = System.Drawing.Color.Transparent;
            this.lb_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contact.Location = new System.Drawing.Point(85, 624);
            this.lb_contact.Name = "lb_contact";
            this.lb_contact.Size = new System.Drawing.Size(57, 22);
            this.lb_contact.TabIndex = 53;
            this.lb_contact.Text = "Name";
            // 
            // tb_contact
            // 
            this.tb_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_contact.Location = new System.Drawing.Point(586, 624);
            this.tb_contact.MaxLength = 11;
            this.tb_contact.Name = "tb_contact";
            this.tb_contact.Size = new System.Drawing.Size(240, 24);
            this.tb_contact.TabIndex = 52;
            this.tb_contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_contact_KeyPress);
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(154, 624);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(240, 24);
            this.tb_name.TabIndex = 51;
            // 
            // tb_profession
            // 
            this.tb_profession.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_profession.Location = new System.Drawing.Point(154, 584);
            this.tb_profession.Name = "tb_profession";
            this.tb_profession.Size = new System.Drawing.Size(240, 24);
            this.tb_profession.TabIndex = 50;
            this.tb_profession.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_profession_KeyPress);
            // 
            // lb_unit
            // 
            this.lb_unit.AutoSize = true;
            this.lb_unit.BackColor = System.Drawing.Color.Transparent;
            this.lb_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_unit.Location = new System.Drawing.Point(37, 586);
            this.lb_unit.Name = "lb_unit";
            this.lb_unit.Size = new System.Drawing.Size(95, 22);
            this.lb_unit.TabIndex = 49;
            this.lb_unit.Text = "Profession";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(536, 581);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 22);
            this.label5.TabIndex = 59;
            this.label5.Text = "ID";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(583, 581);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(25, 22);
            this.lbl_ID.TabIndex = 58;
            this.lbl_ID.Text = "...";
            // 
            // tb_search
            // 
            this.tb_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_search.Location = new System.Drawing.Point(114, 71);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(235, 22);
            this.tb_search.TabIndex = 60;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(18, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 22);
            this.label6.TabIndex = 62;
            this.label6.Text = "Search";
            // 
            // button1
            // 
            this.button1.Image = global::RPUMS.Properties.Resources.icons8_home_button_50;
            this.button1.Location = new System.Drawing.Point(768, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 38);
            this.button1.TabIndex = 89;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Image = global::RPUMS.Properties.Resources.icons8_restart_24__2_;
            this.btn_refresh.Location = new System.Drawing.Point(981, 63);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(54, 36);
            this.btn_refresh.TabIndex = 92;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(702, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 22);
            this.label7.TabIndex = 91;
            this.label7.Text = "Search Filter";
            // 
            // cob_filter
            // 
            this.cob_filter.FormattingEnabled = true;
            this.cob_filter.Items.AddRange(new object[] {
            "Personnel ID",
            "Profession",
            "Name",
            "Contact No."});
            this.cob_filter.Location = new System.Drawing.Point(837, 70);
            this.cob_filter.Name = "cob_filter";
            this.cob_filter.Size = new System.Drawing.Size(121, 24);
            this.cob_filter.TabIndex = 90;
            // 
            // Maintenance_Personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 692);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cob_filter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.btn_updatePeE);
            this.Controls.Add(this.btn_addPeE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_contact);
            this.Controls.Add(this.tb_contact);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_profession);
            this.Controls.Add(this.lb_unit);
            this.Controls.Add(this.dgv_personnel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_deleteTD);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Maintenance_Personnel";
            this.Load += new System.EventHandler(this.Maintenance_Personnel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_personnel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_deleteTD;
        private System.Windows.Forms.Button btn_updatePeE;
        private System.Windows.Forms.Button btn_addPeE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_contact;
        private System.Windows.Forms.TextBox tb_contact;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_profession;
        private System.Windows.Forms.Label lb_unit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cob_filter;
    }
}