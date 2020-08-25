using System;
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
    public partial class 회원관리 : Form
    {
        //DB연결
        string strconn = DBConnection.strconn;
        // 현재 클릭한 개인회원의 id
        string current_id;

        public 회원관리()
        {
            InitializeComponent();
        }

        private void 회원관리_Load(object sender, EventArgs e)
        {
            selectAll();
        }

        private void selectAll()
        {
            SqlConnection sqlcon = new SqlConnection(strconn);
            try
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("select * from CUSTOMER",sqlcon);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);

                dataGridView1.Rows.Clear();
                //개인회원으로 가입한 개인의 정보를 데이터그리드뷰에 표시
                initList(ds.Tables[0]);
            }
            catch (Exception)
            {
                MessageBox.Show("개인회원 리스트 가져오기 에러");
            }
            finally
            {
                if (sqlcon != null)
                    sqlcon.Close();
            }
        }

        //개인회원으로 가입한 개인의 정보를 데이터그리드뷰에 표시
        private void initList(DataTable table)
        {
            int count = 1;
            foreach (DataRow row in table.Rows)
            {
                dataGridView1.Rows.Add(count, row["ID"], row["NAME"]);
                count++;
            }
        }

        //리셋 버튼
        private void btn_clear_Click(object sender, EventArgs e)
        {
            text_clean();
        }

        private void text_clean()
        {
            tb_ID.Text = "";
            tb_pw.Text = "";
            tb_name.Text = "";
            tb_email.Text = "";
            tb_addr.Text = "";
            tb_tel.Text = "";
        }

        //검색버튼
        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }
        private void search()
        {
            //이름 기준 검색
            SqlConnection sqlcon = new SqlConnection(strconn);
            try
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand($"select * from CUSTOMER where NAME LIKE '%'+'{tb_search.Text}'+'%'",sqlcon);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);
                dataGridView1.Rows.Clear();
                initList(ds.Tables[0]);
            }
            catch (Exception)
            {
                MessageBox.Show("회원이름 검색 에러");
            }
            finally
            {
                if (sqlcon != null)
                    sqlcon.Close();
            }
        }

        //데이터그리드뷰에 있는 이름을 클릭하면
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //아이디로 정보를 검색해서 텍스트 박스에 뿌려줌
            current_id = dataGridView1[1, e.RowIndex].Value.ToString();
            Console.WriteLine($"current_id= {current_id}");  //test
            SqlConnection sqlcon = new SqlConnection(strconn);
            try
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand($"select * from CUSTOMER where ID = '{current_id}'", sqlcon);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);

                DataRow row = ds.Tables[0].Rows[0];

                tb_ID.Text = row["ID"].ToString();
                tb_pw.Text = row["PW"].ToString();
                tb_name.Text = row["NAME"].ToString();
                tb_addr.Text = row["ADDR"].ToString();
                tb_email.Text = row["EMAIL"].ToString();
                tb_tel.Text = row["PHONE"].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("회원정보 불러오기 오류");
            }
            finally
            {
                if (sqlcon != null)
                    sqlcon.Close();
            }

        }

        //수정하기
        private void btn_update_Click(object sender, EventArgs e)
        {
            
            SqlConnection sqlcon = new SqlConnection(strconn);
            try
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("update CUSTOME set ID= @id, PW=@pw, NAME=@name, ADDR=@addr, EMAIL=@email, PHONE=@tel", sqlcon);
                cmd.Parameters.AddWithValue("@id", tb_ID.Text);
                cmd.Parameters.AddWithValue("@pw", tb_pw.Text);
                cmd.Parameters.AddWithValue("@name", tb_name.Text);
                cmd.Parameters.AddWithValue("@addr", tb_addr.Text);
                cmd.Parameters.AddWithValue("@email", tb_email.Text);
                cmd.Parameters.AddWithValue("@tel", tb_tel.Text);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ee)
            {
                MessageBox.Show("수정할수없음\r\n" + ee.StackTrace);
            }
            finally
            {
                if (sqlcon != null)
                    sqlcon.Close();
                MessageBox.Show("수정되었습니다");
                selectAll();

            }
        }

        //삭제하기
        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(strconn);
            sqlcon.Open();

            if (tb_ID.Text == "admin")
            {
                MessageBox.Show("관리자는 삭제할수없습니다");
                sqlcon.Close();
            }
            else
            { 
                try
                {
                    SqlCommand cmd = new SqlCommand($"delete from CUSTOMER where ID = '{tb_ID.Text}'", sqlcon);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("customer delete ok");
                    SqlCommand cmd1 = new SqlCommand($"delete from review where rev_id = '{tb_ID.Text}'", sqlcon);
                    cmd1.ExecuteNonQuery();
                    Console.WriteLine("review delete ok");
                    SqlCommand cmd2 = new SqlCommand($"delete from RESUME where id = '{tb_ID.Text}'", sqlcon);
                    cmd2.ExecuteNonQuery();
                    Console.WriteLine("이력서 delete ok");
                    SqlCommand cmd3 = new SqlCommand($"delete from A_LIST where A_ID = '{tb_ID.Text}'", sqlcon);
                    cmd3.ExecuteNonQuery();
                    Console.WriteLine("A_LIST delete ok");

                    selectAll();
                    text_clean();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("삭제오류\r\n" + ex.StackTrace);
                }
                finally
                {
                    if (sqlcon != null)
                        sqlcon.Close();
                    MessageBox.Show("고객의 정보가 완전히 삭제되었습니다.");
                }
            }
        }

       

        //새로고침
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            selectAll();
        }
    }
}
