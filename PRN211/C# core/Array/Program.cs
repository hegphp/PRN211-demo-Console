using System;

namespace Array
{
    internal class Program
    {
        public static void sumArray(out int s, params int[] list) {  //truyền tham số với out và param
            //ngoài ra còn tham số ref, điểm khác biệt giữa ref và out là biến truyền vào từ khóa out không cần khởi tạo giá trị ban đầu
            s = 0;
            for (int i = 0; i < list.Length; i++)
            {
                s += list[i];
            }
        }
        static void Main(string[] args)
        {
            int s;
            sumArray(out s, 1, 2, 3, 4);
            Console.WriteLine(s);
            //declare and initilize an array
            int[] list = { 5, 6, 7, 8, 9 };
            sumArray(out s, list);
            Console.WriteLine("\nSum of second array: {0}",s);
            //String join: concatenates an array of strings.
            Console.WriteLine("Original sequence: "+string.Join(" ",numbers));
            ref int value = ref findNumber(3);
            value *= 2;
            Console.WriteLine("New sequence: "+string.Join(" ",numbers));

            //Create tuples
            (String myString, int[] myList) myValues = ("Hello World", numbers);
            Console.WriteLine($"My String: {myValues.myString}");
            Console.WriteLine($"My List: {string.Join(" ", myValues.myList)}");
        }
        static int[] numbers = { 1, 2, 3, 4, 5 };
        public static ref int findNumber(int target) 
        {
            bool flag = true;
            ref int value = ref numbers[0];
            for(int i = 0; i < numbers.Length && flag == true; i++) 
            {
                if (numbers[i] == target) { 
                    value= ref numbers[i];
                    flag = false;
                }
            }
            return ref value;
        }
    }
}
