using System;
using System.Collections.Generic;
using System.Text;

namespace AmeejaCodePractice
{
   public class practice
    {
        public void swapint()
        {
            int a = 20;
            int b = 15;
           
            a = a + b;//35
            b = a - b;//35-15=20
            a = a - b;//35-20=15
            Console.WriteLine("after swap:" + a +"\t"+ b);
        }

        public void swapintUsingThirdparty()
        {
            int a = 20;
            int b = 15;
            int c;
            c = a;
            a = b;
            b = c ;
            Console.WriteLine("after swap:" + a + "\t" + b);
        }
        public void swapstring()
        {
            string a ="jaaan";
            string  b = "amee";
            string c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("after swap:" + a + "\t" + b);
        }
        public void anagram()
        {
            string a = "god";
            string b = "dog";
            char[] ch1 = a.ToLower().ToCharArray();
            char[] ch2 = b.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("if the string is anagrom");
            }
            else
            {
                Console.WriteLine("if the string is not anagrom");
            }
        }
     public void fibinacciseries()
        {
            int a = 0;
            int b = 1;
            Console.WriteLine(a+"\t"+b);
            int num = int.Parse(Console.ReadLine());
            for (int i = 2;i <= num;i++)
            {
                int c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
     }  
        public void reverseint()
        {
            Console.Write("plzz enter the num:");
            int num = int.Parse(Console.ReadLine());
            int revesre=0;
            while (num > 0)
            {
                int remainder = num % 10;
                revesre = (revesre * 10) + remainder;
                num = num / 10;
            }
            Console.WriteLine(revesre);
        }
        public void ReverseString()
        {
            string name = "Amee";
            string reverse = string.Empty;
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse += name[i];

            }
            Console.WriteLine("string reverse:" + reverse);
        }
        public void polyndromint()
        {
            Console.Write("plzz enter the num:");
            int num = int.Parse(Console.ReadLine());
            int revesre = 0;
           int  temp = num;
            while (num > 0)
            {
                int remainder = num % 10;
                revesre = (revesre * 10) + remainder;
                num = num / 10;
               
                
                if (temp == revesre)
                {
                    Console.Write("if the num int is polyndrom ");//121
                }
                else
                {
                    Console.Write("if the num int is not polyndrom ");//123
                }
            }
           
        }
        public void firstwordReverse()
        {

            Console.WriteLine("please enter the string:");
            string name = Console.ReadLine();
            String[] sentence = name.Split(" ");
            String reverseString = " ";

            string reverse = "";
            for (int i = 0; i < sentence.Length; i++)
            {
                String word = sentence[i];

                String reverseWord = " ";
                if (i == 0)
                {
                    for (int j = word.Length - 1; j >= 0; j--)
                    {
                        reverseWord = reverseWord + word[j];
                    }
                }
                else
                {
                    reverseWord = reverseWord + sentence[i];
                }


                reverseString = reverseString + reverseWord + " ";
            }
            Console.WriteLine("reverse string name:" + reverseString);

        }
        public void RSmiddleWord()
        {
            Console.WriteLine("please enter the string:");
            string name = Console.ReadLine();
            String[] sentence = name.Split(" ");
            String reverseString = " ";

            string reverse = "";
            for (int i = 0; i < sentence.Length; i++)
            {
                String word = sentence[i];

                String reverseWord = " ";
                if (i == sentence.Length / 2)
                {
                    for (int j = word.Length - 1; j >= 0; j--)
                    {
                        reverseWord = reverseWord + word[j];
                    }
                }
                else
                {
                    reverseWord = reverseWord + sentence[i];
                }


                reverseString = reverseString + reverseWord + " ";
            }
            Console.WriteLine("reverse string name:" + reverseString);
        }
        public void ReverseStringSentence()
        {
            Console.WriteLine("please enter the string:");
            string name = Console.ReadLine();
            String[] sentence = name.Split(" ");
            String reverseString = " ";

            for (int i = 0; i < sentence.Length; i++)
            {
                String word = sentence[i];

                String reverseWord = " ";
                if (i == sentence.Length - 1)
                {
                    for (int j = word.Length - 1; j >= 0; j--)
                    {
                        reverseWord = reverseWord + word[j];
                    }
                }
                else
                {
                    reverseWord = reverseWord + sentence[i];
                }


                reverseString = reverseString + reverseWord + " ";
            }
            Console.WriteLine("reverse string name:" + reverseString);
        }
        public void EvenorOddNum()
        {
            int num = int.Parse(Console.ReadLine());
            int quocient = num / 2;
            if (quocient * 2 == num)
            {
                Console.WriteLine("if the num is even:" + num);//even no =2,4,6,8etc
            }
            else
            {
                Console.WriteLine("if the num is odd:" + num);//odd no is i,3,5,7,11 etc
            }
        }
        public  void primeno() 
        {
            int num, i, m = 0, flag = 0;
            Console.Write("Enter the Number to check Prime: ");
            num = int.Parse(Console.ReadLine());
            m = num / 2;
            for (i = 2; i <= m; i++)
            {
                if (num % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Number is Prime.");
        }
        public  void factorial()
        {
            int i, fact = 1, number;
            Console.Write("Enter any Number: ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);
        }
        public  void angastrom()
        {
            int n, r, sum = 0, temp;
            Console.Write("Enter the Number= ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Armstrong Number.");
            else
                Console.Write("Not Armstrong Number.");
        }
    }
}

