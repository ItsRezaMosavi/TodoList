using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TodoList2
{
    public partial class frmAdd : Form
    {
        int index = -1;
        public frmAdd(int i = -1)
        {
            InitializeComponent();
            index = i;
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            if (index > -1)
            {
                txtAdd.Text = clsToDoList.toDoList[index].Name;
                dtpAdd.Value = clsToDoList.toDoList[index].Date_time;
                chbDone.Checked = clsToDoList.toDoList[index].Done;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (index > -1)
            {
                clsToDoList.toDoList[index].Name = txtAdd.Text;
                clsToDoList.toDoList[index].Date_time = dtpAdd.Value.Date;
                clsToDoList.toDoList[index].Done = chbDone.Checked;
                this.Close();
            }
            else
            {
                clsToDoList todo = new clsToDoList();
                todo.Date_time = dtpAdd.Value.Date;
                todo.Name = txtAdd.Text;
                clsToDoList.toDoList.Add(todo);
                MessageBox.Show("added successfully");
                this.Close();
            }
        }
    }
}
