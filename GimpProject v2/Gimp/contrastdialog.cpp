#include "contrastdialog.h"

ContrastDialog::ContrastDialog(QWidget *parent) : QDialog(parent), level(1.0f) { // Default to 100% contrast
    slider = new QSlider(Qt::Horizontal);
    slider->setRange(0, 200); // Range from 0% to 200%
    slider->setValue(100); // Default to 100%

    label = new QLabel("Contrast Level: 100%");

    confirmButton = new QPushButton("Confirm");

    QVBoxLayout *layout = new QVBoxLayout;
    layout->addWidget(label);
    layout->addWidget(slider);
    layout->addWidget(confirmButton);
    setLayout(layout);

    connect(slider, &QSlider::valueChanged, this, &ContrastDialog::updateLabel);
    connect(confirmButton, &QPushButton::clicked, this, &ContrastDialog::onConfirm);
}

void ContrastDialog::updateLabel(int value) {
    level = value / 100.0f;
    label->setText(QString("Contrast Level: %1%").arg(value));
}

void ContrastDialog::onConfirm() {
    accept();
}
