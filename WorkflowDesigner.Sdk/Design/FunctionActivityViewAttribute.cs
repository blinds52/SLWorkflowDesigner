﻿/*
The MIT License (MIT)
Copyright (c) 2012 Denys Vuika

Permission is hereby granted, free of charge, to any person obtaining a copy of this software 
and associated documentation files (the "Software"), to deal in the Software without restriction, 
including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, 
subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, 
DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, 
ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.ComponentModel.Composition;

namespace WorkflowDesigner.Sdk.Design
{
  [MetadataAttribute]
  [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
  public sealed class FunctionActivityViewAttribute : ExportAttribute
  {
    public Type TargetType { get; private set; }
    public string Caption { get; private set; }
    public bool IsToolboxItem { get; set; }
    
    public FunctionActivityViewAttribute(Type targetType, string caption)
      : base(typeof(FunctionActivityView))
    {
      TargetType = targetType;
      Caption = caption;
      IsToolboxItem = true;
    }
  }
}
