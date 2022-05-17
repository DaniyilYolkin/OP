import math
from Moving_Material_Point import Moving_Material_Point


class Moving_Material_Point_X_Y(Moving_Material_Point):

    def __init__(self, x0, y0, a1, a2) -> None:
        self.__x0 = x0
        self.__y0 = y0
        self.__a1 = a1
        self.__a2 = a2

    def get_x0(self):
        return self.__x0

    def set_x0(self, value: float):
        self.__x0 = value

    def get_y0(self):
        return self.__y0

    def set_y0(self, value):
        self.__y0 = value

    def get_a1(self):
        return self.__a1

    def set_a1(self, value):
        self.__a1 = value

    def get_a2(self):
        return self.__a2

    def set_a2(self, value):
        self.__a2 = value

    def find_x(self, t: float):
        return self.__x0 + self.__a1 * math.sin(t)

    def find_y(self, t: float):
        return self.__y0 + self.__a2 * math.cos(t)
