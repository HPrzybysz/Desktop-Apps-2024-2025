#include "BrightnessDialog.h"

BrightnessDialog::BrightnessDialog(QWidget *parent) : QDialog(parent), level(0) {
    slider = new QSlider(Qt::Horizontal);
    slider->setRange(-100, 100); // Range from -100 to 100
    slider->setValue(0); // Default to 0

    label = new QLabel("Brightness Level: 0");

    confirmButton = new QPushButton("Confirm");

    QVBoxLayout *layout = new QVBoxLayout;
    layout->addWidget(label);
    layout->addWidget(slider);
    layout->addWidget(confirmButton);
    setLayout(layout);

    connect(slider, &QSlider::valueChanged, this, &BrightnessDialog::updateLabel);
    connect(confirmButton, &QPushButton::clicked, this, &BrightnessDialog::onConfirm);
}

void BrightnessDialog::updateLabel(int value) {
    level = value;
    label->setText(QString("Brightness Level: %1").arg(value));
}

void BrightnessDialog::onConfirm() {
    accept();
}
