using Newtonsoft.Json;
using Perky_Rabbit_Assessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Perky_Rabbit_Assessment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HttpClient client= new HttpClient();
        public MainWindow()
        {
            client.BaseAddress = new Uri("https://localhost:7111/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.getCategorys();
        }

        private async void getCategorys()
        {
            lblMessage.Content = "";

            var response = await client.GetStringAsync("categories");
            var categorys = JsonConvert.DeserializeObject<List<Category>>(response);
            dgCategory.DataContext= categorys;
        }

        private async void saveCategory(Category category)
        {
           await client.PostAsJsonAsync("categories", category);
        }

        private async void updateCategory(Category category)
        {
            await client.PutAsJsonAsync("categories/" + category.categoryId, category);
        }

        private async void deleteCategory(int categoryId)
        {
            await client.DeleteAsync("categories/" + categoryId);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var category = new Category()
            {
                categoryId = Convert.ToInt32(txtCategoryId.Text),
                Name = txtName.Text
            };

            if (category.categoryId == 0)
            {
                this.saveCategory(category);
                lblMessage.Content = "Category Saved";
            }
            else
            {
                this.updateCategory(category);
                lblMessage.Content = "Category Updated";
            }

            txtCategoryId.Text = 0.ToString();
            txtName.Text = "";
        }

        void btnEditCategory(object sender, RoutedEventArgs e)
        {
            Category category = ((FrameworkElement)sender).DataContext as Category;
            txtCategoryId.Text=category.categoryId.ToString();
            txtName.Text = category.Name;
        }

        void btnDeleteCategory(object sender, RoutedEventArgs e)
        {
            Category category = ((FrameworkElement)sender).DataContext as Category;
            this.deleteCategory(category.categoryId);
        }
    }
}
