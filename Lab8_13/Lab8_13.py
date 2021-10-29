def create_matrix(arr):
    matrix = []
    saved_array = arr.copy()
    matrix.append(saved_array)
    for _ in range(0, len(arr)-1):
        arr.append(arr.pop(0))
        saved_array = arr.copy()
        matrix.append(saved_array)
    return matrix


print(create_matrix([1, 2, 3, 4, 5]))
