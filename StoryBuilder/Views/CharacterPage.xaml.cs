using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.UI.Xaml.Controls;
using StoryBuilder.Models;
using StoryBuilder.ViewModels;
using System;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace StoryBuilder.Views;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class CharacterPage : BindablePage
{
    public CharacterViewModel CharVm => Ioc.Default.GetService<CharacterViewModel>();
    public CharacterPage()
    {
        InitializeComponent();
        DataContext = CharVm;
    }

    private async void CloseTab(Microsoft.UI.Xaml.Controls.TabView sender, Microsoft.UI.Xaml.Controls.TabViewTabCloseRequestedEventArgs args)
    {
        ContentDialog CD = new();
        CD.XamlRoot = GlobalData.XamlRoot;
        CD.Content = new TextBlock() { Text = $"Are you sure you want to delete the {args.Tab.Header} tab" };
        CD.Title = "Are you sure?";
        CD.PrimaryButtonText = "Delete";
        CD.SecondaryButtonText = "Cancel";
        await CD.ShowAsync();
    }
}