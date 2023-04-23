# Description
This is a C# program that shortens an input array of strings to an output array of strings with a length less than or equal to 3 characters. The program does not use collections, only arrays.

# How does it work
The program takes an input array of strings and returns an output array of strings which length is less or equal to 3 symbols.
To use the program, call the ShortenStringArray method with the input array as a parameter:
string[] inputArray = { "hello", "2", "world", ":-)" };
ShortenStringArray(inputArray);
This will output the shortened string array:
2, :-)