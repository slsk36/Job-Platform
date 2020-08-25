namespace Login
{
    partial class ComManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComManage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.tb_star_pt = new System.Windows.Forms.TextBox();
            this.tb_ap_count = new System.Windows.Forms.TextBox();
            this.tb_sales = new System.Windows.Forms.TextBox();
            this.tb_com_tel = new System.Windows.Forms.TextBox();
            this.tb_field = new System.Windows.Forms.TextBox();
            this.tb_com_addr = new System.Windows.Forms.TextBox();
            this.tb_com_name = new System.Windows.Forms.TextBox();
            this.tb_com_num = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COM_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COM_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_comID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("굴림", 14F);
            this.tb_search.Location = new System.Drawing.Point(23, 18);
            this.tb_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_search.Multiline = true;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(280, 30);
            this.tb_search.TabIndex = 27;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(742, 511);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(69, 44);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "삭제";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(666, 511);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(69, 44);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "수정";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.White;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(515, 511);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(69, 44);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "리셋";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(303, 10);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(45, 45);
            this.btn_search.TabIndex = 23;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.White;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(591, 511);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(69, 44);
            this.btn_insert.TabIndex = 8;
            this.btn_insert.Text = "등록";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // tb_star_pt
            // 
            this.tb_star_pt.Font = new System.Drawing.Font("굴림", 14F);
            this.tb_star_pt.Location = new System.Drawing.Point(531, 460);
            this.tb_star_pt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_star_pt.Multiline = true;
            this.tb_star_pt.Name = "tb_star_pt";
            this.tb_star_pt.Size = new System.Drawing.Size(280, 30);
            this.tb_star_pt.TabIndex = 7;
            // 
            // tb_ap_count
            // 
            this.tb_ap_count.Font = new System.Drawing.Font("굴림", 14F);
            this.tb_ap_count.Location = new System.Drawing.Point(531, 411);
            this.tb_ap_count.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ap_count.Multiline = true;
            this.tb_ap_count.Name = "tb_ap_count";
            this.tb_ap_count.Size = new System.Drawing.Size(280, 30);
            this.tb_ap_count.TabIndex = 6;
            // 
            // tb_sales
            // 
            this.tb_sales.Font = new System.Drawing.Font("굴림", 14F);
            this.tb_sales.Location = new System.Drawing.Point(531, 362);
            this.tb_sales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_sales.Multiline = true;
            this.tb_sales.Name = "tb_sales";
            this.tb_sales.Size = new System.Drawing.Size(280, 30);
            this.tb_sales.TabIndex = 5;
            // 
            // tb_com_tel
            // 
            this.tb_com_tel.Font = new System.Drawing.Font("굴림", 14F);
            this.tb_com_tel.Location = new System.Drawing.Point(531, 313);
            this.tb_com_tel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_com_tel.Multiline = true;
            this.tb_com_tel.Name = "tb_com_tel";
            this.tb_com_tel.Size = new System.Drawing.Size(280, 30);
            this.tb_com_tel.TabIndex = 4;
            // 
            // tb_field
            // 
            this.tb_field.Font = new System.Drawing.Font("굴림", 14F);
            this.tb_field.Location = new System.Drawing.Point(531, 264);
            this.tb_field.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_field.Multiline = true;
            this.tb_field.Name = "tb_field";
            this.tb_field.Size = new System.Drawing.Size(280, 30);
            this.tb_field.TabIndex = 3;
            // 
            // tb_com_addr
            // 
            this.tb_com_addr.Font = new System.Drawing.Font("굴림", 14F);
            this.tb_com_addr.Location = new System.Drawing.Point(531, 215);
            this.tb_com_addr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_com_addr.Multiline = true;
            this.tb_com_addr.Name = "tb_com_addr";
            this.tb_com_addr.Size = new System.Drawing.Size(280, 30);
            this.tb_com_addr.TabIndex = 2;
            // 
            // tb_com_name
            // 
            this.tb_com_name.Font = new System.Drawing.Font("굴림", 14F);
            this.tb_com_name.Location = new System.Drawing.Point(531, 166);
            this.tb_com_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_com_name.Multiline = true;
            this.tb_com_name.Name = "tb_com_name";
            this.tb_com_name.Size = new System.Drawing.Size(280, 30);
            this.tb_com_name.TabIndex = 1;
            // 
            // tb_com_num
            // 
            this.tb_com_num.Font = new System.Drawing.Font("굴림", 14F);
            this.tb_com_num.Location = new System.Drawing.Point(531, 117);
            this.tb_com_num.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_com_num.Multiline = true;
            this.tb_com_num.Name = "tb_com_num";
            this.tb_com_num.Size = new System.Drawing.Size(280, 30);
            this.tb_com_num.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(393, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "7.지원자수";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(393, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "6.매출";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(393, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "5.전화번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(393, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "4.직종";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(393, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "3.주소";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(393, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "2.회사명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(393, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "1.사업자번호";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(393, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "8.평점";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.COM_ID,
            this.COM_NAME});
            this.dataGridView1.Location = new System.Drawing.Point(13, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(374, 501);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // num
            // 
            this.num.FillWeight = 30F;
            this.num.HeaderText = "NUM";
            this.num.MinimumWidth = 6;
            this.num.Name = "num";
            this.num.ReadOnly = true;
            // 
            // COM_ID
            // 
            this.COM_ID.FillWeight = 60F;
            this.COM_ID.HeaderText = "ID";
            this.COM_ID.MinimumWidth = 6;
            this.COM_ID.Name = "COM_ID";
            this.COM_ID.ReadOnly = true;
            // 
            // COM_NAME
            // 
            this.COM_NAME.HeaderText = "회사명";
            this.COM_NAME.MinimumWidth = 6;
            this.COM_NAME.Name = "COM_NAME";
            this.COM_NAME.ReadOnly = true;
            // 
            // btn_refresh
            // 
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.Location = new System.Drawing.Point(354, 15);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(40, 40);
            this.btn_refresh.TabIndex = 28;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(393, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 29);
            this.label9.TabIndex = 29;
            this.label9.Text = "0.기업ID";
            // 
            // tb_comID
            // 
            this.tb_comID.Font = new System.Drawing.Font("굴림", 14F);
            this.tb_comID.Location = new System.Drawing.Point(531, 68);
            this.tb_comID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_comID.Multiline = true;
            this.tb_comID.Name = "tb_comID";
            this.tb_comID.Size = new System.Drawing.Size(280, 30);
            this.tb_comID.TabIndex = 30;
            // 
            // ComManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 595);
            this.Controls.Add(this.tb_comID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.tb_star_pt);
            this.Controls.Add(this.tb_ap_count);
            this.Controls.Add(this.tb_sales);
            this.Controls.Add(this.tb_com_tel);
            this.Controls.Add(this.tb_field);
            this.Controls.Add(this.tb_com_addr);
            this.Controls.Add(this.tb_com_name);
            this.Controls.Add(this.tb_com_num);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ComManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComManage";
            this.Load += new System.EventHandler(this.ComManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox tb_star_pt;
        private System.Windows.Forms.TextBox tb_ap_count;
        private System.Windows.Forms.TextBox tb_sales;
        private System.Windows.Forms.TextBox tb_com_tel;
        private System.Windows.Forms.TextBox tb_field;
        private System.Windows.Forms.TextBox tb_com_addr;
        private System.Windows.Forms.TextBox tb_com_name;
        private System.Windows.Forms.TextBox tb_com_num;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_comID;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn COM_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn COM_NAME;
    }
}