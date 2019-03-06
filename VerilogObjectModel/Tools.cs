﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerilogObjectModel
{
    public static class Tools
    {
        public static int ParseVerilogNumber(string verilogNumber)
        {
            var indexOfQuote = verilogNumber.IndexOf('\'');
            var format = verilogNumber.Substring(indexOfQuote + 1, 1);
            var valueAsString = verilogNumber.Substring(indexOfQuote + 2);
            var result = 0;

            switch (format)
            {
                case "h":
                    result = int.Parse(valueAsString, NumberStyles.HexNumber);
                    break;
                case "b":
                    result = Convert.ToInt32(valueAsString, 2);
                    break;
            }

            return result;
        }
    }
}
