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
using BH.oM.Quantities.Attributes;
using System.ComponentModel;

namespace BH.oM.Structure.MaterialFragments
{
    [Description("Generic isotropic material to be used for isotropic materials not yet explicitly supported")]
    public class GenericIsotropicMaterial : BHoMObject, IIsotropic
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Density]
        [Description("Density of the material as mass per volume")]
        public double Density { get; set; }

        [Ratio]
        [Description("Dynamic damping ratio")]
        public double DampingRatio { get; set; }

        [Ratio]
        [Description("Ratio between axial and transversal strain. Used together with YoungsModulus to derive the ShearModulus for isotropic materials")]
        public double PoissonsRatio { get; set; }

        [TemperThermalExpansionCoefficientature]
        [Description("The strain induced in the material per change of temprature")]
        public double ThermalExpansionCoeff { get; set; }

        [YoungsModulus]
        [Description("Modulus of elasticity of the material. Ratio between axial stress and axial strain.")]
        public double YoungsModulus { get; set; }

        [MassFraction]
        [Description("The amount of carbon generated by manufacturing of this Material as mass of carbon per mass of material")]
        public double EmbodiedCarbon { get; set; }

        /***************************************************/

    }
}
