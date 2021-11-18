using System;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            string  revs = "";
           
            for (int i = str.Length - 1; i >= 0; i--) 
            {
                revs += str[i].ToString();
            }
            if (revs == str) 
            {
                return true;
            }
            else
            {
                return false;
            }
            
        } 
    }
}
