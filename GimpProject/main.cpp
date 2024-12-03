#include <QApplication>
#include "mainwindow.h"

int main(int argc, char *argv[]) {
    QApplication app(argc, argv);

    // Create and show the MainWindow
    MainWindow window;
    window.setWindowTitle("Image Editor");
    window.resize(800, 600);
    window.show();

    return app.exec();
}
