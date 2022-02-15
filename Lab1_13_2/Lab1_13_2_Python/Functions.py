import sys


def validate_string_on_escape_seq(string: str) -> bool:
    for letter in string:
        possible_escape_sequence = ord(letter)
        if(possible_escape_sequence >= 0 and possible_escape_sequence != 10 and possible_escape_sequence <= 31):
            return False
    return True


def validate_string_on_fullness(string: str) -> bool:
    return string != ""


def create_input_data(ref: str) -> None:
    try:
        input_file = open(ref, "w+")
        string = input("Enter your input data: ")
        while(validate_string_on_escape_seq(string)):
            input_file.write(string + "\n")
            string = input("Enter your input data: ")
    except KeyboardInterrupt:
        pass
    finally:
        input_file.close()


def read_data_from_file(ref: str) -> list[str]:
    file = open(ref, "r")
    data = file.readlines()
    return data


def find_shortest_word_data_in_line(data: list[str], index: int) -> list[str]:
    shortest_word = ""
    shortest_word_length = sys.maxsize
    words = data[index].replace(',', ' ').replace(
        ';', ' ').replace('.', ' ').replace("\n", ' ').split()

    for word in words:
        if(len(word) < shortest_word_length):
            shortest_word = word
            shortest_word_length = len(word)

    return [shortest_word, shortest_word_length]


def compose_string(shortest_word_info: list[str], string: str) -> str:
    return string + " - " + str(shortest_word_info[1]) + " - " + shortest_word_info[0]


def process_data(data: list[str]) -> list[str]:
    modified_data = []
    index = 0
    for string in data:
        string = string.replace("\n", '')
        if(validate_string_on_fullness(string)):
            shortest_word_info = find_shortest_word_data_in_line(data, index)
            modified_data.append(compose_string(shortest_word_info, string))
        index += 1

    return modified_data


def write_processed_data_in_output(ref: str, processed_data: list[str]) -> None:
    output_file = open(ref, "a+")
    for string in processed_data:
        output_file.write(string + "\n")
    output_file.close()


def output_data_in_console(file_path: str) -> None:
    file = open(file_path, "r+")
    print("\n\n-----------------{0}-----------------".format(file_path))
    for string in file:
        print(string)
    print("--------------------------------------------")
