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
    public partial class DeleteTaskForm : Form
    {
        TaskManager taskManager;
        public DeleteTaskForm(TaskManager mainForm)
        {
            this.taskManager = mainForm;
            InitializeComponent();
            SeeAllTasks();
        }

        private void SeeAllTasks()
        {
            deleteTaskListBox.Items.Clear();

            foreach (string task in taskManager.userTasks)
            {
                deleteTaskListBox.Items.Add(task);
            }
        }

        private void deleteTaskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show(
                $"¿Eliminar tarea: {deleteTaskListBox.SelectedItem}?\nEsta acción no se puede deshacer",
                "Eliminar tarea",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );
            if (delete == DialogResult.Yes)
            {
                taskManager.userTasks.Remove(deleteTaskListBox.SelectedItem.ToString());
                SeeAllTasks();
                return;
            }
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
    }
}
