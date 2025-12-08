using Tyuiu.PisarevMA.Sprint6.Task2.V27.Lib;
namespace Tyuiu.PisarevMA.Sprint6.Task2.V27
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxCondition_PMA = new GroupBox();
            labelCondition_PMA = new Label();
            groupBoxInput_PMA = new GroupBox();
            textBoxStart_PMA = new TextBox();
            textBoxStop_PMA = new TextBox();
            labelStart_PMA = new Label();
            labelStop_PMA = new Label();
            groupBoxOutput_PMA = new GroupBox();
            chartVisFunc_PMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewTable_PMA = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            FX = new DataGridViewTextBoxColumn();
            labelResult_PMA = new Label();
            buttonInfo_PMA = new Button();
            buttonDone_PMA = new Button();
            bindingSource1 = new BindingSource(components);
            groupBoxCondition_PMA.SuspendLayout();
            groupBoxInput_PMA.SuspendLayout();
            groupBoxOutput_PMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartVisFunc_PMA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable_PMA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_PMA
            // 
            groupBoxCondition_PMA.Controls.Add(labelCondition_PMA);
            groupBoxCondition_PMA.Location = new Point(12, 12);
            groupBoxCondition_PMA.Name = "groupBoxCondition_PMA";
            groupBoxCondition_PMA.Size = new Size(521, 329);
            groupBoxCondition_PMA.TabIndex = 0;
            groupBoxCondition_PMA.TabStop = false;
            groupBoxCondition_PMA.Text = "Условие";
            // 
            // labelCondition_PMA
            // 
            labelCondition_PMA.AutoSize = true;
            labelCondition_PMA.Location = new Point(20, 19);
            labelCondition_PMA.Name = "labelCondition_PMA";
            labelCondition_PMA.Size = new Size(362, 30);
            labelCondition_PMA.TabIndex = 4;
            labelCondition_PMA.Text = "Протабулировать функцию F(x) на диапазоне [-5;5]. \nРезультат вывести в DataGridView и построить график функции. ";
            labelCondition_PMA.Click += labelCondition_PMA_Click;
            // 
            // groupBoxInput_PMA
            // 
            groupBoxInput_PMA.Controls.Add(textBoxStart_PMA);
            groupBoxInput_PMA.Controls.Add(textBoxStop_PMA);
            groupBoxInput_PMA.Controls.Add(labelStart_PMA);
            groupBoxInput_PMA.Controls.Add(labelStop_PMA);
            groupBoxInput_PMA.Location = new Point(12, 347);
            groupBoxInput_PMA.Name = "groupBoxInput_PMA";
            groupBoxInput_PMA.Size = new Size(259, 91);
            groupBoxInput_PMA.TabIndex = 1;
            groupBoxInput_PMA.TabStop = false;
            groupBoxInput_PMA.Text = "Ввод данных";
            // 
            // textBoxStart_PMA
            // 
            textBoxStart_PMA.Location = new Point(20, 46);
            textBoxStart_PMA.Name = "textBoxStart_PMA";
            textBoxStart_PMA.Size = new Size(100, 23);
            textBoxStart_PMA.TabIndex = 5;
            // 
            // textBoxStop_PMA
            // 
            textBoxStop_PMA.Location = new Point(131, 46);
            textBoxStop_PMA.Name = "textBoxStop_PMA";
            textBoxStop_PMA.Size = new Size(100, 23);
            textBoxStop_PMA.TabIndex = 6;
            // 
            // labelStart_PMA
            // 
            labelStart_PMA.AutoSize = true;
            labelStart_PMA.Location = new Point(34, 28);
            labelStart_PMA.Name = "labelStart_PMA";
            labelStart_PMA.Size = new Size(72, 15);
            labelStart_PMA.TabIndex = 5;
            labelStart_PMA.Text = "Старт шага:";
            // 
            // labelStop_PMA
            // 
            labelStop_PMA.AutoSize = true;
            labelStop_PMA.Location = new Point(144, 28);
            labelStop_PMA.Name = "labelStop_PMA";
            labelStop_PMA.Size = new Size(75, 15);
            labelStop_PMA.TabIndex = 6;
            labelStop_PMA.Text = "Конец шага:";
            // 
            // groupBoxOutput_PMA
            // 
            groupBoxOutput_PMA.Controls.Add(chartVisFunc_PMA);
            groupBoxOutput_PMA.Controls.Add(dataGridViewTable_PMA);
            groupBoxOutput_PMA.Controls.Add(labelResult_PMA);
            groupBoxOutput_PMA.Location = new Point(539, 12);
            groupBoxOutput_PMA.Name = "groupBoxOutput_PMA";
            groupBoxOutput_PMA.Size = new Size(563, 426);
            groupBoxOutput_PMA.TabIndex = 0;
            groupBoxOutput_PMA.TabStop = false;
            groupBoxOutput_PMA.Text = "Вывод данных";
            // 
            // chartVisFunc_PMA
            // 
            chartArea1.Name = "ChartArea1";
            chartVisFunc_PMA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartVisFunc_PMA.Legends.Add(legend1);
            chartVisFunc_PMA.Location = new Point(130, 37);
            chartVisFunc_PMA.Name = "chartVisFunc_PMA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartVisFunc_PMA.Series.Add(series1);
            chartVisFunc_PMA.Size = new Size(433, 382);
            chartVisFunc_PMA.TabIndex = 4;
            chartVisFunc_PMA.Text = "chart1";
            chartVisFunc_PMA.Click += chart1_Click;
            // 
            // dataGridViewTable_PMA
            // 
            dataGridViewTable_PMA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTable_PMA.Columns.AddRange(new DataGridViewColumn[] { X, FX });
            dataGridViewTable_PMA.Location = new Point(22, 37);
            dataGridViewTable_PMA.Name = "dataGridViewTable_PMA";
            dataGridViewTable_PMA.RowHeadersVisible = false;
            dataGridViewTable_PMA.Size = new Size(102, 382);
            dataGridViewTable_PMA.TabIndex = 4;
            dataGridViewTable_PMA.CellContentClick += dataGridViewTable_PMA_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // FX
            // 
            FX.HeaderText = "FX";
            FX.Name = "FX";
            FX.Width = 50;
            // 
            // labelResult_PMA
            // 
            labelResult_PMA.AutoSize = true;
            labelResult_PMA.Location = new Point(6, 19);
            labelResult_PMA.Name = "labelResult_PMA";
            labelResult_PMA.Size = new Size(63, 15);
            labelResult_PMA.TabIndex = 7;
            labelResult_PMA.Text = "Результат:";
            // 
            // buttonInfo_PMA
            // 
            buttonInfo_PMA.BackColor = Color.DodgerBlue;
            buttonInfo_PMA.Cursor = Cursors.Hand;
            buttonInfo_PMA.Location = new Point(277, 347);
            buttonInfo_PMA.Name = "buttonInfo_PMA";
            buttonInfo_PMA.Size = new Size(94, 91);
            buttonInfo_PMA.TabIndex = 2;
            buttonInfo_PMA.Text = "Справка";
            buttonInfo_PMA.UseVisualStyleBackColor = false;
            buttonInfo_PMA.Click += button1_Click;
            // 
            // buttonDone_PMA
            // 
            buttonDone_PMA.BackColor = Color.Green;
            buttonDone_PMA.Cursor = Cursors.Hand;
            buttonDone_PMA.Location = new Point(377, 347);
            buttonDone_PMA.Name = "buttonDone_PMA";
            buttonDone_PMA.Size = new Size(156, 91);
            buttonDone_PMA.TabIndex = 3;
            buttonDone_PMA.Text = "Выполнить";
            buttonDone_PMA.UseVisualStyleBackColor = false;
            buttonDone_PMA.Click += buttonDone_PMA_Click;
            buttonDone_PMA.MouseDown += buttonDone_PMA_MouseDown;
            buttonDone_PMA.MouseEnter += buttonDone_PMA_MouseEnter;
            buttonDone_PMA.MouseLeave += buttonDone_PMA_MouseLeave;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 443);
            Controls.Add(buttonDone_PMA);
            Controls.Add(buttonInfo_PMA);
            Controls.Add(groupBoxOutput_PMA);
            Controls.Add(groupBoxInput_PMA);
            Controls.Add(groupBoxCondition_PMA);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 27 | Писарев М. А.";
            groupBoxCondition_PMA.ResumeLayout(false);
            groupBoxCondition_PMA.PerformLayout();
            groupBoxInput_PMA.ResumeLayout(false);
            groupBoxInput_PMA.PerformLayout();
            groupBoxOutput_PMA.ResumeLayout(false);
            groupBoxOutput_PMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartVisFunc_PMA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable_PMA).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        private void dataGridViewTable_PMA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox groupBoxCondition_PMA;
        private GroupBox groupBoxInput_PMA;
        private GroupBox groupBoxOutput_PMA;
        private Button buttonInfo_PMA;
        private Button buttonDone_PMA;
        private Label labelCondition_PMA;
        private Label labelStart_PMA;
        private Label labelStop_PMA;
        private Label labelResult_PMA;
        private TextBox textBoxStart_PMA;
        private TextBox textBoxStop_PMA;
        private DataGridView dataGridViewTable_PMA;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn FX;
        private BindingSource bindingSource1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVisFunc_PMA;
    }
}
