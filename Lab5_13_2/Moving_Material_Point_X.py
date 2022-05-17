import math
from Moving_Material_Point import Moving_Material_Point


class Moving_Material_Point_X(Moving_Material_Point):

    def __init__(self, x0: float, a1: float) -> None:
        self.__x0 = x0
        self.__a1 = a1

    def get_x0(self):
        return self.__x0

    def set_x0(self, value: float):
        self.__x0 = value

    def get_a1(self):
        return self.__a1

    def set_a1(self, value: float):
        self.__a1 = value

    def find_x(self, t: float):
        return self.__x0 + self.__a1 * math.sin(t)

    def find_y(self, t: float):
        return 0
