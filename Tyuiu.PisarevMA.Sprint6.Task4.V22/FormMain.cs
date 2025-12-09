using Tyuiu.PisarevMA.Sprint6.Task4.V22.Lib;
namespace Tyuiu.PisarevMA.Sprint6.Task4.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void labelCondition_PMA_Click(object sender, EventArgs e)
        {

        }

        private void textBoxResult_PMA_TextChanged(object sender, EventArgs e)
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

                this.chartFunc_PMA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunc_PMA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_PMA.Text = "";

                chartFunc_PMA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunc_PMA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_PMA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_PMA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult_PMA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + "Сохранён успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_PMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 Выполнил студент группы АСОиУб-25-1 Писарев М. А.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}