#ifndef CONTRASTDIALOG_H
#define CONTRASTDIALOG_H

#include <QDialog>
#include <QSlider>
#include <QVBoxLayout>
#include <QLabel>
#include <QPushButton>

class ContrastDialog : public QDialog {
    Q_OBJECT

public:
    explicit ContrastDialog(QWidget *parent = nullptr);

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

#endif // CONTRASTDIALOG_H
