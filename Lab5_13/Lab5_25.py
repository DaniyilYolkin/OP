prime_found = False
switch = True
counter = 0


def find_closest_prime(a):

    factor_exists = False
    global prime_found
    global switch
    global counter

    if a == 1:
        return '{} is the closest prime'.format(a)

    if a > 1:

        for i in range(2, int(a/2 + 1)):
            if a % i == 0:
                factor_exists = True
                break

        if factor_exists == False:
            prime_found = True
            return '{} is the closest prime'.format(a)

        else:

            if prime_found == False:
                counter += 1
                if switch:
                    switch = False
                    return find_closest_prime(a-counter)
                switch = True
                return find_closest_prime(a+counter)


print(find_closest_prime(int(input(''))))
