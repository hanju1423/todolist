using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todo
{
    public partial class ToDoList : Form
    {
        public ToDoList()

        {
            InitializeComponent();
        }
        DataTable todolist = new DataTable();
        bool isEditing = false;


        private void label2_Click(object sender, EventArgs e)
        {
            // 여기에 클릭 이벤트 처리 코드를 작성하세요.
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 여기에 셀 클릭 이벤트 처리 코드를 작성하세요.
        }
        private void toDoList_Load(object sender,EventArgs e)
        {
            todolist.Columns.Add("title");
            todolist.Columns.Add("description");
            toDoListView.DataSource = todolist;
        }

        //private void toDoList_Load(object sender, EventArgs e)
        //{

       // }
        private void newbutton_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = "";
            descriptionTextbox.Text = "";  //텍스트박스입력전에 초기화 

        }
        private void editbutton_Click(object sender, EventArgs e)
        {
            isEditing = true;
            titleTextBox.Text = todolist.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            descriptionTextbox.Text = todolist.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try //예외가 발생할수잇는 코드르 감싸는것 
            {

            }
            catch (Exception ex) //예외 발생시 발생하는 code 
            {
                Console.WriteLine("Error:" + ex);  //그때 출력된느 것 
            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (isEditing) // 편집 모드인지 확인 하는 문구 
            {

            }
            else
            {
                todolist.Rows.Add(titleTextBox.Text,descriptionTextbox.Text); //새로운 행을 추가하는 메소드. 새로운행 추가 

            }
            titleTextBox.Text = ""; // 리셋하는 것 
            descriptionTextbox.Text = "";
            isEditing = false; //편집모드 종료 

        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptionTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newButton_Click_1(object sender, EventArgs e)
        {

        }

        private void editbutton_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
