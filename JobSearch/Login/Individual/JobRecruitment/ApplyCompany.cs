using Login.Individual.JobRecruitment;
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

namespace Login.Individual.CompanyInfo
{
      public partial class ApplyCompany : Form
      {
            string strconn = DBConnection.strconn;
            PostInfo pi = new PostInfo();

            public ApplyCompany()
            {
                  InitializeComponent();
            }

            
            public string applysbj { get { return apply_subject.Text; } set { apply_subject.Text = value; } }
            public string apply_com_name { get { return Apply_Com_Name.Text; } set { Apply_Com_Name.Text = value; } }
            public string applyfield { get { return apply_field.Text; } set { apply_field.Text = value; } }
            public int applypay { get { return int.Parse(apply_pay.Text); } set { apply_pay.Text = string.Format("{0}", value.ToString("#,##0")) + " 원"; } }
            public string applyplace { get { return apply_place.Text; } set { apply_place.Text = value; } }
            //public string applystart { get { return apply_start.Text; } set { apply_start.Text = value; } }
            //public string applyfinish { get { return apply_finish.Text; } set { apply_finish.Text = value; } }
            public string applydead { get { return apply_dead.Text; } set { apply_dead.Text = value; } }
            public string applycontent { get { return Content_Text.Text; } set { Content_Text.Text = value; } }
            public int applycount { get { return int.Parse(apply_count.Text); } set { apply_count.Text = string.Format("{0}", value.ToString("#,##0")) + "회"; } }
            public int applyacount { get { return int.Parse(apply_acount.Text); } set { apply_acount.Text = string.Format("{0}", value.ToString("#,##0")) + "명"; } }
           

            private void ApplyCompany_Load(object sender, EventArgs e)
            {
                  
                        SqlConnection sqlcon = new SqlConnection(strconn);
                  try
                  {
                        
                        sqlcon.Open();
                        string cmdText = "select * from RECRUIT where W_NUM = @w_num";
                        SqlCommand cmd = new SqlCommand(cmdText, sqlcon);
                        cmd.CommandText = cmdText;
                        cmd.Parameters.AddWithValue("@w_num", PostInfo.getWnum());
                        DataSet ds = new DataSet();
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        adpt.Fill(ds);
                        SqlDataReader DR = cmd.ExecuteReader();

                        if (DR.HasRows)
                        {
                              while (DR.Read())
                              {
           
                                    applysbj = DR["SUBJECT"].ToString();
                                    apply_com_name = DR["COM_NAME"].ToString();
                                    applyfield = DR["FIELD"].ToString();
                                    int paid;
                                    int.TryParse(DR["PAY"].ToString(), out paid);
                                    applypay = paid;
                                    applyplace = DR["W_PLACE"].ToString();
                                    //applystart = DR["W_START_TIME"].ToString();
                                    //applyfinish = DR["W_END_TIME"].ToString();
                                    applydead = DR["PERIOD"].ToString();
                                    applycontent = DR["W_CONTENT"].ToString();
                                    int count=0;
                                    int acount=0;
                                    int.TryParse(DR["COUNT"].ToString(), out count);
                                    applycount = count;
                                    int.TryParse(DR["A_COUNT"].ToString(), out acount);
                                    applyacount = acount;

                              }
                        }
                
                DR.Close();
                //해당 공고의 조회수 증가
                cmd.CommandText = "update RECRUIT set COUNT = (select COUNT from RECRUIT where W_NUM = @w_num3)+1 where W_NUM = @w_num4";
                cmd.Parameters.AddWithValue("@w_num3", PostInfo.getWnum());
                cmd.Parameters.AddWithValue("@w_num4", PostInfo.getWnum());
                cmd.ExecuteNonQuery();

            }
                  catch (Exception ee)
                  {
                        MessageBox.Show(ee.Message);
                        MessageBox.Show(ee.StackTrace);

                  }
                  finally
                  {
                        sqlcon.Close();
       
                  }
            }
        private bool checkResume = false;
        //지원하기
        private void button1_Click(object sender, EventArgs e)
        {
            readRESUMEInfo();
            if (IMemberMainForm.getID() == "admin")
            {
                MessageBox.Show("관리자 모드입니다");
            }
            //이력서 없으면 지원불가
            else if(checkResume == false )
            {
            MessageBox.Show("이력서 작성후 지원 가능합니다");
            }
            else
            {
                checkApply ca = new checkApply();
                ca.Show();
            
            }
            this.Close();
        }
        
