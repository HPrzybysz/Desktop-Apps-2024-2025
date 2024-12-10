/********************************************************************************
** Form generated from reading UI file 'mainwindow.ui'
**
** Created by: Qt User Interface Compiler version 6.8.0
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_MAINWINDOW_H
#define UI_MAINWINDOW_H

#include <QtCore/QVariant>
#include <QtGui/QAction>
#include <QtWidgets/QApplication>
#include <QtWidgets/QLabel>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QMenu>
#include <QtWidgets/QMenuBar>
#include <QtWidgets/QStatusBar>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_MainWindow
{
public:
    QAction *actionDesaturate;
    QAction *actionNegative;
    QAction *actionBrightness;
    QAction *actionSaturation;
    QAction *actionContrast;
    QAction *actionOpen;
    QAction *actionSave;
    QWidget *centralwidget;
    QLabel *imageLabel;
    QStatusBar *statusbar;
    QMenuBar *menuBar;
    QMenu *menuEffects;
    QMenu *menuFile;

    void setupUi(QMainWindow *MainWindow)
    {
        if (MainWindow->objectName().isEmpty())
            MainWindow->setObjectName("MainWindow");
        MainWindow->resize(800, 600);
        actionDesaturate = new QAction(MainWindow);
        actionDesaturate->setObjectName("actionDesaturate");
        actionNegative = new QAction(MainWindow);
        actionNegative->setObjectName("actionNegative");
        actionBrightness = new QAction(MainWindow);
        actionBrightness->setObjectName("actionBrightness");
        actionSaturation = new QAction(MainWindow);
        actionSaturation->setObjectName("actionSaturation");
        actionContrast = new QAction(MainWindow);
        actionContrast->setObjectName("actionContrast");
        actionOpen = new QAction(MainWindow);
        actionOpen->setObjectName("actionOpen");
        actionSave = new QAction(MainWindow);
        actionSave->setObjectName("actionSave");
        centralwidget = new QWidget(MainWindow);
        centralwidget->setObjectName("centralwidget");
        imageLabel = new QLabel(centralwidget);
        imageLabel->setObjectName("imageLabel");
        imageLabel->setGeometry(QRect(0, 0, 801, 581));
        MainWindow->setCentralWidget(centralwidget);
        statusbar = new QStatusBar(MainWindow);
        statusbar->setObjectName("statusbar");
        MainWindow->setStatusBar(statusbar);
        menuBar = new QMenuBar(MainWindow);
        menuBar->setObjectName("menuBar");
        menuBar->setGeometry(QRect(0, 0, 800, 22));
        menuEffects = new QMenu(menuBar);
        menuEffects->setObjectName("menuEffects");
        menuFile = new QMenu(menuBar);
        menuFile->setObjectName("menuFile");
        MainWindow->setMenuBar(menuBar);

        menuBar->addAction(menuFile->menuAction());
        menuBar->addAction(menuEffects->menuAction());
        menuEffects->addAction(actionDesaturate);
        menuEffects->addAction(actionNegative);
        menuEffects->addAction(actionBrightness);
        menuEffects->addAction(actionSaturation);
        menuEffects->addAction(actionContrast);
        menuFile->addAction(actionOpen);
        menuFile->addAction(actionSave);

        retranslateUi(MainWindow);

        QMetaObject::connectSlotsByName(MainWindow);
    } // setupUi

    void retranslateUi(QMainWindow *MainWindow)
    {
        MainWindow->setWindowTitle(QCoreApplication::translate("MainWindow", "MainWindow", nullptr));
        actionDesaturate->setText(QCoreApplication::translate("MainWindow", "Desaturate", nullptr));
        actionNegative->setText(QCoreApplication::translate("MainWindow", "Negative", nullptr));
        actionBrightness->setText(QCoreApplication::translate("MainWindow", "Brightness", nullptr));
        actionSaturation->setText(QCoreApplication::translate("MainWindow", "Saturation", nullptr));
        actionContrast->setText(QCoreApplication::translate("MainWindow", "Contrast", nullptr));
        actionOpen->setText(QCoreApplication::translate("MainWindow", "Open", nullptr));
        actionSave->setText(QCoreApplication::translate("MainWindow", "Save", nullptr));
        imageLabel->setText(QString());
        menuEffects->setTitle(QCoreApplication::translate("MainWindow", "Effects", nullptr));
        menuFile->setTitle(QCoreApplication::translate("MainWindow", "File", nullptr));
    } // retranslateUi

};

namespace Ui {
    class MainWindow: public Ui_MainWindow {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_MAINWINDOW_H
