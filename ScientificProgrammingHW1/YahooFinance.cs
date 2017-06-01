using System;
using System.Collections.Generic;

namespace jarloo
{
    public static class YahooFinance
    {
        public static List<Price> Parse(string csvData)
        {
            List<Price> prices = new List<Price>();
            string[] rows = csvData.Replace("\r", "").Split('\n');
            Boolean flag = false;
            foreach (string row in rows)
            {
                if (string.IsNullOrEmpty(row))
                    continue;

                string[] cols = row.Split(',');
                if (flag)
                {
                    Price p = new Price();
                    p.date = DateTime.Parse(cols[0]);
                    p.close = cols[4];
                    prices.Add(p);
                }
                else
                    flag = true;
            }
            return prices;
        }
    }
    public class Price
    {
        public DateTime date { get; set; }
        public string close { get; set; }

    }
}