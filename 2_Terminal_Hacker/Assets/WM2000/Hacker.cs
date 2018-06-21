using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    //game state
    int level;
    enum Screen { MainMenu, Password, Win};
    Screen currentScreen;

	// Use this for initialization
	void Start () {
                
        ShowMainMenu(); 
        
	}
    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        level = 0;
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?\n");
        Terminal.WriteLine("Press 1 for Library");
        Terminal.WriteLine("Press 2 for the Police Station");
        Terminal.WriteLine("Press 3 for the Pentagon\n");
        Terminal.WriteLine("Enter your selection:");
    }

    void OnUserInput(string input)
    {
        if (input == "menu") //can always return to main menu
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }

    }

    void RunMainMenu(string input)
    {
        if ("1" == input)
        {
            level = 1;
            StartGame();

        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            StartGame();
        }

        else if (input == "007")
        {
            Terminal.WriteLine("Welcome Mr Bond");
            level = 3;
            StartGame();
        }
        else
        {
            Terminal.WriteLine("Please enter a valid response");
        }
    }

    void StartGame()
    {
        Terminal.WriteLine("You have chosen level " + level);
        currentScreen = Screen.Password;
    }
   
}
