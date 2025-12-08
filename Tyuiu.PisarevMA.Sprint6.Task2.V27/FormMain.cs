using Tyuiu.PisarevMA.Sprint6.Task2.V27.Lib;
namespace Tyuiu.PisarevMA.Sprint6.Task2.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 Выполнил студент группы АСОиУб-25-1 Писарев М. А.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void labelCondition_PMA_Click(object sender, EventArgs e)
        {

        }
        DataService ds = new DataService();
        private void buttonDone_PMA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_PMA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_PMA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartVisFunc_PMA.Titles.Add("График функции");

                this.chartVisFunc_PMA.ChartAreas[0].AxisX.Title = ("Ось X");
                this.chartVisFunc_PMA.ChartAreas[0].AxisY.Title = ("Ось Y");
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewTable_PMA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartVisFunc_PMA.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_PMA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_PMA.BackColor = Color.Red;
        }

        private void buttonDone_PMA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_PMA.BackColor = Color.Green;
        }

        private void buttonDone_PMA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_PMA.BackColor = Color.Blue;
        }
    }
}