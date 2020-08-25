namespace Login
{
    partial class 회원관리
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(회원관리));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.personId = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_addr = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.personPh = new System.Windows.Forms.Label();
            this.personEmail = new System.Windows.Forms.Label();
            this.personAddr = new System.Windows.Forms.Label();
            this.personName = new System.Windows.Forms.Label();
            this.personPw = new System.Windows.Forms.Label();
            this.NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.NUM,
            this.ID,
            this.NAME});
            this.dataGridView1.Location = new System.Drawing.Point(31, 67);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(371, 446);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_refresh
            // 
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.Location = new System.Drawing.Point(365, 24);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(40, 40);
            this.btn_refresh.TabIndex = 31;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("굴림", 14F);
            this.tb_search.Location = new System.Drawing.Point(31, 30);
            this.tb_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_search.Multiline = true;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(280, 30);
            this.tb_search.TabIndex = 30;
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(314, 22);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(45, 45);
            this.btn_search.TabIndex = 29;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_ID
            // 
            this.tb_ID.Font = new System.Drawing.Font("굴림", 14F);
            this.tb_ID.Location = new System.Drawing.Point(568, 119);
            this.tb_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ID.Multiline = true;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(280, 30);
            this.tb_ID.TabIndex = 53;
            // 
            // personId
            // 
            this.personId.AutoSize = true;
            this.personId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.personId.Location = new System.Drawing.Point(430, 120);
            this.personId.Name = "personId";
            this.personId.Size = new System.Drawing.Size(36, 29);
            this.personId.TabIndex = 52;
            this.personId.Text = "ID";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(779, 437);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(69, 44);
            this.btn_delete.TabIndex = 46;
            this.btn_delete.Text = "삭제";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(703, 437);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(69, 44);
            this.btn_update.TabIndex = 45;
            this.btn_update.Text = "수정";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.White;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(628, 437);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(69, 44);
            this.btn_clear.TabIndex = 49;
            this.btn_clear.Text = "리셋";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // tb_tel
            // 
            this.tb_tel.Font = new System.Drawing.Font("굴림", 14F);
            this.tb_tel.Location = new System.Drawing.Point(568, 364);
            this.tb_tel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_tel.Multiline = true;
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(280, 30);
            this.tb_tel.TabIndex = 36;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("굴림", 14F);
            this.tb_email.Location = new System.Drawing.Point(568, 315);
            this.tb_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_email.Multiline = true;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(280, 30);
            this.tb_email.TabIndex = 35;
            // 
            // tb_addr
            // 
            this.tb_addr.Font = new System.Drawing.Font("굴림", 14F);
            this.tb_addr.Location = new System.Drawing.Point(568, 266);
            this.tb_addr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_addr.Multiline = true;
            this.tb_addr.Name = "tb_addr";
            this.tb_addr.Size = new System.Drawing.Size(280, 30);
            this.tb_addr.TabIndex = 34;
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("굴림", 14F);
            this.tb_name.Location = new System.Drawing.Point(568, 217);
            this.tb_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(280, 30);
            this.tb_name.TabIndex = 33;
            // 
            // tb_pw
            // 
            this.tb_pw.Font = new System.Drawing.Font("굴림", 14F);
            this.tb_pw.Location = new System.Drawing.Point(568, 168);
            this.tb_pw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_pw.Multiline = true;
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.Size = new System.Drawing.Size(280, 30);
            this.tb_pw.TabIndex = 32;
            // 
            // personPh
            // 
            this.personPh.AutoSize = true;
            this.personPh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.personPh.Location = new System.Drawing.Point(430, 365);
            this.personPh.Name = "personPh";
            this.personPh.Size = new System.Drawing.Size(89, 29);
            this.personPh.TabIndex = 47;
            this.personPh.Text = "전화번호";
            // 
            // personEmail
            // 
            this.personEmail.AutoSize = true;
            this.personEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.personEmail.Location = new System.Drawing.Point(430, 316);
            this.personEmail.Name = "personEmail";
            this.personEmail.Size = new System.Drawing.Size(83, 29);
            this.personEmail.TabIndex = 44;
            this.personEmail.Text = "EMAIL";
            // 
            // personAddr
            // 
            this.personAddr.AutoSize = true;
            this.personAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.personAddr.Location = new System.Drawing.Point(430, 267);
            this.personAddr.Name = "personAddr";
            this.personAddr.Size = new System.Drawing.Size(51, 29);
            this.personAddr.TabIndex = 43;
            this.personAddr.Text = "주소";
            // 
            // personName
            // 
            this.personName.AutoSize = true;
            this.personName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.personName.Location = new System.Drawing.Point(430, 218);
            this.personName.Name = "personName";
            this.personName.Size = new System.Drawing.Size(82, 29);
            this.personName.TabIndex = 41;
            this.personName.Text = "NAME";
            // 
            // personPw
            // 
            this.personPw.AutoSize = true;
            this.personPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.personPw.Location = new System.Drawing.Point(430, 169);
            this.personPw.Name = "personPw";
            this.personPw.Size = new System.Drawing.Size(51, 29);
            this.personPw.TabIndex = 39;
            this.personPw.Text = "PW";
            // 
            // NUM
            // 
            this.NUM.HeaderText = "NUM";
            this.NUM.Name = "NUM";
            this.NUM.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NAME
            // 
            this.NAME.HeaderText = "NAME";
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            // 
            // 회원관리
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 539);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.personId);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.tb_tel);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_addr);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_pw);
            this.Controls.Add(this.personPh);
            this.Controls.Add(this.personEmail);
            this.Controls.Add(this.personAddr);
            this.Controls.Add(this.personName);
            this.Controls.Add(this.personPw);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dataGridView1);
            this.Name = "회원관리";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "회원관리";
            this.Load += new System.EventHandler(this.회원관리_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label personId;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_addr;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.Label personPh;
        private System.Windows.Forms.Label personEmail;
        private System.Windows.Forms.Label personAddr;
        private System.Windows.Forms.Label personName;
        private System.Windows.Forms.Label personPw;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
    }
}