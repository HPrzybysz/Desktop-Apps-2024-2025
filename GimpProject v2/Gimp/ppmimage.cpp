#include "ppmimage.h"
#include <fstream>
#include <algorithm>
#include <cmath>

PPMImage::PPMImage() : m_width(0), m_height(0) {}

PPMImage::~PPMImage() {}

bool PPMImage::load(const std::string& filename) {
    std::ifstream file(filename);
    if (!file.is_open()) return false;

    std::string line;
    std::getline(file, line); // Read the magic number
    if (line != "P3") return false; // Only support ASCII PPM

    // Read image dimensions
    unsigned int maxColorValue;
    file >> m_width >> m_height >> maxColorValue;

    m_data.resize(m_width * m_height * 3); // 3 bytes per pixel (RGB)

    for (size_t i = 0; i < m_data.size(); i++) {
        int value;
        file >> value;
        m_data[i] = static_cast<unsigned char>(value);
    }

    return true;
}

bool PPMImage::save(const std::string& filename) const {
    std::ofstream file(filename);
    if (!file.is_open()) return false;

    file << "P3\n" << m_width << " " << m_height << "\n255\n";
    for (size_t i = 0; i < m_data.size(); i++) {
        file << static_cast<int>(m_data[i]) << " ";
        if ((i + 1) % 3 == 0) file << "\n"; // New line after every RGB triplet
    }

    return true;
}

void PPMImage::desaturate(float level) {
    //level between 0.0 and 1.0
    if (level < 0.0f) level = 0.0f;
    if (level > 1.0f) level = 1.0f;

    for (size_t i = 0; i < m_data.size(); i += 3) {
        unsigned char r = m_data[i];
        unsigned char g = m_data[i + 1];
        unsigned char b = m_data[i + 2];

        unsigned char avg = static_cast<unsigned char>((r + g + b) / 3);

        m_data[i] = static_cast<unsigned char>(r * (1 - level) + avg * level);     // R
        m_data[i + 1] = static_cast<unsigned char>(g * (1 - level) + avg * level); // G
        m_data[i + 2] = static_cast<unsigned char>(b * (1 - level) + avg * level); // B
    }
}


void PPMImage::negative() {

    for (size_t i = 0; i < m_data.size(); i++) {

        m_data[i] = 255 - m_data[i]; // Invert the color

    }

}

void PPMImage::adjustBrightness(int value) {

    for (size_t i = 0; i < m_data.size(); i++) {

        int newValue = static_cast<int>(m_data[i]) + value;

        m_data[i] = static_cast<unsigned char>(std::clamp(newValue, 0, 255));

    }

}

void PPMImage::adjustSaturation(float saturationLevel) {
    saturationLevel = std::clamp(saturationLevel, -1.0f, 1.0f);

    for (size_t i = 0; i < m_data.size(); i += 3) {
        // Extract RGB
        float r = m_data[i] / 255.0f;
        float g = m_data[i + 1] / 255.0f;
        float b = m_data[i + 2] / 255.0f;

        // Calculate brightness
        float luminance = 0.299f * r + 0.587f * g + 0.114f * b;

        // diff between color and luminance
        float dr = r - luminance;
        float dg = g - luminance;
        float db = b - luminance;

        // Adjust colors
        r = luminance + dr * (1 + saturationLevel);
        g = luminance + dg * (1 + saturationLevel);
        b = luminance + db * (1 + saturationLevel);

        // Clamp and convert
        m_data[i] = static_cast<unsigned char>(std::clamp(r * 255, 0.0f, 255.0f));
        m_data[i + 1] = static_cast<unsigned char>(std::clamp(g * 255, 0.0f, 255.0f));
        m_data[i + 2] = static_cast<unsigned char>(std::clamp(b * 255, 0.0f, 255.0f));
    }
}



void PPMImage::adjustContrast(int contrastLevel) {

    // Convert contrast level from percentage to a factor

    float contrastFactor = (contrastLevel - 100) / 100.0f; // 0 for 100%, negative for less contrast, positive for more


    for (size_t i = 0; i < m_data.size(); i += 3) {

        for (int j = 0; j < 3; ++j) { // For R, G, B channels

            int oldValue = m_data[i + j];

            // Apply contrast adjustment

            int newValue = static_cast<int>((((oldValue / 255.0f) - 0.5f) * (1 + contrastFactor) + 0.5f) * 255);

            // Clamp the new value to the range [0, 255]

            m_data[i + j] = std::clamp(newValue, 0, 255);

        }

    }

}
