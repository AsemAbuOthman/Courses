#pragma once

#include <vector>
#include <iostream>
#include <string>

using namespace std;


namespace clsString
{

	class clsString
	{
	private:
		string _Value;

	public:

		clsString()
		{
			_Value = "";
		}

		clsString(string Value)
		{
			_Value = Value;
		}

		void SetValue(string Value)
		{
			_Value = Value;
		}

		string GetValue()
		{
			return _Value;
		}

		static vector<string> SplitString(string text, string delim)
		{
			vector<string> vResult;

			string word;
			short pos = 0;

			while ((pos = text.find(delim)) != string::npos)
			{
				word = text.substr(0, pos);

				if (word != "")
				{
					vResult.push_back(word);
				}

				text.erase(0, pos + delim.length());
			}

			if (text != "")
			{
				vResult.push_back(text);
			}

			return vResult;
		}

		vector<string> SplitString()
		{
			return SplitString(_Value, " ");
		}

		static string ReverseWordsInString(string text)
		{
			vector<string> vText = SplitString(text, " ");
			string reverseText = "";

			vector<string>::iterator iter = vText.end();

			while (iter != vText.begin())
			{

				--iter;

				reverseText += *iter + " ";

			}

			reverseText = reverseText.substr(0, reverseText.length() - 1);

			return reverseText;
		}

		string ReverseWordsInString()
		{
			return ReverseWordsInString(_Value);
		}


		static string JoinString(vector <string> vText, string delim)
		{
			string result = "";

			for (string& text : vText)
			{
				result += text + delim;
			}

			return result.substr(0, result.length() - delim.length());
		}

		string JoinString(string delim)
		{
			return JoinString(SplitString(_Value, delim), delim);
		}

		static short CountLetter(string text, char letter, bool matchCase = true)
		{
			short count = 0;

			for (short i = 0; i < text.length(); i++)
			{
				if (matchCase)
				{
					if (text[i] == letter)
					{
						count++;
					}
				}
				else
				{
					if (tolower(text[i]) == tolower(letter))
					{
						count++;
					}
				}
			}

			return count;
		}

		short CountLetter(char letter, bool matchCase = true)
		{
			return CountLetter(_Value, letter, matchCase);
		}

		static char InvertLetterCase(char letter)
		{

			return isupper(letter) ? tolower(letter) : toupper(letter);
		}

		static string ConvertStringToUpperCase(string text)
		{

			for (short i = 0; i < text.length(); i++)
			{
				if (text[i] != ' ' && text[i] <= 'z' && text[i] >= 'a')
				{
					text[i] = text[i] - ' ';
				}
			}

			return text;
		}

		void ConvertStringToUpperCase()
		{
			_Value = ConvertStringToUpperCase(_Value);
		}


		static string ConvertStringToLowerCase(string text)
		{

			for (short i = 0; i < text.length(); i++)
			{
				if (text[i] != ' ' && text[i] <= 'Z' && text[i] >= 'A')
				{
					text[i] = text[i] + ' ';
				}
			}

			return text;
		}

		void ConvertStringToLowerCase()
		{
			_Value = ConvertStringToLowerCase(_Value);
		}


		static string ReplaceWordInString(string orginalText, string stringToReplace, string stringReplaceTo, bool matchedCase = true)
		{
			vector <string> textWords = SplitString(orginalText, " ");

			short pos = 0;

			if (matchedCase)
			{
				if (orginalText.find(stringToReplace) != string::npos)
				{
					orginalText.erase(0, orginalText.length());

					for (string& text : textWords)
					{
						if (text == stringToReplace)
						{
							text = stringReplaceTo;
						}

						orginalText += text + " ";
					}
				}
			}
			else
			{
				orginalText.erase(0, orginalText.length());

				stringToReplace = ConvertStringToLowerCase(stringToReplace);

				for (string& text : textWords)
				{
					if (ConvertStringToLowerCase(text) == stringToReplace)
					{
						text = stringReplaceTo;
					}

					orginalText += text + " ";
				}
			}

			return orginalText.substr(0, orginalText.length() - 1);
		}

		string ReplaceWordInString(string stringToReplace, string stringReplaceTo, bool matchedCase = true)
		{
			return ReplaceWordInString(_Value, stringToReplace, stringReplaceTo, matchedCase);
		}

		static bool IsLetterVowel(char letter)
		{
			letter = tolower(letter);

			return letter == 'a' ||
				letter == 'e' ||
				letter == 'u' ||
				letter == 'i' ||
				letter == 'o' ? true : false;
		}

		static string TrimLeft(string text)
		{

			for (short i = 0; i < text.length() - 1; i++)
			{
				if (text[i] != ' ')
				{
					return text.substr(i, text.length() - 1);
				}
			}

			return text;
		}

		string TrimLeft()
		{
			return TrimLeft(_Value);
		}

		static string TrimRight(string text)
		{
			for (short i = text.length() - 1; i >= 0; i--)
			{
				if (text[i] != ' ')
				{
					return text.substr(0, i + 1);
				}
			}

			return text;
		}

		string TrimRight()
		{
			return TrimRight();
		}

		static string Trim(string text)
		{

			return TrimLeft(TrimRight(text));
		}

		string Trim()
		{
			return Trim(_Value);
		}

		static short CountLetter(string text, char letter)
		{
			short count = 0;

			for (short i = 0; i < text.length(); i++)
			{
				if (text[i] == letter)
				{
					count++;
				}
			}

			return count;
		}

		__declspec(property(get = GetValue, put = SetValue)) string Value;
	};

}

