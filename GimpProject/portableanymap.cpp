#include "portableanymap.h"
#include <fstream>
#include <stdexcept>
#include <iostream>

PortableAnymap::PortableAnymap() : width(0), height(0), maxColorValue(255) {}

PortableAnymap::PortableAnymap(const PortableAnymap& other)
    : format(other.format), width(other.width), height(other.height),
    maxColorValue(other.maxColorValue), pixelData(other.pixelData) {}

PortableAnymap::~PortableAnymap() {}

void PortableAnymap::load(const std::string& filePath) {
    std::ifstream file(filePath, std::ios::binary);
    if (!file.is_open()) {
        throw std::runtime_error("Cannot open file: " + filePath);
    }

    file >> format;
    if (format != "P3" && format != "P6") {
        throw std::runtime_error("Unsupported PPM format: " + format);
    }

    file >> width >> height >> maxColorValue;
    file.ignore(); // Skip to pixel data

    pixelData.resize(width * height * 3);  // Allocate memory for pixel data
    if (format == "P3") { // ASCII format
        for (int i = 0; i < width * height * 3; ++i) {
            int value;
            file >> value;
            pixelData[i] = static_cast<unsigned char>(value);
        }
    } else { // Binary format
        file.read(reinterpret_cast<char*>(pixelData.data()), pixelData.size());
    }
}

void PortableAnymap::save(const std::string& filePath, bool binary) const {
    std::ofstream file(filePath, binary ? std::ios::binary : std::ios::out);
    if (!file.is_open()) {
        throw std::runtime_error("Cannot open file: " + filePath);
    }

    file << (binary ? "P6" : "P3") << '\n';
    file << width << ' ' << height << '\n';
    file << maxColorValue << '\n';

    if (binary) {
        file.write(reinterpret_cast<const char*>(pixelData.data()), pixelData.size());
    } else {
        for (size_t i = 0; i < pixelData.size(); ++i) {
            file << static_cast<int>(pixelData[i]) << ' ';
            if ((i + 1) % (width * 3) == 0) {
                file << '\n';
            }
        }
    }
}

// Getter methods
int PortableAnymap::width() const {
    return width;
}

int PortableAnymap::height() const {
    return height;
}

int PortableAnymap::maxColorValue() const {
    return maxColorValue;
}

const std::vector<unsigned char>& Portable
