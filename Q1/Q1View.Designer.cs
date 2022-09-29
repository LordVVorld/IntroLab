namespace Q1
{
    partial class Q1View
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label matrixLabel;
            System.Windows.Forms.Label geometricMeanLabel;
            System.Windows.Forms.Label maxRightLabel;
            System.Windows.Forms.Label minLeftLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.startButton = new System.Windows.Forms.Button();
            this.asnwerBox = new System.Windows.Forms.GroupBox();
            this.geometricMeanBox = new System.Windows.Forms.TextBox();
            this.maxRightBox = new System.Windows.Forms.TextBox();
            this.minLeftBox = new System.Windows.Forms.TextBox();
            this.inputPrincipleBox = new System.Windows.Forms.GroupBox();
            this.manualInputButton = new System.Windows.Forms.RadioButton();
            this.autoGenerationButton = new System.Windows.Forms.RadioButton();
            this.matrixGrid = new System.Windows.Forms.DataGridView();
            this.squareMatrixBindingSource = new System.Windows.Forms.BindingSource(this.components);
            matrixLabel = new System.Windows.Forms.Label();
            geometricMeanLabel = new System.Windows.Forms.Label();
            maxRightLabel = new System.Windows.Forms.Label();
            minLeftLabel = new System.Windows.Forms.Label();
            this.asnwerBox.SuspendLayout();
            this.inputPrincipleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squareMatrixBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // matrixLabel
            // 
            matrixLabel.AutoSize = true;
            matrixLabel.Location = new System.Drawing.Point(12, 9);
            matrixLabel.Name = "matrixLabel";
            matrixLabel.Size = new System.Drawing.Size(51, 13);
            matrixLabel.TabIndex = 8;
            matrixLabel.Text = "Матрица";
            // 
            // geometricMeanLabel
            // 
            geometricMeanLabel.AutoSize = true;
            geometricMeanLabel.Location = new System.Drawing.Point(6, 84);
            geometricMeanLabel.Name = "geometricMeanLabel";
            geometricMeanLabel.Size = new System.Drawing.Size(139, 13);
            geometricMeanLabel.TabIndex = 8;
            geometricMeanLabel.Text = "Геометрическое среднее:";
            // 
            // maxRightLabel
            // 
            maxRightLabel.AutoSize = true;
            maxRightLabel.Location = new System.Drawing.Point(6, 49);
            maxRightLabel.Name = "maxRightLabel";
            maxRightLabel.Size = new System.Drawing.Size(142, 26);
            maxRightLabel.TabIndex = 6;
            maxRightLabel.Text = "Наибольшее число справа\r\nот побочной диагонали:";
            // 
            // minLeftLabel
            // 
            minLeftLabel.AutoSize = true;
            minLeftLabel.Location = new System.Drawing.Point(6, 20);
            minLeftLabel.Name = "minLeftLabel";
            minLeftLabel.Size = new System.Drawing.Size(138, 26);
            minLeftLabel.TabIndex = 4;
            minLeftLabel.Text = "Наименьшее число слева\r\nот побочной диагонали:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(450, 54);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Вычислить";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // asnwerBox
            // 
            this.asnwerBox.Controls.Add(this.geometricMeanBox);
            this.asnwerBox.Controls.Add(geometricMeanLabel);
            this.asnwerBox.Controls.Add(this.maxRightBox);
            this.asnwerBox.Controls.Add(maxRightLabel);
            this.asnwerBox.Controls.Add(this.minLeftBox);
            this.asnwerBox.Controls.Add(minLeftLabel);
            this.asnwerBox.Location = new System.Drawing.Point(327, 83);
            this.asnwerBox.Name = "asnwerBox";
            this.asnwerBox.Size = new System.Drawing.Size(262, 110);
            this.asnwerBox.TabIndex = 7;
            this.asnwerBox.TabStop = false;
            this.asnwerBox.Text = "Ответы:";
            // 
            // geometricMeanBox
            // 
            this.geometricMeanBox.Location = new System.Drawing.Point(150, 81);
            this.geometricMeanBox.Name = "geometricMeanBox";
            this.geometricMeanBox.ReadOnly = true;
            this.geometricMeanBox.Size = new System.Drawing.Size(100, 20);
            this.geometricMeanBox.TabIndex = 9;
            // 
            // maxRightBox
            // 
            this.maxRightBox.Location = new System.Drawing.Point(150, 55);
            this.maxRightBox.Name = "maxRightBox";
            this.maxRightBox.ReadOnly = true;
            this.maxRightBox.Size = new System.Drawing.Size(100, 20);
            this.maxRightBox.TabIndex = 7;
            // 
            // minLeftBox
            // 
            this.minLeftBox.Location = new System.Drawing.Point(150, 26);
            this.minLeftBox.Name = "minLeftBox";
            this.minLeftBox.ReadOnly = true;
            this.minLeftBox.Size = new System.Drawing.Size(100, 20);
            this.minLeftBox.TabIndex = 5;
            // 
            // inputPrincipleBox
            // 
            this.inputPrincipleBox.Controls.Add(this.manualInputButton);
            this.inputPrincipleBox.Controls.Add(this.autoGenerationButton);
            this.inputPrincipleBox.Location = new System.Drawing.Point(327, 9);
            this.inputPrincipleBox.Name = "inputPrincipleBox";
            this.inputPrincipleBox.Size = new System.Drawing.Size(117, 68);
            this.inputPrincipleBox.TabIndex = 6;
            this.inputPrincipleBox.TabStop = false;
            this.inputPrincipleBox.Text = "Принцип ввода:";
            // 
            // manualInputButton
            // 
            this.manualInputButton.AutoSize = true;
            this.manualInputButton.Location = new System.Drawing.Point(6, 42);
            this.manualInputButton.Name = "manualInputButton";
            this.manualInputButton.Size = new System.Drawing.Size(87, 17);
            this.manualInputButton.TabIndex = 1;
            this.manualInputButton.TabStop = true;
            this.manualInputButton.Text = "Ручной ввод";
            this.manualInputButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manualInputButton.UseVisualStyleBackColor = true;
            // 
            // autoGenerationButton
            // 
            this.autoGenerationButton.AutoSize = true;
            this.autoGenerationButton.Checked = true;
            this.autoGenerationButton.Location = new System.Drawing.Point(6, 19);
            this.autoGenerationButton.Name = "autoGenerationButton";
            this.autoGenerationButton.Size = new System.Drawing.Size(102, 17);
            this.autoGenerationButton.TabIndex = 0;
            this.autoGenerationButton.TabStop = true;
            this.autoGenerationButton.Text = "Автогенерация";
            this.autoGenerationButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.autoGenerationButton.UseVisualStyleBackColor = true;
            // 
            // matrixGrid
            // 
            this.matrixGrid.AllowUserToAddRows = false;
            this.matrixGrid.AllowUserToDeleteRows = false;
            this.matrixGrid.AllowUserToResizeColumns = false;
            this.matrixGrid.AllowUserToResizeRows = false;
            this.matrixGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.matrixGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matrixGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.matrixGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.matrixGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mookmania", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matrixGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.matrixGrid.Location = new System.Drawing.Point(15, 25);
            this.matrixGrid.Name = "matrixGrid";
            this.matrixGrid.RowHeadersVisible = false;
            this.matrixGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.matrixGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.matrixGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Mookmania", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.matrixGrid.RowTemplate.DefaultCellStyle.Format = "N3";
            this.matrixGrid.RowTemplate.DefaultCellStyle.NullValue = null;
            this.matrixGrid.RowTemplate.Height = 60;
            this.matrixGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.matrixGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matrixGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.matrixGrid.Size = new System.Drawing.Size(300, 300);
            this.matrixGrid.TabIndex = 5;
            // 
            // squareMatrixBindingSource
            // 
            this.squareMatrixBindingSource.DataSource = typeof(Q1.Q1Model.SquareMatrix);
            // 
            // Q1View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 360);
            this.Controls.Add(this.startButton);
            this.Controls.Add(matrixLabel);
            this.Controls.Add(this.asnwerBox);
            this.Controls.Add(this.inputPrincipleBox);
            this.Controls.Add(this.matrixGrid);
            this.Name = "Q1View";
            this.Text = "Q1Form";
            this.asnwerBox.ResumeLayout(false);
            this.asnwerBox.PerformLayout();
            this.inputPrincipleBox.ResumeLayout(false);
            this.inputPrincipleBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squareMatrixBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox asnwerBox;
        private System.Windows.Forms.TextBox geometricMeanBox;
        private System.Windows.Forms.TextBox maxRightBox;
        private System.Windows.Forms.TextBox minLeftBox;
        private System.Windows.Forms.GroupBox inputPrincipleBox;
        private System.Windows.Forms.RadioButton manualInputButton;
        private System.Windows.Forms.RadioButton autoGenerationButton;
        private System.Windows.Forms.DataGridView matrixGrid;
        private System.Windows.Forms.BindingSource squareMatrixBindingSource;
    }
}

