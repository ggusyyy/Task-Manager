using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class FormSeeAllTasks : Form
    {
        TaskManager taskManager;

        public FormSeeAllTasks(TaskManager taskManager)
        {
            this.taskManager = taskManager;
            InitializeComponent();
            ShowAllTasks();
        }

        private void backToMainFormBtn_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show(
                "¿Volver al menú principal?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );
            if (exit == DialogResult.Yes)
            {
                this.Hide();
                taskManager.Show();
            }
        }

        private void ShowAllTasks()
        {
            seeAllTasksListBox.Items.Clear();

            foreach (string task in taskManager.userTasks)
            {
                seeAllTasksListBox.Items.Add(task);
            }
        }
    }
}
