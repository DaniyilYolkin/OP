from Moving_Material_Point import Moving_Material_Point
from Moving_Material_Point_X import Moving_Material_Point_X
from Moving_Material_Point_X_Y import Moving_Material_Point_X_Y
import random as rnd
import math


def main():
    k = int(input("k: "))
    n = int(input("n: "))
    t = float(input("t: "))
    points = generate_points(k, n)
    print(find_max_distance(points, t))


def generate_points(k: int, n: int):
    points = []
    for _ in range(k):
        points.append(Moving_Material_Point_X(
            rnd.uniform(-100, 100), rnd.uniform(-100, 100)))
    for _ in range(n):
        points.append(Moving_Material_Point_X_Y(rnd.uniform(-100, 100),
                      rnd.uniform(-100, 100), rnd.uniform(-100, 100), rnd.uniform(-100, 100)))
    return points


def find_max_distance(points: list[Moving_Material_Point], t: float):
    max_distance = -math.inf
    distances = []
    for i in range(len(points)-1):
        for j in range(i+1, len(points)):
            distances.append(Moving_Material_Point.find_distance(
                t, points[i], points[j]))
            if(Moving_Material_Point.find_distance(t, points[i], points[j]) > max_distance):
                max_distance = Moving_Material_Point.find_distance(
                    t, points[i], points[j])
    print(distances)
    return max_distance


main()
