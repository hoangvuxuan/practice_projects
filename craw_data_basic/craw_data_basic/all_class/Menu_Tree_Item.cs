using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace craw_data_basic.all_class
{
    internal class Menu_Tree_Item
    {
        private string name;
        private string url;
        private ObservableCollection<Menu_Tree_Item> items;

        public Menu_Tree_Item()
        {
            this.items = new ObservableCollection<Menu_Tree_Item>();
        }

        public string Name { get => name; set => name = value; }
        public string Url { get => url; set => url = value; }
        public ObservableCollection<Menu_Tree_Item> Items { get => items; set => items = value; }
    }
}
