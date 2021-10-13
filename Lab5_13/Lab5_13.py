def find_polyndroms():

    double_polyndroms = []

    for i in range(1, 101):
        if(str(i) == str(i)[::-1]):
            if(str(i*i) == str(i*i)[::-1]):
                double_polyndroms.append(i)
    return double_polyndroms


print(find_polyndroms())
