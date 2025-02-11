using System;
class Program { 
	static void Main(string[] args) {
var numero = new MyList<int>(5);
var nombres = new MyList<int>(5);

numero.add(1);
numero.add(2);
numero.add(3);
numero.add(4);
numero.add(5);
numero.add(6);

Console.WriteLine(numero.GetContent());

public class MyList<T>
	{
		private MyList<T> _list;
		private int _limit;

		public MyList(int limit)
		{
			_limit = limit;


		}
		public void Add(T element)
		{
			if (_list.count < _limit)
			{
				_list.Add(element);
			}
		}

		public string GetContent()
		{
			string content = "";
			foreach (var element in _list) {
				content += element + " , ";
			}
			return content;

		}
	}
	}