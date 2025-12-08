using Tyuiu.PisarevMA.Sprint6.Task1.V14.Lib;

namespace Tyuiu.PisarevMA.Sprint6.Task1.V14
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
            labelCondition_PMA = new Label();
            groupBoxInput_PMA = new GroupBox();
            textBoxStart_PMA = new TextBox();
            textBoxStop_PMA = new TextBox();
            labelStart_PMA = new Label();
            labelEnd_PMA = new Label();
            labelResult_PMA = new Label();
            groupBoxOutput_PMA = new GroupBox();
            textBoxResult_PMA = new TextBox();
            buttonInfo_PMA = new Button();
            buttonDone_PMA = new Button();
            groupBoxCondition_PMA.SuspendLayout();
            groupBoxInput_PMA.SuspendLayout();
            groupBoxOutput_PMA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_PMA
            // 
            groupBoxCondition_PMA.Controls.Add(labelCondition_PMA);
            groupBoxCondition_PMA.Location = new Point(12, 12);
            groupBoxCondition_PMA.Name = "groupBoxCondition_PMA";
            groupBoxCondition_PMA.Size = new Size(522, 324);
            groupBoxCondition_PMA.TabIndex = 0;
            groupBoxCondition_PMA.TabStop = false;
            groupBoxCondition_PMA.Text = "Условие";
            groupBoxCondition_PMA.Enter += groupBoxCondition_PMA_Enter;
            // 
            // labelCondition_PMA
            // 
            labelCondition_PMA.AutoSize = true;
            labelCondition_PMA.Location = new Point(17, 19);
            labelCondition_PMA.Name = "labelCondition_PMA";
            labelCondition_PMA.Size = new Size(436, 30);
            labelCondition_PMA.TabIndex = 4;
            labelCondition_PMA.Text = "Протабулировать функцию F(x) на диапазоне [-5;5]. \nРезультат вывести в виде таблицы и округлить до двух знаков после запятой. ";
            labelCondition_PMA.Click += labelCondition_PMA_Click;
            // 
            // groupBoxInput_PMA
            // 
            groupBoxInput_PMA.Controls.Add(textBoxStart_PMA);
            groupBoxInput_PMA.Controls.Add(textBoxStop_PMA);
            groupBoxInput_PMA.Controls.Add(labelStart_PMA);
            groupBoxInput_PMA.Controls.Add(labelEnd_PMA);
            groupBoxInput_PMA.Location = new Point(12, 352);
            groupBoxInput_PMA.Name = "groupBoxInput_PMA";
            groupBoxInput_PMA.Size = new Size(253, 83);
            groupBoxInput_PMA.TabIndex = 1;
            groupBoxInput_PMA.TabStop = false;
            groupBoxInput_PMA.Text = "Ввод данных";
            // 
            // textBoxStart_PMA
            // 
            textBoxStart_PMA.Location = new Point(17, 37);
            textBoxStart_PMA.Name = "textBoxStart_PMA";
            textBoxStart_PMA.Size = new Size(100, 23);
            textBoxStart_PMA.TabIndex = 6;
            // 
            // textBoxStop_PMA
            // 
            textBoxStop_PMA.Location = new Point(138, 37);
            textBoxStop_PMA.Name = "textBoxStop_PMA";
            textBoxStop_PMA.Size = new Size(100, 23);
            textBoxStop_PMA.TabIndex = 7;
            // 
            // labelStart_PMA
            // 
            labelStart_PMA.AutoSize = true;
            labelStart_PMA.Location = new Point(28, 19);
            labelStart_PMA.Name = "labelStart_PMA";
            labelStart_PMA.Size = new Size(72, 15);
            labelStart_PMA.TabIndex = 2;
            labelStart_PMA.Text = "Старт шага:";
            labelStart_PMA.Click += label1_Click;
            // 
            // labelEnd_PMA
            // 
            labelEnd_PMA.AutoSize = true;
            labelEnd_PMA.Location = new Point(153, 19);
            labelEnd_PMA.Name = "labelEnd_PMA";
            labelEnd_PMA.Size = new Size(75, 15);
            labelEnd_PMA.TabIndex = 3;
            labelEnd_PMA.Text = "Конец шага:";
            // 
            // labelResult_PMA
            // 
            labelResult_PMA.AutoSize = true;
            labelResult_PMA.Location = new Point(6, 19);
            labelResult_PMA.Name = "labelResult_PMA";
            labelResult_PMA.Size = new Size(63, 15);
            labelResult_PMA.TabIndex = 5;
            labelResult_PMA.Text = "Результат:";
            // 
            // groupBoxOutput_PMA
            // 
            groupBoxOutput_PMA.Controls.Add(textBoxResult_PMA);
            groupBoxOutput_PMA.Controls.Add(labelResult_PMA);
            groupBoxOutput_PMA.Location = new Point(540, 21);
            groupBoxOutput_PMA.Name = "groupBoxOutput_PMA";
            groupBoxOutput_PMA.Size = new Size(248, 414);
            groupBoxOutput_PMA.TabIndex = 8;
            groupBoxOutput_PMA.TabStop = false;
            groupBoxOutput_PMA.Text = "Вывод данных";
            groupBoxOutput_PMA.Enter += groupBox1_Enter;
            // 
            // textBoxResult_PMA
            // 
            textBoxResult_PMA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_PMA.Location = new Point(6, 43);
            textBoxResult_PMA.Multiline = true;
            textBoxResult_PMA.Name = "textBoxResult_PMA";
            textBoxResult_PMA.ReadOnly = true;
            textBoxResult_PMA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_PMA.Size = new Size(236, 365);
            textBoxResult_PMA.TabIndex = 11;
            textBoxResult_PMA.TextChanged += textBoxResult_PMA_TextChanged;
            // 
            // buttonInfo_PMA
            // 
            buttonInfo_PMA.BackColor = Color.DodgerBlue;
            buttonInfo_PMA.Cursor = Cursors.Hand;
            buttonInfo_PMA.Location = new Point(271, 361);
            buttonInfo_PMA.Name = "buttonInfo_PMA";
            buttonInfo_PMA.Size = new Size(97, 74);
            buttonInfo_PMA.TabIndex = 9;
            buttonInfo_PMA.Text = "Справка";
            buttonInfo_PMA.UseVisualStyleBackColor = false;
            buttonInfo_PMA.Click += button1_Click;
            // 
            // buttonDone_PMA
            // 
            buttonDone_PMA.BackColor = Color.DarkGreen;
            buttonDone_PMA.Cursor = Cursors.Hand;
            buttonDone_PMA.Location = new Point(383, 361);
            buttonDone_PMA.Name = "buttonDone_PMA";
            buttonDone_PMA.Size = new Size(151, 74);
            buttonDone_PMA.TabIndex = 10;
            buttonDone_PMA.Text = "Выполнить";
            buttonDone_PMA.UseVisualStyleBackColor = false;
            buttonDone_PMA.Click += button2_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_PMA);
            Controls.Add(buttonInfo_PMA);
            Controls.Add(groupBoxOutput_PMA);
            Controls.Add(groupBoxInput_PMA);
            Controls.Add(groupBoxCondition_PMA);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 14 | Писарев М. А.";
            groupBoxCondition_PMA.ResumeLayout(false);
            groupBoxCondition_PMA.PerformLayout();
            groupBoxInput_PMA.ResumeLayout(false);
            groupBoxInput_PMA.PerformLayout();
            groupBoxOutput_PMA.ResumeLayout(false);
            groupBoxOutput_PMA.PerformLayout();
            ResumeLayout(false);
        }

        private void groupBoxCondition_PMA_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox groupBoxCondition_PMA;
        private Label labelCondition_PMA;
        private GroupBox groupBoxInput_PMA;
        private Label labelStart_PMA;
        private Label labelEnd_PMA;
        private Label labelResult_PMA;
        private TextBox textBoxStart_PMA;
        private TextBox textBoxStop_PMA;
        private GroupBox groupBoxOutput_PMA;
        private Button buttonInfo_PMA;
        private Button buttonDone_PMA;
        private TextBox textBoxResult_PMA;
    }
}