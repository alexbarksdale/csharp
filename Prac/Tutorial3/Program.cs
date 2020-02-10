using System;

namespace Tutorial3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "This is going to be a really really really really really long text";
            string summary = StringUtil.SummarizeText(sentence, 20);
            System.Console.WriteLine(summary);
        }

    }
}