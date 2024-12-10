#include "DesaturationDialog.h"

DesaturationDialog::DesaturationDialog(QWidget *parent) : QDialog(parent), level(0.5f) {
    slider = new QSlider(Qt::Horizontal);
    slider->setRange(0, 100); // Range from 0% to 100%
    slider->setValue(50); // Default to 50%

    label = new QLabel("Desaturation Level: 50%");

    confirmButton = new QPushButton("Confirm");

    QVBoxLayout *layout = new QVBoxLayout;
    layout->addWidget(label);
    layout->addWidget(slider);
    layout->addWidget(confirmButton);
    setLayout(layout);

    connect(slider, &QSlider::valueChanged, this, &DesaturationDialog::updateLabel);
    connect(confirmButton, &QPushButton::clicked, this, &DesaturationDialog::onConfirm);
}

void DesaturationDialog::updateLabel(int value) {
    level = value / 100.0f;
    label->setText(QString("Desaturation Level: %1%").arg(value));
}

void DesaturationDialog::onConfirm() {
    accept();
}
