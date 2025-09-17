/*
Relational Operators	(== , != , >= , <= , >, <)
Assinment Operators		(=, +=, -=, *=, /=, %=)
Arthimatice Opertaors	(+, -, *, / , %)
Logical Operators		(!, &&, || )
*/

#include <iostream>

using namespace std;

enum enGender {Male, Female};
enum enMatrialStatus {Single, Married};
enum enColor {Red, Green, Blue};

struct stAddress 
{
	string StreetName;
	string BuildingNo;
	string PoBox;
	string ZipCode;

};

struct stContactInfo
{
	string Phone;
	string Email;

	stAddress Address;
};

struct stPerson
{
	string FirstName;
	string LastName;	
	string Age;

	stContactInfo ContactInfo;

	enMatrialStatus MatrialStatus;
	enGender Gender;
	enColor Color;
};

int main()
{

	stPerson Person1;

	Person1.FirstName = "Asem";
	Person1.LastName = "Abu_Othman";
	Person1.Age = "21";

	Person1.ContactInfo.Phone = "+962796570527";
	Person1.ContactInfo.Email = "asemabuothman@gmail.com";
	Person1.ContactInfo.Address.BuildingNo = "10";
	Person1.ContactInfo.Address.StreetName = "Ain_Maoun Street";
	Person1.ContactInfo.Address.PoBox = "7777";
	Person1.ContactInfo.Address.ZipCode = "19242";

	Person1.Gender = enGender::Male;
	Person1.MatrialStatus = enMatrialStatus::Single;
	Person1.Color = enColor::Red;

	cout << Person1.MatrialStatus << endl;

	return 0;
}