namespace GeoFigureWindowsForms
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
            this.labelSelect = new System.Windows.Forms.Label();
            this.labelBaseOrLengthOrRadius = new System.Windows.Forms.Label();
            this.labelHeightOrSide1 = new System.Windows.Forms.Label();
            this.labelSide2 = new System.Windows.Forms.Label();
            this.labelSquare = new System.Windows.Forms.Label();
            this.labelPerimeter = new System.Windows.Forms.Label();
            this.comboBoxNameFigure = new System.Windows.Forms.ComboBox();
            this.buttonShowResult = new System.Windows.Forms.Button();
            this.textBoxBaseOrLengthOrRadius = new System.Windows.Forms.TextBox();
            this.textBoxHeightOrSide1 = new System.Windows.Forms.TextBox();
            this.textBoxSide2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelect.Location = new System.Drawing.Point(315, 46);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(144, 20);
            this.labelSelect.TabIndex = 0;
            this.labelSelect.Text = "Выбор фигуры";
            // 
            // labelBaseOrLengthOrRadius
            // 
            this.labelBaseOrLengthOrRadius.AutoSize = true;
            this.labelBaseOrLengthOrRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBaseOrLengthOrRadius.Location = new System.Drawing.Point(87, 158);
            this.labelBaseOrLengthOrRadius.Name = "labelBaseOrLengthOrRadius";
            this.labelBaseOrLengthOrRadius.Size = new System.Drawing.Size(0, 16);
            this.labelBaseOrLengthOrRadius.TabIndex = 1;
            // 
            // labelHeightOrSide1
            // 
            this.labelHeightOrSide1.AutoSize = true;
            this.labelHeightOrSide1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeightOrSide1.Location = new System.Drawing.Point(306, 158);
            this.labelHeightOrSide1.Name = "labelHeightOrSide1";
            this.labelHeightOrSide1.Size = new System.Drawing.Size(0, 16);
            this.labelHeightOrSide1.TabIndex = 2;
            // 
            // labelSide2
            // 
            this.labelSide2.AutoSize = true;
            this.labelSide2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSide2.Location = new System.Drawing.Point(522, 161);
            this.labelSide2.Name = "labelSide2";
            this.labelSide2.Size = new System.Drawing.Size(0, 16);
            this.labelSide2.TabIndex = 3;
            // 
            // labelSquare
            // 
            this.labelSquare.AutoSize = true;
            this.labelSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSquare.Location = new System.Drawing.Point(305, 248);
            this.labelSquare.Name = "labelSquare";
            this.labelSquare.Size = new System.Drawing.Size(101, 20);
            this.labelSquare.TabIndex = 4;
            this.labelSquare.Text = "Площадь:";
            // 
            // labelPerimeter
            // 
            this.labelPerimeter.AutoSize = true;
            this.labelPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPerimeter.Location = new System.Drawing.Point(306, 307);
            this.labelPerimeter.Name = "labelPerimeter";
            this.labelPerimeter.Size = new System.Drawing.Size(108, 20);
            this.labelPerimeter.TabIndex = 5;
            this.labelPerimeter.Text = "Периметр:";
            // 
            // comboBoxNameFigure
            // 
            this.comboBoxNameFigure.FormattingEnabled = true;
            this.comboBoxNameFigure.Items.AddRange(new object[] {
            "Прямоугольник",
            "Треугольник",
            "Круг"});
            this.comboBoxNameFigure.Location = new System.Drawing.Point(309, 69);
            this.comboBoxNameFigure.Name = "comboBoxNameFigure";
            this.comboBoxNameFigure.Size = new System.Drawing.Size(159, 24);
            this.comboBoxNameFigure.TabIndex = 6;
            this.comboBoxNameFigure.SelectedIndexChanged += new System.EventHandler(this.comboBoxNameFigure_SelectedIndexChanged);
            // 
            // buttonShowResult
            // 
            this.buttonShowResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonShowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonShowResult.Location = new System.Drawing.Point(309, 368);
            this.buttonShowResult.Name = "buttonShowResult";
            this.buttonShowResult.Size = new System.Drawing.Size(159, 35);
            this.buttonShowResult.TabIndex = 7;
            this.buttonShowResult.Text = "Рассчитать";
            this.buttonShowResult.UseVisualStyleBackColor = false;
            this.buttonShowResult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonShowResult_MouseClick);
            // 
            // textBoxBaseOrLengthOrRadius
            // 
            this.textBoxBaseOrLengthOrRadius.Location = new System.Drawing.Point(91, 180);
            this.textBoxBaseOrLengthOrRadius.Name = "textBoxBaseOrLengthOrRadius";
            this.textBoxBaseOrLengthOrRadius.Size = new System.Drawing.Size(159, 22);
            this.textBoxBaseOrLengthOrRadius.TabIndex = 8;
            // 
            // textBoxHeightOrSide1
            // 
            this.textBoxHeightOrSide1.Location = new System.Drawing.Point(309, 180);
            this.textBoxHeightOrSide1.Name = "textBoxHeightOrSide1";
            this.textBoxHeightOrSide1.Size = new System.Drawing.Size(159, 22);
            this.textBoxHeightOrSide1.TabIndex = 9;
            // 
            // textBoxSide2
            // 
            this.textBoxSide2.Location = new System.Drawing.Point(525, 180);
            this.textBoxSide2.Name = "textBoxSide2";
            this.textBoxSide2.Size = new System.Drawing.Size(159, 22);
            this.textBoxSide2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSide2);
            this.Controls.Add(this.textBoxHeightOrSide1);
            this.Controls.Add(this.textBoxBaseOrLengthOrRadius);
            this.Controls.Add(this.buttonShowResult);
            this.Controls.Add(this.comboBoxNameFigure);
            this.Controls.Add(this.labelPerimeter);
            this.Controls.Add(this.labelSquare);
            this.Controls.Add(this.labelSide2);
            this.Controls.Add(this.labelHeightOrSide1);
            this.Controls.Add(this.labelBaseOrLengthOrRadius);
            this.Controls.Add(this.labelSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.Label labelBaseOrLengthOrRadius;
        private System.Windows.Forms.Label labelHeightOrSide1;
        private System.Windows.Forms.Label labelSide2;
        private System.Windows.Forms.Label labelSquare;
        private System.Windows.Forms.Label labelPerimeter;
        private System.Windows.Forms.ComboBox comboBoxNameFigure;
        private System.Windows.Forms.Button buttonShowResult;
        private System.Windows.Forms.TextBox textBoxBaseOrLengthOrRadius;
        private System.Windows.Forms.TextBox textBoxHeightOrSide1;
        private System.Windows.Forms.TextBox textBoxSide2;
    }
}

