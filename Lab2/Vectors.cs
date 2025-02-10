namespace Lab2;

public class Vectors
{
    public static ArrayVector sumSt(ArrayVector a, ArrayVector b)
    {
        if (a == null || b == null)
        {
            throw new ArgumentNullException("Векторы не созданы.");
        }
        
        if (a.getVector.Count() != b.getVector.Count())
        {
            throw new ArgumentException("Векторы должны быть одинакового размера для сложения.");
        }
        
        ArrayVector result = new ArrayVector(a.getVector.Count);
        
        for (int i = 0; i <= a.getVector.Count - 1; ++i)
        {
            // result.setElement(i, (int)(a.getElement(i) + b.getElement(i)));
            result[i] = a[i] + b[i];
        }
        
        return result;
    }
    
    public static int scalarSt(ArrayVector a, ArrayVector b)
    {
        if (a == null || b == null)
        {
            throw new ArgumentNullException("Векторы не созданы.");
        }
        
        if (a.getVector.Count() != b.getVector.Count())
        {
            throw new ArgumentException("Векторы должны быть одинакового размера для сложения.");
        }

        int result = 0;
        for (int i = 0; i <= a.getVector.Count - 1; ++i)
        {
            // result += (int)a.getElement(i) * (int)b.getElement(i);
            result += a[i] * b[i];
        }
        return result;
    }
    
    public static double getNormSt(ArrayVector vec)
    {
        if (vec == null)
        {
            throw new ArgumentNullException("Вектор не создан.");
        }
        
        return vec.getNorm();
    }
}