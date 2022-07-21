using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartGrid.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SmartGridPage : ContentPage
    {
        public SmartGridPage()
        {
            InitializeComponent();
            SScren();
        }

        int GetScreenSize()
        {
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
            var _Width = mainDisplayInfo.Width;
            var _Height = mainDisplayInfo.Height;

            if (_Width < _Height)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        void SScren()
        {
            if (GetScreenSize() == 1)
            {
                VerticalGrid();
            }
            else
                HorizontalGrid();
        }

        void HorizontalGrid() // 2 Column 1 Row 
        {
            Grid _MainGrid = new Grid()
            {
                RowDefinitions =
                {
                    new RowDefinition{Height = new GridLength(1,GridUnitType.Star)}
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition(),
                    new ColumnDefinition()
                }
            };

            Mgrid = _MainGrid;
            Mgrid.Children.Add(BoxBlack, 0, 0);
            Mgrid.Children.Add(BoxRed, 1, 0);
            Content = Mgrid;
            
        }
        void VerticalGrid() // 1 Column 2 Row
        {
            Grid _MainGrid = new Grid()
            {
                RowDefinitions =
                {
                    new RowDefinition{Height = new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height = new GridLength(1,GridUnitType.Star)}
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition()
                }
            };

            Mgrid = _MainGrid;
            Mgrid.Children.Add(BoxBlack, 0, 0);
            Mgrid.Children.Add(BoxRed, 0, 1);
            Content = Mgrid;
        }
    }
}