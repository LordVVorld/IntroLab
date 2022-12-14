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
            System.Windows.Forms.Label geometricMeanLabel;
            System.Windows.Forms.Label maxRightLabel;
            System.Windows.Forms.Label minLeftLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.valuesEvaluationButton = new System.Windows.Forms.Button();
            this.asnwerBox = new System.Windows.Forms.GroupBox();
            this.geometricMeanBox = new System.Windows.Forms.TextBox();
            this.maxRightBox = new System.Windows.Forms.TextBox();
            this.minLeftBox = new System.Windows.Forms.TextBox();
            this.matrixGrid = new System.Windows.Forms.DataGridView();
            this.autoFillButton = new System.Windows.Forms.Button();
            geometricMeanLabel = new System.Windows.Forms.Label();
            maxRightLabel = new System.Windows.Forms.Label();
            minLeftLabel = new System.Windows.Forms.Label();
            this.asnwerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // geometricMeanLabel
            // 
            geometricMeanLabel.AutoSize = true;
            geometricMeanLabel.Font = new System.Drawing.Font("Alegreya SC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            geometricMeanLabel.Location = new System.Drawing.Point(47, 147);
            geometricMeanLabel.Name = "geometricMeanLabel";
            geometricMeanLabel.Size = new System.Drawing.Size(186, 22);
            geometricMeanLabel.TabIndex = 8;
            geometricMeanLabel.Text = "Геометрическое среднее";
            geometricMeanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxRightLabel
            // 
            maxRightLabel.AutoSize = true;
            maxRightLabel.Font = new System.Drawing.Font("Alegreya SC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            maxRightLabel.Location = new System.Drawing.Point(22, 89);
            maxRightLabel.Name = "maxRightLabel";
            maxRightLabel.Size = new System.Drawing.Size(229, 22);
            maxRightLabel.TabIndex = 6;
            maxRightLabel.Text = "Максимум справа от поб. диаг.";
            maxRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minLeftLabel
            // 
            minLeftLabel.AutoSize = true;
            minLeftLabel.Font = new System.Drawing.Font("Alegreya SC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            minLeftLabel.Location = new System.Drawing.Point(29, 32);
            minLeftLabel.Name = "minLeftLabel";
            minLeftLabel.Size = new System.Drawing.Size(217, 22);
            minLeftLabel.TabIndex = 4;
            minLeftLabel.Text = "Минимум слева от поб. диаг.";
            minLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valuesEvaluationButton
            // 
            this.valuesEvaluationButton.BackColor = System.Drawing.Color.Gold;
            this.valuesEvaluationButton.Font = new System.Drawing.Font("Alegreya SC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valuesEvaluationButton.Location = new System.Drawing.Point(668, 9);
            this.valuesEvaluationButton.Name = "valuesEvaluationButton";
            this.valuesEvaluationButton.Size = new System.Drawing.Size(119, 41);
            this.valuesEvaluationButton.TabIndex = 9;
            this.valuesEvaluationButton.Text = "Рассчитать";
            this.valuesEvaluationButton.UseVisualStyleBackColor = false;
            // 
            // asnwerBox
            // 
            this.asnwerBox.Controls.Add(this.geometricMeanBox);
            this.asnwerBox.Controls.Add(geometricMeanLabel);
            this.asnwerBox.Controls.Add(this.maxRightBox);
            this.asnwerBox.Controls.Add(this.minLeftBox);
            this.asnwerBox.Controls.Add(minLeftLabel);
            this.asnwerBox.Controls.Add(maxRightLabel);
            this.asnwerBox.Font = new System.Drawing.Font("Alegreya SC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.asnwerBox.Location = new System.Drawing.Point(518, 56);
            this.asnwerBox.Name = "asnwerBox";
            this.asnwerBox.Size = new System.Drawing.Size(269, 216);
            this.asnwerBox.TabIndex = 7;
            this.asnwerBox.TabStop = false;
            this.asnwerBox.Text = "Ответы";
            // 
            // geometricMeanBox
            // 
            this.geometricMeanBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.geometricMeanBox.Location = new System.Drawing.Point(33, 172);
            this.geometricMeanBox.Name = "geometricMeanBox";
            this.geometricMeanBox.ReadOnly = true;
            this.geometricMeanBox.Size = new System.Drawing.Size(209, 29);
            this.geometricMeanBox.TabIndex = 9;
            this.geometricMeanBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maxRightBox
            // 
            this.maxRightBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maxRightBox.Location = new System.Drawing.Point(33, 114);
            this.maxRightBox.Name = "maxRightBox";
            this.maxRightBox.ReadOnly = true;
            this.maxRightBox.Size = new System.Drawing.Size(209, 29);
            this.maxRightBox.TabIndex = 7;
            this.maxRightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minLeftBox
            // 
            this.minLeftBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minLeftBox.Location = new System.Drawing.Point(33, 57);
            this.minLeftBox.Name = "minLeftBox";
            this.minLeftBox.ReadOnly = true;
            this.minLeftBox.Size = new System.Drawing.Size(209, 29);
            this.minLeftBox.TabIndex = 5;
            this.minLeftBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrixGrid
            // 
            this.matrixGrid.AllowUserToAddRows = false;
            this.matrixGrid.AllowUserToDeleteRows = false;
            this.matrixGrid.AllowUserToResizeColumns = false;
            this.matrixGrid.AllowUserToResizeRows = false;
            this.matrixGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matrixGrid.BackgroundColor = System.Drawing.Color.White;
            this.matrixGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.matrixGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.matrixGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Mookmania", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "N3";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matrixGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.matrixGrid.Location = new System.Drawing.Point(12, 12);
            this.matrixGrid.Name = "matrixGrid";
            this.matrixGrid.RowHeadersVisible = false;
            this.matrixGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.matrixGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.matrixGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Mookmania", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.matrixGrid.RowTemplate.DefaultCellStyle.Format = "N3";
            this.matrixGrid.RowTemplate.DefaultCellStyle.NullValue = null;
            this.matrixGrid.RowTemplate.Height = 100;
            this.matrixGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.matrixGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.matrixGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.matrixGrid.Size = new System.Drawing.Size(500, 503);
            this.matrixGrid.TabIndex = 5;
            this.matrixGrid.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.ColumnAdded);
            // 
            // autoFillButton
            // 
            this.autoFillButton.BackColor = System.Drawing.Color.Gold;
            this.autoFillButton.Font = new System.Drawing.Font("Alegreya SC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autoFillButton.Location = new System.Drawing.Point(518, 9);
            this.autoFillButton.Name = "autoFillButton";
            this.autoFillButton.Size = new System.Drawing.Size(144, 41);
            this.autoFillButton.TabIndex = 10;
            this.autoFillButton.Text = "Автозаполнение";
            this.autoFillButton.UseVisualStyleBackColor = false;
            // 
            // Q1View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(799, 520);
            this.Controls.Add(this.autoFillButton);
            this.Controls.Add(this.valuesEvaluationButton);
            this.Controls.Add(this.asnwerBox);
            this.Controls.Add(this.matrixGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(815, 559);
            this.MinimumSize = new System.Drawing.Size(815, 559);
            this.Name = "Q1View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Матричные вычисления";
            this.asnwerBox.ResumeLayout(false);
            this.asnwerBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button valuesEvaluationButton;
        private System.Windows.Forms.GroupBox asnwerBox;
        private System.Windows.Forms.TextBox geometricMeanBox;
        private System.Windows.Forms.TextBox maxRightBox;
        private System.Windows.Forms.TextBox minLeftBox;
        private System.Windows.Forms.DataGridView matrixGrid;
        private System.Windows.Forms.Button autoFillButton;
    }
}

