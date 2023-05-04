
// Given a random word, users have 6 wrong answers to guess the word
// If the character user guesses exist in the word, all occurrences of the character is filled in
// If the character user guesses does not exist in the word, it is added to the "wrong guesses" list and the user has one less life
// User wins the game if they correctly guesses the word before they run out of lives
// User loses the game if they run out of lives
// Objective

// Create a hangman game with C# Console Application with a partner
// You'll pair program this together
// Deploy this to your azure virtual machine and run from it


//Pick a random word from a list of words
//  ----> America (word)
// _m--i-a (show this to user) (sparseword)
// Gues a letter one at time
//if letter is in word, add character at the position to the sparseword
//  ---> You guess right statement

// if letter is not in word
// ----> Letter not in the word
// If user misses letter 6 times, game ends
using System;
using System.Collections.Generic;
using System.Linq;

string[] MysteryWord = new string[7];

//Country, shoe types, NBA teams
MysteryWord[0] = "Bangladesh";
MysteryWord[1] = "Jordans";
MysteryWord[2] = "Lakers";
MysteryWord[3] = "Ostrich";
MysteryWord[4] = "Candle";
MysteryWord[5] = "Algorithm";
MysteryWord[6] = "Ireland";

for (int i = 0; i < MysteryWord.Length; i++){
    MysteryWord[i] = MysteryWord[i].ToUpper();
}

Random random = new Random();

//Selects a number at random
int randomIndex = random.Next(0, MysteryWord.Length);
string KnownWord = MysteryWord[randomIndex];
//Console.WriteLine(KnownWord);

//Convert string to char array
char[] WordToGuess = KnownWord.ToCharArray();



//Randomly set some of the letters to _
for (int i = 0; i < KnownWord.Length; i++)
{
    //generate a random number
    int randomNumber = random.Next(0, KnownWord.Length);
    if (randomNumber <= KnownWord.Length)
    {
        WordToGuess[randomNumber] = '_';

            //Console.WriteLine(WordToGuess);
    }
}
//Convert char array back to string
string shownWord = new string(WordToGuess);

Console.WriteLine(shownWord);


//Console.WriteLine("Can you guess the missing letters in this Mystery word? " + WordToGuess);




Dictionary<char, int> MissingDict = new Dictionary<char, int>();


for (int k=0; k <KnownWord.Length; k++ ){

    if (shownWord[k]=='_'){
        MissingDict.TryAdd(KnownWord[k],k);
    }

}
//Console.WriteLine(MissingDict.keys);

var MissingLettrers = MissingDict.Keys.Except(shownWord);
string missingLettersString = new string(MissingLettrers.ToArray());


//ten chances for failure to type the right letter
int NumChances =6;
char [] Shownwords = shownWord.ToCharArray();
for (int j=0; j <20 ; j++ ){
    Console.Write("Type a missing character : ");
    char LetterTyped = Console.ReadKey().KeyChar;
    char upperCaseLetter = char.ToUpper(LetterTyped);

     //LetterTyped = h, missingLettersString =Addi(h)
    if (missingLettersString.Contains(upperCaseLetter)){
        Shownwords[MissingDict[upperCaseLetter]] = upperCaseLetter;
        Console.WriteLine(" You guess it right ");
        Console.WriteLine("Guess Another Letter");

        string GuessedWord = new string(Shownwords);
        Console.WriteLine("Your Progress " + GuessedWord);
        //Console.WriteLine("The WordToGuess word is " + KnownWord);


        if (GuessedWord == KnownWord){
        Console.WriteLine("You won the Game");
        break;
    }
        }
    else{
        NumChances--;
        Console.WriteLine(" You got it wrong, you have " + NumChances + " chances ");
        if (NumChances==0){
            Console.WriteLine("You don't have anymore chances, You lost the Game");
            break;
        }
    }




}



