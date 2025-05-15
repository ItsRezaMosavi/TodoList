namespace TodoList2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmAdd().ShowDialog();
            dgvToDo.DataSource = clsToDoList.toDoList.ToList();
        }
        // int Row;
        private void btnSelect_Click(object sender, EventArgs e)
        {
            //Row = dgvToDo.CurrentRow.Index;
            //txtEdit.Text = clsToDoList.toDoList[Row].Name;
            //dtpEdit.Value = clsToDoList.toDoList[Row].Date_time;
            //chbDone.Checked = clsToDoList.toDoList[Row].Done;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //clsToDoList.toDoList[Row].Name = txtEdit.Text;
            //clsToDoList.toDoList[Row].Date_time = dtpEdit.Value.Date;
            //clsToDoList.toDoList[Row].Done = chbDone.Checked;
            //dgvToDo.DataSource = clsToDoList.toDoList.ToList();
            int Row = dgvToDo.CurrentRow.Index;
            //new frmEdit(Row).ShowDialog();
            new frmAdd(Row).ShowDialog();
            dgvToDo.DataSource = clsToDoList.toDoList.ToList();
        }

        private void dgvToDo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Row = dgvToDo.CurrentRow.Index;
            new frmAdd(Row).ShowDialog();
            dgvToDo.DataSource=clsToDoList.toDoList.ToList();
        }
    }
}
