
namespace homeworkcsharp.Views
{
    partial class indexview
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
            this.table = new System.Windows.Forms.DataGridView();
            this.btnGetData = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.hourTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.speciality = new System.Windows.Forms.ComboBox();
            this.doctor = new System.Windows.Forms.ComboBox();
            this.idNumber = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(0, 191);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(538, 113);
            this.table.TabIndex = 0;
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(5, 162);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(200, 23);
            this.btnGetData.TabIndex = 1;
            this.btnGetData.Text = "Obtener citas";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(450, 162);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(88, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Guardar citas";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // hourTime
            // 
            this.hourTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.hourTime.Location = new System.Drawing.Point(338, 129);
            this.hourTime.Name = "hourTime";
            this.hourTime.Size = new System.Drawing.Size(200, 20);
            this.hourTime.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Indentificación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Doctor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Especialidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha";
            // 
            // speciality
            // 
            this.speciality.FormattingEnabled = true;
            this.speciality.Items.AddRange(new object[] {
            "Oncologia",
            "Podologia"});
            this.speciality.Location = new System.Drawing.Point(338, 73);
            this.speciality.Name = "speciality";
            this.speciality.Size = new System.Drawing.Size(200, 21);
            this.speciality.TabIndex = 9;
            // 
            // doctor
            // 
            this.doctor.FormattingEnabled = true;
            this.doctor.Items.AddRange(new object[] {
            "Angell Grisalez",
            "Danilo Perez"});
            this.doctor.Location = new System.Drawing.Point(338, 50);
            this.doctor.Name = "doctor";
            this.doctor.Size = new System.Drawing.Size(200, 21);
            this.doctor.TabIndex = 10;
            // 
            // idNumber
            // 
            this.idNumber.Location = new System.Drawing.Point(338, 28);
            this.idNumber.Name = "idNumber";
            this.idNumber.Size = new System.Drawing.Size(200, 20);
            this.idNumber.TabIndex = 11;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(338, 6);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(200, 20);
            this.name.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Hora";
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(338, 101);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 20);
            this.dateTime.TabIndex = 14;
            // 
            // indexview
            // 
            this.ClientSize = new System.Drawing.Size(539, 302);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.name);
            this.Controls.Add(this.idNumber);
            this.Controls.Add(this.doctor);
            this.Controls.Add(this.speciality);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hourTime);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.table);
            this.Name = "indexview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGetData;
        public System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DateTimePicker hourTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox speciality;
        private System.Windows.Forms.ComboBox doctor;
        private System.Windows.Forms.TextBox idNumber;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTime;
    }
}