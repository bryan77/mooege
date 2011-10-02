﻿/*
 * Copyright (C) 2011 mooege project
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
 */

using Mooege.Net.GS.Message.Fields;
using Mooege.Net.GS.Message;

namespace Mooege.Core.Common.Items.ItemCreation
{
    class DefaultAttributeCreator : IItemAttributeCreator
    {
        public void CreateAttributes(Item item)
        {
            item.Attributes[GameAttribute.Item_Quality_Level] = 1;
            item.Attributes[GameAttribute.Seed] = unchecked((int)2286800181);
//             item.AttributeList.Add(new NetAttributeKeyValue { Attribute = GameAttribute.Attributes[0x0115], Int = 1, }); // Item_Quality_Level 
//             item.AttributeList.Add(new NetAttributeKeyValue{ Attribute = GameAttribute.Attributes[0x0125], Int = unchecked((int)2286800181),}); // Seed            
        }
    }
}
