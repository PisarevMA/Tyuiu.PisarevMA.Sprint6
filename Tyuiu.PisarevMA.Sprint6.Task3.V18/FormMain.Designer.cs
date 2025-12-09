using Tyuiu.PisarevMA.Sprint6.Task3.V18.Lib;
namespace Tyuiu.PisarevMA.Sprint6.Task3.V18
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxCondition_PMA = new GroupBox();
            textBoxCondition_PMA = new TextBox();
            dataGridViewMas_PMA = new DataGridView();
            groupBoxOutput_PMA = new GroupBox();
            labelResult_PMA = new Label();
            buttonDone_PMA = new Button();
            buttonHelp_PMA = new Button();
            groupBoxCondition_PMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMas_PMA).BeginInit();
            groupBoxOutput_PMA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_PMA
            // 
            groupBoxCondition_PMA.Controls.Add(textBoxCondition_PMA);
            groupBoxCondition_PMA.Location = new Point(12, 12);
            groupBoxCondition_PMA.Name = "groupBoxCondition_PMA";
            groupBoxCondition_PMA.Size = new Size(480, 426);
            groupBoxCondition_PMA.TabIndex = 0;
            groupBoxCondition_PMA.TabStop = false;
            groupBoxCondition_PMA.Text = "Условие";
            groupBoxCondition_PMA.Enter += groupBoxCondition_PMA_Enter;
            // 
            // textBoxCondition_PMA
            // 
            textBoxCondition_PMA.Location = new Point(20, 28);
            textBoxCondition_PMA.Multiline = true;
            textBoxCondition_PMA.Name = "textBoxCondition_PMA";
            textBoxCondition_PMA.ReadOnly = true;
            textBoxCondition_PMA.Size = new Size(440, 380);
            textBoxCondition_PMA.TabIndex = 2;
            textBoxCondition_PMA.Text = "Дан массив 5 на 5 элементов.\r\n-19  -19   1   18   7\r\n  5      3   -4  -6  -12\r\n-15    6     2   2   -14\r\n-9    -10  15  -5  -6\r\n-13  -15  -9   7    1\r\nЗаменить четные значения в четвертой строке на 0";
            textBoxCondition_PMA.TextChanged += textBoxCondition_PMA_TextChanged;
            // 
            // dataGridViewMas_PMA
            // 
            dataGridViewMas_PMA.AllowUserToResizeColumns = false;
            dataGridViewMas_PMA.AllowUserToResizeRows = false;
            dataGridViewMas_PMA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMas_PMA.ColumnHeadersVisible = false;
            dataGridViewMas_PMA.Location = new Point(19, 46);
            dataGridViewMas_PMA.Name = "dataGridViewMas_PMA";
            dataGridViewMas_PMA.ReadOnly = true;
            dataGridViewMas_PMA.RowHeadersVisible = false;
            dataGridViewMas_PMA.Size = new Size(253, 128);
            dataGridViewMas_PMA.TabIndex = 1;
            dataGridViewMas_PMA.CellContentClick += dataGridViewMas_PMA_CellContentClick;
            // 
            // groupBoxOutput_PMA
            // 
            groupBoxOutput_PMA.Controls.Add(labelResult_PMA);
            groupBoxOutput_PMA.Controls.Add(dataGridViewMas_PMA);
            groupBoxOutput_PMA.Location = new Point(498, 12);
            groupBoxOutput_PMA.Name = "groupBoxOutput_PMA";
            groupBoxOutput_PMA.Size = new Size(290, 199);
            groupBoxOutput_PMA.TabIndex = 1;
            groupBoxOutput_PMA.TabStop = false;
            groupBoxOutput_PMA.Text = "Вывод данных";
            // 
            // labelResult_PMA
            // 
            labelResult_PMA.AutoSize = true;
            labelResult_PMA.Location = new Point(6, 19);
            labelResult_PMA.Name = "labelResult_PMA";
            labelResult_PMA.Size = new Size(63, 15);
            labelResult_PMA.TabIndex = 0;
            labelResult_PMA.Text = "Результат:";
            labelResult_PMA.Click += label1_Click;
            // 
            // buttonDone_PMA
            // 
            buttonDone_PMA.Cursor = Cursors.Hand;
            buttonDone_PMA.Location = new Point(579, 381);
            buttonDone_PMA.Name = "buttonDone_PMA";
            buttonDone_PMA.Size = new Size(209, 57);
            buttonDone_PMA.TabIndex = 2;
            buttonDone_PMA.Text = "Выполнить";
            buttonDone_PMA.UseVisualStyleBackColor = true;
            buttonDone_PMA.Click += buttonDone_PMA_Click;
            // 
            // buttonHelp_PMA
            // 
            buttonHelp_PMA.Cursor = Cursors.Hand;
            buttonHelp_PMA.Location = new Point(498, 381);
            buttonHelp_PMA.Name = "buttonHelp_PMA";
            buttonHelp_PMA.Size = new Size(75, 57);
            buttonHelp_PMA.TabIndex = 3;
            buttonHelp_PMA.Text = "?";
            buttonHelp_PMA.UseVisualStyleBackColor = true;
            buttonHelp_PMA.Click += button2_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_PMA);
            Controls.Add(buttonDone_PMA);
            Controls.Add(groupBoxOutput_PMA);
            Controls.Add(groupBoxCondition_PMA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 18 | Писарев М. А.";
            Load += FormMain_Load;
            groupBoxCondition_PMA.ResumeLayout(false);
            groupBoxCondition_PMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMas_PMA).EndInit();
            groupBoxOutput_PMA.ResumeLayout(false);
            groupBoxOutput_PMA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_PMA;
        private DataGridView dataGridViewMas_PMA;
        private GroupBox groupBoxOutput_PMA;
        private Label labelResult_PMA;
        private Button buttonDone_PMA;
        private Button buttonHelp_PMA;
        private TextBox textBoxCondition_PMA;
    }
}