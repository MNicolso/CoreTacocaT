# CoreTacocaT
CoreTacocaT is a Coder Foundry challenge done with the .net core framework. 
Basic function is to identify palindromes.

## Installation
Libraries required:
 Bootstrap v4.3.1 [Here](https://getbootstrap.com/)
  jQuery JavaScript Library v3.5.1 [Here](https://jquery.com/)
## Usage
```C#
   var word = inputWord.Replace(" ", "").ToLower(); //cleans user input
            var reverseWord = string.Join("", word.Reverse().ToArray());
            if(word==reverseWord)
            {
                resultTwo.Append(", that is a palindrome!"); //identifies palindrome
            }
            else
            {
                resultTwo.Append(", that is a palindon'T!");
            }
            @ViewData["ResultTwo"] = resultTwo; //output
           @ViewData["Result"] = reverseWord;
```
