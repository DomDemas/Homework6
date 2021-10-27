﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_2
{
    class Wines
    {
        public double id { get; set; }
        public double points { get; set; }
        public double? price { get; set; }
        public string country { get; set; }
        public string description { get; set; }
        public string designation { get; set; }
        public string province { get; set; }
        public string region_1 { get; set; }
        public string region_2 { get; set; }
        public string taster_name { get; set; }
        public string taster_twitter_handle { get; set; }
        public string title { get; set; }
        public string variety { get; set; }
        public string winery { get; set; }

        public Wines()
        {
            id = 0;
            points = 0;
            price = 0;
            country = string.Empty;
            description = string.Empty;
            designation = string.Empty;
            province = string.Empty;
            region_1 = string.Empty;
            region_2 = string.Empty;
            taster_name = string.Empty;
            taster_twitter_handle = string.Empty;
            title = string.Empty;
            variety = string.Empty;
            winery = string.Empty;
        }

        public override string ToString()
        {
            return title;
        }
    }
}
