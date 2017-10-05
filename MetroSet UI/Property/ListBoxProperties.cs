﻿/**
 * MetroSet UI - MetroSet UI Framewrok
 * 
 * The MIT License (MIT)
 * Copyright (c) 2017 Narwin, https://github.com/N-a-r-w-i-n
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of 
 * this software and associated documentation files (the "Software"), to deal in the 
 * Software without restriction, including without limitation the rights to use, copy, 
 * modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, 
 * and to permit persons to whom the Software is furnished to do so, subject to the 
 * following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in 
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
 * INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
 * PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
 * CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE 
 * OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

using System.Drawing;

namespace MetroSet_UI.Property
{
    internal class ListBoxProperties
    {
        /// <summary>
        /// Gets or sets whether the control enabled.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets forecolor used by the control
        /// </summary>
        public Color ForeColor { get; set; }

        /// <summary>
        /// Gets or sets backcolor used by the control
        /// </summary>
        public Color BackColor { get; set; }

        /// <summary>
        /// Gets or sets selected item used by the control
        /// </summary>
        public Color SelectedItemColor { get; set; }

        /// <summary>
        /// Gets or sets selected item backcolor used by the control
        /// </summary>
        public Color SelectedItemBackColor { get; set; }

        /// <summary>
        /// Gets or sets hovered item used by the control
        /// </summary>
        public Color HoveredItemColor { get; set; }

        /// <summary>
        /// Gets or sets hovered item backcolor used by the control
        /// </summary>
        public Color HoveredItemBackColor { get; set; }

        /// <summary>
        /// Gets or sets disabled forecolor used by the control
        /// </summary>
        public Color DisabledForeColor { get; set; }

        /// <summary>
        /// Gets or sets disabled backcolor used by the control
        /// </summary>
        public Color DisabledBackColor { get; set; }

        /// <summary>
        /// Gets or sets border color used by the control
        /// </summary>
        public Color BorderColor { get; set; }

    }
}