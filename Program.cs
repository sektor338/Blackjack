List<string> spades = new List<string> { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
List<string> hearts = new List<string> { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
List<string> diamonds = new List<string> { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
List<string> clubs = new List<string> { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};




List<List<string>> fullDeck = new List<List<string>> {spades, hearts, diamonds, clubs};
List<string> playerDeck = new List<string>();
List<string> hostDeck = new List<string>();

/*

diamonds.Remove("2");

for (int i = 0; i < deck.Count; i++)
{
    for (int j = 0; j < deck[i].Count; j++)
    {
        Console.Write(deck[i][j] + "\t");
    }
    Console.WriteLine();
}*/




while (true) {
    Console.WriteLine("Kezdődjék a játék!");

    Random rng = new Random();
    string cardType;


    for (int i = 0; i < 2; i++)
    {
        int rngType = rng.Next(1, 5);
        int rng1 = rng.Next(1, 5);
        int rng2 = rng.Next(1, 14);


        switch (rngType)
        {
            case 1:
                cardType = "Spades";
                if (rng2 == 1)
                {
                    spades.Remove("Ace");
                    playerDeck.Add(cardType + " " + "Ace");
                }
                else if (rng2 >= 2 && rng2 <= 10)
                {
                    spades.Remove(Convert.ToString(rng2));
                    playerDeck.Add(cardType + " " + Convert.ToString(rng2));
                }
                else if (rng2 == 11)
                {
                    spades.Remove("Jack");
                    playerDeck.Add(cardType + " " + "Jack");
                }
                else if (rng2 == 12)
                {
                    spades.Remove("Queen");
                    playerDeck.Add(cardType + " " + "Queen");
                }
                else
                {
                    spades.Remove("King");
                    playerDeck.Add(cardType + " " + "King");
                }
                break;
            case 2:
                cardType = "Hearts";
                if (rng2 == 1)
                {
                    hearts.Remove("Ace");
                    playerDeck.Add(cardType + " " + "Ace");
                }
                else if (rng2 >= 2 && rng2 <= 10)
                {
                    hearts.Remove(Convert.ToString(rng2));
                    playerDeck.Add(cardType + " " + Convert.ToString(rng2));
                }
                else if (rng2 == 11)
                {
                    hearts.Remove("Jack");
                    playerDeck.Add(cardType + " " + "Jack");
                }
                else if (rng2 == 12)
                {
                    hearts.Remove("Queen");
                    playerDeck.Add(cardType + " " + "Queen");
                }
                else
                {
                    hearts.Remove("King");
                    playerDeck.Add(cardType + " " + "King");
                }
                break;
            case 3:
                cardType = "Diamonds";
                if (rng2 == 1)
                {
                    diamonds.Remove("Ace");
                    playerDeck.Add(cardType + " " + "Ace");
                }
                else if (rng2 >= 2 && rng2 <= 10)
                {
                    diamonds.Remove(Convert.ToString(rng2));
                    playerDeck.Add(cardType + " " + Convert.ToString(rng2));
                }
                else if (rng2 == 11)
                {
                    diamonds.Remove("Jack");
                    playerDeck.Add(cardType + " " + "Jack");
                }
                else if (rng2 == 12)
                {
                    diamonds.Remove("Queen");
                    playerDeck.Add(cardType + " " + "Queen");
                }
                else
                {
                    diamonds.Remove("King");
                    playerDeck.Add(cardType + " " + "King");
                }
                break;
            case 4:
                cardType = "Clubs";
                if (rng2 == 1)
                {
                    clubs.Remove("Ace");
                    playerDeck.Add(cardType + " " + "Ace");
                }
                else if (rng2 >= 2 && rng2 <= 10)
                {
                    clubs.Remove(Convert.ToString(rng2));
                    playerDeck.Add(cardType + " " + Convert.ToString(rng2));
                }
                else if (rng2 == 11)
                {
                    clubs.Remove("Jack");
                    playerDeck.Add(cardType + " " + "Jack");
                }
                else if (rng2 == 12)
                {
                    clubs.Remove("Queen");
                    playerDeck.Add(cardType + " " + "Queen");
                }
                else
                {
                    clubs.Remove("King");
                    playerDeck.Add(cardType + " " + "King");
                }
                break;
        }
    }



    foreach (var item in playerDeck)
    {
        Console.Write(item + "\t");
    }


    string playerInput = Console.ReadLine();


    if (playerInput == "exit")
    {
        break;
    }
    





}

