int main()
{
    //clsMainScreen::ShowMainMenu();
    
    stack<int> stkNumber;

    stkNumber.push(1);
    stkNumber.push(2);
    stkNumber.push(3);
    stkNumber.push(4);
    stkNumber.push(5);

    cout << "Size of Stack : " << stkNumber.size() << endl << endl;

    cout << "Numbers in Stack are : " << endl;

    while (!stkNumber.empty()) 
    {
        cout << stkNumber.top() << endl;

        stkNumber.pop();
    }



    return 0;
}