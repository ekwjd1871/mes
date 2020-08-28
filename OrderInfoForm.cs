using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MES
{
    public partial class OrderInfoForm : Form
    {
        //SQL DB와 연결
        MySqlConnection conn = 
            new MySqlConnection("datasource=localhost;port=3307;Database=mes;username=root;password=1234");

        public OrderInfoForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {


            try {
                //SQL 명령어
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM order_info_head";

                //DataAdapter와 DataSet으로 DB table 불러오기
                MySqlDataAdapter da = new MySqlDataAdapter(cmd); //select 구문이 들어감
                DataSet ds = new DataSet();
                da.Fill(ds, "order_info_head");

                //dataGridView에 DB에서 가져온 데이터 입력하기
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "order_info_head";
            }
            catch(MySqlException ex)
            {

            }
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string s = dataGridView1.CurrentRow.Cells[0].FormattedValue.ToString();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM order_info_body " + "WHERE ORDER_NO = '" + s + "';";

            //DataAdapter와 DataSet으로 DB table 불러오기
            MySqlDataAdapter da = new MySqlDataAdapter(cmd); //select 구문이 들어감
            DataSet ds = new DataSet();
            da.Fill(ds, "order_info_body");

            //dataGridView에 DB에서 가져온 데이터 입력하기
            dataGridView2.DataSource = ds;
            dataGridView2.DataMember = "order_info_body";

            conn.Close();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //새창 띄우기
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) //새로고침 버튼
        {
            OrderForm_Load(sender, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
