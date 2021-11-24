array = [1, -2, 3, -4, 5]


def f_generator(arrayOfIntegers, multiplier):
    F = []
    counter = -1
    for number in arrayOfIntegers:
        counter += 1
        if counter % 2 == 0 and counter != 0:
            F.append(number*multiplier)
        else:
            F.append(number)
    return F


def absolute_of_negative_numbers_average(arrayOfIntegers):
    counter = 0
    sum = 0
    for number in arrayOfIntegers:
        if(number < 0):
            sum += number
            counter += 1
    return abs(sum/counter)


print(absolute_of_negative_numbers_average(array))
print(f_generator(array, absolute_of_negative_numbers_average(array)))
