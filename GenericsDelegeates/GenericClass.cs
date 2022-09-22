using System;

public class GenericClass<T>
{
	int curr = 0;
	int size = 10;

	T[] values = new T[10];
	public void Add(T item)
    {
		values[curr] = item;
		curr++;
		if (curr == 9)
        {                                        
			T[] temp = values;                   
			values = new T[values.Length + size];
			for (int i = 0; i < temp.Length; i++)
            {                                       
				values[i] = temp[i];           
            }
        }
    }

}
