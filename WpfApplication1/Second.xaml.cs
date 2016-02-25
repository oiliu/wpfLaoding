using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApplication1
{
    /// <summary>
    /// Second.xaml 的交互逻辑
    /// </summary>
    public partial class Second : Window
    {
        public Second()
        {
            InitializeComponent();
            //grid 里的每一个控件实现拖拽功能
            foreach (UIElement uiEle in LayoutRoot.Children)
            {
                if (uiEle is Button || uiEle is TextBox)
                {
                    uiEle.AddHandler(Button.MouseLeftButtonDownEvent, new MouseButtonEventHandler(Element_MouseLeftButtonDown), true);
                    uiEle.AddHandler(Button.MouseMoveEvent, new MouseEventHandler(Element_MouseMove), true);
                    uiEle.AddHandler(Button.MouseLeftButtonUpEvent, new MouseButtonEventHandler(Element_MouseLeftButtonUp), true);
                    continue;
                }
                uiEle.MouseMove += new MouseEventHandler(Element_MouseMove);
                uiEle.MouseLeftButtonDown += new MouseButtonEventHandler(Element_MouseLeftButtonDown);
                uiEle.MouseLeftButtonUp += new MouseButtonEventHandler(Element_MouseLeftButtonUp);
            }

            this.slider1.IsSnapToTickEnabled = true;
            //IsSnapToTickEnabled
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += HandleAnimationTick;
            timer.Start();
        }

        bool isContinued = false;
        private void HandleAnimationTick(object sender, EventArgs e)
        {
            if (isContinued)
            {
                SliderValueChange();
            }
        }

        private void Grid_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            //窗口拖动
            //base.DragMove();
        }

        #region Thumb拖拽控件

        private void DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            Canvas.SetLeft(thumb1, Canvas.GetLeft(thumb1) + e.HorizontalChange);
            Canvas.SetTop(thumb1, Canvas.GetTop(thumb1) + e.VerticalChange);
        }

        private void DragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {
            thumb1.Background = Brushes.White;
        }

        private void DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            thumb1.Background = Brushes.Red;
        }

        #endregion

        private void Window_SizeChanged_1(object sender, SizeChangedEventArgs e)
        {
            this.RectangleLinear.Width = this.ActualWidth;
        }

        #region grid里的每一个控件拖拽

        bool isDragDropInEffect = false;
        Point pos = new Point();

        void Element_MouseMove(object sender, MouseEventArgs e)
        {
            var x1 = 0.0;
            if (isDragDropInEffect)
            {
                FrameworkElement currEle = sender as FrameworkElement;
                double xPos = e.GetPosition(null).X - pos.X + currEle.Margin.Left;
                double yPos = e.GetPosition(null).Y - pos.Y + currEle.Margin.Top;
                currEle.Margin = new Thickness(xPos, yPos, 0, 0);
                x1 = pos.X;
                pos = e.GetPosition(null);
                this.labelText.Content =
                    "margin-left:" + currEle.Margin.Left
                    + ",xPos:" + xPos
                    + ",e.GetPosition(null).X:" + e.GetPosition(null).X
                    + ",pos:" + pos.X;
            }
        }

        void Element_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            FrameworkElement fEle = sender as FrameworkElement;
            isDragDropInEffect = true;
            pos = e.GetPosition(null);
            fEle.CaptureMouse();
            //fEle.Cursor = Cursors.Hand;
        }

        void Element_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (isDragDropInEffect)
            {
                FrameworkElement ele = sender as FrameworkElement;
                isDragDropInEffect = false;
                ele.ReleaseMouseCapture();
            }
        }

        #endregion

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SliderValueChange();
        }

        private void Button_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            SliderValueChange();
        }

        private void SliderValueChange()
        {
            int slider1Value = (int)this.slider1.Value;
            if (slider1Value < 100)
            {
                slider1Value++;
                this.slider1.Value = slider1Value;
            }
        }

        private void SliderValueChang()
        {
            int[] ii = new int[] { 3, 2, 4, 9, 5, 20, 11 };


        }
    }
}