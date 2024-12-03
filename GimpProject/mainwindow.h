#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#pragma once

#include <QMainWindow>
#include <QLabel>
#include "portableanymap.h"  // Include your PortableAnymap class

class MainWindow : public QMainWindow {
    Q_OBJECT

public:
    MainWindow(QWidget* parent = nullptr);
    ~MainWindow();

private slots:
    void openFile();
    void saveFile();

private:
    QLabel* imageLabel;    // QLabel to display the image
    PortableAnymap image;  // Instance to hold the image

    // Convert PortableAnymap to QImage for display
    QImage convertToQImage(const PortableAnymap& img);
};



#endif // MAINWINDOW_H
