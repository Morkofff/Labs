using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1
{
    public class ArrayVector
{
    int[] vector;

    public int[] getVector() { return vector; }

    public ArrayVector() : this(5) { }

    public ArrayVector(int size)
    {
        try
        {
            if (size <= 0)
            {
               
                throw new Exception("Длина массива должна быть больше нуля.");
               

            }

            vector = (new int[size]);
        }
        catch (Exception)
        {
            Console.WriteLine("Длина массива должна быть больше нуля.");
            return;
        }
        // for (int i = 0; i < size; ++i)
        // {
        //     vector.Add(0);
        // }
    }

    public void setElement(int index, int value)
    {
        if (index < 0 || index > vector.Length)
        {
            Console.WriteLine("Индекс находится вне границ массива");
            return;
        }
        vector[index] = value;
    }

    public double getElement(int index)
    {
        if (index < 0 || index > vector.Length)
        {
            Console.WriteLine("Индекс находится вне границ массива");
            return -1;
        }
        return vector[index];
    }

    public double getNorm()
    {
        double sum = 0;
        foreach (int element in vector)
        {
            sum += Math.Pow(element, 2);
        }
        return Math.Sqrt(sum);
    }

    public string sumPositivesFromChetIndex()
    {
        int sum = 0;
        bool f = false;

        for (int i = 1; i <= vector.Length; ++i)
        {
            if (i % 2 == 0 && vector[i-1] > 0)
            {
                sum += vector[i-1];
                f = true;
            }
        }
        if (f)
        {
            return ""+ sum;
        }
        else
        {
            return "Элементы не найдены";
        }
    }
    
    public string SumLessFromNechetIndex()
    {
        bool f = false;
        if (vector.Length == 0)
        {
            return "0";
        }

        double avg = vector.Average(x => Math.Abs(x));

        int sum = 0;
        for (int i = 1; i <= vector.Length; ++i)
        {
            if (i % 2 != 0 && Math.Abs(vector[i-1]) < avg)
            {
                sum += vector[i-1];
                f = true;
            }
        }
        if (f)
        {
            return "" + sum;
        }
        else
        {
            return "Элементы не найдены";
        }
    }

    public string multChet()
    {
        int product = 1;
        bool f = false;

        foreach (int element in vector)
        {
            if (element > 0 && element % 2 == 0)
            {
                f = true;
                product *= element;
                if (product == 0) return "0";
            }
        }

        if (f)
        {
            return "" + product;
        }
        else
        {
            return "Элементы не найдены";
        }
        
        
    }

    public string multNechet()
    {
        int product = 1;
        bool f = false;

        foreach (int element in vector)
        {
            if (element % 2 != 0 && element % 3 != 0)
            {
                f = true;
                product *= element;
                if (product == 0) return "0";
            }
        }

        if (f)
        {
            return "" + product;
        }
        else
        {
            return "Элементы не найдены";
        }
    }

    public void sortUp()
    {
        Array.Sort(vector);
 
    }

    public void sortDown()
    {
        var r = from i in vector 
                                    orderby i descending 
                                    select i;
        vector = r.ToArray();
    }

    public string print()
    {
        string result = "";
        if (vector != null)
        {
            foreach (int element in vector)
            {
                result += element + " ";
            }
            return result;
        }
        
        return result;
    }
}
}