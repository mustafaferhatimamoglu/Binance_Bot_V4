﻿using Common_CA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binance_Bot_V4.Strategies
{
    internal class EMA
    {

        public static double CalculateEMA(double[] data, int period)
        {
            double multiplier = 2.0 / (period + 1);
            double ema = CalculateSMA(data, period); // Calculate the initial SMA

            for (int i = period; i < data.Length; i++)
            {
                ema = (data[i] - ema) * multiplier + ema; // Calculate the EMA for each subsequent period
            }

            return ema;
        }
        private static double CalcEma(StockData[] data, int period)
        {
            double[] data_Low = new double[data.Count()];
            double[] data_High = new double[data.Count()]; 
            for (int i = 0; i < data.Count(); i++)
            {
                data_Low[i] = data[i].Low_price;
                data_High[i] = data[i].High_price;
            }
            return 0;
        }
        private static double CalculateSMA(double[] data, int period)
        {
            double sum = 0.0;
            for (int i = 0; i < period; i++)
            {
                sum += data[i];
            }

            return sum / period;
        }
    }
}
