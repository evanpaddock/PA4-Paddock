using PA4;

string gameChoice = Menu.DaMainMenu();

while(Menu.CanYouRead(gameChoice)){
    gameChoice = Menu.DaMainMenu();
}

GamePlay.RunGame(gameChoice);

// System.Console.WriteLine("\n\nWhat is your name brave challenger?");
// string player1 = Console.ReadLine();
// System.Console.WriteLine(player1);

