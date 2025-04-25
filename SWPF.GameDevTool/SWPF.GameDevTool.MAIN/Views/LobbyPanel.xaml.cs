using System;
using System.Collections.Generic;
using System.Linq;
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

namespace SWPF.GameDevTool.MAIN.Views
{
    /// <summary>
    /// LobbyPanel.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LobbyPanel : UserControl
    {
        public event EventHandler AppBtnClick;

        public LobbyPanel()
        {
            InitializeComponent();

            InitMenuControl();
        }
        private void InitMenuControl()
        {

            for (int i = 0; i < 2; i++)
            {
                gdMainMenu.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < 2; i++)
            {
                gdMainMenu.ColumnDefinitions.Add(new ColumnDefinition());
            }

            var panel = NewIconPanel();
            var appBtn = new Button()
            {
                Content = "앱 실행",
                Margin = new Thickness(4),
                Tag = "MAP"
            };
            appBtn.Click += (s, e) =>
            {
                AppBtnClick?.Invoke(s, e);
            };

            // 버튼을 gdMainMenu의 (0, 0) 위치에 배치
            Grid.SetRow(appBtn, 0);
            Grid.SetColumn(appBtn, 0);
            // 실제로 Grid에 추가
            gdMainMenu.Children.Add(appBtn);
        }

        private StackPanel NewIconPanel()
        {
            return new StackPanel()
            {
                Height = 86,
                Width = 58,
                Margin = new Thickness(0, 12, 0, 0),
                HorizontalAlignment = HorizontalAlignment.Center,
                Tag = "IconPanel"
            };
        }
    }
}
