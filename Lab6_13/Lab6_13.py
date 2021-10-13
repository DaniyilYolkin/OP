# formula 1: find_Y(n+1) = (1/k)(a/(pow(find_Y(n), k-1))+(k-1)*find_Y(n)) y0 = a
# formula 2: pass
# find

def find_Y(a: float, k: int, n: int):
    if n == 0:
        return a
    return (1/k)*((a/(pow(find_Y(a, k, n-1), k-1)))+((k-1)*find_Y(a, k, n-1)))


def calculate(a: float, n: int):
    n = int(n)
    a = float(a)
    if n >= 0 and a > 0:
        return ((find_Y(a, 3, n)-find_Y((pow(a, 2)+1), 6, n))/(1+find_Y((3+a), 7, n)))
    else:
        raise ValueError(
            f'n should be type int, a should be type float\nYour n is {n}\nYour a is {a}')


print(calculate(input('a: '), input('n: ')))
