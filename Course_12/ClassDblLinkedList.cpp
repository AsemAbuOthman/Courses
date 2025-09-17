#pragma once

#include <iostream>

using namespace std;

template <typename t> class clsNode
{

public:
	t value;
	clsNode* next;
	clsNode* prev;

};





#pragma once

#include <iostream>
#include "clsNode.h"

using namespace std;

template <typename t> class clsDblLinkedList : public clsNode<t>
{

public:

	clsNode<t> * head = NULL;

	void InsertAtBeginning(t value) 
	{
		clsNode<t> * new_node = new clsNode<t>();

		new_node->value = value;
		new_node->prev = NULL;

		if (head == NULL)
		{
			new_node->next = NULL;
			head = new_node;

			return;
		}

		new_node->next = head;
		head->prev = new_node;
		head = new_node;

	}

	void PrintList() 
	{
		clsNode<t>* Head = head;

		while (Head != NULL)
		{
			cout << Head->value << " ";
			Head = Head->next;
		}
		cout << endl;
	}

	clsNode<t>* Find(t value) 
	{

		clsNode<t>* Head = head;

		 if (Head == NULL)
		 {
			 return NULL;
		 }

		 while (Head != NULL && Head->value != value)
		 {
			 Head = Head->next;
		 }

		 return Head;
	}

	void InsertAfter(clsNode<t> * current, t value) 
	{
		clsNode<t>* new_node = new clsNode<t>();

		new_node->value = value;
		new_node->prev = current;
		new_node->next = current->next;

		if (current->next != NULL)
		{
			current->next->prev = new_node;
		}

		current->next = new_node;

	}

	void InsertAtEnd(int value)
	{
		clsNode<t> * new_node = new clsNode<t>();

		new_node->value = value;
		new_node->next = NULL;

		if (head == NULL)
		{
			new_node->prev = NULL;
			head = new_node;
		}
		else
		{
			clsNode<t> * current = head;

			while (current->next != NULL)
			{
				current = current->next;
			}

			current->next = new_node;
			new_node->prev = current;

		}
	}

	void DeleteNode(clsNode<t> * NodeToDeleted)
	{
		if (NodeToDeleted == NULL || head == NULL)
		{
			return;
		}

		if (NodeToDeleted->prev != NULL)
		{
			NodeToDeleted->prev->next = NodeToDeleted->next;
		}

		if (NodeToDeleted->next != NULL)
		{
			NodeToDeleted->next->prev = NodeToDeleted->prev;

		}

		if (head == NodeToDeleted)
		{
			head = NodeToDeleted->next;
		}


		delete NodeToDeleted;
	}

	void DeleteFirstNode(clsNode<t>*& head)
	{
		if (head == NULL)
		{
			return;
		}

		clsNode<t> * temp = head;
		head = head->next;

		if (head != NULL)
		{
			head->prev = NULL;
		}

		delete temp;
	}
};


int main()
{
    //clsMainScreen::ShowMainMenu();
 
    clsDblLinkedList<int> myDblLinkedList;

    myDblLinkedList.InsertAtBeginning(5);
    myDblLinkedList.InsertAtBeginning(4);
    myDblLinkedList.InsertAtBeginning(3);
    myDblLinkedList.InsertAtBeginning(2);
    myDblLinkedList.InsertAtBeginning(1);

    cout << "\nLinked List Content: ";
    myDblLinkedList.PrintList();

    clsDblLinkedList<int>::clsNode* Node1 = myDblLinkedList.Find(3);

    if (Node1 != NULL) 
    {
        cout << "Node with value " << Node1->value << " was found \n";
    }
    else 
    {
        cout << "Node was Not found \n";

    }


    myDblLinkedList.InsertAfter(Node1, 500);
    cout << "\nAfter Inserting 500 after 3 : \n" << endl;
    myDblLinkedList.PrintList();

    myDblLinkedList.InsertAtEnd(700);
    cout << "\nAfter Inserting 700 at end : \n" << endl;
    myDblLinkedList.PrintList();

    clsDblLinkedList<int>::clsNode* Node2 = myDblLinkedList.Find(4);

    myDblLinkedList.DeleteNode(Node2);
    cout << "\nAfter Deleting 4 : \n" << endl;
    myDblLinkedList.PrintList();

    return 0;
}

