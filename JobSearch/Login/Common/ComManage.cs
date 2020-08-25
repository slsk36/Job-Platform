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
    public partial class ComManage : Form
    {
        //DB연결
        string strconn = DBConnection.strconn;

        // 현재 클릭한 기업의 id
        string current_com_id;

        public ComManage()
        {
            InitializeComponent();
        }

        private void ComManage_Load(object sender, EventArgs e)
        {
            select_all();
        }
        private void select_all()
        {
            SqlConnection sqlcon = new SqlConnection(strconn);
            try
            {
                //기업회원으로 가입한 회사의 id와 회사이름을 데이터그리드뷰에 표시함
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("select * from COM_CUSTOMER", sqlcon);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);

                dataGridView1.Rows.Clear();
                initList(ds.Tables[0]);
            }
            catch (Exception)
            {
                MessageBox.Show("회사 리스트 조회 에러");
            }
            finally
            {
                if(sqlcon!=null)
                    sqlcon.Close();
            }
            
        }

        //기업회원으로 가입한 회사의 id와 회사이름을 데이터그리드뷰에 표시함
        private void initList(DataTable table)
        {
            int count = 1;
            foreach (DataRow row in table.Rows)
            {
                dataGridView1.Rows.Add(count, row["ID"], row["NAME"]);
                count++;
            }
        }
        
        private void btn_clear_Click(object sender, EventArgs e)
        {
            text_clean();
        }
        private void text_clean()
        {
            tb_comID.Text = "";
            tb_com_num.Text = "";
            tb_ap_count.ReadOnly = false;
            tb_star_pt.ReadOnly = false;
            tb_ap_count.Text = "";
            tb_com_addr.Text = "";
            tb_com_name.Text = "";
            tb_com_num.Text = "";
            tb_com_tel.Text = "";
            tb_field.Text = "";
            tb_sales.Text = "";
            tb_search.Text = "";
            tb_star_pt.Text = "";
        }

        //검색 버튼 클릭시
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
                SqlCommand cmd = new SqlCommand("select * from COM_CUSTOMER where COM_NAME LIKE '%'+ @com_name +'%'", sqlcon);
                cmd.Parameters.AddWithValue("@com_name", tb_search.Text);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);
                dataGridView1.Rows.Clear();
                initList(ds.Tables[0]);
            }
            catch (Exception)
            {
                MessageBox.Show("회사명 검색 에러");
            }
            finally
            {
                if(sqlcon!=null)
                    sqlcon.Close();
            }
        }

        //데이터 그리드뷰에 있는 회사를 클릭하면
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //id, 지원자수, 평점은 수정 불가능하게 설정
            tb_comID.ReadOnly = true;
            tb_ap_count.ReadOnly = true;
            tb_star_pt.ReadOnly = true;

            //아이디로 정보를 검색해서 텍스트 박스에 뿌려줌
            current_com_id = dataGridView1[1, e.RowIndex].Value.ToString();
            Console.WriteLine($"current_com_id={current_com_id}"); //test
            SqlConnection sqlcon = new SqlConnection(strconn);
            try
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand($"select * from COM_CUSTOMER where ID = '{current_com_id}'", sqlcon);
                //cmd.Parameters.AddWithValue("@com_id", current_com_id);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);

                DataRow row = ds.Tables[0].Rows[0];

                tb_comID.Text = row["ID"].ToString();
                tb_com_num.Text = row["COM_NUM"].ToString();
                tb_com_name.Text = row["COM_NAME"].ToString();
                tb_com_addr.Text = row["COM_ADDR"].ToString();
                //tb_field.Text = row["FIELD"].ToString();
                tb_com_tel.Text = row["COM_TEL"].ToString();
                //tb_sales.Text = row["SALES"].ToString();
                //tb_ap_count.Text = row["AP_COUNT"].ToString();
                //tb_star_pt.Text = row["STAR_PT"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("기업 정보 넘버조회 에러");
            }
            finally
            {
                if(sqlcon!=null)
                    sqlcon.Close();
            }
        }
        
        //데이터 그리드뷰의 내용을 두번 클릭
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //한번 클릭했을 때와 내용 동일
            tb_comID.ReadOnly = true;
            tb_ap_count.ReadOnly = true;
            tb_star_pt.ReadOnly = true;

            current_com_id = dataGridView1[1, e.RowIndex].Value.ToString();
            SqlConnection sqlcon = new SqlConnection(strconn);
            try
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("select * from COM_CUSTOMER where ID = @com_id", sqlcon);
                cmd.Parameters.AddWithValue("@com_id", current_com_id);
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);

                DataRow row = ds.Tables[0].Rows[0];
                tb_comID.Text = row["ID"].ToString();
                tb_com_num.Text = row["COM_NUM"].ToString();
                tb_com_name.Text = row["COM_NAME"].ToString();
                tb_com_addr.Text = row["COM_ADDR"].ToString();
                //tb_field.Text = row["FIELD"].ToString();
                tb_com_tel.Text = row["COM_TEL"].ToString();
                //tb_sales.Text = row["SALES"].ToString();
                //tb_ap_count.Text = row["AP_COUNT"].ToString();
                //tb_star_pt.Text = row["STAR_PT"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("기업정보 조회 에러");
            }
            finally
            {
                if(sqlcon!=null)
                    sqlcon.Close();
            }
        }


        //등록하기
        private void btn_insert_Click(object sender, EventArgs e)
        {
            tb_comID.ReadOnly = true;
            tb_ap_count.ReadOnly = true; 
            tb_star_pt.ReadOnly = true; 
            SqlConnection sqlcon = new SqlConnection(strconn);
            try
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("insert into COM_INFO values(@com_id,@com_num,@com_name,@com_addr,@field,@com_tel,@sales,@ap_count,@star_pt)", sqlcon);
                cmd.Parameters.AddWithValue("@com_id", tb_comID.Text);
                cmd.Parameters.AddWithValue("@com_num", tb_com_num.Text);
                cmd.Parameters.AddWithValue("@com_name", tb_com_name.Text);
                cmd.Parameters.AddWithValue("@com_addr", tb_com_addr.Text);
                cmd.Parameters.AddWithValue("@field", tb_field.Text);
                cmd.Parameters.AddWithValue("@com_tel", tb_com_tel.Text);
                cmd.Parameters.AddWithValue("@sales", tb_sales.Text);
                cmd.Parameters.AddWithValue("@ap_count", tb_ap_count.Text);
                cmd.Parameters.AddWithValue("@star_pt", tb_star_pt.Text);
                cmd.ExecuteNonQuery();
                
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.StackTrace);
                
            }
            finally
            {
                if(sqlcon!=null)
                    sqlcon.Close();
                select_all();
                MessageBox.Show("등록되었습니다");
                text_clean();
            }
        }


        //수정하기
        private void btn_update_Click(object sender, EventArgs e)
        {
            //아이디, 지원자수, 평점은 수정 불가능하게 셋팅
            tb_comID.ReadOnly = true;
            tb_ap_count.ReadOnly = true;
            tb_star_pt.ReadOnly = true;
            SqlConnection sqlcon = new SqlConnection(strconn);
            try
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("update COM_INFO set COM_NAME=@com_name, COM_ADDR=@com_addr, FIELD=@field, COM_TEL=@com_tel, SALES = @sales, AP_COUNT = @ap_count, STAR_PT = @star_pt where COM_NUM = @com_num", sqlcon);
                cmd.Parameters.AddWithValue("@com_name", tb_com_name.Text);
                cmd.Parameters.AddWithValue("@com_addr", tb_com_addr.Text);
                cmd.Parameters.AddWithValue("@field", tb_field.Text);
                cmd.Parameters.AddWithValue("@com_tel", tb_com_tel.Text);
                int sales = int.Parse(tb_sales.Text);
                cmd.Parameters.AddWithValue("@sales", sales);
                int ap_count = int.Parse(tb_ap_count.Text);
                cmd.Parameters.AddWithValue("@ap_count", ap_count);
                float star_pt = float.Parse(tb_star_pt.Text);
                cmd.Parameters.AddWithValue("@star_pt", star_pt);
                cmd.Parameters.AddWithValue("@com_num", tb_com_num.Text);
                cmd.ExecuteNonQuery();
                
            }
            catch(Exception ee)
            {
               MessageBox.Show("수정할수없음\r\n" + ee.StackTrace);
            }
            finally
            {
                if(sqlcon!=null)
                    sqlcon.Close();
                MessageBox.Show("수정되었습니다");
                select_all();
                
            }
            
        }

        //삭제하기
        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(strconn);
            try
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand($"delete from COM_INFO where COM_ID = '{tb_comID.Text}'", sqlcon);
                cmd.ExecuteNonQuery();
                Console.WriteLine("com_info delete ok");
                SqlCommand cmd1 = new SqlCommand($"delete from COM_CUSTOMER where ID = '{tb_comID.Text}'", sqlcon);
                cmd1.ExecuteNonQuery();
                Console.WriteLine("com_customer delete ok");
                SqlCommand cmd2 = new SqlCommand($"delete from RECRUIT where ID = '{tb_comID.Text}'", sqlcon);
                cmd2.ExecuteNonQuery();
                Console.WriteLine("recruit delete ok");

                select_all();
                text_clean();
            }
            catch(Exception ee)
            {
                MessageBox.Show("삭제할수없음\r\n"+ee.StackTrace);
            }
            finally
            {
                if(sqlcon!=null)
                sqlcon.Close();
                MessageBox.Show("삭제되었습니다");
            }
            
        }

        //새로고침
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            select_all();
        }
    }
}
