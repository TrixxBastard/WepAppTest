﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebApplicationTest.Utils
{
    public class Slugg
    {
           public static string Slugify(string text)
           {
 
             var result = text.ToLower();
             result = Regex.Replace(result, @"\s+", "-");
             result = Regex.Replace(result, @"[^\w\-]+", "");
             result = Regex.Replace(result, @"\-\-+", "-");
             result = Regex.Replace(result, @"^-+/", "");
             result = Regex.Replace(result, @"-+$/", "");
             return result;
           }
}
}
