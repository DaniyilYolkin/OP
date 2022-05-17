from Number import Number


def main():
    N1 = Number(0, 1, 2, 3)
    N2 = Number(0, 1, 2)
    N3 = Number(0, 1)
    N4 = Number(0)

    list_of_numbers = [N1, N2, N3, N4]
    for number in list_of_numbers:
        print(number.generate_number())

    N1 += 1
    N2 -= 1

    print(N1.generate_number())
    print(N2.generate_number())

    N2 += 1

    print(N2.generate_number())

    N3 = N1 + N2

    print(N3.generate_number())

    if(N3 > N4):
        print(N3.generate_number())
    else:
        print(N4.generate_number())


main()
