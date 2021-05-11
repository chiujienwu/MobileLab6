using MobileLab6.Model;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileLab6
{
    public partial class App : Application
    {
        public static IList<QAItem> list { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            if (list == null)
            {
                list = new List<QAItem>
                {
                    new QAItem
                    {
                        Question = "In JavaScript, if(new Date()) will evaluate to",
                        Answer = true
                    },
                    new QAItem
                    {
                        Question = @"In JavaScript, if(""false"") will evaluate to",
                        Answer = true
                    },
                    new QAItem
                    {
                        Question = "In Java, if Object is null, it will evaluate to",
                        Answer = false
                    },
                    new QAItem
                    {
                        Question = "In Java, if Collection is empty or null, it will evaluate to",
                        Answer = false
                    },
                    new QAItem
                    {
                        Question = "In Java, if there no further elements of a given iterator, it will evalute to",
                        Answer = false
                    }
                };
            }

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
