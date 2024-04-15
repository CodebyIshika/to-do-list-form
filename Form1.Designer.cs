namespace ToDoListForm
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            TaskId = new DataGridViewTextBoxColumn();
            TaskName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            DueDate = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            txtName = new TextBox();
            txtDescribe = new TextBox();
            txtStatus = new TextBox();
            name = new Label();
            describ = new Label();
            date = new Label();
            taskStatus = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtDate = new TextBox();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TaskId, TaskName, Description, DueDate, Status });
            dataGridView1.Location = new Point(247, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(541, 283);
            dataGridView1.TabIndex = 0;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // TaskId
            // 
            TaskId.DataPropertyName = "TaskId";
            TaskId.HeaderText = "TaskId";
            TaskId.MinimumWidth = 6;
            TaskId.Name = "TaskId";
            TaskId.Visible = false;
            TaskId.Width = 125;
            // 
            // TaskName
            // 
            TaskName.DataPropertyName = "TaskName";
            TaskName.HeaderText = "Task Name";
            TaskName.MinimumWidth = 6;
            TaskName.Name = "TaskName";
            TaskName.Width = 125;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 125;
            // 
            // DueDate
            // 
            DueDate.DataPropertyName = "DueDate";
            DueDate.HeaderText = "Due Date";
            DueDate.MinimumWidth = 6;
            DueDate.Name = "DueDate";
            DueDate.Width = 125;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // txtName
            // 
            txtName.Location = new Point(105, 91);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 1;
            // 
            // txtDescribe
            // 
            txtDescribe.Location = new Point(105, 155);
            txtDescribe.Name = "txtDescribe";
            txtDescribe.Size = new Size(125, 27);
            txtDescribe.TabIndex = 2;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(105, 285);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(125, 27);
            txtStatus.TabIndex = 4;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(7, 91);
            name.Name = "name";
            name.Size = new Size(80, 20);
            name.TabIndex = 5;
            name.Text = "Task Name";
            // 
            // describ
            // 
            describ.AutoSize = true;
            describ.Location = new Point(2, 155);
            describ.Name = "describ";
            describ.Size = new Size(85, 20);
            describ.TabIndex = 6;
            describ.Text = "Description";
            // 
            // date
            // 
            date.AutoSize = true;
            date.Location = new Point(7, 220);
            date.Name = "date";
            date.Size = new Size(72, 20);
            date.TabIndex = 7;
            date.Text = "Due Date";
            // 
            // taskStatus
            // 
            taskStatus.AutoSize = true;
            taskStatus.Location = new Point(12, 288);
            taskStatus.Name = "taskStatus";
            taskStatus.Size = new Size(49, 20);
            taskStatus.TabIndex = 8;
            taskStatus.Text = "Status";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(15, 348);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 395);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(127, 348);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(105, 220);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(125, 27);
            txtDate.TabIndex = 13;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(127, 395);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(txtDate);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(taskStatus);
            Controls.Add(date);
            Controls.Add(describ);
            Controls.Add(name);
            Controls.Add(txtStatus);
            Controls.Add(txtDescribe);
            Controls.Add(txtName);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtName;
        private TextBox txtDescribe;
        private TextBox txtStatus;
        private Label name;
        private Label describ;
        private Label date;
        private Label taskStatus;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtDate;
        private Button btnCancel;
        private DataGridViewTextBoxColumn TaskId;
        private DataGridViewTextBoxColumn TaskName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn DueDate;
        private DataGridViewTextBoxColumn Status;
    }
}
