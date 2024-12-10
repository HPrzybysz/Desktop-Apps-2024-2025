#ifndef BRIGHTNESSDIALOG_H
#define BRIGHTNESSDIALOG_H

#include <QDialog>
#include <QSlider>
#include <QVBoxLayout>
#include <QLabel>
#include <QPushButton>

class BrightnessDialog : public QDialog {
    Q_OBJECT

public:
    explicit BrightnessDialog(QWidget *parent = nullptr);

    int getLevel() const { return level; }

private:
    QSlider *slider;
    QLabel *label;
    QPushButton *confirmButton;
    int level;

private slots:
    void updateLabel(int value);
    void onConfirm();
};

#endif // BRIGHTNESSDIALOG_H
