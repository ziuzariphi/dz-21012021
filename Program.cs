using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            //DZ-1

            var A = Convert.ToInt32(Console.ReadLine());
            var B = Convert.ToInt32(Console.ReadLine());
            if (A != B) {
                A = Math.Max(A, B);
                B = Math.Max(A, B);
            }
            else {
                A = 0;
                B = 0;
            }
            Console.WriteLine(A + " " + B);

            int operand1 = Convert.ToInt32(Console.ReadLine());
            int operand2 = Convert.ToInt32(Console.ReadLine());
            string znak = Console.ReadLine();
            if (znak == "+"){
                Console.WriteLine(operand1 + operand2);
            }
            else if (znak == "-"){
                Console.WriteLine(operand1 - operand2); 
            }
            else if (znak == "*"){
                Console.WriteLine(operand1 * operand2);
            }
            else if (znak == "/"){
                if (operand2 != 0){
                    Console.WriteLine(operand1 / operand2);
                }
                else {
                    Console.WriteLine("Error");
                }
            }

            int number = Convert.ToInt32(Console.ReadLine());
            if ((0 <= number) && (number <= 14)) {
                Console.WriteLine("В 1-ый промежуток");
            }
            else if ((15 <= number) && (number <= 35)) {
                Console.WriteLine("Во 2-ой промежуток");
            }
            else if ((36 <= number) && (number <= 49)) {
                Console.WriteLine("В 3-ий промежуток");
            }
            else if ((51 <= number) && (number <= 100)) {
                Console.WriteLine("В 4-ый промежуток");
            }
            else if (number == 50) {
                Console.WriteLine("В 3-ий и 4-ый промежутки");
            }
            else{
                Console.WriteLine("Nowhere");
            }
            
            //DZ-2

            int cost = Convert.ToInt32(Console.ReadLine());
            if ((500 < cost) && (cost <= 1000)){
                Console.WriteLine(cost * 97 / 100);
            }
            else
            if (cost > 1000){
                Console.WriteLine(cost * 95 / 100);
            }
            else if(cost <= 500){
                Console.WriteLine(cost);
            }

            var x1 = Convert.ToInt32(Console.ReadLine());
            var x2 = Convert.ToInt32(Console.ReadLine());
            var x3 = Convert.ToInt32(Console.ReadLine());
            var x4 = Convert.ToInt32(Console.ReadLine());
            if ((x1 == x2) && (x2 == x3) && (x3 == x4)){
                Console.WriteLine(x1 * x2 * x3 * x4);
            }
            else if ((x1 <= x2) && (x2 <= x3) && (x3 <= x4)){
                Console.WriteLine("Числа расположены по возрастанию");
            }
            else {
                Console.WriteLine(Math.Min(x1, Math.Min(x2, Math.Min(x3, x4))));
            }

            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            int y;
            if (a < b){
                y = a;
                a = b;
                b = y;
            }
            if (a < c){
                y = a;
                a = c;
                c = y;
            }
            if (b < c){
                y = b;
                b = c;
                c = y;
            }
            Console.WriteLine(a + " " + b + " " + c);
        }
    }
}
