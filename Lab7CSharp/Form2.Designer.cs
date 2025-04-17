
namespace ImageInversionApp
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonInvert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBlueInvert = new System.Windows.Forms.RadioButton();
            this.radioFullInvert = new System.Windows.Forms.RadioButton();
            this.radioGreenInvert = new System.Windows.Forms.RadioButton();
            this.radioRedInvert = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(407, 190);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(162, 23);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Завантажити";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(407, 219);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(162, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonInvert
            // 
            this.buttonInvert.Location = new System.Drawing.Point(407, 248);
            this.buttonInvert.Name = "buttonInvert";
            this.buttonInvert.Size = new System.Drawing.Size(162, 23);
            this.buttonInvert.TabIndex = 3;
            this.buttonInvert.Text = "Застосувати інверсію";
            this.buttonInvert.UseVisualStyleBackColor = true;
            this.buttonInvert.Click += new System.EventHandler(this.buttonInvert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBlueInvert);
            this.groupBox1.Controls.Add(this.radioFullInvert);
            this.groupBox1.Controls.Add(this.radioGreenInvert);
            this.groupBox1.Controls.Add(this.radioRedInvert);
            this.groupBox1.Location = new System.Drawing.Point(407, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 171);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим інверсії";
            // 
            // radioBlueInvert
            // 
            this.radioBlueInvert.AutoSize = true;
            this.radioBlueInvert.Location = new System.Drawing.Point(6, 102);
            this.radioBlueInvert.Name = "radioBlueInvert";
            this.radioBlueInvert.Size = new System.Drawing.Size(37, 20);
            this.radioBlueInvert.TabIndex = 8;
            this.radioBlueInvert.TabStop = true;
            this.radioBlueInvert.Text = "B";
            this.radioBlueInvert.UseVisualStyleBackColor = true;
            // 
            // radioFullInvert
            // 
            this.radioFullInvert.AutoSize = true;
            this.radioFullInvert.Location = new System.Drawing.Point(6, 21);
            this.radioFullInvert.Name = "radioFullInvert";
            this.radioFullInvert.Size = new System.Drawing.Size(70, 20);
            this.radioFullInvert.TabIndex = 5;
            this.radioFullInvert.TabStop = true;
            this.radioFullInvert.Text = "Повна";
            this.radioFullInvert.UseVisualStyleBackColor = true;
            // 
            // radioGreenInvert
            // 
            this.radioGreenInvert.AutoSize = true;
            this.radioGreenInvert.Location = new System.Drawing.Point(6, 75);
            this.radioGreenInvert.Name = "radioGreenInvert";
            this.radioGreenInvert.Size = new System.Drawing.Size(38, 20);
            this.radioGreenInvert.TabIndex = 7;
            this.radioGreenInvert.TabStop = true;
            this.radioGreenInvert.Text = "G";
            this.radioGreenInvert.UseVisualStyleBackColor = true;
            // 
            // radioRedInvert
            // 
            this.radioRedInvert.AutoSize = true;
            this.radioRedInvert.Location = new System.Drawing.Point(6, 48);
            this.radioRedInvert.Name = "radioRedInvert";
            this.radioRedInvert.Size = new System.Drawing.Size(38, 20);
            this.radioRedInvert.TabIndex = 6;
            this.radioRedInvert.TabStop = true;
            this.radioRedInvert.Text = "R";
            this.radioRedInvert.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(593, 302);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonInvert);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

