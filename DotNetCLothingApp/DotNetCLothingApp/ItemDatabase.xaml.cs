﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DotNetCLothingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDatabase : ContentPage
    {
        private SQLiteConnection _database;

        public static ItemDatabase Instance = new ItemDatabase();

        public ItemDatabase()
        {
            InitializeComponent();
        }
    }
}