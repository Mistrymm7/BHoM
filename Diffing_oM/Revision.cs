/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2020, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using BH.oM.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using BH.oM.Reflection.Attributes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.oM.Diffing
{
    public class Revision : BHoMObject, IImmutable
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public Guid StreamId { get; }
        public Guid RevisionId { get; } = Guid.NewGuid();
        public string RevisionName { get; }
        public long Timestamp { get; } = DateTime.UtcNow.Ticks;
        public string Author { get; } = Environment.UserDomainName + "/" + Environment.UserName;
        public string Comment { get; }
        public IEnumerable<object> Objects { get; }

        [Description("Diffing settings for this Stream Revision. Hashes of objects contained in this stream will be computed based on these configs.")]
        public DiffConfig RevisionDiffConfing { get; }

        /***************************************************/
        /**** Constructor                               ****/
        /***************************************************/

        [Description("Creates new Stream Revision.")]
        [Input("objects", "Objects to be included in the Stream")]
        [Input("streamId", "Id of the Stream that owns this Revision.")]
        [Input("revisionDiffConfig", "If the Revision was produced via a diff of a previous one, diffing settings used. Otherwise null.")]
        [Input("revision", "If not specified, revision is initially set to 0")]
        [Input("comment", "Any comment to be added for this stream.")]
        public Revision(IEnumerable<object> objects, Guid streamId, DiffConfig revisionDiffConfig = null, string revisionName = null, string comment = null)
        {
            Objects = objects;

            StreamId = streamId;
            RevisionName = revisionName;
            Comment = comment;

            RevisionDiffConfing = revisionDiffConfig;
        }

        /***************************************************/
    }
}