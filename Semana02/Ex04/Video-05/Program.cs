//Vídeo-05 Arrays

//Create
string[] favoriteRats = ["fancy rat","browrat","radiactive rat","wolf rat"];

//Uptade
//favoriteRats[0] ="fancy rat";
var newFavoriteRats = favoriteRats.Where((e) =>.StartsWith("b"));
foreach (var rat in favoriteRats)

{
    Console.WriteLine(rat);
}

