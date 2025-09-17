int main()
{
    //clsMainScreen::ShowMainMenu();
    
    stack <int> stkNumber1;
    stack <int> stkNumber2;

    stkNumber1.push(10);
    stkNumber1.push(20);
    stkNumber1.push(30);
    stkNumber1.push(40);
    stkNumber1.push(50);

    stkNumber2.push(60);
    stkNumber2.push(70);
    stkNumber2.push(80);
    stkNumber2.push(90);
    stkNumber2.push(100);

    stkNumber1.swap(stkNumber2);

    cout << "Stack 1 : ";

    while (!stkNumber1.empty()) 
    {
        cout << stkNumber1.top() << " ";

        stkNumber1.pop();
    }

    cout << "\nStack 2 : ";

    while (!stkNumber2.empty())
    {
        cout << stkNumber2.top() << " ";

        stkNumber2.pop();
    }

    cout << "\n";


    return 0;
}