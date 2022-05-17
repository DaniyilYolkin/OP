class Number:
    def __init__(self, ones_digit=0, tens_digit=0, hundreds_digit=0, thousands_digit=0) -> None:
        self.__ones_digit = ones_digit
        self.__tens_digit = tens_digit
        self.__hundreds_digit = hundreds_digit
        self.__thousands_digit = thousands_digit

    def generate_number(self):
        return self.__thousands_digit * 10**3 + self.__hundreds_digit * 10**2 + self.__tens_digit * 10 + self.__ones_digit

    def get_ones_digit(self):
        return self.__ones_digit

    def get_tens_digit(self):
        return self.__tens_digit

    def get_hundreds_digit(self):
        return self.__hundreds_digit

    def get_thousands_digit(self):
        return self.__thousands_digit

    def __iadd__(self, number):
        number = 1
        list_of_digits = [self.__ones_digit, self.__tens_digit,
                          self.__hundreds_digit, self.__thousands_digit]
        for i in range(len(list_of_digits)):
            list_of_digits[i] += number
            if(list_of_digits[i] >= 10):
                list_of_digits[i] -= 10
                if(i < 3):
                    list_of_digits[i+1] += 1

        self.__ones_digit = list_of_digits[0]
        self.__tens_digit = list_of_digits[1]
        self.__hundreds_digit = list_of_digits[2]
        self.__thousands_digit = list_of_digits[3]

        return self

    def __isub__(self, number):
        number = 1
        list_of_digits = [self.__ones_digit, self.__tens_digit,
                          self.__hundreds_digit, self.__thousands_digit]
        for i in range(len(list_of_digits)):
            list_of_digits[i] -= number
            if(list_of_digits[i] <= -1):
                list_of_digits[i] += 10
                if(i < 3):
                    list_of_digits[i+1] -= 1

        self.__ones_digit = list_of_digits[0]
        self.__tens_digit = list_of_digits[1]
        self.__hundreds_digit = list_of_digits[2]
        self.__thousands_digit = list_of_digits[3]

        return self

    def __add__(a, b):
        result = Number()
        if(type(a) is not Number or type(b) is not Number):
            print("You can add only instances of class Number between each other")
            return

        list_of_result = [result.__ones_digit, result.__tens_digit,
                          result.__hundreds_digit, result.__thousands_digit]
        list_of_a = [a.__ones_digit, a.__tens_digit,
                     a.__hundreds_digit, a.__thousands_digit]
        list_of_b = [b.__ones_digit, b.__tens_digit,
                     b.__hundreds_digit, b.__thousands_digit]

        for i in range(len(list_of_result)):
            list_of_result[i] += list_of_a[i] + list_of_b[i]
            if(list_of_result[i] >= 10):
                list_of_result[i] -= 10
                if(i < 3):
                    list_of_result[i+1] += 1

        result.__ones_digit = list_of_result[0]
        result.__tens_digit = list_of_result[1]
        result.__hundreds_digit = list_of_result[2]
        result.__thousands_digit = list_of_result[3]

        return result

    def __gt__(a, b):
        if(type(a) is not Number or type(b) is not Number):
            print("Only objects of class Number can be compared")
            return

        list_of_a = [a.__ones_digit, a.__tens_digit,
                     a.__hundreds_digit, a.__thousands_digit]
        list_of_b = [b.__ones_digit, b.__tens_digit,
                     b.__hundreds_digit, b.__thousands_digit]

        for i in range(len(list_of_a)-1, -1, -1):
            if(list_of_a[i] > list_of_b[i]):
                return True
            elif(list_of_a[i] < list_of_b[i]):
                return False

        return False
