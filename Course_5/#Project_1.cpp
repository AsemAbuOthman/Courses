#include <iostream>
#include <cmath>
#include <cstdlib>
#include <string>

using namespace std;

enum enGameChoice {Rock = 1, Paper = 2, Scissors = 3 };
enum enWinner {Player1 = 1, Computer = 2, Draw = 3 };

struct stRoundInfo 
{
	short RoundNum = 0;
	enGameChoice Player1Choice;
	enGameChoice ComputerChoice;
	enWinner Winner;
	string WinnerName;
};

struct stGameResults
{
	short GameRounds = 0;
	short Player1WinTimes = 0;
	short Computer2WinTimes = 0;
	short DrawTimes = 0;
	enWinner GameWinner;
	string WinnerName = "";
};

int RandomNum(int from, int to) 
{
	int randomNum;

	randomNum = rand() % (to - from + 1) + from;

	return randomNum;
}

string WinnerName(enWinner Winner)
{
	string arrWinnerName[3] = { "Player1", "Computer", "Draw" };

	return arrWinnerName[Winner - 1];
}

enWinner WhoWonTheRound(stRoundInfo RoundInfo)
{
	if (RoundInfo.Player1Choice == RoundInfo.ComputerChoice)
		return enWinner::Draw;


	switch (RoundInfo.Player1Choice) 
	{
	case enGameChoice::Rock:
		if (RoundInfo.ComputerChoice == enGameChoice::Paper)
			return enWinner::Computer;
		break;
	case enGameChoice::Paper:
		if (RoundInfo.ComputerChoice == enGameChoice::Scissors)
			return enWinner::Computer;
		break;
	case enGameChoice::Scissors:
		if (RoundInfo.ComputerChoice == enGameChoice::Rock)
			return enWinner::Computer;
		break;
	}

	return enWinner::Player1;
}

enWinner WhoWonTheGame(short player1WinTimes, short computerWinTimes)
{
	if (player1WinTimes > computerWinTimes)
		return enWinner::Player1;
	else if (computerWinTimes > player1WinTimes)
		return enWinner::Computer;
	else
		return enWinner::Draw;
}

string ChoiceName(enGameChoice choice)
{
	string arrGameChoices[3] = { "Rock", "Paper", "Scissors" };

	return arrGameChoices[choice - 1];
}

void SetWinnerScreenColor(enWinner Winner)
{
	switch (Winner)
	{
	case enWinner::Player1:
		system("color 2F");//turn screen to Green
		break;
	case enWinner::Computer:
		system("color 4F");//turn screen to Red
		cout << "\a";
		break;
	case enWinner::Draw:
		system("color 6F");//turn screen to Yellow
		break;
	}
}

void PrintRoundResult(stRoundInfo RoundInfo)
{

	cout << "\n--------------------Round [" << RoundInfo.RoundNum << "]";
	cout << "--------------------\n" << endl;

	cout << "Player1  Choice: " << ChoiceName(RoundInfo.Player1Choice) << endl;
	cout << "Computer Choice: " << ChoiceName(RoundInfo.ComputerChoice) << endl;
	cout << "Round Winner\t: [" << RoundInfo.WinnerName << "] \n";
	cout << "------------------------------------------\n" << endl;

	SetWinnerScreenColor(RoundInfo.Winner);
}

stGameResults FillGameResult(int gameRounds, short player1WinTimes, short computerWinTimes, short drawTimes)
{
	stGameResults GameResults;

	GameResults.GameRounds = gameRounds;
	GameResults.Player1WinTimes = player1WinTimes;
	GameResults.Computer2WinTimes = computerWinTimes;
	GameResults.DrawTimes = drawTimes;
	GameResults.GameWinner = WhoWonTheGame(player1WinTimes, computerWinTimes);
	GameResults.WinnerName = WinnerName(GameResults.GameWinner);

	return GameResults;
}

enGameChoice ReadPlayer1Choice()
{
	short choice = 1;

	do
	{
		cout << "\nYour choice: [1]:Stone, [2]:Paper, [3]:Scissors ? ";
		cin >> choice;

	} while (choice < 1 || choice > 3);

	return (enGameChoice)choice;
}

enGameChoice GetComputerChoice()
{
	return (enGameChoice)RandomNum(1, 3);
}

stGameResults PlayGame(short howManyRounds) 
{
	stRoundInfo RoundInfo;
	short player1WinTimes = 0, computerWinTimes = 0, drawTimes = 0;

	for (short gameRound = 1; gameRound <= howManyRounds; gameRound++) 
	{
		cout << "\nRound [" << gameRound << "] begins:\n";
		RoundInfo.RoundNum = gameRound;
		RoundInfo.Player1Choice = ReadPlayer1Choice();
		RoundInfo.ComputerChoice = GetComputerChoice();
		RoundInfo.Winner = WhoWonTheRound(RoundInfo);
		RoundInfo.WinnerName = WinnerName(RoundInfo.Winner);

		if (RoundInfo.Winner == enWinner::Player1)
			player1WinTimes++;
		else if (RoundInfo.Winner == enWinner::Computer)
			computerWinTimes++;
		else
			drawTimes++;

		PrintRoundResult(RoundInfo);
	}

	return FillGameResult(howManyRounds, player1WinTimes, computerWinTimes, drawTimes);
}

string Tab(short tab)
{
	string t = "";

	for (int i = 1; i < tab; i++)
	{
		t += "\t";
		cout << t;
	}

	return t;
}

void ShowGameOverScreen() 
{
	
	cout << Tab(2) << "----------------------------------------------------------\n\n";
	cout << Tab(2) << "		+++ G a m e  O v e r +++\n" << endl;
	cout << Tab(2) << "----------------------------------------------------------\n\n";
}

void ShowFinalGameResults(stGameResults GameResults) 
{
	cout << Tab(2) << "-------------------- [Game Result ]-----------------------\n" << endl;
	cout << Tab(2) << "Game Rounds\t  : " << GameResults.GameRounds << endl;
	cout << Tab(2) << "Player1 Won times : " << GameResults.Player1WinTimes << endl;
	cout << Tab(2) << "Computer Won times: " << GameResults.Computer2WinTimes << endl;
	cout << Tab(2) << "Draw times\t  : " << GameResults.DrawTimes << endl;

	SetWinnerScreenColor(GameResults.GameWinner);
}

short ReadHowManyRounds()
{
	short gameRounds = 1;

	do
	{
		cout << "How many rounds you want to paly 1 to 10 ? ";
		cin >> gameRounds;

	} while (gameRounds < 1 || gameRounds > 10);


	cout << endl;

	return gameRounds;
}

void ResetScreen()
{
	system("CLS");
	system("color 0F");
}

void StartGame() 
{
	char playAgain = 'Y';

	do
	{
		ResetScreen();
		stGameResults gameResults = PlayGame(ReadHowManyRounds());
		ShowGameOverScreen();
		ShowFinalGameResults(gameResults);

		cout << endl << Tab(3) << "Do you want to paly again ? Y/N ? ";
		cin >> playAgain;

	} while (playAgain == 'y' || playAgain == 'Y');

}


int main()
{
	srand((unsigned)time(NULL));

	StartGame();

	return 0;
}