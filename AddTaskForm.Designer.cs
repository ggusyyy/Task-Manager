namespace TaskManager
{
    partial class FormAddTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.taskNameTB = new System.Windows.Forms.TextBox();
            this.taskDescriptionTB = new System.Windows.Forms.TextBox();
            this.addTaskBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BackToMainFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la tarea:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Observaciones:";
            // 
            // taskNameTB
            // 
            this.taskNameTB.Location = new System.Drawing.Point(118, 84);
            this.taskNameTB.Name = "taskNameTB";
            this.taskNameTB.Size = new System.Drawing.Size(641, 20);
            this.taskNameTB.TabIndex = 2;
            // 
            // taskDescriptionTB
            // 
            this.taskDescriptionTB.Enabled = false;
            this.taskDescriptionTB.Location = new System.Drawing.Point(118, 133);
            this.taskDescriptionTB.Name = "taskDescriptionTB";
            this.taskDescriptionTB.Size = new System.Drawing.Size(641, 20);
            this.taskDescriptionTB.TabIndex = 3;
            this.taskDescriptionTB.Text = "coming soon...";
            // 
            // addTaskBtn
            // 
            this.addTaskBtn.Location = new System.Drawing.Point(339, 181);
            this.addTaskBtn.Name = "addTaskBtn";
            this.addTaskBtn.Size = new System.Drawing.Size(117, 50);
            this.addTaskBtn.TabIndex = 4;
            this.addTaskBtn.Text = "Añadir Tarea";
            this.addTaskBtn.UseVisualStyleBackColor = true;
            this.addTaskBtn.Click += new System.EventHandler(this.addTaskBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Añadir tarea";
            // 
            // BackToMainFormBtn
            // 
            this.BackToMainFormBtn.Location = new System.Drawing.Point(691, 396);
            this.BackToMainFormBtn.Name = "BackToMainFormBtn";
            this.BackToMainFormBtn.Size = new System.Drawing.Size(97, 42);
            this.BackToMainFormBtn.TabIndex = 6;
            this.BackToMainFormBtn.Text = "Volver";
            this.BackToMainFormBtn.UseVisualStyleBackColor = true;
            this.BackToMainFormBtn.Click += new System.EventHandler(this.backToMainFormBtn_Click);
            // 
            // FormAddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackToMainFormBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addTaskBtn);
            this.Controls.Add(this.taskDescriptionTB);
            this.Controls.Add(this.taskNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox taskNameTB;
        private System.Windows.Forms.TextBox taskDescriptionTB;
        private System.Windows.Forms.Button addTaskBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BackToMainFormBtn;
    }
}