//using System;

//namespace PalindromicCSharp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Boolean c = false;
//            while (!c)
//            {
//                Console.WriteLine("Digite o palindrome inicial(fim para terminar): ");
//                String s = Console.ReadLine();
//                if (s.Length < 100)
//                {
//                    if (s.Equals("fim"))
//                    {
//                        c = true;
//                    }

//                    else
//                    {
//                        Console.WriteLine("Maior palíndrome é: " + a(s));
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("A cadeia de caracteres precisa ter no máximo 100 elementos");
//                }
//            }
//        }

//        public static string a(string s)
//        {
//            string d = "";
//            int e = s.Length - 1;
//            for (int i = 0; i < e; i++)
//            {
//                for (int z = i + 2; z < e; z++)
//                {
//                    if (z - i > d.Length)
//                    {
//                        string p = s.Substring(i, z - i);
//                        if (b(p))
//                        {
//                            if (p.Length > d.Length)
//                            {
//                                d = p;
//                            }                                
//                        }
//                    }
//                }
//            }
//            return d;
//        }

//        public static Boolean b(string word)
//        {
//            char[] k = word.ToCharArray();
//            int l = k.Length / 2;
//            int z = k.Length / 2;
//            for (int i = 0; i < l; i++)
//            {
//                if (k[i] != k[z])
//                {
//                    return true;
//                }                    
//                z++;
//            }
//            return false;
//        }
//    }
//}
