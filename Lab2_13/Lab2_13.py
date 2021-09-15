import math


def find_if_number_is_in_range(x, y):

    # (x-1)^2+y^2 <= 4 when x in range(-1,1)
    # y = 4x - 12 when x in range(1,3)
    # y = -4x + 12 when x in range(1,3)

    if ((x >= -1 and x <= 1 and (math.pow(x-1, 2)+math.pow(y, 2) <= 4))
            or (x >= 1 and x <= 3 and x - 3 <= y and -x + 3 >= y)):
        return True
    return False


print(find_if_number_is_in_range(float(input('x: ')), float(input('y: '))))
