class Node 
{
public:
    int value;
    Node* next;
};

void InsertingAtTheBegining(Node* &head, int value) 
{

    Node* new_node = new Node();

    new_node->value = value;
    new_node->next = head;

    head = new_node;
}

void PrintList(Node *head) 
{

    while (head != NULL) 
    {
        cout << head->value << " ";
        head = head->next;
    }

    cout << endl;
}

int main()
{
    //clsMainScreen::ShowMainMenu();
 
    Node* head = NULL;

    InsertingAtTheBegining(head, 1);
    InsertingAtTheBegining(head, 2);
    InsertingAtTheBegining(head, 3);
    InsertingAtTheBegining(head, 4);
    InsertingAtTheBegining(head, 5);

    PrintList(head);

    return 0;
}