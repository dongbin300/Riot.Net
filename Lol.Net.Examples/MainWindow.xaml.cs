using Lol.Net.Clients;
using Lol.Net.Enums;

using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Lol.Net.Examples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string version = "13.4.1";
        LanguageEnum language = Enums.Language.English_UnitedStates;
        LolClient app;

        public MainWindow()
        {
            InitializeComponent();

            app = new LolClient();
            var result = app.DataDragon.Champions.GetChampionsAsync(version, language);
            result.Wait();

            ChampionListBox.Items.Clear();
            foreach (var item in result.Result)
            {
                ChampionListBox.Items.Add(item);
            }
        }

        private void ChampionListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = ((KeyValuePair<string, Objects.Models.LolModels.Champion>)ChampionListBox.SelectedItem).Value;
            TitleText.Text = $"{item.name}, {item.title}";
            TagsPanel.Children.Clear();
            foreach (var tag in item.tags)
            {
                TagsPanel.Children.Add(new TextBlock
                {
                    Text = tag,
                    Foreground = new SolidColorBrush(Colors.White),
                    Background = new SolidColorBrush(Colors.Gray),
                    Padding = new Thickness(3),
                    Margin = new Thickness(3)
                });
            }
            DescriptionText.Text = item.blurb;
            StatsText.Text = $"Hp: {item.stats.hp} +{item.stats.hpperlevel}\n" +
                $"Hp regen: {item.stats.hpregen} +{item.stats.hpregenperlevel}\n" +
                $"Mp: {item.stats.mp} +{item.stats.mpperlevel}\n" +
                $"Mp regen: {item.stats.mpregen} +{item.stats.mpregenperlevel}\n" +
                $"Move speed: {item.stats.movespeed}\n" +
                $"Armor: {item.stats.armor} +{item.stats.armorperlevel}\n" +
                $"Attack Range: {item.stats.attackrange}\n" +
                $"Attack Damage: {item.stats.attackdamage} +{item.stats.attackdamageperlevel}\n" +
                $"Attack Speed: {item.stats.attackspeed} +{item.stats.attackspeed}\n";
        }
    }
}
