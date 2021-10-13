import math


def count_sum(x: float):
    try:
        x = float(x)
    except:
        raise ValueError(
            f'x must be a float type with the value between 1 and 5\nYour x is {x}')
    e = 0.0001  # Точность
    n = 0  # Счетчик
    sum = 0
    if(x >= 1 and x <= 5):
        expression = pow(-1, n)*(pow(x, 2*n)/math.factorial(2*n))
        n += 1
        nextExpression = pow(-1, n)*(pow(x, 2*n)/math.factorial(2*n))
        while abs(nextExpression - expression) >= e:
            expression = nextExpression
            n += 1
            nextExpression = pow(-1, n)*(pow(x, 2*n)/math.factorial(2*n))
            sum += expression
        return sum
    else:
        raise ValueError('x is not in range(1,5)\nYour x is {x}')


print(count_sum(input('x: ')))
