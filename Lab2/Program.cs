namespace Lab2;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Выберите класс для тестирования: ");
            Console.WriteLine("1. ArrayVector");
            Console.WriteLine("2. LinkedListVector");
            Console.WriteLine("3. Vectors");
        
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    arrayVectorTest();
                    break;
            }
        }
        
    }

    public static ArrayVector createArrayVector(int size)
    {
        ArrayVector arrayVector = new ArrayVector(size);
        for (int i = 1; i < arrayVector.getVector.Count; i++)
        {
            Console.WriteLine($"Введите элемент {i}: ");
            int elem = Convert.ToInt32(Console.ReadLine());
            arrayVector[i] = elem;
        }

        // Console.WriteLine(arrayVector.print());
        // Console.WriteLine(arrayVector.getVector.Count);
        return arrayVector;
    }
    
    // public static ArrayVector createArrayVector()
    // {
    //     ArrayVector arrayVector = new ArrayVector();
    //     for (int i = 0; i < arrayVector.getVector.Count; i++)
    //     {
    //         Console.WriteLine($"Введите элемент {i}: ");
    //         int elem = Convert.ToInt32(Console.ReadLine());
    //         arrayVector[i] = elem;
    //     }
    //
    //     Console.WriteLine(arrayVector.print());
    //     return arrayVector;
    // }
    
    static void arrayVectorTest()
    {

        while (true)
        {
            Console.WriteLine("Выберите функцию: ");
            Console.WriteLine("1. Создать вектор");
            Console.WriteLine("2. Получить координату по индексу");
            Console.WriteLine("3. Установить значение для координаты по индексу");
            Console.WriteLine("4. Вывести длину вектора");
            Console.WriteLine("5. Вывести число координат вектора");
        
            string choice = Console.ReadLine();
            ArrayVector arrayVector = null;

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Введите длину вектора \n(или оставьте пустым => длина вектора по умолчанию = 5): ");
                    string len = Console.ReadLine();
                    if (len.Length == 0)
                    {
                        arrayVector = createArrayVector(6);
                    }
                    else
                    {
                        arrayVector = createArrayVector(Convert.ToInt32(len+1));
                    }
                    break;
                case "2":
                    Console.WriteLine("Введите индекс: ");
                    int ind = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(arrayVector.print());
                    Console.WriteLine(arrayVector[ind]);
                    break;
            }
        }
        
        
    }
    
}