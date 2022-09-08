namespace prapp
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("The pyramid");
            Console.WriteLine("hello");
            for (var i = 1; i < 10; i++) {
                for (var j = 0; j < i; j++) {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("reverse num with converting tostring");
            long num = 5685984123;
            //convert to string
            string numStr = num.ToString();
            // reverse
            string newNumStr = "";
            for (int i = 1; i <= numStr.Length; i++)
            {
                newNumStr += numStr[numStr.Length - i];
            }
            long newNum = long.Parse(newNumStr);
            Console.WriteLine(numStr);
            Console.WriteLine(newNum);

            //////////////
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("reverse num without converting tostring");
            long revNum = 0;
            for (int i = 0; i < numStr.Length; i++)
            {
                // get the last num from long number
                var lastNum = num % 10;
                // remove it from the long num
                num -= lastNum;
                num /= 10;
                // add it to the reversed num
                revNum += lastNum;
                if (i < numStr.Length-1) { revNum *= 10; }
            }
            Console.WriteLine(num);
            Console.WriteLine(revNum);
            //////////////
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Calculator");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Enter your first number");
            long firstNum = long.Parse(Console.ReadLine());
            Console.WriteLine("First num is " + firstNum);
            Console.WriteLine("");
            Console.WriteLine("Enter your second number");
            long secNum = long.Parse(Console.ReadLine());
            Console.WriteLine("Second num is " + secNum);
            Console.WriteLine("");
            doOperation();
            void doOperation ()
            {
                Console.WriteLine("Enter your math operator");
                Console.WriteLine("one of these [+, -, *, /]");
                var operatorSign = Console.ReadLine();
                if (operatorSign == "+") {
                    long result = firstNum + secNum;
                    Console.WriteLine("The result is " + result);                
                }
                else if (operatorSign == "-") {
                    long result = firstNum - secNum;
                    Console.WriteLine("The result is " + result);                
                }
                else if (operatorSign == "*") {
                    long result = firstNum * secNum;
                    Console.WriteLine("The result is " + result);                
                }
                else if (operatorSign == "/") {
                    long result = firstNum / secNum;
                    Console.WriteLine("The result is " + result);                
                }
                else {
                    Console.WriteLine("It is not valid opertator, please try again.");
                    doOperation();
                }
            }

        }
    }
}