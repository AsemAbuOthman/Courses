int main()
{
    //clsMainScreen::ShowMainMenu();
 
    queue<int> queNumbers;

    queNumbers.push(10);
    queNumbers.push(20);
    queNumbers.push(30);
    queNumbers.push(40);
    queNumbers.push(50);

    cout << "Queue Size  : " << queNumbers.size() << endl;
    cout << "Queue Front : " << queNumbers.front() << endl;
    cout << "Queue Back  : " << queNumbers.back() << endl;

    cout << endl;

    while (!queNumbers.empty()) 
    {
        cout << queNumbers.front() << " ";

        queNumbers.pop();
    }

    cout << endl;

    return 0;
}