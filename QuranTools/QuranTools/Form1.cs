using System.Data;

namespace QuranTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // mp.URL = "F:\\qu\\شاکرنژاد\\sura\\001.mp3";


        }
        int ayeNo = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            double ms = 1000 * mp.Ctlcontrols.currentPosition;
            int ms1 = (int)ms;

            string[] row1 = new string[] { ayeNo++.ToString(), ((ms1)).ToString(), mp.Ctlcontrols.currentPositionString };
            TimeDG.Rows.Add(row1);


            // textBox1.Text = mp.Ctlcontrols.currentPositionString;
            // textBox2.Text = ms1.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mp.Ctlcontrols.currentPosition = Convert.ToDouble(TimeDG.Rows[e.RowIndex].Cells[1].Value) / 1000;
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (int i = 0; i < TimeDG.RowCount-1; i++)
            {
                TimeDG.Rows[i].Cells[0].Value = i + 1;
                ayeNo = i+1;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.X)
            {
                button1_Click(null, null);

            }

        }

        private void SpeedUpBTN_Click(object sender, EventArgs e)
        {

            mp.settings.rate = mp.settings.rate + .1;
            SpeedLB.Text = "Speed: " + (mp.settings.rate.ToString());
            mp.Ctlcontrols.pause();
            //mp.Ctlcontrols.play();
            Application.DoEvents();
        }

        private void SpeedDownBTN_Click(object sender, EventArgs e)
        {
            mp.settings.rate = ((mp.settings.rate) - .1);
            SpeedLB.Text = "Speed: " + mp.settings.rate;
            Application.DoEvents();
            mp.Ctlcontrols.pause();
            //mp.Ctlcontrols.play();
        }
        private void ExpBTN_Click(object sender, EventArgs e)
        {
            string FA = mp.URL;
            FA = FA.Substring(0, FA.Length - 4);
            if (File.Exists(FA + ".txt"))
            {
                MessageBox.Show("File Exist at \n" + FA);
                return;
            }
            StreamWriter myout = new StreamWriter(FA + ".txt", false, System.Text.Encoding.UTF8);
            for (int i = 0; i < TimeDG.RowCount; i++)
            {
                myout.WriteLine(TimeDG.Rows[i].Cells[1].Value);
            }
            myout.Close();
            MessageBox.Show("Exported");
            TimeDG.Rows.Clear();
            ayeNo = 1;
        }

        private void ImpBTN_Click(object sender, EventArgs e)
        {
            TimeDG.Rows.Clear();
            ayeNo = 1;
            OFD.Filter = "(*.txt)|*.txt";
            string line = "";
            ayeNo = 1;
            if (OFD.ShowDialog() != DialogResult.OK)
                return;
            StreamReader MyRead = new StreamReader(OFD.FileName);
            while ((line = MyRead.ReadLine()) != null)
            {
                string[] row1 = new string[] { ayeNo++.ToString(), line, "" };
                TimeDG.Rows.Add(row1);
                ayeNo++;
            }
            MyRead.Close();

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {


        }

        private void OpenMP3BTN_Click(object sender, EventArgs e)
        {
            OFD.Filter = "(*.mp3)|*.mp3";
            if (OFD.ShowDialog() != DialogResult.OK)
                return;
            mp.URL = OFD.FileName;
            TimeDG.Rows.Clear();
            ayeNo = 1;
        }

        private void ClearListBTN_Click(object sender, EventArgs e)
        {
            TimeDG.Rows.Clear();
            ayeNo = 1;
        }
    }
}
