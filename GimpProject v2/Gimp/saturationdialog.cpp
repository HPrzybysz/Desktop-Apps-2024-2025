#include "SaturationDialog.h"

SaturationDialog::SaturationDialog(QWidget *parent) : QDialog(parent), level(1.0f) {
    slider = new QSlider(Qt::Horizontal);
    slider->setRange(0, 100); // Range
    slider->setValue(0); // Default 0%

    label = new QLabel("Saturation Level: 0%");

    confirmButton = new QPushButton("Confirm"); //confirm button

    QVBoxLayout *layout = new QVBoxLayout;
    layout->addWidget(label);
    layout->addWidget(slider);
    layout->addWidget(confirmButton);
    setLayout(layout);

    connect(slider, &QSlider::valueChanged, this, &SaturationDialog::updateLabel);
    connect(confirmButton, &QPushButton::clicked, this, &SaturationDialog::onConfirm); //button click
}

void SaturationDialog::updateLabel(int value) {
    level = value / 100.0f; // Convert to a float
    label->setText(QString("Saturation Level: %1%").arg(value));
}

void SaturationDialog::onConfirm() {
    accept();
}
