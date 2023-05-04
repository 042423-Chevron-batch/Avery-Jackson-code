// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("What's your name?");

//variable declaration and assignment 
string name = Console.ReadLine();

//String concatenation
Console.WriteLine("Hello " + name + "!");

Console.WriteLine("How old are you?");
string ageInput = Console.ReadLine();
int age = int.Parse(ageInput);

if ( age < 30){
    Console.WriteLine("you young'un!");
}else if ( age < 50 ){
    Console.WriteLine("Almost to 50");

}
