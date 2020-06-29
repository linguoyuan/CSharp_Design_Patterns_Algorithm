using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortTest : MonoBehaviour
{
    int[] OringeArray = new int[] { 7, 4, 6, 9, 8 ,3, 1, 2,5, 0};
    void Start()
    {
        //MaoPaoSort(OringeArray);
        ZhiJieSort(OringeArray);
        PrintArray();

        int index = BinarySearch(5, 0, 10, OringeArray);
        Debug.Log("index =" + index);
    }

    int[] MaoPaoSort(int[] array)
    {
        if (array.Length <= 0)
        {
            return null;
        }
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length - 1; j++)
            {                
                if (array[j] > array[j+1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }

        return array;
    }

    int[] ZhiJieSort(int[] array)
    {
        if (array.Length <= 0)
        {
            return null;
        }
        for (int i = 0; i < array.Length; i++)
        {
            int current = array[i];
            for (int j = i+1; j < array.Length; j++)
            {
                if (array[j] < current)
                {
                    int temp = array[j];
                    array[j] = current;
                    current = temp;
                }
            }
            array[i] = current;
        }
        return array;
    }

    private void PrintArray()
    {
        string s = "";
        for (int i = 0; i < OringeArray.Length; i++)
        {
            s += OringeArray[i] + "  ";
        }
        Debug.Log(s);
    }

    //二分查找,返回所在元素
    private int BinarySearch(int targetNum, int low , int high, int[] sortedArray)
    {
        int mid = (low + high)/2;
        if (low > high)
        {
            return -1;
        }
        else
        {
            if (sortedArray[mid] == targetNum)
            {
                return mid;
            }
            else if(sortedArray[mid] > targetNum)
            {
                return BinarySearch(targetNum, low, mid, sortedArray);
            }
            else
            {
                return BinarySearch(targetNum, mid, high, sortedArray);
            }
        }
    }
}
