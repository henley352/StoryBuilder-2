﻿using CommunityToolkit.Mvvm.ComponentModel;
using StoryBuilder.Models;
using StoryBuilder.Services.Navigation;
using System;
using System.Threading.Tasks;

namespace StoryBuilder.ViewModels;

public class TrashCanViewModel : ObservableRecipient, INavigable
{
    #region Fields

    #endregion

    #region Properties

    // StoryElement data

    private Guid _uuid;
    public Guid Uuid
    {
        get => _uuid;
        set => SetProperty(ref _uuid, value);
    }

    private string _name;
    public string Name
    {
        get => _name;
        set => SetProperty(ref _name, value);
    }

    // There is no data for this View   

    // The StoryModel is passed when TrashCanPage is navigated to
    private TrashCanModel _model;
    public TrashCanModel Model
    {
        get => _model;
        set => SetProperty(ref _model, value);
    }

    #endregion

    #region Methods

    public void Activate(object parameter)
    {
        Model = (TrashCanModel)parameter;
        LoadModel();
    }

    public void Deactivate(object parameter)
    {
        SaveModel();
    }

    private void LoadModel()
    {
        Uuid = Model.Uuid;
        Name = Model.Name;

    }

    private void SaveModel()
    {
        /* Nothing to do */
    }

    #endregion
}