        //이력서 있는지 확인
        public void readRESUMEInfo() 
        {
            SqlConnection sqlcon = new SqlConnection(strconn);
            try
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("select * from RESUME where id = @id", sqlcon);
                cmd.Parameters.AddWithValue("@id", IMemberMainForm.getID());
                DataSet ds = new DataSet();
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(ds);
                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {

                        if (DR["ID"].ToString() == IMemberMainForm.getID())
                        {
                            checkResume = true;
                        }
                    }
                }
                DR.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("error");
            }
            finally
            {
                if (sqlcon != null)
                    sqlcon.Close();
            }


        }

        //지원취소
        private bool checkAinfo = false;
        private void Apply_Cancle_Click(object sender, EventArgs e)
        {
            //지원내역 없으면 취소불가
            readApplyInfo();
            if (checkAinfo == false)
            {
                MessageBox.Show("지원내역이 없습니다");
            }
            else
            {
                //해당공고에 지원내역 있으면 삭제
                try
                {
                    SqlConnection sqlcon = new SqlConnection(strconn);
                    sqlcon.Open();
                    SqlCommand cmd = new SqlCommand($"delete from A_LIST where W_NUM = @w_num and A_ID = '{IMemberMainForm.getID()}'", sqlcon);
                    cmd.Parameters.AddWithValue("@w_num", PostInfo.getWnum());
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("A_LIST delete ok"); //테스트
                    

                    //해당 공고의 지원자 수 감소
                    cmd.CommandText = "Update RECRUIT set A_COUNT = (select A_COUNT from RECRUIT where W_NUM = @w_num1)-1 where W_NUM = @w_num2";
                    cmd.Parameters.AddWithValue("@w_num1", PostInfo.getWnum());
                    cmd.Parameters.AddWithValue("@w_num2", PostInfo.getWnum());
                    cmd.ExecuteNonQuery();

                    //회사 정보 폼의 회사 지원수 감소
                    cmd.CommandText = "select * from COM_INFO where COM_NAME = @com_name";
                    cmd.Parameters.AddWithValue("@com_name", PostInfo.getCname());
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        int a_count = int.Parse(dr["AP_COUNT"].ToString());
                        cmd.CommandText = $"update COM_INFO set AP_COUNT = AP_COUNT-1 where COM_NAME = '{PostInfo.getCname()}'";
                        //cmd.Parameters.AddWithValue("@a_count", a_count+1);
                        Console.WriteLine($"{PostInfo.getCname()} = 회사이름 확인");
                        Console.WriteLine($"{a_count -1} = 지원자수 감소확인");
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("지원취소 되었습니다");

                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);

                }
                finally
                {
                    this.Close();

                }

            }
            
        }
        

        //지원 내역 있는지 확인
        public void readApplyInfo()
        {
            SqlConnection sqlcon = new SqlConnection(strconn);
            try
            {
                sqlcon.Open();
                string cmdText = "select * from A_LIST where W_NUM = @w_num";
                SqlCommand cmd = new SqlCommand(cmdText, sqlcon);
                cmd.CommandText = cmdText;
                cmd.Parameters.AddWithValue("@w_num", PostInfo.getWnum());
                DataSet ds = new DataSet();
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(ds);
                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {

                        if (DR["A_ID"].ToString() == IMemberMainForm.getID())
                        {
                            checkAinfo = true;
                            this.Close();
                        }

                    }
                }
                DR.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                MessageBox.Show(ee.StackTrace);
            }
        }
    }
}
