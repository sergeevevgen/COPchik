namespace View
{
    partial class FormOrder
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
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelPic = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.choiceListProduct = new lab1COP.Components.ChoiceComponent();
            this.textBoxMail = new WindowsFormsControlLibraryKutygin.VisualComponents.EmailInputControl();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(12, 18);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(34, 15);
            this.labelFIO.TabIndex = 0;
            this.labelFIO.Text = "ФИО";
            // 
            // labelPic
            // 
            this.labelPic.AutoSize = true;
            this.labelPic.Location = new System.Drawing.Point(12, 71);
            this.labelPic.Name = "labelPic";
            this.labelPic.Size = new System.Drawing.Size(83, 15);
            this.labelPic.TabIndex = 1;
            this.labelPic.Text = "Изображение";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(12, 340);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(41, 15);
            this.labelMail.TabIndex = 2;
            this.labelMail.Text = "Почта";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(12, 270);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(62, 15);
            this.labelProduct.TabIndex = 3;
            this.labelProduct.Text = "Продукты";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(107, 12);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(325, 23);
            this.textBoxFIO.TabIndex = 4;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(107, 71);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(285, 167);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Location = new System.Drawing.Point(12, 101);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(75, 23);
            this.buttonAddImage.TabIndex = 6;
            this.buttonAddImage.Text = "Добавить";
            this.buttonAddImage.UseVisualStyleBackColor = true;
            this.buttonAddImage.Click += new System.EventHandler(this.buttonAddImage_Click);
            // 
            // choiceListProduct
            // 
            this.choiceListProduct.ChoosenLine = "";
            this.choiceListProduct.Location = new System.Drawing.Point(107, 270);
            this.choiceListProduct.Name = "choiceListProduct";
            this.choiceListProduct.Size = new System.Drawing.Size(130, 23);
            this.choiceListProduct.TabIndex = 7;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(107, 337);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Pattern = "^(?(\")(\"[^\"]+?\"@)|(([0-9a-z]((\\.(?!\\.))|[-!#\\$%&\'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9" +
            "a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-\\w]*[0-9a-z]*\\.)+[a-z0-9]{" +
            "2,17}))$";
            this.textBoxMail.Size = new System.Drawing.Size(249, 23);
            this.textBoxMail.TabIndex = 8;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 386);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 416);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.choiceListProduct);
            this.Controls.Add(this.buttonAddImage);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelPic);
            this.Controls.Add(this.labelFIO);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOrder_FormClosing);
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.Name = "FormOrder";
            this.Text = "Заказ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelFIO;
        private Label labelPic;
        private Label labelMail;
        private Label labelProduct;
        private TextBox textBoxFIO;
        private PictureBox pictureBox;
        private Button buttonAddImage;
        private lab1COP.Components.ChoiceComponent choiceListProduct;
        private WindowsFormsControlLibraryKutygin.VisualComponents.EmailInputControl textBoxMail;
        private Button buttonSave;
    }
}