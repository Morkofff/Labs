using System.Collections;

namespace Lab1;

public class ArrayVector
{
    List<int> vector;
    
    public List<int> getVector { get => vector; }

    public ArrayVector() : this(5) { }

    public ArrayVector(int size)
    {
        if (size <= 0)
        {
            throw new ArgumentException("Длина массива должна быть больше нуля.");
        }
        
        vector = new List<int>(new int[size]);
        // for (int i = 0; i < size; ++i)
        // {
        //     vector.Add(0);
        // }
    }

    public void setElement(int index, int value)
    {
        if (index < 0 || index > vector.Count)
        {
            throw new IndexOutOfRangeException("Индекс находится вне границ массива");
        }
        vector[index] = value;
    }

    public double getElement(int index)
    {
        if (index < 0 || index > vector.Count)
        {
            throw new IndexOutOfRangeException("Индекс находится вне границ массива");
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
    
    public int sumPositivesFromChetIndex()
    {
        int sum = 0;
        for (int i = 1; i <= vector.Count; ++i)
        {
            if (i % 2 == 0 && vector[i-1] > 0)
            {
                sum += vector[i-1];
            }
        }
        return sum;
    }
    
    public int SumLessFromNechetIndex()
    {
        if (vector.Count == 0)
        {
            return 0;
        }

        double avg = vector.Average(x => Math.Abs(x));

        int sum = 0;
        for (int i = 1; i <= vector.Count; ++i)
        {
            if (i % 2 != 0 && Math.Abs(vector[i-1]) < avg)
            {
                sum += vector[i-1];
            }
        }
        return sum;
    }
    
    public int multChet()
    {
        int product = 1;
        bool f = false;

        foreach (int element in vector)
        {
            if (element > 0 && element % 2 == 0)
            {
                f = true;
                product *= element;
                if (product == 0) return 0;
            }
        }

        if (!f)
        {
            return 0;
        }
        
        return product;
    }
    
    public int multNechet()
    {
        int product = 1;
        bool f = false;

        foreach (int element in vector)
        {
            if (element % 2 != 0 && element % 3 != 0)
            {
                f = true;
                product *= element;
                if (product == 0) return 0;
            }
        }

        if (!f)
        {
            return 0;
        }

        return product;
    }

    public void sortUp()
    {
        vector.Sort();
    }

    public void sortDown()
    {
        var r = from i in vector 
                                    orderby i descending 
                                    select i;
        vector = r.ToList();
    }

    public string print()
    {
        string result = "";
        foreach (int element in vector)
        {
            result += element + " ";
        }
        return result;
    }
}