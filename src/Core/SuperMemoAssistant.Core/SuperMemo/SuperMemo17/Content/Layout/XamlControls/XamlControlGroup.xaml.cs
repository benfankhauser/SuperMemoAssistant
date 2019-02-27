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
// Created On:   2019/02/26 23:18
// Modified On:  2019/02/27 20:47
// Modified By:  Alexis

#endregion




using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using SuperMemoAssistant.SuperMemo.SuperMemo17.Content.Layout.XamlLayouts;

// ReSharper disable InconsistentNaming

namespace SuperMemoAssistant.SuperMemo.SuperMemo17.Content.Layout.XamlControls
{
  /// <summary>Interaction logic for XamlControlGroup.xaml</summary>
  public partial class XamlControlGroup : UserControl, INotifyPropertyChanged
  {
    #region Properties & Fields - Non-Public

    private readonly bool _displayMode;

    #endregion




    #region Constructors

    /// <inheritdoc />
    public XamlControlGroup()
    {
      _displayMode = true;

      InitializeComponent();
    }

    /// <param name="xamlLayout"></param>
    /// <param name="displayMode"></param>
    /// <inheritdoc />
    public XamlControlGroup(XamlLayout xamlLayout, bool displayMode = false)
    {
      _displayMode = displayMode;

      InitializeComponent();

      SetXamlLayout(xamlLayout);
    }

    #endregion


    
    public double ScaleX { get; set; } = 1.0;
    public double ScaleY { get; set; } = 1.0;



    #region Methods

    private void OnSizeChanged(object sender, SizeChangedEventArgs e)
    {
      if (_displayMode)
      {
        ScaleX = Math.Max(e.NewSize.Width * ScaleX / SuperMemoFrameSize.Width, 0.00001);
        ScaleY = Math.Max(e.NewSize.Height * ScaleY / SuperMemoFrameSize.Height, 0.00001);
      }
    }

    #endregion




    #region Events

    public event PropertyChangedEventHandler PropertyChanged;

    #endregion
  }
}
