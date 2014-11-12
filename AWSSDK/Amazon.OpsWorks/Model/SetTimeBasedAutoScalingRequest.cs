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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the SetTimeBasedAutoScaling operation.
    /// Specify the time-based auto scaling configuration for a specified instance. For more
    /// information,         see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-autoscaling.html">Managing
    /// Load            with Time-based and Load-based Instances</a>.
    /// 
    ///     
    /// <para>
    /// <b>Required Permissions</b>: To use this action, an IAM user must have a Manage permissions
    /// level for the stack, or an attached       policy that explicitly grants permissions.
    /// For more information on user permissions, see      <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class SetTimeBasedAutoScalingRequest : AmazonWebServiceRequest
    {
        private WeeklyAutoScalingSchedule _autoScalingSchedule;
        private string _instanceId;


        /// <summary>
        /// Gets and sets the property AutoScalingSchedule. 
        /// <para>
        /// An <code>AutoScalingSchedule</code> with the instance schedule.
        /// </para>
        /// </summary>
        public WeeklyAutoScalingSchedule AutoScalingSchedule
        {
            get { return this._autoScalingSchedule; }
            set { this._autoScalingSchedule = value; }
        }


        /// <summary>
        /// Sets the AutoScalingSchedule property
        /// </summary>
        /// <param name="autoScalingSchedule">The value to set for the AutoScalingSchedule property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetTimeBasedAutoScalingRequest WithAutoScalingSchedule(WeeklyAutoScalingSchedule autoScalingSchedule)
        {
            this._autoScalingSchedule = autoScalingSchedule;
            return this;
        }

        // Check to see if AutoScalingSchedule property is set
        internal bool IsSetAutoScalingSchedule()
        {
            return this._autoScalingSchedule != null;
        }


        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The instance ID.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }


        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">The value to set for the InstanceId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetTimeBasedAutoScalingRequest WithInstanceId(string instanceId)
        {
            this._instanceId = instanceId;
            return this;
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}