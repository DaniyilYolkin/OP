from IOManipulator import IOManipulator


def main():
    INPUT_PATH = "input.bin"
    OUTPUT_PATH = "output.bin"

    IOManipulator.create_input_data(INPUT_PATH)
    IOManipulator.write_phone_call_data_in_output_by_certain_criteria(
        INPUT_PATH, OUTPUT_PATH)
    IOManipulator.print_data_from_file_with_message("Input.bin", INPUT_PATH)
    IOManipulator.print_data_from_file_with_message("Output.bin", OUTPUT_PATH)


main()
