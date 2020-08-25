namespace Login.Individual.JobRecruitment
{
      partial class checkApply
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
            this.label1 = new System.Windows.Forms.Label();
            this.Apply_Ok_btn = new System.Windows.Forms.Button();
            this.Apply_Cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "지원 하시겠습니까 ?";
            // 
            // Apply_Ok_btn
            // 
            this.Apply_Ok_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Apply_Ok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Apply_Ok_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apply_Ok_btn.ForeColor = System.Drawing.Color.White;
            this.Apply_Ok_btn.Location = new System.Drawing.Point(61, 117);
            this.Apply_Ok_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Apply_Ok_btn.Name = "Apply_Ok_btn";
            this.Apply_Ok_btn.Size = new System.Drawing.Size(134, 57);
            this.Apply_Ok_btn.TabIndex = 4;
            this.Apply_Ok_btn.Text = "확인";
            this.Apply_Ok_btn.UseVisualStyleBackColor = false;
            this.Apply_Ok_btn.Click += new System.EventHandler(this.Apply_Ok_btn_Click);
            // 
            // Apply_Cancel_btn
            // 
            this.Apply_Cancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Apply_Cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Apply_Cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apply_Cancel_btn.ForeColor = System.Drawing.Color.White;
            this.Apply_Cancel_btn.Location = new System.Drawing.Point(210, 117);
            this.Apply_Cancel_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Apply_Cancel_btn.Name = "Apply_Cancel_btn";
            this.Apply_Cancel_btn.Size = new System.Drawing.Size(134, 57);
            this.Apply_Cancel_btn.TabIndex = 5;
            this.Apply_Cancel_btn.Text = "취소";
            this.Apply_Cancel_btn.UseVisualStyleBackColor = false;
            this.Apply_Cancel_btn.Click += new System.EventHandler(this.Apply_Cancel_btn_Click);
            // 
            // checkApply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 201);
            this.Controls.Add(this.Apply_Cancel_btn);
            this.Controls.Add(this.Apply_Ok_btn);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(50, 50);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "checkApply";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "checkApply";
            this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Button Apply_Ok_btn;
            private System.Windows.Forms.Button Apply_Cancel_btn;
      }
}