using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace lab7_avalonia_oliGaw.Views
{
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();

            AnalyzeButton.Click += AnalyzeButtonClicked;
            ClearButton.Click += ClearButtonClicked;
        }

        private void AnalyzeButtonClicked(object? sender, RoutedEventArgs e)
        {
            string dnaSequence = DnaInputTextBox.Text?.ToUpperInvariant() ?? "";
            if (string.IsNullOrWhiteSpace(dnaSequence))
            {
                ResultsTextBlock.Text = "Please enter a DNA sequence.";
                return;
            }

            
            int aCount = dnaSequence.Split('A').Length - 1;
            int cCount = dnaSequence.Split('C').Length - 1;
            int gCount = dnaSequence.Split('G').Length - 1;
            int tCount = dnaSequence.Split('T').Length - 1;

            ResultsTextBlock.Text = $"Analysis Results:\n" +
                                    $"A: {aCount}\n" +
                                    $"C: {cCount}\n" +
                                    $"G: {gCount}\n" +
                                    $"T: {tCount}";
        }

        private void ClearButtonClicked(object? sender, RoutedEventArgs e)
        {
            DnaInputTextBox.Text = "";
            ResultsTextBlock.Text = "";
        }
    }
}
