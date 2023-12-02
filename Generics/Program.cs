namespace Generics;

internal abstract class Program
{
    public static void Main(string[] args)
    {
        List<string> cities = new List<string>();
        cities.Add("Ankara");
        cities.Add("Roma");
        cities.Add("Berlin");
        cities.Add("London");
        cities.Add("Paris");
        Console.WriteLine(cities.Count);
        
        
        
        
        MyList<string> cities2 = new MyList<string>();
        cities2.Add("Ankara");
        cities2.Add("Roma");
        cities2.Add("Berlin");
        cities2.Add("London");
        cities2.Add("Paris");
        cities2.Add("Amsterdam");
        Console.WriteLine(cities2.Count);
        
    }

    class MyList<T> // generic class
    {
        T[] _array;
        private T[] _tempArray;

        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }
        
        
        public int Count
        {
            get { return _array.Length; }
        }
        
    }

    

    
}