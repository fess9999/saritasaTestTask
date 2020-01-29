using Cummins.Model.Base;

namespace Cummins.Model.Documents
{
    public class TravelItem : Entity
    {
        public int OneWayMileage { get; set; }

        public int VehicleTrips { get; set; }

        public int AverageMpg { get; set; }
    }
}