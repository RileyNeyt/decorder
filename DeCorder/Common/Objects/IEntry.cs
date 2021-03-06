﻿using System;
using System.Collections.Generic;
using System.Text;

/* 
 * 
 * Decorder Test - Extracts files from a certain HDD
 * Copyright (C) 2007  Jan Boon
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 * 
 */

namespace Decorder
{
	public interface IEntry
	{
		IVolume Volume { get; }
		void Delete();
		void Move(IDirectory newparent, string newname);
		IDirectory Parent { get; set; }
		string Name { get; set; }
		DateTime Created { get; set; }
		DateTime Modified { get; set; }
		DateTime LastAccess { get; set; }
	}
}
