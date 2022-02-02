# Декларуємо функцію, яка як параметри приймає a, d, n
# та вертає значення n-го члена арифметичної прогрессії, якщо n - додатнє число
# В іншому випадку, функція згенерує помилку

def find_the_value_of_arithmetic_progression(a, d, n):

    # Перевіряємо чи значення n - додатнє

    if n > 0:

        # Як результат, вертаємо значення n-го члена

        return a+(n-1)*d

    # Якщо if не виконується, то генеруємо помилку

    raise ValueError('n must be greater than 0')

# Виводимо результат функції в консоль, викликаючи її з параметрами a, d, n,
# які переводимо в формат float (для a, d) та int (для n)


print(find_the_value_of_arithmetic_progression(
    float(input('a: ')), float(input('d: ')), int(input('n: '))))
