﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllColorsImage;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Color.Black.Diff(Color.White));
            var i = new ImageCreator(ImageCreatorConfig.c256_128);
            var startTime = DateTime.UtcNow;
            i.SaveImage(@"C:\Users\Justin\Desktop\newImage.png");
            var endTime = DateTime.UtcNow;
            Console.WriteLine(endTime.Subtract(startTime).TotalSeconds);
            Console.ReadKey();
        }
    }
}
