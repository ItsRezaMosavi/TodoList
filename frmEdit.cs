using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList2
{
    public partial class frmEdit : Form
    {
        int index = 0;
        public frmEdit(int i = 0)
        {
            InitializeComponent();
            index = i;
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            txtEdit.Text = clsToDoList.toDoList[index].Name;
            dtpEdit.Value = clsToDoList.toDoList[index].Date_time;
            chbDone.Checked = clsToDoList.toDoList[index].Done;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            clsToDoList.toDoList[index].Name = txtEdit.Text;
            clsToDoList.toDoList[index].Date_time = dtpEdit.Value.Date;
            clsToDoList.toDoList[index].Done = chbDone.Checked;
            this.Close();
        }
    }
}
