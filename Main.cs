using System;
using System.Linq;
using System.Windows.Forms;

namespace GpaCalculator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private static string[] scoreArray = { "AA", "BA", "BB", "CB", "CC", "DC" };
        public static string searchWord;

        public double getScore(string score)
        {
            score = score.ToUpper();
            switch (score)
            {
                case "AA":
                    return 4.0;

                case "BA":
                    return 3.5;

                case "BB":
                    return 3.0;

                case "CB":
                    return 2.5;

                case "CC":
                    return 2.0;

                case "DC":
                    return 1.5;

                case "DD":
                    return 1.0;

                case "FD":
                    return 0.5;

                case "FF":
                    return 0.0;

                default:
                    return -1.0;
            }
        }

        private void btnLessenList_Click(object sender, EventArgs e)
        {
            LessonTable.Rows.Clear();
            if (checkBox1.Checked == false) scoredLessons();
            else allLessons();
        }

        private void scoredLessons()
        {
            double scoreTotal = 0, creditTotal = 0;
            LessonBox.Text = LessonBox.Text.Replace(".", ",");
            for (int i = 0; i < LessonBox.Lines.Count(); i++)
            {
                if (scoreArray.Contains(LessonBox.Lines[i]))
                {
                    scoreTotal += Convert.ToDouble(LessonBox.Lines[i - 1]) * getScore(LessonBox.Lines[i]);
                    creditTotal += Convert.ToDouble(LessonBox.Lines[i - 1]);

                    LessonTable.Rows.Add(i - 5 > 0 ? LessonBox.Lines[i - 5] : "", i - 4 > 0 ? LessonBox.Lines[i - 4] : "", i - 3 > 0 ? LessonBox.Lines[i - 3] : "", i - 1 > 0 ? LessonBox.Lines[i - 1] : "", LessonBox.Lines[i], LessonBox.Lines[i + 1]);
                }
            }
            var totalScoreStr = "Toplam Puan : " + String.Format("{0:0.00}", (scoreTotal));
            var lblAvgStr = "Ortalama :" + String.Format("{0:0.00}", (scoreTotal / creditTotal));
            totalScore.Text = totalScoreStr;
            totalCredit.Text = "Toplam Kredi : " + creditTotal.ToString();
            lblAvg.Text = lblAvgStr;
        }

        private void allLessons()
        {
            LessonBox.Text = LessonBox.Text.Replace(".", ",");
            for (int i = 0; i < LessonBox.Lines.Count() - 1; i++)
            {
                if (scoreArray.Contains(LessonBox.Lines[i]) || (LessonBox.Lines[i] == "-" && LessonBox.Lines[i + 1] == "-"))
                {
                    LessonTable.Rows.Add(i - 5 > 0 ? LessonBox.Lines[i - 5] : "", i - 4 > 0 ? LessonBox.Lines[i - 4] : "", i - 3 > 0 ? LessonBox.Lines[i - 3] : "", i - 1 > 0 ? LessonBox.Lines[i - 1] : "", LessonBox.Lines[i], LessonBox.Lines[i + 1]);
                }
            }
            calcDt();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F))
            {
                SearchForm sf = new SearchForm();
                var selecetedrow = -1;
                try
                {
                    selecetedrow = LessonTable.SelectedRows[0].Index;
                }
                catch
                {
                    selecetedrow = -1;
                }
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < LessonTable.Rows.Count - 1; i++)
                    {
                        if (LessonTable.Rows[i].Cells[1].Value.ToString().ToUpper().Contains(searchWord.ToUpper()) && i != selecetedrow)
                        {
                            LessonTable.Rows[i].Selected = true;
                            LessonTable.FirstDisplayedScrollingRowIndex = LessonTable.SelectedRows[0].Index;
                        }
                    }
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnDtCalc_Click(object sender, EventArgs e)
        {
            calcDt();
        }

        private void calcDt()
        {
            double scoreTotal = 0, creditTotal = 0;
            for (int i = 0; i < LessonTable.Rows.Count - 1; i++)
            {
                var akts = Convert.ToDouble(LessonTable.Rows[i].Cells[3].Value.ToString());
                var score = getScore(LessonTable.Rows[i].Cells[4].Value.ToString());
                if (score != -1.0)
                {
                    scoreTotal += akts * score;
                    creditTotal += akts;
                }
            }
            var totalScoreStr = "Toplam Puan : " + String.Format("{0:0.00}", (scoreTotal));
            var lblAvgStr = "Ortalama :" + String.Format("{0:0.00}", (scoreTotal / creditTotal));
            totalScore.Text = totalScoreStr;
            totalCredit.Text = "Toplam Kredi : " + creditTotal.ToString();
            lblAvg.Text = lblAvgStr;
        }

        private void LessonTable_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            LessonTable.BeginEdit(false);

            if (LessonTable.EditingControl is TextBoxBase)

            {
                TextBoxBase textBox = (TextBoxBase)LessonTable.EditingControl;
                textBox.SelectionStart = textBox.GetCharIndexFromPosition(LessonTable.EditingControl.PointToClient(Cursor.Position));
            }
        }
    }
}