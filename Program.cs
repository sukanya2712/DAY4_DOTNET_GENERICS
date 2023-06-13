namespace genericproblems
{
    internal class Program
    {
        public static void Inte(int[] Number)
        {
            Console.WriteLine("give input to delete ");
            int input = int.Parse(Console.ReadLine());
            int[] temparray = new int[Number.Length - 1];
            int flag = 0;
            for (int i = 0; i < Number.Length; i++)
            {
                if (Number[i] != input)
                {
                    temparray[flag] = Number[i];
                    flag++;
                }
            }
            Console.WriteLine("Modified array:");
            string result = string.Join(", ", temparray.Take(flag));
            Console.WriteLine(result);
        }
        public static void Doub(string[] word)
        {
            Console.WriteLine("give input to delete ");
            string input = Console.ReadLine();
            string[] temparray = new string[word.Length - 1];
            int flag = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != input)
                {
                    temparray[flag] = word[i];
                    flag++;
                }
            }
            Console.WriteLine("Modified array:");
            string result = string.Join(", ", temparray.Take(flag));
            Console.WriteLine(result);
        }
        public static void Chara(char[] chars)
        {
            Console.WriteLine("give input to delete ");
            char input = Convert.ToChar(Console.Read());
            char[] temparray = new char[chars.Length - 1];
            int flag = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] != input)
                {
                    temparray[flag] = chars[i];
                    flag++;
                }
            }
            Console.WriteLine("Modified array:");
            string result = string.Join(", ", temparray.Take(flag));
            Console.WriteLine(result);

        }
        static void Main(string[] args)
        {
            // problem 1 
            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] word = { "abc", "def", "ghi" };
            char[] chars = { 'a', 'b', 'c' };
            //Inte(number);
            //Doub(word);
            //Chara(chars);


            //poblem 2 
            //problem22 obj2 = new problem22();
            //obj2.generics(number,3);
            //obj2.generics(word, "abc");
            //obj2.generics(chars, 'b');

            //problem6
            //problem66.FindMinString("apple","bababa","mango");

            //problem5
            //problem55.FindMinFloat(10.1f,20.3f,30.1f);

            //problem4
            //problem44.FindMinNumberr(10,30,40);

            // problem 7 using generics 
            //problem77.P7("apple","banana","dog");
            //problem77.P7(2, 4, 5);

            Problem8<int> problem8 = new Problem8<int>(8, 2, 6);
            problem8.testMinimum();

            Problem8<double> problem8_1 = new Problem8<double>(1.6, 1.2, 1.3);
            problem8_1.testMinimum();

            Problem8<string> problem8_2 = new Problem8<string>("abc", "efg", "xyz");
            problem8_2.testMinimum();
        }
    }
}
