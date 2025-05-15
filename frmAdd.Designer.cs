namespace TodoList2
{
    partial class frmAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAdd = new TextBox();
            dtpAdd = new DateTimePicker();
            btnAdd = new Button();
            chbDone = new CheckBox();
            SuspendLayout();
            // 
            // txtAdd
            // 
            txtAdd.Location = new Point(12, 41);
            txtAdd.Multiline = true;
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(475, 52);
            txtAdd.TabIndex = 0;
            // 
            // dtpAdd
            // 
            dtpAdd.Location = new Point(137, 166);
            dtpAdd.Name = "dtpAdd";
            dtpAdd.Size = new Size(200, 23);
            dtpAdd.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(166, 281);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // chbDone
            // 
            chbDone.AutoSize = true;
            chbDone.Location = new Point(187, 220);
            chbDone.Name = "chbDone";
            chbDone.Size = new Size(54, 19);
            chbDone.TabIndex = 3;
            chbDone.Text = "Done";
            chbDone.UseVisualStyleBackColor = true;
            // 
            // frmAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 376);
            Controls.Add(chbDone);
            Controls.Add(btnAdd);
            Controls.Add(dtpAdd);
            Controls.Add(txtAdd);
            Name = "frmAdd";
            Text = "frmAdd";
            Load += frmAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAdd;
        private DateTimePicker dtpAdd;
        private Button btnAdd;
        private CheckBox chbDone;
    }
}