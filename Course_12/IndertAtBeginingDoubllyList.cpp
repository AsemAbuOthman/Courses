class Node 
{
public:
    int value;
    Node* next;
    Node* prev;
};

void PrintList(Node* head) 
{
    while (head != NULL)
    {
        cout << head->value << " ";
        head = head->next;
    }
    cout << endl;
}

void InsertAtBegining(Node* &head, int value)
{
    Node* new_node = new Node();

    new_node->value = value;
    new_node->next = head;
    new_node->prev = NULL;

    if (head != NULL)
    {
        head->prev = new_node;
    }

    head = new_node;
}

int main()
{
    //clsMainScreen::ShowMainMenu();
 
    Node* head = NULL;

    //Node* Node1 = NULL;
    //Node* Node2 = NULL;
    //Node* Node3 = NULL;

    //Node1 = new Node();
    //Node2 = new Node();
    //Node3 = new Node();

    //Node1->value = 10;
    //Node2->value = 20;
    //Node3->value = 30;

    //Node1->next = Node2;
    //Node1->prev = NULL;

    //Node2->next = Node3;
    //Node2->prev = Node1;

    //Node3->next = NULL;
    //Node3->prev = Node2;

    //head = Node1;

    InsertAtBegining(head, 0);
    InsertAtBegining(head, -10);
    InsertAtBegining(head, -20);

    PrintList(head);

    return 0;
}