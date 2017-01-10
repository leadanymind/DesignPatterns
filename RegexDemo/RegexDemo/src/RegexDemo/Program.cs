using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var SelectionText = File.ReadAllText("theselection.txt");
            FileStream fs = new FileStream("theselection.txt", FileMode.Open, FileAccess.Read);
            using (StreamReader r = new StreamReader(fs, Encoding.GetEncoding("iso-8859-1"))){
                
               
                var txt = r.ReadToEnd();

                var pattern = new Regex(@"[0-9]");
                var NewLines = new Regex(@"\n");
                var noNewLines = NewLines.Replace(SelectionText, "");
                System.Console.WriteLine(noNewLines);
                var matches = pattern.Matches(SelectionText);

                System.Console.ReadKey();
            }

        }
    }
}
