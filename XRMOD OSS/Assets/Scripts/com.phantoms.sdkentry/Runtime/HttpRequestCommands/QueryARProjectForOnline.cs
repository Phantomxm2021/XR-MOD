// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the SDKEntry.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using System.Threading.Tasks;

namespace SDKEntry.Runtime.DataRequest
{
    public  readonly struct QueryARProjectForOnline<T> : IHttpRequestCommand<T>
    {
        private readonly QueryParameter queryParameter;
        private const string _CONST_PLATFORM_TYPE_STR = "platform_type";
        private const string _CONST_PROJECT_UID_STR = "project_uid";

        public QueryARProjectForOnline(QueryParameter _queryParameter)
        {
            queryParameter = _queryParameter;
        }

        public async Task<T> Execute()
        {
            return await NetworkRequestUtil.SendRequest<T>(_apiUrl: queryParameter.URL,
                _method: ConstKey.CONST_REQUEST_GET,
                _timeout: queryParameter.Timeout,
                _token: queryParameter.Token,
                _params: new Dictionary<string, string>
                {
                    {_CONST_PROJECT_UID_STR, queryParameter.ProjectUid},
                    {_CONST_PLATFORM_TYPE_STR, queryParameter.Platform}
                });
        }
    }
}