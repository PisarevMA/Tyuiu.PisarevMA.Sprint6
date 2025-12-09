using Tyuiu.PisarevMA.Sprint6.Task4.V22.Lib;
namespace Tyuiu.PisarevMA.Sprint6.Task4.V22
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            textBoxResult_PMA = new TextBox();
            groupBoxCondition_PMA = new GroupBox();
            labelCondition_PMA = new Label();
            groupBoxInput_PMA = new GroupBox();
            labelStart_PMA = new Label();
            labelStop_PMA = new Label();
            textBoxStart_PMA = new TextBox();
            textBoxStop_PMA = new TextBox();
            labelOutput_PMA = new Label();
            chartFunc_PMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonDone_PMA = new Button();
            buttonSave_PMA = new Button();
            buttonHelp_PMA = new Button();
            groupBoxCondition_PMA.SuspendLayout();
            groupBoxInput_PMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunc_PMA).BeginInit();
            SuspendLayout();

            // 
            // textBoxResult_PMA
            // 
            textBoxResult_PMA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxResult_PMA.Location = new Point(5, 104);
            textBoxResult_PMA.Multiline = true;
            textBoxResult_PMA.Name = "textBoxResult_PMA";
            textBoxResult_PMA.ReadOnly = true;
            textBoxResult_PMA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_PMA.Size = new Size(204, 346);
            textBoxResult_PMA.TabIndex = 0;
            textBoxResult_PMA.TextChanged += textBoxResult_PMA_TextChanged;
            // 
            // groupBoxCondition_PMA
            // 
            groupBoxCondition_PMA.Controls.Add(labelCondition_PMA);
            groupBoxCondition_PMA.Location = new Point(12, 0);
            groupBoxCondition_PMA.Name = "groupBoxCondition_PMA";
            groupBoxCondition_PMA.Size = new Size(325, 84);
            groupBoxCondition_PMA.TabIndex = 1;
            groupBoxCondition_PMA.TabStop = false;
            groupBoxCondition_PMA.Text = "Условие";
            // 
            // labelCondition_PMA
            // 
            labelCondition_PMA.AutoSize = true;
            labelCondition_PMA.Location = new Point(6, 19);
            labelCondition_PMA.Name = "labelCondition_PMA";
            labelCondition_PMA.Size = new Size(291, 30);
            labelCondition_PMA.TabIndex = 2;
            labelCondition_PMA.Text = "Протабулировать функцию f(x) на диапазоне [-5;5].\nОкруглить до двух знаков после запятой. ";
            labelCondition_PMA.Click += labelCondition_PMA_Click;
            // 
            // groupBoxInput_PMA
            // 
            groupBoxInput_PMA.Controls.Add(labelStart_PMA);
            groupBoxInput_PMA.Controls.Add(labelStop_PMA);
            groupBoxInput_PMA.Controls.Add(textBoxStart_PMA);
            groupBoxInput_PMA.Controls.Add(textBoxStop_PMA);
            groupBoxInput_PMA.Location = new Point(343, 0);
            groupBoxInput_PMA.Name = "groupBoxInput_PMA";
            groupBoxInput_PMA.Size = new Size(289, 84);
            groupBoxInput_PMA.TabIndex = 0;
            groupBoxInput_PMA.TabStop = false;
            groupBoxInput_PMA.Text = "Ввод данных";
            // 
            // labelStart_PMA
            // 
            labelStart_PMA.AutoSize = true;
            labelStart_PMA.Location = new Point(38, 28);
            labelStart_PMA.Name = "labelStart_PMA";
            labelStart_PMA.Size = new Size(72, 15);
            labelStart_PMA.TabIndex = 7;
            labelStart_PMA.Text = "Старт шага:";
            // 
            // labelStop_PMA
            // 
            labelStop_PMA.AutoSize = true;
            labelStop_PMA.Location = new Point(173, 28);
            labelStop_PMA.Name = "labelStop_PMA";
            labelStop_PMA.Size = new Size(75, 15);
            labelStop_PMA.TabIndex = 8;
            labelStop_PMA.Text = "Конец шага:";
            // 
            // textBoxStart_PMA
            // 
            textBoxStart_PMA.Location = new Point(25, 46);
            textBoxStart_PMA.Name = "textBoxStart_PMA";
            textBoxStart_PMA.Size = new Size(100, 23);
            textBoxStart_PMA.TabIndex = 2;
            // 
            // textBoxStop_PMA
            // 
            textBoxStop_PMA.Location = new Point(161, 46);
            textBoxStop_PMA.Name = "textBoxStop_PMA";
            textBoxStop_PMA.Size = new Size(100, 23);
            textBoxStop_PMA.TabIndex = 3;
            // 
            // labelOutput_PMA
            // 
            labelOutput_PMA.AutoSize = true;
            labelOutput_PMA.Location = new Point(18, 86);
            labelOutput_PMA.Name = "labelOutput_PMA";
            labelOutput_PMA.Size = new Size(86, 15);
            labelOutput_PMA.TabIndex = 2;
            labelOutput_PMA.Text = "Вывод данных";
            // 
            // chartFunc_PMA
            // 
            chartFunc_PMA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartFunc_PMA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunc_PMA.Legends.Add(legend1);
            chartFunc_PMA.Location = new Point(215, 86);
            chartFunc_PMA.Name = "chartFunc_PMA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunc_PMA.Series.Add(series1);
            chartFunc_PMA.Size = new Size(709, 364);
            chartFunc_PMA.TabIndex = 3;
            chartFunc_PMA.Text = "chart1";
            title1.Name = "Titlefx";
            title1.Text = "График функции f(x)";
            chartFunc_PMA.Titles.Add(title1);
            // 
            // buttonDone_PMA
            // 
            buttonDone_PMA.BackColor = Color.Green;
            buttonDone_PMA.Cursor = Cursors.Hand;
            buttonDone_PMA.Location = new Point(638, 12);
            buttonDone_PMA.Name = "buttonDone_PMA";
            buttonDone_PMA.Size = new Size(97, 68);
            buttonDone_PMA.TabIndex = 4;
            buttonDone_PMA.Text = "Выполнить";
            buttonDone_PMA.UseVisualStyleBackColor = false;
            buttonDone_PMA.Click += buttonDone_PMA_Click;
            // 
            // buttonSave_PMA
            // 
            buttonSave_PMA.BackColor = Color.RoyalBlue;
            buttonSave_PMA.Cursor = Cursors.Hand;
            buttonSave_PMA.Location = new Point(741, 12);
            buttonSave_PMA.Name = "buttonSave_PMA";
            buttonSave_PMA.Size = new Size(89, 68);
            buttonSave_PMA.TabIndex = 5;
            buttonSave_PMA.Text = "Сохранить";
            buttonSave_PMA.UseVisualStyleBackColor = false;
            buttonSave_PMA.Click += buttonSave_PMA_Click;
            // 
            // buttonHelp_PMA
            // 
            buttonHelp_PMA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_PMA.BackColor = Color.CornflowerBlue;
            buttonHelp_PMA.Cursor = Cursors.Hand;
            buttonHelp_PMA.Location = new Point(836, 12);
            buttonHelp_PMA.Name = "buttonHelp_PMA";
            buttonHelp_PMA.Size = new Size(75, 68);
            buttonHelp_PMA.TabIndex = 6;
            buttonHelp_PMA.Text = "Справка";
            buttonHelp_PMA.UseVisualStyleBackColor = false;
            buttonHelp_PMA.Click += buttonHelp_PMA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 450);
            Controls.Add(buttonHelp_PMA);
            Controls.Add(buttonSave_PMA);
            Controls.Add(buttonDone_PMA);
            Controls.Add(chartFunc_PMA);
            Controls.Add(labelOutput_PMA);
            Controls.Add(groupBoxInput_PMA);
            Controls.Add(groupBoxCondition_PMA);
            Controls.Add(textBoxResult_PMA);
            MinimumSize = new Size(939, 489);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 22 | Писарев М. А.";
            groupBoxCondition_PMA.ResumeLayout(false);
            groupBoxCondition_PMA.PerformLayout();
            groupBoxInput_PMA.ResumeLayout(false);
            groupBoxInput_PMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunc_PMA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxResult_PMA;
        private GroupBox groupBoxCondition_PMA;
        private Label labelCondition_PMA;
        private GroupBox groupBoxInput_PMA;
        private TextBox textBoxStart_PMA;
        private TextBox textBoxStop_PMA;
        private Label labelOutput_PMA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc_PMA;
        private Label labelStart_PMA;
        private Label labelStop_PMA;
        private Button buttonDone_PMA;
        private Button buttonSave_PMA;
        private Button buttonHelp_PMA;
    }
}