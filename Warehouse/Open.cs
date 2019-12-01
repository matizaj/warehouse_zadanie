using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Warehouse
{
    public class Open
    {
        public static List<string> OpenFile()
        {
            var root = @"..\..\Data\";
            string path = Path.Combine(root, "test.txt");
            string pattern = "#.*";
            List<string> result = new List<string>();
            if (File.Exists(path))
            {
                using (var stream = new StreamReader(path))
                {
                    var lines = File.ReadAllLines(path);
                    foreach (var line in lines)
                    {
                        var match = Regex.Match(line, pattern);
                        if (!match.Success)
                        {
                            result.Add(line);
                        }
                    }
                }
                 return result;
            }
            else
            {
                Console.WriteLine("File not found");
            }
            return result;
           
        }
    }
}


