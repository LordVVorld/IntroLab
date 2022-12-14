namespace Q2
{
    partial class ReviewView
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
            System.Windows.Forms.MenuStrip menuStrip;
            System.Windows.Forms.Label studentListLabel;
            System.Windows.Forms.Label groupNameLabel;
            System.Windows.Forms.Label studentDataGridLabel;
            this.editModButton = new System.Windows.Forms.ToolStripMenuItem();
            this.groupGB = new System.Windows.Forms.GroupBox();
            this.studentDataGrid = new System.Windows.Forms.DataGridView();
            this.studentList = new System.Windows.Forms.ListBox();
            this.groupNameBox = new System.Windows.Forms.TextBox();
            this.groupList = new System.Windows.Forms.ListBox();
            menuStrip = new System.Windows.Forms.MenuStrip();
            studentListLabel = new System.Windows.Forms.Label();
            groupNameLabel = new System.Windows.Forms.Label();
            studentDataGridLabel = new System.Windows.Forms.Label();
            menuStrip.SuspendLayout();
            this.groupGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = System.Drawing.Color.Transparent;
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editModButton});
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new System.Drawing.Size(743, 32);
            menuStrip.TabIndex = 2;
            // 
            // editModButton
            // 
            this.editModButton.Font = new System.Drawing.Font("Alegreya SC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editModButton.Name = "editModButton";
            this.editModButton.Size = new System.Drawing.Size(273, 28);
            this.editModButton.Text = "Перейти в режим редактирования";
            // 
            // studentListLabel
            // 
            studentListLabel.AutoSize = true;
            studentListLabel.Font = new System.Drawing.Font("Alegreya SC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            studentListLabel.Location = new System.Drawing.Point(9, 62);
            studentListLabel.Name = "studentListLabel";
            studentListLabel.Size = new System.Drawing.Size(146, 24);
            studentListLabel.TabIndex = 7;
            studentListLabel.Text = "Список студентов";
            studentListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupNameLabel
            // 
            groupNameLabel.AutoSize = true;
            groupNameLabel.Font = new System.Drawing.Font("Alegreya SC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            groupNameLabel.Location = new System.Drawing.Point(6, 25);
            groupNameLabel.Name = "groupNameLabel";
            groupNameLabel.Size = new System.Drawing.Size(66, 24);
            groupNameLabel.TabIndex = 1;
            groupNameLabel.Text = "Группа:";
            groupNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentDataGridLabel
            // 
            studentDataGridLabel.AutoSize = true;
            studentDataGridLabel.Font = new System.Drawing.Font("Alegreya SC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            studentDataGridLabel.Location = new System.Drawing.Point(305, 62);
            studentDataGridLabel.Name = "studentDataGridLabel";
            studentDataGridLabel.Size = new System.Drawing.Size(138, 24);
            studentDataGridLabel.TabIndex = 9;
            studentDataGridLabel.Text = "Данные студента";
            studentDataGridLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupGB
            // 
            this.groupGB.Controls.Add(studentDataGridLabel);
            this.groupGB.Controls.Add(this.studentDataGrid);
            this.groupGB.Controls.Add(studentListLabel);
            this.groupGB.Controls.Add(this.studentList);
            this.groupGB.Controls.Add(groupNameLabel);
            this.groupGB.Controls.Add(this.groupNameBox);
            this.groupGB.Font = new System.Drawing.Font("Alegreya SC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupGB.Location = new System.Drawing.Point(138, 37);
            this.groupGB.Name = "groupGB";
            this.groupGB.Size = new System.Drawing.Size(596, 364);
            this.groupGB.TabIndex = 5;
            this.groupGB.TabStop = false;
            this.groupGB.Text = "Данные группы";
            // 
            // studentDataGrid
            // 
            this.studentDataGrid.AllowUserToAddRows = false;
            this.studentDataGrid.AllowUserToDeleteRows = false;
            this.studentDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.studentDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGrid.Location = new System.Drawing.Point(156, 89);
            this.studentDataGrid.Name = "studentDataGrid";
            this.studentDataGrid.ReadOnly = true;
            this.studentDataGrid.RowHeadersVisible = false;
            this.studentDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.studentDataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Alegreya SC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentDataGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentDataGrid.Size = new System.Drawing.Size(431, 269);
            this.studentDataGrid.TabIndex = 8;
            // 
            // studentList
            // 
            this.studentList.DisplayMember = "Id";
            this.studentList.Font = new System.Drawing.Font("Alegreya SC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentList.FormattingEnabled = true;
            this.studentList.ItemHeight = 24;
            this.studentList.Location = new System.Drawing.Point(12, 89);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(138, 268);
            this.studentList.TabIndex = 4;
            this.studentList.ValueMember = "Name";
            // 
            // groupNameBox
            // 
            this.groupNameBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupNameBox.Font = new System.Drawing.Font("Alegreya SC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupNameBox.Location = new System.Drawing.Point(74, 25);
            this.groupNameBox.Name = "groupNameBox";
            this.groupNameBox.ReadOnly = true;
            this.groupNameBox.Size = new System.Drawing.Size(138, 29);
            this.groupNameBox.TabIndex = 0;
            // 
            // groupList
            // 
            this.groupList.DisplayMember = "Name";
            this.groupList.Font = new System.Drawing.Font("Alegreya SC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupList.FormattingEnabled = true;
            this.groupList.ItemHeight = 24;
            this.groupList.Location = new System.Drawing.Point(12, 37);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(120, 364);
            this.groupList.TabIndex = 4;
            this.groupList.ValueMember = "Name";
            // 
            // ReviewView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(743, 407);
            this.Controls.Add(this.groupGB);
            this.Controls.Add(this.groupList);
            this.Controls.Add(menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = menuStrip;
            this.Name = "ReviewView";
            this.Text = "Просмотр групп";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            this.groupGB.ResumeLayout(false);
            this.groupGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem editModButton;
        private System.Windows.Forms.GroupBox groupGB;
        private System.Windows.Forms.DataGridView studentDataGrid;
        private System.Windows.Forms.ListBox studentList;
        private System.Windows.Forms.TextBox groupNameBox;
        private System.Windows.Forms.ListBox groupList;
    }
}

