int main()
{
    //clsMainScreen::ShowMainMenu();
 
    queue<int> queNumbers1;
    queue<int> queNumbers2;

    queNumbers1.push(10);
    queNumbers1.push(20);
    queNumbers1.push(30);
    queNumbers1.push(40);
    queNumbers1.push(50);

    queNumbers2.push(60);
    queNumbers2.push(70);
    queNumbers2.push(80);
    queNumbers2.push(90);
    queNumbers2.push(100);

    queNumbers1.swap(queNumbers2);

    cout << endl;

    while (!queNumbers1.empty())
    {
        cout << queNumbers1.front() << " ";

        queNumbers1.pop();
    }

    cout << endl;

    while (!queNumbers2.empty())
    {
        cout << queNumbers2.front() << " ";

        queNumbers2.pop();
    }

    cout << endl;

    return 0;
}