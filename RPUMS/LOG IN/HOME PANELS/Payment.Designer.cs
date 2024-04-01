namespace RPUMS.HOME_PANELS
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.dgv_payment = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btn_updatePaE = new System.Windows.Forms.Button();
            this.btn_addPaE = new System.Windows.Forms.Button();
            this.tb_tid = new System.Windows.Forms.TextBox();
            this.tb_balance = new System.Windows.Forms.TextBox();
            this.lb_tenantname = new System.Windows.Forms.Label();
            this.lb_due = new System.Windows.Forms.Label();
            this.lb_balance = new System.Windows.Forms.Label();
            this.lb_paymentstat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.dtp_due = new System.Windows.Forms.DateTimePicker();
            this.cob_filter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_payment
            // 
            this.dgv_payment.AllowUserToAddRows = false;
            this.dgv_payment.AllowUserToDeleteRows = false;
            this.dgv_payment.AllowUserToOrderColumns = true;
            this.dgv_payment.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_payment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_payment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_payment.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgv_payment.ColumnHeadersHeight = 40;
            this.dgv_payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_payment.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_payment.Location = new System.Drawing.Point(21, 108);
            this.dgv_payment.Name = "dgv_payment";
            this.dgv_payment.ReadOnly = true;
            this.dgv_payment.RowHeadersVisible = false;
            this.dgv_payment.RowHeadersWidth = 51;
            this.dgv_payment.RowTemplate.Height = 24;
            this.dgv_payment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_payment.Size = new System.Drawing.Size(1015, 381);
            this.dgv_payment.TabIndex = 37;
            this.dgv_payment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_payment_CellContentClick);
            this.dgv_payment.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_payment_CellDoubleClick);
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
            this.label2.Size = new System.Drawing.Size(225, 51);
            this.label2.TabIndex = 34;
            this.label2.Text = "Payments";
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_delete.Image = global::RPUMS.Properties.Resources.delete;
            this.btn_delete.Location = new System.Drawing.Point(919, 636);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(117, 44);
            this.btn_delete.TabIndex = 38;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(276, 626);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 20);
            this.radioButton2.TabIndex = 55;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Unpaid";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(192, 626);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 20);
            this.radioButton1.TabIndex = 54;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Paid";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btn_updatePaE
            // 
            this.btn_updatePaE.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updatePaE.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_updatePaE.Image = global::RPUMS.Properties.Resources.update;
            this.btn_updatePaE.Location = new System.Drawing.Point(919, 578);
            this.btn_updatePaE.Name = "btn_updatePaE";
            this.btn_updatePaE.Size = new System.Drawing.Size(117, 52);
            this.btn_updatePaE.TabIndex = 51;
            this.btn_updatePaE.UseVisualStyleBackColor = true;
            this.btn_updatePaE.Click += new System.EventHandler(this.btn_updatePaE_Click);
            // 
            // btn_addPaE
            // 
            this.btn_addPaE.BackColor = System.Drawing.SystemColors.Control;
            this.btn_addPaE.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addPaE.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_addPaE.Image = global::RPUMS.Properties.Resources.add;
            this.btn_addPaE.Location = new System.Drawing.Point(919, 526);
            this.btn_addPaE.Name = "btn_addPaE";
            this.btn_addPaE.Size = new System.Drawing.Size(117, 46);
            this.btn_addPaE.TabIndex = 50;
            this.btn_addPaE.UseVisualStyleBackColor = false;
            this.btn_addPaE.Click += new System.EventHandler(this.btn_addPaE_Click);
            // 
            // tb_tid
            // 
            this.tb_tid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tid.Location = new System.Drawing.Point(192, 576);
            this.tb_tid.Name = "tb_tid";
            this.tb_tid.Size = new System.Drawing.Size(119, 24);
            this.tb_tid.TabIndex = 49;
            this.tb_tid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_tid_KeyPress);
            // 
            // tb_balance
            // 
            this.tb_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_balance.Location = new System.Drawing.Point(644, 576);
            this.tb_balance.Name = "tb_balance";
            this.tb_balance.Size = new System.Drawing.Size(202, 24);
            this.tb_balance.TabIndex = 48;
            this.tb_balance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_balance_KeyPress);
            // 
            // lb_tenantname
            // 
            this.lb_tenantname.AutoSize = true;
            this.lb_tenantname.BackColor = System.Drawing.Color.Transparent;
            this.lb_tenantname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenantname.Location = new System.Drawing.Point(68, 576);
            this.lb_tenantname.Name = "lb_tenantname";
            this.lb_tenantname.Size = new System.Drawing.Size(89, 22);
            this.lb_tenantname.TabIndex = 46;
            this.lb_tenantname.Text = "Tenant ID";
            // 
            // lb_due
            // 
            this.lb_due.AutoSize = true;
            this.lb_due.BackColor = System.Drawing.Color.Transparent;
            this.lb_due.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_due.Location = new System.Drawing.Point(539, 624);
            this.lb_due.Name = "lb_due";
            this.lb_due.Size = new System.Drawing.Size(86, 22);
            this.lb_due.TabIndex = 44;
            this.lb_due.Text = "Due Date";
            // 
            // lb_balance
            // 
            this.lb_balance.AutoSize = true;
            this.lb_balance.BackColor = System.Drawing.Color.Transparent;
            this.lb_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_balance.Location = new System.Drawing.Point(548, 578);
            this.lb_balance.Name = "lb_balance";
            this.lb_balance.Size = new System.Drawing.Size(75, 22);
            this.lb_balance.TabIndex = 43;
            this.lb_balance.Text = "Balance";
            // 
            // lb_paymentstat
            // 
            this.lb_paymentstat.AutoSize = true;
            this.lb_paymentstat.BackColor = System.Drawing.Color.Transparent;
            this.lb_paymentstat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_paymentstat.Location = new System.Drawing.Point(21, 626);
            this.lb_paymentstat.Name = "lb_paymentstat";
            this.lb_paymentstat.Size = new System.Drawing.Size(136, 22);
            this.lb_paymentstat.TabIndex = 41;
            this.lb_paymentstat.Text = "Payment Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(12, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(447, 51);
            this.label3.TabIndex = 40;
            this.label3.Text = "Edit Payment Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(596, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 22);
            this.label5.TabIndex = 57;
            this.label5.Text = "ID";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(641, 526);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(25, 22);
            this.lbl_ID.TabIndex = 56;
            this.lbl_ID.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 22);
            this.label4.TabIndex = 76;
            this.label4.Text = "Search";
            // 
            // tb_search
            // 
            this.tb_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_search.Location = new System.Drawing.Point(113, 69);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(235, 22);
            this.tb_search.TabIndex = 74;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged_1);
            // 
            // dtp_due
            // 
            this.dtp_due.CustomFormat = "MM-dd-yyy";
            this.dtp_due.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_due.Location = new System.Drawing.Point(645, 624);
            this.dtp_due.Name = "dtp_due";
            this.dtp_due.Size = new System.Drawing.Size(114, 22);
            this.dtp_due.TabIndex = 84;
            // 
            // cob_filter
            // 
            this.cob_filter.FormattingEnabled = true;
            this.cob_filter.Items.AddRange(new object[] {
            "Payment ID",
            "Tenant ID",
            "Status",
            "Balance",
            "Due"});
            this.cob_filter.Location = new System.Drawing.Point(829, 67);
            this.cob_filter.Name = "cob_filter";
            this.cob_filter.Size = new System.Drawing.Size(121, 24);
            this.cob_filter.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(694, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 22);
            this.label6.TabIndex = 86;
            this.label6.Text = "Search Filter";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Image = global::RPUMS.Properties.Resources.icons8_restart_24__2_;
            this.btn_refresh.Location = new System.Drawing.Point(973, 60);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(54, 36);
            this.btn_refresh.TabIndex = 87;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // button1
            // 
            this.button1.Image = global::RPUMS.Properties.Resources.icons8_home_button_50;
            this.button1.Location = new System.Drawing.Point(788, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 38);
            this.button1.TabIndex = 88;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cob_filter);
            this.Controls.Add(this.dtp_due);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btn_updatePaE);
            this.Controls.Add(this.btn_addPaE);
            this.Controls.Add(this.tb_tid);
            this.Controls.Add(this.tb_balance);
            this.Controls.Add(this.lb_tenantname);
            this.Controls.Add(this.lb_due);
            this.Controls.Add(this.lb_balance);
            this.Controls.Add(this.lb_paymentstat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_payment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_delete);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_payment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_payment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btn_updatePaE;
        private System.Windows.Forms.TextBox tb_tid;
        private System.Windows.Forms.TextBox tb_balance;
        private System.Windows.Forms.Label lb_tenantname;
        private System.Windows.Forms.Label lb_due;
        private System.Windows.Forms.Label lb_balance;
        private System.Windows.Forms.Label lb_paymentstat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Button btn_addPaE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.DateTimePicker dtp_due;
        private System.Windows.Forms.ComboBox cob_filter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button button1;
    }
}