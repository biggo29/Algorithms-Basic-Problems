﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BasicProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------
            //print reverse string
            //--------------------
            Reverse.GetReverseString();

            //--------------------------
            //print "I eat" to "I tae"
            //--------------------------
            Reverse.GetReverseStringLastWord();
            
            //-------------------------------------------------------------------------
            // Take input from file where each line contains a integer and find average
            //-------------------------------------------------------------------------
            ReadFile.GetSum();

            //----------------------------
            // Reverse a string word wise.
            //----------------------------
            Reverse.GetReverseStringWordWise();

        }
    }
}
