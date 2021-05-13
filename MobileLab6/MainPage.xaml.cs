using MobileLab6.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileLab6
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private int score;
        private int index = 0;
        public MainPage()
        {
            InitializeComponent();

                IList<QAItem> list = new List<QAItem>
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
            
            this.BindingContext = list[0];
        }

        private async void OnSwiped(object sender, SwipedEventArgs e)
        {
            //theLabel.Text = e.Direction.ToString() + " " + index;
            
            if (e.Direction == SwipeDirection.Right)
            {

                await DisplayAlert("Swiped", "To the Right", "True");
                if (index > 4)
                {
                    index = 0;
                } else
                {
                    index++;
                }

                //if (index >= strList.Count - 1)
                //{
                //    index = -1;
                //}
                //theLabel.Text = strList[++index];
                //theImage.Source = imageList[index];
            }
            else if (e.Direction == SwipeDirection.Left)
            {
                await DisplayAlert("Swiped", "To the Left", "False");
                if (index == 0)
                {
                    index = 4;
                }
                else
                {
                    index--;
                }
                //if (index <= 0)
                //{
                //    index = strList.Count;
                //}
                //theLabel.Text = strList[--index];
                //theImage.Source = imageList[index];
            }
        }

    }
}
