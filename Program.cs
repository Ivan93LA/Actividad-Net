var numeros = new MyList<int>(5);
var nombres = new MyList<string>(5);

numeros.Add(1);
numeros.Add(2);
numeros.Add(3);
numeros.Add(4);
numeros.Add(5);
numeros.Add(6);

Console.WriteLine(numeros.GetContent());
public class MyList<T>
{
    private List<T> _list;
    private int _limit;

    public MyList(int limit) { 
        _limit = limit;
        _list = new List<T>();

    }

    public void Add(T element)
    {
        if (_list.Count < _limit)
        {
            _list.Add(element);
        }
    }
    public string GetContent()
    {
        string content = " ";
        foreach (var element in _list) {
            content += element + " , ";
        }  
        return content;
    }
}
