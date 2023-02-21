// See https://aka.ms/new-console-template for more information
using _2;

Console.WriteLine("enter your sales");
decimal Sales = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter your comission porcentage");
float ComissionPorcentage = Convert.ToSingle(Console.ReadLine());

var objEm = new ComissionEmployee() {
    Sales = Sales,
    ComissionPorcentage= ComissionPorcentage,   

        }; 
Console.WriteLine(objEm.ToString());
