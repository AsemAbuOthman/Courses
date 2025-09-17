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

Node* Find(Node* head, int value) 
{
    while (head != NULL) 
    {
        if (head->value == value) 
        {
            return head;
        }

        head = head->next;
    }

    return NULL;
}

void InsertAfter(Node* prev_node, int value) 
{

    if (prev_node == NULL) 
    {
        cout << "The Given previous Node is can't be NULL !" << endl;
        return;
    }

    Node* new_node = new Node();

    new_node->value = value;
    new_node->next = prev_node->next;

    prev_node->next = new_node;
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

    Node* N1 = Find(head, 4);

    InsertAfter(N1, 10);

    PrintList(head);

    //N1 != NULL ? cout << "Node Found" << endl : cout << "Node not Found" << endl;


    return 0;
}