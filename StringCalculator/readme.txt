1. Create a simple String calculator with a method signature: 
int add(String numbers)

The method can take up to two numbers, separated by commas, and will return their sum. For an empty string it will return 0, for a single number it will return that number. 


2. Allow the add method to handle an unknown amount of numbers.


3. Allow the Aadd method to handle new lines between numbers (in addition to commas).
The following input is ok: “1\n2,3” (will equal 6)


4. Support different delimiters. To change a delimiter, the beginning of the string will contain a separate line that looks like this:
“//[delimiter]\n[numbers...]” For example: “//;\n1;2” (returns 3).
The first line is optional. all existing scenarios should still be supported


5. Calling add with a negative number will throw an exception “negatives not allowed” - and the negative that was passed. 
If there are multiple negatives, show all of them in the exception message.
