// Updated by XamlIntelliSenseFileGenerator 02.03.2023 15:18:07
#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D20DB5B11FC1F7E33030A80C74E2A8647551A9284A69B6844EF093132A71D9CF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using P3;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace P3
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 43 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox GetMyListBox;

#line default
#line hidden


#line 47 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement media;

#line default
#line hidden


#line 48 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider AudioSlider;

#line default
#line hidden


#line 49 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label timerLabel;

#line default
#line hidden


#line 50 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label timerLabel2;

#line default
#line hidden


#line 53 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PlayButton;

#line default
#line hidden


#line 54 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextSound;

#line default
#line hidden


#line 57 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider AudioVolume;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/P3;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 42 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenDirectory);

#line default
#line hidden
                    return;
                case 2:
                    this.GetMyListBox = ((System.Windows.Controls.ListBox)(target));

#line 43 "..\..\MainWindow.xaml"
                    this.GetMyListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.GetMyListBox_SelectionChanged);

#line default
#line hidden
                    return;
                case 3:
                    this.media = ((System.Windows.Controls.MediaElement)(target));

#line 47 "..\..\MainWindow.xaml"
                    this.media.MediaOpened += new System.Windows.RoutedEventHandler(this.media_MediaOpened);

#line default
#line hidden

#line 47 "..\..\MainWindow.xaml"
                    this.media.MediaEnded += new System.Windows.RoutedEventHandler(this.media_MediaEnded);

#line default
#line hidden

#line 47 "..\..\MainWindow.xaml"
                    this.media.MediaFailed += new System.EventHandler<System.Windows.ExceptionRoutedEventArgs>(this.media_MediaFailed);

#line default
#line hidden
                    return;
                case 4:
                    this.AudioSlider = ((System.Windows.Controls.Slider)(target));

#line 48 "..\..\MainWindow.xaml"
                    this.AudioSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.AudioSlider_ValueChanged);

#line default
#line hidden
                    return;
                case 5:
                    this.timerLabel = ((System.Windows.Controls.Label)(target));
                    return;
                case 6:
                    this.timerLabel2 = ((System.Windows.Controls.Label)(target));
                    return;
                case 7:

#line 52 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Back);

#line default
#line hidden
                    return;
                case 8:
                    this.PlayButton = ((System.Windows.Controls.Button)(target));

#line 53 "..\..\MainWindow.xaml"
                    this.PlayButton.Click += new System.Windows.RoutedEventHandler(this.Play);

#line default
#line hidden
                    return;
                case 9:
                    this.NextSound = ((System.Windows.Controls.Button)(target));

#line 54 "..\..\MainWindow.xaml"
                    this.NextSound.Click += new System.Windows.RoutedEventHandler(this.Next);

#line default
#line hidden
                    return;
                case 10:

#line 55 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Repeat);

#line default
#line hidden
                    return;
                case 11:

#line 56 "..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Accidentally);

#line default
#line hidden
                    return;
                case 12:
                    this.AudioVolume = ((System.Windows.Controls.Slider)(target));

#line 57 "..\..\MainWindow.xaml"
                    this.AudioVolume.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.AudioVolume_ValueChanged);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button repeat;
    }
}

