class Node 
{
public:
    int value;
    Node * next;
};


int main()
{
    //clsMainScreen::ShowMainMenu();
 
    Node* head;

    Node* Node1 = NULL;
    Node* Node2 = NULL;
    Node* Node3 = NULL;

    Node1 = new Node();
    Node2 = new Node();
    Node3 = new Node();

    Node1->value = 10;
    Node2->value = 20;
    Node3->value = 30;

    Node1->next = Node2;
    Node2->next = Node3;
    Node3->next = NULL;

    head = Node1;

    while (head != NULL) 
    {   
        cout << head->value << endl;
        head = head->next;
    }

    return 0;
}