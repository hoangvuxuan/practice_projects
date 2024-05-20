using craw_data_basic.all_class;
using System.Collections.ObjectModel;
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
        public MainWindow()
        {
            InitializeComponent();
            tree_Items = new ObservableCollection<Menu_Tree_Item>();
            Menu_Tree_Item t1 = new Menu_Tree_Item()
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

            Menu_Tree_Item t2 = new Menu_Tree_Item()
            {
                Name = "Foo",
                Url = "Bar",
                Items = new ObservableCollection<Menu_Tree_Item>()
                {
                    new Menu_Tree_Item() {Name= "Foo", Url = "Bar"},
                }
            };

            add_item_to_treeview(tree_Items, t1);
            add_item_to_treeview(tree_Items, t2);

            tree_main.ItemsSource = tree_Items;
        }

        void add_item_to_treeview(ObservableCollection<Menu_Tree_Item> root, Menu_Tree_Item node)
        {
            root.Add(node);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
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
        }
    }
}