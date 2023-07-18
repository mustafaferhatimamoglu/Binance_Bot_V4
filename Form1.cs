using System.ComponentModel;

namespace Binance_Bot_V4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //var task = AllCoins();
            //while (task.Status == AllCoins.Completed) ;
            //var result = Task.Run(async () => await AllCoins()).Result;
            //var b1 = new 
            //var asd = new Common_CA.Database();
            //var asd2 = Common_CA.Database.

            //AllCoins();
            //object value = await Run(() => AllCoins());

            //var result = Task.Run(async () => await AllCoins()).Result;
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
                //Common_CA.Binance.Create_Coin("BTCUSDT"));
                //Common_CA.Binance.Create_Coin(coin));
                BGW_Work);
            //Bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BGW_Completed);
            Bgw.RunWorkerAsync(coin);
            

            //Bgw.RunWorkerCompleted(BGW_Completed);
            //Bgw.RunWorkerCompleted += BGW_Completed();
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

        //private RunWorkerCompletedEventHandler? BGW_Completed()
        //{
        //    //throw new NotImplementedException();
        //    return null;
        //}
        //private void BGW_Completed(object sender, RunWorkerCompletedEventArgs e)
        //{ 
        
        //}
    }
}