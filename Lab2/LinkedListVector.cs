namespace Lab2;

public class LinkedListVector
{
    class Node
    {
        public int elem;
        public Node next;
        
        public Node(int elem = 0)
        {
            this.elem = elem;
            next = null;
        }
    }
    
    private Node head;
    private int size;
    
    public LinkedListVector(int length)
    {
        if (length <= 0)
        {
            throw new ArgumentException("Длина списка должна быть положительной.");
        }
        
        size = length;
        
        head = new Node();
        Node node = head;

        for (int i = 0; i < length - 1; i++)
        {
            node.next = new Node();
            node = node.next;
        }
    }
    
    public LinkedListVector() : this(5) { }
    
    public int this[int index]
    {
        get
        {
            if (index < 1 || index > size)
            {
                throw new IndexOutOfRangeException("Индекс находится вне диапазона.");
            }

            Node node = head;
            for (int i = 1; i < index; i++)
            {
                node = node.next;
            }

            return node.elem;
        }
        set
        {
            if (index < 1 || index > size)
            {
                throw new IndexOutOfRangeException("Индекс находится вне диапазона.");
            }

            Node node = head;
            for (int i = 1; i < index; i++)
            {
                node = node.next;
            }

            node.elem = value;
        }
    }
    
    public double getNorm()
    {
        double sum = 0;
        Node node = head;
        while (node != null)
        {
            sum += node.elem * node.elem;
            node = node.next;
        }
        return Math.Sqrt(sum);
    }

    public int getSize()
    {
        return size;
    }
    
    public void addToBegin(int value)
    {
        Node newNode = new Node(value);
        newNode.next = head;
        head = newNode;
        size++;
    }
    
    public void RemoveFromBeginning()
    {
        head = head.next;
        size--;
    }
    
    public void addToEnd(int value)
    {
        Node node = head;
        while (node.next != null)
        {
            node = node.next;
        }
        node.next = new Node(value);
        
        size++;
    }
    
    public void removeFromEnd()
    {
        
        Node node = head;
        
        if (head.next == null)
        {
            head = null;
            size = 0;
            return;
        }
        
        while (node.next.next != null)
        {
            node = node.next;
        }

        node.next = null;
        size--;
    }
    
    public void addToPos(int value, int position)
    {
        if (position < 1 || position > size + 1)
        {
            throw new IndexOutOfRangeException("Индекс находится вне диапазона для вставки.");
        }

        if (position == 1)
        {
            addToBegin(value);
        }
        else if (position == size + 1)
        {
            addToEnd(value);
        }
        else
        {
            
            Node node = head;
            for (int i = 1; i < position - 1; i++)
            {
                node = node.next;
           }

            Node newNode = new Node(value);
            newNode.next = node.next;
            node.next = newNode;
            size++;
        }
    }
}