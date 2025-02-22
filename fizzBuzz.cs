using System;

class fizzBuzz {
    static void Main() {
        int limit = 15;
        for (int i = 1; i <= limit; i++) {
            if (i % 3 == 0 && i % 5 == 0) {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 5 == 0) {
                Console.WriteLine("Buzz");
            }
            else if (i % 3 == 0) {
                Console.WriteLine("Fizz");
            }
            else {
                Console.WriteLine(i);
            }
        }
    }
}