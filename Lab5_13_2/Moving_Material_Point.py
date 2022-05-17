from abc import ABC, abstractclassmethod
import math


class Moving_Material_Point(ABC):

    @abstractclassmethod
    def find_x(self, t: float):
        raise NotImplementedError

    @abstractclassmethod
    def find_y(self, t: float):
        raise NotImplementedError

    @staticmethod
    def find_distance(t: float, point, other):
        return math.sqrt(math.pow((point.find_x(t) - other.find_x(t)), 2) + math.pow((point.find_y(t) - other.find_y(t)), 2))
