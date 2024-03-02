using static System.Console;

// Напишите метод, который проверяет является ли переданное число «палиндромом». Число передаётся
// в качестве параметра. Если число палиндром нужно вернуть из метода true, иначе false.
// Палиндром — число, которое читается одинаково как справа налево, так и слева направо.
// Например:   1221 — палиндром; 3443 — палиндром; 7854 — не палиндром.

class Program
{
    static void Main()
    {
        WriteLine("Введите число для проверки, является ли переданное число «палиндромом»:");
        int number = Convert.ToInt32(ReadLine());
        bool isPalindrome = CheckPalindrome(number);

        if (isPalindrome)
        {
            WriteLine($"Число {number} является палиндромом");
        }
        else
        {
            WriteLine($"Число {number} НЕ является палиндромом");
        }
    }

    static bool CheckPalindrome(int number)
    {
        int originalNumber = number;
        int reversedNumber = 0;

        while (number > 0)
        {
            int remainder = number % 10;
            reversedNumber = reversedNumber * 10 + remainder;
            number = number / 10;
        }

        return originalNumber == reversedNumber;
    }
}