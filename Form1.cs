using System.Globalization;
using System.Windows.Forms;
using System.Xml.Linq;
using ToDoListForm.Context;
using ToDoListForm.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ToDoListForm
{
    public partial class Form1 : Form
    {
        TaskContext context = new TaskContext();
        TaskEntity task = new TaskEntity();
        public Form1()
        {
            InitializeComponent();
            LoadGridView();
        }


        private void LoadGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = context.Tasks.ToList();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if(dataGridView1.CurrentCell.RowIndex != -1)
            {
                int taskId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["TaskId"].Value);
                task = context.Tasks.FirstOrDefault(x => x.TaskId == taskId);
                txtName.Text = dataGridView1.CurrentRow.Cells["TaskName"].Value.ToString();
                txtDescribe.Text = task.Description;
                txtStatus.Text = task.Status.ToString() ;
                txtDate.Text = task.DueDate?.ToString() ;
            }
           
        }


        public void ClearTextBoxes()
        {
            txtName.Text = txtDescribe.Text = txtDate.Text = txtStatus.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TaskEntity taskAdd = new TaskEntity();
            taskAdd.TaskName = txtName.Text;
            taskAdd.Description = txtDescribe.Text;
            // Validate and parse the due date
            if (DateTime.TryParseExact(txtDate.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime dueDate))
            {
                task.DueDate = dueDate;
            }
            else
            {
                MessageBox.Show("Incorrect date format. Please enter the date in dd/MM/yyyy format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            taskAdd.Status = txtStatus.Text;

            context.Tasks.Add(taskAdd);
            context.SaveChanges();

            ClearTextBoxes();

            LoadGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            task.TaskName = txtName.Text;
            task.Description = txtDescribe.Text;
            // Validate and parse the due date
            if (DateTime.TryParseExact(txtDate.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime dueDate))
            {
                task.DueDate = dueDate;
            }
            else
            {
                MessageBox.Show("Incorrect date format. Please enter the date in dd/MM/yyyy format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            task.Status = txtStatus.Text;
            context.Entry(task).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            LoadGridView();

            ClearTextBoxes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected task from the DataGridView
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int taskId = Convert.ToInt32(selectedRow.Cells["TaskId"].Value);
                TaskEntity selectedTask = context.Tasks.FirstOrDefault(t => t.TaskId == taskId);

                if (selectedTask != null)
                {
                    // Remove the selected task from the database
                    context.Tasks.Remove(selectedTask);
                    context.SaveChanges();

                    LoadGridView();

                    ClearTextBoxes();
                }
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

    }
}
