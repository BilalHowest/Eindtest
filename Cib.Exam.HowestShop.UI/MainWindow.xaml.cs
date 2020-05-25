using Cib.Exam.HowestShop.Domain.Entities;
using Cib.Exam.HowestShop.Domain.Services;
using System;
using System.Windows;

namespace Cib.Exam.HowestShop.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ShopService _shopService;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _shopService = new ShopService();

            FillCategoryComboBox();
            FillProductListBox();
        }

        private void BtnNewProductAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = txtNewProductName.Text;
                Category category = (Category)cmbNewProductCategory.SelectedItem;
                string price = txtNewProductPrice.Text;

                _shopService.AddNewProduct(name, category, price);

                FillProductListBox();
                ClearInputControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fout!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnProductDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product productToDelete = (Product)lstProducts.SelectedItem;

                _shopService.DeleteProduct(productToDelete);

                FillProductListBox();
                ClearInputControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fout!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ClearInputControls()
        {
            txtNewProductName.Clear();
            txtNewProductPrice.Clear();
            cmbNewProductCategory.SelectedIndex = -1;
        }

        private void FillProductListBox()
        {
            lstProducts.Items.Clear();
            foreach (Product product in _shopService.ProductsInShop)
            {
                lstProducts.Items.Add(product);
            }
        }

        private void FillCategoryComboBox()
        {
            cmbNewProductCategory.Items.Clear();
            foreach (Category category in _shopService.CategoriesInShop)
            {
                cmbNewProductCategory.Items.Add(category);
            }
        }
    }
}
