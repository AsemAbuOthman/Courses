class Node 
{
public:
    int value;
    Node* next;
    Node* prev;
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
    Node1->prev = NULL;

    Node2->next = Node3;
    Node2->prev = Node1;

    Node3->next = NULL;
    Node3->prev = Node2;

    head = Node1;

    while (head != NULL) 
    {
        cout << head->value << " ";
        head = head->next;
    }
    cout << endl;

    return 0;
}