using System;

namespace CSharpLabOne
{
    class Program
    {
        //make an array
        public static char[,] make_forward()
        {
            char[,] pixel = new char[4, 13];
            pixel[0, 0] = ' ';
            pixel[0, 1] = ' ';
            pixel[0, 2] = '_';
            pixel[0, 3] = '_';
            pixel[0, 4] = '_';
            pixel[0, 5] = '_';
            pixel[0, 6] = '_';
            pixel[0, 7] = '_';
            pixel[0, 8] = ' ';
            pixel[0, 9] = ' ';
            pixel[0, 10] = ' ';
            pixel[0, 11] = ' ';
            pixel[0, 12] = ' ';
            pixel[1, 0] = ' ';
            pixel[1, 1] = '/';
            pixel[1, 2] = '|';
            pixel[1, 3] = '_';
            pixel[1, 4] = '|';
            pixel[1, 5] = '|';
            pixel[1, 6] = '_';
            pixel[1, 7] = '\\';
            pixel[1, 8] = '\'';
            pixel[1, 9] = '.';
            pixel[1, 10] = '_';
            pixel[1, 11] = '_';
            pixel[1, 12] = ' ';
            pixel[2, 0] = '(';
            pixel[2, 1] = ' ';
            pixel[2, 2] = ' ';
            pixel[2, 3] = ' ';
            pixel[2, 4] = '_';
            pixel[2, 5] = ' ';
            pixel[2, 6] = ' ';
            pixel[2, 7] = ' ';
            pixel[2, 8] = ' ';
            pixel[2, 9] = '_';
            pixel[2, 10] = ' ';
            pixel[2, 11] = '_';
            pixel[2, 12] = '\\';
            pixel[3, 0] = '=';
            pixel[3, 1] = '\'';
            pixel[3, 2] = '-';
            pixel[3, 3] = '(';
            pixel[3, 4] = '_';
            pixel[3, 5] = ')';
            pixel[3, 6] = '-';
            pixel[3, 7] = '-';
            pixel[3, 8] = '(';
            pixel[3, 9] = '_';
            pixel[3, 10] = ')';
            pixel[3, 11] = '-';
            pixel[3, 12] = '\'';
            return pixel;
        }

        //make_mirror method to mirror an array
        public static char[,] make_mirror(char[,] arr)
        {

            char[,] mirror = new char[4, 13];

            for (int i = 0; i < mirror.GetLength(0); i++)
            {
                for (int j = 0; j < mirror.GetLength(1); j++)
                {

                    mirror[i, j] = arr[i, mirror.GetLength(1) - 1 - j];

                    if (mirror[i, j].Equals('('))
                    {

                        mirror[i, j] = ')';

                    }
                    else if (mirror[i, j].Equals(')'))
                    {

                        mirror[i, j] = ')';

                    }
                    else if (mirror[i, j].Equals('/'))
                    {

                        mirror[i, j] = '\\';

                    }
                    else if (mirror[i, j].Equals('\\'))
                    {

                        mirror[i, j] = '/';

                    }
                }
            }

            return mirror;
        }


        //Main method
        public static void Main(string[] args)
        {

            //Create new empty arrays
            char[,] arr1 = new char[4, 13];
            char[,] arr2 = new char[4, 13];


            //create forward array
            arr1 = make_forward();


            //display forward array
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.Write(arr1[i, j]);

                }

                Console.WriteLine();
            }


            //creating mirrored array
            arr2 = make_mirror(arr1);

            //display mirrored array
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write(arr2[i, j]);

                }

                Console.WriteLine();
            }

            //display both arrays
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write(arr1[i, j]);

                }

                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write(arr2[i, j]);

                }

                Console.WriteLine();
            }

        }
    }
}
