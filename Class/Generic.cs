using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace CSharp_Advanced_Topics.Clases
{
    public class Generic
    {
        public Generic()
        {

        }

        public void MyList()
        {
            List<int> intList = new List<int>();
            intList.Add(3);
            intList.Add(4);
            intList.Add(13);
            foreach (int item in intList)
            {
                Console.WriteLine(item);

            }
        }

        public void MyListDos()
        {
            List<int> mylist = test(new List<int>(new int[] { 10, 22, 35, 47, 53, 67, 68, 69 }));
            foreach (var i in mylist)
            {
                Console.Write(i.ToString() + " ");
            }
        }
        public static List<int> test(List<int> nums)
        {
            return nums.Where(n => n % 10 != 7).ToList();
        }
    }
}
