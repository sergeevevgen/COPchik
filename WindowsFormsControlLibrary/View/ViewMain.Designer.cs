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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Узел4");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Узел7");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Узел3", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Узел0", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Узел5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Узел1", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Узел6");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Узел2", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.timePickBox = new WindowsFormsControlLibrary.TimePickBox();
            this.selectedListBox = new WindowsFormsControlLibrary.SelectedListBox();
            this.treeCustom = new WindowsFormsControlLibrary.TreeCustom();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
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
            // treeCustom
            // 
            this.treeCustom.Location = new System.Drawing.Point(431, 35);
            this.treeCustom.Name = "treeCustom";
            this.treeCustom.Size = new System.Drawing.Size(275, 210);
            this.treeCustom.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(316, 199);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел4";
            treeNode1.Text = "Узел4";
            treeNode2.Name = "Узел7";
            treeNode2.Text = "Узел7";
            treeNode3.Name = "Узел3";
            treeNode3.Text = "Узел3";
            treeNode4.Name = "Узел0";
            treeNode4.Text = "Узел0";
            treeNode5.Name = "Узел5";
            treeNode5.Text = "Узел5";
            treeNode6.Name = "Узел1";
            treeNode6.Text = "Узел1";
            treeNode7.Name = "Узел6";
            treeNode7.Text = "Узел6";
            treeNode8.Name = "Узел2";
            treeNode8.Text = "Узел2";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode6,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 3;
            // 
            // ViewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
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
        private System.Windows.Forms.TreeView treeView1;
    }
}

