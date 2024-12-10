#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QFileDialog>
#include <QMessageBox>
#include <QImage>
#include <QPixmap>
#include <QVBoxLayout>


MainWindow::MainWindow(QWidget *parent)

    : QMainWindow(parent), ui(new Ui::MainWindow) {

    ui->setupUi(this);

    imageLabel = new QLabel(this);

    setCentralWidget(imageLabel); // Set QLabel as the central widget

    // Connect actions

    connect(ui->actionOpen, &QAction::triggered, this, &MainWindow::openImage);

    connect(ui->actionSave, &QAction::triggered, this, &MainWindow::saveImage);

    connect(ui->actionDesaturate, &QAction::triggered, this, &MainWindow::desaturateImage);

    connect(ui->actionNegative, &QAction::triggered, this, &MainWindow::negativeImage);

    connect(ui->actionBrightness, &QAction::triggered, this, &MainWindow::showBrightnessDialog);

    connect(ui->actionSaturation, &QAction::triggered, this, &MainWindow::showSaturationDialog);

    connect(ui->actionContrast, &QAction::triggered, this, &MainWindow::showContrastDialog);
}


MainWindow::~MainWindow() {
    delete ui;
}

void MainWindow::openImage() {
    QString filename = QFileDialog::getOpenFileName(this, "Open PPM Image", "", "PPM Files (*.ppm)");
    if (!filename.isEmpty()) {
        if (!m_image.load(filename.toStdString())) {
            QMessageBox::warning(this, "Error", "Failed to load image.");
        } else {
            displayImage(); // Call displayImage to show the loaded image
        }
    }
}

void MainWindow::displayImage() {
    // Create a QImage from the PPM data
    QImage image(m_image.width(), m_image.height(), QImage::Format_RGB888);
    const auto& data = m_image.data();

    for (unsigned int y = 0; y < m_image.height(); ++y) {
        for (unsigned int x = 0; x < m_image.width(); ++x) {
            int index = (y * m_image.width() + x) * 3; // RGB triplet
            image.setPixel(x, y, qRgb(data[index], data[index + 1], data[index + 2]));
        }
    }

    // Convert QImage to QPixmap and display it
    imageLabel->setPixmap(QPixmap::fromImage(image));
    imageLabel->adjustSize(); // Adjust the label size to fit the image
}

void MainWindow::saveImage() {
    QString filename = QFileDialog::getSaveFileName(this, "Save PPM Image", "", "PPM Files (*.ppm)");
    if (!filename.isEmpty()) {
        if (!m_image.save(filename.toStdString())) {
            QMessageBox::warning(this, "Error", "Failed to save image.");
        }
    }
}

void MainWindow::desaturateImage() {

    DesaturationDialog dialog(this);

    if (dialog.exec() == QDialog::Accepted) {

        float level = dialog.getLevel(); // Get the selected level

        m_image.desaturate(level); // Call the scalable desaturate method

        displayImage(); // Update the displayed image

    }

}

void MainWindow::negativeImage() {

    m_image.negative(); // Call the negative method

    displayImage(); // Update the displayed image

}

void MainWindow::showBrightnessDialog() {

    BrightnessDialog dialog(this);

    if (dialog.exec() == QDialog::Accepted) {

        int brightnessLevel = dialog.getLevel();

        m_image.adjustBrightness(brightnessLevel);

        displayImage();

    }

}


void MainWindow::showSaturationDialog() {

    SaturationDialog dialog(this);

    if (dialog.exec() == QDialog::Accepted) {

        float saturationLevel = dialog.getLevel();

        m_image.adjustSaturation(static_cast<int>(saturationLevel * 100));

        displayImage();

    }

}

void MainWindow::showContrastDialog() {

    ContrastDialog dialog(this);

    if (dialog.exec() == QDialog::Accepted) {

        float contrastLevel = dialog.getLevel();

        m_image.adjustContrast(static_cast<int>(contrastLevel * 100));

        displayImage();

    }

}
