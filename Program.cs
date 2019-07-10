using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace email_palfy
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string path_names = @"C:\Users\Bendi\Documents\Visual Studio 2017\Projects\email_palfy\bin\Debug\names.txt";
            string[] students = File.ReadAllLines(path_names);
            string path_emails = @"C:\Users\Bendi\Documents\Visual Studio 2017\Projects\email_palfy\bin\Debug\emails.txt";
            StreamWriter sw = new StreamWriter(path_emails);
            
            string osztaly = students[0];
            for (int i = 1; i < students.Length; i++)
            {
                string word = students[i];
                string word_lower = word.ToLower();
                sw.Write(osztaly);
                for (int j = 0; j < word_lower.Length; j++)
                {
                    char tmp = word_lower[j];

                    switch (tmp)
                    {
                        case 'á':
                            sw.Write('a');
                            break;
                        case 'é':
                            sw.Write('e');
                            break;
                        case 'í':
                            sw.Write('i');
                            break;
                        case 'ó':
                            sw.Write('o');
                            break;
                        case 'ö':
                            sw.Write('o');
                            break;
                        case 'ő':
                            sw.Write('o');
                            break;
                        case 'ú':
                            sw.Write('u');
                            break;
                        case 'ü':
                            sw.Write('u');
                            break;
                        case 'ű':
                            sw.Write('u');
                            break;
                        case ' ':
                            sw.Write('.');
                            break;
                        default:
                            sw.Write(tmp);
                            break;

                    }
                }
                sw.Write("@palfy-vizugyi.hu");
                sw.WriteLine();
            }
            sw.Close();
            Console.WriteLine("Completed successfully!");
            Console.ReadLine();
        }
            
        }
    }

