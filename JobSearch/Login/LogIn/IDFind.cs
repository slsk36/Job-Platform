﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class IDFind : Form
    {
        //마우스로 창 이동
        bool On;
        Point Pos;

        private string strconn = DBConnection.strconn;
        private string table_name = "";

        public IDFind()
        {
            InitializeComponent();
            rbtn_customer.Checked = true;
        }
        // 찾기 버튼 클릭
        private void btn_idFind_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand cmd;
            SqlDataAdapter sda;
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                if (rbtn_customer.Checked == true)
                {
                    table_name = "CUSTOMER";
                    cmd = new SqlCommand($"select ID from {table_name} where NAME = @NAME and PHONE = @PHONE and EMAIL = @EMAIL", conn);
                    cmd.Parameters.AddWithValue("@NAME", text_name.Text);
                    cmd.Parameters.AddWithValue("@PHONE", text_tel.Text);
                    cmd.Parameters.AddWithValue("@EMAIL", text_email.Text);
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    // db 정보 있을 경우
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow dr;
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            dr = ds.Tables[0].Rows[i];
                            string temp = (string)dr[0];
                            MessageBox.Show("아이디 : " + temp);
                        }
                    }
                    // db에 정보가 없을 경우
                    else
                    {
                        MessageBox.Show("등록된 회원 정보가 없습니다.");
                    }
                    //conn.Close();
                }
                else
                {
                    table_name = "COM_CUSTOMER";
                    cmd = new SqlCommand($"select ID from {table_name} where NAME = @NAME and PHONE = @PHONE and EMAIL = @EMAIL", conn);
                    cmd.Parameters.AddWithValue("@NAME", text_name.Text);
                    cmd.Parameters.AddWithValue("@PHONE", text_tel.Text);
                    cmd.Parameters.AddWithValue("@EMAIL", text_email.Text);
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    // db 정보 있을 경우
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow dr;
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            dr = ds.Tables[0].Rows[i];
                            string temp = (string)dr[0];
                            MessageBox.Show("아이디 : " + temp);
                        }
                    }
                    // db에 정보가 없을 경우
                    else
                    {
                        MessageBox.Show("등록된 회원 정보가 없습니다.");
                    }
                    //conn.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("에러");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            
        }
        //마우스로 창이동
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            On = true;
            Pos.X = e.X;
            Pos.Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (On == true)
            {
                this.SetDesktopLocation(MousePosition.X - Pos.X, MousePosition.Y - Pos.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            On = false;
        }

        private void textbox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = "";
        }

        private void text_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        //창 닫기
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
