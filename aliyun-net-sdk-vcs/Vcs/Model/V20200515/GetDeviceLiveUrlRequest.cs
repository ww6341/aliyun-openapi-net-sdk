/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Vcs;
using Aliyun.Acs.Vcs.Transform;
using Aliyun.Acs.Vcs.Transform.V20200515;

namespace Aliyun.Acs.Vcs.Model.V20200515
{
    public class GetDeviceLiveUrlRequest : RpcAcsRequest<GetDeviceLiveUrlResponse>
    {
        public GetDeviceLiveUrlRequest()
            : base("Vcs", "2020-05-15", "GetDeviceLiveUrl")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string outProtocol;

		private int? streamType;

		private string corpId;

		private string gbId;

		private string deviceId;

		public string OutProtocol
		{
			get
			{
				return outProtocol;
			}
			set	
			{
				outProtocol = value;
				DictionaryUtil.Add(BodyParameters, "OutProtocol", value);
			}
		}

		public int? StreamType
		{
			get
			{
				return streamType;
			}
			set	
			{
				streamType = value;
				DictionaryUtil.Add(BodyParameters, "StreamType", value.ToString());
			}
		}

		public string CorpId
		{
			get
			{
				return corpId;
			}
			set	
			{
				corpId = value;
				DictionaryUtil.Add(BodyParameters, "CorpId", value);
			}
		}

		public string GbId
		{
			get
			{
				return gbId;
			}
			set	
			{
				gbId = value;
				DictionaryUtil.Add(BodyParameters, "GbId", value);
			}
		}

		public string DeviceId
		{
			get
			{
				return deviceId;
			}
			set	
			{
				deviceId = value;
				DictionaryUtil.Add(BodyParameters, "DeviceId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetDeviceLiveUrlResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetDeviceLiveUrlResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
