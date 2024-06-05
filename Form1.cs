namespace IMLab13
{
    public partial class Form1 : Form
    {
        double creditRate, wupiupiRate, k = 0.1;
        DateOnly date = DateOnly.FromDateTime(DateTime.Now);
        int y = 1;
        bool started = false;
        Random _rnd = new Random();
        double drift = 0.1;
        double volatility = 0.1;
        public Form1()
        {
            InitializeComponent();
        }
        double CalculateRV(double mean, double variance)
        {
            double z = Math.Cos(2 * Math.PI * _rnd.NextDouble()) * Math.Sqrt(-2 * Math.Log(_rnd.NextDouble()));
            return mean + z * Math.Sqrt(variance);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(CreditLabel, "Основная валюта Галактики со времен Галактической Республики.");
            toolTip2.SetToolTip(WupiupiLabel, "Хаттская разменная монета, ходившая на территориях Внешнего Кольца Галактики до имперского периода.");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            creditRate = ChangeRate(creditRate);
            wupiupiRate = ChangeRate(wupiupiRate);
            //date = date.AddDays(1);
            y++;
            chart1.Series[0].Points.AddXY(y, creditRate);
            chart1.Series[1].Points.AddXY(y, wupiupiRate);
        }
        private double ChangeRate(double initialValue)
        {
            return initialValue * Math.Exp((drift - 0.5 * volatility * volatility) * 0.1 + volatility * Math.Sqrt(0.1) * CalculateRV(0,1));
        }
        private void Init()
        {
            creditRate = Convert.ToDouble(CreditBox.Text);
            wupiupiRate = Convert.ToDouble(WupiupiBox.Text);
            chart1.Series[0].Points.AddXY(y, creditRate);
            chart1.Series[1].Points.AddXY(y, wupiupiRate);
            started = true;
        }
        private void StartStopButton_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                if (!started)
                    Init();
                timer1.Start();
            }
        }
    }
}
