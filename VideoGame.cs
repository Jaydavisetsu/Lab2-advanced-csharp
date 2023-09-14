using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2___Advanced_C_
{
    public class VideoGame
    {
        public string Name { get; set; }
        public string Platform { get; set; }
        public double Year { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public decimal NA_Sales { get; set; }
        public decimal EU_Sales { get; set; }
        public decimal JP_Sales { get; set; }
        public decimal Other_Sales { get; set; }
        public decimal Global_Sales { get; set; }

        public VideoGame(string name, string platform, double year, string genre, string publisher, decimal nA_Sales, decimal eU_Sales, decimal jP_Sales, decimal other_Sales, decimal global_Sales)
        {
            Name = name;
            Platform = platform;
            Year = year;
            Genre = genre;
            Publisher = publisher;
            NA_Sales = nA_Sales;
            EU_Sales = eU_Sales;
            JP_Sales = jP_Sales;
            Other_Sales = other_Sales;
            Global_Sales = global_Sales;
        }

        public VideoGame()
        {
            // Default constructor
            Name = "";
            Platform = "";
            Year = 0;
            Genre = "";
            Publisher = "";
            NA_Sales = 0.0m;
            EU_Sales = 0.0m;
            JP_Sales = 0.0m;
            Other_Sales = 0.0m;
            Global_Sales = 0.0m;

        }

        public override string ToString()
        {
            return
                $"Name: {Name}, " + "\n" +
                $"Platorm: {Platform}," + "\n" +
                $"Genre: {Genre}," + "\n" +
                $"Publisher: {Publisher}";

        }


    }
}
