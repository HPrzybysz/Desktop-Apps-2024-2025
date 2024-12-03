#include "mainwindow.h"
#include <QMenuBar>
#include <QFileDialog>
#include <QMessageBox>
#include <QImage>
#include <QPixmap>
#include <QHBoxLayout>

// Constructor
MainWindow::MainWindow(QWidget* parent)
    : QMainWindow(parent), imageLabel(new QLabel(this)) {
    // Set up the layout to hold the QLabel
    setCentralWidget(imageLabel);

    // Set up menu bar
    QMenu* fileMenu = menuBar()->addMenu("File");

    // Create actions for "Open" and "Save"
    QAction* openAction = new QAction("Open", this);
    QAction* saveAction = new QAction("Save", this);

    // Add actions to the menu
    fileMenu->addAction(openAction);
    fileMenu->addAction(saveAction);

    // Connect actions to slots
    connect(openAction, &QAction::triggered, this, &MainWindow::openFile);
    connect(saveAction, &QAction::triggered, this, &MainWindow::saveFile);
}

// Slot to open a file
void MainWindow::openFile() {
    QString fileName = QFileDialog::getOpenFileName(this, "Open PPM File", "", "PPM Files (*.ppm)");
    if (!fileName.isEmpty()) {
        try {
            image.load(fileName.toStdString());  // Load image into PortableAnymap
            QImage qImage = convertToQImage(image);  // Convert to QImage
            imageLabel->setPixmap(QPixmap::fromImage(qImage));  // Display image
            imageLabel->adjustSize();  // Adjust QLabel size to fit the image
            QMessageBox::information(this, "Success", "File loaded successfully.");
        } catch (const std::exception& e) {
            QMessageBox::critical(this, "Error", e.what());
        }
    }
}

// Slot to save a file
void MainWindow::saveFile() {
    QString fileName = QFileDialog::getSaveFileName(this, "Save PPM File", "", "PPM Files (*.ppm)");
    if (!fileName.isEmpty()) {
        try {
            image.save(fileName.toStdString());  // Save the image to file
            QMessageBox::information(this, "Success", "File saved successfully.");
        } catch (const std::exception& e) {
            QMessageBox::critical(this, "Error", e.what());
        }
    }
}

// Convert PortableAnymap to QImage
QImage MainWindow::convertToQImage(const PortableAnymap& img) {
    int width = img.width();        // Get image width
    int height = img.height();       // Get image height

    QImage qImage(width, height, QImage::Format_RGB888);  // Create a QImage with RGB format

    const auto& pixels = img.pixelData();
    for (int y = 0; y < height; ++y) {
        for (int x = 0; x < width; ++x) {
            // Assuming `pixelData` returns a color in RGB format
            int index = (y * width + x) * 3;
            int red = pixels[index];
            int green = pixels[index + 1];
            int blue = pixels[index + 2];
            qImage.setPixel(x, y, qRgb(red, green, blue));  // Set pixel in QImage
        }
    }

    return qImage;
}
