#ifndef PPMIMAGE_H
#define PPMIMAGE_H

#include <vector>
#include <string>
#include <QImage>

class PPMImage {
public:
    PPMImage();
    ~PPMImage();

    bool load(const std::string& filename);
    bool save(const std::string& filename) const;

    unsigned int width() const { return m_width; }
    unsigned int height() const { return m_height; }
    const std::vector<unsigned char>& data() const { return m_data; }

    void desaturate(float level);
    void negative();
    void adjustBrightness(int value);
    void adjustSaturation(float saturationLevel);
    void adjustContrast(int contrastLevel);



private:
    unsigned int m_width;
    unsigned int m_height;
    std::vector<unsigned char> m_data; // RGB data
};

#endif // PPMIMAGE_H
