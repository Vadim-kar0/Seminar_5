// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12

// Console.WriteLine("Введите число: ");
// string str = "123"; // Console.ReadLine();
// int sum = 0;

// // for (int i = 0; i < str.Length; i++)
// // {
// //     char currentChar = str[i];
// //     int positionOfChar = Convert.ToInt32(currentChar);
// //     int numberFromChar = Convert.ToInt32(currentChar.ToString());
// //     Console.Write($"Символ: {currentChar}, позиция: {positionOfChar}, число: {numberFromChar} \n");
// // }

// for (int i = 0; i < str.Length; i++)
// {
//     int currentNumber = int.Parse(str[i].ToString());
//     sum += currentNumber; // sum = sum + currentNumber
// }
// Console.WriteLine(sum);

// Заполение массива:
// int[] array = {new Random().Next(0, 10)}; // так не сработает, будет только одно число
// Console.WriteLine("Введите размер массива: ");
// int arraySize = Convert.ToInt32(Console.ReadLine()); // например, 4
// int[] array = new int[arraySize]; // arraySize == 4 - размер (количество)

// for (int i = 0; i < array.Length; i++) // заполнение массива
// {
//     int randomNumber = new Random().Next(0, 10); // генерируем случайное число
//     array[i] = randomNumber; // кладём в массив на место с индексом i
// }

// for (int i = 0; i < array.Length; i++) // вывод массива в консоль
// {
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();

// for (int i = 0; i < array.Length; i++) // изменение массива уже после заполнения
// {
//     array[i] = array[i] + 5;
// }

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }

// Циклы:
// Прерывание - break

// Console.WriteLine("Начало цикла");
// for (int i = 0; i < 10; i++)
// {
//     if (i == 2)
//     {
//         Console.WriteLine($"{i} это уже и так много");
//         break; // прерывание цикла и выход из него
//     }
//     Console.WriteLine(i);
// }
// Console.WriteLine("Конец цикла");

// Переход к следущей итерации - continue
// Console.WriteLine("Начало цикла");
// for (int i = 0; i < 4; i++)
// {
//     if (i == 2)
//     {
//         Console.WriteLine($"Мне не нравится квадрат {i}");
//         continue;
//     }
//     Console.WriteLine(i * i);
// }
// Console.WriteLine("Конец цикла");

// // Правила по стилю написания кода (code style)
// // Все названия любых структур языка должны описывать то, что они делают или хранят
// // Переменные: первое слово пишется с маленькой буквы, следующие слова с большой
// string textFromConsole; // Текст из консоли
// string text; // вот так не надо, это не информативно

// // Функции (Класс, интерфейсы, структуры, перечисления): Все слова с первого пишутся с большой буквы
// int GetRandomNumber(int from, int to) // Получение случайного числа
// // все фигурные скобки начинаются с новое строки, а не со строки, где объявляется функция или цикл
// {
//     return 0; // заглушка
// }

// Массив -- ссылочный тип данных (https://docs.google.com/spreadsheets/d/1yiSKaofDmfVFaZWDs287BpUPn_IrmfgpnPB4tbZnF8A/edit?usp=sharing)
// // ! Массив переменная, которая хранит массив, хранит ССЫЛКУ (адрес) на оперативную память 
// (так же ведут себя классы, интерфейсы и объекты)
// int[] array = { 1, 2, 3 };
// int[] array2 = array;
// array2[0] = 55;
// Console.WriteLine($"Первое значение исходного массива: {array[0]}, первое значение скопированного массива {array2[0]}");
// // Чтобы сделать копию массива:
// int[] array3 = new int[array.Length];
// for (int i = 0; i < array3.Length; i++)
// {
//     array3[i] = array[i];
// }
// // вариант 2
// int[] array4 = (int[])array.Clone();

// Область видимости -- фигурные скобки задают то, где переменную видно

// {
//     // если переменная объявлена внутри фигурных скобок, то её не будет видно за пределами фигурных скобках
//     int a = 5;
// }

// Задачи 5-й семинар C#:
// Задача 1: Задайте массив из 10 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите суммы отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

// Console.WriteLine("Введите размер массива: ");
// int arraySize = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[arraySize];

// for (int i = 0; i < array.Length; i++)
// {
//     int randomNumber = new Random().Next(-9, 10);
//     array[i] = randomNumber;
//     Console.Write(array[i] + " ");
// }

// int sumneg = 0;
// int sumpoz = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] < 0)
//     {
//         sumneg = sumneg + array[i];
//     }
//     if (array[i] > 0)
//     {
//         sumpoz = sumpoz + array[i];
//     }
// }
// Console.WriteLine($"сумма положительных равна {sumpoz}");
// Console.WriteLine($"сумма отрицательных равна {sumneg}");




// Задача 2: Задайте массив из 10 элементов из промежутка [-9, 9] и положительные элементы замените 
// на соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// Console.WriteLine("Введите размер массива: ");
// int arraySize = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[arraySize];

// for (int i = 0; i < array.Length; i++)
// {
//     int randomNumber = new Random().Next(-9, 10);
//     array[i] = randomNumber;
//     Console.Write(array[i] + " ");
// }

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = array[i] * -1;
//     Console.Write(array[i] + " ");
// }
