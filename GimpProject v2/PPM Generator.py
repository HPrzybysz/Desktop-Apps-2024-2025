import random

def generate_ppm(filename, width, height):
    """Generates a PPM P3 file with random RGB pixels."""
    # Open the file to write
    with open(filename, 'w') as file:
        # Write the PPM header
        file.write(f"P3\n")
        file.write(f"{width} {height}\n")
        file.write("255\n")  # Maximum color value

        # Generate random RGB values for each pixel
        for _ in range(height):
            for _ in range(width):
                r = random.randint(0, 255)
                g = random.randint(0, 255)
                b = random.randint(0, 255)
                file.write(f"{r} {g} {b} ")
            file.write("\n")  # Newline after each row

if __name__ == "__main__":
    # Parameters for the PPM file
    output_filename = "random_image.ppm"
    image_width = 600
    image_height = 600

    # Generate the PPM file
    generate_ppm(output_filename, image_width, image_height)

    print(f"PPM file '{output_filename}' generated successfully!")
