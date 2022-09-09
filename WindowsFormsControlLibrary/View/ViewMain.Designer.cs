namespace View
{
    partial class ViewMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.timePickBox = new WindowsFormsControlLibrary.TimePickBox();
            this.selectedListBox = new WindowsFormsControlLibrary.SelectedListBox();
            this.SuspendLayout();
            // 
            // timePickBox
            // 
            this.timePickBox.Location = new System.Drawing.Point(166, 12);
            this.timePickBox.Name = "timePickBox";
            this.timePickBox.Size = new System.Drawing.Size(200, 135);
            this.timePickBox.TabIndex = 1;
            this.timePickBox.TimePicked = new System.DateTime(2022, 9, 9, 1, 15, 19, 683);
            // 
            // selectedListBox
            // 
            this.selectedListBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.selectedListBox.Location = new System.Drawing.Point(12, 12);
            this.selectedListBox.Name = "selectedListBox";
            this.selectedListBox.SelectedElement = "";
            this.selectedListBox.Size = new System.Drawing.Size(126, 100);
            this.selectedListBox.TabIndex = 0;
            // 
            // ViewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timePickBox);
            this.Controls.Add(this.selectedListBox);
            this.Name = "ViewMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsControlLibrary.SelectedListBox selectedListBox;
        private WindowsFormsControlLibrary.TimePickBox timePickBox;
    }
}

