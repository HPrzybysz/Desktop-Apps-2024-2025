#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QLabel>
#include <QSlider>
#include <QPushButton>
#include <QVBoxLayout>
#include "ppmimage.h"
#include "ui_mainwindow.h"
#include "brightnessdialog.h"
#include "DesaturationDialog.h"
#include "SaturationDialog.h"
#include "ContrastDialog.h"

class MainWindow : public QMainWindow {
    Q_OBJECT

public:
    MainWindow(QWidget *parent = nullptr);
    ~MainWindow();

private slots:

    void openImage();

    void saveImage();

    void desaturateImage();

    void negativeImage();

    void showBrightnessDialog();

    void showSaturationDialog();

    void showContrastDialog();

private:
    void displayImage(); // New method to display the image
    Ui::MainWindow *ui; // UI pointer
    PPMImage m_image; // PPM image object
    QLabel *imageLabel; // QLabel to display the image
};

#endif // MAINWINDOW_H
