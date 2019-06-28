using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using BuildIt;
using BuildIt.States;
using BuildIt.States.Interfaces;
using Prism.Commands;
using Prism.Navigation;
using ShellSamplePrism.Views.Studies;
using Xamarin.Forms;

namespace ShellSamplePrism.ViewModels.Studies
{
    public class ShrineMenuPageViewModel : ViewModelBase, IHasStates
    {
        private readonly INavigationService _navigationService;

        public ObservableCollection<ShrineItem> ShrineCartItems { get; } =
            new ObservableCollection<ShrineItem>();


        public ObservableCollection<ShrineItemGroup> ShrineItems { get; } =
            new ObservableCollection<ShrineItemGroup>();

        public ObservableCollection<CartItemGroup> CartItemsGroups { get; private set; } = new ObservableCollection<CartItemGroup>();
        

        private int _shrineCartWidth;

        public int ShrineCartWidth => ShrineCartItems.Count >3 ? 150: ShrineCartItems.Count*50;

        public int MoreItemsCount => ShrineCartItems.Count - 3;

        public bool ShowMoreItemsCount => MoreItemsCount > 0;


        private ShrineItem[] AllItems=new[]
        {
            new ShrineItem{Name = "ACCESSORIES", Price = 100, Image = "acc1.png", ItemType = ItemTypes.ACCESSORIES},
            new ShrineItem{Name = "HOME", Price = 100, Image = "home1.png",ItemType = ItemTypes.HOME},
            new ShrineItem{Name = "CLOTHING", Price = 100, Image = "clothing1.png",ItemType = ItemTypes.CLOTHING},
            new ShrineItem{Name = "ACCESSORIES ACCESSORIES", Price = 100, Image = "acc2.png",ItemType = ItemTypes.ACCESSORIES},
            new ShrineItem{Name = "HOME HOME", Price = 100, Image = "home2.png",ItemType = ItemTypes.HOME},
            new ShrineItem{Name = "CLOTHING CLOTHING", Price = 100, Image = "clothing2.png",ItemType = ItemTypes.CLOTHING},
            new ShrineItem{Name = "ACCESSORIES Sunglasses", Price = 100, Image = "acc3.png",ItemType = ItemTypes.ACCESSORIES},
            new ShrineItem{Name = "HOME Sunglasses", Price = 100, Image = "home3.png",ItemType = ItemTypes.HOME},
            new ShrineItem{Name = "Stella ACCESSORIES", Price = 100, Image = "acc4.png",ItemType = ItemTypes.ACCESSORIES},
            new ShrineItem{Name = "Stella CLOTHING", Price = 100, Image = "clothing3.png",ItemType = ItemTypes.CLOTHING},
            new ShrineItem{Name = "ACCESSORIES Sunglasses", Price = 100, Image = "acc1.png",ItemType = ItemTypes.ACCESSORIES},
            new ShrineItem{Name = "Stella CLOTHING", Price = 100, Image = "clothing1.png",ItemType = ItemTypes.CLOTHING},
            new ShrineItem{Name = "CLOTHING Sunglasses", Price = 100, Image = "clothing1.png",ItemType = ItemTypes.CLOTHING},
            new ShrineItem{Name = "CLOTHING Sunglasses", Price = 100, Image = "clothing1.png",ItemType = ItemTypes.CLOTHING},
            new ShrineItem{Name = "Stella ACCESSORIES", Price = 100, Image = "acc2.png",ItemType = ItemTypes.ACCESSORIES},
            new ShrineItem{Name = "Stella ACCESSORIES", Price = 100, Image = "home1.png",ItemType = ItemTypes.HOME},
            new ShrineItem{Name = "Stella ACCESSORIES", Price = 100, Image = "acc3.png",ItemType = ItemTypes.ACCESSORIES}
        };

        private CurrentOption _currentOption;

        public CurrentOption CurrentOption
        {
            get { return _currentOption; }
            set { SetProperty(ref _currentOption, value); }
        }

        public ShrineMenuPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            Title = "MENU";
            _currentOption = CurrentOption.ALL;

            StateManager.Group<MenuStates>().DefineAllStates();

            StateManager.GoToState(MenuStates.Show);
            
        }

        private DelegateCommand<string> _shrineMenuNavigationCommand;

        public DelegateCommand<string> ShrineMenuNavigationCommand =>
            _shrineMenuNavigationCommand ?? (_shrineMenuNavigationCommand = new DelegateCommand<string>(ExecuteCommandNameShrineMenuNavi, CanExecuteNavigation));

        private bool CanExecuteNavigation(string arg)
        {
            return true;
        }

        void UpdateItem(string itemType)
        {
            List<ShrineItem> filteredItems;

            ShrineItems.Clear();

            filteredItems = itemType == ItemTypes.ALL ? AllItems.ToList() : AllItems.Where(s => s.ItemType == itemType).ToList();
            

            while (filteredItems.Count >0)
            {
                var newItems = new List<ShrineItem>(filteredItems);

                if (filteredItems.Count < 3)
                {
                    ShrineItems.Add(new ShrineItemGroup
                    {
                        Items = newItems
                    });

                    filteredItems.RemoveRange(0,filteredItems.Count);
                }

                else
                {
                    ShrineItems.Add(new ShrineItemGroup
                    {
                        Items = newItems.Take(3).ToList()
                    });

                    filteredItems.RemoveRange(0,3);
                }
            }

            RaisePropertyChanged("ShrineItems");
        }


