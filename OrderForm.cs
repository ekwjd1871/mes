using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MES
{
    public partial class OrderForm : Form
    {
        MySqlConnection conn =
            new MySqlConnection("datasource=localhost;port=3307;Database=mes;username=root;password=1234");
        

        public OrderForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //텍스트박스에서 값을 가져오기
            string h1 = hTxt1.Text;
            string h2 = hTxt2.Text;
            string h3 = hTxt3.Text;
            string h4 = hTxt4.Text;
            string h5 = hTxt5.Text;
            string h6 = hTxt6.Text;
            string h7 = hTxt7.Text;

            string b1 = bTxt1.Text;
            string b2 = bTxt2.Text;
            string b3 = bTxt3.Text;
            string b4 = bTxt4.Text;
            string b5 = bTxt5.Text;
            string b6 = bTxt6.Text;
            string b7 = bTxt7.Text;
            string b8 = bTxt8.Text;
            string b9 = bTxt9.Text;
            string b10 = bTxt10.Text;
            string b11 = bTxt11.Text;
            string b12 = bTxt12.Text;
            string b13 = bTxt13.Text;
            string b14 = bTxt14.Text;
            string b15 = bTxt15.Text;

            
            string insertQuery =
                "START TRANSACTION;" +

                "INSERT INTO order_info_head(ORDER_NO, ORDER_GUBUN, ORDER_DATE, CUST_NO, MEMO, CREATEUSER, UPDATEUSER) " +
                "values('" + h1 + "' ,'" + h2 + "' ,'" + h3 + "' ,'" + h4 + "' ,'" + h5 + "' ,'" + h6 + "' ,'" + h7 + "');" +

                "INSERT INTO order_info_body(DATA_ID, ORDER_NO, ITEM_NO, ITEM_NAME, ITEM_CAPACITY, ITEM_QTY, SCHEDUL_DATE, RECIPIENT, RECIPIENT_TEL, RECIPIENT_ZIP, RECIPIENT_ADDRES, MEMO, STATUS, CREATEUSER, UPDATEUSER) " +
                "values('" + b1 + "' ,'" + b2 + "' ,'" + b3 + "' ,'" + b4 + "' ,'" + b5 + "' ,'" + b6 + "' ,'" + b7 + "' ,'" + b8 + "' ,'" + b9 + "' ,'" + b10 + "' ,'" + b11 + "' ,'" + b12 + "' ,'" + b13 + "' ,'" + b14 + "' ,'" + b15 + "');" +

                "COMMIT;";

            conn.Open();

            MySqlCommand command = new MySqlCommand(insertQuery, conn);

            command.ExecuteNonQuery();

            conn.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
