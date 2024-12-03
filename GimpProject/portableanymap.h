#ifndef PORTABLEANYMAP_H
#define PORTABLEANYMAP_H

#pragma once
#include <string>
#include <vector>
#include <fstream>
#include <iostream>
#include <sstream>

class PortableAnymap {
public:
    PortableAnymap();
    PortableAnymap(const PortableAnymap& other);
    ~PortableAnymap();

    void load(const std::string& filePath);
    void save(const std::string& filePath, bool binary = false) const;

    int width() const;         // Access image width
    int height() const;        // Access image height
    int maxColorValue() const;  // Access max color value
    const std::vector<unsigned char>& pixelData() const;  // Access pixel data

private:
    std::string format;                // Format: P3 (ASCII) or P6 (Binary)
    int width, height;                 // Image dimensions
    int maxColorValue;                 // Maximum color value (e.g., 255)
    std::vector<unsigned char> pixelData;  // Raw pixel data
};

#endif // PORTABLEANYMAP_H