        async void ExecuteCommandNameShrineMenuNavi(string option)
        {
            switch (option)
            {
                case ItemTypes.ALL:
                    await StateManager?.GoToState(MenuStates.Hide);
                    UpdateItem(ItemTypes.ALL);
                    CurrentOption = CurrentOption.ALL;
                    break;
                case ItemTypes.ACCESSORIES:
                    await StateManager?.GoToState(MenuStates.Hide);
                    UpdateItem(ItemTypes.ACCESSORIES);
                    CurrentOption = CurrentOption.ACCESSORIES;
                    break;
                case ItemTypes.CLOTHING:
                    await StateManager?.GoToState(MenuStates.Hide);
                    UpdateItem(ItemTypes.CLOTHING);
                    CurrentOption = CurrentOption.CLOTHING;
                    break;
                case ItemTypes.HOME:
                    await StateManager?.GoToState(MenuStates.Hide);
                    UpdateItem(ItemTypes.HOME);
                    CurrentOption = CurrentOption.HOME;
                    break;
            }
        }

        private DelegateCommand _showMenuCommand;
        public DelegateCommand ShowMenuCommand =>
            _showMenuCommand ?? (_showMenuCommand = new DelegateCommand(ExecuteShowMenuCommand));

        async void ExecuteShowMenuCommand()
        {
            var currentState = StateManager.CurrentState<MenuStates>();

            if (currentState == MenuStates.Show)
            {
                switch (CurrentOption)
                {
                    case CurrentOption.ALL:
                        ExecuteCommandNameShrineMenuNavi(ItemTypes.ALL);
                        break;

                    case CurrentOption.ACCESSORIES:
                        ExecuteCommandNameShrineMenuNavi(ItemTypes.ACCESSORIES);
                        break;

                    case CurrentOption.CLOTHING:
                        ExecuteCommandNameShrineMenuNavi(ItemTypes.CLOTHING);
                        break;

                    case CurrentOption.HOME:
                        ExecuteCommandNameShrineMenuNavi(ItemTypes.HOME);
                        break;
                }
                
            }

            else
            {
                await StateManager?.GoToState(MenuStates.Show);
            }

        }

        private DelegateCommand<object> _addImageToCartCommand;
        public DelegateCommand<object> AddImageToCartCommand =>
            _addImageToCartCommand ?? (_addImageToCartCommand = new DelegateCommand<object>(ExecuteCommandNameAddImageToCartCommand));

        void ExecuteCommandNameAddImageToCartCommand(object sender)
        {
            if (sender is ShrineItem item)
            {
                ShrineCartItems.Add(item);

                RaisePropertyChanged("ShrineCartItems");
                RaisePropertyChanged("ShrineCartWidth");
                RaisePropertyChanged("MoreItemsCount");
                RaisePropertyChanged("ShowMoreItemsCount");
            }
        }

        private DelegateCommand _showCartCommand;
        public DelegateCommand ShowCartCommand =>
            _showCartCommand ?? (_showCartCommand = new DelegateCommand(ExecuteCommandNameShowCartCommand));

       async void ExecuteCommandNameShowCartCommand()
       {
           var cartItemGroupsFromCart = ShrineCartItems.ToList().GroupBy(x => x.Name);

           if (!cartItemGroupsFromCart.Any())
           {
                RaisePropertyChanged("ShrineCartItems");
                RaisePropertyChanged("ShrineCartWidth");
                RaisePropertyChanged("ShowMoreItemsCount");
                RaisePropertyChanged("MoreItemsCount");
           }

           else
           {
               var cartItemGroups = cartItemGroupsFromCart.Select(cartItemsGroup =>
                   new CartItemGroup
                   {
                       TotalGroupPrice = cartItemsGroup.Sum(x => x.Price),
                       Count = cartItemsGroup.Count(),
                       Image = cartItemsGroup.FirstOrDefault()?.Image,
                       Name = cartItemsGroup.Key
                   }).ToList();

               CartItemsGroups = new ObservableCollection<CartItemGroup>(cartItemGroups);
               RaisePropertyChanged("CartItemsGroups");
           }
          


           var currentState = StateManager.CurrentState<MenuStates>();

           if (currentState == MenuStates.ShowCart)
           {
               await StateManager.GoToState(MenuStates.Hide);
           }

           else
           {
               await StateManager.GoToState(MenuStates.ShowCart);
           }
          
       }



        public IStateManager StateManager { get; } = new StateManager();

        public enum MenuStates
        {
            Base,
            Show,
            Hide,
            ShowCart
        }

        public enum DisplayStates
        {
            Landscape,
            Portrait
        }

        public class ItemTypes
        {
            public const string ALL = "ALL";
            public const string ACCESSORIES = "ACCESSORIES";
            public const string CLOTHING = "CLOTHING";
            public const string HOME = "HOME";
        }



    }
}
