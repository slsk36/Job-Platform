namespace Login
{
    partial class Menu1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textSubject = new System.Windows.Forms.TextBox();
            this.textPay = new System.Windows.Forms.TextBox();
            this.textPlace = new System.Windows.Forms.TextBox();
            this.deadLineTime = new System.Windows.Forms.DateTimePicker();
            this.textContent = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.applyBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "구인 등록";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "제목";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "급여";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "근무지";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(177, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "접수마감";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(177, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "구인내용";
            // 
            // textSubject
            // 
            this.textSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textSubject.Location = new System.Drawing.Point(323, 124);
            this.textSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textSubject.Name = "textSubject";
            this.textSubject.Size = new System.Drawing.Size(249, 38);
            this.textSubject.TabIndex = 6;
            // 
            // textPay
            // 
            this.textPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textPay.Location = new System.Drawing.Point(323, 234);
            this.textPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textPay.Name = "textPay";
            this.textPay.Size = new System.Drawing.Size(203, 38);
            this.textPay.TabIndex = 7;
            // 
            // textPlace
            // 
            this.textPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textPlace.Location = new System.Drawing.Point(323, 289);
            this.textPlace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textPlace.Name = "textPlace";
            this.textPlace.Size = new System.Drawing.Size(249, 38);
            this.textPlace.TabIndex = 8;
            // 
            // deadLineTime
            // 
            this.deadLineTime.CalendarFont = new System.Drawing.Font("HY강M", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.deadLineTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.deadLineTime.Location = new System.Drawing.Point(321, 344);
            this.deadLineTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deadLineTime.Name = "deadLineTime";
            this.deadLineTime.Size = new System.Drawing.Size(384, 38);
            this.deadLineTime.TabIndex = 10;
            this.deadLineTime.CloseUp += new System.EventHandler(this.deadLineTime_CloseUp);
            // 
            // textContent
            // 
            this.textContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textContent.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textContent.Location = new System.Drawing.Point(175, 454);
            this.textContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textContent.Multiline = true;
            this.textContent.Name = "textContent";
            this.textContent.Size = new System.Drawing.Size(827, 221);
            this.textContent.TabIndex = 11;
            this.textContent.Text = "우대사항 작업내용 등";
            this.textContent.Click += new System.EventHandler(this.textContent_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(528, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "(만원)";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(701, 68);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(310, 255);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // applyBtn
            // 
            this.applyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.applyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyBtn.ForeColor = System.Drawing.Color.White;
            this.applyBtn.Location = new System.Drawing.Point(480, 696);
            this.applyBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(195, 66);
            this.applyBtn.TabIndex = 16;
            this.applyBtn.Text = "등록하기";
            this.applyBtn.UseVisualStyleBackColor = false;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            this.applyBtn.Leave += new System.EventHandler(this.applyBtn_Leave);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(177, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 37);
            this.label9.TabIndex = 22;
            this.label9.Text = "직종";
            // 
            // textField
            // 
            this.textField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textField.Location = new System.Drawing.Point(323, 179);
            this.textField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textField.Name = "textField";
            this.textField.Size = new System.Drawing.Size(249, 38);
            this.textField.TabIndex = 23;
            // 
            // Menu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textField);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textContent);
            this.Controls.Add(this.deadLineTime);
            this.Controls.Add(this.textPlace);
            this.Controls.Add(this.textPay);
            this.Controls.Add(this.textSubject);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu1";
            this.Size = new System.Drawing.Size(1137, 794);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

            #endregion

            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.Label label4;
            private System.Windows.Forms.Label label5;
            private System.Windows.Forms.Label label6;
            private System.Windows.Forms.TextBox textSubject;
            private System.Windows.Forms.TextBox textPay;
            private System.Windows.Forms.TextBox textPlace;
            private System.Windows.Forms.DateTimePicker deadLineTime;
            private System.Windows.Forms.TextBox textContent;
            private System.Windows.Forms.Label label8;
            private System.Windows.Forms.PictureBox pictureBox2;
            private System.Windows.Forms.Button applyBtn;
            private System.Windows.Forms.Label label9;
            private System.Windows.Forms.TextBox textField;
      }
}
