namespace dbInCsharp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            BtnGetAll = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            searchBtn = new Button();
            BtnUpdate = new Button();
            txtGiven = new TextBox();
            txtFamily = new TextBox();
            txtID = new TextBox();
            BtnGetStudentsTable = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BtnGetAll
            // 
            BtnGetAll.BackColor = Color.Fuchsia;
            BtnGetAll.Location = new Point(286, 56);
            BtnGetAll.Name = "BtnGetAll";
            BtnGetAll.Size = new Size(146, 44);
            BtnGetAll.TabIndex = 0;
            BtnGetAll.Text = "Get All Record";
            BtnGetAll.UseVisualStyleBackColor = false;
            BtnGetAll.Click += BtnGetAll_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FloralWhite;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(189, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(331, 169);
            dataGridView1.TabIndex = 1;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 141);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 2;
            label1.Text = "Student ID:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(237, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = SystemColors.ControlLight;
            searchBtn.Location = new Point(368, 131);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(133, 41);
            searchBtn.TabIndex = 4;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.BackColor = SystemColors.ControlLight;
            BtnUpdate.Location = new Point(487, 404);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(102, 41);
            BtnUpdate.TabIndex = 5;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = false;
            BtnUpdate.Click += updateBtn_Click;
            // 
            // txtGiven
            // 
            txtGiven.Location = new Point(356, 411);
            txtGiven.Name = "txtGiven";
            txtGiven.Size = new Size(125, 27);
            txtGiven.TabIndex = 6;
            // 
            // txtFamily
            // 
            txtFamily.Location = new Point(225, 411);
            txtFamily.Name = "txtFamily";
            txtFamily.Size = new Size(125, 27);
            txtFamily.TabIndex = 7;
            // 
            // txtID
            // 
            txtID.Location = new Point(159, 411);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(46, 27);
            txtID.TabIndex = 8;
            // 
            // BtnGetStudentsTable
            // 
            BtnGetStudentsTable.BackColor = SystemColors.ControlLight;
            BtnGetStudentsTable.Location = new Point(286, 353);
            BtnGetStudentsTable.Name = "BtnGetStudentsTable";
            BtnGetStudentsTable.Size = new Size(145, 32);
            BtnGetStudentsTable.TabIndex = 9;
            BtnGetStudentsTable.Text = "Get Students Table";
            BtnGetStudentsTable.UseVisualStyleBackColor = false;
            BtnGetStudentsTable.Click += BtnGetStudentsTable_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnGetStudentsTable);
            Controls.Add(txtID);
            Controls.Add(txtFamily);
            Controls.Add(txtGiven);
            Controls.Add(BtnUpdate);
            Controls.Add(searchBtn);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(BtnGetAll);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGetAll;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Button searchBtn;
        private Button BtnUpdate;
        private TextBox txtGiven;
        private TextBox txtFamily;
        private TextBox txtID;
        private Button BtnGetStudentsTable;
    }
}
