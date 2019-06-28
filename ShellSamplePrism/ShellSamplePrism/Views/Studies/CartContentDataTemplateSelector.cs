using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ShellSamplePrism.ViewModels.Studies;
using Xamarin.Forms;

namespace ShellSamplePrism.Views.Studies
{
    public class CartContentDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ContentItemTemplate { get; set; }
        public DataTemplate CheckoutItemTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {

            CartItemGroup CartItem = item is CartItemGroup itemGroup ? itemGroup : default;
            CollectionView view = container as CollectionView;
            var vm = view.BindingContext as ShrineMenuPageViewModel;
            ObservableCollection<CartItemGroup> cartItemGroups = vm.CartItemsGroups as ObservableCollection<CartItemGroup>;

            var index = cartItemGroups.IndexOf(item is CartItemGroup cartItemGroup ? cartItemGroup : default);
            if (index == cartItemGroups.Count - 1)
            {
                return CheckoutItemTemplate;
            }

            return ContentItemTemplate;
        }

    }
}
