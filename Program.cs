//start main

DisplayMenu();
string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendation(enjoymentLevel);
string game = GetGameRecommendation(stadium);

if (game == "invalid choice"){
    System.Console.WriteLine("You must enter one of the given choices.");
}
else{
System.Console.WriteLine($"You should watch {game} play at {stadium}.");
}
//end main


static void DisplayMenu(){
    Console.Clear();
    System.Console.WriteLine("What kind of game do you want to watch?");
    System.Console.WriteLine("1. Boring\n2. Average\n3. Fun\n4. Epic");
}

static string GetEnjoymentLevel(){
    System.Console.WriteLine("Enter your choice");
    return Console.ReadLine().ToLower();
}

static string GetStadiumRecommendation(string enjoymentLevel){ 
    if (enjoymentLevel == "boring"){
        return "Neyland Stadium";
    }
    else if (enjoymentLevel == "average"){
        return "Jordan-Hare Stadium";
    }
    else if (enjoymentLevel == "fun"){
        return "Tiger Stadium";
    }
    else if (enjoymentLevel == "epic"){
        return "Saban Field at Bryant-Denny Stadium";
    }
    else {
        return "invalid choice";
    }
}

static string GetGameRecommendation(string stadium){
    if (stadium == "Neyland Stadium"){
        return "Kent State";
    }
    else if (stadium == "Jordan-Hare Stadium"){
        return "Kentucky";
    }
    else if (stadium == "Tiger Stadium"){
        return "Alabama";
    }
    else if (stadium == "Saban Field at Bryant-Denny Stadium"){
        return "Auburn";
    }
    else {
        return "invalid choice";
    }
}


