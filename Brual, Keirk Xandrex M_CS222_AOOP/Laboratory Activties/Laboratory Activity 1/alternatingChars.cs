using System;

class alternatingChars {
    static void Main() {
        Console.Write("First character: ");
        char first = Console.ReadKey().KeyChar;
        Console.WriteLine();
        
        Console.Write("Second character: ");
        char second = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.Write("Enter size: ");
        int size = int.Parse(Console.ReadLine());

        for (int i = 0; i < size; i++) {
            for(int j = 1; j <= i; j++) {
                Console.Write("-");
            }
            if (i % 2 == 0) {
                Console.Write(first);
            } else {
                Console.Write(second);
            }
            Console.WriteLine();
        }
    } 
}