namespace TaskManager
{
    partial class DeleteTaskForm
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
            this.deleteTaskListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backToMainFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteTaskListBox
            // 
            this.deleteTaskListBox.FormattingEnabled = true;
            this.deleteTaskListBox.Location = new System.Drawing.Point(105, 98);
            this.deleteTaskListBox.Name = "deleteTaskListBox";
            this.deleteTaskListBox.Size = new System.Drawing.Size(581, 264);
            this.deleteTaskListBox.TabIndex = 0;
            this.deleteTaskListBox.SelectedIndexChanged += new System.EventHandler(this.deleteTaskListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eliminar Tarea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecciona la tarea que quieres eliminar: ";
            // 
            // backToMainFormBtn
            // 
            this.backToMainFormBtn.Location = new System.Drawing.Point(682, 396);
            this.backToMainFormBtn.Name = "backToMainFormBtn";
            this.backToMainFormBtn.Size = new System.Drawing.Size(97, 42);
            this.backToMainFormBtn.TabIndex = 3;
            this.backToMainFormBtn.Text = "Volver";
            this.backToMainFormBtn.UseVisualStyleBackColor = true;
            this.backToMainFormBtn.Click += new System.EventHandler(this.backToMainFormBtn_Click);
            // 
            // DeleteTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backToMainFormBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteTaskListBox);
            this.Name = "DeleteTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar tarea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox deleteTaskListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backToMainFormBtn;
    }
}