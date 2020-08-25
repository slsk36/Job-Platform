namespace Login
{
    partial class IMenu2
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMenu2));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_seq_letter = new System.Windows.Forms.Button();
            this.btn_seq_point = new System.Windows.Forms.Button();
            this.btn_seq_apply = new System.Windows.Forms.Button();
            this.panel_search = new System.Windows.Forms.Panel();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_all = new System.Windows.Forms.Button();
            this.panel_search.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(45, 110);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1053, 622);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_seq_letter
            // 
            this.btn_seq_letter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.btn_seq_letter.FlatAppearance.BorderSize = 0;
            this.btn_seq_letter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seq_letter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_seq_letter.ForeColor = System.Drawing.Color.Gray;
            this.btn_seq_letter.Location = new System.Drawing.Point(123, 0);
            this.btn_seq_letter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_seq_letter.Name = "btn_seq_letter";
            this.btn_seq_letter.Size = new System.Drawing.Size(120, 70);
            this.btn_seq_letter.TabIndex = 1;
            this.btn_seq_letter.Text = "가나다순";
            this.btn_seq_letter.UseVisualStyleBackColor = true;
            this.btn_seq_letter.Click += new System.EventHandler(this.btn_seq_letter_Click);
            // 
            // btn_seq_point
            // 
            this.btn_seq_point.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.btn_seq_point.FlatAppearance.BorderSize = 0;
            this.btn_seq_point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seq_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_seq_point.ForeColor = System.Drawing.Color.Gray;
            this.btn_seq_point.Location = new System.Drawing.Point(243, 0);
            this.btn_seq_point.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_seq_point.Name = "btn_seq_point";
            this.btn_seq_point.Size = new System.Drawing.Size(120, 70);
            this.btn_seq_point.TabIndex = 1;
            this.btn_seq_point.Text = "평점순";
            this.btn_seq_point.UseVisualStyleBackColor = true;
            this.btn_seq_point.Click += new System.EventHandler(this.btn_seq_point_Click);
            // 
            // btn_seq_apply
            // 
            this.btn_seq_apply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            this.btn_seq_apply.FlatAppearance.BorderSize = 0;
            this.btn_seq_apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seq_apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_seq_apply.ForeColor = System.Drawing.Color.Gray;
            this.btn_seq_apply.Location = new System.Drawing.Point(363, 0);
            this.btn_seq_apply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_seq_apply.Name = "btn_seq_apply";
            this.btn_seq_apply.Size = new System.Drawing.Size(120, 70);
            this.btn_seq_apply.TabIndex = 1;
            this.btn_seq_apply.Text = "지원자순";
            this.btn_seq_apply.UseVisualStyleBackColor = true;
            this.btn_seq_apply.Click += new System.EventHandler(this.btn_seq_apply_Click);
            // 
            // panel_search
            // 
            this.panel_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel_search.Controls.Add(this.tb_search);
            this.panel_search.Controls.Add(this.btn_search);
            this.panel_search.Location = new System.Drawing.Point(46, 32);
            this.panel_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(567, 72);
            this.panel_search.TabIndex = 2;
            // 
            // tb_search
            // 
            this.tb_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tb_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tb_search.ForeColor = System.Drawing.Color.White;
            this.tb_search.Location = new System.Drawing.Point(16, 22);
            this.tb_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(437, 31);
            this.tb_search.TabIndex = 1;
            this.tb_search.Text = "검색 할 기업을 입력하세요";
            this.tb_search.Click += new System.EventHandler(this.tb_search_Click);
            this.tb_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_search_KeyDown);
            this.tb_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_search_KeyPress);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(494, 0);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(73, 72);
            this.btn_search.TabIndex = 0;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_all);
            this.panel2.Controls.Add(this.btn_seq_letter);
            this.panel2.Controls.Add(this.btn_seq_point);
            this.panel2.Controls.Add(this.btn_seq_apply);
            this.panel2.Location = new System.Drawing.Point(619, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 72);
            this.panel2.TabIndex = 3;
            // 
            // btn_all
            // 
            this.btn_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_all.FlatAppearance.BorderSize = 0;
            this.btn_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_all.ForeColor = System.Drawing.Color.White;
            this.btn_all.Location = new System.Drawing.Point(3, 0);
            this.btn_all.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(120, 70);
            this.btn_all.TabIndex = 1;
            this.btn_all.Text = "전체글";
            this.btn_all.UseVisualStyleBackColor = false;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // IMenu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_search);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IMenu2";
            this.Size = new System.Drawing.Size(1137, 792);
            this.Load += new System.EventHandler(this.IMenu2_Load);
            this.panel_search.ResumeLayout(false);
            this.panel_search.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_seq_letter;
        private System.Windows.Forms.Button btn_seq_point;
        private System.Windows.Forms.Button btn_seq_apply;
        private System.Windows.Forms.Panel panel_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_all;
    }
}
