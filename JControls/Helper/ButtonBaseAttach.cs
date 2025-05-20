using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace JControls.Helper
{
    public class ButtonBaseAttach
    {
        #region CornerRadius
        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(ButtonBaseAttach), new PropertyMetadata(new CornerRadius(0)));

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
        public static readonly DependencyProperty IconProperty = DependencyProperty.RegisterAttached("Icon", typeof(string), typeof(ButtonBaseAttach), new PropertyMetadata("/JControls;component/Styles/Images/default.svg"));

        public static void SetIcon(UIElement element, string value)
        {
            element.SetValue(IconProperty, value);
        }

        public static string GetIcon(UIElement element)
        {
            return (string)element.GetValue(IconProperty);
        }
        #endregion

        #region IconSize
        public static readonly DependencyProperty IconSizeProperty = DependencyProperty.RegisterAttached("IconSize", typeof(double), typeof(ButtonBaseAttach), new PropertyMetadata(16.0));
        public static void SetIconSize(UIElement element, double value)
        {
            element.SetValue(IconSizeProperty, value);
        }

        public static double GetIconSize(UIElement element)
        {
            return (double)element.GetValue(IconSizeProperty);
        }
        #endregion

        #region Geometry
        public static readonly DependencyProperty GeometryProperty = DependencyProperty.RegisterAttached("Geometry", typeof(Geometry), typeof(ButtonBaseAttach), new PropertyMetadata(default(Geometry)));
        public static void SetGeometry(UIElement element, Geometry value)
        {
            element.SetValue(GeometryProperty, value);
        }
        public static Geometry GetGeometry(UIElement element)
        {
            return (Geometry)element.GetValue(GeometryProperty);
        }
        #endregion

        #region GeometrySize
        public static readonly DependencyProperty GeometrySizeProperty = DependencyProperty.RegisterAttached("GeometrySize", typeof(double), typeof(ButtonBaseAttach), new PropertyMetadata(16.0));
        public static void SetGeometrySize(UIElement element, double value)
        {
            element.SetValue(GeometrySizeProperty, value);
        }
        public static double GetGeometrySize(UIElement element)
        {
            return (double)element.GetValue(GeometrySizeProperty);
        }
        #endregion
    }
}
