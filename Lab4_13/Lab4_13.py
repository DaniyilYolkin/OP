x = int(input('Type your x: '))
a = int(input('Type your a: '))
n = int(input('Type your n: '))


def find_N(n):
    if n == 0:
        return a
    return 0.5 * (find_N(n-1) + (x / find_N(n-1)))


print(find_N(n))
