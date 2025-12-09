using Tyuiu.PisarevMA.Sprint6.Task3.V18.Lib;
namespace Tyuiu.PisarevMA.Sprint6.Task3.V18
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

        private void groupBoxCondition_PMA_Enter(object sender, EventArgs e)
        {

        }
        DataService ds = new DataService();
        int[,] mas = new int[5, 5] { { -19, -19, 1, 18, 7 },
                                          { 5, 3, -4, -6, -12 },
                                          { -15, 6, 2, 2, -14 },
                                          { -9, -10, 15, -5, -6 },
                                          { -13, -15, -9, 7, 1 } };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;

            dataGridViewMas_PMA.ColumnCount = columns;
            dataGridViewMas_PMA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMas_PMA.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMas_PMA.Rows[i].Cells[j].Value = Convert.ToString(mas[i, j]);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 Выполнил студент группы АСОиУб-25-1 Писарев М. А.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_PMA_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mas);

            int rows = res.GetUpperBound(0) + 1;
            int columns = res.Length / rows;

            dataGridViewMas_PMA.RowCount = rows;
            dataGridViewMas_PMA.ColumnCount = columns;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMas_PMA.Rows[i].Cells[j].Value = res[i, j];
                }
            }
        }

        private void dataGridViewMas_PMA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxCondition_PMA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
