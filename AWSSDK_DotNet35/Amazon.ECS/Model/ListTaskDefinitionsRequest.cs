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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the ListTaskDefinitions operation.
    /// Returns a list of task definitions that are registered to your account. You can filter
    /// the results by family name with the <code>familyPrefix</code> parameter.
    /// </summary>
    public partial class ListTaskDefinitionsRequest : AmazonECSRequest
    {
        private string _familyPrefix;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property FamilyPrefix. 
        /// <para>
        /// The name of the family that you want to filter the <code>ListTaskDefinitions</code>
        /// results with. Specifying a <code>familyPrefix</code> will limit the listed task definitions
        /// to definitions that belong to that family.
        /// </para>
        /// </summary>
        public string FamilyPrefix
        {
            get { return this._familyPrefix; }
            set { this._familyPrefix = value; }
        }

        // Check to see if FamilyPrefix property is set
        internal bool IsSetFamilyPrefix()
        {
            return this._familyPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of task definition results returned by <code>ListTaskDefinitions</code>
        /// in paginated output. When this parameter is used, <code>ListTaskDefinitions</code>
        /// only returns <code>maxResults</code> results in a single page along with a <code>nextToken</code>
        /// response element. The remaining results of the initial request can be seen by sending
        /// another <code>ListTaskDefinitions</code> request with the returned <code>nextToken</code>
        /// value. This value can be between 1 and 100. If this parameter is not used, then <code>ListTaskDefinitions</code>
        /// returns up to 100 results and a <code>nextToken</code> value if applicable.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> value returned from a previous paginated <code>ListTaskDefinitions</code>
        /// request where <code>maxResults</code> was used and the results exceeded the value
        /// of that parameter. Pagination continues from the end of the previous results that
        /// returned the <code>nextToken</code> value. This value is <code>null</code> when there
        /// are no more results to return.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}