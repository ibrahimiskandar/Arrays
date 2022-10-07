

/*------------2.Find out min value in array.-----------------------*/
//Console.WriteLine("input the size of array:");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] arr=new int[size];
//Console.WriteLine("input values:");
//for (int i = 0; i < size; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//void Min(int[] array)
//{
//    int min = array[0];
//    for (int i = 1; i < array.Length; i++)
//	{
//		if (min > arr[i])
//		{
//			min = arr[i];
//		}
//	}
//	Console.WriteLine(min);
//}
//Min(arr);

/*------------2.Find out max value in array.-----------------------*/
//Console.WriteLine("input the size of array:");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] arr = new int[size];
//Console.WriteLine("input values:");
//for (int i = 0; i < size; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//void Max(int[] array)
//{
//    int max = array[0];
//    for (int i = 1; i < array.Length; i++)
//    {
//        if (max < arr[i])
//        {
//            max = arr[i];
//        }
//    }
//    Console.WriteLine(max);
//}
//Max(arr);


/*------------3.Find out index of minimal value in array.-----------------------*/

//Console.WriteLine("input the size of array:");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] arr = new int[size];
//Console.WriteLine("input values:");
//for (int i = 0; i < size; i++)
//{
//	arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//void minIndex(int[] array)
//{
//	int min = array[0];
//	int minIndex = 0;
//	for (int i = 1; i < array.Length; i++)
//	{
//		if (min > arr[i])
//		{
//			min = arr[i];
//            minIndex = i;
//        }
//	}
//	Console.WriteLine(minIndex);
//}
//minIndex(arr);


/*------------4.Find out index of maximal value in array.-----------------------*/

//Console.WriteLine("input the size of array:");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] arr = new int[size];
//Console.WriteLine("input values:");
//for (int i = 0; i < size; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//void maxIndex(int[] array)
//{
//    int max = array[0];
//    int maxIndex = 0;
//    for (int i = 1; i < array.Length; i++)
//    {
//        if (max < arr[i])
//        {
//            max = arr[i];
//            maxIndex = i;
//        }
//    }
//    Console.WriteLine(maxIndex);
//}
//maxIndex(arr);


/*------------5.Calculate sum of all elements with odd indexes.-----------------------*/



//Console.WriteLine("input the size of array:");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] arr = new int[size];
//Console.WriteLine("input values:");
//for (int i = 0; i < size; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//void sumOdd(int[] array)
//{
//    int sum = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (i%2==1)
//        {
//            sum += array[i];
//        }
//    }
//    Console.WriteLine(sum);
//}
//sumOdd(arr);


/*------------6.Reverse an array (f.e. 1 2 3 4 5-> 5 4 3 2 1).-----------------------*/


//Console.WriteLine("input the size of array:");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] arr = new int[size];
//Console.WriteLine("input values:");
//for (int i = 0; i < size; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//void reverse(int[] array)
//{
//    int[] reverse = new int[array.Length];
//    for (int i = 0; i < array.Length; i++)
//    {
//        reverse[reverse.Length - 1 - i] = array[i];
//    }

//    for (int i = 0; i < reverse.Length; i++)
//    {
//        Console.WriteLine(reverse[i]);
//    }
//}
//reverse(arr);

/*------------7.Calculate amount of all elements with odd values.-----------------------*/

//Console.WriteLine("input the size of array:");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] arr = new int[size];
//Console.WriteLine("input values:");
//for (int i = 0; i < size; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//void sumOddValue(int[] array)
//{
//    int sum = 0;
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (arr[i]%2 == 1)
//        {
//            sum += array[i];
//        }
//    }
//    Console.WriteLine(sum);
//}
//sumOddValue(arr);


/*------------8.Change first and second half of array(f.e. 1 2 3 4 -> 3 4 1 2, or 1 2 3 4 5-> 4 5 3 1 2).-----------------------*/


//Console.WriteLine("input the size of array:");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] arr = new int[size];
//Console.WriteLine("input values:");
//for (int i = 0; i < size; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//void Split(int[] array)
//{
//    int temp = array.Length / 2;
//    int[] first = new int[array.Length / 2];
//    int[] second = new int[first.Length];
//    for (int i = 0; i < array.Length / 2; i++)
//    {
//        first[i] = array[temp];
//        second[i] = array[i];
//        temp++;
//    }


//    for (int i = 0; i < first.Length; i++)
//    {

//            Console.WriteLine(first[i]);

//    }
//    for (int i = 0; i < second.Length; i++)
//    {

//        Console.WriteLine(second[i] );

//    }
//}
//Split(arr);



/*------------9.Sort array with one of those methods: bubble, select or insert. -----------------------*/


//Console.WriteLine("input the size of array:");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] arr = new int[size];
//Console.WriteLine("input values:");
//static void bubbleSort(int[] arr)
//{
//    for (int i = 0; i < arr.Length - 1; i++)
//        for (int j = 0; j < arr.Length - i - 1; j++)
//            if (arr[j] > arr[j + 1])
//            {
//                int temp = arr[j];
//                arr[j] = arr[j + 1];
//                arr[j + 1] = temp;
//            }

//    for (int i = 0; i < arr.Length; ++i)
//    {
//        Console.Write(arr[i] + " ");
//    }
//}
//bubbleSort(arr);
