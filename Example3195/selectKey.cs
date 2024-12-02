using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example3195
{
    public partial class selectKey : Form
    {
        private Form1 form;
        private int index;
        public selectKey(Form1 form1, int index)
        {
            if (InputLanguage.InstalledInputLanguages.Count > 0)
            {
                foreach (InputLanguage language in InputLanguage.InstalledInputLanguages)
                {
                    if (language.LayoutName == "Русская")
                    {
                        Application.CurrentInputLanguage = language;
                    }
                }
            }

            // В загрузке формы не сработало так как форма загружалась и снова переопределяла язык

            InitializeComponent();
            label1.Text = "";
            this.index = index;
            string alphabet = "йцукен" +
                                "гшщзхъ" +
                                "фывапр" +
                                "олджэя" +
                                "чсмить" +
                                "бюё";

            form = form1;

            for (int i = 0; i < form.dataGridView1.ColumnCount; i++)
            {

                if (form.dataGridView1.Rows[0].Cells[i].Value != null)
                {
                    label1.Text += form.dataGridView1.Rows[0].Cells[i].Value.ToString();
                }
                else
                {
                    if (i == index)
                    {
                        label1.Font = new Font(label1.Font, FontStyle.Bold);
                        label1.ForeColor = Color.Red;
                    }
                    label1.Text += "*";
                    label1.Font = new Font(label1.Font, FontStyle.Regular);
                    label1.ForeColor = Color.Black;
                }

            }


            form.Hide();
            dataGridView1.RowCount = 6;
            dataGridView1.ColumnCount = 6;
            int schetchik = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (schetchik < alphabet.Length)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = alphabet[schetchik];
                        schetchik++;
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            form.selChar = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null ? ' ' : dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToLower()[0];
            form.Show();
            this.Close();
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            form.selChar = e.KeyChar;
            form.Show();
            this.Close();
        }

        private void selectKey_Load(object sender, EventArgs e)
        {
        }
    }
}
