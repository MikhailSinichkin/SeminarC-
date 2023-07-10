/*45. Напишите программу, 
которая будет создавать копию заданного одномерного массива
с помощью поэлементного копирования.
 */

int[] copyArray(int[] arr)
{
    int[] copyArry = new int[arr.Length];
    for (int i= 0; i < arr.Length; i++)
    {
        copyArray[i] =arr[i];
        
    }
    return copyArray;
}
