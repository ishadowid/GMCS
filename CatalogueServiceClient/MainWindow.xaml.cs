using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CatalogueServiceClient.Enums;
using CatalogueServiceClient.PeopleCatalogueServiceReference;
using CatalogueServiceClient.ViewModels;

namespace CatalogueServiceClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainDataGrid.DataContext = new MainViewModel();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var form = new EditRecordWindow {DataContext = new EditRecordViewModel(null, EditMode.Add)};
            form.ShowDialog();
            using (var client = new PeopleCatalogueServiceClient())
            {
                try
                {
                    var mainViewModel = MainDataGrid.DataContext as MainViewModel;
                    if (mainViewModel != null)
                    {
                        mainViewModel.DataCollection =
                            new ObservableCollection<PersonViewModel>(
                                client.GetAddressBook()
                                    .Select(p => new PersonViewModel {Id = p.Id, Name = p.Name, PhoneNumber = p.PhoneNumber}));
                        MainDataGrid.DataContext = null;
                        MainDataGrid.DataContext = mainViewModel;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainDataGrid.SelectedItem == null) return;
            var selectedItem = MainDataGrid.SelectedItem as PersonViewModel;
            var form = new EditRecordWindow { DataContext = new EditRecordViewModel(selectedItem, EditMode.Update) };
            form.ShowDialog();
            using (var client = new PeopleCatalogueServiceClient())
            {
                try
                {
                    var mainViewModel = MainDataGrid.DataContext as MainViewModel;
                    if (mainViewModel != null)
                    {
                        mainViewModel.DataCollection =
                            new ObservableCollection<PersonViewModel>(
                                client.GetAddressBook()
                                    .Select(p => new PersonViewModel { Id = p.Id, Name = p.Name, PhoneNumber = p.PhoneNumber }));
                        MainDataGrid.DataContext = null;
                        MainDataGrid.DataContext = mainViewModel;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainDataGrid.SelectedItem == null) return;
            var selectedItem = MainDataGrid.SelectedItem as PersonViewModel;
            if (selectedItem == null) return;
            using (var client = new PeopleCatalogueServiceClient())
            {
                try
                {
                    client.DeletePerson(new Person { Id = selectedItem.Id, Name = selectedItem.Name, PhoneNumber = selectedItem.PhoneNumber });
                    var mainViewModel = MainDataGrid.DataContext as MainViewModel;
                    if (mainViewModel != null)
                    {
                        mainViewModel.DataCollection =
                            new ObservableCollection<PersonViewModel>(
                                client.GetAddressBook()
                                    .Select(p => new PersonViewModel { Id = p.Id, Name = p.Name, PhoneNumber = p.PhoneNumber }));
                        MainDataGrid.DataContext = null;
                        MainDataGrid.DataContext = mainViewModel;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TextBoxBase_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var type = SearchTypeComboBox.SelectedIndex;
            var mainViewModel = MainDataGrid.DataContext as MainViewModel;
            if (mainViewModel == null) return;

            if (String.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                using (var client = new PeopleCatalogueServiceClient())
                {
                    try
                    {
                        mainViewModel.DataCollection = new ObservableCollection<PersonViewModel>(client.GetAddressBook().Select(p => new PersonViewModel { Id = p.Id, Name = p.Name, PhoneNumber = p.PhoneNumber }));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                switch (type)
                {
                    case 0:
                        using (var client = new PeopleCatalogueServiceClient())
                        {
                            try
                            {
                                mainViewModel.DataCollection =
                                    new ObservableCollection<PersonViewModel>(
                                        client.SearchPersonByName(SearchTextBox.Text)
                                            .Select(
                                                p =>
                                                    new PersonViewModel
                                                    {
                                                        Id = p.Id,
                                                        Name = p.Name,
                                                        PhoneNumber = p.PhoneNumber
                                                    }));

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        break;
                    case 1:
                        using (var client = new PeopleCatalogueServiceClient())
                        {
                            try
                            {
                                mainViewModel.DataCollection =
                                    new ObservableCollection<PersonViewModel>(
                                        client.SearchPersonByPhone(SearchTextBox.Text)
                                            .Select(
                                                p =>
                                                    new PersonViewModel
                                                    {
                                                        Id = p.Id,
                                                        Name = p.Name,
                                                        PhoneNumber = p.PhoneNumber
                                                    }));

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        break;
                } 
            }

            MainDataGrid.DataContext = null;
            MainDataGrid.DataContext = mainViewModel;
        }
    }
}
