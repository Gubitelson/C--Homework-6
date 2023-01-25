/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
void Number()
{
    Console.Clear();
    Console.WriteLine("Для остановки программы нажите 'q'.\nВведите числа больше нуля: ");
    bool GoCode = true;
    int result = 0;
    while (GoCode)
    {
        string m = Console.ReadLine();
        if (int.TryParse(m, out int n) && Convert.ToInt32(m) > 0)
        {
            result++;
        }
        else if (m == "q")
        {
            Console.Write($"Вы нажали 'q', Программа остановилась. Введено {result} значений.\n");
            GoCode = false;
        }
    }
}

Number();