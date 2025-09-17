#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>

using namespace std;

enum enRockPaperScissors {Rock = 1, Paper = 2, Scissors = 3 };

void Tab() 
{
	cout << "\t\t\t";
}

void ShowGameResult(short player1WonTimes, short computerWonTimes, short drawTimes, short numOfRounds) 
{
	Tab();
	cout << "-------------------- [Game Result ]-----------------------\n" << endl;
	Tab();
	cout << "Game Rounds\t  : " << numOfRounds << endl;
	Tab();
	cout << "Player1 Won times : " << player1WonTimes << endl;
	Tab();
	cout << "Computer Won times: " << computerWonTimes << endl;
	Tab();
	cout << "Draw times\t  : " << drawTimes << endl;
	
	Tab();
	if (player1WonTimes == computerWonTimes) 
	{
		cout << "Final Winner\t  : " << "No Winner" << endl;
		system("color 6F");
	}
	else if (player1WonTimes > computerWonTimes) 
	{
		cout << "Final Winner\t  : " << "Player1" << endl;
		system("color 2F");
	}
	else 
	{
		cout << "Final Winner\t  : " << "Computer" << endl;
		system("color 4F");
	}

	cout << endl;
}

void ShowGameOver() 
{
	Tab();
	cout << "----------------------------------------------------------\n" << endl;
	Tab();
	cout << "\t\t+++ G a m e  O v e r +++\n" << endl;
	Tab();
	cout << "----------------------------------------------------------\n" << endl;
}

short ReadHowManyRounds(string message) 
{
	short num = 0;

	do 
	{
		cout << message;
		cin >> num;

	} while (num <= 0);


	cout << endl;

	return num;
}

void ShowRoundResult(short playerChoice, short computerChoice, short & player1WonTimes, short & computerWonTimes, short &drawTimes, short numOfRound)
{
	string gameChoices[3] = { "Rock", "Paper", "Scissors" };

	cout << "\n--------------------Round [" << numOfRound << "]";
	cout << "--------------------\n" << endl;

	cout << "Player1  Choice: " << gameChoices[playerChoice - 1] << endl;
	cout << "Computer Choice: " << gameChoices[computerChoice - 1] << endl;
	cout << "Round Winner\t: ";

	if (playerChoice == computerChoice) 
	{
		cout << "[No Winner]" << endl;
		drawTimes++;
		system("color 6F");
	}
	else if (playerChoice == enRockPaperScissors::Rock && computerChoice == enRockPaperScissors::Scissors)
	{
		cout << "[Player1]" << endl;
		player1WonTimes++;
		system("color 2F");
	}
	else if (playerChoice == enRockPaperScissors::Paper && computerChoice == enRockPaperScissors::Rock)
	{
		cout << "[Player1]" << endl;
		player1WonTimes++;
		system("color 2F");
	}
	else if (playerChoice == enRockPaperScissors::Scissors && computerChoice == enRockPaperScissors::Paper) 
	{
		cout << "[Player1]" << endl;
		player1WonTimes++;
		system("color 2F");
	}
	else
	{
		cout << "[Computer]\a" << endl;
		computerWonTimes++;
		system("color 4F");
	}

	cout << "---------------------------------------------------\n\n" << endl;
}

void ResetScreen()
{
	system("CLS");
	system("color 0F");
}

void StartGame() 
{
	int numOfRounds = ReadHowManyRounds("How Many Rounds 1 to 10 ? ");
	short playerChoice = 0, computerChoice = 0, player1WonTimes = 0, computerWonTimes = 0, drawTimes = 0;
	char playAgain = 'n';

	do
	{
		for (int i = 1; i <= numOfRounds; i++)
		{
			cout << "Round [" << i << "] " << "begins:\n\n";
			cout << "Your choice: [1]:Rock, [2]:Paper, [3]:Scissors ? ";
			cin >> playerChoice;

			computerChoice = rand() % 3 + 1;

			ShowRoundResult(playerChoice, computerChoice, player1WonTimes, computerWonTimes, drawTimes, i);

		}
		ShowGameOver();
		ShowGameResult(player1WonTimes, computerWonTimes, drawTimes, numOfRounds);

		Tab();
		cout << "Do you want to play again? Y/N? ";
		cin >> playAgain;

		cout << endl << endl;
		cout << endl << endl;
		cout << endl << endl;

		if (playAgain == 'y' || playAgain == 'Y') 
		{
			ResetScreen();

			numOfRounds = ReadHowManyRounds("How Many Rounds 1 to 10 ? "),
			playerChoice = 0,
			computerChoice = 0,
			player1WonTimes = 0,
			computerWonTimes = 0,
			drawTimes = 0;
		}

	} while (playAgain == 'y' || playAgain == 'Y');

}


int main()
{
	srand((unsigned)time(NULL));

	StartGame();

	return 0;
}