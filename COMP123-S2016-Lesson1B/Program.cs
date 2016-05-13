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
 * Version: 0.6 - Refactored using the ternary operator
 */




namespace COMP123_S2016_Lesson1B
{
    /**
     * This is the driver class for our program
     * 
     * @class program
     
     */
   public class Program
    {
        /**
         * Main method for class program
         *
         * @pram {string[]} args
         * @constructor Main
         */
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
            OutputStringToConsole("Enter User Name", true);
            UserName = Console.ReadLine();

            Console.WriteLine("\n=========================");
            Console.WriteLine("You Entered: " + UserName);
            return UserName;
        }
        /**
         * This method writes a string to console
         * Choose to add new line character
         * @parm {string} outputString
         * @parm {bool} hasNewLine
         * @parm {return} outputString
         */
        public static string OutputStringToConsole(string outputString, bool hasNewLine)
        {
            /**
            if (hasNewLine)
            {
                Console.WriteLine(outputString);

            }
            else
            {
                Console.Write(outputString);
            } */

            // refactored using the ternary operator
           string suffixString = hasNewLine ?"\n": "";
           Console.Write(outputString + suffixString);
            return outputString;


        }
    }
}