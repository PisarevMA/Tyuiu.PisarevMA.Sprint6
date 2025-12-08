using Tyuiu.PisarevMA.Sprint6.Task0.V9.Lib;

namespace Tyuiu.PisarevMA.Sprint6.Task0.V9
{
    partial class FormMain : Form
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
            textBoxVariable_PMA = new TextBox();
            buttonDone_PMA = new Button();
            groupBoxInput_PMA = new GroupBox();
            labelVariable_PMA = new Label();
            groupBoxOutput_PMA = new GroupBox();
            textBoxResult_PMA = new TextBox();
            labelResult_PMA = new Label();
            buttonHelp = new Button();
            groupBoxCondition_PMA = new GroupBox();
            labelCondition_PMA = new Label();
            pictureBoxFormula_PMA = new PictureBox();
            groupBoxInput_PMA.SuspendLayout();
            groupBoxOutput_PMA.SuspendLayout();
            groupBoxCondition_PMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_PMA).BeginInit();
            SuspendLayout();
            // 
            // textBoxVariable_PMA
            // 
            textBoxVariable_PMA.Location = new Point(32, 62);
            textBoxVariable_PMA.Name = "textBoxVariable_PMA";
            textBoxVariable_PMA.Size = new Size(89, 23);
            textBoxVariable_PMA.TabIndex = 2;
            textBoxVariable_PMA.Text = "3";
            textBoxVariable_PMA.TextChanged += textBoxVariable_PMA_TextChanged;
            // 
            // buttonDone_PMA
            // 
            buttonDone_PMA.Cursor = Cursors.Hand;
            buttonDone_PMA.Location = new Point(667, 393);
            buttonDone_PMA.Name = "buttonDone_PMA";
            buttonDone_PMA.Size = new Size(106, 32);
            buttonDone_PMA.TabIndex = 0;
            buttonDone_PMA.Text = "Выполнить";
            buttonDone_PMA.UseVisualStyleBackColor = true;
            buttonDone_PMA.Click += button_PMA_Click;
            // 
            // groupBoxInput_PMA
            // 
            groupBoxInput_PMA.Controls.Add(labelVariable_PMA);
            groupBoxInput_PMA.Controls.Add(textBoxVariable_PMA);
            groupBoxInput_PMA.Location = new Point(12, 291);
            groupBoxInput_PMA.Name = "groupBoxInput_PMA";
            groupBoxInput_PMA.Size = new Size(583, 134);
            groupBoxInput_PMA.TabIndex = 3;
            groupBoxInput_PMA.TabStop = false;
            groupBoxInput_PMA.Text = "Ввод данных";
            groupBoxInput_PMA.Enter += groupBoxInput_PMA_Enter;
            // 
            // labelVariable_PMA
            // 
            labelVariable_PMA.AutoSize = true;
            labelVariable_PMA.Location = new Point(32, 44);
            labelVariable_PMA.Name = "labelVariable_PMA";
            labelVariable_PMA.Size = new Size(88, 15);
            labelVariable_PMA.TabIndex = 4;
            labelVariable_PMA.Text = "Переменная x:";
            // 
            // groupBoxOutput_PMA
            // 
            groupBoxOutput_PMA.Controls.Add(textBoxResult_PMA);
            groupBoxOutput_PMA.Controls.Add(labelResult_PMA);
            groupBoxOutput_PMA.Location = new Point(601, 291);
            groupBoxOutput_PMA.Name = "groupBoxOutput_PMA";
            groupBoxOutput_PMA.Size = new Size(187, 96);
            groupBoxOutput_PMA.TabIndex = 4;
            groupBoxOutput_PMA.TabStop = false;
            groupBoxOutput_PMA.Text = "Вывод данных";
            groupBoxOutput_PMA.Enter += groupBoxOutput_PMA_Enter;
            // 
            // textBoxResult_PMA
            // 
            textBoxResult_PMA.Location = new Point(22, 51);
            textBoxResult_PMA.Name = "textBoxResult_PMA";
            textBoxResult_PMA.ReadOnly = true;
            textBoxResult_PMA.Size = new Size(150, 23);
            textBoxResult_PMA.TabIndex = 5;
            textBoxResult_PMA.TextChanged += textBoxVariable_PMA_TextChanged;
            // 
            // labelResult_PMA
            // 
            labelResult_PMA.AutoSize = true;
            labelResult_PMA.Location = new Point(22, 33);
            labelResult_PMA.Name = "labelResult_PMA";
            labelResult_PMA.Size = new Size(63, 15);
            labelResult_PMA.TabIndex = 5;
            labelResult_PMA.Text = "Результат:";
            // 
            // buttonHelp
            // 
            buttonHelp.Cursor = Cursors.Hand;
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(601, 393);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(60, 40);
            buttonHelp.TabIndex = 5;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // groupBoxCondition_PMA
            // 
            groupBoxCondition_PMA.Controls.Add(labelCondition_PMA);
            groupBoxCondition_PMA.Controls.Add(pictureBoxFormula_PMA);
            groupBoxCondition_PMA.Location = new Point(15, 23);
            groupBoxCondition_PMA.Name = "groupBoxCondition_PMA";
            groupBoxCondition_PMA.Size = new Size(773, 251);
            groupBoxCondition_PMA.TabIndex = 6;
            groupBoxCondition_PMA.TabStop = false;
            groupBoxCondition_PMA.Text = "Условие";
            // 
            // labelCondition_PMA
            // 
            labelCondition_PMA.AutoSize = true;
            labelCondition_PMA.Location = new Point(29, 32);
            labelCondition_PMA.Name = "labelCondition_PMA";
            labelCondition_PMA.Size = new Size(458, 30);
            labelCondition_PMA.TabIndex = 7;
            labelCondition_PMA.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. \r\nОкруглить до трёх знаков после запятой.";
            labelCondition_PMA.Click += label1_Click;
            // 
            // pictureBoxFormula_PMA
            // 
            pictureBoxFormula_PMA.Image = (Image)resources.GetObject("pictureBoxFormula_PMA.Image");
            pictureBoxFormula_PMA.Location = new Point(608, 32);
            pictureBoxFormula_PMA.Name = "pictureBoxFormula_PMA";
            pictureBoxFormula_PMA.Size = new Size(108, 61);
            pictureBoxFormula_PMA.TabIndex = 0;
            pictureBoxFormula_PMA.TabStop = false;
            pictureBoxFormula_PMA.Click += pictureBox1_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxCondition_PMA);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxOutput_PMA);
            Controls.Add(groupBoxInput_PMA);
            Controls.Add(buttonDone_PMA);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 9 | Писарев М. А. ";
            groupBoxInput_PMA.ResumeLayout(false);
            groupBoxInput_PMA.PerformLayout();
            groupBoxOutput_PMA.ResumeLayout(false);
            groupBoxOutput_PMA.PerformLayout();
            groupBoxCondition_PMA.ResumeLayout(false);
            groupBoxCondition_PMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_PMA).EndInit();
            ResumeLayout(false);
        }

        private void textBoxVariable_PMA_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBoxOutput_PMA_Enter(object sender, EventArgs e)
        {
        }

        private void groupBoxInput_PMA_Enter(object sender, EventArgs e)
        {
        }

        private void button_PMA_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                double result = ds.Calculate(Convert.ToInt32(textBoxVariable_PMA.Text));
                textBoxResult_PMA.Text = Math.Round(result, 3).ToString("F3");
            }
            catch
            {
                MessageBox.Show("Ошибка при вычислении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        #endregion
        private Button buttonDone_PMA;
        private TextBox textBoxVariable_PMA;
        private GroupBox groupBoxInput_PMA;
        private Label labelVariable_PMA;
        private GroupBox groupBoxOutput_PMA;
        private TextBox textBoxResult_PMA;
        private Label labelResult_PMA;
        private Button buttonHelp;
        private GroupBox groupBoxCondition_PMA;
        private PictureBox pictureBoxFormula_PMA;
        private Label labelCondition_PMA;
    }
}