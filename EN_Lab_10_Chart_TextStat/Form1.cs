using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EN_Lab_10_Chart_TextStat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //label for axes
            chartCharsFrequency.Titles.Add("Character Frequency");
            chartCharsFrequency.ChartAreas[0].AxisX.Title = "Characters";

            chartWordsLength.Titles.Add("Word Length Frequency");
            chartWordsLength.ChartAreas[0].AxisX.Title = "Word Length";

            chartGroupFrequency.Titles.Add("Character Group Frequency");
            chartGroupFrequency.ChartAreas[0].AxisX.Title = "Character Group";

            foreach (Chart ch in new Chart[] { chartCharsFrequency, chartGroupFrequency, chartWordsLength })
            {
                //for better readability - every character on the x-axis
                ch.ChartAreas[0].AxisX.Interval = 1;

                //labels for axes
                ch.ChartAreas[0].AxisY.Title = "Count";

                ch.Legends[0].Enabled = false;

                //remove grid lines for better readability
                ch.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                ch.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            }

            richTextBox_TextChanged(null, null);
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            claculateCharsFrequency();
            claculateWordsLength();
            claculateTypeOfChars();

        }

        private void claculateTypeOfChars()
        {
            Dictionary<string, int> charTypeCount = new Dictionary<string, int>();
            charTypeCount["Capital letters"] = 0;
            charTypeCount["Small letters"] = 0;
            charTypeCount["Digits"] = 0;
            charTypeCount["Whitespace"] = 0;
            charTypeCount["Other"] = 0;

            foreach (char c in richTextBox.Text)
            {
                if (char.IsUpper(c))
                {
                    charTypeCount["Capital letters"]++;
                }
                else if (char.IsLower(c))
                {
                    charTypeCount["Small letters"]++;
                }
                else if (char.IsDigit(c))
                {
                    charTypeCount["Digits"]++;
                }
                else if (char.IsWhiteSpace(c))
                {
                    charTypeCount["Whitespace"]++;
                }
                else
                {
                    charTypeCount["Other"]++;
                }
            }
            Series series = new Series();

            series.IsValueShownAsLabel = true;

            foreach (string key in charTypeCount.Keys)
            {
                series.Points.AddXY(key, charTypeCount[key]);
            }
            chartGroupFrequency.Series.Clear();
            chartGroupFrequency.Series.Add(series);
            chartGroupFrequency.ChartAreas[0].RecalculateAxesScale();
        }

        private void claculateWordsLength()
        {
            String[] words;

            words = richTextBox.Text.Split(new char[] { ' ', '\n', '\r', '\t' },
                                           StringSplitOptions.RemoveEmptyEntries);

            Dictionary<int, int> wordLengthCount = new Dictionary<int, int>();
            foreach (String word in words)
            {
                int length = word.Length;
                if (wordLengthCount.ContainsKey(length))
                {
                    wordLengthCount[length]++;
                }
                else
                {
                    wordLengthCount[length] = 1;
                }
            }
            Series series = new Series();

            series.IsValueShownAsLabel = true;

            foreach (int key in wordLengthCount.Keys.OrderBy(k => k))
            {
                series.Points.AddXY(key.ToString(), wordLengthCount[key]);
            }
            chartWordsLength.Series.Clear();
            chartWordsLength.Series.Add(series);
            chartWordsLength.ChartAreas[0].RecalculateAxesScale();
        }

        private void claculateCharsFrequency()
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in richTextBox.Text)
            {
                //normalization
                char lowerC = char.ToLower(c);

                //counting
                if (lowerC == ' ' ||
                   lowerC == '\n' ||
                   lowerC == '\r' ||
                   lowerC == '\t')
                {
                    continue;
                }
                else if (charCount.ContainsKey(lowerC))
                {
                    charCount[lowerC]++;
                }
                else
                {
                    charCount[lowerC] = 1;
                }
            }
            Series series = new Series();

            series.IsValueShownAsLabel = true;

            foreach (char key in charCount.Keys.OrderBy(k => k))
            {
                series.Points.AddXY(key.ToString(), charCount[key]);
            }
            chartCharsFrequency.Series.Clear();
            chartCharsFrequency.Series.Add(series);
            chartCharsFrequency.ChartAreas[0].RecalculateAxesScale();
        }
    }
}
