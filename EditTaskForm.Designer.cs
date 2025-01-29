namespace TaskManager
{
    partial class EditTaskForm
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.editTaskListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newTaskNameLbl = new System.Windows.Forms.Label();
            this.newTaskNameTextBox = new System.Windows.Forms.TextBox();
            this.addNewTaskNameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(675, 396);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(97, 42);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Volver";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // editTaskListBox
            // 
            this.editTaskListBox.FormattingEnabled = true;
            this.editTaskListBox.Location = new System.Drawing.Point(88, 106);
            this.editTaskListBox.Name = "editTaskListBox";
            this.editTaskListBox.Size = new System.Drawing.Size(605, 251);
            this.editTaskListBox.TabIndex = 7;
            this.editTaskListBox.SelectedIndexChanged += new System.EventHandler(this.editTaskListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Editar tarea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Selecciona tu tarea para editarla: ";
            // 
            // newTaskNameLbl
            // 
            this.newTaskNameLbl.AutoSize = true;
            this.newTaskNameLbl.Location = new System.Drawing.Point(12, 170);
            this.newTaskNameLbl.Name = "newTaskNameLbl";
            this.newTaskNameLbl.Size = new System.Drawing.Size(91, 26);
            this.newTaskNameLbl.TabIndex = 10;
            this.newTaskNameLbl.Text = "Ingresa el nombre\r\nde la nueva tarea";
            this.newTaskNameLbl.Visible = false;
            // 
            // newTaskNameTextBox
            // 
            this.newTaskNameTextBox.Location = new System.Drawing.Point(122, 176);
            this.newTaskNameTextBox.Name = "newTaskNameTextBox";
            this.newTaskNameTextBox.Size = new System.Drawing.Size(544, 20);
            this.newTaskNameTextBox.TabIndex = 11;
            this.newTaskNameTextBox.Visible = false;
            // 
            // addNewTaskNameBtn
            // 
            this.addNewTaskNameBtn.Location = new System.Drawing.Point(689, 170);
            this.addNewTaskNameBtn.Name = "addNewTaskNameBtn";
            this.addNewTaskNameBtn.Size = new System.Drawing.Size(99, 30);
            this.addNewTaskNameBtn.TabIndex = 12;
            this.addNewTaskNameBtn.Text = "Editar tarea";
            this.addNewTaskNameBtn.UseVisualStyleBackColor = true;
            this.addNewTaskNameBtn.Visible = false;
            this.addNewTaskNameBtn.Click += new System.EventHandler(this.addNewTaskNameBtn_Click);
            // 
            // EditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addNewTaskNameBtn);
            this.Controls.Add(this.newTaskNameTextBox);
            this.Controls.Add(this.newTaskNameLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editTaskListBox);
            this.Controls.Add(this.exitBtn);
            this.Name = "EditTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar tareas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ListBox editTaskListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label newTaskNameLbl;
        private System.Windows.Forms.TextBox newTaskNameTextBox;
        private System.Windows.Forms.Button addNewTaskNameBtn;
    }
}