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

using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Click2Cloud.Samples.AspNetCore.MvcMongoDb.Web.Models
{
    [BsonIgnoreExtraElements]
    public class Restaurants
    {
        [Required]
        [MinLength(4)]
        public string Name { get; set; }
        public string Address { get; set; }
        public int RestaurantId { get; set; }
        public string Cuisine { get; set; }

        public ObjectId _id { get; set; }
    }
}