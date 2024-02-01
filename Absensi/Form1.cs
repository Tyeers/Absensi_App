using System.Data;

namespace Absensi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int InputNIS = int.Parse(inputNIS.Text);
            string InputNama = inputNama.Text;
            var inputTanggal = dateTimePicker1.Value;
            string InputMapel = inputMapel.Text;

            if (IsNISAlreadyExists(inputNIS.Text))
            {
                MessageBox.Show("NIS sudah dimasukkan!");
            }

            else if (checkHadir.Checked)
            {
                dataGridView1.Rows.Add(InputNIS, InputNama, inputTanggal, InputMapel, "Hadir");

            }
            else if (checkTidakHadir.Checked)
            {
                dataGridView1.Rows.Add(InputNIS, InputNama, inputTanggal, InputMapel, "Tidak Hadir");
            }

            bool IsNISAlreadyExists(string nis)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["NIS"].Value != null && row.Cells["NIS"].Value.ToString() == nis)
                    {
                        return true;
                    }
                }

                return false;
            }
        }
    }
}