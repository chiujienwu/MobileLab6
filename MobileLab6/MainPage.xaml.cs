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
        IList<QAItem> list = new List<QAItem>();
        private int score = 0;
        private int index = 0;
        public MainPage()
        {
            InitializeComponent();
            list.Add(new QAItem
            {
                Question = "In JavaScript, expression if(new Date()) will evaluate to?",
                Answer = true
            });
            list.Add(new QAItem
            {
                Question = @"In JavaScript, expression if(""false"") will evaluate to?",
                Answer = true
            });
            list.Add(new QAItem
            {
                Question = "In Java, if an Object is null, it will evaluate to?",
                Answer = false
            });
            list.Add(new QAItem
            {
                Question = "In Java, if a Collection is empty or null, it will evaluate to?",
                Answer = false
            });
            list.Add(new QAItem
            {
                Question = "In Java, if there no further elements of a given iterator, it will evalute to?",
                Answer = false
            });

            this.BindingContext = list[index];
        }

        private async void OnSwiped(object sender, SwipedEventArgs e)
        {
            //theLabel.Text = e.Direction.ToString() + " " + index;
            
            if (e.Direction == SwipeDirection.Right)
            {
                await DisplayAlert("Swiped", "To the Right", "True");

                if(list[index].Answer == true)
                {
                    score++;
                    await DisplayAlert("Answer", "Correct!", "Next");
                } else
                {
                    await DisplayAlert("Answer", "Incorrect!", "Next");
                }
            }
            else if (e.Direction == SwipeDirection.Left)
            {
                await DisplayAlert("Swiped", "To the Left", "False");

                if (list[index].Answer == false)
                {
                    score++;
                    await DisplayAlert("Answer", "Correct!", "Next");
                } else
                {
                    await DisplayAlert("Answer", "Incorrect!", "Next");
                }
            }

            if((index + 1) >= list.Count)
            {
                await DisplayAlert("Final Score", "You scored " + score + " out of " + list.Count, "Done");
            } else
            {
                index++;
            }
            
            this.BindingContext = list[index];
        }
    }
}
