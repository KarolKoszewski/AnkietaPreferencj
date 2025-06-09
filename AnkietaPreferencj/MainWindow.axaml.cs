using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AnkietaPreferencj;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private string userName = "";
    private string zainteresowania = "";
    
    private void PotwierdzDane(object? sender, RoutedEventArgs e)
    {
        userName = NameTextBox.Text ?? "";
        zainteresowania = (CategoryComboBox.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "";
    }
    
    private void Podsumuj(object? sender, RoutedEventArgs e)
    {
        int licznikTak = 0;
        if(Q1CheckBox.IsChecked == true)
        {
            licznikTak++;
        }

        if (Q2CheckBox.IsChecked == true)
        {
            licznikTak++;
        }

        if (Q3CheckBox.IsChecked == true)
        {
            licznikTak++;
        }

        tekstPodsumujacy.Text = $"Użytkownika: {userName}\n" +
                                $"Kategoria: {zainteresowania}\n" +
                                $"Odpowiedzi Tak: {licznikTak}\n";
        Podsumowanie.IsVisible = true;
    }
}