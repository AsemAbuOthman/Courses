

int main()
{
    //clsMainScreen::ShowMainMenu();
 
    map<string, int> studentGrades;

    studentGrades["Asem"] = 100;
    studentGrades["Ziad"] = 50;
    studentGrades["Khalil"] = 75;
    
    for (const auto& pair : studentGrades) 
    {
        cout << pair.first << "'s Grade is " << pair.second << "/100 . " << endl;
    }

    string name = "Asem";

    if (studentGrades.find(name) != studentGrades.end()) 
    {

        cout << "\nFound " << studentGrades[name] << endl;
    }

    return 0;
}