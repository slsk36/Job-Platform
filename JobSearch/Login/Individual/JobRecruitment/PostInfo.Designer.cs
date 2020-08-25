namespace Login.Individual.JobRecruitment
{
      partial class PostInfo
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
            this.ComName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.infoField = new System.Windows.Forms.Label();
            this.infoPay = new System.Windows.Forms.Label();
            this.infoPlace = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.infoDead = new System.Windows.Forms.Label();
            this.infownum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComName
            // 
            this.ComName.AutoSize = true;
            this.ComName.Font = new System.Drawing.Font("a옛날사진관4", 20F, System.Drawing.FontStyle.Bold);
            this.ComName.Location = new System.Drawing.Point(18, 25);
            this.ComName.Name = "ComName";
            this.ComName.Size = new System.Drawing.Size(114, 34);
            this.ComName.TabIndex = 0;
            this.ComName.Text = "기업명";
            this.ComName.Click += new System.EventHandler(this.PostInfo_Click);
            this.ComName.MouseEnter += new System.EventHandler(this.PostInfo_MouseEnter);
            this.ComName.MouseLeave += new System.EventHandler(this.PostInfo_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("a옛날사진관3", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(27, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "직종";
            this.label1.Click += new System.EventHandler(this.PostInfo_Click);
            this.label1.MouseEnter += new System.EventHandler(this.PostInfo_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.PostInfo_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("a옛날사진관3", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(27, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "급여";
            this.label2.Click += new System.EventHandler(this.PostInfo_Click);
            this.label2.MouseEnter += new System.EventHandler(this.PostInfo_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.PostInfo_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("a옛날사진관3", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(407, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "지역";
            this.label3.Click += new System.EventHandler(this.PostInfo_Click);
            this.label3.MouseEnter += new System.EventHandler(this.PostInfo_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.PostInfo_MouseLeave);
            // 
            // infoField
            // 
            this.infoField.AutoSize = true;
            this.infoField.Font = new System.Drawing.Font("a옛날사진관3", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.infoField.Location = new System.Drawing.Point(138, 81);
            this.infoField.Name = "infoField";
            this.infoField.Size = new System.Drawing.Size(76, 28);
            this.infoField.TabIndex = 5;
            this.infoField.Text = "field";
            this.infoField.Click += new System.EventHandler(this.PostInfo_Click);
            this.infoField.MouseEnter += new System.EventHandler(this.PostInfo_MouseEnter);
            this.infoField.MouseLeave += new System.EventHandler(this.PostInfo_MouseLeave);
            // 
            // infoPay
            // 
            this.infoPay.Font = new System.Drawing.Font("a옛날사진관3", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.infoPay.Location = new System.Drawing.Point(138, 123);
            this.infoPay.Name = "infoPay";
            this.infoPay.Size = new System.Drawing.Size(262, 28);
            this.infoPay.TabIndex = 6;
            this.infoPay.Text = "pay";
            this.infoPay.Click += new System.EventHandler(this.PostInfo_Click);
            this.infoPay.MouseEnter += new System.EventHandler(this.PostInfo_MouseEnter);
            this.infoPay.MouseLeave += new System.EventHandler(this.PostInfo_MouseLeave);
            // 
            // infoPlace
            // 
            this.infoPlace.AutoSize = true;
            this.infoPlace.Font = new System.Drawing.Font("a옛날사진관3", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.infoPlace.Location = new System.Drawing.Point(490, 81);
            this.infoPlace.Name = "infoPlace";
            this.infoPlace.Size = new System.Drawing.Size(87, 28);
            this.infoPlace.TabIndex = 7;
            this.infoPlace.Text = "place";
            this.infoPlace.Click += new System.EventHandler(this.PostInfo_Click);
            this.infoPlace.MouseEnter += new System.EventHandler(this.PostInfo_MouseEnter);
            this.infoPlace.MouseLeave += new System.EventHandler(this.PostInfo_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("a옛날사진관3", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(27, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "마감";
            this.label5.Click += new System.EventHandler(this.PostInfo_Click);
            this.label5.MouseEnter += new System.EventHandler(this.PostInfo_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.PostInfo_MouseLeave);
            // 
            // infoDead
            // 
            this.infoDead.AutoSize = true;
            this.infoDead.Font = new System.Drawing.Font("a옛날사진관3", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.infoDead.Location = new System.Drawing.Point(138, 165);
            this.infoDead.Name = "infoDead";
            this.infoDead.Size = new System.Drawing.Size(80, 28);
            this.infoDead.TabIndex = 12;
            this.infoDead.Text = "dead";
            this.infoDead.Click += new System.EventHandler(this.PostInfo_Click);
            this.infoDead.MouseEnter += new System.EventHandler(this.PostInfo_MouseEnter);
            this.infoDead.MouseLeave += new System.EventHandler(this.PostInfo_MouseLeave);
            // 
            // infownum
            // 
            this.infownum.AutoSize = true;
            this.infownum.Font = new System.Drawing.Font("굴림", 16F);
            this.infownum.Location = new System.Drawing.Point(510, 25);
            this.infownum.Name = "infownum";
            this.infownum.Size = new System.Drawing.Size(100, 27);
            this.infownum.TabIndex = 13;
            this.infownum.Text = "w_num";
            this.infownum.Visible = false;
            this.infownum.Click += new System.EventHandler(this.PostInfo_Click);
            this.infownum.MouseEnter += new System.EventHandler(this.PostInfo_MouseEnter);
            this.infownum.MouseLeave += new System.EventHandler(this.PostInfo_MouseLeave);
            // 
            // PostInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.infownum);
            this.Controls.Add(this.infoDead);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.infoPlace);
            this.Controls.Add(this.infoPay);
            this.Controls.Add(this.infoField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PostInfo";
            this.Size = new System.Drawing.Size(750, 215);
            this.Click += new System.EventHandler(this.PostInfo_Click);
            this.MouseEnter += new System.EventHandler(this.PostInfo_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.PostInfo_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Label ComName;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.Label infoField;
            private System.Windows.Forms.Label infoPay;
            private System.Windows.Forms.Label infoPlace;
            private System.Windows.Forms.Label label5;
            private System.Windows.Forms.Label infoDead;
            private System.Windows.Forms.Label infownum;
      }
}
