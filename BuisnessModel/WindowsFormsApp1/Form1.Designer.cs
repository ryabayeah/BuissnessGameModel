
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tBoughtCash = new System.Windows.Forms.Label();
            this.tCash = new System.Windows.Forms.Label();
            this.nWantCash = new System.Windows.Forms.NumericUpDown();
            this.bDollar = new System.Windows.Forms.Button();
            this.bEuro = new System.Windows.Forms.Button();
            this.bSell = new System.Windows.Forms.Button();
            this.bBuy = new System.Windows.Forms.Button();
            this.lCash = new System.Windows.Forms.Label();
            this.nRate = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nWantCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.tBoughtCash);
            this.panel1.Controls.Add(this.tCash);
            this.panel1.Controls.Add(this.nWantCash);
            this.panel1.Controls.Add(this.bDollar);
            this.panel1.Controls.Add(this.bEuro);
            this.panel1.Controls.Add(this.bSell);
            this.panel1.Controls.Add(this.bBuy);
            this.panel1.Controls.Add(this.lCash);
            this.panel1.Controls.Add(this.nRate);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(586, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 325);
            this.panel1.TabIndex = 0;
            // 
            // tBoughtCash
            // 
            this.tBoughtCash.AutoSize = true;
            this.tBoughtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoughtCash.Location = new System.Drawing.Point(17, 175);
            this.tBoughtCash.Name = "tBoughtCash";
            this.tBoughtCash.Size = new System.Drawing.Size(16, 18);
            this.tBoughtCash.TabIndex = 14;
            this.tBoughtCash.Text = "0";
            // 
            // tCash
            // 
            this.tCash.AutoSize = true;
            this.tCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tCash.Location = new System.Drawing.Point(17, 146);
            this.tCash.Name = "tCash";
            this.tCash.Size = new System.Drawing.Size(16, 18);
            this.tCash.TabIndex = 13;
            this.tCash.Text = "0";
            // 
            // nWantCash
            // 
            this.nWantCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.nWantCash.Location = new System.Drawing.Point(11, 250);
            this.nWantCash.Name = "nWantCash";
            this.nWantCash.Size = new System.Drawing.Size(125, 22);
            this.nWantCash.TabIndex = 12;
            this.nWantCash.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bDollar
            // 
            this.bDollar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bDollar.Location = new System.Drawing.Point(206, 13);
            this.bDollar.Name = "bDollar";
            this.bDollar.Size = new System.Drawing.Size(98, 36);
            this.bDollar.TabIndex = 10;
            this.bDollar.Text = "Dollar";
            this.bDollar.UseVisualStyleBackColor = false;
            this.bDollar.Click += new System.EventHandler(this.bDollar_Click);
            // 
            // bEuro
            // 
            this.bEuro.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bEuro.Location = new System.Drawing.Point(8, 13);
            this.bEuro.Name = "bEuro";
            this.bEuro.Size = new System.Drawing.Size(103, 36);
            this.bEuro.TabIndex = 9;
            this.bEuro.Text = "Eur";
            this.bEuro.UseVisualStyleBackColor = false;
            this.bEuro.Click += new System.EventHandler(this.bEuro_Click);
            // 
            // bSell
            // 
            this.bSell.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSell.Location = new System.Drawing.Point(71, 278);
            this.bSell.Name = "bSell";
            this.bSell.Size = new System.Drawing.Size(62, 35);
            this.bSell.TabIndex = 8;
            this.bSell.Text = "Sell";
            this.bSell.UseVisualStyleBackColor = false;
            this.bSell.Click += new System.EventHandler(this.bSell_Click);
            // 
            // bBuy
            // 
            this.bBuy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bBuy.Location = new System.Drawing.Point(8, 278);
            this.bBuy.Name = "bBuy";
            this.bBuy.Size = new System.Drawing.Size(57, 35);
            this.bBuy.TabIndex = 7;
            this.bBuy.Text = "Buy";
            this.bBuy.UseVisualStyleBackColor = false;
            this.bBuy.Click += new System.EventHandler(this.bBuy_Click);
            // 
            // lCash
            // 
            this.lCash.AutoSize = true;
            this.lCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCash.Location = new System.Drawing.Point(7, 109);
            this.lCash.Name = "lCash";
            this.lCash.Size = new System.Drawing.Size(98, 24);
            this.lCash.TabIndex = 6;
            this.lCash.Text = "You have";
            // 
            // nRate
            // 
            this.nRate.DecimalPlaces = 2;
            this.nRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nRate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nRate.Location = new System.Drawing.Point(206, 71);
            this.nRate.Name = "nRate";
            this.nRate.Size = new System.Drawing.Size(98, 22);
            this.nRate.TabIndex = 5;
            this.nRate.Value = new decimal(new int[] {
            7433,
            0,
            0,
            131072});
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Location = new System.Drawing.Point(225, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Next day";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current rate";
            // 
            // chart1
            // 
            this.chart1.BorderlineWidth = 3;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.LightBlue;
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.LightBlue;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(6, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.LabelBorderWidth = 3;
            series1.LabelFormat = "F2";
            series1.Name = "Series1";
            series1.SmartLabelStyle.Enabled = false;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(574, 325);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 381);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Currency Game";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nWantCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nRate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button bSell;
        private System.Windows.Forms.Button bBuy;
        private System.Windows.Forms.Label lCash;
        private System.Windows.Forms.Button bDollar;
        private System.Windows.Forms.Button bEuro;
        private System.Windows.Forms.NumericUpDown nWantCash;
        private System.Windows.Forms.Label tBoughtCash;
        private System.Windows.Forms.Label tCash;
    }
}

