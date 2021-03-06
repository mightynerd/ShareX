﻿#region License Information (GPL v3)

/*
    ShareX - A program that allows you to take screenshots and share any file type
    Copyright © 2007-2015 ShareX Developers

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ShareX.HelpersLib
{
    public class SplitContainerCustomSplitter : SplitContainer
    {
        [DefaultValue(true)]
        public bool DrawLineLeftSide { get; set; }

        [DefaultValue(true)]
        public bool DrawLineRightSide { get; set; }

        public SplitContainerCustomSplitter()
        {
            DrawLineLeftSide = true;
            DrawLineRightSide = true;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            Rectangle rect = SplitterRectangle;

            if (DrawLineLeftSide)
            {
                g.DrawLine(Pens.Black, rect.Left, rect.Top, rect.Left, rect.Bottom - 1);
            }

            if (DrawLineRightSide)
            {
                g.DrawLine(Pens.Black, rect.Right - 1, rect.Top, rect.Right - 1, rect.Bottom - 1);
            }
        }
    }
}