using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace gyak1
{
    class Program
    {
        const string emailPattern = @"[^@]+\@[^\.]+\..+";

        static IEnumerable<string> TestCases
        {
            get
            {
                yield return "user@test.com";
                yield return "test.com";
                yield return "user@.com";
                yield return "user@1234.com";
                yield return "12elemer@server.be";
                yield return "valaki@mymail.hu";
            }
        }

        static void Main(string[] args)
        {
            var expression = new Regex(emailPattern, RegexOptions.Compiled);

            foreach (var testcase in TestCases)
            {
                bool match = expression.IsMatch(testcase);
                Console.WriteLine("{0} match status: {1}", testcase, match);
            }
            string datum = "2024-02-12";
            string datum2 = "s000024-02-12";
            Regex datumMinta = new Regex(@"\d{4}-\d{2}-\d{2}|\d{2}-\d{2}");
            bool illik=datumMinta.IsMatch(datum);
            Console.WriteLine(illik);
            bool illik2 = datumMinta.IsMatch(datum2);
            Console.WriteLine(illik);

            //Console.ReadKey();
        }
    }
}