#ifndef DESATURATIONDIALOG_H
#define DESATURATIONDIALOG_H

#include <QDialog>
#include <QSlider>
#include <QVBoxLayout>
#include <QLabel>
#include <QPushButton> // Include QPushButton

class DesaturationDialog : public QDialog {
    Q_OBJECT

public:
    explicit DesaturationDialog(QWidget *parent = nullptr);

    float getLevel() const { return level; }

private:
    QSlider *slider;
    QLabel *label;
    QPushButton *confirmButton; // Add a confirm button
    float level;

private slots:
    void updateLabel(int value);
    void onConfirm(); // Slot for confirm button
};

#endif // DESATURATIONDIALOG_H
