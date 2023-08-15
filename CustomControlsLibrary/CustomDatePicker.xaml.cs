using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomControlsLibrary
{
    /// <summary>
    /// Interaction logic for CustomDatePicker.xaml
    /// </summary>
    public partial class CustomDatePicker : UserControl
    {
        #region Dep Properties




        public CustomCalendar Calendar
        {
            get { return (CustomCalendar)GetValue(CalendarProperty); }
            set { SetValue(CalendarProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Calendar.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CalendarProperty;



        #region Styles

        #endregion

        #region Fields



        #endregion

        #region Properties





        #endregion

        #endregion
        #region Static Ctor

        static CustomDatePicker()
        {
            CalendarProperty =
             DependencyProperty.Register("Calendar", typeof(CustomCalendar),
                 typeof(CustomDatePicker), new PropertyMetadata(null, OnCalendarPropertyChanged));

            #region Styles

            #endregion
        }
      
        #endregion

        #region Ctor

        public CustomDatePicker()
        {
            InitializeComponent();            

        }





        #endregion



        #region Methods

        #region On Properties Changed
        private static void OnCalendarPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as CustomDatePicker).Popup.Child = (CustomCalendar)e.NewValue;
        }

        #endregion

        #endregion
    }
}
