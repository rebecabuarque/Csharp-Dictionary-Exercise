using System;
using System.IO;
using System.Collections.Generic;

namespace ExercicioDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();

            string path = @"C:\Users\gerba\Desktop\College\Rebeca Coding\Curso online - Orientado Objetos C#\12- Generics, Set e dictionary\ExercicioDictionary/text.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] vect = sr.ReadLine().Split(',');
                        string name = vect[0];
                        int votes = int.Parse(vect[1]);

                        if (dic.ContainsKey(name)){
                            dic[name] += votes;
                        }

                        else
                        {
                            dic[name] = votes;
                        }
                    }

                    foreach (var item in dic)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }


               
            } catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
