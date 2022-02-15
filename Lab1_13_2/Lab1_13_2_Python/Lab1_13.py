from Functions import *


def main():

    INPUT_REFERENCE = "input.txt"
    OUTPUT_REFERENCE = "output.txt"

    create_input_data(INPUT_REFERENCE)
    data = read_data_from_file(INPUT_REFERENCE)
    modified_data = process_data(data)
    write_processed_data_in_output(OUTPUT_REFERENCE, modified_data)
    print("\n\nCode ended successfully! Check output.txt for results!")
    output_data_in_console(INPUT_REFERENCE)
    output_data_in_console(OUTPUT_REFERENCE)


main()
