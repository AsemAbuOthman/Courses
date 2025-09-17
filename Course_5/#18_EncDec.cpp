#include <iostream>
#include <string>
#include <cmath>

using namespace std;


string ReadText(string message)
{
	string text = "";

	cout << message;
	cin >> text;
	cout << endl;

	return text;
}


string EncryptText(string text, short encryptionKey)
{
	string encryptText = "";

	for (int i = 0; i < text.length(); i++)
	{
		encryptText += char(text[i] + encryptionKey);
	}

	return encryptText;
}

string DecryptText(string encryptText, short encryptionKey)
{
	string decryptedText = "";

	for (int i = 0; i < encryptText.length(); i++)
	{
		decryptedText += char(encryptText[i] - encryptionKey);
	}

	return decryptedText;
}


int main()
{
	const short encryptionKey = 2;
	string text = ReadText("Plz enter text to encrypt it : "),
		encryptedText = EncryptText(text, encryptionKey),
		decryptedText = DecryptText(encryptedText, encryptionKey);

	cout << "Text before Encryption : " << text << endl;
	cout << "Text after Encryption : " << encryptedText << endl;
	cout << "Text after Decryption : " << decryptedText << endl;

	return 0;
}