string[] myArray2 = new string[7];
myArray2[0] = "Monday";
myArray2[1] = "Tuesday";
myArray2[2] = "Wednesday";
myArray2[3] = "Thursday";
myArray2[4] = "Friday";
myArray2[5] = "Saturday";
myArray2[6] = "Sunday";
Console.WriteLine(myArray2[0]);

for (int i=0; i<myArray2.Length; i++){
    Console.WriteLine(myArray[i])
}
list<string> list = new List <string>();
list.Add("Monday");
list.Add("Thuesday");
list.Add("Wednesday");
list.Add("Thursday");
list.Add("Friday");
list.Add("Saturday");
list.Add("Sunday");
for (int i = 0; i<list.Count; i++){
   
    Console.WriteLine(list[i]);
}

Dictionary<string, int> dictionary = new Dictionary <string, int> ();
dictionary[0] = "Monday";
dictionary[1] = "Tuesday";
dictionary[2] = "Wednesday";
dictionary[3] = "Thursday";
dictionary[4] = "Friday";
dictionary[5] = "Saturday";
dictionary[6] = "Sunday";
 for(int i = 0; i< dictionary.Count; i++){
    dictionary[i]=dictionary[i].Substring(0,3);
    Console.WriteLine(dictionary[i]);

 }
