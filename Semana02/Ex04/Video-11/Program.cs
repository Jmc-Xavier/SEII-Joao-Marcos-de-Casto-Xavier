//Video 11- Class

Console.WriteLine(wolfRat.Name);
Console.WriteLine(FRat.IsRadioactive);

using System;
namespace Video_11{
    class Program{
        static void Main(string[] args){
            Rat wolfRat = new Rat();
            Rat FRat = new Rat();

            wolfRat.Name = "Wolf Rat";
            wolfRat.Number = 10000;
            wolfRat.IsRadioactive = false;

            FRat.Name = "FRA";
            FRat.Number = 50;
            FRat.IsRadioactive = true;

            Console.WriteLine(wolfRat.Name);
            Console.WriteLine(FRat.IsRadioactive);
        }}}