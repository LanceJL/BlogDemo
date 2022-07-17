using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp
{
    public class StockAppClass
    {
        public string? User { get; set; }
        public int PortfolioValue { get; set; }

        public string JSonValue { get; set; }

        public void SetJSonValue(string JSonVal)
        {
            JSonValue += JSonVal + "\n";
        }
        public void SetPortfolioValue(int value)
        {
            PortfolioValue = value;
        }

        public void PurchaseStock(string amount, string stockCode)
        {
            int latestPrice = GetLatestPrice(stockCode);
            int netSumToAdd = Int32.Parse(amount) * latestPrice;
            PortfolioValue += netSumToAdd;
        }

        private int GetLatestPrice(string stockCode)
        {
            switch (stockCode)
            {
                case "MSFT":
                    return 287;
                case "SBUX":
                    return 93;
                case "AMZN":
                    return 3052;
                case "BA":
                    return 209;
                case "ZAR":
                    return 520;
                case "ABN":
                    return 250;
                case "AUD":
                    return 155;
  //              case "FOR":
  //                  return 275;
                case "TUX":
                    return 75;
                default:
                    return 0;                
            }
        }
    }
}