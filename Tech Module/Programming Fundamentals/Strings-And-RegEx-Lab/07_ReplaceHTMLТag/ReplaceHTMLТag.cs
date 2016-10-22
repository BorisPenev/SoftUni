namespace _07_ReplaceHTMLТag
{
    using System;
    using System.Text.RegularExpressions;

    public class ReplaceHTMLТag
    {
        static void Main()
        {
            //string text = "<ul> <li> <a href=\"http://softuni.bg\">SoftUni</a> </ li > </ ul >";

            //string pattern = @"<a.*?href.*?=.*?(""\S*"")>(.*)<\/a>";
            //string replace = @"[URL href=$1]$2[/URL]";
            
            //string newText = Regex.Replace(text,pattern, replace);
            
            //Console.WriteLine(newText); // True


            string pattern = @"<a.*?href.*?=.*?(""\S*"")>(.*?)<\/a>";
            string replace = @"[URL href=$1]$2[/URL]";

            string text = Console.ReadLine();

            while (!text.Equals("end"))
            {
                text += Console.ReadLine();
            }

            string output = Regex.Replace(text, pattern, replace);
            Console.WriteLine(output);
        }
    }
}
