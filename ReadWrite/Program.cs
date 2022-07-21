using System;
using System.IO;
using System.Linq;

namespace ReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] words = { "hello", "hi", "words", "word", "Beautifull" };
            //var startword = from word in words where word.Length <= 5 select word;
            //foreach (var lword in startword)
            //{
            //    Console.WriteLine(lword);
            //}
            //Console.ReadLine();
            //Console.WriteLine("Hello World!");
            string sample1 = @"D:\\sample1.txt";
            if (!File.Exists(sample1))
            {
                string str = "";
                var linecounter = 0;
                foreach (var samples in new[] { "D:\\sample2.txt", "D:\\sample3.txt" })
                {
                    using (var readsamples = File.OpenText(samples))
                    {
                        while ((str = readsamples.ReadLine()) != null)
                        {
                            if (linecounter == 2)
                            {
                                Console.WriteLine("");
                            }
                            else
                            {
                                using (StreamWriter writer = System.IO.File.AppendText(sample1))
                                {
                                    writer.WriteLine(str);
                                }
                            }
                            linecounter++;
                        }
                    }
                }
            }
            //string str = "";
            //var linecounter = 0;
            //using (StreamReader streamReader = File.OpenText("D:\\sample3.txt"))
            //{
            //    while ((str = streamReader.ReadLine()) != null)
            //    {
            //        if (linecounter == 1)
            //        {
            //            Console.WriteLine("");
            //        }
            //        else
            //        {
            //            Console.WriteLine(str);
            //        }
            //        linecounter++;
            //    }
            //}
            //int[] scrore = new int[] { 10,33,55,46,86,90,55};
            //var lastscrore = from scores in scrore where scores < 40 select scores;
            //foreach (var item in lastscrore)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
