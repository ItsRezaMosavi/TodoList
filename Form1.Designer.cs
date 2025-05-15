namespace TodoList2
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            dgvToDo = new DataGridView();
            btnEdit = new Button();
            txtEdit = new TextBox();
            dtpEdit = new DateTimePicker();
            chbDone = new CheckBox();
            btnSelect = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvToDo).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1, 618);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(387, 67);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvToDo
            // 
            dgvToDo.AllowUserToResizeColumns = false;
            dgvToDo.AllowUserToResizeRows = false;
            dgvToDo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvToDo.Location = new Point(1, 34);
            dgvToDo.Name = "dgvToDo";
            dgvToDo.RowTemplate.ReadOnly = true;
            dgvToDo.Size = new Size(387, 567);
            dgvToDo.TabIndex = 1;
            dgvToDo.CellMouseDoubleClick += dgvToDo_CellMouseDoubleClick;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(485, 375);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(160, 67);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtEdit
            // 
            txtEdit.Enabled = false;
            txtEdit.Location = new Point(416, 127);
            txtEdit.Multiline = true;
            txtEdit.Name = "txtEdit";
            txtEdit.Size = new Size(283, 61);
            txtEdit.TabIndex = 3;
            txtEdit.Visible = false;
            // 
            // dtpEdit
            // 
            dtpEdit.Enabled = false;
            dtpEdit.Location = new Point(447, 244);
            dtpEdit.Name = "dtpEdit";
            dtpEdit.Size = new Size(200, 23);
            dtpEdit.TabIndex = 4;
            dtpEdit.Visible = false;
            // 
            // chbDone
            // 
            chbDone.AutoSize = true;
            chbDone.Enabled = false;
            chbDone.Location = new Point(524, 316);
            chbDone.Name = "chbDone";
            chbDone.Size = new Size(54, 19);
            chbDone.TabIndex = 5;
            chbDone.Text = "Done";
            chbDone.UseVisualStyleBackColor = true;
            chbDone.Visible = false;
            // 
            // btnSelect
            // 
            btnSelect.Enabled = false;
            btnSelect.Location = new Point(485, 51);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(145, 51);
            btnSelect.TabIndex = 6;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Visible = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 697);
            Controls.Add(btnSelect);
            Controls.Add(chbDone);
            Controls.Add(dtpEdit);
            Controls.Add(txtEdit);
            Controls.Add(btnEdit);
            Controls.Add(dgvToDo);
            Controls.Add(btnAdd);
            Name = "frmMain";
            Text = "To Do List";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvToDo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private DataGridView dgvToDo;
        private Button btnEdit;
        private TextBox txtEdit;
        private DateTimePicker dtpEdit;
        private CheckBox chbDone;
        private Button btnSelect;
    }
}
