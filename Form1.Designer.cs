namespace Coursework_C_Sharp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxThridName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAddres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownUpd = new System.Windows.Forms.NumericUpDown();
            this.buttonUpdData = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDownDel = new System.Windows.Forms.NumericUpDown();
            this.buttonFindSName = new System.Windows.Forms.Button();
            this.buttonFindNumber = new System.Windows.Forms.Button();
            this.textBoxFindSName = new System.Windows.Forms.TextBox();
            this.textBoxFindNumber = new System.Windows.Forms.TextBox();
            this.buttonUpd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpd)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Information";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(64, 95);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(226, 20);
            this.textBoxNumber.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number telephone    ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Thrid Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(64, 157);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(226, 20);
            this.textBoxName.TabIndex = 11;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(24, 182);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(226, 20);
            this.textBoxSecondName.TabIndex = 12;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(98, 336);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(66, 23);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Add new";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxThridName
            // 
            this.textBoxThridName.Location = new System.Drawing.Point(64, 276);
            this.textBoxThridName.Name = "textBoxThridName";
            this.textBoxThridName.Size = new System.Drawing.Size(226, 20);
            this.textBoxThridName.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Second Name";
            // 
            // textBoxAddres
            // 
            this.textBoxAddres.Location = new System.Drawing.Point(64, 335);
            this.textBoxAddres.Name = "textBoxAddres";
            this.textBoxAddres.Size = new System.Drawing.Size(226, 20);
            this.textBoxAddres.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Subscriber\'s address";
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(332, 447);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(57, 20);
            this.buttonDel.TabIndex = 23;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownUpd);
            this.groupBox1.Controls.Add(this.buttonUpdData);
            this.groupBox1.Controls.Add(this.textBoxSecondName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Location = new System.Drawing.Point(40, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 407);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // numericUpDownUpd
            // 
            this.numericUpDownUpd.Location = new System.Drawing.Point(171, 367);
            this.numericUpDownUpd.Name = "numericUpDownUpd";
            this.numericUpDownUpd.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownUpd.TabIndex = 21;
            // 
            // buttonUpdData
            // 
            this.buttonUpdData.Location = new System.Drawing.Point(79, 365);
            this.buttonUpdData.Name = "buttonUpdData";
            this.buttonUpdData.Size = new System.Drawing.Size(85, 23);
            this.buttonUpdData.TabIndex = 20;
            this.buttonUpdData.Text = "Update Data";
            this.buttonUpdData.UseVisualStyleBackColor = true;
            this.buttonUpdData.Click += new System.EventHandler(this.buttonUpdData_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(351, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 430);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Table1,
            this.Table2,
            this.Table3,
            this.Table4,
            this.Table5});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 405);
            this.dataGridView1.TabIndex = 0;
        
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Table1
            // 
            this.Table1.HeaderText = "Number telephone";
            this.Table1.Name = "Table1";
            // 
            // Table2
            // 
            this.Table2.HeaderText = "Name";
            this.Table2.Name = "Table2";
            // 
            // Table3
            // 
            this.Table3.HeaderText = "Second Name";
            this.Table3.Name = "Table3";
            // 
            // Table4
            // 
            this.Table4.HeaderText = "Thrid Name";
            this.Table4.Name = "Table4";
            // 
            // Table5
            // 
            this.Table5.HeaderText = "Subscriber\'s address";
            this.Table5.Name = "Table5";
            // 
            // numericUpDownDel
            // 
            this.numericUpDownDel.Location = new System.Drawing.Point(395, 447);
            this.numericUpDownDel.Name = "numericUpDownDel";
            this.numericUpDownDel.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownDel.TabIndex = 24;
            // 
            // buttonFindSName
            // 
            this.buttonFindSName.Location = new System.Drawing.Point(441, 445);
            this.buttonFindSName.Name = "buttonFindSName";
            this.buttonFindSName.Size = new System.Drawing.Size(116, 23);
            this.buttonFindSName.TabIndex = 27;
            this.buttonFindSName.Text = "Find Second Name";
            this.buttonFindSName.UseVisualStyleBackColor = true;
            this.buttonFindSName.Click += new System.EventHandler(this.buttonFindSName_Click_1);
            // 
            // buttonFindNumber
            // 
            this.buttonFindNumber.Location = new System.Drawing.Point(662, 445);
            this.buttonFindNumber.Name = "buttonFindNumber";
            this.buttonFindNumber.Size = new System.Drawing.Size(83, 23);
            this.buttonFindNumber.TabIndex = 28;
            this.buttonFindNumber.Text = "Find Number";
            this.buttonFindNumber.UseVisualStyleBackColor = true;
            this.buttonFindNumber.Click += new System.EventHandler(this.buttonFindNumber_Click);
            // 
            // textBoxFindSName
            // 
            this.textBoxFindSName.Location = new System.Drawing.Point(563, 447);
            this.textBoxFindSName.Name = "textBoxFindSName";
            this.textBoxFindSName.Size = new System.Drawing.Size(93, 20);
            this.textBoxFindSName.TabIndex = 29;
            // 
            // textBoxFindNumber
            // 
            this.textBoxFindNumber.Location = new System.Drawing.Point(751, 447);
            this.textBoxFindNumber.Name = "textBoxFindNumber";
            this.textBoxFindNumber.Size = new System.Drawing.Size(93, 20);
            this.textBoxFindNumber.TabIndex = 30;
            // 
            // buttonUpd
            // 
            this.buttonUpd.Location = new System.Drawing.Point(929, 445);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new System.Drawing.Size(66, 23);
            this.buttonUpd.TabIndex = 31;
            this.buttonUpd.Text = "Update";
            this.buttonUpd.UseVisualStyleBackColor = true;
            this.buttonUpd.Click += new System.EventHandler(this.buttonUpd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 472);
            this.Controls.Add(this.buttonUpd);
            this.Controls.Add(this.textBoxFindNumber);
            this.Controls.Add(this.textBoxFindSName);
            this.Controls.Add(this.buttonFindNumber);
            this.Controls.Add(this.buttonFindSName);
            this.Controls.Add(this.numericUpDownDel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxAddres);
            this.Controls.Add(this.textBoxThridName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Base Student\'s";
            
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUpd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxThridName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAddres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDownDel;
        private System.Windows.Forms.Button buttonFindSName;
        private System.Windows.Forms.Button buttonFindNumber;
        private System.Windows.Forms.TextBox textBoxFindSName;
        private System.Windows.Forms.TextBox textBoxFindNumber;
        private System.Windows.Forms.Button buttonUpd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table5;
        private System.Windows.Forms.NumericUpDown numericUpDownUpd;
        private System.Windows.Forms.Button buttonUpdData;
    }
}

