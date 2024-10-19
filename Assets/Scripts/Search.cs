using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Search : MonoBehaviour
{

    public int[] _array = null; 
    // Start is called before the first frame update
    void Start()
    {
        int arrayCount = Random.Range(10, 100);
        _array =  new int[arrayCount];

        Debug.Log($"Array de {arrayCount} posicoes");

        string result = "Valores; ";
        for (int i = 0; i < arrayCount; i++)
        {
            _array[i] = Random.Range(1, 1000);
            result += _array[i].ToString();
            if (i < arrayCount - 1)
            {
                result += ","; 
            }
        }
        Debug.Log (result);

        BubbleSort();

        result = "Valores; ";
        for (int i = 0; i < arrayCount; i++)
        {
            result += _array[i].ToString();
            if (i < arrayCount - 1)
            {
                result += ",";
            }
        }
        Debug.Log(result);
    }

  

    private void BubbleSort()
    {
        for (int i = _array.Length - 1; i > 0; i--)
        {
            bool toStop = true;
            for (int j = 0; j < i; j++)
            {
                if (_array[j] > _array[j + 1])
                {
                    toStop = false;
                    int temp = _array[j];
                    _array[j] = _array[j + 1];
                    _array[j + 1] = temp;
                }
            }
            if(toStop)
            break;
        }
    }

    private int BinarySearch(int value)
    {
        int start = 0;
        int end = _array.Length - 1;
        while (start <= end)
        {
            int middle = (start + end) / 2;
            if(value == _array[middle])
                return middle;

            if (value > _array[middle])
            {
                start = middle + 1;
            }
            else if (value < _array[middle])
            {
                end = middle - 1;
            }
        }

        return -1;
    }

}
