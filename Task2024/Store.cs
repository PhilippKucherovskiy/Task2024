﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2024
{
    public class Store
    {
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }


        /// <summary>
        /// Generates a string with product sales statistics
        /// Sorting - descending order of number of products sold
        /// </summary>
        /// <param name="year">The year for which statistics are calculated</param>
        public string GetProductStatistics(int year)
        {
            // String format:
            // {№}) - {Product name} - {number of units sold} item(s)\r\n
            //
            // Example of the resulting string:
            //
            // 1) Product 3 - 1103 item(s)
            // 2) Product 1 - 800 item(s)
            // 3) Product 2 - 10 item(s)

            // TODO Implement the logic for obtaining and generating the required data
        }

        /// <summary>
        /// Generates a line with product sales statistics by year
        /// Sorting - in descending order of years.
        /// All years in which there were sales of products are displayed
        /// </summary>
        public string GetYearsStatistics()
        {
            // Result format:
            // {Year} - {For what amount of products sold usd\r\n
            // Most selling: -{Name of the best-selling product} (number of units sold of the most popular product pcs.)\r\n
            // \r\n
            //
            // Example:
            //
            // 2021 - 630,000 usd.
            // Most selling: Product 1 (380 item(s))
            //
            // 2020 - 630,000 usd.
            // Most selling: Product 1 (380 item(s))
            //
            // 2019 - 130,000 usd.
            // Most selling: Product 3 (10 item(s))
            //
            // 2018 - 50,000 usd.
            // Most selling: Product 3 (5 item(s))

            // TODO Implement the logic for obtaining and generating the required data  
        }
    }
}
