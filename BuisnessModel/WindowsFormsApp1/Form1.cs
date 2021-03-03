using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        Exchanger exchanger = new Exchanger(" $");
        public Form1()
        {   
            InitializeComponent();
            rePaint();
            bDollar.BackColor = Color.Gray;
            bSell.Enabled = false;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            var rate = exchanger.GetRate((double)nRate.Value);
            chart1.Series[0].Points.AddXY(exchanger.days++, rate);
            chart1.ChartAreas[0].AxisX.ScaleView.Size = 30;
            nRate.Value = (decimal)rate;

            if (exchanger.days <= 30) return;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.Axis.ScaleView.Position = exchanger.days - 30;
        }

        private void bBuy_Click(object sender, EventArgs e)
        {
            (tCash.Text ,tBoughtCash.Text) = exchanger.Buy((double)nRate.Value, (double)nWantCash.Value);
            (bBuy.Enabled, bSell.Enabled) = exchanger.CheckCash();

            if (exchanger.cash <= 0 & exchanger.boughtCash <= 0)
            {
                bBuy.Enabled = bSell.Enabled = false;
                lCash.Text = "You loose!";
                return;
            }
        }

        private void bSell_Click(object sender, EventArgs e)
        {
            (tCash.Text, tBoughtCash.Text) = exchanger.Sell((double)nRate.Value, (double)nWantCash.Value);
            (bBuy.Enabled, bSell.Enabled) = exchanger.CheckCash();
        }

        private void bEuro_Click(object sender, EventArgs e)
        {
            exchanger.Restart(" €");
            rePaint();
            bEuro.BackColor = Color.Gray;
            bDollar.BackColor = Color.White;
        }

        private void bDollar_Click(object sender, EventArgs e)
        {
            exchanger.Restart(" $");
            rePaint();
            bDollar.BackColor = Color.Gray;
            bEuro.BackColor = Color.White;
        }

        public void rePaint()
        {
            (tCash.Text, tBoughtCash.Text) = exchanger.GetFormatedCash();
            chart1.Series[0].Points.Clear();
            nRate.Value = (decimal)exchanger.GetRate((double)nRate.Value);
            chart1.Series[0].Points.AddXY(0, (double)nRate.Value);
            bDollar.BackColor = Color.Gray;
            bEuro.BackColor = Color.White;
            chart1.ChartAreas[0].AxisX.ScrollBar.Axis.ScaleView.Position = 0;
            chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = false;
        }
    }

    class Exchanger
    {
        public const double k = 0.1;
        public int days;
        public double rate;
        Random random = new Random();
        public string currency;
        public double cash;
        public double boughtCash;
        public string currencyCash;
        public Exchanger(string Currency)
        {
            currency = Currency;
            cash = 1000;
            boughtCash = 0;
            days = 1;
            currencyCash = " ₽";
        }

        public double GetRate(double currentRate) { return currentRate * (1 + k * (random.NextDouble() - 0.5)); }
        
        public (string,string) GetFormatedCash()
        {
            return (cash + currencyCash, boughtCash + currency);
        }
        public (string, string) Buy(double rate, double quantity)
        {
            cash -= rate * quantity;
            boughtCash += quantity;
            return GetFormatedCash();
        }

        public (string,string) Sell(double rate, double quantity)
        {
            cash += rate * quantity;
            boughtCash -= quantity;
            return GetFormatedCash();
        }

        public (bool, bool) CheckCash()
        {
            bool cPass = true , bPass = true;
            if (cash < 0) { cPass = false; }
            if (boughtCash <= 0) { bPass = false; }

            return (cPass, bPass);
        }
        public void Restart(string Currency)
        {
            currency = Currency;
            cash = 1000;
            days = 1;
            boughtCash = 0;
            currencyCash = " ₽";
        }
    }
}
