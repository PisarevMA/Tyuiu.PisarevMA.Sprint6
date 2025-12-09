using Tyuiu.PisarevMA.Sprint6.Task5.V21.Lib;
namespace Tyuiu.PisarevMA.Sprint6.Task5.V21
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
        DataService ds = new DataService();
        string path = @"C:\Files\InPutDataFileTask5V21.txt";
        private void buttonDone_PMA_Click(object sender, EventArgs e)
        {
            dataGridViewResult_PMA.ColumnCount = 2;
            dataGridViewResult_PMA.Columns[0].Width = 40;
            dataGridViewResult_PMA.Columns[1].Width = 125;

            this.chartDiag_PMA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_PMA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_PMA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_PMA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_PMA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_PMA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_PMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 Выполнил студент группы АСОиУб-25-1 Писарев М. А.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewResult_PMA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
