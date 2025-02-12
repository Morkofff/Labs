using System;

namespace Lab1
{
    public class Program
    {
        public static ArrayVector createVector()
        {
            ArrayVector vector = new ArrayVector();
            Console.WriteLine("Введите длину массива (или оставьте поле ввода пустым)");
            string input = Console.ReadLine();
            if (input != "")
            {
                int l = Convert.ToInt32(input);
                vector = new ArrayVector(l);
                for (int i = 0; i < l; i++)
                {
                    Console.WriteLine("Введите элемент " + (i + 1));
                    vector.setElement(i, Convert.ToInt32(Console.ReadLine()));
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Введите элемент " + (i + 1));
                    vector.setElement(i, Convert.ToInt32(Console.ReadLine()));
                }
              
            }
            Console.WriteLine("Исходный вектор: " + vector.print());
            return vector;
        }

        public static void methodsArrayVector()
        {
            ArrayVector vector = null;

            while (true)
            {
                Console.WriteLine("Выберите пункт меню");
                Console.WriteLine("1. Создать вектор");
                Console.WriteLine("2. Получить элемент по индексу");
                Console.WriteLine("3. Получить модуль вектора");
                Console.WriteLine("4. Cуммa всех положительных элементов\nмассива с четными номерами");
                Console.WriteLine("5. Cуммa тех элементов массива, которые\nимеют нечетные номера и одновременно меньше среднего значения всех модулей\nэлементов массива");
                Console.WriteLine("6. Произведение всех четных положительных элементов по\nзначению");
                Console.WriteLine("7. Произведения всех нечетных элементов (по значению), не\nделящихся на три");
                Console.WriteLine("8. Отсотировать массивпо возрастанию");
                Console.WriteLine("9. Отсотировать массивпо убыванию");
                Console.WriteLine("10. Вывести вектор");
                Console.WriteLine("11. Вернуться в исходное меню");

                string userInput = Console.ReadLine();
                
                switch (userInput)
                {
                    case "1":
                        vector = createVector();
                        break;
                    case "2":
                        Console.WriteLine("Введите индекс: ");
                        int ind = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Элемент по индексу " + ind + ": " + vector.getElement(ind));
                        break;
                    case "3":
                        Console.WriteLine("Модуль вектора: " + vector.getNorm());
                        break;
                    case "4":
                       
                        Console.WriteLine("Cуммa всех положительных элементов\nмассива с четными номерами: " + vector.sumPositivesFromChetIndex());
                        break;
                    case "5":
                        Console.WriteLine("Cуммa тех элементов массива, которые\nимеют нечетные номера и одновременно меньше среднего значения всех модулей\nэлементов массива: " + vector.SumLessFromNechetIndex());
                        break;
                    case "6":
                        Console.WriteLine("Произведение всех четных положительных элементов по\nзначению: " + vector.multChet());
                        break;
                    case "7":
                        Console.WriteLine("Произведения всех нечетных элементов (по значению), не\nделящихся на три: " + vector.multNechet());
                        break;
                    case "8":
                        vector.sortUp();
                        Console.WriteLine("Отсортированный по возрастанию вектор: " + vector.print());
                        break;
                    case "9":
                        vector.sortDown();
                        Console.WriteLine("Отсортированный по убыванию вектор: " + vector.print());
                        break;
                    case "10":
                        Console.WriteLine(vector.print());
                        break;
                    case "11":
                        Menu();
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод");
                        break;
                }
            }
        }

        public static void methodsVectors()
        {
            ArrayVector a = null;
            ArrayVector b = null;

            while (true)
            {
                Console.WriteLine("Выберите пункт меню");
                Console.WriteLine("1. Создать векторы");
                Console.WriteLine("2. Сумма векторов a and b");
                Console.WriteLine("3. Скалярное произведение векторов a and b");
                Console.WriteLine("4. Умножение вектора a на число");
                Console.WriteLine("5. Модуль веткора a ");
                Console.WriteLine("6. Вернуться в исходное меню");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        a = createVector();
                        b = createVector();
                        break;
                    case "2":
                        Console.WriteLine("Сумма векторов a and b: " + Vectors.sumSt(a, b).print());
                        break;
                    case "3":
                        Console.WriteLine("Скалярное произведение векторов a and b: " + Vectors.scalarSt(a, b));
                        break;
                    case "4":
                        Console.WriteLine("Умножение вектора a на 5: " + Vectors.multNumberSt(a, 5).print());
                        break;
                    case "5":
                        Console.WriteLine("Модуль веткора a : " + Vectors.getNormSt(a));
                        break;
                    case "6":
                        Menu();
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод");
                        break;
                }
            }
        }

        public static void Menu()
        {
            ArrayVector arrayVector = new ArrayVector();

            while (true)
            {
                Console.WriteLine("Выберите пункт меню");
                Console.WriteLine("1. ArrayVector");
                Console.WriteLine("2. Vectors");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        methodsArrayVector();
                        break;
                    case "2":
                        methodsVectors();
                        break;
                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Лабораторнаяработа 1");
            Console.WriteLine("Кочетов Иван 6103-020302D");

            Menu();

            
           
        }
    }
}