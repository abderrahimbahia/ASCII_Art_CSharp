# ASCII_Art_CSharp
Background:
In this lab, you are going to draw some Ascii Art using a two dimensional array. When dealing with multi-dimensional arrays, you’ll typically use nested loops (i.e. a loop within a loop). The outer loop typically iterates over the rows of the array, while the inner loop typically iterates over the columns.
A two dimensional array uses two indexes. The first index represents the row number, while the second index represents the column. For example: myArray[0][1] refers to the first row (0) and the second column (1).
Your Tasks:
1) Open your IDE and start a new project.
2) Copy and paste the appropriate version of the make_forward() method from page 3 below. This
method creates and returns a two dimensional array of characters with some Ascii Art in it.
3) In your main method, create a two dimensional array of characters with 4 rows and 13 columns.
4) Call the make_forward() method and store the result in your new array.
5) Using loops, print out the array contents character by character. You should see Ascii Art.
6) Write a new method called make_mirror(). It should take a two dimensional array as a
parameter and return a mirrored version of that 2D array. i.e. The contents of each row should be reversed as follows:
a) Input array cell [0][0] should be copied to cell [0][12] in the return array, likewise cell [0][1] should be copied to cell [0][11] ... cell [0][12] should be copied to cell [0][0]
b) Cell [1][0] will be copied to cell [1][12], cell [1][1] should be copied to cell [1][11] etc...
c) The same is true for the other two rows.
d) As you copy each character, check the table below to see if the character itself needs to
be reversed. If the character is not in the table, copy it as normal, but if it is in the table, replace it with the “Mirrored” character. You will need ​if statements​ for this.
Old Character Mirrored Character
() )(
/ \ (backslash - above enter key) \ (backslash - above enter key) /
Note​: The backslash (\) has special meaning. It means to “escape” the next character that’s typed. For example, if you want to set a variable x to ‘ you would write: ​char x=’\’’​. This is because quotes are used when specifying a character. If you wish to print or compare a backslash itself, you’ll need to escape it, so you’ll actually have to write \\. So, for example, to set a variable x to \, you’d write
char ​x=’\\’​. You’ll need this when swapping forward slashes and backslashes. There are examples of escaping in the provided make_forward() method.
                    
 7) In your main method, create another 2d array of characters of the same size (4x13). Call the make_mirror() method, passing it the original array returned from the make_forward() method. Store the result in your new array.
8) Print out the mirrored 2D array.
9) Finally, in your main method, print the forward and mirrored image on the same lines, so that
they face each other as if having a head on collision...see below:
Expected Results:
If you complete the lab correctly, you should see:
______ /|_||_\'.__
( _ __\ ='-(_)--(_)-'
______ __.'/_||_|\
/__ _ ) '-(_)--(_)-'=
______
/|_||_\'.__ __.'/_||_|\
( _ __\/__ _ ) ='-(_)--(_)-''-(_)--(_)-'=
Submitting your answer:
Please follow the posted submission guidelines here:
https://ccse.kennesaw.edu/fye/submissionguidelines.php
Ensure you submit before the deadline listed on the lab schedule for CSE1322L here:
https://ccse.kennesaw.edu/fye/courseschedules.php
______
  make_forward() code for Java and C# on next page:
 
  Java C#
public static char[][] make_forward() {
char[][] pixel = new char[4][13]; pixel[0][0]=' ';
pixel[0][1]=' ';
pixel[0][2]='_';
pixel[0][3]='_'; pixel[0][4]='_'; pixel[0][5]='_'; pixel[0][6]='_'; pixel[0][7]='_'; pixel[0][8]=' '; pixel[0][9]=' '; pixel[0][10]=' '; pixel[0][11]=' '; pixel[0][12]=' '; pixel[1][0]=' '; pixel[1][1]='/'; pixel[1][2]='|'; pixel[1][3]='_'; pixel[1][4]='|'; pixel[1][5]='|'; pixel[1][6]='_'; pixel[1][7]='\\'; pixel[1][8]='\''; pixel[1][9]='.'; pixel[1][10]='_'; pixel[1][11]='_'; pixel[1][12]=' '; pixel[2][0]='('; pixel[2][1]=' '; pixel[2][2]=' '; pixel[2][3]=' '; pixel[2][4]='_'; pixel[2][5]=' '; pixel[2][6]=' '; pixel[2][7]=' '; pixel[2][8]=' '; pixel[2][9]='_'; pixel[2][10]=' '; pixel[2][11]='_'; pixel[2][12]='\\'; pixel[3][0]='='; pixel[3][1]='\''; pixel[3][2]='-'; pixel[3][3]='('; pixel[3][4]='_'; pixel[3][5]=')'; pixel[3][6]='-'; pixel[3][7]='-'; pixel[3][8]='('; pixel[3][9]='_'; pixel[3][10]=')'; pixel[3][11]='-'; pixel[3][12]='\''; return pixel;
}
public static char[,] make_forward() {
char[,] pixel = new char[4,13]; pixel[0,0]=' ';
pixel[0,1]=' ';
pixel[0,2]='_';
pixel[0,3]='_'; pixel[0,4]='_'; pixel[0,5]='_'; pixel[0,6]='_'; pixel[0,7]='_'; pixel[0,8]=' '; pixel[0,9]=' '; pixel[0,10]=' '; pixel[0,11]=' '; pixel[0,12]=' '; pixel[1,0]=' '; pixel[1,1]='/'; pixel[1,2]='|'; pixel[1,3]='_'; pixel[1,4]='|'; pixel[1,5]='|'; pixel[1,6]='_'; pixel[1,7]='\\'; pixel[1,8]='\''; pixel[1,9]='.'; pixel[1,10]='_'; pixel[1,11]='_'; pixel[1,12]=' '; pixel[2,0]='('; pixel[2,1]=' '; pixel[2,2]=' '; pixel[2,3]=' '; pixel[2,4]='_'; pixel[2,5]=' '; pixel[2,6]=' '; pixel[2,7]=' '; pixel[2,8]=' '; pixel[2,9]='_'; pixel[2,10]=' '; pixel[2,11]='_'; pixel[2,12]='\\'; pixel[3,0]='='; pixel[3,1]='\''; pixel[3,2]='-'; pixel[3,3]='('; pixel[3,4]='_'; pixel[3,5]=')'; pixel[3,6]='-'; pixel[3,7]='-'; pixel[3,8]='('; pixel[3,9]='_'; pixel[3,10]=')'; pixel[3,11]='-'; pixel[3,12]='\''; return pixel;
}
