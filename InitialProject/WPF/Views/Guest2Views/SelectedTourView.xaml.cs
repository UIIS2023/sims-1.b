﻿using InitialProject.Application.UseCases;
using InitialProject.Domain.Models;
using InitialProject.Domain.RepositoryInterfaces;
using InitialProject.Repositories;
using InitialProject.WPF.ViewModels.Guest2ViewModels;
using InitialProject.WPF.Views.Guest2Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace InitialProject.WPF.Views
{
    /// <summary>
    /// Interaction logic for TourReservationForm.xaml
    /// </summary>
    public partial class SelectedTourView : Page
    {
        public SelectedTourView(Tour selectedTour, User loggedUser)
        {
            InitializeComponent();
            this.DataContext = new SelectedTourViewModel(loggedUser, selectedTour);
            Guest2MainWindow.mainWindow.Guest2MainPreview.Content = this;
        }
    }
}
