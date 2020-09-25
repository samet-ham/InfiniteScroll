using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Xaml;

namespace InfiniteScroll
{
    public class InfiniteScrollListView : ListView
    {
        public static readonly BindableProperty LoadCommadProperty = BindableProperty.Create<InfiniteScrollListView, ICommand>(bp => bp.LoadCommand, default(ICommand));
        public ICommand LoadCommand 
        {
            get { return (ICommand)this.GetValue(LoadCommadProperty); }
            set { this.SetValue(LoadCommadProperty, value); } 
        }
        public InfiniteScrollListView()
        {
            this.ItemAppearing += InfiniteScrollListView_ItemAppearing;
        }

        private void InfiniteScrollListView_ItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            var items = this.ItemsSource as IList;
            if (items != null && e.Item == items[items.Count -1])
            {
                if (this.LoadCommand != null && this.LoadCommand.CanExecute(null))
                {
                    this.LoadCommand.Execute(null);
                }
            }
        }
    }
}
