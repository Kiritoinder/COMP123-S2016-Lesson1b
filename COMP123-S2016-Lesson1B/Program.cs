using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Inderjeet Singh
 * Date: 13 May-2016
 * Student ID: 300874118
 * Description: this is the lesson 1B for github
 * 
 * Version: 0.2 - Added GetUserName method
 */




namespace COMP123_S2016_Lesson1B
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserName();
        }

        /**
         *This method reads user names from the console
         *
         * @method GetUserName
         * @return {string} UserName
         * */



        public static string GetUserName()
        {
            // initialize Variable
            string UserName = "";
            Console.Write("Enter User Name");
            UserName = Console.ReadLine();
            
            Console.WriteLine("/n=========================");
            Console.WriteLine("You Entered: " + UserName);
            return UserName;
        }


    }
}
