using System;
//Just checking that push and pull works
//Arrays are th simplest data structures (data-index pairs) upon which stacks and queues are based
namespace Array
{
    class Program
    {

        static void Main(string[] args)
        {
            Random generator = new Random();

            int[] oneArray = new int[10];
            Console.WriteLine("One dimensional array items before sort:");
            for (int i = 0; i < 10; i++) {
                oneArray[i] = generator.Next(20);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write(oneArray[i] + " ");
            }

            //uncomment sort you want to apply
            //MergeSort(oneArray, 0, 9);
            //QuickSort(oneArray, 0, 9);
            //SelectionSort(oneArray);
            //BubbleSort(oneArray);
            InsertionSort(oneArray);
            Console.WriteLine("\nOne dimensional array items after sort:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(oneArray[i] + " ");
            }

        }

        //Merge Sort
        static void MergeSort(int[] arr, int li, int hi) {
            if (li < hi) {
                int mid = (li + hi) / 2;
                MergeSort(arr, li, mid);
                MergeSort(arr, mid + 1, hi);
                Merge(arr, li, mid, hi);
            }
        }

        static void Merge(int[] arr, int li, int mid, int hi) {
            int[] twoArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int i = li;
            int j = mid + 1;
            int k = li;
            while (i <= mid && j <= hi) {
                if (arr[i] <= arr[j])
                {
                    twoArray[k] = arr[i];
                    i++;
                    k++;
                }
                else {
                    twoArray[k] = arr[j];
                    j++;
                    k++;
                }
            }

            if (i > mid) {
                while (j <= hi) {
                    twoArray[k] = arr[j];
                    j++;
                    k++;
                }

            }
            else if (j > hi) {
                while (i <= mid) {
                    twoArray[k] = arr[i];
                    i++;
                    k++;
                }
            }
            for (int p = li; p <= hi; p++) {
                arr[p] = twoArray[p];
            }
        }

        //Quick Sort
        static void QuickSort(int[] arr, int l, int h){
            int j;
            if (l < h) {
                j = Partition(arr, l, h);
                if (j > 1) {QuickSort(arr, l, j-1); }
                if (j + 1 < h) {QuickSort(arr, j + 1, h); }
            }
        }
        static int Partition(int[] arr, int l, int h) {
            int pivot = arr[l];
            int i = l;
            int j = h;
            while (i<j) {
                while (arr[i] <= pivot && i<h) {
                    i++;
                }
                while (arr[j] > pivot && j>0) {
                    j--;
                }
                if (i < j) {
                    int temp1 = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp1;
                }
                    
            }
            int temp2 = arr[j];
            arr[j] = arr[l];
            arr[l] = temp2;
            return j;
        }

        //Selection sort
        static void SelectionSort(int[] arr) {
            int length = arr.Length;
            for (int i = 0; i < length - 1; i++) {
                int smallest = i;
                for (int j = i+1; j < length; j++) {
                    if (arr[j] < arr[smallest]) {
                        smallest = j;
                    }
                }
                int oldMin = arr[i];
                arr[i] = arr[smallest];
                arr[smallest] = oldMin;
            }
        }

        //Bubble sort
        static void BubbleSort(int[] arr) {
            int length = arr.Length;
            for (int i = 0; i < length - 1; i++) {
                for (int j = 0; j < length - 1 - i; j++) {
                    if (arr[j] > arr[j + 1]) {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        //Insertion sort
        static void InsertionSort(int[] arr)
        {
            int length = arr.Length;
            int temp;
            int j;
            for (int i = 1; i < length; i++)
            {
                temp = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > temp) {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = temp;
            }
        }
    }
}
