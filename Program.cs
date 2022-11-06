namespace System
{
    class Program
    {
        static void Main()
        {
            //DEFINE VARIABLES
            string line1;
            string line2;
            string line3;
            string results = "";

            while ((line1 = Console.ReadLine()) != null && line1 != "")
            {
                //INPUT DATA
                line2 = Console.ReadLine();
                line3 = Console.ReadLine();

                //NEW LINE IN RESULTS
                results += "\n";

                //DETECT EACH NUMBER
                for (int i = 0; i < line1.Length; i += 3)
                {
                    results += Distinguish(line1.Substring(i, 3), line2.Substring(i, 3), line3.Substring(i, 3));
                };
            }
            Console.WriteLine(results);
        }
        public static string Distinguish(string top, string mid, string bot)
        {
            if (mid == "| |") //0
            {
                return "0";
            }
            else if (bot == "  |") //1 4 7 9
            {
                if (mid == "  |") //1 7
                {
                    if (top == "   ")
                    {
                        return "1";
                    }
                    else
                    {
                        return "7";
                    }
                }
                else //4 9
                {
                    if (top == "   ")
                    {
                        return "4";
                    }
                    else
                    {
                        return "9";
                    }
                }
            }
            else if (mid == "|_|") //8
            {
                return "8";
            }
            else if (mid == " _|") //2 3
            {
                if (bot == "|_ ")
                {
                    return "2";
                }
                else
                {
                    return "3";
                }
            }
            else if (bot == "|_|")
            {
                return "6";
            }
            else
            {
                return "5";
            }
        }
    }
}