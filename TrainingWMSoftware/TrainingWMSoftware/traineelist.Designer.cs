namespace TrainingWMSoftware
{
    partial class traineelist
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task1trainigtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task2trainigtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task3trainigtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task4trainigtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task5trainigtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskAlltrainigtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traineeDataSet1 = new TrainingWMSoftware.traineeDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.trainigTimeTableAdapter1 = new TrainingWMSoftware.traineeDataSet1TableAdapters.trainigTimeTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.task1trainigtimeDataGridViewTextBoxColumn,
            this.task2trainigtimeDataGridViewTextBoxColumn,
            this.task3trainigtimeDataGridViewTextBoxColumn,
            this.task4trainigtimeDataGridViewTextBoxColumn,
            this.task5trainigtimeDataGridViewTextBoxColumn,
            this.taskAlltrainigtimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "trainigTime";
            this.dataGridView1.DataSource = this.traineeDataSet1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.dataGridView1.Location = new System.Drawing.Point(64, 149);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(916, 291);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 253.8071F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "شناسه";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 63;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "Fname";
            this.fnameDataGridViewTextBoxColumn.FillWeight = 82.91032F;
            this.fnameDataGridViewTextBoxColumn.HeaderText = "نام ";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.Width = 45;
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "Lname";
            this.lnameDataGridViewTextBoxColumn.FillWeight = 82.91032F;
            this.lnameDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            this.lnameDataGridViewTextBoxColumn.Width = 94;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.FillWeight = 82.91032F;
            this.ageDataGridViewTextBoxColumn.HeaderText = "سن";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 48;
            // 
            // task1trainigtimeDataGridViewTextBoxColumn
            // 
            this.task1trainigtimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.task1trainigtimeDataGridViewTextBoxColumn.DataPropertyName = "Task1trainigtime";
            this.task1trainigtimeDataGridViewTextBoxColumn.FillWeight = 82.91032F;
            this.task1trainigtimeDataGridViewTextBoxColumn.HeaderText = "زمان تمرین اول";
            this.task1trainigtimeDataGridViewTextBoxColumn.Name = "task1trainigtimeDataGridViewTextBoxColumn";
            // 
            // task2trainigtimeDataGridViewTextBoxColumn
            // 
            this.task2trainigtimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.task2trainigtimeDataGridViewTextBoxColumn.DataPropertyName = "Task2trainigtime";
            this.task2trainigtimeDataGridViewTextBoxColumn.FillWeight = 82.91032F;
            this.task2trainigtimeDataGridViewTextBoxColumn.HeaderText = "زمان تمرین دوم";
            this.task2trainigtimeDataGridViewTextBoxColumn.Name = "task2trainigtimeDataGridViewTextBoxColumn";
            // 
            // task3trainigtimeDataGridViewTextBoxColumn
            // 
            this.task3trainigtimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.task3trainigtimeDataGridViewTextBoxColumn.DataPropertyName = "Task3trainigtime";
            this.task3trainigtimeDataGridViewTextBoxColumn.FillWeight = 82.91032F;
            this.task3trainigtimeDataGridViewTextBoxColumn.HeaderText = "زمان تمرین سوم";
            this.task3trainigtimeDataGridViewTextBoxColumn.Name = "task3trainigtimeDataGridViewTextBoxColumn";
            this.task3trainigtimeDataGridViewTextBoxColumn.Width = 104;
            // 
            // task4trainigtimeDataGridViewTextBoxColumn
            // 
            this.task4trainigtimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.task4trainigtimeDataGridViewTextBoxColumn.DataPropertyName = "Task4trainigtime";
            this.task4trainigtimeDataGridViewTextBoxColumn.FillWeight = 82.91032F;
            this.task4trainigtimeDataGridViewTextBoxColumn.HeaderText = "زمان تمرین چهارم";
            this.task4trainigtimeDataGridViewTextBoxColumn.Name = "task4trainigtimeDataGridViewTextBoxColumn";
            this.task4trainigtimeDataGridViewTextBoxColumn.Width = 111;
            // 
            // task5trainigtimeDataGridViewTextBoxColumn
            // 
            this.task5trainigtimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.task5trainigtimeDataGridViewTextBoxColumn.DataPropertyName = "Task5trainigtime";
            this.task5trainigtimeDataGridViewTextBoxColumn.FillWeight = 82.91032F;
            this.task5trainigtimeDataGridViewTextBoxColumn.HeaderText = "زمان تمرین پنجم";
            this.task5trainigtimeDataGridViewTextBoxColumn.Name = "task5trainigtimeDataGridViewTextBoxColumn";
            this.task5trainigtimeDataGridViewTextBoxColumn.Width = 104;
            // 
            // taskAlltrainigtimeDataGridViewTextBoxColumn
            // 
            this.taskAlltrainigtimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.taskAlltrainigtimeDataGridViewTextBoxColumn.DataPropertyName = "TaskAlltrainigtime";
            this.taskAlltrainigtimeDataGridViewTextBoxColumn.FillWeight = 82.91032F;
            this.taskAlltrainigtimeDataGridViewTextBoxColumn.HeaderText = "زمان کلی تمرین";
            this.taskAlltrainigtimeDataGridViewTextBoxColumn.Name = "taskAlltrainigtimeDataGridViewTextBoxColumn";
            this.taskAlltrainigtimeDataGridViewTextBoxColumn.Width = 104;
            // 
            // traineeDataSet1
            // 
            this.traineeDataSet1.DataSetName = "traineeDataSet1";
            this.traineeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ویرایش";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(717, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "شروع";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // trainigTimeTableAdapter1
            // 
            this.trainigTimeTableAdapter1.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(429, 475);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "اضافه کردن";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(279, 475);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "حذف";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(142, 475);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "خروج";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nazanin", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(175, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 86);
            this.label1.TabIndex = 6;
            this.label1.Text = "(نرم افزار تقويت حافظه کاری و سطح توجه کودکان کم توان ذهنی(نسخه 1.0\r\nثبت شده در د" +
                "بيرخانه شورای عالی انفورماتيک کشور \r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // traineelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "traineelist";
            this.RightToLeftLayout = true;
            this.Text = "ورود اطلاعات کاربران";
            this.Load += new System.EventHandler(this.traineelist_Load);
            this.Activated += new System.EventHandler(this.traineelist_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineeDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private traineeDataSet1 traineeDataSet1;
        private TrainingWMSoftware.traineeDataSet1TableAdapters.trainigTimeTableAdapter trainigTimeTableAdapter1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn task1trainigtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn task2trainigtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn task3trainigtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn task4trainigtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn task5trainigtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskAlltrainigtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
    }
}