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
// Created On:   2018/07/27 12:55
// Modified On:  2018/12/13 13:07
// Modified By:  Alexis

#endregion




using System;

namespace SuperMemoAssistant.Interop.SuperMemo.Core
{
  [Serializable]
  public class SMCollection
  {
    #region Constructors

    public SMCollection(string name,
                        string path)
      : this(name,
             path,
             DateTime.MinValue) { }

    public SMCollection(string   name,
                        string   path,
                        DateTime lastOpen)
    {
      Name     = name;
      Path     = path;
      LastOpen = lastOpen;
    }

    #endregion




    #region Properties & Fields - Public

    public string   Name     { get; set; }
    public string   Path     { get; set; }
    public DateTime LastOpen { get; set; }

    #endregion
  }
}
