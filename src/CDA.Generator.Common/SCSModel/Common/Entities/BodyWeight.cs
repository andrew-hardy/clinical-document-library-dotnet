﻿/*
 * Copyright 2013 NEHTA
 *
 * Licensed under the NEHTA Open Source (Apache) License; you may not use this
 * file except in compliance with the License. A copy of the License is in the
 * 'license.txt' file, which should be provided with this work.
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations
 * under the License.
 */

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using JetBrains.Annotations;
using Nehta.VendorLibrary.CDA.Common;
using Nehta.VendorLibrary.Common;

namespace Nehta.VendorLibrary.CDA.SCSModel.Common
{
    /// <summary>
    /// This class is designed to encapsulate the properties within a CDA document that make up 
    /// an body weight
    /// </summary>
    [Serializable]
    [DataContract]
    public class BodyWeight
    {
        #region properties

        /// <summary>
        /// Quantity
        /// </summary>
        [CanBeNull]
        [DataMember]
        public Quantity Quantity { get; set; }

        /// <summary>
        /// Date / Time that the weight was recorded
        /// </summary>
        [CanBeNull]
        [DataMember]
        public ISO8601DateTime BodyWeightObservationTime { get; set; }
        #endregion

        #region Constructors
        internal BodyWeight()
        {
        }
        #endregion

        #region Validation
        /// <summary>
        /// Validates this Body Weight
        /// </summary>
        /// <param name="path">The path to this object as a string</param>
        /// <param name="messages">the validation messages to date, these may be added to within this method</param>
        public void Validate(string path, List<ValidationMessage> messages)
        {
            var vb = new ValidationBuilder(path, messages);

            if (vb.ArgumentRequiredCheck("Quantity", Quantity))
            {
              Quantity.Validate(vb.Path + "Quantity", messages);
            }
            vb.ArgumentRequiredCheck("BodyWeightObservationTime", BodyWeightObservationTime);
        }

        #endregion
    }
}
