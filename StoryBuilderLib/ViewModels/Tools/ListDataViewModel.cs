﻿using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace StoryBuilder.ViewModels.Tools;

public class ListDataViewModel : ObservableRecipient
{
    #region fields

    private string _title;

    #endregion

    #region Properties

    public string Title
    {
        get => _title;
        set => SetProperty(ref _title, value);
    }

    #endregion

    #region Combobox and ListBox sources

    public ObservableCollection<string> DataList = new();

    #endregion

}