using System.ComponentModel;

namespace Binance_Bot_V4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AllCoins();
        }



        public void AllCoins()
        {
            CreateBGWforCoin("BTCUSDT");
            CreateBGWforCoin("LINAUSDT");
        }
        public void CreateBGWforCoin(string coin)
        {
            BackgroundWorker Bgw = new BackgroundWorker();
            Bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(
                BGW_Work);
            Bgw.RunWorkerAsync(coin);
        }


        private void BGW_Work(object? sender, DoWorkEventArgs e)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string coin = (string)e.Argument;
            Common_CA.Binance.Create_Coin(coin);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }

    }
}