﻿#region License & Metadata

// The MIT License (MIT)
// 
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the 
// Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// 
// 
// Created On:   2019/02/25 23:44
// Modified On:  2019/02/25 23:44
// Modified By:  Alexis

#endregion




using System;
using System.Globalization;
using System.Windows;
using FontAwesome5;
using SuperMemoAssistant.Plugins;
using SuperMemoAssistant.Sys.Windows.Data;

namespace SuperMemoAssistant.SMA.UI.Settings
{
  public class StartPauseIconPluginStatusConverter : OneWayValueConverter
  {
    #region Methods Impl

    /// <inheritdoc />
    public override object Convert(object      value,
                                   Type        targetType,
                                   object      parameter,
                                   CultureInfo culture)
    {
      if (!(value is PluginStatus pluginStatus))
        throw new ArgumentException($"{nameof(value)} must be of type {nameof(PluginStatus)}");

      switch (pluginStatus)
      {
        case PluginStatus.Starting:
        case PluginStatus.Connected:
        case PluginStatus.Stopping:
          return EFontAwesomeIcon.Solid_Pause;

        default:
          return EFontAwesomeIcon.Solid_Play;
      }
    }

    #endregion
  }
  
  public class UninstallPluginVisibilityConverter : OneWayValueConverter
  {
    #region Methods Impl

    /// <inheritdoc />
    public override object Convert(object      value,
                                   Type        targetType,
                                   object      parameter,
                                   CultureInfo culture)
    {
      if (!(value is bool isDevelopment))
        throw new ArgumentException($"{nameof(value)} must be of type bool");

      return isDevelopment
        ? Visibility.Collapsed
        : Visibility.Visible;
    }

    #endregion
  }
}
