using jarloo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ScientificProgrammingHW1
{
    public partial class PredictStock : Form
    {
        double Slope, intercept;
        List<Price> StockPrices;
        public PredictStock()
        {
            InitializeComponent();
            btnGetRecords.Enabled = false;
            FromDtStatus.Visible = false;
            toDtStat.Visible = false;
            PredictionDtStatus.Visible = false;
            PredictionChart.Series["BestFit"].Points.Add();
            PredictionChart.Series["BestFit"].Points[0].IsEmpty = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.Size = new Size(482, 509);
            btnGetRecords.Enabled = false;
            FromDtStatus.Visible = false;
            toDtStat.Visible = false;
            PredictionDtStatus.Visible = false;
            if (FromDt.Value.Date >= DateTime.Now)
            {
                FromDtStatus.Text = "From Date can only be set to a date before today";
                FromDtStatus.Visible = true;
                btnGetRecords.Enabled = false;
            }
            if (ToDt.Value.Date <= FromDt.Value.Date)
            {
                toDtStat.Text = "to date can only be set to a date after from date";
                toDtStat.Visible = true;
                btnGetRecords.Enabled = false;
            }
            if (PredictionDate.Value.Date < DateTime.Now) {
                PredictionDtStatus.Text = "Prediction date can only be in the future";
                PredictionDtStatus.Visible = true;
                btnGetRecords.Enabled = false;
            }
            if(FromDt.Value.Date < DateTime.Now && ToDt.Value.Date > FromDt.Value.Date && PredictionDate.Value.Date > DateTime.Now)
            {
                toDtStat.Visible = false;
                FromDtStatus.Visible = false;
                PredictionDtStatus.Visible = false;
                btnGetRecords.Enabled = true;
            }
            
        }

        private void btnGetRecords_Click(object sender, EventArgs e)
        {
            //initializers
            RL.Text = "";
            foreach (var series in PredictionChart.Series)
            {
                series.Points.Clear();
            }
            string csvData;
            HistoryRecords.Items.Clear();
            WebClient web = new WebClient();
            PredictionChart.Series["BestFit"].Points.Clear();
            this.Size = new Size(1266, 646);
            try
            {
                //binging Data from yahoo finance
                csvData = web.DownloadString("http://ichart.finance.yahoo.com/table.csv?s=" + CompanyName.Text + "&a=" + (FromDt.Value.Month - 1).ToString() + "&b=" + (FromDt.Value.Day).ToString() + "&c=" + (FromDt.Value.Year).ToString() + "&d=" + (ToDt.Value.Month - 1).ToString() + "&e=" + (ToDt.Value.Day).ToString() + "&f=" + (ToDt.Value.Year).ToString() + "&g=d&ignore=.csv");
                StockPrices = YahooFinance.Parse(csvData);
                foreach (Price price in StockPrices)
                {
                    ListViewItem l1 = new ListViewItem(price.date.Date.ToShortDateString());
                    l1.SubItems.Add(price.close);
                    HistoryRecords.Items.Add(l1);
                }

                //Creating a regression line based on mathematical equations - linear regression line
                GetRegressionLine(StockPrices);

                StockPrices.Reverse();

                //entering/adding the data into the charts
                for (int i  = 0; i < StockPrices.Count; i++){
                    PredictionChart.Series["points"].XValueType = ChartValueType.DateTime;
                    PredictionChart.Series["points"].Points.AddXY(StockPrices[i].date.ToShortDateString(), StockPrices[i].close);
                    PredictionChart.Series["BestFit"].XValueType = ChartValueType.DateTime;
                    PredictionChart.Series["BestFit"].Points.AddXY(StockPrices[i].date.ToShortDateString(), Slope*i + intercept );
                }
                RL.Text = "Best-Fit Regression Line: Y = " + Slope.ToString() + " * X + " + intercept.ToString();
                Pr.Text = "Stock prediction for the date " + PredictionDate.Value.Date.ToString() +" is " + PredictionRL(PredictionDate.Value.Date).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Company's name is not found");
            }

        }
        public void GetRegressionLine(List<Price> StockPrices)
        {
            
            if (StockPrices.Count == 1)
            {
                intercept = 0;
                 Slope = double.Parse(StockPrices[0].close.ToString());
                return;
            }
            double Xsum = 0 , Ysum = 0 , XYsum = 0 , X2sum = 0;
            double XsumAVG , YsumAVG;
            double count = StockPrices.Count;
            // calculating the Average sum of axis X (Days) and Y (closing Prices)
            foreach (Price price in StockPrices){
                Xsum += count;
                Ysum += double.Parse(price.close.ToString());
                count--;
            }
            XsumAVG = Xsum / StockPrices.Count;
            YsumAVG = Ysum / StockPrices.Count;
            count = StockPrices.Count;
            // calculating the Slope and the interception based on the AVG sum of both axises
            foreach (Price price in StockPrices){
                XYsum += (double.Parse(price.close.ToString()) - YsumAVG) * (count - XsumAVG);
                X2sum += (count - XsumAVG)*(count - XsumAVG);
                count--;
            }
            //got the Slope and the interception->we have the equation : Y = Slope*x+interecption
             Slope = XYsum / X2sum;
             intercept = YsumAVG - Slope * XsumAVG;
        }

        private void CompanyName_TextChanged(object sender, EventArgs e)
        {
            this.Size = new Size(482, 509);
            btnGetRecords.Enabled = false;
            this.Size = new Size(482, 509);
            btnGetRecords.Enabled = false;
            FromDtStatus.Visible = false;
            toDtStat.Visible = false;
            PredictionDtStatus.Visible = false;
            if (FromDt.Value.Date >= DateTime.Now)
            {
                FromDtStatus.Text = "From Date can only be set to \na date before today";
                FromDtStatus.Visible = true;
                btnGetRecords.Enabled = false;
            }
            if (ToDt.Value.Date <= FromDt.Value.Date)
            {
                toDtStat.Text = "To date can only be set to a\n date after from date";
                toDtStat.Visible = true;
                btnGetRecords.Enabled = false;
            }
            if (PredictionDate.Value.Date < DateTime.Now)
            {
                PredictionDtStatus.Text = "Prediction date can only be\n in the future";
                PredictionDtStatus.Visible = true;
                btnGetRecords.Enabled = false;
            }
            if (FromDt.Value.Date < DateTime.Now && ToDt.Value.Date > FromDt.Value.Date && PredictionDate.Value.Date > DateTime.Now)
            {
                toDtStat.Visible = false;
                FromDtStatus.Visible = false;
                PredictionDtStatus.Visible = false;
                btnGetRecords.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //A function that calculates the predicted price for stock in a future date
        public double PredictionRL(DateTime date) {
            TimeSpan newD = date.Date - ToDt.Value.Date;
            double period = double.Parse(newD.Days.ToString());
            return Slope * period + intercept;
        }
    }
}
