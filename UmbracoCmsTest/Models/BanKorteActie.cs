using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UmbracoCmsTest.Models
{
    using Umbraco.ModelsBuilder;
    using Umbraco.Web;

    //[IgnorePropertyType("kaTitel")]
    public partial class BanKorteActie
    {
        ///<summary>
        /// KaTitel
        ///</summary>
        //[ImplementPropertyType("kaTitel")]
        public string CustomKaTitel
        {
            get
            {
                var givenTitle = this.GetPropertyValue<string>("kaTitel");
                return string.Format("Customized title --> {0} --> {0}Custom", givenTitle);
            }
        }
    }
}