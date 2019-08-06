using System;

namespace ManipulatingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ManipulatingArrays.Main");
            int[] arrayA = { 0, 2, 4, 6, 8, 10 };
            int[] arrayB = { 1, 3, 5, 7, 9 };
            int[] arrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            //Counting, summing, computing the mean
            MeanOfArray(arrayC);

            //Reversing arrays
            //Write a method that accepts an array as an argument and prints the reversed array. 
            //For example, if you pass the method Array B, it should print[9, 7, 5, 3, 1].
            //Print the reverse of all three arrays.
            ShowResults(reverseArray(arrayB));

            //Rotating arrays
            ShowResults(RotatingArray("left", 2, arrayA));
            ShowResults(RotatingArray("right", 2, arrayB));
            ShowResults(RotatingArray("left", 4, arrayC));

            //Sorting arrays
        }
        public static int[] reverseArray(int[] inputArray)
        {
            int[] answer = inputArray;
            for (int i = 0; i < inputArray.Length/2; i++)
            {
                int temp = answer[i];
                answer[i] = answer[inputArray.Length-i-1];
                answer[inputArray.Length-i-1] = temp;
            }
            return answer;
        }
        public static double MeanOfArray(int[] inputArray)
        {
            //initializing count and sum
            int sum = 0, count = 0;
            //iterate through entire array to get each element
            foreach (int element in inputArray)
            {
                //add 1 to count for each element
                count++;
                //adding the value of an element to the sum
                sum += element;
            }
            //calculating the mean
            double mean = (double)sum / count;
            //printing sum/count/mean to screen
            Console.WriteLine($"Sum of intArray is {sum}");
            Console.WriteLine($"Num of elements in intArray is {count}");
            Console.WriteLine($"Mean of array is {mean}");
            //just incase i wanna use the mean value for another method ive returned it as a double
            return mean;
        }
        public static void ShowResults(int[] answer)
        {
            //Method that prints the results of returned answers to the screen
            for (int i = 0; i < answer.Length; i++)
            {
                Console.WriteLine($"{i} : {answer[i]}");
            }
        }
        public static int[] RotatingArray(string direction, int offset, int[] inputArray)
        {
            //create new array to where the elements will be populated based on direction given and offset.
            int[] answer = inputArray;
            //leftrotate
            if (direction == "left")
            {
                do
                {
                    //declares a temp value of the first element in inputArray,slides every element left 1,
                    //sets the temp value to the last element of answer.
                    int first = inputArray[0];//holds temp of first element
                    for (int i = 0; i < inputArray.Length - 1; i++)
                    {
                        answer[i] = inputArray[i + 1];
                    }
                    answer[inputArray.Length - 1] = first;//sets last element
                    offset--;//decrement offset
                }
                while (offset != 0);//boolean condition to stop loop

            }
            //rightrotate
            if (direction == "right")
            { 
                do
                {
                    //declares a temp value of the last element in inputArray, slides all elements to the right 1,
                    //sets the temp value to the first element of answer.
                    int last = inputArray[inputArray.Length - 1];//holds temp of last element
                    for (int i = inputArray.Length - 2; i > -1; i--)

                    {
                        answer[i] = answer[i + 1];
                    }
                    answer[0] = last;
                    offset--;
                }
                while (offset != 0);//boolean condition to stop loop
            }
            return answer;
        }
    }
}
