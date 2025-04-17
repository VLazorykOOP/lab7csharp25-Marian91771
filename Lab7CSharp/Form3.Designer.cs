
namespace ShapeDrawer
{
    partial class Form3
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
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxSize1 = new System.Windows.Forms.TextBox();
            this.textBoxSize2 = new System.Windows.Forms.TextBox();
            this.labelSize1 = new System.Windows.Forms.Label();
            this.labelSize2 = new System.Windows.Forms.Label();
            this.buttonAdd1 = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(12, 12);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(171, 24);
            this.comboBoxType.TabIndex = 0;
            // 
            // textBoxSize1
            // 
            this.textBoxSize1.Location = new System.Drawing.Point(83, 42);
            this.textBoxSize1.Name = "textBoxSize1";
            this.textBoxSize1.Size = new System.Drawing.Size(100, 22);
            this.textBoxSize1.TabIndex = 1;
            // 
            // textBoxSize2
            // 
            this.textBoxSize2.Location = new System.Drawing.Point(83, 70);
            this.textBoxSize2.Name = "textBoxSize2";
            this.textBoxSize2.Size = new System.Drawing.Size(100, 22);
            this.textBoxSize2.TabIndex = 2;
            // 
            // labelSize1
            // 
            this.labelSize1.AutoSize = true;
            this.labelSize1.Location = new System.Drawing.Point(12, 44);
            this.labelSize1.Name = "labelSize1";
            this.labelSize1.Size = new System.Drawing.Size(65, 16);
            this.labelSize1.TabIndex = 3;
            this.labelSize1.Text = "Розмір 1:";
            // 
            // labelSize2
            // 
            this.labelSize2.AutoSize = true;
            this.labelSize2.Location = new System.Drawing.Point(12, 73);
            this.labelSize2.Name = "labelSize2";
            this.labelSize2.Size = new System.Drawing.Size(65, 16);
            this.labelSize2.TabIndex = 4;
            this.labelSize2.Text = "Розмір 2:";
            // 
            // buttonAdd1
            // 
            this.buttonAdd1.Location = new System.Drawing.Point(15, 98);
            this.buttonAdd1.Name = "buttonAdd1";
            this.buttonAdd1.Size = new System.Drawing.Size(168, 23);
            this.buttonAdd1.TabIndex = 5;
            this.buttonAdd1.Text = "Додати фігуру";
            this.buttonAdd1.UseVisualStyleBackColor = true;
            this.buttonAdd1.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(15, 127);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(168, 23);
            this.buttonColor.TabIndex = 6;
            this.buttonColor.Text = "Вибрати колір";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(189, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1263, 685);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(1495, 808);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.buttonAdd1);
            this.Controls.Add(this.labelSize2);
            this.Controls.Add(this.labelSize1);
            this.Controls.Add(this.textBoxSize2);
            this.Controls.Add(this.textBoxSize1);
            this.Controls.Add(this.comboBoxType);
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonInvert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioFullInvert;
        private System.Windows.Forms.RadioButton radioRedInvert;
        private System.Windows.Forms.RadioButton radioGreenInvert;
        private System.Windows.Forms.RadioButton radioBlueInvert;

        private void Form2_Load(object sender, System.EventArgs e)
        {

        }

        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxSize1;
        private System.Windows.Forms.TextBox textBoxSize2;
        private System.Windows.Forms.Label labelSize1;
        private System.Windows.Forms.Label labelSize2;
        private System.Windows.Forms.Button buttonAdd1;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

