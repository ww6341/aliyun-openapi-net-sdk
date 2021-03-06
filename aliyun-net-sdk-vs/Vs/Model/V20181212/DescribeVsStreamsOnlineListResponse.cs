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

namespace Aliyun.Acs.vs.Model.V20181212
{
	public class DescribeVsStreamsOnlineListResponse : AcsResponse
	{

		private string requestId;

		private int? pageNum;

		private int? pageSize;

		private int? totalNum;

		private int? totalPage;

		private List<DescribeVsStreamsOnlineList_LiveStreamOnlineInfo> onlineInfo;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? TotalNum
		{
			get
			{
				return totalNum;
			}
			set	
			{
				totalNum = value;
			}
		}

		public int? TotalPage
		{
			get
			{
				return totalPage;
			}
			set	
			{
				totalPage = value;
			}
		}

		public List<DescribeVsStreamsOnlineList_LiveStreamOnlineInfo> OnlineInfo
		{
			get
			{
				return onlineInfo;
			}
			set	
			{
				onlineInfo = value;
			}
		}

		public class DescribeVsStreamsOnlineList_LiveStreamOnlineInfo
		{

			private string domainName;

			private string appName;

			private string streamName;

			private string publishTime;

			private string publishUrl;

			private string publishDomain;

			private string publishType;

			private string transcoded;

			private string transcodeId;

			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
				}
			}

			public string AppName
			{
				get
				{
					return appName;
				}
				set	
				{
					appName = value;
				}
			}

			public string StreamName
			{
				get
				{
					return streamName;
				}
				set	
				{
					streamName = value;
				}
			}

			public string PublishTime
			{
				get
				{
					return publishTime;
				}
				set	
				{
					publishTime = value;
				}
			}

			public string PublishUrl
			{
				get
				{
					return publishUrl;
				}
				set	
				{
					publishUrl = value;
				}
			}

			public string PublishDomain
			{
				get
				{
					return publishDomain;
				}
				set	
				{
					publishDomain = value;
				}
			}

			public string PublishType
			{
				get
				{
					return publishType;
				}
				set	
				{
					publishType = value;
				}
			}

			public string Transcoded
			{
				get
				{
					return transcoded;
				}
				set	
				{
					transcoded = value;
				}
			}

			public string TranscodeId
			{
				get
				{
					return transcodeId;
				}
				set	
				{
					transcodeId = value;
				}
			}
		}
	}
}
