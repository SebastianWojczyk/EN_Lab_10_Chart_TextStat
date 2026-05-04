namespace EN_Lab_10_Chart_TextStat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.chartCharsFrequency = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartWordsLength = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartGroupFrequency = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartCharsFrequency)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWordsLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGroupFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(3, 3);
            this.richTextBox.Name = "richTextBox";
            this.tableLayoutPanel1.SetRowSpan(this.richTextBox, 3);
            this.richTextBox.Size = new System.Drawing.Size(394, 444);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "Some text for statistics.";
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox_TextChanged);
            // 
            // chartCharsFrequency
            // 
            chartArea5.Name = "ChartArea1";
            this.chartCharsFrequency.ChartAreas.Add(chartArea5);
            this.chartCharsFrequency.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.chartCharsFrequency.Legends.Add(legend5);
            this.chartCharsFrequency.Location = new System.Drawing.Point(403, 3);
            this.chartCharsFrequency.Name = "chartCharsFrequency";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartCharsFrequency.Series.Add(series5);
            this.chartCharsFrequency.Size = new System.Drawing.Size(394, 142);
            this.chartCharsFrequency.TabIndex = 1;
            this.chartCharsFrequency.Text = "chart1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chartGroupFrequency, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.chartWordsLength, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartCharsFrequency, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // chartWordsLength
            // 
            chartArea4.Name = "ChartArea1";
            this.chartWordsLength.ChartAreas.Add(chartArea4);
            this.chartWordsLength.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chartWordsLength.Legends.Add(legend4);
            this.chartWordsLength.Location = new System.Drawing.Point(403, 151);
            this.chartWordsLength.Name = "chartWordsLength";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartWordsLength.Series.Add(series4);
            this.chartWordsLength.Size = new System.Drawing.Size(394, 142);
            this.chartWordsLength.TabIndex = 2;
            this.chartWordsLength.Text = "chart1";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chartGroupFrequency.ChartAreas.Add(chartArea3);
            this.chartGroupFrequency.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartGroupFrequency.Legends.Add(legend3);
            this.chartGroupFrequency.Location = new System.Drawing.Point(403, 299);
            this.chartGroupFrequency.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartGroupFrequency.Series.Add(series3);
            this.chartGroupFrequency.Size = new System.Drawing.Size(394, 148);
            this.chartGroupFrequency.TabIndex = 3;
            this.chartGroupFrequency.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "TextStats";
            ((System.ComponentModel.ISupportInitialize)(this.chartCharsFrequency)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartWordsLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGroupFrequency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCharsFrequency;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWordsLength;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGroupFrequency;
    }
}

