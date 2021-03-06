/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the GetUsagePlanKeys operation.
    /// Gets all the usage plan keys representing the API keys added to a specified usage
    /// plan.
    /// </summary>
    public partial class GetUsagePlanKeysRequest : AmazonAPIGatewayRequest
    {
        private int? _limit;
        private string _nameQuery;
        private string _position;
        private string _usagePlanId;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// A query parameter specifying the maximum number usage plan keys returned by the GET
        /// request.
        /// </para>
        /// </summary>
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NameQuery. 
        /// <para>
        /// A query parameter specifying the name of the to-be-returned usage plan keys.
        /// </para>
        /// </summary>
        public string NameQuery
        {
            get { return this._nameQuery; }
            set { this._nameQuery = value; }
        }

        // Check to see if NameQuery property is set
        internal bool IsSetNameQuery()
        {
            return this._nameQuery != null;
        }

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// A query parameter specifying the zero-based index specifying the position of a usage
        /// plan key.
        /// </para>
        /// </summary>
        public string Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null;
        }

        /// <summary>
        /// Gets and sets the property UsagePlanId. 
        /// <para>
        /// The Id of the <a>UsagePlan</a> resource representing the usage plan containing the
        /// to-be-retrieved <a>UsagePlanKey</a> resource representing a plan customer.
        /// </para>
        /// </summary>
        public string UsagePlanId
        {
            get { return this._usagePlanId; }
            set { this._usagePlanId = value; }
        }

        // Check to see if UsagePlanId property is set
        internal bool IsSetUsagePlanId()
        {
            return this._usagePlanId != null;
        }

    }
}