def solve(string, chars):
    arr_of_string = string.split(' ', -1)

    def filter_function(item):
        counter = 0
        contains = True
        arr_of_item = list(item)
        arr_of_chars = list(chars)
        for char in arr_of_chars:
            if char != arr_of_item[counter] or char != arr_of_item[len(arr_of_item)-len(arr_of_chars)+counter]:
                contains = False
                break
            counter += 1
        if contains == True:
            return item

#
    return list(filter(filter_function, arr_of_string))


print(solve('adcasdadc asdasdas adc adadasf adad dada fs adcd', 'adc'))
