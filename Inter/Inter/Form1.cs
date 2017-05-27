using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrafOfMatrix;

namespace Inter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = int.Parse(Number.Text);
            CreateCell(count);
            Tabl.Width = count * 30+45;
        }
        private void CreateCell(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Tabl.Columns.Add("col" + (i+1).ToString(), (i+1).ToString());
                Tabl.Columns[i].Width = 30;
            }
            Tabl.RowCount = count+1;
            Tabl.AllowUserToAddRows = false;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    if (i == j)
                    {
                        Tabl[i, j].Value = "M";
                        Tabl[i, j].ReadOnly = true;
                    }
                    if (j >=i)
                    {
                        Tabl[i, j].ReadOnly = true;
                        Tabl[i, j].Style.BackColor = Color.Coral;
                    }
                }
            }
        }

        private void Tabl_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Tabl[e.RowIndex, e.ColumnIndex].Value = Tabl[e.ColumnIndex, e.RowIndex].Value;
        }

        private void ReshBut_Click(object sender, EventArgs e)
        {
            int[,] Mat = new int[Tabl.ColumnCount, Tabl.ColumnCount];
            for (int i = 0;i < Tabl.ColumnCount;i++)
                for(int j = 0;j<Tabl.ColumnCount;j++)
                {
                    if (Tabl[i, j].Value.ToString() == "M")
                        Mat[i, j] = 1000;
                    else
                        Mat[i, j] = int.Parse(Tabl[i, j].Value.ToString());
                }
            Graf myGraf = new Graf(Mat);
            List<int> result = myGraf.GoNer(1, new List<int>());
            foreach (var temp in result)
            {
                label1.Text += temp.ToString();
                label1.Text += " ";
            }
            result = myGraf.Alg2(1, new List<int>());
            foreach (var temp in result)
            {
                label2.Text += temp.ToString();
                label2.Text += " ";
            }
            myGraf.Branch();
            foreach (var temp in myGraf.Prim)
            {
                label3.Text += temp.ToString();
                label3.Text += " ";
            }
        }
    }
}
