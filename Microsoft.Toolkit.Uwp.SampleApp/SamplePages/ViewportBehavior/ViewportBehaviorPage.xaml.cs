﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.UI.Animations;
using Microsoft.Toolkit.Uwp.UI.Behaviors;
using Microsoft.Toolkit.Uwp.UI.Extensions;
using Microsoft.Xaml.Interactivity;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Microsoft.Toolkit.Uwp.SampleApp.SamplePages
{
    /// <summary>
    /// A page that shows how to use the viewport behavior.
    /// </summary>
    public sealed partial class ViewportBehaviorPage : Page, IXamlRenderListener
    {
        private readonly ObservableCollection<string> _logs = new ObservableCollection<string>();
        private Image _effectElement;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewportBehaviorPage"/> class.
        /// </summary>
        public ViewportBehaviorPage()
        {
            InitializeComponent();

            LogsItemsControl.ItemsSource = _logs;
        }

        public void OnXamlRendered(FrameworkElement control)
        {
            if (control.FindChildByName("EffectElement") is Image effectElement)
            {
                _effectElement = effectElement;
#if !HAS_UNO
                _effectElement.Blur(value: 10, duration: 0).Start();
#endif
            }

            if (control.FindChildByName("EffectElementHost") is FrameworkElement effectElementHost)
            {
                var behaviors = Interaction.GetBehaviors(effectElementHost);
                var viewportBehavior = behaviors.OfType<ViewportBehavior>().FirstOrDefault();
                if (viewportBehavior != null)
                {
                    viewportBehavior.EnteredViewport += EffectElementHost_EnteredViewport;
                    viewportBehavior.EnteringViewport += EffectElementHost_EnteringViewport;
                    viewportBehavior.ExitedViewport += EffectElementHost_ExitedViewport;
                    viewportBehavior.ExitingViewport += EffectElementHost_ExitingViewport;
                }
            }
        }

        private async void AddLog(string log)
        {
            _logs.Add(log);
            await Task.Yield(); // wait for layout updated.
            LogsScrollViewer.ChangeView(null, LogsScrollViewer.ScrollableHeight, null);
        }

        private void ClearLogsButton_Click(object sender, RoutedEventArgs e)
        {
            _logs.Clear();
        }

        private async void EffectElementHost_EnteredViewport(object sender, EventArgs e)
        {
            AddLog("Entered viewport");

            await _effectElement.Blur(value: 0, duration: 1500).StartAsync();
        }

        private void EffectElementHost_EnteringViewport(object sender, EventArgs e)
        {
            AddLog("Entering viewport");

            _effectElement.Source = new BitmapImage(new Uri("ms-appx:///Assets/ToolkitLogo.png"));
        }

        private async void EffectElementHost_ExitedViewport(object sender, EventArgs e)
        {
            AddLog("Exited viewport");

            _effectElement.Source = null;
            await _effectElement.Blur(value: 8, duration: 0).StartAsync();
        }

        private void EffectElementHost_ExitingViewport(object sender, EventArgs e)
        {
            AddLog("Exiting viewport");
        }
    }
}