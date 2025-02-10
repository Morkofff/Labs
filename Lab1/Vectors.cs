namespace Lab1;

public class Vectors
{
    public static ArrayVector sumSt(ArrayVector a, ArrayVector b)
    {
        if (a.getVector.Count() != b.getVector.Count())
        {
            throw new ArgumentException("Векторы должны быть одинакового размера для сложения.");
        }
        
        ArrayVector result = new ArrayVector(a.getVector.Count);
        
        for (int i = 0; i <= a.getVector.Count - 1; ++i)
        {
            result.setElement(i, (int)(a.getElement(i) + b.getElement(i)));
        }
        
        return result;
    }
    
    public static int scalarSt(ArrayVector a, ArrayVector b)
    {
        if (a.getVector.Count() != b.getVector.Count())
        {
            throw new ArgumentException("Векторы должны быть одинакового размера для сложения.");
        }

        int result = 0;
        for (int i = 0; i <= a.getVector.Count - 1; ++i)
        {
            result += (int)a.getElement(i) * (int)b.getElement(i);
        }
        return result;
    }
    
    public static ArrayVector multNumberSt(ArrayVector vec, int number)
    {
        
        ArrayVector result = new ArrayVector(vec.getVector.Count);

        for (int i = 0; i <= vec.getVector.Count - 1; ++i)
        {
            result.setElement(i, (int)vec.getElement(i) * number);
        }
        return result;
    }
    
    public static double getNormSt(ArrayVector vec)
    {
        return vec.getNorm();
    }
}