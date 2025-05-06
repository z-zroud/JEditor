using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace JControls.Helper
{
    public class AttachPropertyHelper
    {
        #region CornerRadius
        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(AttachPropertyHelper), new PropertyMetadata(new CornerRadius(0)));

        public static void SetCornerRadius(UIElement element, CornerRadius value)
        {
            element.SetValue(CornerRadiusProperty, value);
        }

        public static CornerRadius GetCornerRadius(UIElement element)
        {
            return (CornerRadius)element.GetValue(CornerRadiusProperty);
        }
        #endregion

        #region Icon
        public static readonly DependencyProperty IconProperty = DependencyProperty.RegisterAttached("Icon", typeof(string), typeof(AttachPropertyHelper), new PropertyMetadata("/JControls;component/Styles/Images/default.svg"));

        public static void SetIcon(UIElement element, string value)
        {
            element.SetValue(IconProperty, value);
        }

        public static string GetIcon(UIElement element)
        {
            return (string)element.GetValue(IconProperty);
        }
        #endregion
    }
}
