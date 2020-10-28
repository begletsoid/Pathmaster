﻿using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using meta.Views;

namespace meta
{
    public partial class App : Application
    {
        public const string DATABASE_NAME2 = "chapters.db";
        public const string DATABASE_NAME = "characters.db";
        public static CharacterRepository database;
        public static ChapterRepository database2;
        public static CharacterRepository Database
        {
            get
            {
                if(database == null)
                {
                    database = new CharacterRepository(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }

        }
        public static ChapterRepository Database2
        {
            get
            {
                if (database2 == null)
                {
                    database2 = new ChapterRepository(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME2));
                }
                return database2;
            }

        }
        public App()
        {
           // MainPage = new NavigationPage(Page1());
             MainPage = new NavigationPage(new CharactersListPage());
            // MainPage = new ImagesListPage();
            System.Console.WriteLine("Hello");
        }

        protected override void OnStart()
        { }

        protected override void OnSleep()
        { }

        protected override void OnResume()
        { }
    }
}
