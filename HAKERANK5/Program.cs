﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int sonuc;
        string x = Console.ReadLine();
        
        for(int i =1; i<=10; i++)
        {   
            int ilkDeger = i;
            int ikinciDeger = n;
            sonuc = n*i;
            Console.WriteLine(ikinciDeger+ " "+ "x"+ " " +ilkDeger+" "+ "="+" "+sonuc);
        }
    }
}
