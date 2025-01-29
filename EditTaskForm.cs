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
    public partial class EditTaskForm : Form
    {
        TaskManager taskManager;

        public EditTaskForm(TaskManager taskManager)
        {
            this.taskManager = taskManager;
            InitializeComponent();
            ShowAllTasks();
        }

        private void exitBtn_Click(object sender, EventArgs e)
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
            editTaskListBox.Items.Clear();

            foreach (string task in taskManager.userTasks)
            {
                editTaskListBox.Items.Add(task);
            }
        }

        private void editTaskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            editTaskListBox.Visible = false;
            newTaskNameLbl.Visible = true;
            newTaskNameTextBox.Visible = true;
            addNewTaskNameBtn.Visible = true;

            newTaskNameTextBox.Text = editTaskListBox.SelectedItem.ToString();
        }

        private void addNewTaskNameBtn_Click(object sender, EventArgs e)
        {
            if (newTaskNameTextBox.Text.Length < 3)
            {
                MessageBox.Show(
                    "Ingresa al menos tres caracteres.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
                return;
            }

            int index = taskManager.userTasks.IndexOf(editTaskListBox.SelectedItem.ToString()); // get the index of the selected task
            taskManager.userTasks[index] = newTaskNameTextBox.Text; // replace the old task
            MessageBox.Show(
                "Tarea editada correctamente!", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );

            ShowAllTasks();

            addNewTaskNameBtn.Visible = false;
            newTaskNameLbl.Visible = false;
            newTaskNameTextBox.Visible = false;
            editTaskListBox.Visible = true;
        }
    }
}
