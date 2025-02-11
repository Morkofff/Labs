namespace Lab2;

public class ArrayVector
{
    private List<int> vector;
    
    public ArrayVector() : this(5) { }

    public ArrayVector(int size)
    {
        if (size <= 0)
        {
            throw new ArgumentException("Длина массива должна быть больше нуля.");
        }
        
        vector = new List<int>(new int[size]);
        
    }
    
    public List<int> getVector { get => vector; }
    
    public int this[int index]
    {
        get
        {
            if (index - 1 < 0 || index - 1 >= vector.Count)
            {
                throw new IndexOutOfRangeException("Индекс находится вне допустимого диапазона.");
            }
            return vector[index - 1];
        }
        set
        {
            if (index - 1 < 0 || index - 1 >= vector.Count)
            {
                throw new IndexOutOfRangeException("Индекс находится вне допустимого диапазона.");
            }
            vector[index - 1] = value;
        }
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