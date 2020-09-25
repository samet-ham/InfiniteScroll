using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InfiniteScroll
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPage : ContentPage
    {
        private ViewModel _viewModel = new ViewModel();
        public MyPage()
        {
            InitializeComponent();
            //this.list.ItemsSource = this._viewModel.Items;
            this.list.BindingContext = _viewModel.Items;
        }

        private void list_ItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            var items = this.list.ItemsSource as IList;
            if (items != null && e.Item == items[items.Count - 1])
            {
                this._viewModel.Load();
            }
        }
    }
}