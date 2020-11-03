using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo
{
    public partial class FrmKezdo : Form
    {
        private List<string> todos = new List<string>();
        public FrmKezdo()
        {
            InitializeComponent();
            StreamReader be = new StreamReader("todoitems.txt");

            while (!be.EndOfStream)
            {
                todos.Add(be.ReadLine());
            }

            be.Close();
        }

        private void mKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmKezdo_Shown(object sender, EventArgs e)
        {
            textBox1.Text = "";
            listBox1.Items.Clear();
            textBox1.Focus();
            
        }

        private void btnListabol_Click(object sender, EventArgs e)
        {
            frmLista formLista = new frmLista(todos);
            var result = formLista.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBox1.Text = formLista.SelectedTodo;
            }

            textBox1.Focus();
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void btnFelvitel_Click(object sender, EventArgs e)
        {
            string todo = textBox1.Text.Trim();
            if (todo != "" && !listBox1.Items.Contains(todo))
            {
                listBox1.Items.Add(todo);
                textBox1.Text = "";
            }
        }

        private void btnEltavolit_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKivesz_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            if (index > -1)
            {
                listBox1.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Válassz ki egy elemet!", "Nincs kiválasztva",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mbeolvas_Click(object sender, EventArgs e)
        {
            if (ofdMegnyitas.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                StreamReader be = new StreamReader(ofdMegnyitas.FileName);
                while (!be.EndOfStream)
                {
                    listBox1.Items.Add(be.ReadLine());
                }
                be.Close();
                MessageBox.Show("Sikeres beolvasás!", "Beolvasás",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mMentes_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                sfdMentes.FileName = FileNameDate();
                if (sfdMentes.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter ki = new StreamWriter(sfdMentes.FileName);
                    foreach (var item in listBox1.Items)
                    {
                        ki.WriteLine(item);
                    }
                    ki.Close();
                    MessageBox.Show("Sikeres mentés!", "Mentés",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
            }
            else
            {
                MessageBox.Show("Nincs mit menteni!", "Üres lista",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private string FileNameDate()
        {
            var datum = DateTime.Now;
            string ev = datum.Year.ToString();
            string honap = "";
            

            if (datum.Month < 10)
            {
                honap = "0" + datum.Month.ToString();
            }
            else
            {
                honap = datum.Month.ToString();
            }
            string nap = "";

            if (datum.Day < 10)
            {
                nap = "0" + datum.Day.ToString();
            }
            else
            {
                nap = datum.Day.ToString();
            }
            return ev + honap + nap;
        }
    }
}
