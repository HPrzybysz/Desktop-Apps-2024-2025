#ifndef SATURATIONDIALOG_H
#define SATURATIONDIALOG_H

#include <QDialog>
#include <QSlider>
#include <QVBoxLayout>
#include <QLabel>
#include <QPushButton>

class SaturationDialog : public QDialog {
    Q_OBJECT

public:
    explicit SaturationDialog(QWidget *parent = nullptr);

    float getLevel() const { return level; }

private:
    QSlider *slider;
    QLabel *label;
    QPushButton *confirmButton;
    float level;

private slots:
    void updateLabel(int value);
    void onConfirm();
};

#endif // SATURATIONDIALOG_H
