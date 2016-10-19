using System.Collections.Generic;
using CoreGraphics;
using UIKit;

namespace RotatingWheelDemo
{
    public class MyViewController : UIViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var rotatingWheel = new RotatingWheelView(new CGRect(0, 0, 800, 800), new RotatingWheelSettings()
                {
                    BackgroundImage = UIImage.FromBundle("images/bg.png"),
                    CenterButtonImage = UIImage.FromBundle("images/centerButton.png"),
                    SegmentImage = UIImage.FromBundle("images/segment.png"),
                    Slices = new List<RotatingWheelSettings.WheelSliceValue>()
                        {
                            new RotatingWheelSettings.WheelSliceValue
                                {
                                    Image = UIImage.FromBundle("images/icon0.png"),
                                    Value = "Circle"
                                },
                            new RotatingWheelSettings.WheelSliceValue
                                {
                                    Image = UIImage.FromBundle("images/icon1.png"),
                                    Value = "Circle"
                                },
                            new RotatingWheelSettings.WheelSliceValue
                                {
                                    Image = UIImage.FromBundle("images/icon2.png"),
                                    Value = "Circle"
                                },
                            new RotatingWheelSettings.WheelSliceValue
                                {
                                    Image = UIImage.FromBundle("images/icon3.png"),
                                    Value = "Circle"
                                },
                            new RotatingWheelSettings.WheelSliceValue
                                {
                                    Image = UIImage.FromBundle("images/icon4.png"),
                                    Value = "Circle"
                                },
                            new RotatingWheelSettings.WheelSliceValue
                                {
                                    Image = UIImage.FromBundle("images/icon5.png"),
                                    Value = "Circle"
                                },
                            new RotatingWheelSettings.WheelSliceValue
                                {
                                    Image = UIImage.FromBundle("images/icon6.png"),
                                    Value = "Circle"
                                },
                            new RotatingWheelSettings.WheelSliceValue
                                {
                                    Image = UIImage.FromBundle("images/icon7.png"),
                                    Value = "Circle"
                                },
                        }
			}) {Center = new CGPoint(0, this.View.Bounds.GetMidY())};

            Add(rotatingWheel);
        }
    }
}

