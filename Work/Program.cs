using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Work
{
    public class Program
    {
        private const string token = "";
        private const string secretKey = "";
        static async Task Main(string[] args)
        {
            BaseRequest request = new BaseRequest(token,secretKey);
            var currencyPair = await request.ProcessGetRequest<CurrencyPair>("https://api.binance.com/api/v3/ticker/24hr?symbol=BNBBTC");
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(currencyPair))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(currencyPair);
                Console.WriteLine("{0}={1}", name, value);
            }
        }
    }
}
