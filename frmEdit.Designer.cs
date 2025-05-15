namespace TodoList2
{
    partial class frmEdit
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
            chbDone = new CheckBox();
            btnEdit = new Button();
            dtpEdit = new DateTimePicker();
            txtEdit = new TextBox();
            SuspendLayout();
            // 
            // chbDone
            // 
            chbDone.AutoSize = true;
            chbDone.Location = new Point(137, 164);
            chbDone.Name = "chbDone";
            chbDone.Size = new Size(54, 19);
            chbDone.TabIndex = 0;
            chbDone.Text = "Done";
            chbDone.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(100, 212);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(124, 46);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // dtpEdit
            // 
            dtpEdit.Location = new Point(61, 97);
            dtpEdit.Name = "dtpEdit";
            dtpEdit.Size = new Size(200, 23);
            dtpEdit.TabIndex = 2;
            // 
            // txtEdit
            // 
            txtEdit.Location = new Point(12, 46);
            txtEdit.Name = "txtEdit";
            txtEdit.Size = new Size(307, 23);
            txtEdit.TabIndex = 3;
            // 
            // frmEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 450);
            Controls.Add(txtEdit);
            Controls.Add(dtpEdit);
            Controls.Add(btnEdit);
            Controls.Add(chbDone);
            Name = "frmEdit";
            Text = "frmEdit";
            Load += frmEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chbDone;
        private Button btnEdit;
        private DateTimePicker dtpEdit;
        private TextBox txtEdit;
    }
}