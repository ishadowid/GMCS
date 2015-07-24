using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CatalogueServiceClient.Enums;
using CatalogueServiceClient.PeopleCatalogueServiceReference;
using CatalogueServiceClient.ViewModels;

namespace CatalogueServiceClient
{
    /// <summary>
    /// Interaction logic for EditRecordWindow.xaml
    /// </summary>
    public partial class EditRecordWindow : Window
    {
        public EditRecordWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var client = new PeopleCatalogueServiceClient())
            {
                var editRecordViewModel = DataContext as EditRecordViewModel;
                if (editRecordViewModel == null) return;

                try
                {
                    switch (editRecordViewModel.Mode)
                    {
                        case EditMode.Add:
                            client.AddPerson(new Person {Name = editRecordViewModel.Name, PhoneNumber = editRecordViewModel.PhoneNumber});
                            break;
                        case EditMode.Update:
                            client.UpdatePerson(new Person {Id = editRecordViewModel.Id, Name = editRecordViewModel.Name, PhoneNumber = editRecordViewModel.PhoneNumber});
                            break;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Close();
        }
    }
}
