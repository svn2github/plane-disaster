/*
 * Copyright 2006-2007 Justin Dearing
 * 
 * This file is part of PlaneDisaster.NET.
 * 
 * PlaneDisaster.NET is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; version 2 of the License.
 * 
 * PlaneDisaster.NET is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with PlaneDisaster.NET; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
 */

/*
 * Created by SharpDevelop.
 * Author:		Justin Dearing <zippy1981@gmail.com>
 * Date: 1/9/2007
 * Time: 12:48 AM
 */

using System;   
using System.Configuration;

namespace PlaneDisaster.Configuration
{
	/// <summary>
	/// An xml representation of a recent element.
	/// </summary>
	public sealed class RecentFileElement : ConfigurationElement
	{
		/// <summary>
		/// The full path of the recently opened file.
		/// </summary>
		[ConfigurationProperty("fileName", IsKey = true, IsRequired = true)]
		public string Name
		{
			get { return (string)this["fileName"]; }
			set { this["fileName"] = value; }
		}
		
		internal RecentFileElement() : base()
		{}
		
		internal RecentFileElement(string FileName)  : base()
		{
			this.Name = FileName;
		}
	}
	
}

