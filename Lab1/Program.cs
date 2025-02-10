namespace Lab1;

public class Program
{
    public static void Main(string[] args)
    {
        ArrayVector arrayVector = new ArrayVector();
        arrayVector.setElement(0, 1);
        arrayVector.setElement(1, 2);
        arrayVector.setElement(2, 1);
        arrayVector.setElement(3, 3);
        arrayVector.setElement(4, 4);
        Console.WriteLine("Испходный вектор: " + arrayVector.print());

        Console.WriteLine("Элемент по индексу 2: " + arrayVector.getElement(2));
        Console.WriteLine("Модуль вектора: " + arrayVector.getNorm());
        Console.WriteLine("Cуммa всех положительных элементов\nмассива с четными номерами: " + arrayVector.sumPositivesFromChetIndex());
        Console.WriteLine("Cуммa тех элементов массива, которые\nимеют нечетные номера и одновременно меньше среднего значения всех модулей\nэлементов массива: " + arrayVector.SumLessFromNechetIndex());
        Console.WriteLine("Произведение всех четных положительных элементов по\nзначению: " + arrayVector.multChet());
        Console.WriteLine("Произведения всех нечетных элементов (по значению), не\nделящихся на три: " + arrayVector.multNechet());
        
        arrayVector.sortUp();
        Console.WriteLine("Отсортированный по возрастанию вектор: " + arrayVector.print());
        arrayVector.sortDown();
        Console.WriteLine("Отсортированный по убыванию вектор: " + arrayVector.print());
        
        ArrayVector a = new ArrayVector(3);
        a.setElement(0, 1);
        a.setElement(1, 2);
        a.setElement(2, 3);
        
        ArrayVector b = new ArrayVector(3);
        b.setElement(0, 1);
        b.setElement(1, 2);
        b.setElement(2, 3);
        
        Console.WriteLine("Сумма векторов a and b: " + Vectors.sumSt(a, b).print());
        Console.WriteLine("Скалярное произведение векторов a and b: " + Vectors.scalarSt(a, b));
        
        Console.WriteLine("Умножение вектора a на 5: " + Vectors.multNumberSt(a, 5).print());
        Console.WriteLine("Модуль веткора a : " + Vectors.getNormSt(a));
    }
}