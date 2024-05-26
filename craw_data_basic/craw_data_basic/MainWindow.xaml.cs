using craw_data_basic.all_class;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http;
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

namespace craw_data_basic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Menu_Tree_Item> tree_Items;
        HttpClient httpClient ;
        HttpClientHandler HttpClientHandler ;
        CookieContainer CookieContainer = new CookieContainer();
        public MainWindow()
        {
            InitializeComponent();

            init_httpclient();
            

            tree_Items = new ObservableCollection<Menu_Tree_Item>();
             

            tree_main.ItemsSource = tree_Items;
        }

        void init_httpclient()
        {
            HttpClientHandler = new HttpClientHandler()
            {
                CookieContainer = CookieContainer,
                ClientCertificateOptions = ClientCertificateOption.Automatic,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                AllowAutoRedirect = true,
                UseDefaultCredentials = false
            };

            httpClient = new HttpClient(HttpClientHandler);

            //httpClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/124.0.0.0 Safari/537.36");
            /*header:
             * origin
             * host
             * referer
             * ....
             */
            httpClient.BaseAddress = new Uri("https://howkteam.vn/");
        }

        void add_item_to_treeview(ObservableCollection<Menu_Tree_Item> root, Menu_Tree_Item node)
        {
            root.Add(node);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*
            Menu_Tree_Item t3 = new Menu_Tree_Item()
            {
                Name = "Foo",
                Url = "Bar",
                Items = new ObservableCollection<Menu_Tree_Item>()
                {
                    new Menu_Tree_Item() {Name= "Foo", Url = "Bar"},
                    new Menu_Tree_Item() {Name= "Foo", Url = "Bar"},
                    new Menu_Tree_Item() {Name= "Foo", Url = "Bar"},
                }
            };

            add_item_to_treeview(tree_Items[1].Items, t3);
            */
        }

        private string craw_data_from_url(string s)
        {
            string html = "";
            //Request Method tren trang laf get -> dung getstringasync
            //neu la post thi dung:
            //html = httpClient.PostAsync(s, new StringContent("")).Result.Content.ReadAsStringAsync().Result;
            html = httpClient.GetStringAsync(s).Result;
            
            return html;

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            web_browser.Text = craw_data_from_url("learn");
        }
    }
}