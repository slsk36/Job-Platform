﻿namespace Login.Individual.CompanyInfo
{
    partial class InfoItem
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
            this.lb_com_name = new System.Windows.Forms.Label();
            this.lb_field = new System.Windows.Forms.Label();
            this.lb_point = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_com_addr = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_sales = new System.Windows.Forms.Label();
            this.lb_ap_count = new System.Windows.Forms.Label();
            this.lb_com_tel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_com_name
            // 
            this.lb_com_name.AutoSize = true;
            this.lb_com_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_com_name.Location = new System.Drawing.Point(13, 10);
            this.lb_com_name.Name = "lb_com_name";
            this.lb_com_name.Size = new System.Drawing.Size(89, 38);
            this.lb_com_name.TabIndex = 0;
            this.lb_com_name.Text = "기업명";
            // 
            // lb_field
            // 
            this.lb_field.AutoEllipsis = true;
            this.lb_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_field.Location = new System.Drawing.Point(95, 52);
            this.lb_field.Name = "lb_field";
            this.lb_field.Size = new System.Drawing.Size(101, 30);
            this.lb_field.TabIndex = 0;
            this.lb_field.Text = "업종";
            // 
            // lb_point
            // 
            this.lb_point.AutoSize = true;
            this.lb_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_point.Location = new System.Drawing.Point(495, 55);
            this.lb_point.Name = "lb_point";
            this.lb_point.Size = new System.Drawing.Size(56, 31);
            this.lb_point.TabIndex = 0;
            this.lb_point.Text = "점수";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(399, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "평점";
            // 
            // lb_com_addr
            // 
            this.lb_com_addr.AutoEllipsis = true;
            this.lb_com_addr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_com_addr.Location = new System.Drawing.Point(14, 163);
            this.lb_com_addr.Name = "lb_com_addr";
            this.lb_com_addr.Size = new System.Drawing.Size(434, 29);
            this.lb_com_addr.TabIndex = 2;
            this.lb_com_addr.Text = "주소";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(14, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "TEL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(14, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "매출";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(399, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "지원자";
            // 
            // lb_sales
            // 
            this.lb_sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_sales.Location = new System.Drawing.Point(95, 88);
            this.lb_sales.Name = "lb_sales";
            this.lb_sales.Size = new System.Drawing.Size(275, 30);
            this.lb_sales.TabIndex = 3;
            this.lb_sales.Text = "금액";
            // 
            // lb_ap_count
            // 
            this.lb_ap_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_ap_count.Location = new System.Drawing.Point(495, 95);
            this.lb_ap_count.Name = "lb_ap_count";
            this.lb_ap_count.Size = new System.Drawing.Size(130, 37);
            this.lb_ap_count.TabIndex = 4;
            this.lb_ap_count.Text = "지원자수";
            // 
            // lb_com_tel
            // 
            this.lb_com_tel.AutoSize = true;
            this.lb_com_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_com_tel.Location = new System.Drawing.Point(95, 127);
            this.lb_com_tel.Name = "lb_com_tel";
            this.lb_com_tel.Size = new System.Drawing.Size(98, 31);
            this.lb_com_tel.TabIndex = 5;
            this.lb_com_tel.Text = "전화번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "업종";
            // 
            // InfoItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_com_tel);
            this.Controls.Add(this.lb_ap_count);
            this.Controls.Add(this.lb_sales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_com_addr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_point);
            this.Controls.Add(this.lb_field);
            this.Controls.Add(this.lb_com_name);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InfoItem";
            this.Size = new System.Drawing.Size(665, 210);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_com_name;
        private System.Windows.Forms.Label lb_field;
        private System.Windows.Forms.Label lb_point;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_com_addr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_sales;
        private System.Windows.Forms.Label lb_ap_count;
        private System.Windows.Forms.Label lb_com_tel;
        private System.Windows.Forms.Label label2;
    }
}
