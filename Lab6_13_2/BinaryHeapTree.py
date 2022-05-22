import math
import random


class Data:
    def __init__(self, detail="", quantity=0, distributor=""):
        self.detail = detail
        self.quantity = quantity
        self.distributor = distributor

    def __repr__(self):
        return "{0} {1} {2}".format(self.detail, str(self.quantity), self.distributor)


class BinaryHeapTree:
    def __init__(self):
        self.Heap = ["-1"]

    def parent(self, i: int):
        return math.floor(i/2)

    def left_child(self, i: int):
        return 2*i

    def right_child(self, i: int):
        return 2*i+1

    def sift_up(self, i: int):
        while i > 1 and self.Heap[self.parent(i)].quantity < self.Heap[i].quantity:
            self.Heap[self.parent(
                i)], self.Heap[i] = self.Heap[i], self.Heap[self.parent(i)]
            i = self.parent(i)

    def insert(self, data: Data):
        self.Heap.append(data)
        self.sift_up(len(self.Heap)-1)

    def find_max_quantity_distributor(self):
        print(
            "Distributor - {0}; Quantity - {1}".format(self.Heap[1].distributor, self.Heap[1].quantity))
        return self.Heap[1]
