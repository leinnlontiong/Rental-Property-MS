namespace RPUMS.HOME_PANELS
{
    partial class Unit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Unit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_no = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_unit = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.cob_status = new System.Windows.Forms.ComboBox();
            this.btn_updateU = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.tb_rent = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cob_filter = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_unit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 42);
            this.label1.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 51);
            this.label2.TabIndex = 34;
            this.label2.Text = "Units";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(524, 517);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(25, 22);
            this.lbl_ID.TabIndex = 55;
            this.lbl_ID.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(469, 519);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 22);
            this.label4.TabIndex = 56;
            this.label4.Text = "ID";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.BackColor = System.Drawing.Color.Transparent;
            this.lbl_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.Location = new System.Drawing.Point(126, 622);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(25, 22);
            this.lbl_type.TabIndex = 58;
            this.lbl_type.Text = "...";
            this.lbl_type.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 622);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 57;
            this.label6.Text = "Unit Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(386, 567);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 59;
            this.label3.Text = "Unit No.";
            // 
            // lbl_no
            // 
            this.lbl_no.AutoSize = true;
            this.lbl_no.BackColor = System.Drawing.Color.Transparent;
            this.lbl_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_no.Location = new System.Drawing.Point(495, 565);
            this.lbl_no.Name = "lbl_no";
            this.lbl_no.Size = new System.Drawing.Size(25, 22);
            this.lbl_no.TabIndex = 60;
            this.lbl_no.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 563);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 22);
            this.label8.TabIndex = 61;
            this.label8.Text = "Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(346, 622);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 22);
            this.label11.TabIndex = 64;
            this.label11.Text = "Monthly Rent";
            // 
            // dgv_unit
            // 
            this.dgv_unit.AllowUserToAddRows = false;
            this.dgv_unit.AllowUserToDeleteRows = false;
            this.dgv_unit.AllowUserToOrderColumns = true;
            this.dgv_unit.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_unit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_unit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_unit.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_unit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_unit.ColumnHeadersHeight = 40;
            this.dgv_unit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_unit.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_unit.Location = new System.Drawing.Point(20, 90);
            this.dgv_unit.Name = "dgv_unit";
            this.dgv_unit.ReadOnly = true;
            this.dgv_unit.RowHeadersVisible = false;
            this.dgv_unit.RowHeadersWidth = 51;
            this.dgv_unit.RowTemplate.Height = 24;
            this.dgv_unit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_unit.Size = new System.Drawing.Size(1015, 381);
            this.dgv_unit.TabIndex = 65;
            this.dgv_unit.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_unit_CellDoubleClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(11, 497);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(351, 51);
            this.label12.TabIndex = 66;
            this.label12.Text = "Edit Unit Details";
            // 
            // cob_status
            // 
            this.cob_status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cob_status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cob_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cob_status.FormattingEnabled = true;
            this.cob_status.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.cob_status.Location = new System.Drawing.Point(130, 567);
            this.cob_status.Name = "cob_status";
            this.cob_status.Size = new System.Drawing.Size(133, 24);
            this.cob_status.TabIndex = 67;
            // 
            // btn_updateU
            // 
            this.btn_updateU.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateU.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_updateU.Image = global::RPUMS.Properties.Resources.update;
            this.btn_updateU.Location = new System.Drawing.Point(911, 603);
            this.btn_updateU.Name = "btn_updateU";
            this.btn_updateU.Size = new System.Drawing.Size(99, 46);
            this.btn_updateU.TabIndex = 69;
            this.btn_updateU.UseVisualStyleBackColor = true;
            this.btn_updateU.Click += new System.EventHandler(this.btn_updateU_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(20, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 73;
            this.label5.Text = "Search";
            // 
            // tb_search
            // 
            this.tb_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_search.Location = new System.Drawing.Point(119, 62);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(235, 22);
            this.tb_search.TabIndex = 71;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged_1);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // tb_rent
            // 
            this.tb_rent.Location = new System.Drawing.Point(499, 624);
            this.tb_rent.Name = "tb_rent";
            this.tb_rent.Size = new System.Drawing.Size(183, 22);
            this.tb_rent.TabIndex = 79;
            this.tb_rent.TextChanged += new System.EventHandler(this.tb_rent_TextChanged);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_refresh.Image = global::RPUMS.Properties.Resources.icons8_restart_24__2_;
            this.btn_refresh.Location = new System.Drawing.Point(977, 47);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(56, 38);
            this.btn_refresh.TabIndex = 90;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(690, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 22);
            this.label7.TabIndex = 89;
            this.label7.Text = "Search Filter";
            // 
            // cob_filter
            // 
            this.cob_filter.FormattingEnabled = true;
            this.cob_filter.Items.AddRange(new object[] {
            "Unit ID",
            "Status",
            "Type",
            "Unit",
            "Monthly Rent"});
            this.cob_filter.Location = new System.Drawing.Point(813, 58);
            this.cob_filter.Name = "cob_filter";
            this.cob_filter.Size = new System.Drawing.Size(120, 24);
            this.cob_filter.TabIndex = 88;
            this.cob_filter.SelectedIndexChanged += new System.EventHandler(this.cob_filter_SelectedIndexChanged_1);
            // 
            // button1
            // 
            this.button1.Image = global::RPUMS.Properties.Resources.icons8_home_button_50;
            this.button1.Location = new System.Drawing.Point(624, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 38);
            this.button1.TabIndex = 91;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Unit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cob_filter);
            this.Controls.Add(this.tb_rent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.btn_updateU);
            this.Controls.Add(this.cob_status);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgv_unit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_no);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Unit";
            this.Text = "Unit";
            this.Load += new System.EventHandler(this.Unit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_unit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_no;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_unit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cob_status;
        private System.Windows.Forms.Button btn_updateU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_search;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.TextBox tb_rent;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cob_filter;
        private System.Windows.Forms.Button button1;
    }
}