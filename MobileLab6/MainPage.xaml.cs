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
        IList<string> strList = new List<string>();
        IList<string> imageList = new List<string>();
        int index;
        public MainPage()
        {
            InitializeComponent();

            //strList.Add("Flower Box");
            //strList.Add("Onion Patch");
            //strList.Add("Lettuce Lattice");
            //strList.Add("Tomato Tub");
            //imageList.Add("flower_box.jpg");
            //imageList.Add("img_1.jpg");
            //imageList.Add("img_2.jpg");
            //imageList.Add("img_3.jpg");
            //index = 0;
        }

        void OnSwiped(object sender, SwipedEventArgs e)
        {
            theLabel.Text = e.Direction.ToString() + " " + index;
            if (e.Direction == SwipeDirection.Right)
            {
                if (index >= strList.Count - 1)
                {
                    index = -1;
                }
                //theLabel.Text = strList[++index];
                //theImage.Source = imageList[index];
            }
            else if (e.Direction == SwipeDirection.Left)
            {
                if (index <= 0)
                {
                    index = strList.Count;
                }
                //theLabel.Text = strList[--index];
                //theImage.Source = imageList[index];
            }
        }

    }
}
