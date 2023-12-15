using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KolchakovDR.Sprint6.TaskReview.V6.Lib;

namespace Tyuiu.KolchakovDR.Sprint6.Review
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        Random rand = new Random();

        static int[,] arrayValues;

        private void buttonAddMat_KDR_Click(object sender, EventArgs e)
        {

            if (textBoxOt_KDR.Text == "" || textBoxDo_KDR.Text == "" || textBoxRow_KDR.Text == "" || textBoxColu_KDR.Text == "" || textBoxRow_KDR.Text == "0" || textBoxColu_KDR.Text == "0")
            {
                MessageBox.Show("Неверные параметры!");
            }
            else
            {
                int row = Convert.ToInt32(textBoxRow_KDR.Text);
                int column = Convert.ToInt32(textBoxColu_KDR.Text);
                int n1 = Convert.ToInt32(textBoxOt_KDR.Text);
                int n2 = Convert.ToInt32(textBoxDo_KDR.Text);
                if (n1 > n2 || n1 == n2)
                {
                    MessageBox.Show("Неверный диапозон!");
                }
                else
                {
                    arrayValues = ds.GetRandom(n1, n2, row, column);
                    
                    dataGridViewOut_KDR.RowCount = row;
                    dataGridViewOut_KDR.ColumnCount = column;

                    for (int i = 0; i < column; i++)
                    {
                        dataGridViewOut_KDR.Columns[i].Width = 50;
                    }

                    for (int r = 0; r < row; r++)
                    {
                        for (int c = 0; c < column; c++)
                        {
                            dataGridViewOut_KDR.Rows[r].Cells[c].Value = arrayValues[r, c];
                        }
                    }

                    buttonLoadFile_KDR.Enabled = true;
                    textBoxK_KDR.Enabled = true;
                    textBoxL_KDR.Enabled = true;
                    textBoxC_KDR.Enabled = true;
                }
            }
        }

        private void buttonLoadFile_KDR_Click(object sender, EventArgs e)
        {
            if (textBoxK_KDR.Text == "" || textBoxL_KDR.Text == "" || textBoxC_KDR.Text == "")
            {
                MessageBox.Show("Заполните значения!");
            }
            else
            {

                int k = Convert.ToInt32(textBoxK_KDR.Text);
                int l = Convert.ToInt32(textBoxL_KDR.Text);
                int c = Convert.ToInt32(textBoxC_KDR.Text);

                if (k < 0 || l < 0 || c < 0 || k > l )
                {
                    MessageBox.Show("Неверные параметры!");
                }
                else
                {
                    int res = 1;
                    res = ds.GetMatrix(arrayValues, c, k, l);

                    textBoxRes_KDR.Text = Convert.ToString(res);
                }

            }
        }
    }
    
}
