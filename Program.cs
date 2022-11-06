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
            //0
            if (mid == "| |")
                return "0";

            //1 4 7 9
            if (bot == "  |")
                if (mid == "  |") //1 7
                {
                    if (top == "   ")
                        return "1";
                    return "7";
                }
                else //4 9
                {
                    if (top == "   ")
                        return "4";
                    return "9";
                }

            //8
            if (mid == "|_|")
                return "8";


            //2 3
            if (mid == " _|")
                if (bot == "|_ ")
                    return "2";
                else
                    return "3";

            //6
            if (bot == "|_|")
                return "6";

            //5
            return "5";
        }
    }
}