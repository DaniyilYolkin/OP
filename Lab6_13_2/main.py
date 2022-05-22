import random
from BinaryHeapTree import BinaryHeapTree
from Data import Data


def print_tree(bht: BinaryHeapTree):
    for i in range(1, len(bht.Heap)):
        print(bht.Heap[i])


def test(bht: BinaryHeapTree):
    while(True):
        bht = BinaryHeapTree()
        max_quantity = 0
        for i in range(11):
            name = str(i)
            quantity = random.randint(1, 1001)
            distributor = str(i)
            bht.insert(Data(name, quantity, distributor))
            max_quantity = bht.find_max_quantity_distributor().quantity
            max = 0
            for i in range(1, len(bht.Heap)):
                if(bht.Heap[i].quantity > max):
                    max = bht.Heap[i].quantity
            print("Actual max quantity is {}".format(str(max)))

            if(max_quantity != max):
                print("Error!")
                print("Actual max quantity is {}".format(str(max)))
                print("Given {}".format(max_quantity))
                break


# I used Binary Heap Tree based on list
# After each execution of insert method the max element is located in the root
# It modifies time searching for max element from O(n) to O(log(n))

if __name__ == "__main__":
    # You can use test to check the correctness.
    # bht = BinaryHeapTree()
    # test(bht)
    bht = BinaryHeapTree()
    answer = input("Do you want to add a node to the Tree? Y/N: ")
    while answer == "Y" or answer == "y":
        try:
            data = input(
                "Enter the data for a node (detail_name quantity distributor): ").split()
            bht.insert(Data(data[0], int(data[1]), data[2]))
            print("Data was succesfully added")
        except:
            print("Error occured: Data wasn't added")
        finally:
            answer = input(
                "Do you want to add node to the Tree? Y to continue: ")
    max_quantity_distributor = bht.find_max_quantity_distributor()
