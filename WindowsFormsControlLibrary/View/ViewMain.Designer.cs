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
            this.treeCustom = new WindowsFormsControlLibrary.TreeCustom();
            this.timePickBox = new WindowsFormsControlLibrary.TimePickBox();
            this.selectedListBox = new WindowsFormsControlLibrary.SelectedListBox();
            this.button = new System.Windows.Forms.Button();
            this.buttonImage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeCustom
            // 
            this.treeCustom.Location = new System.Drawing.Point(431, 35);
            this.treeCustom.Name = "treeCustom";
            this.treeCustom.Size = new System.Drawing.Size(275, 210);
            this.treeCustom.TabIndex = 2;
            // 
            // timePickBox
            // 
            this.timePickBox.Location = new System.Drawing.Point(166, 12);
            this.timePickBox.Name = "timePickBox";
            this.timePickBox.Size = new System.Drawing.Size(200, 135);
            this.timePickBox.TabIndex = 1;
            this.timePickBox.TimePicked = null;
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
            // button
            // 
            this.button.Location = new System.Drawing.Point(452, 264);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 3;
            this.button.Text = "Получить элемент ";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonImage
            // 
            this.buttonImage.Location = new System.Drawing.Point(35, 170);
            this.buttonImage.Name = "buttonImage";
            this.buttonImage.Size = new System.Drawing.Size(75, 23);
            this.buttonImage.TabIndex = 4;
            this.buttonImage.Text = "Создать документ с картинкой";
            this.buttonImage.UseVisualStyleBackColor = true;
            this.buttonImage.Click += new System.EventHandler(this.buttonImage_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Получить элемент ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Получить элемент ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ViewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonImage);
            this.Controls.Add(this.button);
            this.Controls.Add(this.treeCustom);
            this.Controls.Add(this.timePickBox);
            this.Controls.Add(this.selectedListBox);
            this.Name = "ViewMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsControlLibrary.SelectedListBox selectedListBox;
        private WindowsFormsControlLibrary.TimePickBox timePickBox;
        private WindowsFormsControlLibrary.TreeCustom treeCustom;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button buttonImage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

