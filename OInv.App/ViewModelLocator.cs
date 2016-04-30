using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;

namespace OInv.App
{
    public static class ViewModelLocator
    {
        public static bool GetAutoWireModel(DependencyObject obj)
        {
            return (bool)obj.GetValue(AutoWireModelProperty);
        }

        public static void SetAutoWireModel(DependencyObject obj, bool value)
        {
            obj.SetValue(AutoWireModelProperty, value);
        }

        // Using a DependencyProperty as the backing store for AutoWireModel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AutoWireModelProperty =
            DependencyProperty.RegisterAttached("AutoWireModel",
            typeof(bool), typeof(ViewModelLocator), new PropertyMetadata(false, AutoWireViewModelChanged));

        private static void AutoWireViewModelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (DesignerProperties.GetIsInDesignMode(d)) return;
            var viewType = d.GetType();
            var viewTypeName = viewType.FullName;
            var viewModelTypeName = viewTypeName + "Model";
            var viewModelType = Type.GetType(viewModelTypeName);
            var viewModel = Activator.CreateInstance(viewModelType);
            ((FrameworkElement)d).DataContext = viewModel;
        }


    }
}