using System;
using System.Security.Cryptography.X509Certificates;

class test
{
    public static void Main()
    {
        Console.WriteLine("enter one of the numbers from 0 to 6 that represent the days of the week:");
        int a = Convert.ToInt32(Console.ReadLine());
        month_1(a);
        Console.Write("\n");
        month_2(a);
        Console.Write("\n");
        month_3(a);
        Console.Write("\n");
        month_4(a);
        Console.Write("\n");
        month_5(a);
        Console.Write("\n");
        month_6(a);
        Console.Write("\n");
        month_7(a);
        Console.Write("\n");
        month_8(a);
        Console.Write("\n");
        month_9(a);
        Console.Write("\n");
        month_10(a);
        Console.Write("\n");
        month_11(a);
        Console.Write("\n");
        month_12(a);
    }
    private static void month_1(int a)
    {
        Console.WriteLine("farvardin:");
        Console.WriteLine("Saturday Sunday Monday Tuesday Wednesday Thursday Friday");
        if (a == 0)
        {
            int x = 1;
            for (; x < 32;)
            {
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
            }
        }
        else if (a == 1)
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("        ");
                for (int j = 0; j < 6 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 2)
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                ");
                for (int j = 0; j < 5 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 3)
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                        ");
                for (int j = 0; j < 4 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 4)
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                                ");
                for (int j = 0; j < 3 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 5)
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                                        ");
                for (int j = 0; j < 2 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 6)
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                                                ");
                for (int j = 0; j < 1 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
    }
    private static void month_2(int a)
    {
        Console.WriteLine("ordibehesht:");
        Console.WriteLine("Saturday Sunday Monday Tuesday Wednesday Thursday Friday");
        a += 3;
        if (a == 0 | a == 7 )
        {
            int x = 1;
            for (; x < 32;)
            {
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
            }
        }
        else if (a == 1 | a == 8    )
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("        ");
                for (int j = 0; j < 6 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 2 | a == 9    )
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                ");
                for (int j = 0; j < 5 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 3 | a == 10    )
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                        ");
                for (int j = 0; j < 4 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 4 | a == 11    )
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                                ");
                for (int j = 0; j < 3 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 5 | a == 12    )
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                                        ");
                for (int j = 0; j < 2 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 6 | a == 13    )
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                                                ");
                for (int j = 0; j < 1 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
    }
    private static void month_3(int a)
    {
        Console.WriteLine("khordad:");
        Console.WriteLine("Saturday Sunday Monday Tuesday Wednesday Thursday Friday");
        a += 6;
        if (a == 0|a==7)
        {
            int x = 1;
            for (; x < 32;)
            {
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
            }
        }
        else if (a == 1|a==8)
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("        ");
                for (int j = 0; j < 6 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 2|a==9)
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                ");
                for (int j = 0; j < 5 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 3|a==10)
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                        ");
                for (int j = 0; j < 4 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 4|a==11)
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                                ");
                for (int j = 0; j < 3 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 5|a==12)
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                                        ");
                for (int j = 0; j < 2 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 6|a==13)
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                                                ");
                for (int j = 0; j < 1 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
    }
    private static void month_4(int a)
    {
        Console.WriteLine("tir:");
        Console.WriteLine("Saturday Sunday Monday Tuesday Wednesday Thursday Friday");
        a += 2;
        if (a == 0 | a == 7 )
        {
            int x = 1;
            for (; x < 32;)
            {
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
            }
        }
        else if (a == 1|a==8)
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("        ");
                for (int j = 0; j < 6 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 2|a==9)
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                ");
                for (int j = 0; j < 5 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 3|a==10)
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                        ");
                for (int j = 0; j < 4 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 4|a==11)
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                                ");
                for (int j = 0; j < 3 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 5|a==12)
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                                        ");
                for (int j = 0; j < 2 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 6|a==13)
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                                                ");
                for (int j = 0; j < 1 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
    }
    private static void month_5(int a)
    {
        Console.WriteLine("mordad:");
        Console.WriteLine("Saturday Sunday Monday Tuesday Wednesday Thursday Friday");
        a += 5;
        if (a == 0|a==7)
        {
            int x = 1;
            for (; x < 32;)
            {
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
            }
        }
        else if (a == 1 | a == 8    )
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("        ");
                for (int j = 0; j < 6 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 2|a==9)
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                ");
                for (int j = 0; j < 5 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 3 | a == 10    )
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                        ");
                for (int j = 0; j < 4 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 4 | a == 11    )
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                                ");
                for (int j = 0; j < 3 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 5 | a == 12    )
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                                        ");
                for (int j = 0; j < 2 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 6 | a == 13    )
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                                                ");
                for (int j = 0; j < 1 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
    }
    private static void month_6(int a)
    {
        Console.WriteLine("shahrivar:");
        Console.WriteLine("Saturday Sunday Monday Tuesday Wednesday Thursday Friday");
        a += 1;
        if (a == 0|a==7)
        {
            int x = 1;
            for (; x < 32;)
            {
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
            }
        }
        else if (a == 1|a==8)
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("        ");
                for (int j = 0; j < 6 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 2|a==9)
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                ");
                for (int j = 0; j < 5 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 3|a==10)
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                        ");
                for (int j = 0; j < 4 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 4|a==11)
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                                ");
                for (int j = 0; j < 3 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 5|a==12)
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                                        ");
                for (int j = 0; j < 2 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 6|a==13)
        {
            int x = 1;
            for (; x < 32;)
            {
                Console.Write("                                                ");
                for (int j = 0; j < 1 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 32; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
    }
    private static void month_7(int a)
    {
        Console.WriteLine("mehr:");
        Console.WriteLine("Saturday Sunday Monday Tuesday Wednesday Thursday Friday");
        a += 4;
        if (a == 0|a==7)
        {
            int x = 1;
            for (; x < 31;)
            {
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
            }
        }
        else if (a == 1|a==8)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("        ");
                for (int j = 0; j < 6 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 2|a==9)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("                ");
                for (int j = 0; j < 5 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 3|a==10)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("                        ");
                for (int j = 0; j < 4 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 4|a==11)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("                                ");
                for (int j = 0; j < 3 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 5|a==12)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("                                        ");
                for (int j = 0; j < 2 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 6|a==13)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("                                                ");
                for (int j = 0; j < 1 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
    }
    private static void month_8(int a)
    {
        Console.WriteLine("aban:");
        Console.WriteLine("Saturday Sunday Monday Tuesday Wednesday Thursday Friday");
        a += 6;
        if (a == 0 | a == 7)
        {
            int x = 1;
            for (; x < 31;)
            {
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
            }
        }
        else if (a == 1 | a == 8)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("        ");
                for (int j = 0; j < 6 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 2 | a == 9)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("                ");
                for (int j = 0; j < 5 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 3 | a == 10)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("                        ");
                for (int j = 0; j < 4 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 4 | a == 11)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("                                ");
                for (int j = 0; j < 3 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 5 | a == 12)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("                                        ");
                for (int j = 0; j < 2 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 6 | a == 13)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("                                                ");
                for (int j = 0; j < 1 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
    }
    private static void month_9(int a)
    {
        Console.WriteLine("azar:");
        Console.WriteLine("Saturday Sunday Monday Tuesday Wednesday Thursday Friday");
        a += 1;
        if (a == 0 | a == 7)
        {
            int x = 1;
            for (; x < 31;)
            {
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
            }
        }
        else if (a == 1 | a == 8)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("        ");
                for (int j = 0; j < 6 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 2 | a == 9)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("                ");
                for (int j = 0; j < 5 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 3 | a == 10)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("                        ");
                for (int j = 0; j < 4 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 4 | a == 11)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("                                ");
                for (int j = 0; j < 3 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 5 | a == 12)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("                                        ");
                for (int j = 0; j < 2 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 6 | a == 13)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("                                                ");
                for (int j = 0; j < 1 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
    }
    private static void month_10(int a)
    {
        Console.WriteLine("dey:");
        Console.WriteLine("Saturday Sunday Monday Tuesday Wednesday Thursday Friday");
        a += 3;
        if (a == 0 | a == 7)
        {
            int x = 1;
            for (; x < 31;)
            {
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
            }
        }
        else if (a == 1 | a == 8)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("        ");
                for (int j = 0; j < 6 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 2 | a == 9)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("                ");
                for (int j = 0; j < 5 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 3 | a == 10)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("                        ");
                for (int j = 0; j < 4 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 4 | a == 11)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("                                ");
                for (int j = 0; j < 3 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 5 | a == 12)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("                                        ");
                for (int j = 0; j < 2 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 6 | a == 13)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("                                                ");
                for (int j = 0; j < 1 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
    }
    private static void month_11(int a)
    {
        Console.WriteLine("bahman:");
        Console.WriteLine("Saturday Sunday Monday Tuesday Wednesday Thursday Friday");
        a += 5;
        if (a == 0 | a == 7)
        {
            int x = 1;
            for (; x < 31;)
            {
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
            }
        }
        else if (a == 1 | a == 8)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("        ");
                for (int j = 0; j < 6 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 2 | a == 9)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("                ");
                for (int j = 0; j < 5 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 3 | a == 10)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("                        ");
                for (int j = 0; j < 4 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 4 | a == 11)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("                                ");
                for (int j = 0; j < 3 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 5 | a == 12)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("                                        ");
                for (int j = 0; j < 2 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 6 | a == 13)
        {
            int x = 1;
            for (; x < 31;)
            {
                Console.Write("                                                ");
                for (int j = 0; j < 1 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 31; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
    }
    private static void month_12(int a)
    {
        Console.WriteLine("esfand:");
        Console.WriteLine("Saturday Sunday Monday Tuesday Wednesday Thursday Friday");
        if (a == 0 | a == 7)
        {
            int x = 1;
            for (; x < 30;)
            {
                for (int j = 0; j < 7 && x < 30; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
            }
        }
        else if (a == 1 | a == 8)
        {
            int x = 1;
            for (; x < 30;)
            {
                Console.Write("        ");
                for (int j = 0; j < 6 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 30; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 2 | a == 9)
        {
            int x = 1;
            for (; x < 30;)
            {
                Console.Write("                ");
                for (int j = 0; j < 5 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 30; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 3 | a == 10)
        {
            int x = 1;
            for (; x < 30;)
            {
                Console.Write("                        ");
                for (int j = 0; j < 4 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 30; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 4 | a == 11)
        {
            int x = 1;
            for (; x < 30;)
            {
                Console.Write("                                ");
                for (int j = 0; j < 3 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 30; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 5 | a == 12)
        {
            int x = 1;
            for (; x < 30;)
            {
                Console.Write("                                        ");
                for (int j = 0; j < 2 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 30; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
        else if (a == 6 | a == 13)
        {
            int x = 1;
            for (; x < 30;)
            {
                Console.Write("                                                ");
                for (int j = 0; j < 1 && x < 7; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
                Console.Write("\n");
                for (int j = 0; j < 7 && x < 30; j++)
                {
                    Console.Write("   ");
                    Console.Write(x);
                    Console.Write("\t");
                    x++;
                }
            }
        }
    }
}