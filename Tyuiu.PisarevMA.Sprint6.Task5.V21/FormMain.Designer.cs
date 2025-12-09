using Tyuiu.PisarevMA.Sprint6.Task5.V21.Lib;
namespace Tyuiu.PisarevMA.Sprint6.Task5.V21
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            dataGridViewResult_PMA = new DataGridView();
            groupBoxCondition_PMA = new GroupBox();
            labelCondition_PMA = new Label();
            chartDiag_PMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonDone_PMA = new Button();
            buttonOpenFile_PMA = new Button();
            buttonHelp_PMA = new Button();
            labelOutput_PMA = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_PMA).BeginInit();
            groupBoxCondition_PMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiag_PMA).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewResult_PMA
            // 
            dataGridViewResult_PMA.AllowUserToAddRows = false;
            dataGridViewResult_PMA.AllowUserToDeleteRows = false;
            dataGridViewResult_PMA.AllowUserToResizeColumns = false;
            dataGridViewResult_PMA.AllowUserToResizeRows = false;
            dataGridViewResult_PMA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewResult_PMA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_PMA.ColumnHeadersVisible = false;
            dataGridViewResult_PMA.Location = new Point(2, 118);
            dataGridViewResult_PMA.MinimumSize = new Size(164, 327);
            dataGridViewResult_PMA.Name = "dataGridViewResult_PMA";
            dataGridViewResult_PMA.ReadOnly = true;
            dataGridViewResult_PMA.RowHeadersVisible = false;
            dataGridViewResult_PMA.ScrollBars = ScrollBars.Vertical;
            dataGridViewResult_PMA.Size = new Size(164, 327);
            dataGridViewResult_PMA.TabIndex = 0;
            dataGridViewResult_PMA.CellContentClick += dataGridViewResult_PMA_CellContentClick;
            // 
            // groupBoxCondition_PMA
            // 
            groupBoxCondition_PMA.Controls.Add(labelCondition_PMA);
            groupBoxCondition_PMA.Location = new Point(2, 4);
            groupBoxCondition_PMA.Name = "groupBoxCondition_PMA";
            groupBoxCondition_PMA.Size = new Size(451, 96);
            groupBoxCondition_PMA.TabIndex = 1;
            groupBoxCondition_PMA.TabStop = false;
            groupBoxCondition_PMA.Text = "Условие";
            // 
            // labelCondition_PMA
            // 
            labelCondition_PMA.AutoSize = true;
            labelCondition_PMA.Location = new Point(10, 19);
            labelCondition_PMA.Name = "labelCondition_PMA";
            labelCondition_PMA.Size = new Size(380, 60);
            labelCondition_PMA.TabIndex = 2;
            labelCondition_PMA.Text = "Прочитать данные из файла InPutFileTask5V21.txt. \r\nВывести все числа, кратные 3. \r\nПостроить диаграмму по этим значениям. \r\nУ вещественных значений округлить до трёх знаков после запятой.";
            labelCondition_PMA.Click += labelCondition_PMA_Click;
            // 
            // chartDiag_PMA
            // 
            chartDiag_PMA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartDiag_PMA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDiag_PMA.Legends.Add(legend1);
            chartDiag_PMA.Location = new Point(172, 106);
            chartDiag_PMA.Name = "chartDiag_PMA";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag_PMA.Series.Add(series1);
            chartDiag_PMA.Size = new Size(627, 339);
            chartDiag_PMA.TabIndex = 2;
            chartDiag_PMA.Text = "chart1";
            // 
            // buttonDone_PMA
            // 
            buttonDone_PMA.BackColor = Color.Green;
            buttonDone_PMA.Cursor = Cursors.Hand;
            buttonDone_PMA.Location = new Point(471, 22);
            buttonDone_PMA.Name = "buttonDone_PMA";
            buttonDone_PMA.Size = new Size(91, 66);
            buttonDone_PMA.TabIndex = 3;
            buttonDone_PMA.Text = "Выполнить";
            buttonDone_PMA.UseVisualStyleBackColor = false;
            buttonDone_PMA.Click += buttonDone_PMA_Click;
            // 
            // buttonOpenFile_PMA
            // 
            buttonOpenFile_PMA.BackColor = SystemColors.HotTrack;
            buttonOpenFile_PMA.Cursor = Cursors.Hand;
            buttonOpenFile_PMA.Location = new Point(580, 22);
            buttonOpenFile_PMA.Name = "buttonOpenFile_PMA";
            buttonOpenFile_PMA.Size = new Size(91, 65);
            buttonOpenFile_PMA.TabIndex = 4;
            buttonOpenFile_PMA.Text = "Открыть файл";
            buttonOpenFile_PMA.UseVisualStyleBackColor = false;
            buttonOpenFile_PMA.Click += buttonOpenFile_PMA_Click;
            // 
            // buttonHelp_PMA
            // 
            buttonHelp_PMA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_PMA.BackColor = Color.DodgerBlue;
            buttonHelp_PMA.Cursor = Cursors.Hand;
            buttonHelp_PMA.Location = new Point(687, 22);
            buttonHelp_PMA.Name = "buttonHelp_PMA";
            buttonHelp_PMA.Size = new Size(91, 64);
            buttonHelp_PMA.TabIndex = 5;
            buttonHelp_PMA.Text = "Справка";
            buttonHelp_PMA.UseVisualStyleBackColor = false;
            buttonHelp_PMA.Click += buttonHelp_PMA_Click;
            // 
            // labelOutput_PMA
            // 
            labelOutput_PMA.AutoSize = true;
            labelOutput_PMA.Location = new Point(8, 100);
            labelOutput_PMA.Name = "labelOutput_PMA";
            labelOutput_PMA.Size = new Size(89, 15);
            labelOutput_PMA.TabIndex = 6;
            labelOutput_PMA.Text = "Вывод данных:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 446);
            Controls.Add(labelOutput_PMA);
            Controls.Add(buttonHelp_PMA);
            Controls.Add(buttonOpenFile_PMA);
            Controls.Add(buttonDone_PMA);
            Controls.Add(chartDiag_PMA);
            Controls.Add(groupBoxCondition_PMA);
            Controls.Add(dataGridViewResult_PMA);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(816, 485);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 21 | Писарев М. А.";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_PMA).EndInit();
            groupBoxCondition_PMA.ResumeLayout(false);
            groupBoxCondition_PMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiag_PMA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewResult_PMA;
        private GroupBox groupBoxCondition_PMA;
        private Label labelCondition_PMA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_PMA;
        private Button buttonDone_PMA;
        private Button buttonOpenFile_PMA;
        private Button buttonHelp_PMA;
        private Label labelOutput_PMA;
    }
}