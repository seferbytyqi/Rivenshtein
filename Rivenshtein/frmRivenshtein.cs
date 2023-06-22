using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rivenshtein
{
    public partial class frmRivenshtein : Form
    {
        public static String Kutia1, Kutia2;
        public static double[,] Tabela_Distances;
        public frmRivenshtein()
        {
            InitializeComponent();
        }

        private void frmRivenshtein_Load(object sender, EventArgs e)
        {
            dgvTabelaLevenshtainit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        //Funksionet kryesore
        private void KalkulimiDistancesMinimale()
        {
            //Ne kete funksion krijohet tabela e distances [Levenshtaini]
            Kutia1 = txtKutia1.Text;
            Kutia2 = txtKutia2.Text;

            Tabela_Distances = new double[Kutia1.Length + 1, Kutia2.Length + 1];
            for (int i = 0; i <= Kutia1.Length; i++)
                Tabela_Distances[i, 0] = i * 1;

            for (int j = 0; j <= Kutia2.Length; j++)
                Tabela_Distances[0, j] = j * 1;

            for (int i = 1; i <= Kutia1.Length; i++)
            {
                for (int j = 1; j <= Kutia2.Length; j++)
                {
                    if (Kutia1[i - 1] == Kutia2[j - 1])//nese shkronjat qe krahasohen jane te njeita
                        Tabela_Distances[i, j] = Tabela_Distances[i - 1, j - 1];
                    else //nese shkronjat nuk jane te njeita
                    {
                        Tabela_Distances[i, j] = Math.Min(Math.Min(Tabela_Distances[i - 1, j - 1] + int.Parse(txtSubstitution.Text), Tabela_Distances[i - 1, j] + int.Parse(txtInsertion.Text)), Tabela_Distances[i, j - 1] + int.Parse(txtDeletion.Text));
                    }
                }
            }
            //Krijimi i Tabeles
            ShfaqjaTabeles();


            //kthimi i Kolones zero ne int per arsye te kthimit te gridit ne vertikalisht
            this.dgvTabelaLevenshtainit.Columns[0].ValueType = typeof(Int32);
        }
        public void ShfaqjaTabeles()
        {
            //Krijimi i Kolonave dhe rreshtave ne datagridview
            this.dgvTabelaLevenshtainit.Columns.Add(" ", " ");
            this.dgvTabelaLevenshtainit.Rows.Add(" ", " ");
            this.dgvTabelaLevenshtainit.Columns.Add(" ", " ");

            //Mbushja e tabeles me te dhena pa gjurme dhe ngjyra
            for (int j = 1; j <= Kutia2.Length; j++)
                this.dgvTabelaLevenshtainit.Columns.Add(j.ToString(), Kutia2[j - 1].ToString());

            for (int i = 1; i <= Kutia1.Length; i++)
                this.dgvTabelaLevenshtainit.Rows.Add(Kutia1[i - 1].ToString());

            for (int i = 1; i <= Kutia1.Length + 1; i++)
            {
                for (int j = 1; j <= Kutia2.Length + 1; j++)
                {
                    this.dgvTabelaLevenshtainit.Rows[i - 1].Cells[j].Value = Tabela_Distances[i - 1, j - 1].ToString();
                }
            }
        }

        private void KalkulimiGjurmeve()
        {
            //Krijimi i gjurmeve ne grid si dhe krahasimi i stringjeve ne zgjatje
            String stringu_distances = "";
            String rezultati_distances;
            int i = Kutia1.Length, j = Kutia2.Length;
            while (true)
            {
                //Ngjyrosja e qelizes fillestare
                this.dgvTabelaLevenshtainit.Rows[i].Cells[j + 1].Style.BackColor = Color.LightBlue;
                if (i == 0 && j == 0)
                {
                    //Ngjyrosja e Qelizes zero
                    this.dgvTabelaLevenshtainit.Rows[i].Cells[j].Style.BackColor = Color.LightBlue;

                    //Vendosja e stringut te distances ne textbox
                    txtStringuDistances.Text = stringu_distances;
                    char[] a = stringu_distances.ToCharArray();
                    Array.Reverse(a);
                    rezultati_distances = new string(a);
                    txtStringuDistances.Text = rezultati_distances;
                    break;
                }
                else if (i == 0 && j > 0)
                {
                    //Ngjyrosja e karakterit te pare nese eshte delete
                    this.dgvTabelaLevenshtainit.Rows[i].Cells[j + 1].Style.BackColor = Color.LightBlue;
                    txtDistanca1.Text = "-" + txtDistanca1.Text;
                    txtDistanca2.Text = dgvTabelaLevenshtainit.Columns[j + 1].HeaderText + txtDistanca2.Text;
                    txtVija.Text = "|" + txtVija.Text;
                    stringu_distances += "D";//delete
                    j--;
                }
                else if (i > 0 && j == 0)
                {
                    this.dgvTabelaLevenshtainit.Rows[i].Cells[j + 1].Style.BackColor = Color.LightBlue;
                    txtDistanca1.Text = this.dgvTabelaLevenshtainit.Rows[i].Cells[0].Value.ToString() + txtDistanca1.Text;
                    txtDistanca2.Text = "-" + txtDistanca2.Text;
                    txtVija.Text = "|" + txtVija.Text;
                    stringu_distances += "I";//insert
                    i--;
                }
                else
                {
                    if (Tabela_Distances[i - 1, j - 1] <= Tabela_Distances[i - 1, j] && Tabela_Distances[i - 1, j - 1] <= Tabela_Distances[i, j - 1])
                    {
                        //Kalkulimi i machit behet nese karakteret jane te njeita
                        this.dgvTabelaLevenshtainit.Rows[i].Cells[j + 1].Style.BackColor = Color.LightBlue;
                        if (Tabela_Distances[i - 1, j - 1] == Tabela_Distances[i, j])
                            stringu_distances += "M"; //match - karakteret jane te njeita
                        else
                            //Kalkulimi i substitution behet kur karakteri i stringut te pare nuk eshte i njeit me karakterin e stringut te dyte
                            stringu_distances += "S"; //substitue - behet zavendesimi i karatereve 
                            txtDistanca1.Text = this.dgvTabelaLevenshtainit.Rows[i].Cells[0].Value.ToString() + txtDistanca1.Text;
                            txtDistanca2.Text = dgvTabelaLevenshtainit.Columns[j + 1].HeaderText + txtDistanca2.Text;
                            txtVija.Text = "|" + txtVija.Text;
                        i--;
                        j--;
                    }

                    else if (Tabela_Distances[i - 1, j] < Tabela_Distances[i, j - 1])
                    {
                        this.dgvTabelaLevenshtainit.Rows[i].Cells[j + 1].Style.BackColor = Color.LightBlue;
                        txtDistanca1.Text = this.dgvTabelaLevenshtainit.Rows[i].Cells[0].Value.ToString() + txtDistanca1.Text;
                        txtDistanca2.Text = "-" + txtDistanca2.Text;
                        txtVija.Text = "|" + txtVija.Text;
                        stringu_distances += "I"; //insert
                        i--;
                    }
                    else if (Tabela_Distances[i, j - 1] < Tabela_Distances[i - 1, j])
                    {
                        this.dgvTabelaLevenshtainit.Rows[i].Cells[j + 1].Style.BackColor = Color.LightBlue;
                        txtDistanca1.Text = "-" + txtDistanca1.Text;
                        txtDistanca2.Text = dgvTabelaLevenshtainit.Columns[j + 1].HeaderText + txtDistanca2.Text;
                        txtVija.Text = "|" + txtVija.Text;
                        stringu_distances += "D"; //delete
                        j--;
                    }

                }
            }
        }



        private void PastrimiKutiave()
        {
            this.dgvTabelaLevenshtainit.Rows.Clear(); // Pastrimi i rreshtave ne datagridview
            this.dgvTabelaLevenshtainit.Columns.Clear();
            txtDistanca1.Clear();
            txtDistanca2.Clear();
            txtStringuDistances.Clear();
            txtVija.Clear();


            //Zhdukja e kutiave ne fund te formes
            txtDistanca1.Visible = false;
            txtDistanca2.Visible = false;
            txtStringuDistances.Visible = false;
            txtVija.Visible = false; ;
        }

        private void btnShfaqTabelen_Click(object sender, EventArgs e)
        {
            PastrimiKutiave();
            KalkulimiDistancesMinimale();
            dgvTabelaLevenshtainit.Sort(dgvTabelaLevenshtainit.Columns[1], ListSortDirection.Descending);
        }

        private void dgvTabelaLevenshtainit_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == 1)
            {
                e.SortResult = int.Parse(e.CellValue1.ToString()).CompareTo(int.Parse(e.CellValue2.ToString()));
                e.Handled = true;//pass by the default sorting
            }
        }

        private void btnShfaqRadhitjen_Click(object sender, EventArgs e)
        {
            //Shfaqja e kutiave ne fund te formes
            txtDistanca1.Visible = true;
            txtDistanca2.Visible = true;
            txtStringuDistances.Visible = true;
            txtVija.Visible = true; ;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PastrimiKutiave();
            txtDeletion.Text = "1";
            txtInsertion.Text = "1";
            txtSubstitution.Text = "2";
            txtKutia1.Text = "Intention";
            txtKutia2.Text = "Execution";
            txtKutia1.Focus();
        }

        private void btnShfaqGjurmet_Click(object sender, EventArgs e)
        {
            dgvTabelaLevenshtainit.Sort(dgvTabelaLevenshtainit.Columns[1], ListSortDirection.Ascending);
            PastrimiKutiave();
            KalkulimiDistancesMinimale();
            KalkulimiGjurmeve();
            dgvTabelaLevenshtainit.Sort(dgvTabelaLevenshtainit.Columns[1], ListSortDirection.Descending);
        }
    }
}
