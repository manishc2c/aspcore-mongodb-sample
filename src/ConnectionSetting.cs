#region Copyright ©2016, Click2Cloud Inc. - All Rights Reserved
/* ------------------------------------------------------------------- *
*                            Click2Cloud Inc.                          *
*                  Copyright ©2016 - All Rights reserved               *
*                                                                      *
* Apache 2.0 License                                                   *
* You may obtain a copy of the License at                              * 
* http://www.apache.org/licenses/LICENSE-2.0                           *
* Unless required by applicable law or agreed to in writing,           *
* software distributed under the License is distributed on an "AS IS"  *
* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express  *
* or implied. See the License for the specific language governing      *
* permissions and limitations under the License.                       *
*                                                                      *
* -------------------------------------------------------------------  */
#endregion Copyright ©2016, Click2Cloud Inc. - All Rights Reserved

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Click2Cloud.Samples.AspNetCore.MvcMongoDb
{
    public static class ConnectionSetting
    {
        //TODO: Provide Cluster IP of mongo db server 
        private static string mongoDBClusterIP = "172.30.30.215";

        internal static string CONNECTION_STRING
        {
            get
            {
                if (!(string.IsNullOrEmpty(MONGODB_USER) || string.IsNullOrEmpty(MONGODB_PASSWORD)
                || string.IsNullOrEmpty(mongoDBClusterIP) || string.IsNullOrEmpty(MONGODB_DATABASE)))
                {
                    string _connectionString = string.Format("mongodb://{0}:{1}@{2}:{3}/{4}", MONGODB_USER, MONGODB_PASSWORD,
                    mongoDBClusterIP, "27017", MONGODB_DATABASE);

                    return _connectionString;
                }
                else { throw new Exception("MongoDB Cluster IP is not set."); }
            }
        }

        private static string MONGODB_USER
        {
            get
            {
                if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("MONGODB_USER")))
                {
                    return Environment.GetEnvironmentVariable("MONGODB_USER");
                }

                return string.Empty;
            }
        }

        private static string MONGODB_PASSWORD
        {
            get
            {
                if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("MONGODB_PASSWORD")))
                {
                    return Environment.GetEnvironmentVariable("MONGODB_PASSWORD");
                }

                return string.Empty;
            }
        }

        internal static string MONGODB_DATABASE
        {
            get
            {
                if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("MONGODB_DATABASE")))
                {
                    return Environment.GetEnvironmentVariable("MONGODB_DATABASE");
                }

                return string.Empty;
            }
        }
    }
}
