def find_the_value_of_arithmetic_progression(a, d, n):
    if n > 0:
        return a+(n-1)*d
    raise ValueError('n must be greater than 0')


print(find_the_value_of_arithmetic_progression(
    float(input('a: ')), float(input('d: ')), int(input('n: '))))
