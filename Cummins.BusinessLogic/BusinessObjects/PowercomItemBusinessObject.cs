using Cummins.Model.Items;

namespace Cummins.BusinessLogic.BusinessObjects
{
    public class PowercomItemBusinessObject : BusinessObject<PowercomItem>
    {
        /// <summary>
        ///     ExtendedCost
        /// </summary>
        /// <remarks>
        /// Use decorator pattern to add business-logic behavior.
        /// This example shows the proper way of getting extended cost.
        /// </remarks>
        public decimal ExtendedCost
        {
            get
            {
                Entity.ExtendedCost = Entity.Cost * Entity.Quantity;
                return Entity.ExtendedCost;
            }
        }
    }
}