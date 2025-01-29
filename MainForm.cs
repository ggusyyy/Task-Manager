using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TaskManager
{
    public partial class TaskManager : Form
    {
        public List<string> userTasks = new List<string>();
        public readonly string pathTasks = "tareas.txt";

        public TaskManager()
        {
            InitializeComponent();
            this.FormClosing += TaskManager_FormClosing;
            GetAllTasksFromFile(pathTasks);
        }

        private void TaskManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllLines(pathTasks, userTasks);
        }

        private void GetAllTasksFromFile(string path)
        {
            foreach (string task in File.ReadAllLines(path))
            {
                userTasks.Add(task);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show(
                "¿Salir del programa?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                );
            if (DialogResult.Yes == exit)
            {
                Application.Exit();
            }
        }


        private void AddTaskFormBtn_Click(object sender, EventArgs e)
        {
            FormAddTask formAddTask = new FormAddTask(this);
            this.Hide();
            formAddTask.Show();
        }


        private void seeAllTasksFormBtn_Click(object sender, EventArgs e)
        {
            FormSeeAllTasks formSeeAllTasks = new FormSeeAllTasks(this);
            this.Hide();
            formSeeAllTasks.Show();
        }


        private void deleteTaskFormBtn_Click(object sender, EventArgs e)
        {
            DeleteTaskForm deleteTaskForm = new DeleteTaskForm(this);
            this.Hide();
            deleteTaskForm.Show();
        }

        private void editTaskFormBtn_Click(object sender, EventArgs e)
        {
            EditTaskForm editTaskForm = new EditTaskForm(this);
            this.Hide();
            editTaskForm.Show();
        }
    }
}
