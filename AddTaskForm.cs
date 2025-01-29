using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class FormAddTask : Form
    {
        private TaskManager taskManager;

        public FormAddTask(TaskManager mainForm)
        {
            InitializeComponent();
            this.taskManager = mainForm;
        }

        private void addTaskBtn_Click(object sender, EventArgs e)
        {
            if (taskManager.userTasks.Contains(taskNameTB.Text))
            {
                MessageBox.Show(
                    "Esa tarea ya existe.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                    );
                return;
            }
            else if (taskNameTB.Text.Length <= 2)
            {
                MessageBox.Show(
                    "Ingresa al menos tres caracteres", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                    );
                return;
            }

            taskManager.userTasks.Add(taskNameTB.Text);
            MessageBox.Show(
                "Tarea añadida correctamente", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            taskNameTB.Text = "";
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
