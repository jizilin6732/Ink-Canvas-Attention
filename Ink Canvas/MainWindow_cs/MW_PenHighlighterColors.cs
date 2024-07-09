﻿using System.Windows;
using System.Windows.Controls;

namespace Ink_Canvas
{
    public partial class MainWindow : Window
    {
        private void InkAlphaSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (!isLoaded) return;
            if (sender == BoardInkAlphaSlider) InkAlphaSlider.Value = ((Slider)sender).Value;
            if (sender == InkAlphaSlider) BoardInkAlphaSlider.Value = ((Slider)sender).Value;
            drawingAttributes.Height = 20;
            drawingAttributes.Width = 5;
            Settings.Canvas.InkAlpha = (int)((Slider)sender).Value;
            SaveSettingsToFile();
            CheckColorTheme();
        }

        private void BtnHighlighterColorRed_Click(object sender, RoutedEventArgs e)
        {
            CheckLastColor(101);
            ColorSwitchCheck();
        }

        private void BtnHighlighterColorOrange_Click(object sender, RoutedEventArgs e)
        {
            CheckLastColor(102);
            ColorSwitchCheck();
        }

        private void BtnHighlighterColorYellow_Click(object sender, RoutedEventArgs e)
        {
            CheckLastColor(103);
            ColorSwitchCheck();
        }

        private void BtnHighlighterColorTeal_Click(object sender, RoutedEventArgs e)
        {
            CheckLastColor(104);
            ColorSwitchCheck();
        }
        private void BtnHighlighterColorBlue_Click(object sender, RoutedEventArgs e)
        {
            CheckLastColor(105);
            ColorSwitchCheck();
        }

        private void BtnHighlighterColorPurple_Click(object sender, RoutedEventArgs e)
        {
            CheckLastColor(106);
            ColorSwitchCheck();
        }
    }
}