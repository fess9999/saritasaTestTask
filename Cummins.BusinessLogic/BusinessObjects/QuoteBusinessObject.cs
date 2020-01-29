using System.Collections.Generic;
using System.Linq;
using Cummins.Model.Documents;
using Cummins.Model.Items;

namespace Cummins.BusinessLogic.BusinessObjects
{
    public class QuoteBusinessObject : BusinessObject<Quote>
    {
        /// <summary>
        ///     PowercomItems
        /// </summary>
        /// <remarks>
        /// Use OfType to get items of the type you need.
        /// Use active caching if you call that prop more than once.
        /// </remarks>
        public List<PowercomItem> PowercomItems => Entity.Items.OfType<PowercomItem>().ToList();

        public List<UpfitItem> UpfitItems => Entity.Items.OfType<UpfitItem>().ToList();
    }
}