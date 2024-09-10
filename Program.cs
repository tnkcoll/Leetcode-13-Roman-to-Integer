namespace Leetcode_13_Roman_to_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "LIVII";
            s = s.ToUpper();

            Console.WriteLine(RomanToInt(s));
        }

        public static int RomanToInt(string s)
        {
            int total = 0;
            string rNumeral = "";
            var romanNumeralsDict = new Dictionary<string, int>();

            for(int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1)
                {
                    switch (s[i])
                    {
                        case 'I':
                            if (s[i + 1] == 'V')
                            {
                                rNumeral = "IV";
                                i++;
                            }
                            else if (s[i + 1] == 'X')
                            {
                                rNumeral = "IX";
                                i++;
                            }
                            else
                            {
                                rNumeral = "I";
                            }

                            break;
                        case 'X':
                            if (s[i + 1] == 'L')
                            {
                                rNumeral = "XL";
                                i++;
                            }
                            else if (s[i + 1] == 'C')
                            {
                                rNumeral = "XC";
                                i++;
                            }
                            else
                            {
                                rNumeral = "X";
                            }

                            break;
                        case 'C':
                            if (s[i + 1] == 'D')
                            {
                                rNumeral = "CD";
                                i++;
                            }
                            else if (s[i + 1] == 'M')
                            {
                                rNumeral = "CM";
                                i++;
                            }
                            else
                            {
                                rNumeral = "C";
                            }

                            break;
                        default:
                            rNumeral = s[i].ToString();
                            break;
                    }
                }
                else
                {
                    rNumeral = s[i].ToString();
                }

                if (romanNumeralsDict.ContainsKey(rNumeral))
                {
                    romanNumeralsDict[rNumeral]++;
                    total = AddToTotal(rNumeral, total);
                }
                else
                {
                    romanNumeralsDict.Add(rNumeral, 1);
                    total = AddToTotal(rNumeral, total);
                }
                rNumeral = "";
            }

            return total;

        }

        public static int AddToTotal(string rNum, int total)
        {
            switch (rNum)
            {
                case "I":
                    total += 1; 
                    break;
                case "V":
                    total += 5;
                    break;
                case "X":
                    total += 10;
                    break;
                case "IV":
                    total += 4;
                    break;
                case "IX":
                    total += 9;
                    break;
                case "L":
                    total += 50;
                    break;
                case "C":
                    total += 100;
                    break;
                case "XL":
                    total += 40;
                    break;
                case "XC":
                    total += 90;
                    break;
                case "D":
                    total += 500;
                    break;
                case "M":
                    total += 1000;
                    break;
                case "CD":
                    total += 400;
                    break;
                case "CM":
                    total += 900;
                    break;
                default:
                    break;
            }
            return total;
        }
    }
}
