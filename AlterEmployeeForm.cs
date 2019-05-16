using System;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class AlterEmployeeForm : Form
    {


        public AlterEmployeeForm()
        {
            InitializeComponent();
        }

        //定义一个长度为10的数组用来保存  要传递进来的字符串
        public string[] str = new string[10];


        //在窗体中加载的过程中 初始化 一些内容
        private void AlterEmployeeForm_Load(object sender, EventArgs e)
        {
            //读取数组对应索引中的值 并将它赋值给文本框 

            textBox1.Text = str[0];

            textBox2.Text = str[1];


            string temporary = str[2];

            textBox3.Text = str[3];
            dateTimePicker1.Text = str[4];
            comboBox1.Text = str[5];
            comboBox2.Text = str[6];
            comboBox3.Text = str[7];
            comboBox4.Text = str[8];
            textBox4.Text = str[9];
        }
    }
}
