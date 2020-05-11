using System;

namespace SouthAfricaIDNumber
{
    //Our South African ID number is a very important part of our lives and is the key to our access to banking facilities
    //    and our daily interaction with retail, medical aid, insurance and travel. This information will help you understand
    //    what the numbers in your South African ID represents.

    // ***************************************************************************************************************************************
    // A South African ID number is a 13-digit number which is defined by the following format: YYMMDDSSSSCAZ.
    // ***************************************************************************************************************************************

    // * The first 6 digits(YYMMDD) are based on your date of birth. 20 February 1992 is displayed as 920220.
    // *  The next 4 digits(SSSS) are used to define your gender.Females are assigned numbers in the range 0000-4999 and males from 5000-9999
    // * The next digit (C) shows if you're an SA citizen status with 0 denoting that you were born a SA citizen and 1 denoting that you're a permanent resident.


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
