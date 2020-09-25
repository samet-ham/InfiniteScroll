using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace InfiniteScroll
{
    public class ViewModel
    {
        public ObservableCollection<string> Items { get; set; }

        public ICommand LoadCommand { get; set; }

        public ViewModel()
        {
            this.Items = new ObservableCollection<string>();
            this.Load();
        }


        public void Load()
        {
            int _index = 0;
            for (int i = 0; i < 10; i++)
            {
                this.Items.Add(string.Format("Item {0}", _index++));
            }
        }
    }
}
